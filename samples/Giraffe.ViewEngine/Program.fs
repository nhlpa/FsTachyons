module Program

open Giraffe.ViewEngine
open FsTachyons

let divider =
    hr [ _class (tac [ Tac.bt; Tac.b__red ]) ]

let master (pageTitle : string) (content : XmlNode list) =
    html [ _lang "en" ] [
        head [] [
            title [] [ rawText pageTitle ]
            // Include Tachyons CDN reference
            link [ _rel "stylesheet"; _href TachyonsUrl.minified ]
        ]
        body [] content
    ]

let homepage =
    master "Homepage" [
        h1 [ _class (tac [ Tac.f1; Tac.red ]) ] [ rawText "Homepage" ]
        divider
        p [] [ rawText "Lorem ipsum dolor sit amet."]
    ]

let [<EntryPoint>] main _ =
    let html = RenderView.AsString.htmlNode homepage
    printfn "%s" html
    0