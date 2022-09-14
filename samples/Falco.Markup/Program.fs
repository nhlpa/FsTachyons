﻿module Program

open Falco.Markup
open FsTachyons

let divider =
    Elem.hr [ Attr.class' (tac (bt + b__red) ) ]

let master (title : string) (content : XmlNode list) =
    Elem.html [ Attr.lang "en" ] [
        Elem.head [] [
            Elem.title [] [ Text.raw title ]
        ]
        Elem.body [] content
    ]

let homepage =
    master "Homepage" [
        Elem.h1 [ Attr.class' (tac (f1 + red)) ] [ Text.raw "Homepage" ]
        divider
        Elem.p [] [ Text.raw "Lorem ipsum dolor sit amet."]
    ]

let [<EntryPoint>] main _ =
    let html = renderHtml homepage
    printfn "%s" html
    0