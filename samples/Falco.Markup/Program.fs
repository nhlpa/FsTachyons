module Program

open Falco.Markup
open FsTachyons
open FsTachyons.Tac

let button =
    Elem.a [ Attr.class' (tac [ f6; link; dim; br1; ph3; pv2; dib; white; bg_black ]) ]
           [ Text.raw "Button Text" ]

let divider =
    Elem.hr [ Attr.class' (tac [ bt; b__red ]) ]

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
        Elem.h1 [ Attr.class' (tac [ f1; red ]) ] [ Text.raw "Homepage" ]
        divider
        Elem.p [] [ Text.raw "Lorem ipsum dolor sit amet."]
        button
    ]

let [<EntryPoint>] main _ =
    let html = renderHtml homepage
    printfn "%s" html
    0