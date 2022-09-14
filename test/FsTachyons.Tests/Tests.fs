namespace FsTachyons

open System
open FsUnit.Xunit
open Xunit

module Tests =
    [<Fact>]
    let ``Can create new TachyonsClass`` () =
        let clsName = "FsTachyons"
        let cls = TachyonsClass clsName
        let (TachyonsClass clsStr) = cls
        clsStr |> should equal clsName

    [<Fact>]
    let ``tac function should return valid class string`` () =
        let clsName = "FsTachyons"
        let cls = TachyonsClass clsName
        let (TachyonsClass clsStr) = cls
        clsStr |> should equal clsName

    [<Fact>]
    let ``Can combine ad hoc TachyonsClass's`` () =
        let cls1 = TachyonsClass "a"
        let cls2 = TachyonsClass "b"

        cls1 + cls2 |> string |> should equal "a b"
        tac [ cls1; cls2 ] |> should equal "a b"

    [<Fact>]
    let ``Can combine built-in TachyonsClass's`` () =
        tac [ Tac.mb2; Tac.ttu; Tac.f3; Tac.f2_l; Tac.silver ]
        |> should equal "mb2 ttu f3 f2-l silver"