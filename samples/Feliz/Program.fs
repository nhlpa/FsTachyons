module Program

open Feliz
open FsTachyons
open FsTachyons.Tac

let button =
    Html.button [ prop.className [ tac [ f6; link; dim; br1; ph3; pv2; dib; white; bg_black ] ]
                  prop.text "Button Text" ]

let divider =
    Html.hr [ prop.className [ tac [ bt; b__red ] ] ]

let master (title : string) (content : ReactElement seq) =
    Html.html [
        prop.lang "en"
        prop.children [
            Html.head [
                Html.title [ prop.text title ]
                // Include Tachyons CDN reference
                Html.link [ prop.rel "stylesheet"; prop.href TachyonsUrl.minified ]
            ]
            Html.body content
        ]
    ]

let homepage =
    master "Homepage" [
        Html.h1 [ prop.className [ tac [ f1; red ] ]; prop.text "Homepage" ]
        divider
        Html.p [ prop.text "Lorem ipsum dolor sit amet."]
    ]

let [<EntryPoint>] main _ =
    let html = ReactDOMServer.renderToString homepage
    printfn "%s" html
    0