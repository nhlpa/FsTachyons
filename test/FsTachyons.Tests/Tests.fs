namespace FsTachyons

open System
open FsUnit.Xunit
open Xunit

module Tests =
    [<Fact>]
    let ``Can create new TachyonsClass`` () =
        let clsName = "FsTachyons"
        let cls = TachyonsClass clsName
        let clsStr (TachyonsClass x) = x
        clsStr cls |> should equal clsName

    [<Fact>]
    let ``tac function should return valid class string`` () =
        let clsName = "FsTachyons"
        let cls = TachyonsClass clsName
        tac cls |> should equal clsName

    [<Fact>]
    let ``Can combine ad hoc TachyonsClass's`` () =
        let cls1 = TachyonsClass "a"
        let cls2 = TachyonsClass "b"

        cls1 + cls2 |> tac |> should equal "a b"

    [<Fact>]
    let ``Can combine built-in TachyonsClass's`` () =
        mb2 + ttu + f3 + f2_l + silver
        |> tac
        |> should equal "mb2 ttu f3 f2-l silver"