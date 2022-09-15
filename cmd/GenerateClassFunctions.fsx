open System
open System.IO
open System.Net.Http
open System.Text.RegularExpressions

//
// Tachyons
let buildCdnUrl = "https://unpkg.com/tachyons/css/tachyons.css"
let minifiedCdnUrl = "https://unpkg.com/tachyons/css/tachyons.min.css"
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
    // trim required to catch nested selectors
    |> Seq.map (fun (x : string) -> x.TrimStart())
    // filter more specifically for valid css class name(s), include element
    // selectors for now
    |> Seq.filter (fun x -> Regex.IsMatch(x, @"^[\.a-z]-?[_a-zA-Z]+[_a-zA-Z0-9-, \.]* {.+}"))
    // extract rule with curlies, and yield copy for each individual class selector
    |> Seq.collect (fun x ->
        let ruleStartIndex = x.IndexOf("{")
        let rule = x.Substring(ruleStartIndex)

        x.Substring(0, ruleStartIndex).Trim().Split(",")
        |> Seq.map (fun (x : string) -> x.Trim())
        |> Seq.filter (fun (selector : string) -> selector.StartsWith(".") && not(selector.Contains(" ")))
        |> Seq.map (fun x -> x.Substring(1), rule))
    // to remove duplicates (i.e., ".pre"), use the last definition
    |> Seq.groupBy (fun (selector, _) -> selector)
    |> Seq.map (fun (_, dupes) -> dupes |> Seq.rev |> Seq.head)
    // clean selector name into f# safe style, output function definition
    |> Seq.map (fun (selector, rule) ->
        let fnName = selector.Replace("-", "_")
        let fnName' = if List.contains fnName reservedWords then fnName + "'" else fnName
        sprintf "    /// %s\n    let %s = TachyonsClass \"%s\"\n" rule fnName' selector)

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
    String.Join("\n\n", "namespace FsTachyons", tachyonsUrlModule, tachyonsClassesModule))
