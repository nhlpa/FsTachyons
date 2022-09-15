open System
open System.IO
open System.Net.Http
open System.Text.RegularExpressions

//
// Tachyons
let buildCdnUrl = "https://raw.githubusercontent.com/tachyons-css/tachyons/master/css/tachyons.css"
let minifiedCdnUrl = "https://raw.githubusercontent.com/tachyons-css/tachyons/master/css/tachyons.min.css"
let http = new HttpClient()
let rawCss = http.GetStringAsync(buildCdnUrl).Result

//
// Extract classes
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
    |> Seq.distinctBy (fun (_, className) -> className)
    |> Seq.map (fun (rule, className) ->
        let fnName = className.Replace("-", "_")
        // let fnName = "``" + className + "``"
        let fnName' = if List.contains fnName reservedWords then fnName + "'" else fnName
        sprintf "    /// %s\n    let %s = TachyonsClass \"%s\"\n" rule fnName' className)

//
// Output module templates
let tachyonsUrlModule =
        sprintf
            "module TachyonsUrl =
    /// Tachyons build CDN reference
    let build = \"%s\"

    /// Tachyons minified CDN reference
    let minified = \"%s\""
            buildCdnUrl
            minifiedCdnUrl


let tachyonsClassesModule =
    sprintf "module Tac =\n%s" (String.Join("\n", functionSpecs))

//
// Write class function file
let fsTachyonsSrcFile = FileInfo(Path.Join(__SOURCE_DIRECTORY__, "../src/FsTachyons/Tac.fs"))

File.WriteAllText(
    fsTachyonsSrcFile.FullName,
    String.Join("\n\n", "namespace FsTachyons", "open System", tachyonsUrlModule, tachyonsClassesModule))
