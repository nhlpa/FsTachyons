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

        let outline_black         = buttonBase + b__black + ba + black
        let outline_near_black    = buttonBase + b__near_black + ba + near_black
        let outline_dark_gray     = buttonBase + b__dark_gray + ba + dark_gray
        let outline_mid_gray      = buttonBase + b__mid_gray + ba + mid_gray
        let outline_gray          = buttonBase + b__gray + ba + gray
        let outline_silver        = buttonBase + b__silver + ba + silver
        let outline_light_silver  = buttonBase + b__light_silver + ba + light_silver
        let outline_moon_gray     = buttonBase + b__moon_gray + ba + moon_gray
        let outline_light_gray    = buttonBase + b__light_gray + ba + light_gray
        let outline_near_white    = buttonBase + b__near_white + ba + near_white
        let outline_white         = buttonBase + b__white + ba + white
        let outline_dark_red      = buttonBase + b__dark_red + ba + dark_red
        let outline_red           = buttonBase + b__red + ba + red
        let outline_light_red     = buttonBase + b__light_red + ba + light_red
        let outline_orange        = buttonBase + b__orange + ba + orange
        let outline_gold          = buttonBase + b__gold + ba + gold
        let outline_yellow        = buttonBase + b__yellow + ba + yellow
        let outline_light_yellow  = buttonBase + b__light_yellow + ba + light_yellow
        let outline_purple        = buttonBase + b__purple + ba + purple
        let outline_light_purple  = buttonBase + b__light_purple + ba + light_purple
        let outline_dark_pink     = buttonBase + b__dark_pink + ba + dark_pink
        let outline_hot_pink      = buttonBase + b__hot_pink + ba + hot_pink
        let outline_pink          = buttonBase + b__pink + ba + pink
        let outline_light_pink    = buttonBase + b__light_pink + ba + light_pink
        let outline_dark_green    = buttonBase + b__dark_green + ba + dark_green
        let outline_green         = buttonBase + b__green + ba + green
        let outline_light_green   = buttonBase + b__light_green + ba + light_green
        let outline_navy          = buttonBase + b__navy + ba + navy
        let outline_dark_blue     = buttonBase + b__dark_blue + ba + dark_blue
        let outline_blue          = buttonBase + b__blue + ba + blue
        let outline_light_blue    = buttonBase + b__light_blue + ba + light_blue
        let outline_lightest_blue = buttonBase + b__lightest_blue + ba + lightest_blue
        let outline_washed_blue   = buttonBase + b__washed_blue + ba + washed_blue
        let outline_washed_green  = buttonBase + b__washed_green + ba + washed_green
        let outline_washed_yellow = buttonBase + b__washed_yellow + ba + washed_yellow
        let outline_washed_red    = buttonBase + b__washed_red + ba + washed_red
