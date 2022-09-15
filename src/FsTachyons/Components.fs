namespace FsTachyons

open FsTachyons.Tac

module Components =

    module Btn =
        let private buttonBase =
            f6 + link + dim + br1 + ph3 + pv2 + mb2 + dib

        let bg_black         = buttonBase + bg_black + bn + white
        let bg_near_black    = buttonBase + bg_near_black + bn + white
        let bg_dark_gray     = buttonBase + bg_dark_gray + bn + white
        let bg_mid_gray      = buttonBase + bg_mid_gray + bn + white
        let bg_gray          = buttonBase + bg_gray + bn + white
        let bg_silver        = buttonBase + bg_silver + bn + white
        let bg_light_silver  = buttonBase + bg_light_silver + bn + white
        let bg_moon_gray     = buttonBase + bg_moon_gray + bn + white
        let bg_light_gray    = buttonBase + bg_light_gray + bn + white
        let bg_near_white    = buttonBase + bg_near_white + bn + black
        let bg_white         = buttonBase + bg_white + bn + black
        let bg_transparent   = buttonBase + bg_transparent + bn + black
        let bg_dark_red      = buttonBase + bg_dark_red + bn + white
        let bg_red           = buttonBase + bg_red + bn + white
        let bg_light_red     = buttonBase + bg_light_red + bn + white
        let bg_orange        = buttonBase + bg_orange + bn + white
        let bg_gold          = buttonBase + bg_gold + bn + white
        let bg_yellow        = buttonBase + bg_yellow + bn + white
        let bg_light_yellow  = buttonBase + bg_light_yellow + bn + white
        let bg_purple        = buttonBase + bg_purple + bn + white
        let bg_light_purple  = buttonBase + bg_light_purple + bn + white
        let bg_dark_pink     = buttonBase + bg_dark_pink + bn + white
        let bg_hot_pink      = buttonBase + bg_hot_pink + bn + white
        let bg_pink          = buttonBase + bg_pink + bn + white
        let bg_light_pink    = buttonBase + bg_light_pink + bn + white
        let bg_dark_green    = buttonBase + bg_dark_green + bn + white
        let bg_green         = buttonBase + bg_green + bn + white
        let bg_light_green   = buttonBase + bg_light_green + bn + white
        let bg_navy          = buttonBase + bg_navy + bn + white
        let bg_dark_blue     = buttonBase + bg_dark_blue + bn + white
        let bg_blue          = buttonBase + bg_blue + bn + white
        let bg_light_blue    = buttonBase + bg_light_blue + bn + white
        let bg_lightest_blue = buttonBase + bg_lightest_blue + bn + white
        let bg_washed_blue   = buttonBase + bg_washed_blue + bn + white
        let bg_washed_green  = buttonBase + bg_washed_green + bn + white
        let bg_washed_yellow = buttonBase + bg_washed_yellow + bn + white
        let bg_washed_red    = buttonBase + bg_washed_red + bn + white

        let outline_black         = buttonBase + b__black + ba + white
        let outline_near_black    = buttonBase + b__near_black + ba + white
        let outline_dark_gray     = buttonBase + b__dark_gray + ba + white
        let outline_mid_gray      = buttonBase + b__mid_gray + ba + white
        let outline_gray          = buttonBase + b__gray + ba + white
        let outline_silver        = buttonBase + b__silver + ba + white
        let outline_light_silver  = buttonBase + b__light_silver + ba + white
        let outline_moon_gray     = buttonBase + b__moon_gray + ba + white
        let outline_light_gray    = buttonBase + b__light_gray + ba + white
        let outline_near_white    = buttonBase + b__near_white + ba + black
        let outline_white         = buttonBase + b__white + ba + black
        let outline_transparent   = buttonBase + b__transparent + ba + black
        let outline_dark_red      = buttonBase + b__dark_red + ba + white
        let outline_red           = buttonBase + b__red + ba + white
        let outline_light_red     = buttonBase + b__light_red + ba + white
        let outline_orange        = buttonBase + b__orange + ba + white
        let outline_gold          = buttonBase + b__gold + ba + white
        let outline_yellow        = buttonBase + b__yellow + ba + white
        let outline_light_yellow  = buttonBase + b__light_yellow + ba + white
        let outline_purple        = buttonBase + b__purple + ba + white
        let outline_light_purple  = buttonBase + b__light_purple + ba + white
        let outline_dark_pink     = buttonBase + b__dark_pink + ba + white
        let outline_hot_pink      = buttonBase + b__hot_pink + ba + white
        let outline_pink          = buttonBase + b__pink + ba + white
        let outline_light_pink    = buttonBase + b__light_pink + ba + white
        let outline_dark_green    = buttonBase + b__dark_green + ba + white
        let outline_green         = buttonBase + b__green + ba + white
        let outline_light_green   = buttonBase + b__light_green + ba + white
        let outline_navy          = buttonBase + b__navy + ba + white
        let outline_dark_blue     = buttonBase + b__dark_blue + ba + white
        let outline_blue          = buttonBase + b__blue + ba + white
        let outline_light_blue    = buttonBase + b__light_blue + ba + white
        let outline_lightest_blue = buttonBase + b__lightest_blue + ba + white
        let outline_washed_blue   = buttonBase + b__washed_blue + ba + white
        let outline_washed_green  = buttonBase + b__washed_green + ba + white
        let outline_washed_yellow = buttonBase + b__washed_yellow + ba + white
        let outline_washed_red    = buttonBase + b__washed_red + ba + white
