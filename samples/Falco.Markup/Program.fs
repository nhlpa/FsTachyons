module Program

open Falco.Markup
open FsTachyons

let x =
    Elem.a [ Attr.class' (tac [ Tac.f6; Tac.link; Tac.dim; Tac.br1; Tac.ph3; Tac.pv2; Tac.dib; Tac.white; Tac.bg_black ]) ]
           [ Text.raw "Button Text" ]

let divider =
    Elem.hr [ Attr.class' (tac [ Tac.bt; Tac.b__red ]) ]

let master (title : string) (content : XmlNode list) =
    Elem.html [ Attr.lang "en" ] [
        Elem.head [] [
            Elem.title [] [ Text.raw title ]
            // Include Tachyons CDN reference
            Elem.link [ Attr.rel "stylesheet"; Attr.href TachyonsUrl.minified ]
        ]
        Elem.body [] content
    ]

let homepage =
    master "Homepage" [
        Elem.h1 [ Attr.class' (tac [ Tac.f1; Tac.red ]) ] [ Text.raw "Homepage" ]
        divider
        Elem.p [] [ Text.raw "Lorem ipsum dolor sit amet."]
    ]

let [<EntryPoint>] main _ =
    let html = renderHtml homepage
    printfn "%s" html
    0