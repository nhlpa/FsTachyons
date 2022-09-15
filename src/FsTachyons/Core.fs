namespace FsTachyons

open System

type TachyonsClass =  TachyonsClass of string with
    override x.ToString() : string =
        let (TachyonsClass str) = x
        str

    static member (+) (a : TachyonsClass, b : TachyonsClass) =
        TachyonsClass (String.Join(" ", [string a; string b]))

[<AutoOpen>]
module Core =
    let tac (tachyonsClasses : TachyonsClass seq) : string =
        tachyonsClasses
        |> Seq.map string
        |> fun x -> String.Join(" ", x)