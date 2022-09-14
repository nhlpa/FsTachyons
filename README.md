# FsTachyons

[![NuGet Version](https://img.shields.io/nuget/v/FsTachyons.svg)](https://www.nuget.org/packages/FsTachyons)
[![build](https://github.com/nhlpa/FsTachyons/actions/workflows/build.yml/badge.svg)](https://github.com/nhlpa/FsTachyons/actions/workflows/build.yml)

```fsharp
open Falco.Markup
open FsTachyons
open FsTachyons.Tac

Elem.h1 [ Attr.class' (tac [ f3; f1_m; f_headline_l ])]
        [ Text.raw "Hello World!" ]
// Produces: <h1 class="f3 f1-m f-headline-l">Title</h1>
```

> Note: [Falco.Markup](https://github.com/pimbrouwers/Falco.Markup) is included for _demonstration purposes only_.

[FsTachyons](https://github.com/nhlpa/FsTachyons) is an F# API for the functional CSS library [Tachyons](https://tachyons.io/), functional CSS for humans.

## Key Features

- Automatically helps build complex class strings, via `tac []`.
- Facilitates the discoverability of Tachyons classes.
- Use native F# to produce class strings.
- Easily extended by creating custom classes.

## Design Goals

- Provide discoverable functions for **_all_** Tachyons classes.
- Can be integrated into **_any_** F# markup DSL.
- Easily learned by someone with knowledge of Tachyons.

## Overview

FsTachyons maps all of the Tachyons CSS classes to functions in the `Tac` module. These types can be combined together to form class strings using the `tac []` helper function, or composed using the `+` operator.

To escape the characters which are valid in the CSS spec, but not F#, the following augmentations to the Tachyons class are made:
- Leading `.` is removed (i.e., `.red` becomes `red`).
- `-` are replaced by `_` (i.e., `.b--red` becomes `b__red`).

## Usage with [Falco.Markup](https://github.com/pimbrouwers/Falco.Markup)

Libraries like Falco.Markup, that explicit modules for elements & attributes, allow us to import the `FsTachyons.Tac` which make class string definitions more terse.

```fsharp
open Falco.Markup
open FsTachyons
open FsTachyons.Tac

// <p class="measure lh-copy">Lorem ipsum</p>
Elem.p [ Attr.class' (tac [measure; lh_copy ])]
       [ Text.raw "Lorem ipsum" ]

// <h1 class="f3 f1-m f-headline-l">Title</h1>
Elem.h1 [ Attr.class' (tac [ f3; f1_m; f_headline_l ])]
        [ Text.raw "Hello World!" ]

// <a class="f6 link dim br1 ph3 pv2 mb2 dib white bg-black" href="#0">Button Text</a>
Elem.a [ Attr.class' (tac [ f6; link; dim; br1; ph3; pv2; dib; white; bg_black ]) ]
       [ Text.raw "Button Text" ]
```

## Usage with [Giraffe.ViewEngine](https://github.com/giraffe-fsharp/Giraffe.ViewEngine)

With Giraffe's approach to HTML generation, we must reference the class functions via the `Tac` module.

```fsharp
open FsTachyons
open Giraffe.ViewEngine

// <p class="measure lh-copy">Lorem ipsum</p>
p [ _class (tac [Tac.measure; Tac.lh_copy ])]
  [ rawText "Lorem ipsum" ]

// <h1 class="f3 f1-m f-headline-l">Title</h1>
h1 [ _class (tac [ Tac.f3; Tac.f1_m; Tac.f_headline_l ])]
   [ rawText "Hello World!" ]

// <a class="f6 link dim br1 ph3 pv2 mb2 dib white bg-black" href="#0">Button Text</a>
a [ _class (tac [ Tac.f6; Tac.link; Tac.dim; Tac.br1; Tac.ph3; Tac.pv2; Tac.dib; Tac.white; Tac.bg_black ]) ]
  [ rawText "Button Text" ]
```

## Find a bug?

There's an [issue](https://github.com/nhlpa/FsTachyons/issues) for that.

## License

Built with ♥ by [NHLPA Engineering](https://github.com/nhlpa) in Toronto, ON. Licensed under [MIT](https://github.com/nhlpa/Falco.Markup/blob/master/LICENSE).