namespace FsTachyons

module TachyonsUrl =
    /// Tachyons build CDN reference
    let build = "https://unpkg.com/tachyons/css/tachyons.css"

    /// Tachyons minified CDN reference
    let minified = "https://unpkg.com/tachyons/css/tachyons.min.css"

module Tac =
    /// { height: 0; position: relative; }
    let aspect_ratio = TachyonsClass "aspect-ratio"

    /// { padding-bottom: 56.25%; }
    let aspect_ratio__16x9 = TachyonsClass "aspect-ratio--16x9"

    /// { padding-bottom: 177.77%; }
    let aspect_ratio__9x16 = TachyonsClass "aspect-ratio--9x16"

    /// { padding-bottom: 75%; }
    let aspect_ratio__4x3 = TachyonsClass "aspect-ratio--4x3"

    /// { padding-bottom: 133.33%; }
    let aspect_ratio__3x4 = TachyonsClass "aspect-ratio--3x4"

    /// { padding-bottom: 66.6%; }
    let aspect_ratio__6x4 = TachyonsClass "aspect-ratio--6x4"

    /// { padding-bottom: 150%; }
    let aspect_ratio__4x6 = TachyonsClass "aspect-ratio--4x6"

    /// { padding-bottom: 62.5%; }
    let aspect_ratio__8x5 = TachyonsClass "aspect-ratio--8x5"

    /// { padding-bottom: 160%; }
    let aspect_ratio__5x8 = TachyonsClass "aspect-ratio--5x8"

    /// { padding-bottom: 71.42%; }
    let aspect_ratio__7x5 = TachyonsClass "aspect-ratio--7x5"

    /// { padding-bottom: 140%; }
    let aspect_ratio__5x7 = TachyonsClass "aspect-ratio--5x7"

    /// { padding-bottom: 100%; }
    let aspect_ratio__1x1 = TachyonsClass "aspect-ratio--1x1"

    /// { position: absolute; top: 0; right: 0; bottom: 0; left: 0; width: 100%; height: 100%; z-index: 100; }
    let aspect_ratio__object = TachyonsClass "aspect-ratio--object"

    /// { background-size: cover !important; }
    let cover = TachyonsClass "cover"

    /// { background-size: contain !important; }
    let contain = TachyonsClass "contain"

    /// { background-repeat: no-repeat; background-position: center center; }
    let bg_center = TachyonsClass "bg-center"

    /// { background-repeat: no-repeat; background-position: top center; }
    let bg_top = TachyonsClass "bg-top"

    /// { background-repeat: no-repeat; background-position: center right; }
    let bg_right = TachyonsClass "bg-right"

    /// { background-repeat: no-repeat; background-position: bottom center; }
    let bg_bottom = TachyonsClass "bg-bottom"

    /// { background-repeat: no-repeat; background-position: center left; }
    let bg_left = TachyonsClass "bg-left"

    /// { outline: 1px solid; }
    let outline = TachyonsClass "outline"

    /// { outline: 1px solid transparent; }
    let outline_transparent = TachyonsClass "outline-transparent"

    /// { outline: 0; }
    let outline_0 = TachyonsClass "outline-0"

    /// { border-style: solid; border-width: 1px; }
    let ba = TachyonsClass "ba"

    /// { border-top-style: solid; border-top-width: 1px; }
    let bt = TachyonsClass "bt"

    /// { border-right-style: solid; border-right-width: 1px; }
    let br = TachyonsClass "br"

    /// { border-bottom-style: solid; border-bottom-width: 1px; }
    let bb = TachyonsClass "bb"

    /// { border-left-style: solid; border-left-width: 1px; }
    let bl = TachyonsClass "bl"

    /// { border-style: none; border-width: 0; }
    let bn = TachyonsClass "bn"

    /// { border-color: #000; }
    let b__black = TachyonsClass "b--black"

    /// { border-color: #111; }
    let b__near_black = TachyonsClass "b--near-black"

    /// { border-color: #333; }
    let b__dark_gray = TachyonsClass "b--dark-gray"

    /// { border-color: #555; }
    let b__mid_gray = TachyonsClass "b--mid-gray"

    /// { border-color: #777; }
    let b__gray = TachyonsClass "b--gray"

    /// { border-color: #999; }
    let b__silver = TachyonsClass "b--silver"

    /// { border-color: #aaa; }
    let b__light_silver = TachyonsClass "b--light-silver"

    /// { border-color: #ccc; }
    let b__moon_gray = TachyonsClass "b--moon-gray"

    /// { border-color: #eee; }
    let b__light_gray = TachyonsClass "b--light-gray"

    /// { border-color: #f4f4f4; }
    let b__near_white = TachyonsClass "b--near-white"

    /// { border-color: #fff; }
    let b__white = TachyonsClass "b--white"

    /// { border-color: rgba( 255, 255, 255, .9 ); }
    let b__white_90 = TachyonsClass "b--white-90"

    /// { border-color: rgba( 255, 255, 255, .8 ); }
    let b__white_80 = TachyonsClass "b--white-80"

    /// { border-color: rgba( 255, 255, 255, .7 ); }
    let b__white_70 = TachyonsClass "b--white-70"

    /// { border-color: rgba( 255, 255, 255, .6 ); }
    let b__white_60 = TachyonsClass "b--white-60"

    /// { border-color: rgba( 255, 255, 255, .5 ); }
    let b__white_50 = TachyonsClass "b--white-50"

    /// { border-color: rgba( 255, 255, 255, .4 ); }
    let b__white_40 = TachyonsClass "b--white-40"

    /// { border-color: rgba( 255, 255, 255, .3 ); }
    let b__white_30 = TachyonsClass "b--white-30"

    /// { border-color: rgba( 255, 255, 255, .2 ); }
    let b__white_20 = TachyonsClass "b--white-20"

    /// { border-color: rgba( 255, 255, 255, .1 ); }
    let b__white_10 = TachyonsClass "b--white-10"

    /// { border-color: rgba( 255, 255, 255, .05 ); }
    let b__white_05 = TachyonsClass "b--white-05"

    /// { border-color: rgba( 255, 255, 255, .025 ); }
    let b__white_025 = TachyonsClass "b--white-025"

    /// { border-color: rgba( 255, 255, 255, .0125 ); }
    let b__white_0125 = TachyonsClass "b--white-0125"

    /// { border-color: rgba( 0, 0, 0, .9 ); }
    let b__black_90 = TachyonsClass "b--black-90"

    /// { border-color: rgba( 0, 0, 0, .8 ); }
    let b__black_80 = TachyonsClass "b--black-80"

    /// { border-color: rgba( 0, 0, 0, .7 ); }
    let b__black_70 = TachyonsClass "b--black-70"

    /// { border-color: rgba( 0, 0, 0, .6 ); }
    let b__black_60 = TachyonsClass "b--black-60"

    /// { border-color: rgba( 0, 0, 0, .5 ); }
    let b__black_50 = TachyonsClass "b--black-50"

    /// { border-color: rgba( 0, 0, 0, .4 ); }
    let b__black_40 = TachyonsClass "b--black-40"

    /// { border-color: rgba( 0, 0, 0, .3 ); }
    let b__black_30 = TachyonsClass "b--black-30"

    /// { border-color: rgba( 0, 0, 0, .2 ); }
    let b__black_20 = TachyonsClass "b--black-20"

    /// { border-color: rgba( 0, 0, 0, .1 ); }
    let b__black_10 = TachyonsClass "b--black-10"

    /// { border-color: rgba( 0, 0, 0, .05 ); }
    let b__black_05 = TachyonsClass "b--black-05"

    /// { border-color: rgba( 0, 0, 0, .025 ); }
    let b__black_025 = TachyonsClass "b--black-025"

    /// { border-color: rgba( 0, 0, 0, .0125 ); }
    let b__black_0125 = TachyonsClass "b--black-0125"

    /// { border-color: #e7040f; }
    let b__dark_red = TachyonsClass "b--dark-red"

    /// { border-color: #ff4136; }
    let b__red = TachyonsClass "b--red"

    /// { border-color: #ff725c; }
    let b__light_red = TachyonsClass "b--light-red"

    /// { border-color: #ff6300; }
    let b__orange = TachyonsClass "b--orange"

    /// { border-color: #ffb700; }
    let b__gold = TachyonsClass "b--gold"

    /// { border-color: #ffd700; }
    let b__yellow = TachyonsClass "b--yellow"

    /// { border-color: #fbf1a9; }
    let b__light_yellow = TachyonsClass "b--light-yellow"

    /// { border-color: #5e2ca5; }
    let b__purple = TachyonsClass "b--purple"

    /// { border-color: #a463f2; }
    let b__light_purple = TachyonsClass "b--light-purple"

    /// { border-color: #d5008f; }
    let b__dark_pink = TachyonsClass "b--dark-pink"

    /// { border-color: #ff41b4; }
    let b__hot_pink = TachyonsClass "b--hot-pink"

    /// { border-color: #ff80cc; }
    let b__pink = TachyonsClass "b--pink"

    /// { border-color: #ffa3d7; }
    let b__light_pink = TachyonsClass "b--light-pink"

    /// { border-color: #137752; }
    let b__dark_green = TachyonsClass "b--dark-green"

    /// { border-color: #19a974; }
    let b__green = TachyonsClass "b--green"

    /// { border-color: #9eebcf; }
    let b__light_green = TachyonsClass "b--light-green"

    /// { border-color: #001b44; }
    let b__navy = TachyonsClass "b--navy"

    /// { border-color: #00449e; }
    let b__dark_blue = TachyonsClass "b--dark-blue"

    /// { border-color: #357edd; }
    let b__blue = TachyonsClass "b--blue"

    /// { border-color: #96ccff; }
    let b__light_blue = TachyonsClass "b--light-blue"

    /// { border-color: #cdecff; }
    let b__lightest_blue = TachyonsClass "b--lightest-blue"

    /// { border-color: #f6fffe; }
    let b__washed_blue = TachyonsClass "b--washed-blue"

    /// { border-color: #e8fdf5; }
    let b__washed_green = TachyonsClass "b--washed-green"

    /// { border-color: #fffceb; }
    let b__washed_yellow = TachyonsClass "b--washed-yellow"

    /// { border-color: #ffdfdf; }
    let b__washed_red = TachyonsClass "b--washed-red"

    /// { border-color: transparent; }
    let b__transparent = TachyonsClass "b--transparent"

    /// { border-color: inherit; }
    let b__inherit = TachyonsClass "b--inherit"

    /// { border-color: initial; }
    let b__initial = TachyonsClass "b--initial"

    /// { border-color: unset; }
    let b__unset = TachyonsClass "b--unset"

    /// { border-radius: 0; }
    let br0 = TachyonsClass "br0"

    /// { border-radius: .125rem; }
    let br1 = TachyonsClass "br1"

    /// { border-radius: .25rem; }
    let br2 = TachyonsClass "br2"

    /// { border-radius: .5rem; }
    let br3 = TachyonsClass "br3"

    /// { border-radius: 1rem; }
    let br4 = TachyonsClass "br4"

    /// { border-radius: 100%; }
    let br_100 = TachyonsClass "br-100"

    /// { border-radius: 9999px; }
    let br_pill = TachyonsClass "br-pill"

    /// { border-top-left-radius: 0; border-top-right-radius: 0; }
    let br__bottom = TachyonsClass "br--bottom"

    /// { border-bottom-left-radius: 0; border-bottom-right-radius: 0; }
    let br__top = TachyonsClass "br--top"

    /// { border-top-left-radius: 0; border-bottom-left-radius: 0; }
    let br__right = TachyonsClass "br--right"

    /// { border-top-right-radius: 0; border-bottom-right-radius: 0; }
    let br__left = TachyonsClass "br--left"

    /// { border-radius: inherit; }
    let br_inherit = TachyonsClass "br-inherit"

    /// { border-radius: initial; }
    let br_initial = TachyonsClass "br-initial"

    /// { border-radius: unset; }
    let br_unset = TachyonsClass "br-unset"

    /// { border-style: dotted; }
    let b__dotted = TachyonsClass "b--dotted"

    /// { border-style: dashed; }
    let b__dashed = TachyonsClass "b--dashed"

    /// { border-style: solid; }
    let b__solid = TachyonsClass "b--solid"

    /// { border-style: none; }
    let b__none = TachyonsClass "b--none"

    /// { border-width: 0; }
    let bw0 = TachyonsClass "bw0"

    /// { border-width: .125rem; }
    let bw1 = TachyonsClass "bw1"

    /// { border-width: .25rem; }
    let bw2 = TachyonsClass "bw2"

    /// { border-width: .5rem; }
    let bw3 = TachyonsClass "bw3"

    /// { border-width: 1rem; }
    let bw4 = TachyonsClass "bw4"

    /// { border-width: 2rem; }
    let bw5 = TachyonsClass "bw5"

    /// { border-top-width: 0; }
    let bt_0 = TachyonsClass "bt-0"

    /// { border-right-width: 0; }
    let br_0 = TachyonsClass "br-0"

    /// { border-bottom-width: 0; }
    let bb_0 = TachyonsClass "bb-0"

    /// { border-left-width: 0; }
    let bl_0 = TachyonsClass "bl-0"

    /// { box-shadow: 0 0 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_1 = TachyonsClass "shadow-1"

    /// { box-shadow: 0 0 8px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_2 = TachyonsClass "shadow-2"

    /// { box-shadow: 2px 2px 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_3 = TachyonsClass "shadow-3"

    /// { box-shadow: 2px 2px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_4 = TachyonsClass "shadow-4"

    /// { box-shadow: 4px 4px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_5 = TachyonsClass "shadow-5"

    /// { white-space: pre; }
    let pre = TachyonsClass "pre"

    /// { top: 0; }
    let top_0 = TachyonsClass "top-0"

    /// { right: 0; }
    let right_0 = TachyonsClass "right-0"

    /// { bottom: 0; }
    let bottom_0 = TachyonsClass "bottom-0"

    /// { left: 0; }
    let left_0 = TachyonsClass "left-0"

    /// { top: 1rem; }
    let top_1 = TachyonsClass "top-1"

    /// { right: 1rem; }
    let right_1 = TachyonsClass "right-1"

    /// { bottom: 1rem; }
    let bottom_1 = TachyonsClass "bottom-1"

    /// { left: 1rem; }
    let left_1 = TachyonsClass "left-1"

    /// { top: 2rem; }
    let top_2 = TachyonsClass "top-2"

    /// { right: 2rem; }
    let right_2 = TachyonsClass "right-2"

    /// { bottom: 2rem; }
    let bottom_2 = TachyonsClass "bottom-2"

    /// { left: 2rem; }
    let left_2 = TachyonsClass "left-2"

    /// { top: -1rem; }
    let top__1 = TachyonsClass "top--1"

    /// { right: -1rem; }
    let right__1 = TachyonsClass "right--1"

    /// { bottom: -1rem; }
    let bottom__1 = TachyonsClass "bottom--1"

    /// { left: -1rem; }
    let left__1 = TachyonsClass "left--1"

    /// { top: -2rem; }
    let top__2 = TachyonsClass "top--2"

    /// { right: -2rem; }
    let right__2 = TachyonsClass "right--2"

    /// { bottom: -2rem; }
    let bottom__2 = TachyonsClass "bottom--2"

    /// { left: -2rem; }
    let left__2 = TachyonsClass "left--2"

    /// { top: 0; right: 0; bottom: 0; left: 0; }
    let absolute__fill = TachyonsClass "absolute--fill"

    /// { *zoom: 1; }
    let cf = TachyonsClass "cf"

    /// { clear: left; }
    let cl = TachyonsClass "cl"

    /// { clear: right; }
    let cr = TachyonsClass "cr"

    /// { clear: both; }
    let cb = TachyonsClass "cb"

    /// { clear: none; }
    let cn = TachyonsClass "cn"

    /// { display: none; }
    let dn = TachyonsClass "dn"

    /// { display: inline; }
    let di = TachyonsClass "di"

    /// { display: block; }
    let db = TachyonsClass "db"

    /// { display: inline-block; }
    let dib = TachyonsClass "dib"

    /// { display: inline-table; }
    let dit = TachyonsClass "dit"

    /// { display: table; }
    let dt = TachyonsClass "dt"

    /// { display: table-cell; }
    let dtc = TachyonsClass "dtc"

    /// { display: table-row; }
    let dt_row = TachyonsClass "dt-row"

    /// { display: table-row-group; }
    let dt_row_group = TachyonsClass "dt-row-group"

    /// { display: table-column; }
    let dt_column = TachyonsClass "dt-column"

    /// { display: table-column-group; }
    let dt_column_group = TachyonsClass "dt-column-group"

    /// { table-layout: fixed; width: 100%; }
    let dt__fixed = TachyonsClass "dt--fixed"

    /// { display: flex; }
    let flex = TachyonsClass "flex"

    /// { display: inline-flex; }
    let inline_flex = TachyonsClass "inline-flex"

    /// { flex: 1 1 auto; min-width: 0; /* 1 */ min-height: 0; /* 1 */ }
    let flex_auto = TachyonsClass "flex-auto"

    /// { flex: none; }
    let flex_none = TachyonsClass "flex-none"

    /// { flex-direction: column; }
    let flex_column = TachyonsClass "flex-column"

    /// { flex-direction: row; }
    let flex_row = TachyonsClass "flex-row"

    /// { flex-wrap: wrap; }
    let flex_wrap = TachyonsClass "flex-wrap"

    /// { flex-wrap: nowrap; }
    let flex_nowrap = TachyonsClass "flex-nowrap"

    /// { flex-wrap: wrap-reverse; }
    let flex_wrap_reverse = TachyonsClass "flex-wrap-reverse"

    /// { flex-direction: column-reverse; }
    let flex_column_reverse = TachyonsClass "flex-column-reverse"

    /// { flex-direction: row-reverse; }
    let flex_row_reverse = TachyonsClass "flex-row-reverse"

    /// { align-items: flex-start; }
    let items_start = TachyonsClass "items-start"

    /// { align-items: flex-end; }
    let items_end = TachyonsClass "items-end"

    /// { align-items: center; }
    let items_center = TachyonsClass "items-center"

    /// { align-items: baseline; }
    let items_baseline = TachyonsClass "items-baseline"

    /// { align-items: stretch; }
    let items_stretch = TachyonsClass "items-stretch"

    /// { align-self: flex-start; }
    let self_start = TachyonsClass "self-start"

    /// { align-self: flex-end; }
    let self_end = TachyonsClass "self-end"

    /// { align-self: center; }
    let self_center = TachyonsClass "self-center"

    /// { align-self: baseline; }
    let self_baseline = TachyonsClass "self-baseline"

    /// { align-self: stretch; }
    let self_stretch = TachyonsClass "self-stretch"

    /// { justify-content: flex-start; }
    let justify_start = TachyonsClass "justify-start"

    /// { justify-content: flex-end; }
    let justify_end = TachyonsClass "justify-end"

    /// { justify-content: center; }
    let justify_center = TachyonsClass "justify-center"

    /// { justify-content: space-between; }
    let justify_between = TachyonsClass "justify-between"

    /// { justify-content: space-around; }
    let justify_around = TachyonsClass "justify-around"

    /// { align-content: flex-start; }
    let content_start = TachyonsClass "content-start"

    /// { align-content: flex-end; }
    let content_end = TachyonsClass "content-end"

    /// { align-content: center; }
    let content_center = TachyonsClass "content-center"

    /// { align-content: space-between; }
    let content_between = TachyonsClass "content-between"

    /// { align-content: space-around; }
    let content_around = TachyonsClass "content-around"

    /// { align-content: stretch; }
    let content_stretch = TachyonsClass "content-stretch"

    /// { order: 0; }
    let order_0 = TachyonsClass "order-0"

    /// { order: 1; }
    let order_1 = TachyonsClass "order-1"

    /// { order: 2; }
    let order_2 = TachyonsClass "order-2"

    /// { order: 3; }
    let order_3 = TachyonsClass "order-3"

    /// { order: 4; }
    let order_4 = TachyonsClass "order-4"

    /// { order: 5; }
    let order_5 = TachyonsClass "order-5"

    /// { order: 6; }
    let order_6 = TachyonsClass "order-6"

    /// { order: 7; }
    let order_7 = TachyonsClass "order-7"

    /// { order: 8; }
    let order_8 = TachyonsClass "order-8"

    /// { order: 99999; }
    let order_last = TachyonsClass "order-last"

    /// { flex-grow: 0; }
    let flex_grow_0 = TachyonsClass "flex-grow-0"

    /// { flex-grow: 1; }
    let flex_grow_1 = TachyonsClass "flex-grow-1"

    /// { flex-shrink: 0; }
    let flex_shrink_0 = TachyonsClass "flex-shrink-0"

    /// { flex-shrink: 1; }
    let flex_shrink_1 = TachyonsClass "flex-shrink-1"

    /// { float: left; _display: inline; }
    let fl = TachyonsClass "fl"

    /// { float: right; _display: inline; }
    let fr = TachyonsClass "fr"

    /// { float: none; }
    let fn = TachyonsClass "fn"

    /// { font-family: -apple-system, BlinkMacSystemFont, 'avenir next', avenir, 'helvetica neue', helvetica, ubuntu, roboto, noto, 'segoe ui', arial, sans-serif; }
    let sans_serif = TachyonsClass "sans-serif"

    /// { font-family: georgia, times, serif; }
    let serif = TachyonsClass "serif"

    /// { font-family: sans-serif; }
    let system_sans_serif = TachyonsClass "system-sans-serif"

    /// { font-family: serif; }
    let system_serif = TachyonsClass "system-serif"

    /// { font-family: Consolas, monaco, monospace; }
    let code = TachyonsClass "code"

    /// { font-family: 'Courier Next', courier, monospace; }
    let courier = TachyonsClass "courier"

    /// { font-family: 'helvetica neue', helvetica, sans-serif; }
    let helvetica = TachyonsClass "helvetica"

    /// { font-family: 'avenir next', avenir, sans-serif; }
    let avenir = TachyonsClass "avenir"

    /// { font-family: athelas, georgia, serif; }
    let athelas = TachyonsClass "athelas"

    /// { font-family: georgia, serif; }
    let georgia = TachyonsClass "georgia"

    /// { font-family: times, serif; }
    let times = TachyonsClass "times"

    /// { font-family: "Bodoni MT", serif; }
    let bodoni = TachyonsClass "bodoni"

    /// { font-family: "Calisto MT", serif; }
    let calisto = TachyonsClass "calisto"

    /// { font-family: garamond, serif; }
    let garamond = TachyonsClass "garamond"

    /// { font-family: baskerville, serif; }
    let baskerville = TachyonsClass "baskerville"

    /// { font-style: italic; }
    let i = TachyonsClass "i"

    /// { font-style: normal; }
    let fs_normal = TachyonsClass "fs-normal"

    /// { font-weight: normal; }
    let normal = TachyonsClass "normal"

    /// { font-weight: bold; }
    let b = TachyonsClass "b"

    /// { font-weight: 100; }
    let fw1 = TachyonsClass "fw1"

    /// { font-weight: 200; }
    let fw2 = TachyonsClass "fw2"

    /// { font-weight: 300; }
    let fw3 = TachyonsClass "fw3"

    /// { font-weight: 400; }
    let fw4 = TachyonsClass "fw4"

    /// { font-weight: 500; }
    let fw5 = TachyonsClass "fw5"

    /// { font-weight: 600; }
    let fw6 = TachyonsClass "fw6"

    /// { font-weight: 700; }
    let fw7 = TachyonsClass "fw7"

    /// { font-weight: 800; }
    let fw8 = TachyonsClass "fw8"

    /// { font-weight: 900; }
    let fw9 = TachyonsClass "fw9"

    /// { -webkit-appearance: none; -moz-appearance: none; }
    let input_reset = TachyonsClass "input-reset"

    /// { height: 1rem; }
    let h1 = TachyonsClass "h1"

    /// { height: 2rem; }
    let h2 = TachyonsClass "h2"

    /// { height: 4rem; }
    let h3 = TachyonsClass "h3"

    /// { height: 8rem; }
    let h4 = TachyonsClass "h4"

    /// { height: 16rem; }
    let h5 = TachyonsClass "h5"

    /// { height: 25%; }
    let h_25 = TachyonsClass "h-25"

    /// { height: 50%; }
    let h_50 = TachyonsClass "h-50"

    /// { height: 75%; }
    let h_75 = TachyonsClass "h-75"

    /// { height: 100%; }
    let h_100 = TachyonsClass "h-100"

    /// { min-height: 100%; }
    let min_h_100 = TachyonsClass "min-h-100"

    /// { height: 25vh; }
    let vh_25 = TachyonsClass "vh-25"

    /// { height: 50vh; }
    let vh_50 = TachyonsClass "vh-50"

    /// { height: 75vh; }
    let vh_75 = TachyonsClass "vh-75"

    /// { height: 100vh; }
    let vh_100 = TachyonsClass "vh-100"

    /// { min-height: 100vh; }
    let min_vh_100 = TachyonsClass "min-vh-100"

    /// { height: auto; }
    let h_auto = TachyonsClass "h-auto"

    /// { height: inherit; }
    let h_inherit = TachyonsClass "h-inherit"

    /// { letter-spacing: .1em; }
    let tracked = TachyonsClass "tracked"

    /// { letter-spacing: -.05em; }
    let tracked_tight = TachyonsClass "tracked-tight"

    /// { letter-spacing: .25em; }
    let tracked_mega = TachyonsClass "tracked-mega"

    /// { line-height: 1; }
    let lh_solid = TachyonsClass "lh-solid"

    /// { line-height: 1.25; }
    let lh_title = TachyonsClass "lh-title"

    /// { line-height: 1.5; }
    let lh_copy = TachyonsClass "lh-copy"

    /// { text-decoration: none; transition: color .15s ease-in; }
    let link = TachyonsClass "link"

    /// { list-style-type: none; }
    let list = TachyonsClass "list"

    /// { max-width: 100%; }
    let mw_100 = TachyonsClass "mw-100"

    /// { max-width: 1rem; }
    let mw1 = TachyonsClass "mw1"

    /// { max-width: 2rem; }
    let mw2 = TachyonsClass "mw2"

    /// { max-width: 4rem; }
    let mw3 = TachyonsClass "mw3"

    /// { max-width: 8rem; }
    let mw4 = TachyonsClass "mw4"

    /// { max-width: 16rem; }
    let mw5 = TachyonsClass "mw5"

    /// { max-width: 32rem; }
    let mw6 = TachyonsClass "mw6"

    /// { max-width: 48rem; }
    let mw7 = TachyonsClass "mw7"

    /// { max-width: 64rem; }
    let mw8 = TachyonsClass "mw8"

    /// { max-width: 96rem; }
    let mw9 = TachyonsClass "mw9"

    /// { max-width: none; }
    let mw_none = TachyonsClass "mw-none"

    /// { width: 1rem; }
    let w1 = TachyonsClass "w1"

    /// { width: 2rem; }
    let w2 = TachyonsClass "w2"

    /// { width: 4rem; }
    let w3 = TachyonsClass "w3"

    /// { width: 8rem; }
    let w4 = TachyonsClass "w4"

    /// { width: 16rem; }
    let w5 = TachyonsClass "w5"

    /// { width: 10%; }
    let w_10 = TachyonsClass "w-10"

    /// { width: 20%; }
    let w_20 = TachyonsClass "w-20"

    /// { width: 25%; }
    let w_25 = TachyonsClass "w-25"

    /// { width: 30%; }
    let w_30 = TachyonsClass "w-30"

    /// { width: 33%; }
    let w_33 = TachyonsClass "w-33"

    /// { width: 34%; }
    let w_34 = TachyonsClass "w-34"

    /// { width: 40%; }
    let w_40 = TachyonsClass "w-40"

    /// { width: 50%; }
    let w_50 = TachyonsClass "w-50"

    /// { width: 60%; }
    let w_60 = TachyonsClass "w-60"

    /// { width: 70%; }
    let w_70 = TachyonsClass "w-70"

    /// { width: 75%; }
    let w_75 = TachyonsClass "w-75"

    /// { width: 80%; }
    let w_80 = TachyonsClass "w-80"

    /// { width: 90%; }
    let w_90 = TachyonsClass "w-90"

    /// { width: 100%; }
    let w_100 = TachyonsClass "w-100"

    /// { width: 33.33333%; }
    let w_third = TachyonsClass "w-third"

    /// { width: 66.66667%; }
    let w_two_thirds = TachyonsClass "w-two-thirds"

    /// { width: auto; }
    let w_auto = TachyonsClass "w-auto"

    /// { overflow: visible; }
    let overflow_visible = TachyonsClass "overflow-visible"

    /// { overflow: hidden; }
    let overflow_hidden = TachyonsClass "overflow-hidden"

    /// { overflow: scroll; }
    let overflow_scroll = TachyonsClass "overflow-scroll"

    /// { overflow: auto; }
    let overflow_auto = TachyonsClass "overflow-auto"

    /// { overflow-x: visible; }
    let overflow_x_visible = TachyonsClass "overflow-x-visible"

    /// { overflow-x: hidden; }
    let overflow_x_hidden = TachyonsClass "overflow-x-hidden"

    /// { overflow-x: scroll; }
    let overflow_x_scroll = TachyonsClass "overflow-x-scroll"

    /// { overflow-x: auto; }
    let overflow_x_auto = TachyonsClass "overflow-x-auto"

    /// { overflow-y: visible; }
    let overflow_y_visible = TachyonsClass "overflow-y-visible"

    /// { overflow-y: hidden; }
    let overflow_y_hidden = TachyonsClass "overflow-y-hidden"

    /// { overflow-y: scroll; }
    let overflow_y_scroll = TachyonsClass "overflow-y-scroll"

    /// { overflow-y: auto; }
    let overflow_y_auto = TachyonsClass "overflow-y-auto"

    /// { position: static; }
    let static' = TachyonsClass "static"

    /// { position: relative; }
    let relative = TachyonsClass "relative"

    /// { position: absolute; }
    let absolute = TachyonsClass "absolute"

    /// { position: fixed; }
    let fixed' = TachyonsClass "fixed"

    /// { opacity: 1; }
    let o_100 = TachyonsClass "o-100"

    /// { opacity: .9; }
    let o_90 = TachyonsClass "o-90"

    /// { opacity: .8; }
    let o_80 = TachyonsClass "o-80"

    /// { opacity: .7; }
    let o_70 = TachyonsClass "o-70"

    /// { opacity: .6; }
    let o_60 = TachyonsClass "o-60"

    /// { opacity: .5; }
    let o_50 = TachyonsClass "o-50"

    /// { opacity: .4; }
    let o_40 = TachyonsClass "o-40"

    /// { opacity: .3; }
    let o_30 = TachyonsClass "o-30"

    /// { opacity: .2; }
    let o_20 = TachyonsClass "o-20"

    /// { opacity: .1; }
    let o_10 = TachyonsClass "o-10"

    /// { opacity: .05; }
    let o_05 = TachyonsClass "o-05"

    /// { opacity: .025; }
    let o_025 = TachyonsClass "o-025"

    /// { opacity: 0; }
    let o_0 = TachyonsClass "o-0"

    /// { -webkit-transform: rotate( 45deg ); transform: rotate( 45deg ); }
    let rotate_45 = TachyonsClass "rotate-45"

    /// { -webkit-transform: rotate( 90deg ); transform: rotate( 90deg ); }
    let rotate_90 = TachyonsClass "rotate-90"

    /// { -webkit-transform: rotate( 135deg ); transform: rotate( 135deg ); }
    let rotate_135 = TachyonsClass "rotate-135"

    /// { -webkit-transform: rotate( 180deg ); transform: rotate( 180deg ); }
    let rotate_180 = TachyonsClass "rotate-180"

    /// { -webkit-transform: rotate( 225deg ); transform: rotate( 225deg ); }
    let rotate_225 = TachyonsClass "rotate-225"

    /// { -webkit-transform: rotate( 270deg ); transform: rotate( 270deg ); }
    let rotate_270 = TachyonsClass "rotate-270"

    /// { -webkit-transform: rotate( 315deg ); transform: rotate( 315deg ); }
    let rotate_315 = TachyonsClass "rotate-315"

    /// { color: rgba( 0, 0, 0, .9 ); }
    let black_90 = TachyonsClass "black-90"

    /// { color: rgba( 0, 0, 0, .8 ); }
    let black_80 = TachyonsClass "black-80"

    /// { color: rgba( 0, 0, 0, .7 ); }
    let black_70 = TachyonsClass "black-70"

    /// { color: rgba( 0, 0, 0, .6 ); }
    let black_60 = TachyonsClass "black-60"

    /// { color: rgba( 0, 0, 0, .5 ); }
    let black_50 = TachyonsClass "black-50"

    /// { color: rgba( 0, 0, 0, .4 ); }
    let black_40 = TachyonsClass "black-40"

    /// { color: rgba( 0, 0, 0, .3 ); }
    let black_30 = TachyonsClass "black-30"

    /// { color: rgba( 0, 0, 0, .2 ); }
    let black_20 = TachyonsClass "black-20"

    /// { color: rgba( 0, 0, 0, .1 ); }
    let black_10 = TachyonsClass "black-10"

    /// { color: rgba( 0, 0, 0, .05 ); }
    let black_05 = TachyonsClass "black-05"

    /// { color: rgba( 255, 255, 255, .9 ); }
    let white_90 = TachyonsClass "white-90"

    /// { color: rgba( 255, 255, 255, .8 ); }
    let white_80 = TachyonsClass "white-80"

    /// { color: rgba( 255, 255, 255, .7 ); }
    let white_70 = TachyonsClass "white-70"

    /// { color: rgba( 255, 255, 255, .6 ); }
    let white_60 = TachyonsClass "white-60"

    /// { color: rgba( 255, 255, 255, .5 ); }
    let white_50 = TachyonsClass "white-50"

    /// { color: rgba( 255, 255, 255, .4 ); }
    let white_40 = TachyonsClass "white-40"

    /// { color: rgba( 255, 255, 255, .3 ); }
    let white_30 = TachyonsClass "white-30"

    /// { color: rgba( 255, 255, 255, .2 ); }
    let white_20 = TachyonsClass "white-20"

    /// { color: rgba( 255, 255, 255, .1 ); }
    let white_10 = TachyonsClass "white-10"

    /// { color: #000; }
    let black = TachyonsClass "black"

    /// { color: #111; }
    let near_black = TachyonsClass "near-black"

    /// { color: #333; }
    let dark_gray = TachyonsClass "dark-gray"

    /// { color: #555; }
    let mid_gray = TachyonsClass "mid-gray"

    /// { color: #777; }
    let gray = TachyonsClass "gray"

    /// { color: #999; }
    let silver = TachyonsClass "silver"

    /// { color: #aaa; }
    let light_silver = TachyonsClass "light-silver"

    /// { color: #ccc; }
    let moon_gray = TachyonsClass "moon-gray"

    /// { color: #eee; }
    let light_gray = TachyonsClass "light-gray"

    /// { color: #f4f4f4; }
    let near_white = TachyonsClass "near-white"

    /// { color: #fff; }
    let white = TachyonsClass "white"

    /// { color: #e7040f; }
    let dark_red = TachyonsClass "dark-red"

    /// { color: #ff4136; }
    let red = TachyonsClass "red"

    /// { color: #ff725c; }
    let light_red = TachyonsClass "light-red"

    /// { color: #ff6300; }
    let orange = TachyonsClass "orange"

    /// { color: #ffb700; }
    let gold = TachyonsClass "gold"

    /// { color: #ffd700; }
    let yellow = TachyonsClass "yellow"

    /// { color: #fbf1a9; }
    let light_yellow = TachyonsClass "light-yellow"

    /// { color: #5e2ca5; }
    let purple = TachyonsClass "purple"

    /// { color: #a463f2; }
    let light_purple = TachyonsClass "light-purple"

    /// { color: #d5008f; }
    let dark_pink = TachyonsClass "dark-pink"

    /// { color: #ff41b4; }
    let hot_pink = TachyonsClass "hot-pink"

    /// { color: #ff80cc; }
    let pink = TachyonsClass "pink"

    /// { color: #ffa3d7; }
    let light_pink = TachyonsClass "light-pink"

    /// { color: #137752; }
    let dark_green = TachyonsClass "dark-green"

    /// { color: #19a974; }
    let green = TachyonsClass "green"

    /// { color: #9eebcf; }
    let light_green = TachyonsClass "light-green"

    /// { color: #001b44; }
    let navy = TachyonsClass "navy"

    /// { color: #00449e; }
    let dark_blue = TachyonsClass "dark-blue"

    /// { color: #357edd; }
    let blue = TachyonsClass "blue"

    /// { color: #96ccff; }
    let light_blue = TachyonsClass "light-blue"

    /// { color: #cdecff; }
    let lightest_blue = TachyonsClass "lightest-blue"

    /// { color: #f6fffe; }
    let washed_blue = TachyonsClass "washed-blue"

    /// { color: #e8fdf5; }
    let washed_green = TachyonsClass "washed-green"

    /// { color: #fffceb; }
    let washed_yellow = TachyonsClass "washed-yellow"

    /// { color: #ffdfdf; }
    let washed_red = TachyonsClass "washed-red"

    /// { color: inherit; }
    let color_inherit = TachyonsClass "color-inherit"

    /// { background-color: rgba( 0, 0, 0, .9 ); }
    let bg_black_90 = TachyonsClass "bg-black-90"

    /// { background-color: rgba( 0, 0, 0, .8 ); }
    let bg_black_80 = TachyonsClass "bg-black-80"

    /// { background-color: rgba( 0, 0, 0, .7 ); }
    let bg_black_70 = TachyonsClass "bg-black-70"

    /// { background-color: rgba( 0, 0, 0, .6 ); }
    let bg_black_60 = TachyonsClass "bg-black-60"

    /// { background-color: rgba( 0, 0, 0, .5 ); }
    let bg_black_50 = TachyonsClass "bg-black-50"

    /// { background-color: rgba( 0, 0, 0, .4 ); }
    let bg_black_40 = TachyonsClass "bg-black-40"

    /// { background-color: rgba( 0, 0, 0, .3 ); }
    let bg_black_30 = TachyonsClass "bg-black-30"

    /// { background-color: rgba( 0, 0, 0, .2 ); }
    let bg_black_20 = TachyonsClass "bg-black-20"

    /// { background-color: rgba( 0, 0, 0, .1 ); }
    let bg_black_10 = TachyonsClass "bg-black-10"

    /// { background-color: rgba( 0, 0, 0, .05 ); }
    let bg_black_05 = TachyonsClass "bg-black-05"

    /// { background-color: rgba( 255, 255, 255, .9 ); }
    let bg_white_90 = TachyonsClass "bg-white-90"

    /// { background-color: rgba( 255, 255, 255, .8 ); }
    let bg_white_80 = TachyonsClass "bg-white-80"

    /// { background-color: rgba( 255, 255, 255, .7 ); }
    let bg_white_70 = TachyonsClass "bg-white-70"

    /// { background-color: rgba( 255, 255, 255, .6 ); }
    let bg_white_60 = TachyonsClass "bg-white-60"

    /// { background-color: rgba( 255, 255, 255, .5 ); }
    let bg_white_50 = TachyonsClass "bg-white-50"

    /// { background-color: rgba( 255, 255, 255, .4 ); }
    let bg_white_40 = TachyonsClass "bg-white-40"

    /// { background-color: rgba( 255, 255, 255, .3 ); }
    let bg_white_30 = TachyonsClass "bg-white-30"

    /// { background-color: rgba( 255, 255, 255, .2 ); }
    let bg_white_20 = TachyonsClass "bg-white-20"

    /// { background-color: rgba( 255, 255, 255, .1 ); }
    let bg_white_10 = TachyonsClass "bg-white-10"

    /// { background-color: #000; }
    let bg_black = TachyonsClass "bg-black"

    /// { background-color: #111; }
    let bg_near_black = TachyonsClass "bg-near-black"

    /// { background-color: #333; }
    let bg_dark_gray = TachyonsClass "bg-dark-gray"

    /// { background-color: #555; }
    let bg_mid_gray = TachyonsClass "bg-mid-gray"

    /// { background-color: #777; }
    let bg_gray = TachyonsClass "bg-gray"

    /// { background-color: #999; }
    let bg_silver = TachyonsClass "bg-silver"

    /// { background-color: #aaa; }
    let bg_light_silver = TachyonsClass "bg-light-silver"

    /// { background-color: #ccc; }
    let bg_moon_gray = TachyonsClass "bg-moon-gray"

    /// { background-color: #eee; }
    let bg_light_gray = TachyonsClass "bg-light-gray"

    /// { background-color: #f4f4f4; }
    let bg_near_white = TachyonsClass "bg-near-white"

    /// { background-color: #fff; }
    let bg_white = TachyonsClass "bg-white"

    /// { background-color: transparent; }
    let bg_transparent = TachyonsClass "bg-transparent"

    /// { background-color: #e7040f; }
    let bg_dark_red = TachyonsClass "bg-dark-red"

    /// { background-color: #ff4136; }
    let bg_red = TachyonsClass "bg-red"

    /// { background-color: #ff725c; }
    let bg_light_red = TachyonsClass "bg-light-red"

    /// { background-color: #ff6300; }
    let bg_orange = TachyonsClass "bg-orange"

    /// { background-color: #ffb700; }
    let bg_gold = TachyonsClass "bg-gold"

    /// { background-color: #ffd700; }
    let bg_yellow = TachyonsClass "bg-yellow"

    /// { background-color: #fbf1a9; }
    let bg_light_yellow = TachyonsClass "bg-light-yellow"

    /// { background-color: #5e2ca5; }
    let bg_purple = TachyonsClass "bg-purple"

    /// { background-color: #a463f2; }
    let bg_light_purple = TachyonsClass "bg-light-purple"

    /// { background-color: #d5008f; }
    let bg_dark_pink = TachyonsClass "bg-dark-pink"

    /// { background-color: #ff41b4; }
    let bg_hot_pink = TachyonsClass "bg-hot-pink"

    /// { background-color: #ff80cc; }
    let bg_pink = TachyonsClass "bg-pink"

    /// { background-color: #ffa3d7; }
    let bg_light_pink = TachyonsClass "bg-light-pink"

    /// { background-color: #137752; }
    let bg_dark_green = TachyonsClass "bg-dark-green"

    /// { background-color: #19a974; }
    let bg_green = TachyonsClass "bg-green"

    /// { background-color: #9eebcf; }
    let bg_light_green = TachyonsClass "bg-light-green"

    /// { background-color: #001b44; }
    let bg_navy = TachyonsClass "bg-navy"

    /// { background-color: #00449e; }
    let bg_dark_blue = TachyonsClass "bg-dark-blue"

    /// { background-color: #357edd; }
    let bg_blue = TachyonsClass "bg-blue"

    /// { background-color: #96ccff; }
    let bg_light_blue = TachyonsClass "bg-light-blue"

    /// { background-color: #cdecff; }
    let bg_lightest_blue = TachyonsClass "bg-lightest-blue"

    /// { background-color: #f6fffe; }
    let bg_washed_blue = TachyonsClass "bg-washed-blue"

    /// { background-color: #e8fdf5; }
    let bg_washed_green = TachyonsClass "bg-washed-green"

    /// { background-color: #fffceb; }
    let bg_washed_yellow = TachyonsClass "bg-washed-yellow"

    /// { background-color: #ffdfdf; }
    let bg_washed_red = TachyonsClass "bg-washed-red"

    /// { background-color: inherit; }
    let bg_inherit = TachyonsClass "bg-inherit"

    /// { padding: 0; }
    let pa0 = TachyonsClass "pa0"

    /// { padding: .25rem; }
    let pa1 = TachyonsClass "pa1"

    /// { padding: .5rem; }
    let pa2 = TachyonsClass "pa2"

    /// { padding: 1rem; }
    let pa3 = TachyonsClass "pa3"

    /// { padding: 2rem; }
    let pa4 = TachyonsClass "pa4"

    /// { padding: 4rem; }
    let pa5 = TachyonsClass "pa5"

    /// { padding: 8rem; }
    let pa6 = TachyonsClass "pa6"

    /// { padding: 16rem; }
    let pa7 = TachyonsClass "pa7"

    /// { padding-left: 0; }
    let pl0 = TachyonsClass "pl0"

    /// { padding-left: .25rem; }
    let pl1 = TachyonsClass "pl1"

    /// { padding-left: .5rem; }
    let pl2 = TachyonsClass "pl2"

    /// { padding-left: 1rem; }
    let pl3 = TachyonsClass "pl3"

    /// { padding-left: 2rem; }
    let pl4 = TachyonsClass "pl4"

    /// { padding-left: 4rem; }
    let pl5 = TachyonsClass "pl5"

    /// { padding-left: 8rem; }
    let pl6 = TachyonsClass "pl6"

    /// { padding-left: 16rem; }
    let pl7 = TachyonsClass "pl7"

    /// { padding-right: 0; }
    let pr0 = TachyonsClass "pr0"

    /// { padding-right: .25rem; }
    let pr1 = TachyonsClass "pr1"

    /// { padding-right: .5rem; }
    let pr2 = TachyonsClass "pr2"

    /// { padding-right: 1rem; }
    let pr3 = TachyonsClass "pr3"

    /// { padding-right: 2rem; }
    let pr4 = TachyonsClass "pr4"

    /// { padding-right: 4rem; }
    let pr5 = TachyonsClass "pr5"

    /// { padding-right: 8rem; }
    let pr6 = TachyonsClass "pr6"

    /// { padding-right: 16rem; }
    let pr7 = TachyonsClass "pr7"

    /// { padding-bottom: 0; }
    let pb0 = TachyonsClass "pb0"

    /// { padding-bottom: .25rem; }
    let pb1 = TachyonsClass "pb1"

    /// { padding-bottom: .5rem; }
    let pb2 = TachyonsClass "pb2"

    /// { padding-bottom: 1rem; }
    let pb3 = TachyonsClass "pb3"

    /// { padding-bottom: 2rem; }
    let pb4 = TachyonsClass "pb4"

    /// { padding-bottom: 4rem; }
    let pb5 = TachyonsClass "pb5"

    /// { padding-bottom: 8rem; }
    let pb6 = TachyonsClass "pb6"

    /// { padding-bottom: 16rem; }
    let pb7 = TachyonsClass "pb7"

    /// { padding-top: 0; }
    let pt0 = TachyonsClass "pt0"

    /// { padding-top: .25rem; }
    let pt1 = TachyonsClass "pt1"

    /// { padding-top: .5rem; }
    let pt2 = TachyonsClass "pt2"

    /// { padding-top: 1rem; }
    let pt3 = TachyonsClass "pt3"

    /// { padding-top: 2rem; }
    let pt4 = TachyonsClass "pt4"

    /// { padding-top: 4rem; }
    let pt5 = TachyonsClass "pt5"

    /// { padding-top: 8rem; }
    let pt6 = TachyonsClass "pt6"

    /// { padding-top: 16rem; }
    let pt7 = TachyonsClass "pt7"

    /// { padding-top: 0; padding-bottom: 0; }
    let pv0 = TachyonsClass "pv0"

    /// { padding-top: .25rem; padding-bottom: .25rem; }
    let pv1 = TachyonsClass "pv1"

    /// { padding-top: .5rem; padding-bottom: .5rem; }
    let pv2 = TachyonsClass "pv2"

    /// { padding-top: 1rem; padding-bottom: 1rem; }
    let pv3 = TachyonsClass "pv3"

    /// { padding-top: 2rem; padding-bottom: 2rem; }
    let pv4 = TachyonsClass "pv4"

    /// { padding-top: 4rem; padding-bottom: 4rem; }
    let pv5 = TachyonsClass "pv5"

    /// { padding-top: 8rem; padding-bottom: 8rem; }
    let pv6 = TachyonsClass "pv6"

    /// { padding-top: 16rem; padding-bottom: 16rem; }
    let pv7 = TachyonsClass "pv7"

    /// { padding-left: 0; padding-right: 0; }
    let ph0 = TachyonsClass "ph0"

    /// { padding-left: .25rem; padding-right: .25rem; }
    let ph1 = TachyonsClass "ph1"

    /// { padding-left: .5rem; padding-right: .5rem; }
    let ph2 = TachyonsClass "ph2"

    /// { padding-left: 1rem; padding-right: 1rem; }
    let ph3 = TachyonsClass "ph3"

    /// { padding-left: 2rem; padding-right: 2rem; }
    let ph4 = TachyonsClass "ph4"

    /// { padding-left: 4rem; padding-right: 4rem; }
    let ph5 = TachyonsClass "ph5"

    /// { padding-left: 8rem; padding-right: 8rem; }
    let ph6 = TachyonsClass "ph6"

    /// { padding-left: 16rem; padding-right: 16rem; }
    let ph7 = TachyonsClass "ph7"

    /// { margin: 0; }
    let ma0 = TachyonsClass "ma0"

    /// { margin: .25rem; }
    let ma1 = TachyonsClass "ma1"

    /// { margin: .5rem; }
    let ma2 = TachyonsClass "ma2"

    /// { margin: 1rem; }
    let ma3 = TachyonsClass "ma3"

    /// { margin: 2rem; }
    let ma4 = TachyonsClass "ma4"

    /// { margin: 4rem; }
    let ma5 = TachyonsClass "ma5"

    /// { margin: 8rem; }
    let ma6 = TachyonsClass "ma6"

    /// { margin: 16rem; }
    let ma7 = TachyonsClass "ma7"

    /// { margin-left: 0; }
    let ml0 = TachyonsClass "ml0"

    /// { margin-left: .25rem; }
    let ml1 = TachyonsClass "ml1"

    /// { margin-left: .5rem; }
    let ml2 = TachyonsClass "ml2"

    /// { margin-left: 1rem; }
    let ml3 = TachyonsClass "ml3"

    /// { margin-left: 2rem; }
    let ml4 = TachyonsClass "ml4"

    /// { margin-left: 4rem; }
    let ml5 = TachyonsClass "ml5"

    /// { margin-left: 8rem; }
    let ml6 = TachyonsClass "ml6"

    /// { margin-left: 16rem; }
    let ml7 = TachyonsClass "ml7"

    /// { margin-right: 0; }
    let mr0 = TachyonsClass "mr0"

    /// { margin-right: .25rem; }
    let mr1 = TachyonsClass "mr1"

    /// { margin-right: .5rem; }
    let mr2 = TachyonsClass "mr2"

    /// { margin-right: 1rem; }
    let mr3 = TachyonsClass "mr3"

    /// { margin-right: 2rem; }
    let mr4 = TachyonsClass "mr4"

    /// { margin-right: 4rem; }
    let mr5 = TachyonsClass "mr5"

    /// { margin-right: 8rem; }
    let mr6 = TachyonsClass "mr6"

    /// { margin-right: 16rem; }
    let mr7 = TachyonsClass "mr7"

    /// { margin-bottom: 0; }
    let mb0 = TachyonsClass "mb0"

    /// { margin-bottom: .25rem; }
    let mb1 = TachyonsClass "mb1"

    /// { margin-bottom: .5rem; }
    let mb2 = TachyonsClass "mb2"

    /// { margin-bottom: 1rem; }
    let mb3 = TachyonsClass "mb3"

    /// { margin-bottom: 2rem; }
    let mb4 = TachyonsClass "mb4"

    /// { margin-bottom: 4rem; }
    let mb5 = TachyonsClass "mb5"

    /// { margin-bottom: 8rem; }
    let mb6 = TachyonsClass "mb6"

    /// { margin-bottom: 16rem; }
    let mb7 = TachyonsClass "mb7"

    /// { margin-top: 0; }
    let mt0 = TachyonsClass "mt0"

    /// { margin-top: .25rem; }
    let mt1 = TachyonsClass "mt1"

    /// { margin-top: .5rem; }
    let mt2 = TachyonsClass "mt2"

    /// { margin-top: 1rem; }
    let mt3 = TachyonsClass "mt3"

    /// { margin-top: 2rem; }
    let mt4 = TachyonsClass "mt4"

    /// { margin-top: 4rem; }
    let mt5 = TachyonsClass "mt5"

    /// { margin-top: 8rem; }
    let mt6 = TachyonsClass "mt6"

    /// { margin-top: 16rem; }
    let mt7 = TachyonsClass "mt7"

    /// { margin-top: 0; margin-bottom: 0; }
    let mv0 = TachyonsClass "mv0"

    /// { margin-top: .25rem; margin-bottom: .25rem; }
    let mv1 = TachyonsClass "mv1"

    /// { margin-top: .5rem; margin-bottom: .5rem; }
    let mv2 = TachyonsClass "mv2"

    /// { margin-top: 1rem; margin-bottom: 1rem; }
    let mv3 = TachyonsClass "mv3"

    /// { margin-top: 2rem; margin-bottom: 2rem; }
    let mv4 = TachyonsClass "mv4"

    /// { margin-top: 4rem; margin-bottom: 4rem; }
    let mv5 = TachyonsClass "mv5"

    /// { margin-top: 8rem; margin-bottom: 8rem; }
    let mv6 = TachyonsClass "mv6"

    /// { margin-top: 16rem; margin-bottom: 16rem; }
    let mv7 = TachyonsClass "mv7"

    /// { margin-left: 0; margin-right: 0; }
    let mh0 = TachyonsClass "mh0"

    /// { margin-left: .25rem; margin-right: .25rem; }
    let mh1 = TachyonsClass "mh1"

    /// { margin-left: .5rem; margin-right: .5rem; }
    let mh2 = TachyonsClass "mh2"

    /// { margin-left: 1rem; margin-right: 1rem; }
    let mh3 = TachyonsClass "mh3"

    /// { margin-left: 2rem; margin-right: 2rem; }
    let mh4 = TachyonsClass "mh4"

    /// { margin-left: 4rem; margin-right: 4rem; }
    let mh5 = TachyonsClass "mh5"

    /// { margin-left: 8rem; margin-right: 8rem; }
    let mh6 = TachyonsClass "mh6"

    /// { margin-left: 16rem; margin-right: 16rem; }
    let mh7 = TachyonsClass "mh7"

    /// { margin: -0.25rem; }
    let na1 = TachyonsClass "na1"

    /// { margin: -0.5rem; }
    let na2 = TachyonsClass "na2"

    /// { margin: -1rem; }
    let na3 = TachyonsClass "na3"

    /// { margin: -2rem; }
    let na4 = TachyonsClass "na4"

    /// { margin: -4rem; }
    let na5 = TachyonsClass "na5"

    /// { margin: -8rem; }
    let na6 = TachyonsClass "na6"

    /// { margin: -16rem; }
    let na7 = TachyonsClass "na7"

    /// { margin-left: -0.25rem; }
    let nl1 = TachyonsClass "nl1"

    /// { margin-left: -0.5rem; }
    let nl2 = TachyonsClass "nl2"

    /// { margin-left: -1rem; }
    let nl3 = TachyonsClass "nl3"

    /// { margin-left: -2rem; }
    let nl4 = TachyonsClass "nl4"

    /// { margin-left: -4rem; }
    let nl5 = TachyonsClass "nl5"

    /// { margin-left: -8rem; }
    let nl6 = TachyonsClass "nl6"

    /// { margin-left: -16rem; }
    let nl7 = TachyonsClass "nl7"

    /// { margin-right: -0.25rem; }
    let nr1 = TachyonsClass "nr1"

    /// { margin-right: -0.5rem; }
    let nr2 = TachyonsClass "nr2"

    /// { margin-right: -1rem; }
    let nr3 = TachyonsClass "nr3"

    /// { margin-right: -2rem; }
    let nr4 = TachyonsClass "nr4"

    /// { margin-right: -4rem; }
    let nr5 = TachyonsClass "nr5"

    /// { margin-right: -8rem; }
    let nr6 = TachyonsClass "nr6"

    /// { margin-right: -16rem; }
    let nr7 = TachyonsClass "nr7"

    /// { margin-bottom: -0.25rem; }
    let nb1 = TachyonsClass "nb1"

    /// { margin-bottom: -0.5rem; }
    let nb2 = TachyonsClass "nb2"

    /// { margin-bottom: -1rem; }
    let nb3 = TachyonsClass "nb3"

    /// { margin-bottom: -2rem; }
    let nb4 = TachyonsClass "nb4"

    /// { margin-bottom: -4rem; }
    let nb5 = TachyonsClass "nb5"

    /// { margin-bottom: -8rem; }
    let nb6 = TachyonsClass "nb6"

    /// { margin-bottom: -16rem; }
    let nb7 = TachyonsClass "nb7"

    /// { margin-top: -0.25rem; }
    let nt1 = TachyonsClass "nt1"

    /// { margin-top: -0.5rem; }
    let nt2 = TachyonsClass "nt2"

    /// { margin-top: -1rem; }
    let nt3 = TachyonsClass "nt3"

    /// { margin-top: -2rem; }
    let nt4 = TachyonsClass "nt4"

    /// { margin-top: -4rem; }
    let nt5 = TachyonsClass "nt5"

    /// { margin-top: -8rem; }
    let nt6 = TachyonsClass "nt6"

    /// { margin-top: -16rem; }
    let nt7 = TachyonsClass "nt7"

    /// { border-collapse: collapse; border-spacing: 0; }
    let collapse = TachyonsClass "collapse"

    /// { text-decoration: line-through; }
    let strike = TachyonsClass "strike"

    /// { text-decoration: underline; }
    let underline = TachyonsClass "underline"

    /// { text-decoration: none; }
    let no_underline = TachyonsClass "no-underline"

    /// { text-align: left; }
    let tl = TachyonsClass "tl"

    /// { text-align: right; }
    let tr = TachyonsClass "tr"

    /// { text-align: center; }
    let tc = TachyonsClass "tc"

    /// { text-align: justify; }
    let tj = TachyonsClass "tj"

    /// { text-transform: capitalize; }
    let ttc = TachyonsClass "ttc"

    /// { text-transform: lowercase; }
    let ttl = TachyonsClass "ttl"

    /// { text-transform: uppercase; }
    let ttu = TachyonsClass "ttu"

    /// { text-transform: none; }
    let ttn = TachyonsClass "ttn"

    /// { font-size: 6rem; }
    let f_6 = TachyonsClass "f-6"

    /// { font-size: 6rem; }
    let f_headline = TachyonsClass "f-headline"

    /// { font-size: 5rem; }
    let f_5 = TachyonsClass "f-5"

    /// { font-size: 5rem; }
    let f_subheadline = TachyonsClass "f-subheadline"

    /// { font-size: 3rem; }
    let f1 = TachyonsClass "f1"

    /// { font-size: 2.25rem; }
    let f2 = TachyonsClass "f2"

    /// { font-size: 1.5rem; }
    let f3 = TachyonsClass "f3"

    /// { font-size: 1.25rem; }
    let f4 = TachyonsClass "f4"

    /// { font-size: 1rem; }
    let f5 = TachyonsClass "f5"

    /// { font-size: .875rem; }
    let f6 = TachyonsClass "f6"

    /// { font-size: .75rem; }
    let f7 = TachyonsClass "f7"

    /// { max-width: 30em; }
    let measure = TachyonsClass "measure"

    /// { max-width: 34em; }
    let measure_wide = TachyonsClass "measure-wide"

    /// { max-width: 20em; }
    let measure_narrow = TachyonsClass "measure-narrow"

    /// { text-indent: 1em; margin-top: 0; margin-bottom: 0; }
    let indent = TachyonsClass "indent"

    /// { font-variant: small-caps; }
    let small_caps = TachyonsClass "small-caps"

    /// { white-space: nowrap; overflow: hidden; text-overflow: ellipsis; }
    let truncate = TachyonsClass "truncate"

    /// { overflow-y: scroll; }
    let overflow_container = TachyonsClass "overflow-container"

    /// { margin-right: auto; margin-left: auto; }
    let center = TachyonsClass "center"

    /// { margin-right: auto; }
    let mr_auto = TachyonsClass "mr-auto"

    /// { margin-left: auto; }
    let ml_auto = TachyonsClass "ml-auto"

    /// { position: fixed !important; _position: absolute !important; clip: rect( 1px 1px 1px 1px ); /* IE6, IE7 */ clip: rect( 1px, 1px, 1px, 1px ); }
    let clip = TachyonsClass "clip"

    /// { white-space: normal; }
    let ws_normal = TachyonsClass "ws-normal"

    /// { white-space: nowrap; }
    let nowrap = TachyonsClass "nowrap"

    /// { vertical-align: baseline; }
    let v_base = TachyonsClass "v-base"

    /// { vertical-align: middle; }
    let v_mid = TachyonsClass "v-mid"

    /// { vertical-align: top; }
    let v_top = TachyonsClass "v-top"

    /// { vertical-align: bottom; }
    let v_btm = TachyonsClass "v-btm"

    /// { opacity: 1; transition: opacity .15s ease-in; }
    let dim = TachyonsClass "dim"

    /// { transition: opacity .15s ease-in; }
    let glow = TachyonsClass "glow"

    /// { -moz-osx-font-smoothing: grayscale; -webkit-backface-visibility: hidden; backface-visibility: hidden; -webkit-transform: translateZ( 0 ); transform: translateZ( 0 ); transition: -webkit-transform .25s ease-out; transition: transform .25s ease-out; transition: transform .25s ease-out, -webkit-transform .25s ease-out; }
    let grow = TachyonsClass "grow"

    /// { -moz-osx-font-smoothing: grayscale; -webkit-backface-visibility: hidden; backface-visibility: hidden; -webkit-transform: translateZ( 0 ); transform: translateZ( 0 ); transition: -webkit-transform .25s ease-in-out; transition: transform .25s ease-in-out; transition: transform .25s ease-in-out, -webkit-transform .25s ease-in-out; }
    let grow_large = TachyonsClass "grow-large"

    /// { cursor: pointer; position: relative; transition: all .5s cubic-bezier( .165, .84, .44, 1 ); }
    let shadow_hover = TachyonsClass "shadow-hover"

    /// { z-index: 0; }
    let z_0 = TachyonsClass "z-0"

    /// { z-index: 1; }
    let z_1 = TachyonsClass "z-1"

    /// { z-index: 2; }
    let z_2 = TachyonsClass "z-2"

    /// { z-index: 3; }
    let z_3 = TachyonsClass "z-3"

    /// { z-index: 4; }
    let z_4 = TachyonsClass "z-4"

    /// { z-index: 5; }
    let z_5 = TachyonsClass "z-5"

    /// { z-index: 999; }
    let z_999 = TachyonsClass "z-999"

    /// { z-index: 9999; }
    let z_9999 = TachyonsClass "z-9999"

    /// { z-index: 2147483647; }
    let z_max = TachyonsClass "z-max"

    /// { z-index: inherit; }
    let z_inherit = TachyonsClass "z-inherit"

    /// { z-index: initial; }
    let z_initial = TachyonsClass "z-initial"

    /// { z-index: unset; }
    let z_unset = TachyonsClass "z-unset"

    /// { background: transparent url( data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAICAYAAADED76LAAAAFElEQVR4AWPAC97/9x0eCsAEPgwAVLshdpENIxcAAAAASUVORK5CYII= ) repeat top left; }
    let debug_grid = TachyonsClass "debug-grid"

    /// { background: transparent url( data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAMklEQVR4AWOgCLz/b0epAa6UGuBOqQHOQHLUgFEDnAbcBZ4UGwDOkiCnkIhdgNgNxAYAiYlD+8sEuo8AAAAASUVORK5CYII= ) repeat top left; }
    let debug_grid_16 = TachyonsClass "debug-grid-16"

    /// { background: white url( data:image/gif;base64,R0lGODdhCAAIAPEAAADw/wDx/////wAAACwAAAAACAAIAAACDZQvgaeb/lxbAIKA8y0AOw== ) repeat top left; }
    let debug_grid_8_solid = TachyonsClass "debug-grid-8-solid"

    /// { background: white url( data:image/gif;base64,R0lGODdhEAAQAPEAAADw/wDx/xXy/////ywAAAAAEAAQAAACIZyPKckYDQFsb6ZqD85jZ2+BkwiRFKehhqQCQgDHcgwEBQA7 ) repeat top left; }
    let debug_grid_16_solid = TachyonsClass "debug-grid-16-solid"

    /// { height: 0; position: relative; }
    let aspect_ratio_ns = TachyonsClass "aspect-ratio-ns"

    /// { padding-bottom: 56.25%; }
    let aspect_ratio__16x9_ns = TachyonsClass "aspect-ratio--16x9-ns"

    /// { padding-bottom: 177.77%; }
    let aspect_ratio__9x16_ns = TachyonsClass "aspect-ratio--9x16-ns"

    /// { padding-bottom: 75%; }
    let aspect_ratio__4x3_ns = TachyonsClass "aspect-ratio--4x3-ns"

    /// { padding-bottom: 133.33%; }
    let aspect_ratio__3x4_ns = TachyonsClass "aspect-ratio--3x4-ns"

    /// { padding-bottom: 66.6%; }
    let aspect_ratio__6x4_ns = TachyonsClass "aspect-ratio--6x4-ns"

    /// { padding-bottom: 150%; }
    let aspect_ratio__4x6_ns = TachyonsClass "aspect-ratio--4x6-ns"

    /// { padding-bottom: 62.5%; }
    let aspect_ratio__8x5_ns = TachyonsClass "aspect-ratio--8x5-ns"

    /// { padding-bottom: 160%; }
    let aspect_ratio__5x8_ns = TachyonsClass "aspect-ratio--5x8-ns"

    /// { padding-bottom: 71.42%; }
    let aspect_ratio__7x5_ns = TachyonsClass "aspect-ratio--7x5-ns"

    /// { padding-bottom: 140%; }
    let aspect_ratio__5x7_ns = TachyonsClass "aspect-ratio--5x7-ns"

    /// { padding-bottom: 100%; }
    let aspect_ratio__1x1_ns = TachyonsClass "aspect-ratio--1x1-ns"

    /// { position: absolute; top: 0; right: 0; bottom: 0; left: 0; width: 100%; height: 100%; z-index: 100; }
    let aspect_ratio__object_ns = TachyonsClass "aspect-ratio--object-ns"

    /// { background-size: cover !important; }
    let cover_ns = TachyonsClass "cover-ns"

    /// { background-size: contain !important; }
    let contain_ns = TachyonsClass "contain-ns"

    /// { background-repeat: no-repeat; background-position: center center; }
    let bg_center_ns = TachyonsClass "bg-center-ns"

    /// { background-repeat: no-repeat; background-position: top center; }
    let bg_top_ns = TachyonsClass "bg-top-ns"

    /// { background-repeat: no-repeat; background-position: center right; }
    let bg_right_ns = TachyonsClass "bg-right-ns"

    /// { background-repeat: no-repeat; background-position: bottom center; }
    let bg_bottom_ns = TachyonsClass "bg-bottom-ns"

    /// { background-repeat: no-repeat; background-position: center left; }
    let bg_left_ns = TachyonsClass "bg-left-ns"

    /// { outline: 1px solid; }
    let outline_ns = TachyonsClass "outline-ns"

    /// { outline: 1px solid transparent; }
    let outline_transparent_ns = TachyonsClass "outline-transparent-ns"

    /// { outline: 0; }
    let outline_0_ns = TachyonsClass "outline-0-ns"

    /// { border-style: solid; border-width: 1px; }
    let ba_ns = TachyonsClass "ba-ns"

    /// { border-top-style: solid; border-top-width: 1px; }
    let bt_ns = TachyonsClass "bt-ns"

    /// { border-right-style: solid; border-right-width: 1px; }
    let br_ns = TachyonsClass "br-ns"

    /// { border-bottom-style: solid; border-bottom-width: 1px; }
    let bb_ns = TachyonsClass "bb-ns"

    /// { border-left-style: solid; border-left-width: 1px; }
    let bl_ns = TachyonsClass "bl-ns"

    /// { border-style: none; border-width: 0; }
    let bn_ns = TachyonsClass "bn-ns"

    /// { border-radius: 0; }
    let br0_ns = TachyonsClass "br0-ns"

    /// { border-radius: .125rem; }
    let br1_ns = TachyonsClass "br1-ns"

    /// { border-radius: .25rem; }
    let br2_ns = TachyonsClass "br2-ns"

    /// { border-radius: .5rem; }
    let br3_ns = TachyonsClass "br3-ns"

    /// { border-radius: 1rem; }
    let br4_ns = TachyonsClass "br4-ns"

    /// { border-radius: 100%; }
    let br_100_ns = TachyonsClass "br-100-ns"

    /// { border-radius: 9999px; }
    let br_pill_ns = TachyonsClass "br-pill-ns"

    /// { border-top-left-radius: 0; border-top-right-radius: 0; }
    let br__bottom_ns = TachyonsClass "br--bottom-ns"

    /// { border-bottom-left-radius: 0; border-bottom-right-radius: 0; }
    let br__top_ns = TachyonsClass "br--top-ns"

    /// { border-top-left-radius: 0; border-bottom-left-radius: 0; }
    let br__right_ns = TachyonsClass "br--right-ns"

    /// { border-top-right-radius: 0; border-bottom-right-radius: 0; }
    let br__left_ns = TachyonsClass "br--left-ns"

    /// { border-radius: inherit; }
    let br_inherit_ns = TachyonsClass "br-inherit-ns"

    /// { border-radius: initial; }
    let br_initial_ns = TachyonsClass "br-initial-ns"

    /// { border-radius: unset; }
    let br_unset_ns = TachyonsClass "br-unset-ns"

    /// { border-style: dotted; }
    let b__dotted_ns = TachyonsClass "b--dotted-ns"

    /// { border-style: dashed; }
    let b__dashed_ns = TachyonsClass "b--dashed-ns"

    /// { border-style: solid; }
    let b__solid_ns = TachyonsClass "b--solid-ns"

    /// { border-style: none; }
    let b__none_ns = TachyonsClass "b--none-ns"

    /// { border-width: 0; }
    let bw0_ns = TachyonsClass "bw0-ns"

    /// { border-width: .125rem; }
    let bw1_ns = TachyonsClass "bw1-ns"

    /// { border-width: .25rem; }
    let bw2_ns = TachyonsClass "bw2-ns"

    /// { border-width: .5rem; }
    let bw3_ns = TachyonsClass "bw3-ns"

    /// { border-width: 1rem; }
    let bw4_ns = TachyonsClass "bw4-ns"

    /// { border-width: 2rem; }
    let bw5_ns = TachyonsClass "bw5-ns"

    /// { border-top-width: 0; }
    let bt_0_ns = TachyonsClass "bt-0-ns"

    /// { border-right-width: 0; }
    let br_0_ns = TachyonsClass "br-0-ns"

    /// { border-bottom-width: 0; }
    let bb_0_ns = TachyonsClass "bb-0-ns"

    /// { border-left-width: 0; }
    let bl_0_ns = TachyonsClass "bl-0-ns"

    /// { box-shadow: 0 0 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_1_ns = TachyonsClass "shadow-1-ns"

    /// { box-shadow: 0 0 8px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_2_ns = TachyonsClass "shadow-2-ns"

    /// { box-shadow: 2px 2px 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_3_ns = TachyonsClass "shadow-3-ns"

    /// { box-shadow: 2px 2px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_4_ns = TachyonsClass "shadow-4-ns"

    /// { box-shadow: 4px 4px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_5_ns = TachyonsClass "shadow-5-ns"

    /// { top: 0; }
    let top_0_ns = TachyonsClass "top-0-ns"

    /// { left: 0; }
    let left_0_ns = TachyonsClass "left-0-ns"

    /// { right: 0; }
    let right_0_ns = TachyonsClass "right-0-ns"

    /// { bottom: 0; }
    let bottom_0_ns = TachyonsClass "bottom-0-ns"

    /// { top: 1rem; }
    let top_1_ns = TachyonsClass "top-1-ns"

    /// { left: 1rem; }
    let left_1_ns = TachyonsClass "left-1-ns"

    /// { right: 1rem; }
    let right_1_ns = TachyonsClass "right-1-ns"

    /// { bottom: 1rem; }
    let bottom_1_ns = TachyonsClass "bottom-1-ns"

    /// { top: 2rem; }
    let top_2_ns = TachyonsClass "top-2-ns"

    /// { left: 2rem; }
    let left_2_ns = TachyonsClass "left-2-ns"

    /// { right: 2rem; }
    let right_2_ns = TachyonsClass "right-2-ns"

    /// { bottom: 2rem; }
    let bottom_2_ns = TachyonsClass "bottom-2-ns"

    /// { top: -1rem; }
    let top__1_ns = TachyonsClass "top--1-ns"

    /// { right: -1rem; }
    let right__1_ns = TachyonsClass "right--1-ns"

    /// { bottom: -1rem; }
    let bottom__1_ns = TachyonsClass "bottom--1-ns"

    /// { left: -1rem; }
    let left__1_ns = TachyonsClass "left--1-ns"

    /// { top: -2rem; }
    let top__2_ns = TachyonsClass "top--2-ns"

    /// { right: -2rem; }
    let right__2_ns = TachyonsClass "right--2-ns"

    /// { bottom: -2rem; }
    let bottom__2_ns = TachyonsClass "bottom--2-ns"

    /// { left: -2rem; }
    let left__2_ns = TachyonsClass "left--2-ns"

    /// { top: 0; right: 0; bottom: 0; left: 0; }
    let absolute__fill_ns = TachyonsClass "absolute--fill-ns"

    /// { clear: left; }
    let cl_ns = TachyonsClass "cl-ns"

    /// { clear: right; }
    let cr_ns = TachyonsClass "cr-ns"

    /// { clear: both; }
    let cb_ns = TachyonsClass "cb-ns"

    /// { clear: none; }
    let cn_ns = TachyonsClass "cn-ns"

    /// { display: none; }
    let dn_ns = TachyonsClass "dn-ns"

    /// { display: inline; }
    let di_ns = TachyonsClass "di-ns"

    /// { display: block; }
    let db_ns = TachyonsClass "db-ns"

    /// { display: inline-block; }
    let dib_ns = TachyonsClass "dib-ns"

    /// { display: inline-table; }
    let dit_ns = TachyonsClass "dit-ns"

    /// { display: table; }
    let dt_ns = TachyonsClass "dt-ns"

    /// { display: table-cell; }
    let dtc_ns = TachyonsClass "dtc-ns"

    /// { display: table-row; }
    let dt_row_ns = TachyonsClass "dt-row-ns"

    /// { display: table-row-group; }
    let dt_row_group_ns = TachyonsClass "dt-row-group-ns"

    /// { display: table-column; }
    let dt_column_ns = TachyonsClass "dt-column-ns"

    /// { display: table-column-group; }
    let dt_column_group_ns = TachyonsClass "dt-column-group-ns"

    /// { table-layout: fixed; width: 100%; }
    let dt__fixed_ns = TachyonsClass "dt--fixed-ns"

    /// { display: flex; }
    let flex_ns = TachyonsClass "flex-ns"

    /// { display: inline-flex; }
    let inline_flex_ns = TachyonsClass "inline-flex-ns"

    /// { flex: 1 1 auto; min-width: 0; /* 1 */ min-height: 0; /* 1 */ }
    let flex_auto_ns = TachyonsClass "flex-auto-ns"

    /// { flex: none; }
    let flex_none_ns = TachyonsClass "flex-none-ns"

    /// { flex-direction: column; }
    let flex_column_ns = TachyonsClass "flex-column-ns"

    /// { flex-direction: row; }
    let flex_row_ns = TachyonsClass "flex-row-ns"

    /// { flex-wrap: wrap; }
    let flex_wrap_ns = TachyonsClass "flex-wrap-ns"

    /// { flex-wrap: nowrap; }
    let flex_nowrap_ns = TachyonsClass "flex-nowrap-ns"

    /// { flex-wrap: wrap-reverse; }
    let flex_wrap_reverse_ns = TachyonsClass "flex-wrap-reverse-ns"

    /// { flex-direction: column-reverse; }
    let flex_column_reverse_ns = TachyonsClass "flex-column-reverse-ns"

    /// { flex-direction: row-reverse; }
    let flex_row_reverse_ns = TachyonsClass "flex-row-reverse-ns"

    /// { align-items: flex-start; }
    let items_start_ns = TachyonsClass "items-start-ns"

    /// { align-items: flex-end; }
    let items_end_ns = TachyonsClass "items-end-ns"

    /// { align-items: center; }
    let items_center_ns = TachyonsClass "items-center-ns"

    /// { align-items: baseline; }
    let items_baseline_ns = TachyonsClass "items-baseline-ns"

    /// { align-items: stretch; }
    let items_stretch_ns = TachyonsClass "items-stretch-ns"

    /// { align-self: flex-start; }
    let self_start_ns = TachyonsClass "self-start-ns"

    /// { align-self: flex-end; }
    let self_end_ns = TachyonsClass "self-end-ns"

    /// { align-self: center; }
    let self_center_ns = TachyonsClass "self-center-ns"

    /// { align-self: baseline; }
    let self_baseline_ns = TachyonsClass "self-baseline-ns"

    /// { align-self: stretch; }
    let self_stretch_ns = TachyonsClass "self-stretch-ns"

    /// { justify-content: flex-start; }
    let justify_start_ns = TachyonsClass "justify-start-ns"

    /// { justify-content: flex-end; }
    let justify_end_ns = TachyonsClass "justify-end-ns"

    /// { justify-content: center; }
    let justify_center_ns = TachyonsClass "justify-center-ns"

    /// { justify-content: space-between; }
    let justify_between_ns = TachyonsClass "justify-between-ns"

    /// { justify-content: space-around; }
    let justify_around_ns = TachyonsClass "justify-around-ns"

    /// { align-content: flex-start; }
    let content_start_ns = TachyonsClass "content-start-ns"

    /// { align-content: flex-end; }
    let content_end_ns = TachyonsClass "content-end-ns"

    /// { align-content: center; }
    let content_center_ns = TachyonsClass "content-center-ns"

    /// { align-content: space-between; }
    let content_between_ns = TachyonsClass "content-between-ns"

    /// { align-content: space-around; }
    let content_around_ns = TachyonsClass "content-around-ns"

    /// { align-content: stretch; }
    let content_stretch_ns = TachyonsClass "content-stretch-ns"

    /// { order: 0; }
    let order_0_ns = TachyonsClass "order-0-ns"

    /// { order: 1; }
    let order_1_ns = TachyonsClass "order-1-ns"

    /// { order: 2; }
    let order_2_ns = TachyonsClass "order-2-ns"

    /// { order: 3; }
    let order_3_ns = TachyonsClass "order-3-ns"

    /// { order: 4; }
    let order_4_ns = TachyonsClass "order-4-ns"

    /// { order: 5; }
    let order_5_ns = TachyonsClass "order-5-ns"

    /// { order: 6; }
    let order_6_ns = TachyonsClass "order-6-ns"

    /// { order: 7; }
    let order_7_ns = TachyonsClass "order-7-ns"

    /// { order: 8; }
    let order_8_ns = TachyonsClass "order-8-ns"

    /// { order: 99999; }
    let order_last_ns = TachyonsClass "order-last-ns"

    /// { flex-grow: 0; }
    let flex_grow_0_ns = TachyonsClass "flex-grow-0-ns"

    /// { flex-grow: 1; }
    let flex_grow_1_ns = TachyonsClass "flex-grow-1-ns"

    /// { flex-shrink: 0; }
    let flex_shrink_0_ns = TachyonsClass "flex-shrink-0-ns"

    /// { flex-shrink: 1; }
    let flex_shrink_1_ns = TachyonsClass "flex-shrink-1-ns"

    /// { float: left; _display: inline; }
    let fl_ns = TachyonsClass "fl-ns"

    /// { float: right; _display: inline; }
    let fr_ns = TachyonsClass "fr-ns"

    /// { float: none; }
    let fn_ns = TachyonsClass "fn-ns"

    /// { font-style: italic; }
    let i_ns = TachyonsClass "i-ns"

    /// { font-style: normal; }
    let fs_normal_ns = TachyonsClass "fs-normal-ns"

    /// { font-weight: normal; }
    let normal_ns = TachyonsClass "normal-ns"

    /// { font-weight: bold; }
    let b_ns = TachyonsClass "b-ns"

    /// { font-weight: 100; }
    let fw1_ns = TachyonsClass "fw1-ns"

    /// { font-weight: 200; }
    let fw2_ns = TachyonsClass "fw2-ns"

    /// { font-weight: 300; }
    let fw3_ns = TachyonsClass "fw3-ns"

    /// { font-weight: 400; }
    let fw4_ns = TachyonsClass "fw4-ns"

    /// { font-weight: 500; }
    let fw5_ns = TachyonsClass "fw5-ns"

    /// { font-weight: 600; }
    let fw6_ns = TachyonsClass "fw6-ns"

    /// { font-weight: 700; }
    let fw7_ns = TachyonsClass "fw7-ns"

    /// { font-weight: 800; }
    let fw8_ns = TachyonsClass "fw8-ns"

    /// { font-weight: 900; }
    let fw9_ns = TachyonsClass "fw9-ns"

    /// { height: 1rem; }
    let h1_ns = TachyonsClass "h1-ns"

    /// { height: 2rem; }
    let h2_ns = TachyonsClass "h2-ns"

    /// { height: 4rem; }
    let h3_ns = TachyonsClass "h3-ns"

    /// { height: 8rem; }
    let h4_ns = TachyonsClass "h4-ns"

    /// { height: 16rem; }
    let h5_ns = TachyonsClass "h5-ns"

    /// { height: 25%; }
    let h_25_ns = TachyonsClass "h-25-ns"

    /// { height: 50%; }
    let h_50_ns = TachyonsClass "h-50-ns"

    /// { height: 75%; }
    let h_75_ns = TachyonsClass "h-75-ns"

    /// { height: 100%; }
    let h_100_ns = TachyonsClass "h-100-ns"

    /// { min-height: 100%; }
    let min_h_100_ns = TachyonsClass "min-h-100-ns"

    /// { height: 25vh; }
    let vh_25_ns = TachyonsClass "vh-25-ns"

    /// { height: 50vh; }
    let vh_50_ns = TachyonsClass "vh-50-ns"

    /// { height: 75vh; }
    let vh_75_ns = TachyonsClass "vh-75-ns"

    /// { height: 100vh; }
    let vh_100_ns = TachyonsClass "vh-100-ns"

    /// { min-height: 100vh; }
    let min_vh_100_ns = TachyonsClass "min-vh-100-ns"

    /// { height: auto; }
    let h_auto_ns = TachyonsClass "h-auto-ns"

    /// { height: inherit; }
    let h_inherit_ns = TachyonsClass "h-inherit-ns"

    /// { letter-spacing: .1em; }
    let tracked_ns = TachyonsClass "tracked-ns"

    /// { letter-spacing: -.05em; }
    let tracked_tight_ns = TachyonsClass "tracked-tight-ns"

    /// { letter-spacing: .25em; }
    let tracked_mega_ns = TachyonsClass "tracked-mega-ns"

    /// { line-height: 1; }
    let lh_solid_ns = TachyonsClass "lh-solid-ns"

    /// { line-height: 1.25; }
    let lh_title_ns = TachyonsClass "lh-title-ns"

    /// { line-height: 1.5; }
    let lh_copy_ns = TachyonsClass "lh-copy-ns"

    /// { max-width: 100%; }
    let mw_100_ns = TachyonsClass "mw-100-ns"

    /// { max-width: 1rem; }
    let mw1_ns = TachyonsClass "mw1-ns"

    /// { max-width: 2rem; }
    let mw2_ns = TachyonsClass "mw2-ns"

    /// { max-width: 4rem; }
    let mw3_ns = TachyonsClass "mw3-ns"

    /// { max-width: 8rem; }
    let mw4_ns = TachyonsClass "mw4-ns"

    /// { max-width: 16rem; }
    let mw5_ns = TachyonsClass "mw5-ns"

    /// { max-width: 32rem; }
    let mw6_ns = TachyonsClass "mw6-ns"

    /// { max-width: 48rem; }
    let mw7_ns = TachyonsClass "mw7-ns"

    /// { max-width: 64rem; }
    let mw8_ns = TachyonsClass "mw8-ns"

    /// { max-width: 96rem; }
    let mw9_ns = TachyonsClass "mw9-ns"

    /// { max-width: none; }
    let mw_none_ns = TachyonsClass "mw-none-ns"

    /// { width: 1rem; }
    let w1_ns = TachyonsClass "w1-ns"

    /// { width: 2rem; }
    let w2_ns = TachyonsClass "w2-ns"

    /// { width: 4rem; }
    let w3_ns = TachyonsClass "w3-ns"

    /// { width: 8rem; }
    let w4_ns = TachyonsClass "w4-ns"

    /// { width: 16rem; }
    let w5_ns = TachyonsClass "w5-ns"

    /// { width: 10%; }
    let w_10_ns = TachyonsClass "w-10-ns"

    /// { width: 20%; }
    let w_20_ns = TachyonsClass "w-20-ns"

    /// { width: 25%; }
    let w_25_ns = TachyonsClass "w-25-ns"

    /// { width: 30%; }
    let w_30_ns = TachyonsClass "w-30-ns"

    /// { width: 33%; }
    let w_33_ns = TachyonsClass "w-33-ns"

    /// { width: 34%; }
    let w_34_ns = TachyonsClass "w-34-ns"

    /// { width: 40%; }
    let w_40_ns = TachyonsClass "w-40-ns"

    /// { width: 50%; }
    let w_50_ns = TachyonsClass "w-50-ns"

    /// { width: 60%; }
    let w_60_ns = TachyonsClass "w-60-ns"

    /// { width: 70%; }
    let w_70_ns = TachyonsClass "w-70-ns"

    /// { width: 75%; }
    let w_75_ns = TachyonsClass "w-75-ns"

    /// { width: 80%; }
    let w_80_ns = TachyonsClass "w-80-ns"

    /// { width: 90%; }
    let w_90_ns = TachyonsClass "w-90-ns"

    /// { width: 100%; }
    let w_100_ns = TachyonsClass "w-100-ns"

    /// { width: 33.33333%; }
    let w_third_ns = TachyonsClass "w-third-ns"

    /// { width: 66.66667%; }
    let w_two_thirds_ns = TachyonsClass "w-two-thirds-ns"

    /// { width: auto; }
    let w_auto_ns = TachyonsClass "w-auto-ns"

    /// { overflow: visible; }
    let overflow_visible_ns = TachyonsClass "overflow-visible-ns"

    /// { overflow: hidden; }
    let overflow_hidden_ns = TachyonsClass "overflow-hidden-ns"

    /// { overflow: scroll; }
    let overflow_scroll_ns = TachyonsClass "overflow-scroll-ns"

    /// { overflow: auto; }
    let overflow_auto_ns = TachyonsClass "overflow-auto-ns"

    /// { overflow-x: visible; }
    let overflow_x_visible_ns = TachyonsClass "overflow-x-visible-ns"

    /// { overflow-x: hidden; }
    let overflow_x_hidden_ns = TachyonsClass "overflow-x-hidden-ns"

    /// { overflow-x: scroll; }
    let overflow_x_scroll_ns = TachyonsClass "overflow-x-scroll-ns"

    /// { overflow-x: auto; }
    let overflow_x_auto_ns = TachyonsClass "overflow-x-auto-ns"

    /// { overflow-y: visible; }
    let overflow_y_visible_ns = TachyonsClass "overflow-y-visible-ns"

    /// { overflow-y: hidden; }
    let overflow_y_hidden_ns = TachyonsClass "overflow-y-hidden-ns"

    /// { overflow-y: scroll; }
    let overflow_y_scroll_ns = TachyonsClass "overflow-y-scroll-ns"

    /// { overflow-y: auto; }
    let overflow_y_auto_ns = TachyonsClass "overflow-y-auto-ns"

    /// { position: static; }
    let static_ns = TachyonsClass "static-ns"

    /// { position: relative; }
    let relative_ns = TachyonsClass "relative-ns"

    /// { position: absolute; }
    let absolute_ns = TachyonsClass "absolute-ns"

    /// { position: fixed; }
    let fixed_ns = TachyonsClass "fixed-ns"

    /// { -webkit-transform: rotate( 45deg ); transform: rotate( 45deg ); }
    let rotate_45_ns = TachyonsClass "rotate-45-ns"

    /// { -webkit-transform: rotate( 90deg ); transform: rotate( 90deg ); }
    let rotate_90_ns = TachyonsClass "rotate-90-ns"

    /// { -webkit-transform: rotate( 135deg ); transform: rotate( 135deg ); }
    let rotate_135_ns = TachyonsClass "rotate-135-ns"

    /// { -webkit-transform: rotate( 180deg ); transform: rotate( 180deg ); }
    let rotate_180_ns = TachyonsClass "rotate-180-ns"

    /// { -webkit-transform: rotate( 225deg ); transform: rotate( 225deg ); }
    let rotate_225_ns = TachyonsClass "rotate-225-ns"

    /// { -webkit-transform: rotate( 270deg ); transform: rotate( 270deg ); }
    let rotate_270_ns = TachyonsClass "rotate-270-ns"

    /// { -webkit-transform: rotate( 315deg ); transform: rotate( 315deg ); }
    let rotate_315_ns = TachyonsClass "rotate-315-ns"

    /// { padding: 0; }
    let pa0_ns = TachyonsClass "pa0-ns"

    /// { padding: .25rem; }
    let pa1_ns = TachyonsClass "pa1-ns"

    /// { padding: .5rem; }
    let pa2_ns = TachyonsClass "pa2-ns"

    /// { padding: 1rem; }
    let pa3_ns = TachyonsClass "pa3-ns"

    /// { padding: 2rem; }
    let pa4_ns = TachyonsClass "pa4-ns"

    /// { padding: 4rem; }
    let pa5_ns = TachyonsClass "pa5-ns"

    /// { padding: 8rem; }
    let pa6_ns = TachyonsClass "pa6-ns"

    /// { padding: 16rem; }
    let pa7_ns = TachyonsClass "pa7-ns"

    /// { padding-left: 0; }
    let pl0_ns = TachyonsClass "pl0-ns"

    /// { padding-left: .25rem; }
    let pl1_ns = TachyonsClass "pl1-ns"

    /// { padding-left: .5rem; }
    let pl2_ns = TachyonsClass "pl2-ns"

    /// { padding-left: 1rem; }
    let pl3_ns = TachyonsClass "pl3-ns"

    /// { padding-left: 2rem; }
    let pl4_ns = TachyonsClass "pl4-ns"

    /// { padding-left: 4rem; }
    let pl5_ns = TachyonsClass "pl5-ns"

    /// { padding-left: 8rem; }
    let pl6_ns = TachyonsClass "pl6-ns"

    /// { padding-left: 16rem; }
    let pl7_ns = TachyonsClass "pl7-ns"

    /// { padding-right: 0; }
    let pr0_ns = TachyonsClass "pr0-ns"

    /// { padding-right: .25rem; }
    let pr1_ns = TachyonsClass "pr1-ns"

    /// { padding-right: .5rem; }
    let pr2_ns = TachyonsClass "pr2-ns"

    /// { padding-right: 1rem; }
    let pr3_ns = TachyonsClass "pr3-ns"

    /// { padding-right: 2rem; }
    let pr4_ns = TachyonsClass "pr4-ns"

    /// { padding-right: 4rem; }
    let pr5_ns = TachyonsClass "pr5-ns"

    /// { padding-right: 8rem; }
    let pr6_ns = TachyonsClass "pr6-ns"

    /// { padding-right: 16rem; }
    let pr7_ns = TachyonsClass "pr7-ns"

    /// { padding-bottom: 0; }
    let pb0_ns = TachyonsClass "pb0-ns"

    /// { padding-bottom: .25rem; }
    let pb1_ns = TachyonsClass "pb1-ns"

    /// { padding-bottom: .5rem; }
    let pb2_ns = TachyonsClass "pb2-ns"

    /// { padding-bottom: 1rem; }
    let pb3_ns = TachyonsClass "pb3-ns"

    /// { padding-bottom: 2rem; }
    let pb4_ns = TachyonsClass "pb4-ns"

    /// { padding-bottom: 4rem; }
    let pb5_ns = TachyonsClass "pb5-ns"

    /// { padding-bottom: 8rem; }
    let pb6_ns = TachyonsClass "pb6-ns"

    /// { padding-bottom: 16rem; }
    let pb7_ns = TachyonsClass "pb7-ns"

    /// { padding-top: 0; }
    let pt0_ns = TachyonsClass "pt0-ns"

    /// { padding-top: .25rem; }
    let pt1_ns = TachyonsClass "pt1-ns"

    /// { padding-top: .5rem; }
    let pt2_ns = TachyonsClass "pt2-ns"

    /// { padding-top: 1rem; }
    let pt3_ns = TachyonsClass "pt3-ns"

    /// { padding-top: 2rem; }
    let pt4_ns = TachyonsClass "pt4-ns"

    /// { padding-top: 4rem; }
    let pt5_ns = TachyonsClass "pt5-ns"

    /// { padding-top: 8rem; }
    let pt6_ns = TachyonsClass "pt6-ns"

    /// { padding-top: 16rem; }
    let pt7_ns = TachyonsClass "pt7-ns"

    /// { padding-top: 0; padding-bottom: 0; }
    let pv0_ns = TachyonsClass "pv0-ns"

    /// { padding-top: .25rem; padding-bottom: .25rem; }
    let pv1_ns = TachyonsClass "pv1-ns"

    /// { padding-top: .5rem; padding-bottom: .5rem; }
    let pv2_ns = TachyonsClass "pv2-ns"

    /// { padding-top: 1rem; padding-bottom: 1rem; }
    let pv3_ns = TachyonsClass "pv3-ns"

    /// { padding-top: 2rem; padding-bottom: 2rem; }
    let pv4_ns = TachyonsClass "pv4-ns"

    /// { padding-top: 4rem; padding-bottom: 4rem; }
    let pv5_ns = TachyonsClass "pv5-ns"

    /// { padding-top: 8rem; padding-bottom: 8rem; }
    let pv6_ns = TachyonsClass "pv6-ns"

    /// { padding-top: 16rem; padding-bottom: 16rem; }
    let pv7_ns = TachyonsClass "pv7-ns"

    /// { padding-left: 0; padding-right: 0; }
    let ph0_ns = TachyonsClass "ph0-ns"

    /// { padding-left: .25rem; padding-right: .25rem; }
    let ph1_ns = TachyonsClass "ph1-ns"

    /// { padding-left: .5rem; padding-right: .5rem; }
    let ph2_ns = TachyonsClass "ph2-ns"

    /// { padding-left: 1rem; padding-right: 1rem; }
    let ph3_ns = TachyonsClass "ph3-ns"

    /// { padding-left: 2rem; padding-right: 2rem; }
    let ph4_ns = TachyonsClass "ph4-ns"

    /// { padding-left: 4rem; padding-right: 4rem; }
    let ph5_ns = TachyonsClass "ph5-ns"

    /// { padding-left: 8rem; padding-right: 8rem; }
    let ph6_ns = TachyonsClass "ph6-ns"

    /// { padding-left: 16rem; padding-right: 16rem; }
    let ph7_ns = TachyonsClass "ph7-ns"

    /// { margin: 0; }
    let ma0_ns = TachyonsClass "ma0-ns"

    /// { margin: .25rem; }
    let ma1_ns = TachyonsClass "ma1-ns"

    /// { margin: .5rem; }
    let ma2_ns = TachyonsClass "ma2-ns"

    /// { margin: 1rem; }
    let ma3_ns = TachyonsClass "ma3-ns"

    /// { margin: 2rem; }
    let ma4_ns = TachyonsClass "ma4-ns"

    /// { margin: 4rem; }
    let ma5_ns = TachyonsClass "ma5-ns"

    /// { margin: 8rem; }
    let ma6_ns = TachyonsClass "ma6-ns"

    /// { margin: 16rem; }
    let ma7_ns = TachyonsClass "ma7-ns"

    /// { margin-left: 0; }
    let ml0_ns = TachyonsClass "ml0-ns"

    /// { margin-left: .25rem; }
    let ml1_ns = TachyonsClass "ml1-ns"

    /// { margin-left: .5rem; }
    let ml2_ns = TachyonsClass "ml2-ns"

    /// { margin-left: 1rem; }
    let ml3_ns = TachyonsClass "ml3-ns"

    /// { margin-left: 2rem; }
    let ml4_ns = TachyonsClass "ml4-ns"

    /// { margin-left: 4rem; }
    let ml5_ns = TachyonsClass "ml5-ns"

    /// { margin-left: 8rem; }
    let ml6_ns = TachyonsClass "ml6-ns"

    /// { margin-left: 16rem; }
    let ml7_ns = TachyonsClass "ml7-ns"

    /// { margin-right: 0; }
    let mr0_ns = TachyonsClass "mr0-ns"

    /// { margin-right: .25rem; }
    let mr1_ns = TachyonsClass "mr1-ns"

    /// { margin-right: .5rem; }
    let mr2_ns = TachyonsClass "mr2-ns"

    /// { margin-right: 1rem; }
    let mr3_ns = TachyonsClass "mr3-ns"

    /// { margin-right: 2rem; }
    let mr4_ns = TachyonsClass "mr4-ns"

    /// { margin-right: 4rem; }
    let mr5_ns = TachyonsClass "mr5-ns"

    /// { margin-right: 8rem; }
    let mr6_ns = TachyonsClass "mr6-ns"

    /// { margin-right: 16rem; }
    let mr7_ns = TachyonsClass "mr7-ns"

    /// { margin-bottom: 0; }
    let mb0_ns = TachyonsClass "mb0-ns"

    /// { margin-bottom: .25rem; }
    let mb1_ns = TachyonsClass "mb1-ns"

    /// { margin-bottom: .5rem; }
    let mb2_ns = TachyonsClass "mb2-ns"

    /// { margin-bottom: 1rem; }
    let mb3_ns = TachyonsClass "mb3-ns"

    /// { margin-bottom: 2rem; }
    let mb4_ns = TachyonsClass "mb4-ns"

    /// { margin-bottom: 4rem; }
    let mb5_ns = TachyonsClass "mb5-ns"

    /// { margin-bottom: 8rem; }
    let mb6_ns = TachyonsClass "mb6-ns"

    /// { margin-bottom: 16rem; }
    let mb7_ns = TachyonsClass "mb7-ns"

    /// { margin-top: 0; }
    let mt0_ns = TachyonsClass "mt0-ns"

    /// { margin-top: .25rem; }
    let mt1_ns = TachyonsClass "mt1-ns"

    /// { margin-top: .5rem; }
    let mt2_ns = TachyonsClass "mt2-ns"

    /// { margin-top: 1rem; }
    let mt3_ns = TachyonsClass "mt3-ns"

    /// { margin-top: 2rem; }
    let mt4_ns = TachyonsClass "mt4-ns"

    /// { margin-top: 4rem; }
    let mt5_ns = TachyonsClass "mt5-ns"

    /// { margin-top: 8rem; }
    let mt6_ns = TachyonsClass "mt6-ns"

    /// { margin-top: 16rem; }
    let mt7_ns = TachyonsClass "mt7-ns"

    /// { margin-top: 0; margin-bottom: 0; }
    let mv0_ns = TachyonsClass "mv0-ns"

    /// { margin-top: .25rem; margin-bottom: .25rem; }
    let mv1_ns = TachyonsClass "mv1-ns"

    /// { margin-top: .5rem; margin-bottom: .5rem; }
    let mv2_ns = TachyonsClass "mv2-ns"

    /// { margin-top: 1rem; margin-bottom: 1rem; }
    let mv3_ns = TachyonsClass "mv3-ns"

    /// { margin-top: 2rem; margin-bottom: 2rem; }
    let mv4_ns = TachyonsClass "mv4-ns"

    /// { margin-top: 4rem; margin-bottom: 4rem; }
    let mv5_ns = TachyonsClass "mv5-ns"

    /// { margin-top: 8rem; margin-bottom: 8rem; }
    let mv6_ns = TachyonsClass "mv6-ns"

    /// { margin-top: 16rem; margin-bottom: 16rem; }
    let mv7_ns = TachyonsClass "mv7-ns"

    /// { margin-left: 0; margin-right: 0; }
    let mh0_ns = TachyonsClass "mh0-ns"

    /// { margin-left: .25rem; margin-right: .25rem; }
    let mh1_ns = TachyonsClass "mh1-ns"

    /// { margin-left: .5rem; margin-right: .5rem; }
    let mh2_ns = TachyonsClass "mh2-ns"

    /// { margin-left: 1rem; margin-right: 1rem; }
    let mh3_ns = TachyonsClass "mh3-ns"

    /// { margin-left: 2rem; margin-right: 2rem; }
    let mh4_ns = TachyonsClass "mh4-ns"

    /// { margin-left: 4rem; margin-right: 4rem; }
    let mh5_ns = TachyonsClass "mh5-ns"

    /// { margin-left: 8rem; margin-right: 8rem; }
    let mh6_ns = TachyonsClass "mh6-ns"

    /// { margin-left: 16rem; margin-right: 16rem; }
    let mh7_ns = TachyonsClass "mh7-ns"

    /// { margin: -0.25rem; }
    let na1_ns = TachyonsClass "na1-ns"

    /// { margin: -0.5rem; }
    let na2_ns = TachyonsClass "na2-ns"

    /// { margin: -1rem; }
    let na3_ns = TachyonsClass "na3-ns"

    /// { margin: -2rem; }
    let na4_ns = TachyonsClass "na4-ns"

    /// { margin: -4rem; }
    let na5_ns = TachyonsClass "na5-ns"

    /// { margin: -8rem; }
    let na6_ns = TachyonsClass "na6-ns"

    /// { margin: -16rem; }
    let na7_ns = TachyonsClass "na7-ns"

    /// { margin-left: -0.25rem; }
    let nl1_ns = TachyonsClass "nl1-ns"

    /// { margin-left: -0.5rem; }
    let nl2_ns = TachyonsClass "nl2-ns"

    /// { margin-left: -1rem; }
    let nl3_ns = TachyonsClass "nl3-ns"

    /// { margin-left: -2rem; }
    let nl4_ns = TachyonsClass "nl4-ns"

    /// { margin-left: -4rem; }
    let nl5_ns = TachyonsClass "nl5-ns"

    /// { margin-left: -8rem; }
    let nl6_ns = TachyonsClass "nl6-ns"

    /// { margin-left: -16rem; }
    let nl7_ns = TachyonsClass "nl7-ns"

    /// { margin-right: -0.25rem; }
    let nr1_ns = TachyonsClass "nr1-ns"

    /// { margin-right: -0.5rem; }
    let nr2_ns = TachyonsClass "nr2-ns"

    /// { margin-right: -1rem; }
    let nr3_ns = TachyonsClass "nr3-ns"

    /// { margin-right: -2rem; }
    let nr4_ns = TachyonsClass "nr4-ns"

    /// { margin-right: -4rem; }
    let nr5_ns = TachyonsClass "nr5-ns"

    /// { margin-right: -8rem; }
    let nr6_ns = TachyonsClass "nr6-ns"

    /// { margin-right: -16rem; }
    let nr7_ns = TachyonsClass "nr7-ns"

    /// { margin-bottom: -0.25rem; }
    let nb1_ns = TachyonsClass "nb1-ns"

    /// { margin-bottom: -0.5rem; }
    let nb2_ns = TachyonsClass "nb2-ns"

    /// { margin-bottom: -1rem; }
    let nb3_ns = TachyonsClass "nb3-ns"

    /// { margin-bottom: -2rem; }
    let nb4_ns = TachyonsClass "nb4-ns"

    /// { margin-bottom: -4rem; }
    let nb5_ns = TachyonsClass "nb5-ns"

    /// { margin-bottom: -8rem; }
    let nb6_ns = TachyonsClass "nb6-ns"

    /// { margin-bottom: -16rem; }
    let nb7_ns = TachyonsClass "nb7-ns"

    /// { margin-top: -0.25rem; }
    let nt1_ns = TachyonsClass "nt1-ns"

    /// { margin-top: -0.5rem; }
    let nt2_ns = TachyonsClass "nt2-ns"

    /// { margin-top: -1rem; }
    let nt3_ns = TachyonsClass "nt3-ns"

    /// { margin-top: -2rem; }
    let nt4_ns = TachyonsClass "nt4-ns"

    /// { margin-top: -4rem; }
    let nt5_ns = TachyonsClass "nt5-ns"

    /// { margin-top: -8rem; }
    let nt6_ns = TachyonsClass "nt6-ns"

    /// { margin-top: -16rem; }
    let nt7_ns = TachyonsClass "nt7-ns"

    /// { text-decoration: line-through; }
    let strike_ns = TachyonsClass "strike-ns"

    /// { text-decoration: underline; }
    let underline_ns = TachyonsClass "underline-ns"

    /// { text-decoration: none; }
    let no_underline_ns = TachyonsClass "no-underline-ns"

    /// { text-align: left; }
    let tl_ns = TachyonsClass "tl-ns"

    /// { text-align: right; }
    let tr_ns = TachyonsClass "tr-ns"

    /// { text-align: center; }
    let tc_ns = TachyonsClass "tc-ns"

    /// { text-align: justify; }
    let tj_ns = TachyonsClass "tj-ns"

    /// { text-transform: capitalize; }
    let ttc_ns = TachyonsClass "ttc-ns"

    /// { text-transform: lowercase; }
    let ttl_ns = TachyonsClass "ttl-ns"

    /// { text-transform: uppercase; }
    let ttu_ns = TachyonsClass "ttu-ns"

    /// { text-transform: none; }
    let ttn_ns = TachyonsClass "ttn-ns"

    /// { font-size: 6rem; }
    let f_6_ns = TachyonsClass "f-6-ns"

    /// { font-size: 6rem; }
    let f_headline_ns = TachyonsClass "f-headline-ns"

    /// { font-size: 5rem; }
    let f_5_ns = TachyonsClass "f-5-ns"

    /// { font-size: 5rem; }
    let f_subheadline_ns = TachyonsClass "f-subheadline-ns"

    /// { font-size: 3rem; }
    let f1_ns = TachyonsClass "f1-ns"

    /// { font-size: 2.25rem; }
    let f2_ns = TachyonsClass "f2-ns"

    /// { font-size: 1.5rem; }
    let f3_ns = TachyonsClass "f3-ns"

    /// { font-size: 1.25rem; }
    let f4_ns = TachyonsClass "f4-ns"

    /// { font-size: 1rem; }
    let f5_ns = TachyonsClass "f5-ns"

    /// { font-size: .875rem; }
    let f6_ns = TachyonsClass "f6-ns"

    /// { font-size: .75rem; }
    let f7_ns = TachyonsClass "f7-ns"

    /// { max-width: 30em; }
    let measure_ns = TachyonsClass "measure-ns"

    /// { max-width: 34em; }
    let measure_wide_ns = TachyonsClass "measure-wide-ns"

    /// { max-width: 20em; }
    let measure_narrow_ns = TachyonsClass "measure-narrow-ns"

    /// { text-indent: 1em; margin-top: 0; margin-bottom: 0; }
    let indent_ns = TachyonsClass "indent-ns"

    /// { font-variant: small-caps; }
    let small_caps_ns = TachyonsClass "small-caps-ns"

    /// { white-space: nowrap; overflow: hidden; text-overflow: ellipsis; }
    let truncate_ns = TachyonsClass "truncate-ns"

    /// { margin-right: auto; margin-left: auto; }
    let center_ns = TachyonsClass "center-ns"

    /// { margin-right: auto; }
    let mr_auto_ns = TachyonsClass "mr-auto-ns"

    /// { margin-left: auto; }
    let ml_auto_ns = TachyonsClass "ml-auto-ns"

    /// { position: fixed !important; _position: absolute !important; clip: rect( 1px 1px 1px 1px ); /* IE6, IE7 */ clip: rect( 1px, 1px, 1px, 1px ); }
    let clip_ns = TachyonsClass "clip-ns"

    /// { white-space: normal; }
    let ws_normal_ns = TachyonsClass "ws-normal-ns"

    /// { white-space: nowrap; }
    let nowrap_ns = TachyonsClass "nowrap-ns"

    /// { white-space: pre; }
    let pre_ns = TachyonsClass "pre-ns"

    /// { vertical-align: baseline; }
    let v_base_ns = TachyonsClass "v-base-ns"

    /// { vertical-align: middle; }
    let v_mid_ns = TachyonsClass "v-mid-ns"

    /// { vertical-align: top; }
    let v_top_ns = TachyonsClass "v-top-ns"

    /// { vertical-align: bottom; }
    let v_btm_ns = TachyonsClass "v-btm-ns"

    /// { height: 0; position: relative; }
    let aspect_ratio_m = TachyonsClass "aspect-ratio-m"

    /// { padding-bottom: 56.25%; }
    let aspect_ratio__16x9_m = TachyonsClass "aspect-ratio--16x9-m"

    /// { padding-bottom: 177.77%; }
    let aspect_ratio__9x16_m = TachyonsClass "aspect-ratio--9x16-m"

    /// { padding-bottom: 75%; }
    let aspect_ratio__4x3_m = TachyonsClass "aspect-ratio--4x3-m"

    /// { padding-bottom: 133.33%; }
    let aspect_ratio__3x4_m = TachyonsClass "aspect-ratio--3x4-m"

    /// { padding-bottom: 66.6%; }
    let aspect_ratio__6x4_m = TachyonsClass "aspect-ratio--6x4-m"

    /// { padding-bottom: 150%; }
    let aspect_ratio__4x6_m = TachyonsClass "aspect-ratio--4x6-m"

    /// { padding-bottom: 62.5%; }
    let aspect_ratio__8x5_m = TachyonsClass "aspect-ratio--8x5-m"

    /// { padding-bottom: 160%; }
    let aspect_ratio__5x8_m = TachyonsClass "aspect-ratio--5x8-m"

    /// { padding-bottom: 71.42%; }
    let aspect_ratio__7x5_m = TachyonsClass "aspect-ratio--7x5-m"

    /// { padding-bottom: 140%; }
    let aspect_ratio__5x7_m = TachyonsClass "aspect-ratio--5x7-m"

    /// { padding-bottom: 100%; }
    let aspect_ratio__1x1_m = TachyonsClass "aspect-ratio--1x1-m"

    /// { position: absolute; top: 0; right: 0; bottom: 0; left: 0; width: 100%; height: 100%; z-index: 100; }
    let aspect_ratio__object_m = TachyonsClass "aspect-ratio--object-m"

    /// { background-size: cover !important; }
    let cover_m = TachyonsClass "cover-m"

    /// { background-size: contain !important; }
    let contain_m = TachyonsClass "contain-m"

    /// { background-repeat: no-repeat; background-position: center center; }
    let bg_center_m = TachyonsClass "bg-center-m"

    /// { background-repeat: no-repeat; background-position: top center; }
    let bg_top_m = TachyonsClass "bg-top-m"

    /// { background-repeat: no-repeat; background-position: center right; }
    let bg_right_m = TachyonsClass "bg-right-m"

    /// { background-repeat: no-repeat; background-position: bottom center; }
    let bg_bottom_m = TachyonsClass "bg-bottom-m"

    /// { background-repeat: no-repeat; background-position: center left; }
    let bg_left_m = TachyonsClass "bg-left-m"

    /// { outline: 1px solid; }
    let outline_m = TachyonsClass "outline-m"

    /// { outline: 1px solid transparent; }
    let outline_transparent_m = TachyonsClass "outline-transparent-m"

    /// { outline: 0; }
    let outline_0_m = TachyonsClass "outline-0-m"

    /// { border-style: solid; border-width: 1px; }
    let ba_m = TachyonsClass "ba-m"

    /// { border-top-style: solid; border-top-width: 1px; }
    let bt_m = TachyonsClass "bt-m"

    /// { border-right-style: solid; border-right-width: 1px; }
    let br_m = TachyonsClass "br-m"

    /// { border-bottom-style: solid; border-bottom-width: 1px; }
    let bb_m = TachyonsClass "bb-m"

    /// { border-left-style: solid; border-left-width: 1px; }
    let bl_m = TachyonsClass "bl-m"

    /// { border-style: none; border-width: 0; }
    let bn_m = TachyonsClass "bn-m"

    /// { border-radius: 0; }
    let br0_m = TachyonsClass "br0-m"

    /// { border-radius: .125rem; }
    let br1_m = TachyonsClass "br1-m"

    /// { border-radius: .25rem; }
    let br2_m = TachyonsClass "br2-m"

    /// { border-radius: .5rem; }
    let br3_m = TachyonsClass "br3-m"

    /// { border-radius: 1rem; }
    let br4_m = TachyonsClass "br4-m"

    /// { border-radius: 100%; }
    let br_100_m = TachyonsClass "br-100-m"

    /// { border-radius: 9999px; }
    let br_pill_m = TachyonsClass "br-pill-m"

    /// { border-top-left-radius: 0; border-top-right-radius: 0; }
    let br__bottom_m = TachyonsClass "br--bottom-m"

    /// { border-bottom-left-radius: 0; border-bottom-right-radius: 0; }
    let br__top_m = TachyonsClass "br--top-m"

    /// { border-top-left-radius: 0; border-bottom-left-radius: 0; }
    let br__right_m = TachyonsClass "br--right-m"

    /// { border-top-right-radius: 0; border-bottom-right-radius: 0; }
    let br__left_m = TachyonsClass "br--left-m"

    /// { border-radius: inherit; }
    let br_inherit_m = TachyonsClass "br-inherit-m"

    /// { border-radius: initial; }
    let br_initial_m = TachyonsClass "br-initial-m"

    /// { border-radius: unset; }
    let br_unset_m = TachyonsClass "br-unset-m"

    /// { border-style: dotted; }
    let b__dotted_m = TachyonsClass "b--dotted-m"

    /// { border-style: dashed; }
    let b__dashed_m = TachyonsClass "b--dashed-m"

    /// { border-style: solid; }
    let b__solid_m = TachyonsClass "b--solid-m"

    /// { border-style: none; }
    let b__none_m = TachyonsClass "b--none-m"

    /// { border-width: 0; }
    let bw0_m = TachyonsClass "bw0-m"

    /// { border-width: .125rem; }
    let bw1_m = TachyonsClass "bw1-m"

    /// { border-width: .25rem; }
    let bw2_m = TachyonsClass "bw2-m"

    /// { border-width: .5rem; }
    let bw3_m = TachyonsClass "bw3-m"

    /// { border-width: 1rem; }
    let bw4_m = TachyonsClass "bw4-m"

    /// { border-width: 2rem; }
    let bw5_m = TachyonsClass "bw5-m"

    /// { border-top-width: 0; }
    let bt_0_m = TachyonsClass "bt-0-m"

    /// { border-right-width: 0; }
    let br_0_m = TachyonsClass "br-0-m"

    /// { border-bottom-width: 0; }
    let bb_0_m = TachyonsClass "bb-0-m"

    /// { border-left-width: 0; }
    let bl_0_m = TachyonsClass "bl-0-m"

    /// { box-shadow: 0 0 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_1_m = TachyonsClass "shadow-1-m"

    /// { box-shadow: 0 0 8px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_2_m = TachyonsClass "shadow-2-m"

    /// { box-shadow: 2px 2px 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_3_m = TachyonsClass "shadow-3-m"

    /// { box-shadow: 2px 2px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_4_m = TachyonsClass "shadow-4-m"

    /// { box-shadow: 4px 4px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_5_m = TachyonsClass "shadow-5-m"

    /// { top: 0; }
    let top_0_m = TachyonsClass "top-0-m"

    /// { left: 0; }
    let left_0_m = TachyonsClass "left-0-m"

    /// { right: 0; }
    let right_0_m = TachyonsClass "right-0-m"

    /// { bottom: 0; }
    let bottom_0_m = TachyonsClass "bottom-0-m"

    /// { top: 1rem; }
    let top_1_m = TachyonsClass "top-1-m"

    /// { left: 1rem; }
    let left_1_m = TachyonsClass "left-1-m"

    /// { right: 1rem; }
    let right_1_m = TachyonsClass "right-1-m"

    /// { bottom: 1rem; }
    let bottom_1_m = TachyonsClass "bottom-1-m"

    /// { top: 2rem; }
    let top_2_m = TachyonsClass "top-2-m"

    /// { left: 2rem; }
    let left_2_m = TachyonsClass "left-2-m"

    /// { right: 2rem; }
    let right_2_m = TachyonsClass "right-2-m"

    /// { bottom: 2rem; }
    let bottom_2_m = TachyonsClass "bottom-2-m"

    /// { top: -1rem; }
    let top__1_m = TachyonsClass "top--1-m"

    /// { right: -1rem; }
    let right__1_m = TachyonsClass "right--1-m"

    /// { bottom: -1rem; }
    let bottom__1_m = TachyonsClass "bottom--1-m"

    /// { left: -1rem; }
    let left__1_m = TachyonsClass "left--1-m"

    /// { top: -2rem; }
    let top__2_m = TachyonsClass "top--2-m"

    /// { right: -2rem; }
    let right__2_m = TachyonsClass "right--2-m"

    /// { bottom: -2rem; }
    let bottom__2_m = TachyonsClass "bottom--2-m"

    /// { left: -2rem; }
    let left__2_m = TachyonsClass "left--2-m"

    /// { top: 0; right: 0; bottom: 0; left: 0; }
    let absolute__fill_m = TachyonsClass "absolute--fill-m"

    /// { clear: left; }
    let cl_m = TachyonsClass "cl-m"

    /// { clear: right; }
    let cr_m = TachyonsClass "cr-m"

    /// { clear: both; }
    let cb_m = TachyonsClass "cb-m"

    /// { clear: none; }
    let cn_m = TachyonsClass "cn-m"

    /// { display: none; }
    let dn_m = TachyonsClass "dn-m"

    /// { display: inline; }
    let di_m = TachyonsClass "di-m"

    /// { display: block; }
    let db_m = TachyonsClass "db-m"

    /// { display: inline-block; }
    let dib_m = TachyonsClass "dib-m"

    /// { display: inline-table; }
    let dit_m = TachyonsClass "dit-m"

    /// { display: table; }
    let dt_m = TachyonsClass "dt-m"

    /// { display: table-cell; }
    let dtc_m = TachyonsClass "dtc-m"

    /// { display: table-row; }
    let dt_row_m = TachyonsClass "dt-row-m"

    /// { display: table-row-group; }
    let dt_row_group_m = TachyonsClass "dt-row-group-m"

    /// { display: table-column; }
    let dt_column_m = TachyonsClass "dt-column-m"

    /// { display: table-column-group; }
    let dt_column_group_m = TachyonsClass "dt-column-group-m"

    /// { table-layout: fixed; width: 100%; }
    let dt__fixed_m = TachyonsClass "dt--fixed-m"

    /// { display: flex; }
    let flex_m = TachyonsClass "flex-m"

    /// { display: inline-flex; }
    let inline_flex_m = TachyonsClass "inline-flex-m"

    /// { flex: 1 1 auto; min-width: 0; /* 1 */ min-height: 0; /* 1 */ }
    let flex_auto_m = TachyonsClass "flex-auto-m"

    /// { flex: none; }
    let flex_none_m = TachyonsClass "flex-none-m"

    /// { flex-direction: column; }
    let flex_column_m = TachyonsClass "flex-column-m"

    /// { flex-direction: row; }
    let flex_row_m = TachyonsClass "flex-row-m"

    /// { flex-wrap: wrap; }
    let flex_wrap_m = TachyonsClass "flex-wrap-m"

    /// { flex-wrap: nowrap; }
    let flex_nowrap_m = TachyonsClass "flex-nowrap-m"

    /// { flex-wrap: wrap-reverse; }
    let flex_wrap_reverse_m = TachyonsClass "flex-wrap-reverse-m"

    /// { flex-direction: column-reverse; }
    let flex_column_reverse_m = TachyonsClass "flex-column-reverse-m"

    /// { flex-direction: row-reverse; }
    let flex_row_reverse_m = TachyonsClass "flex-row-reverse-m"

    /// { align-items: flex-start; }
    let items_start_m = TachyonsClass "items-start-m"

    /// { align-items: flex-end; }
    let items_end_m = TachyonsClass "items-end-m"

    /// { align-items: center; }
    let items_center_m = TachyonsClass "items-center-m"

    /// { align-items: baseline; }
    let items_baseline_m = TachyonsClass "items-baseline-m"

    /// { align-items: stretch; }
    let items_stretch_m = TachyonsClass "items-stretch-m"

    /// { align-self: flex-start; }
    let self_start_m = TachyonsClass "self-start-m"

    /// { align-self: flex-end; }
    let self_end_m = TachyonsClass "self-end-m"

    /// { align-self: center; }
    let self_center_m = TachyonsClass "self-center-m"

    /// { align-self: baseline; }
    let self_baseline_m = TachyonsClass "self-baseline-m"

    /// { align-self: stretch; }
    let self_stretch_m = TachyonsClass "self-stretch-m"

    /// { justify-content: flex-start; }
    let justify_start_m = TachyonsClass "justify-start-m"

    /// { justify-content: flex-end; }
    let justify_end_m = TachyonsClass "justify-end-m"

    /// { justify-content: center; }
    let justify_center_m = TachyonsClass "justify-center-m"

    /// { justify-content: space-between; }
    let justify_between_m = TachyonsClass "justify-between-m"

    /// { justify-content: space-around; }
    let justify_around_m = TachyonsClass "justify-around-m"

    /// { align-content: flex-start; }
    let content_start_m = TachyonsClass "content-start-m"

    /// { align-content: flex-end; }
    let content_end_m = TachyonsClass "content-end-m"

    /// { align-content: center; }
    let content_center_m = TachyonsClass "content-center-m"

    /// { align-content: space-between; }
    let content_between_m = TachyonsClass "content-between-m"

    /// { align-content: space-around; }
    let content_around_m = TachyonsClass "content-around-m"

    /// { align-content: stretch; }
    let content_stretch_m = TachyonsClass "content-stretch-m"

    /// { order: 0; }
    let order_0_m = TachyonsClass "order-0-m"

    /// { order: 1; }
    let order_1_m = TachyonsClass "order-1-m"

    /// { order: 2; }
    let order_2_m = TachyonsClass "order-2-m"

    /// { order: 3; }
    let order_3_m = TachyonsClass "order-3-m"

    /// { order: 4; }
    let order_4_m = TachyonsClass "order-4-m"

    /// { order: 5; }
    let order_5_m = TachyonsClass "order-5-m"

    /// { order: 6; }
    let order_6_m = TachyonsClass "order-6-m"

    /// { order: 7; }
    let order_7_m = TachyonsClass "order-7-m"

    /// { order: 8; }
    let order_8_m = TachyonsClass "order-8-m"

    /// { order: 99999; }
    let order_last_m = TachyonsClass "order-last-m"

    /// { flex-grow: 0; }
    let flex_grow_0_m = TachyonsClass "flex-grow-0-m"

    /// { flex-grow: 1; }
    let flex_grow_1_m = TachyonsClass "flex-grow-1-m"

    /// { flex-shrink: 0; }
    let flex_shrink_0_m = TachyonsClass "flex-shrink-0-m"

    /// { flex-shrink: 1; }
    let flex_shrink_1_m = TachyonsClass "flex-shrink-1-m"

    /// { float: left; _display: inline; }
    let fl_m = TachyonsClass "fl-m"

    /// { float: right; _display: inline; }
    let fr_m = TachyonsClass "fr-m"

    /// { float: none; }
    let fn_m = TachyonsClass "fn-m"

    /// { font-style: italic; }
    let i_m = TachyonsClass "i-m"

    /// { font-style: normal; }
    let fs_normal_m = TachyonsClass "fs-normal-m"

    /// { font-weight: normal; }
    let normal_m = TachyonsClass "normal-m"

    /// { font-weight: bold; }
    let b_m = TachyonsClass "b-m"

    /// { font-weight: 100; }
    let fw1_m = TachyonsClass "fw1-m"

    /// { font-weight: 200; }
    let fw2_m = TachyonsClass "fw2-m"

    /// { font-weight: 300; }
    let fw3_m = TachyonsClass "fw3-m"

    /// { font-weight: 400; }
    let fw4_m = TachyonsClass "fw4-m"

    /// { font-weight: 500; }
    let fw5_m = TachyonsClass "fw5-m"

    /// { font-weight: 600; }
    let fw6_m = TachyonsClass "fw6-m"

    /// { font-weight: 700; }
    let fw7_m = TachyonsClass "fw7-m"

    /// { font-weight: 800; }
    let fw8_m = TachyonsClass "fw8-m"

    /// { font-weight: 900; }
    let fw9_m = TachyonsClass "fw9-m"

    /// { height: 1rem; }
    let h1_m = TachyonsClass "h1-m"

    /// { height: 2rem; }
    let h2_m = TachyonsClass "h2-m"

    /// { height: 4rem; }
    let h3_m = TachyonsClass "h3-m"

    /// { height: 8rem; }
    let h4_m = TachyonsClass "h4-m"

    /// { height: 16rem; }
    let h5_m = TachyonsClass "h5-m"

    /// { height: 25%; }
    let h_25_m = TachyonsClass "h-25-m"

    /// { height: 50%; }
    let h_50_m = TachyonsClass "h-50-m"

    /// { height: 75%; }
    let h_75_m = TachyonsClass "h-75-m"

    /// { height: 100%; }
    let h_100_m = TachyonsClass "h-100-m"

    /// { min-height: 100%; }
    let min_h_100_m = TachyonsClass "min-h-100-m"

    /// { height: 25vh; }
    let vh_25_m = TachyonsClass "vh-25-m"

    /// { height: 50vh; }
    let vh_50_m = TachyonsClass "vh-50-m"

    /// { height: 75vh; }
    let vh_75_m = TachyonsClass "vh-75-m"

    /// { height: 100vh; }
    let vh_100_m = TachyonsClass "vh-100-m"

    /// { min-height: 100vh; }
    let min_vh_100_m = TachyonsClass "min-vh-100-m"

    /// { height: auto; }
    let h_auto_m = TachyonsClass "h-auto-m"

    /// { height: inherit; }
    let h_inherit_m = TachyonsClass "h-inherit-m"

    /// { letter-spacing: .1em; }
    let tracked_m = TachyonsClass "tracked-m"

    /// { letter-spacing: -.05em; }
    let tracked_tight_m = TachyonsClass "tracked-tight-m"

    /// { letter-spacing: .25em; }
    let tracked_mega_m = TachyonsClass "tracked-mega-m"

    /// { line-height: 1; }
    let lh_solid_m = TachyonsClass "lh-solid-m"

    /// { line-height: 1.25; }
    let lh_title_m = TachyonsClass "lh-title-m"

    /// { line-height: 1.5; }
    let lh_copy_m = TachyonsClass "lh-copy-m"

    /// { max-width: 100%; }
    let mw_100_m = TachyonsClass "mw-100-m"

    /// { max-width: 1rem; }
    let mw1_m = TachyonsClass "mw1-m"

    /// { max-width: 2rem; }
    let mw2_m = TachyonsClass "mw2-m"

    /// { max-width: 4rem; }
    let mw3_m = TachyonsClass "mw3-m"

    /// { max-width: 8rem; }
    let mw4_m = TachyonsClass "mw4-m"

    /// { max-width: 16rem; }
    let mw5_m = TachyonsClass "mw5-m"

    /// { max-width: 32rem; }
    let mw6_m = TachyonsClass "mw6-m"

    /// { max-width: 48rem; }
    let mw7_m = TachyonsClass "mw7-m"

    /// { max-width: 64rem; }
    let mw8_m = TachyonsClass "mw8-m"

    /// { max-width: 96rem; }
    let mw9_m = TachyonsClass "mw9-m"

    /// { max-width: none; }
    let mw_none_m = TachyonsClass "mw-none-m"

    /// { width: 1rem; }
    let w1_m = TachyonsClass "w1-m"

    /// { width: 2rem; }
    let w2_m = TachyonsClass "w2-m"

    /// { width: 4rem; }
    let w3_m = TachyonsClass "w3-m"

    /// { width: 8rem; }
    let w4_m = TachyonsClass "w4-m"

    /// { width: 16rem; }
    let w5_m = TachyonsClass "w5-m"

    /// { width: 10%; }
    let w_10_m = TachyonsClass "w-10-m"

    /// { width: 20%; }
    let w_20_m = TachyonsClass "w-20-m"

    /// { width: 25%; }
    let w_25_m = TachyonsClass "w-25-m"

    /// { width: 30%; }
    let w_30_m = TachyonsClass "w-30-m"

    /// { width: 33%; }
    let w_33_m = TachyonsClass "w-33-m"

    /// { width: 34%; }
    let w_34_m = TachyonsClass "w-34-m"

    /// { width: 40%; }
    let w_40_m = TachyonsClass "w-40-m"

    /// { width: 50%; }
    let w_50_m = TachyonsClass "w-50-m"

    /// { width: 60%; }
    let w_60_m = TachyonsClass "w-60-m"

    /// { width: 70%; }
    let w_70_m = TachyonsClass "w-70-m"

    /// { width: 75%; }
    let w_75_m = TachyonsClass "w-75-m"

    /// { width: 80%; }
    let w_80_m = TachyonsClass "w-80-m"

    /// { width: 90%; }
    let w_90_m = TachyonsClass "w-90-m"

    /// { width: 100%; }
    let w_100_m = TachyonsClass "w-100-m"

    /// { width: 33.33333%; }
    let w_third_m = TachyonsClass "w-third-m"

    /// { width: 66.66667%; }
    let w_two_thirds_m = TachyonsClass "w-two-thirds-m"

    /// { width: auto; }
    let w_auto_m = TachyonsClass "w-auto-m"

    /// { overflow: visible; }
    let overflow_visible_m = TachyonsClass "overflow-visible-m"

    /// { overflow: hidden; }
    let overflow_hidden_m = TachyonsClass "overflow-hidden-m"

    /// { overflow: scroll; }
    let overflow_scroll_m = TachyonsClass "overflow-scroll-m"

    /// { overflow: auto; }
    let overflow_auto_m = TachyonsClass "overflow-auto-m"

    /// { overflow-x: visible; }
    let overflow_x_visible_m = TachyonsClass "overflow-x-visible-m"

    /// { overflow-x: hidden; }
    let overflow_x_hidden_m = TachyonsClass "overflow-x-hidden-m"

    /// { overflow-x: scroll; }
    let overflow_x_scroll_m = TachyonsClass "overflow-x-scroll-m"

    /// { overflow-x: auto; }
    let overflow_x_auto_m = TachyonsClass "overflow-x-auto-m"

    /// { overflow-y: visible; }
    let overflow_y_visible_m = TachyonsClass "overflow-y-visible-m"

    /// { overflow-y: hidden; }
    let overflow_y_hidden_m = TachyonsClass "overflow-y-hidden-m"

    /// { overflow-y: scroll; }
    let overflow_y_scroll_m = TachyonsClass "overflow-y-scroll-m"

    /// { overflow-y: auto; }
    let overflow_y_auto_m = TachyonsClass "overflow-y-auto-m"

    /// { position: static; }
    let static_m = TachyonsClass "static-m"

    /// { position: relative; }
    let relative_m = TachyonsClass "relative-m"

    /// { position: absolute; }
    let absolute_m = TachyonsClass "absolute-m"

    /// { position: fixed; }
    let fixed_m = TachyonsClass "fixed-m"

    /// { -webkit-transform: rotate( 45deg ); transform: rotate( 45deg ); }
    let rotate_45_m = TachyonsClass "rotate-45-m"

    /// { -webkit-transform: rotate( 90deg ); transform: rotate( 90deg ); }
    let rotate_90_m = TachyonsClass "rotate-90-m"

    /// { -webkit-transform: rotate( 135deg ); transform: rotate( 135deg ); }
    let rotate_135_m = TachyonsClass "rotate-135-m"

    /// { -webkit-transform: rotate( 180deg ); transform: rotate( 180deg ); }
    let rotate_180_m = TachyonsClass "rotate-180-m"

    /// { -webkit-transform: rotate( 225deg ); transform: rotate( 225deg ); }
    let rotate_225_m = TachyonsClass "rotate-225-m"

    /// { -webkit-transform: rotate( 270deg ); transform: rotate( 270deg ); }
    let rotate_270_m = TachyonsClass "rotate-270-m"

    /// { -webkit-transform: rotate( 315deg ); transform: rotate( 315deg ); }
    let rotate_315_m = TachyonsClass "rotate-315-m"

    /// { padding: 0; }
    let pa0_m = TachyonsClass "pa0-m"

    /// { padding: .25rem; }
    let pa1_m = TachyonsClass "pa1-m"

    /// { padding: .5rem; }
    let pa2_m = TachyonsClass "pa2-m"

    /// { padding: 1rem; }
    let pa3_m = TachyonsClass "pa3-m"

    /// { padding: 2rem; }
    let pa4_m = TachyonsClass "pa4-m"

    /// { padding: 4rem; }
    let pa5_m = TachyonsClass "pa5-m"

    /// { padding: 8rem; }
    let pa6_m = TachyonsClass "pa6-m"

    /// { padding: 16rem; }
    let pa7_m = TachyonsClass "pa7-m"

    /// { padding-left: 0; }
    let pl0_m = TachyonsClass "pl0-m"

    /// { padding-left: .25rem; }
    let pl1_m = TachyonsClass "pl1-m"

    /// { padding-left: .5rem; }
    let pl2_m = TachyonsClass "pl2-m"

    /// { padding-left: 1rem; }
    let pl3_m = TachyonsClass "pl3-m"

    /// { padding-left: 2rem; }
    let pl4_m = TachyonsClass "pl4-m"

    /// { padding-left: 4rem; }
    let pl5_m = TachyonsClass "pl5-m"

    /// { padding-left: 8rem; }
    let pl6_m = TachyonsClass "pl6-m"

    /// { padding-left: 16rem; }
    let pl7_m = TachyonsClass "pl7-m"

    /// { padding-right: 0; }
    let pr0_m = TachyonsClass "pr0-m"

    /// { padding-right: .25rem; }
    let pr1_m = TachyonsClass "pr1-m"

    /// { padding-right: .5rem; }
    let pr2_m = TachyonsClass "pr2-m"

    /// { padding-right: 1rem; }
    let pr3_m = TachyonsClass "pr3-m"

    /// { padding-right: 2rem; }
    let pr4_m = TachyonsClass "pr4-m"

    /// { padding-right: 4rem; }
    let pr5_m = TachyonsClass "pr5-m"

    /// { padding-right: 8rem; }
    let pr6_m = TachyonsClass "pr6-m"

    /// { padding-right: 16rem; }
    let pr7_m = TachyonsClass "pr7-m"

    /// { padding-bottom: 0; }
    let pb0_m = TachyonsClass "pb0-m"

    /// { padding-bottom: .25rem; }
    let pb1_m = TachyonsClass "pb1-m"

    /// { padding-bottom: .5rem; }
    let pb2_m = TachyonsClass "pb2-m"

    /// { padding-bottom: 1rem; }
    let pb3_m = TachyonsClass "pb3-m"

    /// { padding-bottom: 2rem; }
    let pb4_m = TachyonsClass "pb4-m"

    /// { padding-bottom: 4rem; }
    let pb5_m = TachyonsClass "pb5-m"

    /// { padding-bottom: 8rem; }
    let pb6_m = TachyonsClass "pb6-m"

    /// { padding-bottom: 16rem; }
    let pb7_m = TachyonsClass "pb7-m"

    /// { padding-top: 0; }
    let pt0_m = TachyonsClass "pt0-m"

    /// { padding-top: .25rem; }
    let pt1_m = TachyonsClass "pt1-m"

    /// { padding-top: .5rem; }
    let pt2_m = TachyonsClass "pt2-m"

    /// { padding-top: 1rem; }
    let pt3_m = TachyonsClass "pt3-m"

    /// { padding-top: 2rem; }
    let pt4_m = TachyonsClass "pt4-m"

    /// { padding-top: 4rem; }
    let pt5_m = TachyonsClass "pt5-m"

    /// { padding-top: 8rem; }
    let pt6_m = TachyonsClass "pt6-m"

    /// { padding-top: 16rem; }
    let pt7_m = TachyonsClass "pt7-m"

    /// { padding-top: 0; padding-bottom: 0; }
    let pv0_m = TachyonsClass "pv0-m"

    /// { padding-top: .25rem; padding-bottom: .25rem; }
    let pv1_m = TachyonsClass "pv1-m"

    /// { padding-top: .5rem; padding-bottom: .5rem; }
    let pv2_m = TachyonsClass "pv2-m"

    /// { padding-top: 1rem; padding-bottom: 1rem; }
    let pv3_m = TachyonsClass "pv3-m"

    /// { padding-top: 2rem; padding-bottom: 2rem; }
    let pv4_m = TachyonsClass "pv4-m"

    /// { padding-top: 4rem; padding-bottom: 4rem; }
    let pv5_m = TachyonsClass "pv5-m"

    /// { padding-top: 8rem; padding-bottom: 8rem; }
    let pv6_m = TachyonsClass "pv6-m"

    /// { padding-top: 16rem; padding-bottom: 16rem; }
    let pv7_m = TachyonsClass "pv7-m"

    /// { padding-left: 0; padding-right: 0; }
    let ph0_m = TachyonsClass "ph0-m"

    /// { padding-left: .25rem; padding-right: .25rem; }
    let ph1_m = TachyonsClass "ph1-m"

    /// { padding-left: .5rem; padding-right: .5rem; }
    let ph2_m = TachyonsClass "ph2-m"

    /// { padding-left: 1rem; padding-right: 1rem; }
    let ph3_m = TachyonsClass "ph3-m"

    /// { padding-left: 2rem; padding-right: 2rem; }
    let ph4_m = TachyonsClass "ph4-m"

    /// { padding-left: 4rem; padding-right: 4rem; }
    let ph5_m = TachyonsClass "ph5-m"

    /// { padding-left: 8rem; padding-right: 8rem; }
    let ph6_m = TachyonsClass "ph6-m"

    /// { padding-left: 16rem; padding-right: 16rem; }
    let ph7_m = TachyonsClass "ph7-m"

    /// { margin: 0; }
    let ma0_m = TachyonsClass "ma0-m"

    /// { margin: .25rem; }
    let ma1_m = TachyonsClass "ma1-m"

    /// { margin: .5rem; }
    let ma2_m = TachyonsClass "ma2-m"

    /// { margin: 1rem; }
    let ma3_m = TachyonsClass "ma3-m"

    /// { margin: 2rem; }
    let ma4_m = TachyonsClass "ma4-m"

    /// { margin: 4rem; }
    let ma5_m = TachyonsClass "ma5-m"

    /// { margin: 8rem; }
    let ma6_m = TachyonsClass "ma6-m"

    /// { margin: 16rem; }
    let ma7_m = TachyonsClass "ma7-m"

    /// { margin-left: 0; }
    let ml0_m = TachyonsClass "ml0-m"

    /// { margin-left: .25rem; }
    let ml1_m = TachyonsClass "ml1-m"

    /// { margin-left: .5rem; }
    let ml2_m = TachyonsClass "ml2-m"

    /// { margin-left: 1rem; }
    let ml3_m = TachyonsClass "ml3-m"

    /// { margin-left: 2rem; }
    let ml4_m = TachyonsClass "ml4-m"

    /// { margin-left: 4rem; }
    let ml5_m = TachyonsClass "ml5-m"

    /// { margin-left: 8rem; }
    let ml6_m = TachyonsClass "ml6-m"

    /// { margin-left: 16rem; }
    let ml7_m = TachyonsClass "ml7-m"

    /// { margin-right: 0; }
    let mr0_m = TachyonsClass "mr0-m"

    /// { margin-right: .25rem; }
    let mr1_m = TachyonsClass "mr1-m"

    /// { margin-right: .5rem; }
    let mr2_m = TachyonsClass "mr2-m"

    /// { margin-right: 1rem; }
    let mr3_m = TachyonsClass "mr3-m"

    /// { margin-right: 2rem; }
    let mr4_m = TachyonsClass "mr4-m"

    /// { margin-right: 4rem; }
    let mr5_m = TachyonsClass "mr5-m"

    /// { margin-right: 8rem; }
    let mr6_m = TachyonsClass "mr6-m"

    /// { margin-right: 16rem; }
    let mr7_m = TachyonsClass "mr7-m"

    /// { margin-bottom: 0; }
    let mb0_m = TachyonsClass "mb0-m"

    /// { margin-bottom: .25rem; }
    let mb1_m = TachyonsClass "mb1-m"

    /// { margin-bottom: .5rem; }
    let mb2_m = TachyonsClass "mb2-m"

    /// { margin-bottom: 1rem; }
    let mb3_m = TachyonsClass "mb3-m"

    /// { margin-bottom: 2rem; }
    let mb4_m = TachyonsClass "mb4-m"

    /// { margin-bottom: 4rem; }
    let mb5_m = TachyonsClass "mb5-m"

    /// { margin-bottom: 8rem; }
    let mb6_m = TachyonsClass "mb6-m"

    /// { margin-bottom: 16rem; }
    let mb7_m = TachyonsClass "mb7-m"

    /// { margin-top: 0; }
    let mt0_m = TachyonsClass "mt0-m"

    /// { margin-top: .25rem; }
    let mt1_m = TachyonsClass "mt1-m"

    /// { margin-top: .5rem; }
    let mt2_m = TachyonsClass "mt2-m"

    /// { margin-top: 1rem; }
    let mt3_m = TachyonsClass "mt3-m"

    /// { margin-top: 2rem; }
    let mt4_m = TachyonsClass "mt4-m"

    /// { margin-top: 4rem; }
    let mt5_m = TachyonsClass "mt5-m"

    /// { margin-top: 8rem; }
    let mt6_m = TachyonsClass "mt6-m"

    /// { margin-top: 16rem; }
    let mt7_m = TachyonsClass "mt7-m"

    /// { margin-top: 0; margin-bottom: 0; }
    let mv0_m = TachyonsClass "mv0-m"

    /// { margin-top: .25rem; margin-bottom: .25rem; }
    let mv1_m = TachyonsClass "mv1-m"

    /// { margin-top: .5rem; margin-bottom: .5rem; }
    let mv2_m = TachyonsClass "mv2-m"

    /// { margin-top: 1rem; margin-bottom: 1rem; }
    let mv3_m = TachyonsClass "mv3-m"

    /// { margin-top: 2rem; margin-bottom: 2rem; }
    let mv4_m = TachyonsClass "mv4-m"

    /// { margin-top: 4rem; margin-bottom: 4rem; }
    let mv5_m = TachyonsClass "mv5-m"

    /// { margin-top: 8rem; margin-bottom: 8rem; }
    let mv6_m = TachyonsClass "mv6-m"

    /// { margin-top: 16rem; margin-bottom: 16rem; }
    let mv7_m = TachyonsClass "mv7-m"

    /// { margin-left: 0; margin-right: 0; }
    let mh0_m = TachyonsClass "mh0-m"

    /// { margin-left: .25rem; margin-right: .25rem; }
    let mh1_m = TachyonsClass "mh1-m"

    /// { margin-left: .5rem; margin-right: .5rem; }
    let mh2_m = TachyonsClass "mh2-m"

    /// { margin-left: 1rem; margin-right: 1rem; }
    let mh3_m = TachyonsClass "mh3-m"

    /// { margin-left: 2rem; margin-right: 2rem; }
    let mh4_m = TachyonsClass "mh4-m"

    /// { margin-left: 4rem; margin-right: 4rem; }
    let mh5_m = TachyonsClass "mh5-m"

    /// { margin-left: 8rem; margin-right: 8rem; }
    let mh6_m = TachyonsClass "mh6-m"

    /// { margin-left: 16rem; margin-right: 16rem; }
    let mh7_m = TachyonsClass "mh7-m"

    /// { margin: -0.25rem; }
    let na1_m = TachyonsClass "na1-m"

    /// { margin: -0.5rem; }
    let na2_m = TachyonsClass "na2-m"

    /// { margin: -1rem; }
    let na3_m = TachyonsClass "na3-m"

    /// { margin: -2rem; }
    let na4_m = TachyonsClass "na4-m"

    /// { margin: -4rem; }
    let na5_m = TachyonsClass "na5-m"

    /// { margin: -8rem; }
    let na6_m = TachyonsClass "na6-m"

    /// { margin: -16rem; }
    let na7_m = TachyonsClass "na7-m"

    /// { margin-left: -0.25rem; }
    let nl1_m = TachyonsClass "nl1-m"

    /// { margin-left: -0.5rem; }
    let nl2_m = TachyonsClass "nl2-m"

    /// { margin-left: -1rem; }
    let nl3_m = TachyonsClass "nl3-m"

    /// { margin-left: -2rem; }
    let nl4_m = TachyonsClass "nl4-m"

    /// { margin-left: -4rem; }
    let nl5_m = TachyonsClass "nl5-m"

    /// { margin-left: -8rem; }
    let nl6_m = TachyonsClass "nl6-m"

    /// { margin-left: -16rem; }
    let nl7_m = TachyonsClass "nl7-m"

    /// { margin-right: -0.25rem; }
    let nr1_m = TachyonsClass "nr1-m"

    /// { margin-right: -0.5rem; }
    let nr2_m = TachyonsClass "nr2-m"

    /// { margin-right: -1rem; }
    let nr3_m = TachyonsClass "nr3-m"

    /// { margin-right: -2rem; }
    let nr4_m = TachyonsClass "nr4-m"

    /// { margin-right: -4rem; }
    let nr5_m = TachyonsClass "nr5-m"

    /// { margin-right: -8rem; }
    let nr6_m = TachyonsClass "nr6-m"

    /// { margin-right: -16rem; }
    let nr7_m = TachyonsClass "nr7-m"

    /// { margin-bottom: -0.25rem; }
    let nb1_m = TachyonsClass "nb1-m"

    /// { margin-bottom: -0.5rem; }
    let nb2_m = TachyonsClass "nb2-m"

    /// { margin-bottom: -1rem; }
    let nb3_m = TachyonsClass "nb3-m"

    /// { margin-bottom: -2rem; }
    let nb4_m = TachyonsClass "nb4-m"

    /// { margin-bottom: -4rem; }
    let nb5_m = TachyonsClass "nb5-m"

    /// { margin-bottom: -8rem; }
    let nb6_m = TachyonsClass "nb6-m"

    /// { margin-bottom: -16rem; }
    let nb7_m = TachyonsClass "nb7-m"

    /// { margin-top: -0.25rem; }
    let nt1_m = TachyonsClass "nt1-m"

    /// { margin-top: -0.5rem; }
    let nt2_m = TachyonsClass "nt2-m"

    /// { margin-top: -1rem; }
    let nt3_m = TachyonsClass "nt3-m"

    /// { margin-top: -2rem; }
    let nt4_m = TachyonsClass "nt4-m"

    /// { margin-top: -4rem; }
    let nt5_m = TachyonsClass "nt5-m"

    /// { margin-top: -8rem; }
    let nt6_m = TachyonsClass "nt6-m"

    /// { margin-top: -16rem; }
    let nt7_m = TachyonsClass "nt7-m"

    /// { text-decoration: line-through; }
    let strike_m = TachyonsClass "strike-m"

    /// { text-decoration: underline; }
    let underline_m = TachyonsClass "underline-m"

    /// { text-decoration: none; }
    let no_underline_m = TachyonsClass "no-underline-m"

    /// { text-align: left; }
    let tl_m = TachyonsClass "tl-m"

    /// { text-align: right; }
    let tr_m = TachyonsClass "tr-m"

    /// { text-align: center; }
    let tc_m = TachyonsClass "tc-m"

    /// { text-align: justify; }
    let tj_m = TachyonsClass "tj-m"

    /// { text-transform: capitalize; }
    let ttc_m = TachyonsClass "ttc-m"

    /// { text-transform: lowercase; }
    let ttl_m = TachyonsClass "ttl-m"

    /// { text-transform: uppercase; }
    let ttu_m = TachyonsClass "ttu-m"

    /// { text-transform: none; }
    let ttn_m = TachyonsClass "ttn-m"

    /// { font-size: 6rem; }
    let f_6_m = TachyonsClass "f-6-m"

    /// { font-size: 6rem; }
    let f_headline_m = TachyonsClass "f-headline-m"

    /// { font-size: 5rem; }
    let f_5_m = TachyonsClass "f-5-m"

    /// { font-size: 5rem; }
    let f_subheadline_m = TachyonsClass "f-subheadline-m"

    /// { font-size: 3rem; }
    let f1_m = TachyonsClass "f1-m"

    /// { font-size: 2.25rem; }
    let f2_m = TachyonsClass "f2-m"

    /// { font-size: 1.5rem; }
    let f3_m = TachyonsClass "f3-m"

    /// { font-size: 1.25rem; }
    let f4_m = TachyonsClass "f4-m"

    /// { font-size: 1rem; }
    let f5_m = TachyonsClass "f5-m"

    /// { font-size: .875rem; }
    let f6_m = TachyonsClass "f6-m"

    /// { font-size: .75rem; }
    let f7_m = TachyonsClass "f7-m"

    /// { max-width: 30em; }
    let measure_m = TachyonsClass "measure-m"

    /// { max-width: 34em; }
    let measure_wide_m = TachyonsClass "measure-wide-m"

    /// { max-width: 20em; }
    let measure_narrow_m = TachyonsClass "measure-narrow-m"

    /// { text-indent: 1em; margin-top: 0; margin-bottom: 0; }
    let indent_m = TachyonsClass "indent-m"

    /// { font-variant: small-caps; }
    let small_caps_m = TachyonsClass "small-caps-m"

    /// { white-space: nowrap; overflow: hidden; text-overflow: ellipsis; }
    let truncate_m = TachyonsClass "truncate-m"

    /// { margin-right: auto; margin-left: auto; }
    let center_m = TachyonsClass "center-m"

    /// { margin-right: auto; }
    let mr_auto_m = TachyonsClass "mr-auto-m"

    /// { margin-left: auto; }
    let ml_auto_m = TachyonsClass "ml-auto-m"

    /// { position: fixed !important; _position: absolute !important; clip: rect( 1px 1px 1px 1px ); /* IE6, IE7 */ clip: rect( 1px, 1px, 1px, 1px ); }
    let clip_m = TachyonsClass "clip-m"

    /// { white-space: normal; }
    let ws_normal_m = TachyonsClass "ws-normal-m"

    /// { white-space: nowrap; }
    let nowrap_m = TachyonsClass "nowrap-m"

    /// { white-space: pre; }
    let pre_m = TachyonsClass "pre-m"

    /// { vertical-align: baseline; }
    let v_base_m = TachyonsClass "v-base-m"

    /// { vertical-align: middle; }
    let v_mid_m = TachyonsClass "v-mid-m"

    /// { vertical-align: top; }
    let v_top_m = TachyonsClass "v-top-m"

    /// { vertical-align: bottom; }
    let v_btm_m = TachyonsClass "v-btm-m"

    /// { height: 0; position: relative; }
    let aspect_ratio_l = TachyonsClass "aspect-ratio-l"

    /// { padding-bottom: 56.25%; }
    let aspect_ratio__16x9_l = TachyonsClass "aspect-ratio--16x9-l"

    /// { padding-bottom: 177.77%; }
    let aspect_ratio__9x16_l = TachyonsClass "aspect-ratio--9x16-l"

    /// { padding-bottom: 75%; }
    let aspect_ratio__4x3_l = TachyonsClass "aspect-ratio--4x3-l"

    /// { padding-bottom: 133.33%; }
    let aspect_ratio__3x4_l = TachyonsClass "aspect-ratio--3x4-l"

    /// { padding-bottom: 66.6%; }
    let aspect_ratio__6x4_l = TachyonsClass "aspect-ratio--6x4-l"

    /// { padding-bottom: 150%; }
    let aspect_ratio__4x6_l = TachyonsClass "aspect-ratio--4x6-l"

    /// { padding-bottom: 62.5%; }
    let aspect_ratio__8x5_l = TachyonsClass "aspect-ratio--8x5-l"

    /// { padding-bottom: 160%; }
    let aspect_ratio__5x8_l = TachyonsClass "aspect-ratio--5x8-l"

    /// { padding-bottom: 71.42%; }
    let aspect_ratio__7x5_l = TachyonsClass "aspect-ratio--7x5-l"

    /// { padding-bottom: 140%; }
    let aspect_ratio__5x7_l = TachyonsClass "aspect-ratio--5x7-l"

    /// { padding-bottom: 100%; }
    let aspect_ratio__1x1_l = TachyonsClass "aspect-ratio--1x1-l"

    /// { position: absolute; top: 0; right: 0; bottom: 0; left: 0; width: 100%; height: 100%; z-index: 100; }
    let aspect_ratio__object_l = TachyonsClass "aspect-ratio--object-l"

    /// { background-size: cover !important; }
    let cover_l = TachyonsClass "cover-l"

    /// { background-size: contain !important; }
    let contain_l = TachyonsClass "contain-l"

    /// { background-repeat: no-repeat; background-position: center center; }
    let bg_center_l = TachyonsClass "bg-center-l"

    /// { background-repeat: no-repeat; background-position: top center; }
    let bg_top_l = TachyonsClass "bg-top-l"

    /// { background-repeat: no-repeat; background-position: center right; }
    let bg_right_l = TachyonsClass "bg-right-l"

    /// { background-repeat: no-repeat; background-position: bottom center; }
    let bg_bottom_l = TachyonsClass "bg-bottom-l"

    /// { background-repeat: no-repeat; background-position: center left; }
    let bg_left_l = TachyonsClass "bg-left-l"

    /// { outline: 1px solid; }
    let outline_l = TachyonsClass "outline-l"

    /// { outline: 1px solid transparent; }
    let outline_transparent_l = TachyonsClass "outline-transparent-l"

    /// { outline: 0; }
    let outline_0_l = TachyonsClass "outline-0-l"

    /// { border-style: solid; border-width: 1px; }
    let ba_l = TachyonsClass "ba-l"

    /// { border-top-style: solid; border-top-width: 1px; }
    let bt_l = TachyonsClass "bt-l"

    /// { border-right-style: solid; border-right-width: 1px; }
    let br_l = TachyonsClass "br-l"

    /// { border-bottom-style: solid; border-bottom-width: 1px; }
    let bb_l = TachyonsClass "bb-l"

    /// { border-left-style: solid; border-left-width: 1px; }
    let bl_l = TachyonsClass "bl-l"

    /// { border-style: none; border-width: 0; }
    let bn_l = TachyonsClass "bn-l"

    /// { border-radius: 0; }
    let br0_l = TachyonsClass "br0-l"

    /// { border-radius: .125rem; }
    let br1_l = TachyonsClass "br1-l"

    /// { border-radius: .25rem; }
    let br2_l = TachyonsClass "br2-l"

    /// { border-radius: .5rem; }
    let br3_l = TachyonsClass "br3-l"

    /// { border-radius: 1rem; }
    let br4_l = TachyonsClass "br4-l"

    /// { border-radius: 100%; }
    let br_100_l = TachyonsClass "br-100-l"

    /// { border-radius: 9999px; }
    let br_pill_l = TachyonsClass "br-pill-l"

    /// { border-top-left-radius: 0; border-top-right-radius: 0; }
    let br__bottom_l = TachyonsClass "br--bottom-l"

    /// { border-bottom-left-radius: 0; border-bottom-right-radius: 0; }
    let br__top_l = TachyonsClass "br--top-l"

    /// { border-top-left-radius: 0; border-bottom-left-radius: 0; }
    let br__right_l = TachyonsClass "br--right-l"

    /// { border-top-right-radius: 0; border-bottom-right-radius: 0; }
    let br__left_l = TachyonsClass "br--left-l"

    /// { border-radius: inherit; }
    let br_inherit_l = TachyonsClass "br-inherit-l"

    /// { border-radius: initial; }
    let br_initial_l = TachyonsClass "br-initial-l"

    /// { border-radius: unset; }
    let br_unset_l = TachyonsClass "br-unset-l"

    /// { border-style: dotted; }
    let b__dotted_l = TachyonsClass "b--dotted-l"

    /// { border-style: dashed; }
    let b__dashed_l = TachyonsClass "b--dashed-l"

    /// { border-style: solid; }
    let b__solid_l = TachyonsClass "b--solid-l"

    /// { border-style: none; }
    let b__none_l = TachyonsClass "b--none-l"

    /// { border-width: 0; }
    let bw0_l = TachyonsClass "bw0-l"

    /// { border-width: .125rem; }
    let bw1_l = TachyonsClass "bw1-l"

    /// { border-width: .25rem; }
    let bw2_l = TachyonsClass "bw2-l"

    /// { border-width: .5rem; }
    let bw3_l = TachyonsClass "bw3-l"

    /// { border-width: 1rem; }
    let bw4_l = TachyonsClass "bw4-l"

    /// { border-width: 2rem; }
    let bw5_l = TachyonsClass "bw5-l"

    /// { border-top-width: 0; }
    let bt_0_l = TachyonsClass "bt-0-l"

    /// { border-right-width: 0; }
    let br_0_l = TachyonsClass "br-0-l"

    /// { border-bottom-width: 0; }
    let bb_0_l = TachyonsClass "bb-0-l"

    /// { border-left-width: 0; }
    let bl_0_l = TachyonsClass "bl-0-l"

    /// { box-shadow: 0 0 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_1_l = TachyonsClass "shadow-1-l"

    /// { box-shadow: 0 0 8px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_2_l = TachyonsClass "shadow-2-l"

    /// { box-shadow: 2px 2px 4px 2px rgba( 0, 0, 0, .2 ); }
    let shadow_3_l = TachyonsClass "shadow-3-l"

    /// { box-shadow: 2px 2px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_4_l = TachyonsClass "shadow-4-l"

    /// { box-shadow: 4px 4px 8px 0 rgba( 0, 0, 0, .2 ); }
    let shadow_5_l = TachyonsClass "shadow-5-l"

    /// { top: 0; }
    let top_0_l = TachyonsClass "top-0-l"

    /// { left: 0; }
    let left_0_l = TachyonsClass "left-0-l"

    /// { right: 0; }
    let right_0_l = TachyonsClass "right-0-l"

    /// { bottom: 0; }
    let bottom_0_l = TachyonsClass "bottom-0-l"

    /// { top: 1rem; }
    let top_1_l = TachyonsClass "top-1-l"

    /// { left: 1rem; }
    let left_1_l = TachyonsClass "left-1-l"

    /// { right: 1rem; }
    let right_1_l = TachyonsClass "right-1-l"

    /// { bottom: 1rem; }
    let bottom_1_l = TachyonsClass "bottom-1-l"

    /// { top: 2rem; }
    let top_2_l = TachyonsClass "top-2-l"

    /// { left: 2rem; }
    let left_2_l = TachyonsClass "left-2-l"

    /// { right: 2rem; }
    let right_2_l = TachyonsClass "right-2-l"

    /// { bottom: 2rem; }
    let bottom_2_l = TachyonsClass "bottom-2-l"

    /// { top: -1rem; }
    let top__1_l = TachyonsClass "top--1-l"

    /// { right: -1rem; }
    let right__1_l = TachyonsClass "right--1-l"

    /// { bottom: -1rem; }
    let bottom__1_l = TachyonsClass "bottom--1-l"

    /// { left: -1rem; }
    let left__1_l = TachyonsClass "left--1-l"

    /// { top: -2rem; }
    let top__2_l = TachyonsClass "top--2-l"

    /// { right: -2rem; }
    let right__2_l = TachyonsClass "right--2-l"

    /// { bottom: -2rem; }
    let bottom__2_l = TachyonsClass "bottom--2-l"

    /// { left: -2rem; }
    let left__2_l = TachyonsClass "left--2-l"

    /// { top: 0; right: 0; bottom: 0; left: 0; }
    let absolute__fill_l = TachyonsClass "absolute--fill-l"

    /// { clear: left; }
    let cl_l = TachyonsClass "cl-l"

    /// { clear: right; }
    let cr_l = TachyonsClass "cr-l"

    /// { clear: both; }
    let cb_l = TachyonsClass "cb-l"

    /// { clear: none; }
    let cn_l = TachyonsClass "cn-l"

    /// { display: none; }
    let dn_l = TachyonsClass "dn-l"

    /// { display: inline; }
    let di_l = TachyonsClass "di-l"

    /// { display: block; }
    let db_l = TachyonsClass "db-l"

    /// { display: inline-block; }
    let dib_l = TachyonsClass "dib-l"

    /// { display: inline-table; }
    let dit_l = TachyonsClass "dit-l"

    /// { display: table; }
    let dt_l = TachyonsClass "dt-l"

    /// { display: table-cell; }
    let dtc_l = TachyonsClass "dtc-l"

    /// { display: table-row; }
    let dt_row_l = TachyonsClass "dt-row-l"

    /// { display: table-row-group; }
    let dt_row_group_l = TachyonsClass "dt-row-group-l"

    /// { display: table-column; }
    let dt_column_l = TachyonsClass "dt-column-l"

    /// { display: table-column-group; }
    let dt_column_group_l = TachyonsClass "dt-column-group-l"

    /// { table-layout: fixed; width: 100%; }
    let dt__fixed_l = TachyonsClass "dt--fixed-l"

    /// { display: flex; }
    let flex_l = TachyonsClass "flex-l"

    /// { display: inline-flex; }
    let inline_flex_l = TachyonsClass "inline-flex-l"

    /// { flex: 1 1 auto; min-width: 0; /* 1 */ min-height: 0; /* 1 */ }
    let flex_auto_l = TachyonsClass "flex-auto-l"

    /// { flex: none; }
    let flex_none_l = TachyonsClass "flex-none-l"

    /// { flex-direction: column; }
    let flex_column_l = TachyonsClass "flex-column-l"

    /// { flex-direction: row; }
    let flex_row_l = TachyonsClass "flex-row-l"

    /// { flex-wrap: wrap; }
    let flex_wrap_l = TachyonsClass "flex-wrap-l"

    /// { flex-wrap: nowrap; }
    let flex_nowrap_l = TachyonsClass "flex-nowrap-l"

    /// { flex-wrap: wrap-reverse; }
    let flex_wrap_reverse_l = TachyonsClass "flex-wrap-reverse-l"

    /// { flex-direction: column-reverse; }
    let flex_column_reverse_l = TachyonsClass "flex-column-reverse-l"

    /// { flex-direction: row-reverse; }
    let flex_row_reverse_l = TachyonsClass "flex-row-reverse-l"

    /// { align-items: flex-start; }
    let items_start_l = TachyonsClass "items-start-l"

    /// { align-items: flex-end; }
    let items_end_l = TachyonsClass "items-end-l"

    /// { align-items: center; }
    let items_center_l = TachyonsClass "items-center-l"

    /// { align-items: baseline; }
    let items_baseline_l = TachyonsClass "items-baseline-l"

    /// { align-items: stretch; }
    let items_stretch_l = TachyonsClass "items-stretch-l"

    /// { align-self: flex-start; }
    let self_start_l = TachyonsClass "self-start-l"

    /// { align-self: flex-end; }
    let self_end_l = TachyonsClass "self-end-l"

    /// { align-self: center; }
    let self_center_l = TachyonsClass "self-center-l"

    /// { align-self: baseline; }
    let self_baseline_l = TachyonsClass "self-baseline-l"

    /// { align-self: stretch; }
    let self_stretch_l = TachyonsClass "self-stretch-l"

    /// { justify-content: flex-start; }
    let justify_start_l = TachyonsClass "justify-start-l"

    /// { justify-content: flex-end; }
    let justify_end_l = TachyonsClass "justify-end-l"

    /// { justify-content: center; }
    let justify_center_l = TachyonsClass "justify-center-l"

    /// { justify-content: space-between; }
    let justify_between_l = TachyonsClass "justify-between-l"

    /// { justify-content: space-around; }
    let justify_around_l = TachyonsClass "justify-around-l"

    /// { align-content: flex-start; }
    let content_start_l = TachyonsClass "content-start-l"

    /// { align-content: flex-end; }
    let content_end_l = TachyonsClass "content-end-l"

    /// { align-content: center; }
    let content_center_l = TachyonsClass "content-center-l"

    /// { align-content: space-between; }
    let content_between_l = TachyonsClass "content-between-l"

    /// { align-content: space-around; }
    let content_around_l = TachyonsClass "content-around-l"

    /// { align-content: stretch; }
    let content_stretch_l = TachyonsClass "content-stretch-l"

    /// { order: 0; }
    let order_0_l = TachyonsClass "order-0-l"

    /// { order: 1; }
    let order_1_l = TachyonsClass "order-1-l"

    /// { order: 2; }
    let order_2_l = TachyonsClass "order-2-l"

    /// { order: 3; }
    let order_3_l = TachyonsClass "order-3-l"

    /// { order: 4; }
    let order_4_l = TachyonsClass "order-4-l"

    /// { order: 5; }
    let order_5_l = TachyonsClass "order-5-l"

    /// { order: 6; }
    let order_6_l = TachyonsClass "order-6-l"

    /// { order: 7; }
    let order_7_l = TachyonsClass "order-7-l"

    /// { order: 8; }
    let order_8_l = TachyonsClass "order-8-l"

    /// { order: 99999; }
    let order_last_l = TachyonsClass "order-last-l"

    /// { flex-grow: 0; }
    let flex_grow_0_l = TachyonsClass "flex-grow-0-l"

    /// { flex-grow: 1; }
    let flex_grow_1_l = TachyonsClass "flex-grow-1-l"

    /// { flex-shrink: 0; }
    let flex_shrink_0_l = TachyonsClass "flex-shrink-0-l"

    /// { flex-shrink: 1; }
    let flex_shrink_1_l = TachyonsClass "flex-shrink-1-l"

    /// { float: left; _display: inline; }
    let fl_l = TachyonsClass "fl-l"

    /// { float: right; _display: inline; }
    let fr_l = TachyonsClass "fr-l"

    /// { float: none; }
    let fn_l = TachyonsClass "fn-l"

    /// { font-style: italic; }
    let i_l = TachyonsClass "i-l"

    /// { font-style: normal; }
    let fs_normal_l = TachyonsClass "fs-normal-l"

    /// { font-weight: normal; }
    let normal_l = TachyonsClass "normal-l"

    /// { font-weight: bold; }
    let b_l = TachyonsClass "b-l"

    /// { font-weight: 100; }
    let fw1_l = TachyonsClass "fw1-l"

    /// { font-weight: 200; }
    let fw2_l = TachyonsClass "fw2-l"

    /// { font-weight: 300; }
    let fw3_l = TachyonsClass "fw3-l"

    /// { font-weight: 400; }
    let fw4_l = TachyonsClass "fw4-l"

    /// { font-weight: 500; }
    let fw5_l = TachyonsClass "fw5-l"

    /// { font-weight: 600; }
    let fw6_l = TachyonsClass "fw6-l"

    /// { font-weight: 700; }
    let fw7_l = TachyonsClass "fw7-l"

    /// { font-weight: 800; }
    let fw8_l = TachyonsClass "fw8-l"

    /// { font-weight: 900; }
    let fw9_l = TachyonsClass "fw9-l"

    /// { height: 1rem; }
    let h1_l = TachyonsClass "h1-l"

    /// { height: 2rem; }
    let h2_l = TachyonsClass "h2-l"

    /// { height: 4rem; }
    let h3_l = TachyonsClass "h3-l"

    /// { height: 8rem; }
    let h4_l = TachyonsClass "h4-l"

    /// { height: 16rem; }
    let h5_l = TachyonsClass "h5-l"

    /// { height: 25%; }
    let h_25_l = TachyonsClass "h-25-l"

    /// { height: 50%; }
    let h_50_l = TachyonsClass "h-50-l"

    /// { height: 75%; }
    let h_75_l = TachyonsClass "h-75-l"

    /// { height: 100%; }
    let h_100_l = TachyonsClass "h-100-l"

    /// { min-height: 100%; }
    let min_h_100_l = TachyonsClass "min-h-100-l"

    /// { height: 25vh; }
    let vh_25_l = TachyonsClass "vh-25-l"

    /// { height: 50vh; }
    let vh_50_l = TachyonsClass "vh-50-l"

    /// { height: 75vh; }
    let vh_75_l = TachyonsClass "vh-75-l"

    /// { height: 100vh; }
    let vh_100_l = TachyonsClass "vh-100-l"

    /// { min-height: 100vh; }
    let min_vh_100_l = TachyonsClass "min-vh-100-l"

    /// { height: auto; }
    let h_auto_l = TachyonsClass "h-auto-l"

    /// { height: inherit; }
    let h_inherit_l = TachyonsClass "h-inherit-l"

    /// { letter-spacing: .1em; }
    let tracked_l = TachyonsClass "tracked-l"

    /// { letter-spacing: -.05em; }
    let tracked_tight_l = TachyonsClass "tracked-tight-l"

    /// { letter-spacing: .25em; }
    let tracked_mega_l = TachyonsClass "tracked-mega-l"

    /// { line-height: 1; }
    let lh_solid_l = TachyonsClass "lh-solid-l"

    /// { line-height: 1.25; }
    let lh_title_l = TachyonsClass "lh-title-l"

    /// { line-height: 1.5; }
    let lh_copy_l = TachyonsClass "lh-copy-l"

    /// { max-width: 100%; }
    let mw_100_l = TachyonsClass "mw-100-l"

    /// { max-width: 1rem; }
    let mw1_l = TachyonsClass "mw1-l"

    /// { max-width: 2rem; }
    let mw2_l = TachyonsClass "mw2-l"

    /// { max-width: 4rem; }
    let mw3_l = TachyonsClass "mw3-l"

    /// { max-width: 8rem; }
    let mw4_l = TachyonsClass "mw4-l"

    /// { max-width: 16rem; }
    let mw5_l = TachyonsClass "mw5-l"

    /// { max-width: 32rem; }
    let mw6_l = TachyonsClass "mw6-l"

    /// { max-width: 48rem; }
    let mw7_l = TachyonsClass "mw7-l"

    /// { max-width: 64rem; }
    let mw8_l = TachyonsClass "mw8-l"

    /// { max-width: 96rem; }
    let mw9_l = TachyonsClass "mw9-l"

    /// { max-width: none; }
    let mw_none_l = TachyonsClass "mw-none-l"

    /// { width: 1rem; }
    let w1_l = TachyonsClass "w1-l"

    /// { width: 2rem; }
    let w2_l = TachyonsClass "w2-l"

    /// { width: 4rem; }
    let w3_l = TachyonsClass "w3-l"

    /// { width: 8rem; }
    let w4_l = TachyonsClass "w4-l"

    /// { width: 16rem; }
    let w5_l = TachyonsClass "w5-l"

    /// { width: 10%; }
    let w_10_l = TachyonsClass "w-10-l"

    /// { width: 20%; }
    let w_20_l = TachyonsClass "w-20-l"

    /// { width: 25%; }
    let w_25_l = TachyonsClass "w-25-l"

    /// { width: 30%; }
    let w_30_l = TachyonsClass "w-30-l"

    /// { width: 33%; }
    let w_33_l = TachyonsClass "w-33-l"

    /// { width: 34%; }
    let w_34_l = TachyonsClass "w-34-l"

    /// { width: 40%; }
    let w_40_l = TachyonsClass "w-40-l"

    /// { width: 50%; }
    let w_50_l = TachyonsClass "w-50-l"

    /// { width: 60%; }
    let w_60_l = TachyonsClass "w-60-l"

    /// { width: 70%; }
    let w_70_l = TachyonsClass "w-70-l"

    /// { width: 75%; }
    let w_75_l = TachyonsClass "w-75-l"

    /// { width: 80%; }
    let w_80_l = TachyonsClass "w-80-l"

    /// { width: 90%; }
    let w_90_l = TachyonsClass "w-90-l"

    /// { width: 100%; }
    let w_100_l = TachyonsClass "w-100-l"

    /// { width: 33.33333%; }
    let w_third_l = TachyonsClass "w-third-l"

    /// { width: 66.66667%; }
    let w_two_thirds_l = TachyonsClass "w-two-thirds-l"

    /// { width: auto; }
    let w_auto_l = TachyonsClass "w-auto-l"

    /// { overflow: visible; }
    let overflow_visible_l = TachyonsClass "overflow-visible-l"

    /// { overflow: hidden; }
    let overflow_hidden_l = TachyonsClass "overflow-hidden-l"

    /// { overflow: scroll; }
    let overflow_scroll_l = TachyonsClass "overflow-scroll-l"

    /// { overflow: auto; }
    let overflow_auto_l = TachyonsClass "overflow-auto-l"

    /// { overflow-x: visible; }
    let overflow_x_visible_l = TachyonsClass "overflow-x-visible-l"

    /// { overflow-x: hidden; }
    let overflow_x_hidden_l = TachyonsClass "overflow-x-hidden-l"

    /// { overflow-x: scroll; }
    let overflow_x_scroll_l = TachyonsClass "overflow-x-scroll-l"

    /// { overflow-x: auto; }
    let overflow_x_auto_l = TachyonsClass "overflow-x-auto-l"

    /// { overflow-y: visible; }
    let overflow_y_visible_l = TachyonsClass "overflow-y-visible-l"

    /// { overflow-y: hidden; }
    let overflow_y_hidden_l = TachyonsClass "overflow-y-hidden-l"

    /// { overflow-y: scroll; }
    let overflow_y_scroll_l = TachyonsClass "overflow-y-scroll-l"

    /// { overflow-y: auto; }
    let overflow_y_auto_l = TachyonsClass "overflow-y-auto-l"

    /// { position: static; }
    let static_l = TachyonsClass "static-l"

    /// { position: relative; }
    let relative_l = TachyonsClass "relative-l"

    /// { position: absolute; }
    let absolute_l = TachyonsClass "absolute-l"

    /// { position: fixed; }
    let fixed_l = TachyonsClass "fixed-l"

    /// { -webkit-transform: rotate( 45deg ); transform: rotate( 45deg ); }
    let rotate_45_l = TachyonsClass "rotate-45-l"

    /// { -webkit-transform: rotate( 90deg ); transform: rotate( 90deg ); }
    let rotate_90_l = TachyonsClass "rotate-90-l"

    /// { -webkit-transform: rotate( 135deg ); transform: rotate( 135deg ); }
    let rotate_135_l = TachyonsClass "rotate-135-l"

    /// { -webkit-transform: rotate( 180deg ); transform: rotate( 180deg ); }
    let rotate_180_l = TachyonsClass "rotate-180-l"

    /// { -webkit-transform: rotate( 225deg ); transform: rotate( 225deg ); }
    let rotate_225_l = TachyonsClass "rotate-225-l"

    /// { -webkit-transform: rotate( 270deg ); transform: rotate( 270deg ); }
    let rotate_270_l = TachyonsClass "rotate-270-l"

    /// { -webkit-transform: rotate( 315deg ); transform: rotate( 315deg ); }
    let rotate_315_l = TachyonsClass "rotate-315-l"

    /// { padding: 0; }
    let pa0_l = TachyonsClass "pa0-l"

    /// { padding: .25rem; }
    let pa1_l = TachyonsClass "pa1-l"

    /// { padding: .5rem; }
    let pa2_l = TachyonsClass "pa2-l"

    /// { padding: 1rem; }
    let pa3_l = TachyonsClass "pa3-l"

    /// { padding: 2rem; }
    let pa4_l = TachyonsClass "pa4-l"

    /// { padding: 4rem; }
    let pa5_l = TachyonsClass "pa5-l"

    /// { padding: 8rem; }
    let pa6_l = TachyonsClass "pa6-l"

    /// { padding: 16rem; }
    let pa7_l = TachyonsClass "pa7-l"

    /// { padding-left: 0; }
    let pl0_l = TachyonsClass "pl0-l"

    /// { padding-left: .25rem; }
    let pl1_l = TachyonsClass "pl1-l"

    /// { padding-left: .5rem; }
    let pl2_l = TachyonsClass "pl2-l"

    /// { padding-left: 1rem; }
    let pl3_l = TachyonsClass "pl3-l"

    /// { padding-left: 2rem; }
    let pl4_l = TachyonsClass "pl4-l"

    /// { padding-left: 4rem; }
    let pl5_l = TachyonsClass "pl5-l"

    /// { padding-left: 8rem; }
    let pl6_l = TachyonsClass "pl6-l"

    /// { padding-left: 16rem; }
    let pl7_l = TachyonsClass "pl7-l"

    /// { padding-right: 0; }
    let pr0_l = TachyonsClass "pr0-l"

    /// { padding-right: .25rem; }
    let pr1_l = TachyonsClass "pr1-l"

    /// { padding-right: .5rem; }
    let pr2_l = TachyonsClass "pr2-l"

    /// { padding-right: 1rem; }
    let pr3_l = TachyonsClass "pr3-l"

    /// { padding-right: 2rem; }
    let pr4_l = TachyonsClass "pr4-l"

    /// { padding-right: 4rem; }
    let pr5_l = TachyonsClass "pr5-l"

    /// { padding-right: 8rem; }
    let pr6_l = TachyonsClass "pr6-l"

    /// { padding-right: 16rem; }
    let pr7_l = TachyonsClass "pr7-l"

    /// { padding-bottom: 0; }
    let pb0_l = TachyonsClass "pb0-l"

    /// { padding-bottom: .25rem; }
    let pb1_l = TachyonsClass "pb1-l"

    /// { padding-bottom: .5rem; }
    let pb2_l = TachyonsClass "pb2-l"

    /// { padding-bottom: 1rem; }
    let pb3_l = TachyonsClass "pb3-l"

    /// { padding-bottom: 2rem; }
    let pb4_l = TachyonsClass "pb4-l"

    /// { padding-bottom: 4rem; }
    let pb5_l = TachyonsClass "pb5-l"

    /// { padding-bottom: 8rem; }
    let pb6_l = TachyonsClass "pb6-l"

    /// { padding-bottom: 16rem; }
    let pb7_l = TachyonsClass "pb7-l"

    /// { padding-top: 0; }
    let pt0_l = TachyonsClass "pt0-l"

    /// { padding-top: .25rem; }
    let pt1_l = TachyonsClass "pt1-l"

    /// { padding-top: .5rem; }
    let pt2_l = TachyonsClass "pt2-l"

    /// { padding-top: 1rem; }
    let pt3_l = TachyonsClass "pt3-l"

    /// { padding-top: 2rem; }
    let pt4_l = TachyonsClass "pt4-l"

    /// { padding-top: 4rem; }
    let pt5_l = TachyonsClass "pt5-l"

    /// { padding-top: 8rem; }
    let pt6_l = TachyonsClass "pt6-l"

    /// { padding-top: 16rem; }
    let pt7_l = TachyonsClass "pt7-l"

    /// { padding-top: 0; padding-bottom: 0; }
    let pv0_l = TachyonsClass "pv0-l"

    /// { padding-top: .25rem; padding-bottom: .25rem; }
    let pv1_l = TachyonsClass "pv1-l"

    /// { padding-top: .5rem; padding-bottom: .5rem; }
    let pv2_l = TachyonsClass "pv2-l"

    /// { padding-top: 1rem; padding-bottom: 1rem; }
    let pv3_l = TachyonsClass "pv3-l"

    /// { padding-top: 2rem; padding-bottom: 2rem; }
    let pv4_l = TachyonsClass "pv4-l"

    /// { padding-top: 4rem; padding-bottom: 4rem; }
    let pv5_l = TachyonsClass "pv5-l"

    /// { padding-top: 8rem; padding-bottom: 8rem; }
    let pv6_l = TachyonsClass "pv6-l"

    /// { padding-top: 16rem; padding-bottom: 16rem; }
    let pv7_l = TachyonsClass "pv7-l"

    /// { padding-left: 0; padding-right: 0; }
    let ph0_l = TachyonsClass "ph0-l"

    /// { padding-left: .25rem; padding-right: .25rem; }
    let ph1_l = TachyonsClass "ph1-l"

    /// { padding-left: .5rem; padding-right: .5rem; }
    let ph2_l = TachyonsClass "ph2-l"

    /// { padding-left: 1rem; padding-right: 1rem; }
    let ph3_l = TachyonsClass "ph3-l"

    /// { padding-left: 2rem; padding-right: 2rem; }
    let ph4_l = TachyonsClass "ph4-l"

    /// { padding-left: 4rem; padding-right: 4rem; }
    let ph5_l = TachyonsClass "ph5-l"

    /// { padding-left: 8rem; padding-right: 8rem; }
    let ph6_l = TachyonsClass "ph6-l"

    /// { padding-left: 16rem; padding-right: 16rem; }
    let ph7_l = TachyonsClass "ph7-l"

    /// { margin: 0; }
    let ma0_l = TachyonsClass "ma0-l"

    /// { margin: .25rem; }
    let ma1_l = TachyonsClass "ma1-l"

    /// { margin: .5rem; }
    let ma2_l = TachyonsClass "ma2-l"

    /// { margin: 1rem; }
    let ma3_l = TachyonsClass "ma3-l"

    /// { margin: 2rem; }
    let ma4_l = TachyonsClass "ma4-l"

    /// { margin: 4rem; }
    let ma5_l = TachyonsClass "ma5-l"

    /// { margin: 8rem; }
    let ma6_l = TachyonsClass "ma6-l"

    /// { margin: 16rem; }
    let ma7_l = TachyonsClass "ma7-l"

    /// { margin-left: 0; }
    let ml0_l = TachyonsClass "ml0-l"

    /// { margin-left: .25rem; }
    let ml1_l = TachyonsClass "ml1-l"

    /// { margin-left: .5rem; }
    let ml2_l = TachyonsClass "ml2-l"

    /// { margin-left: 1rem; }
    let ml3_l = TachyonsClass "ml3-l"

    /// { margin-left: 2rem; }
    let ml4_l = TachyonsClass "ml4-l"

    /// { margin-left: 4rem; }
    let ml5_l = TachyonsClass "ml5-l"

    /// { margin-left: 8rem; }
    let ml6_l = TachyonsClass "ml6-l"

    /// { margin-left: 16rem; }
    let ml7_l = TachyonsClass "ml7-l"

    /// { margin-right: 0; }
    let mr0_l = TachyonsClass "mr0-l"

    /// { margin-right: .25rem; }
    let mr1_l = TachyonsClass "mr1-l"

    /// { margin-right: .5rem; }
    let mr2_l = TachyonsClass "mr2-l"

    /// { margin-right: 1rem; }
    let mr3_l = TachyonsClass "mr3-l"

    /// { margin-right: 2rem; }
    let mr4_l = TachyonsClass "mr4-l"

    /// { margin-right: 4rem; }
    let mr5_l = TachyonsClass "mr5-l"

    /// { margin-right: 8rem; }
    let mr6_l = TachyonsClass "mr6-l"

    /// { margin-right: 16rem; }
    let mr7_l = TachyonsClass "mr7-l"

    /// { margin-bottom: 0; }
    let mb0_l = TachyonsClass "mb0-l"

    /// { margin-bottom: .25rem; }
    let mb1_l = TachyonsClass "mb1-l"

    /// { margin-bottom: .5rem; }
    let mb2_l = TachyonsClass "mb2-l"

    /// { margin-bottom: 1rem; }
    let mb3_l = TachyonsClass "mb3-l"

    /// { margin-bottom: 2rem; }
    let mb4_l = TachyonsClass "mb4-l"

    /// { margin-bottom: 4rem; }
    let mb5_l = TachyonsClass "mb5-l"

    /// { margin-bottom: 8rem; }
    let mb6_l = TachyonsClass "mb6-l"

    /// { margin-bottom: 16rem; }
    let mb7_l = TachyonsClass "mb7-l"

    /// { margin-top: 0; }
    let mt0_l = TachyonsClass "mt0-l"

    /// { margin-top: .25rem; }
    let mt1_l = TachyonsClass "mt1-l"

    /// { margin-top: .5rem; }
    let mt2_l = TachyonsClass "mt2-l"

    /// { margin-top: 1rem; }
    let mt3_l = TachyonsClass "mt3-l"

    /// { margin-top: 2rem; }
    let mt4_l = TachyonsClass "mt4-l"

    /// { margin-top: 4rem; }
    let mt5_l = TachyonsClass "mt5-l"

    /// { margin-top: 8rem; }
    let mt6_l = TachyonsClass "mt6-l"

    /// { margin-top: 16rem; }
    let mt7_l = TachyonsClass "mt7-l"

    /// { margin-top: 0; margin-bottom: 0; }
    let mv0_l = TachyonsClass "mv0-l"

    /// { margin-top: .25rem; margin-bottom: .25rem; }
    let mv1_l = TachyonsClass "mv1-l"

    /// { margin-top: .5rem; margin-bottom: .5rem; }
    let mv2_l = TachyonsClass "mv2-l"

    /// { margin-top: 1rem; margin-bottom: 1rem; }
    let mv3_l = TachyonsClass "mv3-l"

    /// { margin-top: 2rem; margin-bottom: 2rem; }
    let mv4_l = TachyonsClass "mv4-l"

    /// { margin-top: 4rem; margin-bottom: 4rem; }
    let mv5_l = TachyonsClass "mv5-l"

    /// { margin-top: 8rem; margin-bottom: 8rem; }
    let mv6_l = TachyonsClass "mv6-l"

    /// { margin-top: 16rem; margin-bottom: 16rem; }
    let mv7_l = TachyonsClass "mv7-l"

    /// { margin-left: 0; margin-right: 0; }
    let mh0_l = TachyonsClass "mh0-l"

    /// { margin-left: .25rem; margin-right: .25rem; }
    let mh1_l = TachyonsClass "mh1-l"

    /// { margin-left: .5rem; margin-right: .5rem; }
    let mh2_l = TachyonsClass "mh2-l"

    /// { margin-left: 1rem; margin-right: 1rem; }
    let mh3_l = TachyonsClass "mh3-l"

    /// { margin-left: 2rem; margin-right: 2rem; }
    let mh4_l = TachyonsClass "mh4-l"

    /// { margin-left: 4rem; margin-right: 4rem; }
    let mh5_l = TachyonsClass "mh5-l"

    /// { margin-left: 8rem; margin-right: 8rem; }
    let mh6_l = TachyonsClass "mh6-l"

    /// { margin-left: 16rem; margin-right: 16rem; }
    let mh7_l = TachyonsClass "mh7-l"

    /// { margin: -0.25rem; }
    let na1_l = TachyonsClass "na1-l"

    /// { margin: -0.5rem; }
    let na2_l = TachyonsClass "na2-l"

    /// { margin: -1rem; }
    let na3_l = TachyonsClass "na3-l"

    /// { margin: -2rem; }
    let na4_l = TachyonsClass "na4-l"

    /// { margin: -4rem; }
    let na5_l = TachyonsClass "na5-l"

    /// { margin: -8rem; }
    let na6_l = TachyonsClass "na6-l"

    /// { margin: -16rem; }
    let na7_l = TachyonsClass "na7-l"

    /// { margin-left: -0.25rem; }
    let nl1_l = TachyonsClass "nl1-l"

    /// { margin-left: -0.5rem; }
    let nl2_l = TachyonsClass "nl2-l"

    /// { margin-left: -1rem; }
    let nl3_l = TachyonsClass "nl3-l"

    /// { margin-left: -2rem; }
    let nl4_l = TachyonsClass "nl4-l"

    /// { margin-left: -4rem; }
    let nl5_l = TachyonsClass "nl5-l"

    /// { margin-left: -8rem; }
    let nl6_l = TachyonsClass "nl6-l"

    /// { margin-left: -16rem; }
    let nl7_l = TachyonsClass "nl7-l"

    /// { margin-right: -0.25rem; }
    let nr1_l = TachyonsClass "nr1-l"

    /// { margin-right: -0.5rem; }
    let nr2_l = TachyonsClass "nr2-l"

    /// { margin-right: -1rem; }
    let nr3_l = TachyonsClass "nr3-l"

    /// { margin-right: -2rem; }
    let nr4_l = TachyonsClass "nr4-l"

    /// { margin-right: -4rem; }
    let nr5_l = TachyonsClass "nr5-l"

    /// { margin-right: -8rem; }
    let nr6_l = TachyonsClass "nr6-l"

    /// { margin-right: -16rem; }
    let nr7_l = TachyonsClass "nr7-l"

    /// { margin-bottom: -0.25rem; }
    let nb1_l = TachyonsClass "nb1-l"

    /// { margin-bottom: -0.5rem; }
    let nb2_l = TachyonsClass "nb2-l"

    /// { margin-bottom: -1rem; }
    let nb3_l = TachyonsClass "nb3-l"

    /// { margin-bottom: -2rem; }
    let nb4_l = TachyonsClass "nb4-l"

    /// { margin-bottom: -4rem; }
    let nb5_l = TachyonsClass "nb5-l"

    /// { margin-bottom: -8rem; }
    let nb6_l = TachyonsClass "nb6-l"

    /// { margin-bottom: -16rem; }
    let nb7_l = TachyonsClass "nb7-l"

    /// { margin-top: -0.25rem; }
    let nt1_l = TachyonsClass "nt1-l"

    /// { margin-top: -0.5rem; }
    let nt2_l = TachyonsClass "nt2-l"

    /// { margin-top: -1rem; }
    let nt3_l = TachyonsClass "nt3-l"

    /// { margin-top: -2rem; }
    let nt4_l = TachyonsClass "nt4-l"

    /// { margin-top: -4rem; }
    let nt5_l = TachyonsClass "nt5-l"

    /// { margin-top: -8rem; }
    let nt6_l = TachyonsClass "nt6-l"

    /// { margin-top: -16rem; }
    let nt7_l = TachyonsClass "nt7-l"

    /// { text-decoration: line-through; }
    let strike_l = TachyonsClass "strike-l"

    /// { text-decoration: underline; }
    let underline_l = TachyonsClass "underline-l"

    /// { text-decoration: none; }
    let no_underline_l = TachyonsClass "no-underline-l"

    /// { text-align: left; }
    let tl_l = TachyonsClass "tl-l"

    /// { text-align: right; }
    let tr_l = TachyonsClass "tr-l"

    /// { text-align: center; }
    let tc_l = TachyonsClass "tc-l"

    /// { text-align: justify; }
    let tj_l = TachyonsClass "tj-l"

    /// { text-transform: capitalize; }
    let ttc_l = TachyonsClass "ttc-l"

    /// { text-transform: lowercase; }
    let ttl_l = TachyonsClass "ttl-l"

    /// { text-transform: uppercase; }
    let ttu_l = TachyonsClass "ttu-l"

    /// { text-transform: none; }
    let ttn_l = TachyonsClass "ttn-l"

    /// { font-size: 6rem; }
    let f_6_l = TachyonsClass "f-6-l"

    /// { font-size: 6rem; }
    let f_headline_l = TachyonsClass "f-headline-l"

    /// { font-size: 5rem; }
    let f_5_l = TachyonsClass "f-5-l"

    /// { font-size: 5rem; }
    let f_subheadline_l = TachyonsClass "f-subheadline-l"

    /// { font-size: 3rem; }
    let f1_l = TachyonsClass "f1-l"

    /// { font-size: 2.25rem; }
    let f2_l = TachyonsClass "f2-l"

    /// { font-size: 1.5rem; }
    let f3_l = TachyonsClass "f3-l"

    /// { font-size: 1.25rem; }
    let f4_l = TachyonsClass "f4-l"

    /// { font-size: 1rem; }
    let f5_l = TachyonsClass "f5-l"

    /// { font-size: .875rem; }
    let f6_l = TachyonsClass "f6-l"

    /// { font-size: .75rem; }
    let f7_l = TachyonsClass "f7-l"

    /// { max-width: 30em; }
    let measure_l = TachyonsClass "measure-l"

    /// { max-width: 34em; }
    let measure_wide_l = TachyonsClass "measure-wide-l"

    /// { max-width: 20em; }
    let measure_narrow_l = TachyonsClass "measure-narrow-l"

    /// { text-indent: 1em; margin-top: 0; margin-bottom: 0; }
    let indent_l = TachyonsClass "indent-l"

    /// { font-variant: small-caps; }
    let small_caps_l = TachyonsClass "small-caps-l"

    /// { white-space: nowrap; overflow: hidden; text-overflow: ellipsis; }
    let truncate_l = TachyonsClass "truncate-l"

    /// { margin-right: auto; margin-left: auto; }
    let center_l = TachyonsClass "center-l"

    /// { margin-right: auto; }
    let mr_auto_l = TachyonsClass "mr-auto-l"

    /// { margin-left: auto; }
    let ml_auto_l = TachyonsClass "ml-auto-l"

    /// { position: fixed !important; _position: absolute !important; clip: rect( 1px 1px 1px 1px ); /* IE6, IE7 */ clip: rect( 1px, 1px, 1px, 1px ); }
    let clip_l = TachyonsClass "clip-l"

    /// { white-space: normal; }
    let ws_normal_l = TachyonsClass "ws-normal-l"

    /// { white-space: nowrap; }
    let nowrap_l = TachyonsClass "nowrap-l"

    /// { white-space: pre; }
    let pre_l = TachyonsClass "pre-l"

    /// { vertical-align: baseline; }
    let v_base_l = TachyonsClass "v-base-l"

    /// { vertical-align: middle; }
    let v_mid_l = TachyonsClass "v-mid-l"

    /// { vertical-align: top; }
    let v_top_l = TachyonsClass "v-top-l"

    /// { vertical-align: bottom; }
    let v_btm_l = TachyonsClass "v-btm-l"
