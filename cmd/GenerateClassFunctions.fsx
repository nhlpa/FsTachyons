open System
open System.IO
open System.Net.Http
open System.Text.RegularExpressions

let buildCdnUrl = "https://raw.githubusercontent.com/tachyons-css/tachyons/master/css/tachyons.css"
let minifiedCdnUrl = "https://raw.githubusercontent.com/tachyons-css/tachyons/master/css/tachyons.min.css"

let tachyonsUrlModule =
        sprintf
            "module TachyonsUrl =
    /// Tachyons build CDN reference
    let build = \"%s\"

    /// Tachyons minified CDN reference
    let minified = \"%s\""
            buildCdnUrl
            minifiedCdnUrl

let http = new HttpClient()

let rawCss = http.GetStringAsync(buildCdnUrl).Result

let classNames =
    rawCss.Split("\n")
    |> Seq.map (fun (x : string) -> x.TrimStart()) // trim required to catch nested selectors
    |> Seq.filter (fun x -> x.StartsWith(".")) // first reduce to "likely" selectors
    |> Seq.filter (fun x -> Regex.IsMatch(x, @"^\.-?[_a-zA-Z]+[_a-zA-Z0-9-]* {")) // filter more specifically for valid css class names
    |> Seq.map (fun x ->
        let startIndex = 1
        let ruleStartIndex = x.IndexOf("{") - 1
        let endIndex =
            let classSepIndex = x.IndexOf(",") |> fun x -> if x > ruleStartIndex then -1 else x
            let pseudoIndex = x.IndexOf(":") |> fun x -> if x > ruleStartIndex then -1 else x
            if classSepIndex > 0 then classSepIndex
            elif pseudoIndex > 0 then pseudoIndex
            else ruleStartIndex
        x, x.Substring(startIndex, endIndex).Trim())

let functionSpecs =
    let reservedWords =
        [ "abstract"; "and"; "as"; "assert"; "base"; "begin"; "class"; "default"; "delegate"; "do"
          "done"; "downcast"; "downto"; "elif"; "else"; "end"; "exception"; "extern"; "false"
          "finally"; "fixed"; "for"; "fun"; "function"; "global"; "if"; "in"; "inherit"; "inline"
          "interface"; "internal"; "lazy"; "let"; "let!"; "match"; "match!"; "member"; "module"
          "mutable"; "namespace";"new";"not";"null";"of";"open";"or";"override";"private"
          "public"; "rec"; "return"; "return!"; "select"; "static"; "struct"; "then"; "to"
          "true"; "try"; "type"; "upcast"; "use"; "use!"; "val"; "void"; "when"; "while"; "with"
          "yield"; "yield!"; "const"; "asr"; "land"; "lor"; "lsl"; "lsr"; "lxor"; "mod"; "sig"
          "break"; "checked"; "component"; "const"; "constraint"; "continue"; "event"; "external"
          "include"; "mixin"; "parallel"; "process"; "protected"; "pure"; "sealed"; "tailcall"
          "trait"; "virtual" ]

    classNames
    |> Seq.distinctBy (fun (_, className) -> className)
    |> Seq.map (fun (rule, className) ->
        let fnName = className.Replace("-", "_")
        let fnName' = if List.contains fnName reservedWords then fnName + "'" else fnName
        sprintf "/// %s\nlet %s = TachyonsClass \"%s\"\n" rule fnName' className)

let cssClassFunctions =
    String.Join("\n", functionSpecs)

let fsTachyonsSrcFile = FileInfo(Path.Join(__SOURCE_DIRECTORY__, "../src/FsTachyons/FsTachyons.fs"))
let fsTachyonsSrcLines = File.ReadAllLines(fsTachyonsSrcFile.FullName)

let mutable continueLooping = true
let mutable index = 0

while continueLooping do
    let line = fsTachyonsSrcLines.[index]
    if String.Equals(line, "// Tachyons CSS Functions", StringComparison.OrdinalIgnoreCase) then
        continueLooping <- false
    else
        index <- index + 1

let moduleHead = String.Join("\n", fsTachyonsSrcLines[0..index])

let moduleGenerated =  String.Join("\n\n", moduleHead, tachyonsUrlModule, cssClassFunctions)

File.WriteAllText(fsTachyonsSrcFile.FullName, moduleGenerated)
