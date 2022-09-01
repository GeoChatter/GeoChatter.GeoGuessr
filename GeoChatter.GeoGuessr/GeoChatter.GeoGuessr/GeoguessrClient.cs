using GeoChatter.Helpers;
using GeoChatter.Core.Model;
using GeoChatter.Model;
using log4net;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using GeoChatter.Core.Common.Extensions;

namespace GeoChatter.Web
{
    /*
     *     89168: function(e, t) {
        "use strict";
        var n = {
            startPage: function() {
                return "/"
            },
            introGame: function() {
                return "/intro"
            },
            playIntroGame: function() {
                return "/intro/game"
            },
            freeGame: function() {
                return "/free"
            },
            challenge: function(e) {
                return "/challenge/".concat(e)
            },
            results: function(e, t) {
                return "/results/".concat(e).concat(t ? "/?friends" : "")
            },
            leagues: function() {
                return "/leagues"
            },
            createLeague: function() {
                return "/leagues/create"
            },
            league: function(e) {
                return "/leagues/".concat(e)
            },
            map: function(e) {
                return "/maps/".concat(e)
            },
            playMap: function(e) {
                return "/maps/".concat(e, "/play")
            },
            officialMaps: function() {
                return "/maps/official"
            },
            popularMaps: function() {
                return "/maps/popular"
            },
            newMaps: function() {
                return "/maps/new"
            },
            editorsChoice: function() {
                return "/maps/editors-choice"
            },
            search: function(e) {
                return e ? "/search?query=".concat(encodeURIComponent(e)) : "/search"
            },
            signupForPro: function(e, t) {
                return e && t ? "/pro?utm_source=geoguessr&utm_medium=".concat(e, "&utm_content=").concat(t, "&utm_campaign=pro") : "/pro"
            },
            signedupForPro: function() {
                return "/pro/thanks"
            },
            dailyChallenges: function() {
                return "/daily-challenges"
            },
            user: function(e) {
                return "/user/".concat(e)
            },
            signup: function(e) {
                var t = e.target
                  , n = void 0 === t ? "" : t;
                return "/signup".concat(n ? "?target=".concat(encodeURIComponent(n)) : "")
            },
            signin: function(e) {
                var t = e.target
                  , n = void 0 === t ? "" : t
                  , r = e.prefilledUsername
                  , o = void 0 === r ? "" : r;
                return "/signin".concat(n ? "?target=".concat(encodeURIComponent(n), "&prefilledUsername=").concat(encodeURIComponent(o)) : "")
            },
            signout: function(e) {
                var t = e.target
                  , n = void 0 === t ? "" : t;
                return "/signout".concat(n ? "?target=".concat(encodeURIComponent(n)) : "")
            },
            resetPassword: function() {
                return "profile/reset-password"
            },
            myProfile: function() {
                return "/me/profile"
            },
            mySettings: function() {
                return "/me/settings"
            },
            myActivities: function() {
                return "/me/activities"
            },
            myOngoingGames: function() {
                return "/me/current"
            },
            myFavoriteMaps: function() {
                return "/me/likes"
            },
            myBadges: function() {
                return "/me/badges"
            },
            myMaps: function() {
                return "/me/maps"
            },
            myFriends: function() {
                return "/me/friends"
            },
            streams: function() {
                return "/streams"
            },
            invoice: function(e) {
                return "/me/invoices/".concat(e)
            },
            mapMaker: function(e) {
                return "/map-maker".concat(e ? "/" + e : "")
            },
            explorer: function() {
                return "/explorer"
            },
            countryStreak: function() {
                return "/country-streak"
            },
            usStateStreak: function() {
                return "/us-state-streak"
            },
            streaks: function() {
                return "/streaks"
            },
            competitiveStreaks: function() {
                return "/streaks/competitive"
            },
            support: function() {
                return "/support"
            },
            shop: function() {
                return "https://shop.spreadshirt.se/geoguessr/"
            },
            twitch: function() {
                return "https://www.twitch.tv/directory/game/GeoGuessr/"
            },
            youtube: function() {
                return "https://www.youtube.com/embed?listType=search&list=geoguessr"
            },
            streetview: function(e, t) {
                return "https://www.google.com/maps?q&layer=c&cbll=".concat(e, ",").concat(t)
            },
            giftCards: function() {
                return "/gift-card"
            },
            redeemGiftCard: function() {
                return "/gift-card/redeem"
            },
            kundo: function() {
                return "https://kundo.se/org/geoguessr/"
            },
            emailData: function() {
                return "data@geoguessr.com"
            },
            emailDaniel: function() {
                return "daniel@geoguessr.com"
            },
            emailSubscription: function() {
                return "subscription@geoguessr.com"
            },
            privacy: function() {
                return "/privacy"
            },
            terms: function() {
                return "/terms"
            },
            faq: function() {
                return "https://geoguessr.zendesk.com/hc/"
            },
            verifyEmail: function(e) {
                return "/profile/verify-email/".concat(e)
            },
            edu: function() {
                return "/education"
            },
            eduSignIn: function() {
                return "/education/signin"
            },
            liveChallenge: function(e) {
                return "/live-challenge/".concat(e)
            },
            groupEvents: function() {
                return "/quiz"
            },
            groupEvent: function(e) {
                return "/quiz/".concat(e)
            },
            playGroupEvent: function(e) {
                return "/quiz/play/".concat(e)
            },
            editGroupEvent: function(e) {
                return "/quiz/".concat(e, "/edit")
            },
            finishedGroupEvent: function(e) {
                return "/quiz/".concat(e, "/finished")
            },
            quizCompetition: function() {
                return "/quiz/competition"
            },
            join: function() {
                return "/join"
            },
            joinWithCode: function(e) {
                return "/join/".concat(e)
            },
            gameLobby: function(e, t) {
                switch (t) {
                case "CompetitiveCityStreak":
                    return "/competitive-streak/".concat(e);
                case "BattleRoyaleCountries":
                case "BattleRoyaleDistance":
                    return "/battle-royale/".concat(e);
                case "Duels":
                    return "/duels/".concat(e);
                case "TeamDuels":
                    return "/team-duels/".concat(e);
                case "LiveChallenge":
                    return "/live-challenge/".concat(e);
                case "Bullseye":
                    return "/bullseye/".concat(e);
                default:
                    throw new Error("Invalid ".concat(t))
                }
            },
            competitions: function() {
                return "/competitions"
            },
            competition: function(e) {
                return "/competitions/".concat(e)
            },
            classic: function() {
                return "/classic"
            },
            competitive: function() {
                return "/competitive"
            },
            playWithFriends: function() {
                return "/play-with-friends"
            },
            party: function(e, t) {
                return "/parties/".concat(e) + (t ? "?target=".concat(encodeURIComponent(t)) : "")
            },
            partySettings: function(e) {
                return "/parties/".concat(e, "?settings")
            },
            duels: function(e) {
                return "/duels".concat(e ? "?competitionId=".concat(encodeURIComponent(e)) : "")
            },
            duelsSummary: function(e) {
                return "/duels/".concat(e, "/summary")
            },
            googlePlayStore: function() {
                return "https://play.google.com/store/apps/details?id=com.geoguessr.app"
            },
            appleAppStore: function() {
                return "https://apps.apple.com/us/app/geoguessr/id1049876497"
            }
        };
        t.Z = n
    },
    15667: function(e) {
        e.exports = {
            variantUnderline: "anchor_variantUnderline__8wlJr",
            variantNoUnderline: "anchor_variantNoUnderline__SPwsd"
        }
    },
    53052: function(e) {
        e.exports = {
            titleAvatar: "avatar_titleAvatar__0pdL9",
            titleAvatarImage: "avatar_titleAvatarImage__A51Dx",
            teamAvatarImage: "avatar_teamAvatarImage__p3mW7",
            teamAvatarMargin: "avatar_teamAvatarMargin__QiXQN",
            teamBackgroundred: "avatar_teamBackgroundred__MHuYT",
            teamBackgroundblue: "avatar_teamBackgroundblue__Z6_12",
            teamBackgroundyellow: "avatar_teamBackgroundyellow__cJcpk",
            teamBackgroundgreen: "avatar_teamBackgroundgreen__eW2l5",
            teamBackgroundpurple: "avatar_teamBackgroundpurple__a3MwG",
            teamBackgroundorange: "avatar_teamBackgroundorange__LvLdl",
            titleAvatarFrame: "avatar_titleAvatarFrame__AT57_",
            annotation: "avatar_annotation__0mngH"
        }
    },
    5935: function(e) {
        e.exports = {
            annotation: "badge_annotation__7_znn"
        }
    },
    59626: function(e) {
        e.exports = {
            button: "button_button__CnARx",
            link: "button_link__xHa3x",
            disabled: "button_disabled__dEfBZ",
            loading: "button_loading__gorPD",
            variantPrimary: "button_variantPrimary__xc8Hp",
            variantSecondary: "button_variantSecondary__lSxsR",
            variantTertiary: "button_variantTertiary__yzas_",
            variantDarkBlue: "button_variantDarkBlue__5iyI5",
            variantDanger: "button_variantDanger__lR03V",
            variantBlack: "button_variantBlack__CgHSk",
            variantGrey: "button_variantGrey__OLOxX",
            sizeSmall: "button_sizeSmall__POheY",
            sizeLarge: "button_sizeLarge__Va8YG",
            wrapper: "button_wrapper__NkcHZ",
            label: "button_label__kpJrA",
            icon: "button_icon__a2L5l",
            loadingIndicator: "button_loadingIndicator__vSyVg",
            spin: "button_spin__W4vHW",
            appear: "button_appear__lR_wN"
        }
    },
    60943: function(e) {
        e.exports = {
            buttons: "buttons_buttons__0B3SB"
        }
    },
    11564: function(e) {
        e.exports = {
            image: "styles_image__NoSwf",
            fitContainLarge: "styles_fitContainLarge__u8hMM",
            fitContainMedium: "styles_fitContainMedium__PzvdJ",
            fitContainSmall: "styles_fitContainSmall__gxMCI",
            fitContainFull: "styles_fitContainFull__b9xWi",
            fitCover: "styles_fitCover__sLtWg"
        }
    },
    35960: function(e) {
        e.exports = {
            wrapper: "styles_wrapper__8FGBW",
            fontSizeXSmall: "styles_fontSizeXSmall__mhSgH",
            fontSizeSmall: "styles_fontSizeSmall__F1V8j",
            fontSizeMedium: "styles_fontSizeMedium__V_p2O",
            fontSizeLarge: "styles_fontSizeLarge__In4g_",
            fontColorBlack: "styles_fontColorBlack__tteiq",
            fontColorWhite: "styles_fontColorWhite__POCGW",
            label: "styles_label__66OQc"
        }
    },
    11778: function(e) {
        e.exports = {
            circle: "styles_circle__QFYEk",
            innerCircle: "styles_innerCircle__Y_L_e",
            content: "styles_content__otIVG",
            annotation: "styles_annotation__pBXEI",
            variantFloating: "styles_variantFloating__Srm_N",
            variantFloatingCircular: "styles_variantFloatingCircular__SwU2T",
            variantRaised: "styles_variantRaised__C5ReH",
            colorDarkBlue: "styles_colorDarkBlue__A1mW1",
            colorWhite: "styles_colorWhite__Y640w",
            colorDarkGrey: "styles_colorDarkGrey__tjXN4",
            colorGreen: "styles_colorGreen__vvBa5",
            colorDarkGreen: "styles_colorDarkGreen__yx9E6",
            colorSolidDarkBlue: "styles_colorSolidDarkBlue__hYPX5",
            colorRed: "styles_colorRed__P_hkj",
            colorPurple: "styles_colorPurple__dErS5",
            colorDarkPurple: "styles_colorDarkPurple__798oP",
            colorYellow: "styles_colorYellow__IL548",
            colorTransparent: "styles_colorTransparent__2bG5I",
            sizeXSmall: "styles_sizeXSmall__WdSaY",
            sizeSmall: "styles_sizeSmall__12rrd",
            sizeMedium: "styles_sizeMedium__UsBXG",
            sizeLarge: "styles_sizeLarge__XUXWt",
            sizeXLarge: "styles_sizeXLarge___4C62",
            borderSizeFactorZero: "styles_borderSizeFactorZero__MEFpf",
            borderSizeFactorHalf: "styles_borderSizeFactorHalf__h3ATE",
            borderSizeFactorOne: "styles_borderSizeFactorOne__8iP_3",
            borderSizeFactorTwo: "styles_borderSizeFactorTwo__TBAZ4",
            borderColorGold: "styles_borderColorGold__mjHcO",
            borderColorSilver: "styles_borderColorSilver__ix_Jw",
            borderColorBronze: "styles_borderColorBronze__EFxvq",
            borderColorBeige: "styles_borderColorBeige__nMqBl",
            borderColorBlue: "styles_borderColorBlue__rmqSz",
            borderColorTransparentBeige: "styles_borderColorTransparentBeige__hQ0ZP",
            borderColorLightGrey: "styles_borderColorLightGrey__L32ZP",
            borderColorGreen: "styles_borderColorGreen__lloq_",
            borderColorRed: "styles_borderColorRed__NvJtJ",
            borderColorDarkPurple: "styles_borderColorDarkPurple__DvM_B",
            borderColorDarkGrey: "styles_borderColorDarkGrey__EcHkQ",
            borderColorTransparent: "styles_borderColorTransparent__CwSAk",
            borderColorBlack: "styles_borderColorBlack__f050C",
            overflowVisible: "styles_overflowVisible__MSdGK"
        }
    },
    52382: function(e) {
        e.exports = {
            confirmationDialog: "confirmation-dialog_confirmationDialog__inOcr",
            fullContent: "confirmation-dialog_fullContent__xJO8Y",
            content: "confirmation-dialog_content__cwdow",
            body: "confirmation-dialog_body__OyeEL",
            title: "confirmation-dialog_title__J_yn_",
            actions: "confirmation-dialog_actions__oWY2X",
            footer: "confirmation-dialog_footer__NYip_"
        }
    },
    44556: function(e) {
        e.exports = {
            wrapper: "countdown_wrapper__9hmfQ",
            animationWrapper: "countdown_animationWrapper__OBsFz",
            animation: "countdown_animation__G2elw"
        }
    },
    57883: function(e) {
        e.exports = {
            flash: "flash_flash__zXNGk",
            icon: "flash_icon__0tKj8",
            label: "flash_label__KdA6d",
            typeError: "flash_typeError__uB7At",
            typeInfo: "flash_typeInfo__NpA4k",
            typeWarning: "flash_typeWarning__8TBq3",
            variantInline: "flash_variantInline__dCrNX"
        }
    },
    99129: function(e) {
        e.exports = {
            image: "styles_image__8M_kp"
        }
    },
    65034: function(e) {
        e.exports = {
            sizeFull: "container_sizeFull__T__bh",
            sizeXLarge: "container_sizeXLarge__D7B3l",
            sizeLarge: "container_sizeLarge__QY371",
            sizeMedium: "container_sizeMedium__zNtDe",
            sizeSmall: "container_sizeSmall__zbBrD",
            sizeXSmall: "container_sizeXSmall__Kb1qQ",
            content: "container_content__H3tXS",
            overflowVisible: "container_overflowVisible__tXD2V"
        }
    },
    58028: function(e) {
        e.exports = {
            grid: "grid_grid__Hrqu6",
            columnsXSmall1: "grid_columnsXSmall1__FWlPm",
            columnsSmall1: "grid_columnsSmall1__GsgJe",
            columnsMedium1: "grid_columnsMedium1__tpK8r",
            columns1: "grid_columns1__kfBV1",
            columnsXSmall2: "grid_columnsXSmall2__xoSih",
            columnsSmall2: "grid_columnsSmall2___b9Kt",
            columnsMedium2: "grid_columnsMedium2__odpGN",
            columns2: "grid_columns2__fiLPJ",
            columnsXSmall3: "grid_columnsXSmall3__HYQbp",
            columnsSmall3: "grid_columnsSmall3__xY9lb",
            columnsMedium3: "grid_columnsMedium3__IYERm",
            columns3: "grid_columns3__LP6wX",
            columnsXSmall4: "grid_columnsXSmall4__Ay6sm",
            columnsSmall4: "grid_columnsSmall4__Q_AML",
            columnsMedium4: "grid_columnsMedium4__cut3l",
            columns4: "grid_columns4__xDMYd",
            columnsXSmall5: "grid_columnsXSmall5__csGma",
            columnsSmall5: "grid_columnsSmall5__myTw7",
            columnsMedium5: "grid_columnsMedium5__STd_S",
            columns5: "grid_columns5___O9U9",
            columnsXSmall6: "grid_columnsXSmall6__U39dU",
            columnsSmall6: "grid_columnsSmall6__SAGVI",
            columnsMedium6: "grid_columnsMedium6__bk6Ll",
            columns6: "grid_columns6__OMNct",
            columnsXSmall7: "grid_columnsXSmall7__vS_R9",
            columnsSmall7: "grid_columnsSmall7__gWRQU",
            columnsMedium7: "grid_columnsMedium7__rbmnK",
            columns7: "grid_columns7__gl6Ec",
            columnsXSmall8: "grid_columnsXSmall8__X_pXY",
            columnsSmall8: "grid_columnsSmall8__qfb0d",
            columnsMedium8: "grid_columnsMedium8__4cKsy",
            columns8: "grid_columns8__BKPww",
            columnsXSmall9: "grid_columnsXSmall9__bjmiz",
            columnsSmall9: "grid_columnsSmall9__ticrz",
            columnsMedium9: "grid_columnsMedium9__ORa9x",
            columns9: "grid_columns9__cKVZd",
            columnsXSmall10: "grid_columnsXSmall10__0uWRC",
            columnsSmall10: "grid_columnsSmall10__cG71_",
            columnsMedium10: "grid_columnsMedium10__qtpB0",
            columns10: "grid_columns10__guFiO",
            gapSizeXLarge: "grid_gapSizeXLarge__Xy3oq",
            gapSizeLarge: "grid_gapSizeLarge__DIJSo",
            gapSizeSmall: "grid_gapSizeSmall__PXyb2",
            justifyCenter: "grid_justifyCenter__vEu_Z"
        }
    },
    16027: function(e) {
        e.exports = {
            rectangle: "styles_rectangle___6gqv"
        }
    },
    96150: function(e) {
        e.exports = {
            root: "styles_root__eoNIJ",
            variantPurple: "styles_variantPurple__puakw",
            variantTurquoise: "styles_variantTurquoise__vz0ex",
            variantFlatPurple: "styles_variantFlatPurple__iTRWw",
            variantLightPurple: "styles_variantLightPurple__Xboik",
            variantDarkPurple: "styles_variantDarkPurple__4p8TR",
            variantTransparentDarkPurple: "styles_variantTransparentDarkPurple__pOi5A",
            variantBlackTransparent: "styles_variantBlackTransparent___3MrK",
            variantWhiteTransparent: "styles_variantWhiteTransparent__20ADs",
            variantGrey: "styles_variantGrey__nmqpz",
            variantYellow: "styles_variantYellow__U7GL_",
            variantRed: "styles_variantRed__XYLmY",
            variantWhite: "styles_variantWhite__BHUvD",
            withShadow: "styles_withShadow__dNIJm",
            roundnessSmall: "styles_roundnessSmall__ZbRvs",
            roundnessLarge: "styles_roundnessLarge__aznIn",
            start: "styles_start__u_cL2",
            end: "styles_end__euu3r",
            right: "styles_right__hZg0u",
            left: "styles_left__an7Bw"
        }
    },
    75973: function(e) {
        e.exports = {
            root: "fullscreen-spinner_root__IwRRr",
            backgroundSolid: "fullscreen-spinner_backgroundSolid__kZ0BT",
            sizeSmall: "fullscreen-spinner_sizeSmall__H2D_U",
            sizeXSmall: "fullscreen-spinner_sizeXSmall__SxwRv",
            foregroundDark: "fullscreen-spinner_foregroundDark__O79g7",
            square: "fullscreen-spinner_square__mwMfl",
            circle: "fullscreen-spinner_circle__k_HHt",
            spin: "fullscreen-spinner_spin__rcEr6",
            globeImageContainer: "fullscreen-spinner_globeImageContainer__pgT3S",
            globeImage: "fullscreen-spinner_globeImage__dQnXs",
            label: "fullscreen-spinner_label__oFLtU"
        }
    },
    69020: function(e) {
        e.exports = {
            toggle: "toggle_toggle__hwnyw"
        }
    },
    1068: function(e) {
        e.exports = {
            sizeLarge: "body-text_sizeLarge__aqEl_",
            sizeMedium: "body-text_sizeMedium__AQoSR",
            sizeSmall: "body-text_sizeSmall__hhbe1",
            sizeXSmall: "body-text_sizeXSmall__rwJFf"
        }
    },
    97812: function(e) {
        e.exports = {
            heading: "headline_heading__c6HiU",
            sizeDisplay: "headline_sizeDisplay__YN51e",
            sizeXLarge: "headline_sizeXLarge__XmpZn",
            sizeLarge: "headline_sizeLarge__DqYNn",
            sizeMedium: "headline_sizeMedium__Fco5n",
            sizeSmall: "headline_sizeSmall__51whs",
            sizeXSmall: "headline_sizeXSmall__f9y69",
            variantYellow: "headline_variantYellow__N_sDa"
        }
    },
    77746: function(e) {
        e.exports = {
            sizeLarge: "label_sizeLarge__Va1xu",
            sizeMedium: "label_sizeMedium__QzIL1",
            sizeSmall: "label_sizeSmall__nPGP5",
            sizeXSmall: "label_sizeXSmall__mFnrR",
            sizeXXSmall: "label_sizeXXSmall__mN5ZF",
            italic: "label_italic__CuofN",
            variantYellow: "label_variantYellow__yLh_Q"
        }
    },
    12368: function(e) {
        e.exports = {
            sizeMedium: "title_sizeMedium__qQF8o",
            sizeSmall: "title_sizeSmall__wyOnH"
        }
    },
    31853: function(e) {
        e.exports = {
            root: "user-nick_root__DUfvc",
            avatar: "user-nick_avatar__lW3e2",
            nickWrapper: "user-nick_nickWrapper__8Tnk4",
            nick: "user-nick_nick__y4VIt",
            verifiedWrapper: "user-nick_verifiedWrapper__yocOV",
            verified: "user-nick_verified__WdndT"
        }
    },
    18946: function(e) {
        e.exports = {
            loading: "page-loading_loading__Ty_Li",
            appear: "page-loading_appear__Q1rFh",
            label: "page-loading_label__fHBiW"
        }
    },
    1873: function(e) {
        e.exports = {
            layout: "classic_layout__SWwJr",
            noPadding: "classic_noPadding__Z7g34",
            darkColorScheme: "classic_darkColorScheme__Au0zr",
            header: "classic_header__g_G4W",
            main: "classic_main__JenaD",
            sidebar: "classic_sidebar__44CQP",
            footer: "classic_footer__gSBmm",
            content: "classic_content__HuuNS",
            hasSubmenu: "classic_hasSubmenu__LfnDs"
        }
    },
    57523: function(e) {
        e.exports = {
            root: "version3-in-game_root__P2ydF",
            content: "version3-in-game_content__9t8Xc",
            layout: "version3-in-game_layout__Hi_Iw"
        }
    },
    18118: function(e) {
        e.exports = {
            layout: "version3_layout__yhcz4",
            noSideTray: "version3_noSideTray__RuZF3",
            sideBar: "version3_sideBar__vqOva",
            content: "version3_content__JY7bX",
            noPadding: "version3_noPadding__oP_Nu",
            main: "version3_main__xNkED",
            sidebar: "version3_sidebar__WE547"
        }
    },
    42579: function(e) {
        e.exports = {
            wrapper: "background_wrapper__6dvrI",
            background: "background_background__VD7Hb",
            backgroundProfile: "background_backgroundProfile__M97Zn",
            backgroundCompetitive: "background_backgroundCompetitive__GTgXA",
            backgroundGroupEvents: "background_backgroundGroupEvents__oYAE1",
            backgroundCareer: "background_backgroundCareer___wI_r",
            backgroundHome: "background_backgroundHome__obpvR",
            backgroundClassic: "background_backgroundClassic__VqEE0",
            backgroundPlayWithFriends: "background_backgroundPlayWithFriends__nkB4i"
        }
    },
    55604: function(e) {
        e.exports = {
            footer: "footer_footer__NmtmJ",
            footerContent: "footer_footerContent__Uvqhp",
            links: "footer_links__OvdUf",
            link: "footer_link__WeWYw",
            social: "footer_social__uOPzN"
        }
    },
    72837: function(e) {
        e.exports = {
            hamburger: "hamburger_hamburger__zbUPC",
            bars: "hamburger_bars__R_0PZ",
            bar: "hamburger_bar__8EkDJ",
            active: "hamburger_active__K0Qe9",
            activityIndicator: "hamburger_activityIndicator__FJdkq"
        }
    },
    36380: function(e) {
        e.exports = {
            header: "header_header__BxMhs",
            logo: "header_logo__5cSig",
            logoImage: "header_logoImage__Fcmkm",
            largeLogoImage: "header_largeLogoImage__7X4iK",
            smallLogoImage: "header_smallLogoImage__VaM_p",
            context: "header_context__hzGGK",
            item: "header_item__PyYsU",
            search: "header_search__4yVbF",
            hamburgerContainer: "header_hamburgerContainer__CVsTZ",
            proButton: "header_proButton__nSQ2V",
            profile: "header_profile__2Stwe",
            alreadyHaveAnAccount: "header_alreadyHaveAnAccount__qp_5F",
            ltxp: "header_ltxp__lP9nW",
            level: "header_level__2dWqx",
            title: "header_title__kHqAb",
            xpProgress: "header_xpProgress__GRChu"
        }
    },
    29646: function(e) {
        e.exports = {
            modal: "language-selector_modal__snAlz",
            list: "language-selector_list__PVYKX",
            icon: "language-selector_icon__oLqQe",
            button: "language-selector_button__S1yYE",
            listItem: "language-selector_listItem__UzpFk",
            selectedListItem: "language-selector_selectedListItem__O2Ddj"
        }
    },
    44871: function(e) {
        e.exports = {
            menu: "menu_menu__r1oFY",
            tabList: "menu_tabList__OhfO3",
            menuItems: "menu_menuItems__MENIh",
            menuItemLabel: "menu_menuItemLabel__MQkhr",
            selected: "menu_selected__TMNDd",
            hamburger: "menu_hamburger__D5yYo",
            profile: "menu_profile__c1ezn",
            subMenu: "menu_subMenu__gIvIc",
            tabPanelContent: "menu_tabPanelContent__M4JDu",
            animateVisibility: "menu_animateVisibility__UheVq",
            menuItem: "menu_menuItem__Cn2wB",
            subMenuContent: "menu_subMenuContent__Xnam9",
            isMobileMenuOpen: "menu_isMobileMenuOpen__CWxFI",
            fixedHamburger: "menu_fixedHamburger__yyjrC"
        }
    },
    12032: function(e) {
        e.exports = {
            noNotifications: "notification-list_noNotifications__b2j_9",
            noNotificationsIcon: "notification-list_noNotificationsIcon__ueAkx",
            notifications: "notification-list_notifications__Q9pfv",
            notification: "notification-list_notification__TBJOh",
            notificationIcon: "notification-list_notificationIcon__2Rwcr",
            notificationText: "notification-list_notificationText__A6Zx3",
            notificationActions: "notification-list_notificationActions___Jtvd",
            notificationDescription: "notification-list_notificationDescription__0HDOr",
            notificationTime: "notification-list_notificationTime__BtzVj",
            buttonIcon: "notification-list_buttonIcon__ns9Y2"
        }
    },
    29141: function(e) {
        e.exports = {
            root: "profile_root__r_kQu",
            profile: "profile_profile__YnjW8",
            avatar: "profile_avatar__3Cs8U",
            progression: "profile_progression__PbHaC",
            level: "profile_level__CzEHo",
            title: "profile_title__v69IT",
            badgeTitle: "profile_badgeTitle__NyqMq",
            xpProgress: "profile_xpProgress__Dutms",
            showDropdown: "profile_showDropdown__vQPU_",
            dropdown: "profile_dropdown__J0pSB",
            dropdownBottom: "profile_dropdownBottom__oGpHw",
            medalsAndTrophies: "profile_medalsAndTrophies__ImNfG",
            medals: "profile_medals__ScJQQ",
            trophies: "profile_trophies__NZVuL",
            trophy: "profile_trophy__9v_1r",
            amount: "profile_amount__Budib",
            badgesSection: "profile_badgesSection__9s4c2",
            badges: "profile_badges__DjNEM",
            badge: "profile_badge__09xB3",
            hideProgressionOnSmallScreens: "profile_hideProgressionOnSmallScreens__TZg4F"
        }
    },
    95650: function(e) {
        e.exports = {
            wrapper: "side-tray_wrapper__gJ2AC",
            header: "side-tray_header__A0_0U",
            notificationIconWrapper: "side-tray_notificationIconWrapper__Bgn3w",
            body: "side-tray_body__Uy1NP"
        }
    },
    96514: function(e) {
        e.exports = {
            submenuAnchorList: "sub-menu-anchor_submenuAnchorList__ODg9K",
            solid: "sub-menu-anchor_solid__hXlKA",
            item: "sub-menu-anchor_item__Jtri5",
            icon: "sub-menu-anchor_icon__HAwN_",
            activeItem: "sub-menu-anchor_activeItem__nwhLL",
            label: "sub-menu-anchor_label__tF9mU",
            activeLabel: "sub-menu-anchor_activeLabel__mbg4K"
        }
    },
    58679: function(e) {
        e.exports = {
            badge: "sub-menus_badge__bUgfX",
            levels: "sub-menus_levels__B0UMz",
            level: "sub-menus_level__dI9fC",
            mediumLevel: "sub-menus_mediumLevel__U_nSW",
            levelIcon: "sub-menus_levelIcon__BMQga",
            levelCount: "sub-menus_levelCount__recQi"
        }
    },
    61073: function(e) {
        e.exports = {
            tabList: "tabs_tabList__r4zrL",
            label: "tabs_label__aLDUQ",
            tab: "tabs_tab__pTeTw",
            selected: "tabs_selected___Cu2E",
            tabSelected1: "tabs_tabSelected1__wR4Yq",
            content: "tabs_content__70y2i",
            tabSelected2: "tabs_tabSelected2__328aj",
            tabSelected3: "tabs_tabSelected3__HScNi",
            activityIndicator: "tabs_activityIndicator__A3aFE",
            tabs: "tabs_tabs__29nZq",
            variantSmallScreen: "tabs_variantSmallScreen__5MWh_"
        }
    },
    28142: function(e) {
        e.exports = {
            medals: "medals_medals__ThC_j",
            sizeLarge: "medals_sizeLarge__WpFao",
            sizeMedium: "medals_sizeMedium__iet1M",
            sizeSmall: "medals_sizeSmall__1rkZB"
        }
    },
    98879: function(e) {
        e.exports = {
            backdrop: "cookie-consent-popup_backdrop__PbCqL",
            fadeInBackdrop: "cookie-consent-popup_fadeInBackdrop__jmzhh",
            container: "cookie-consent-popup_container__8DIby",
            fadeInContainer: "cookie-consent-popup_fadeInContainer__otEgp",
            image: "cookie-consent-popup_image__B774c",
            divider: "cookie-consent-popup_divider__WYFgQ",
            innerContainer: "cookie-consent-popup_innerContainer__MUEVH",
            headline: "cookie-consent-popup_headline__OaNCu",
            body: "cookie-consent-popup_body__2_Ym1",
            selection: "cookie-consent-popup_selection__RbB9J",
            selectionHeadlineContainer: "cookie-consent-popup_selectionHeadlineContainer__w_mJX",
            selectionHeadline: "cookie-consent-popup_selectionHeadline__QenQJ",
            selectionLine: "cookie-consent-popup_selectionLine__aev7V",
            selectionContainer: "cookie-consent-popup_selectionContainer__F1uIm",
            description: "cookie-consent-popup_description__SKQeG",
            buttons: "cookie-consent-popup_buttons__PQhuO"
        }
    },
    96859: function(e) {
        e.exports = {
            root: "ticket-bar_root__H8RcX",
            meta: "ticket-bar_meta__yIMWz",
            headline: "ticket-bar_headline__lVeaW",
            body: "ticket-bar_body__iJVUC",
            stopwatch: "ticket-bar_stopwatch__WnUe8",
            stopwatchButton: "ticket-bar_stopwatchButton__6luXv",
            stopwatchImage: "ticket-bar_stopwatchImage__5axy6",
            filler: "ticket-bar_filler__WBL_X",
            content: "ticket-bar_content__Wmey1"
        }
    },
    61085: function(e) {
        e.exports = {
            errorPage: "_error_errorPage__5Obe2",
            heading: "_error_heading__nM7jJ",
            "body-1": "_error_body-1__52KN2",
            "body-2": "_error_body-2__5X7V9",
            "body-3": "_error_body-3__pC2dp",
            "body-4": "_error_body-4__G38KT",
            title: "_error_title__oLWAK",
            illustration: "_error_illustration__N9KjT",
            cta: "_error_cta__Gzu_C",
            lightErrorPage: "_error_lightErrorPage___qPI5",
            card: "_error_card__PM_ck"
        }
    },
    50363: function(e) {
        e.exports = "/_next/static/images/education-918722f7e97b2b39fa390278512d5235.svg"
    },
    84431: function(e) {
        e.exports = "/_next/static/images/team-border-157efbd7f371ddeb927fbb5258896c7f.png"
    },
    97164: function(e) {
        e.exports = "/_next/static/images/error-cb2f178433caad8bb7e7ed16b65cb414.svg"
    },
    66454: function(e) {
        e.exports = "/_next/static/images/info-4ccf216d5d7cdc6ec12aca8be053d1e2.svg"
    },
    386: function(e) {
        e.exports = "/_next/static/images/success-f050d3fa276dad3e9711864b892fed39.svg"
    },
    52497: function(e) {
        e.exports = "/_next/static/images/warning-c1b7e11139d7587b2a5d1d1bee727cfb.svg"
    },
    82257: function(e) {
        e.exports = "/_next/static/images/circle-dark@2x-b942ca8629c0dea3a7400253715a82c9.png"
    },
    25104: function(e) {
        e.exports = "/_next/static/images/circle-light@2x-ead8bc8d25b56d83c4d94d881c3bcee7.png"
    },
    85528: function(e) {
        e.exports = "/_next/static/images/globe-dark-13bd41b76c00df339d7ec2d68c4e5c13.svg"
    },
    94185: function(e) {
        e.exports = "/_next/static/images/globe-light-184fa30055fab7f803455a6e83df1291.svg"
    },
    27347: function(e) {
        e.exports = "/_next/static/images/verified-badge-566f0efd4d90928c6e044cbe588456dc.svg"
    },
    69240: function(e) {
        e.exports = "/_next/static/images/check-0ef974bad3e8fc0e22998a26facbe1db.svg"
    },
    45999: function(e) {
        e.exports = "/_next/static/images/close-1169c4a14affbc7a1cbc881adcb36d9b.svg"
    },
    25471: function(e) {
        e.exports = "/_next/static/images/notifications-disabled-336166e0957b4d905d37e6e8366bec54.svg"
    },
    92383: function(e) {
        e.exports = "/_next/static/images/trophy-54c9ea328982df111a00fa5c01851fbb.png"
    },
    91668: function(e) {
        e.exports = "/_next/static/images/translation-18ba3464f100354c29dd9c2c6bdd0de9.svg"
    },
    51919: function(e) {
        e.exports = "/_next/static/images/notifications-disabled-336166e0957b4d905d37e6e8366bec54.svg"
    },
    12146: function(e) {
        e.exports = "/_next/static/images/notifications-enabled-6e29947e1917489fa4a48e6ea76320de.svg"
    },
    90612: function(e) {
        e.exports = "/_next/static/images/compass-a526b93f27b9ffeeca3ac65a9a7bdb5b.png"
    },
    50595: function(e) {
        e.exports = "/_next/static/images/medals-large-f9f3614625c6fa1397a4aae37d211116.png"
    },
    31928: function(e) {
        e.exports = "/_next/static/images/stopwatch-green-117bf5891a9fb89afb33d1ab0c1c5a92.avif"
    },
    26967: function(e) {
        e.exports = "/_next/static/images/stopwatch-green-2e27320085422df7d2496ec56fd80fc6.png"
    },
    20670: function(e) {
        e.exports = "/_next/static/images/stopwatch-green-16e5910a5a8768e747aa37723a0f21c3.webp"
    },
    84223: function(e) {
        e.exports = "/_next/static/images/stopwatch-red-3783abba92e11f1370cb620e4f56daec.avif"
    },
    9161: function(e) {
        e.exports = "/_next/static/images/stopwatch-red-96b1c60bb4954fa3d16f3fce376392b1.png"
    },
    63304: function(e) {
        e.exports = "/_next/static/images/stopwatch-red-c8778e2afd9414487df5c5099e9521c0.webp"
    },
    500: function(e) {
        e.exports = "/_next/static/images/favicon-aae84a1ec836612840470a029b5c29d6.png"
    },
    78918: function(e) {
        e.exports = "/_next/static/images/geoguessr-114-ec472c4815675a5aca39944d79648852.png"
    },
    45249: function(e) {
        e.exports = "/_next/static/images/geoguessr-57-e3554d29cf9a410853ee28063965a2ba.png"
    },
    50891: function(e) {
        e.exports = "/_next/static/images/geoguessr-72-1e6853f1053b9c0f51b29d43615ce7e7.png"
    },
    14318: function(e) {
        e.exports = "/_next/static/images/pin-outlined-51d207838a93226e3df9c01de40939ad.svg"
    },
    97032: function(e) {
        e.exports = "/_next/static/images/bronze-0328d5f575d9f291ea2c7eebaf425a92.svg"
    },
    75648: function(e) {
        e.exports = "/_next/static/images/gold-873f4625d5332a41102bf2ee1094dcda.svg"
    },
    5216: function(e) {
        e.exports = "/_next/static/images/none-e4ff9afed3db081c44080e02588d9f64.svg"
    },
    64540: function(e) {
        e.exports = "/_next/static/images/silver-834498a23aecc5cecff60dd952ac5780.svg"
    },
    11972: function(e) {
        e.exports = "/_next/static/images/logo-small-8d0cb27dbaf4721dd9cf52b4a3649a12.svg"
    },
    90955: function(e) {
        e.exports = "/_next/static/images/logo-dd3c3286e6d14f72653800dbdf5340a0.svg"
    },
    55338: function(e) {
        e.exports = "/_next/static/images/default-231f6f91e41050bfcac84aa3009be3fe.png"
    },
    62580: function(e) {
        e.exports = "/_next/static/images/pin-7c4fd5036b113d8a16a9c2316243b0e1.png"
    },
    85899: function(e) {
        e.exports = "/_next/static/images/discord-b09e05aac64ee71e0ffd9052b9e4d2a6.svg"
    },
    14986: function(e) {
        e.exports = "/_next/static/images/facebook-07516ced64b63b6f7b04c58f39a3a432.svg"
    },
    42471: function(e) {
        e.exports = "/_next/static/images/instagram-5eaca8c522a868a153cbc06a9e31e205.svg"
    },
    74064: function(e) {
        e.exports = "/_next/static/images/reddit-59dcaeb53354667866bf5e15428d4d26.svg"
    },
    55144: function(e) {
        e.exports = "/_next/static/images/twitch-c10a03a006f800119170f90796f59e8c.svg"
    },
    68553: function(e) {
        e.exports = "/_next/static/images/twitter-5f141422accd13a07389c29cba4bde91.svg"
    },
    15288: function(e, t, n) {
        var r = {
            "./de_DE/all.json": [74457, 74457],
            "./de_DE/api-badge-hint.json": [62147, 62147],
            "./de_DE/api-badge-name.json": [12007, 12007],
            "./de_DE/api-email.json": [97323, 97323],
            "./de_DE/api-map-description.json": [787, 787],
            "./de_DE/api-map-name.json": [96242, 96242],
            "./de_DE/api-subscription-description.json": [61949, 61949],
            "./de_DE/api-subscription-plan-name.json": [62322, 62322],
            "./de_DE/api-subscription-plan-title.json": [13588, 13588],
            "./de_DE/auth.json": [91005, 91005],
            "./de_DE/br.json": [54793, 54793],
            "./de_DE/campaign.json": [93855, 93855],
            "./de_DE/career.json": [22088, 22088],
            "./de_DE/challenge.json": [26412, 26412],
            "./de_DE/city-streaks.json": [10531, 10531],
            "./de_DE/components.json": [20669, 20669],
            "./de_DE/country-streak.json": [33064, 33064],
            "./de_DE/country.json": [70563, 70563],
            "./de_DE/daily-challenge.json": [28549, 28549],
            "./de_DE/duels.json": [11154, 11154],
            "./de_DE/education.json": [94068, 94068],
            "./de_DE/explorer.json": [12999, 12999],
            "./de_DE/faq.json": [89901, 89901],
            "./de_DE/free.json": [61665, 61665],
            "./de_DE/friends.json": [45263, 45263],
            "./de_DE/game.json": [18330, 18330],
            "./de_DE/gift-card.json": [91396, 91396],
            "./de_DE/infinity.json": [51409, 51409],
            "./de_DE/layout.json": [29998, 29998],
            "./de_DE/leagues.json": [34311, 34311],
            "./de_DE/lobby.json": [70509, 70509],
            "./de_DE/map-maker.json": [34291, 34291],
            "./de_DE/maps.json": [24028, 24028],
            "./de_DE/privacy.json": [12688, 12688],
            "./de_DE/pro.json": [97657, 97657],
            "./de_DE/profile.json": [54298, 54298],
            "./de_DE/results.json": [29172, 29172],
            "./de_DE/search.json": [1944, 1944],
            "./de_DE/start.json": [94591, 94591],
            "./de_DE/startpage.json": [99026, 99026],
            "./de_DE/streak.json": [10303, 10303],
            "./de_DE/streams.json": [26738, 26738],
            "./de_DE/support.json": [34801, 34801],
            "./de_DE/tutorial.json": [56029, 56029],
            "./de_DE/unsubscribe.json": [9676, 9676],
            "./de_DE/us-state-streak.json": [23155, 23155],
            "./de_DE/us.json": [83011, 83011],
            "./de_DE/user.json": [20009, 38228],
            "./en_US/all.json": [2920, 2920],
            "./en_US/api-badge-hint.json": [79617, 79617],
            "./en_US/api-badge-name.json": [90304, 90304],
            "./en_US/api-email.json": [72694, 72694],
            "./en_US/api-map-description.json": [18606, 18606],
            "./en_US/api-map-name.json": [86367, 86367],
            "./en_US/api-subscription-description.json": [59603, 59603],
            "./en_US/api-subscription-plan-name.json": [81924, 81924],
            "./en_US/api-subscription-plan-title.json": [28372, 28372],
            "./en_US/auth.json": [42735, 42735],
            "./en_US/br.json": [86053, 86053],
            "./en_US/campaign.json": [42584, 42584],
            "./en_US/career.json": [21296, 21296],
            "./en_US/challenge.json": [81091, 81091],
            "./en_US/city-streaks.json": [31726, 31726],
            "./en_US/components.json": [79427, 79427],
            "./en_US/country-streak.json": [31290, 31290],
            "./en_US/country.json": [17654, 17654],
            "./en_US/daily-challenge.json": [82677, 82677],
            "./en_US/duels.json": [43812, 43812],
            "./en_US/education.json": [91482, 91482],
            "./en_US/explorer.json": [70733, 70733],
            "./en_US/faq.json": [82191, 82191],
            "./en_US/free.json": [68153, 68153],
            "./en_US/friends.json": [99538, 99538],
            "./en_US/game.json": [6394, 6394],
            "./en_US/gift-card.json": [10659, 10659],
            "./en_US/infinity.json": [76655, 76655],
            "./en_US/layout.json": [67753, 67753],
            "./en_US/leagues.json": [27390, 27390],
            "./en_US/lobby.json": [40247, 25825],
            "./en_US/map-maker.json": [25305, 25305],
            "./en_US/maps.json": [20003, 20003],
            "./en_US/privacy.json": [96701, 96701],
            "./en_US/pro.json": [49091, 49091],
            "./en_US/profile.json": [57103, 57103],
            "./en_US/results.json": [26522, 26522],
            "./en_US/search.json": [32161, 32161],
            "./en_US/start.json": [73918, 73918],
            "./en_US/startpage.json": [64906, 64906],
            "./en_US/streak.json": [92004, 92004],
            "./en_US/streams.json": [68010, 68010],
            "./en_US/support.json": [12214, 12214],
            "./en_US/tutorial.json": [31524, 31524],
            "./en_US/unsubscribe.json": [6587, 6587],
            "./en_US/us-state-streak.json": [83995, 83995],
            "./en_US/us.json": [13123, 13123],
            "./en_US/user.json": [21122, 21122],
            "./es_ES/all.json": [38826, 38826],
            "./es_ES/api-badge-hint.json": [22320, 22320],
            "./es_ES/api-badge-name.json": [68911, 68911],
            "./es_ES/api-email.json": [10326, 10326],
            "./es_ES/api-map-description.json": [67542, 67542],
            "./es_ES/api-map-name.json": [96442, 96442],
            "./es_ES/api-subscription-description.json": [31990, 31990],
            "./es_ES/api-subscription-plan-name.json": [34324, 34324],
            "./es_ES/api-subscription-plan-title.json": [10323, 10323],
            "./es_ES/auth.json": [50861, 50861],
            "./es_ES/br.json": [93072, 93072],
            "./es_ES/campaign.json": [22939, 22939],
            "./es_ES/career.json": [73658, 73658],
            "./es_ES/challenge.json": [82348, 82348],
            "./es_ES/city-streaks.json": [46806, 46806],
            "./es_ES/components.json": [34176, 34176],
            "./es_ES/country-streak.json": [5027, 5027],
            "./es_ES/country.json": [24644, 24644],
            "./es_ES/daily-challenge.json": [70402, 70402],
            "./es_ES/duels.json": [21622, 21622],
            "./es_ES/education.json": [64543, 64543],
            "./es_ES/explorer.json": [41320, 41320],
            "./es_ES/faq.json": [79481, 79481],
            "./es_ES/free.json": [70006, 70006],
            "./es_ES/friends.json": [64363, 64363],
            "./es_ES/game.json": [8739, 8739],
            "./es_ES/gift-card.json": [23581, 23581],
            "./es_ES/infinity.json": [70828, 70828],
            "./es_ES/layout.json": [48280, 48280],
            "./es_ES/leagues.json": [56646, 56646],
            "./es_ES/lobby.json": [34998, 34998],
            "./es_ES/map-maker.json": [19695, 19695],
            "./es_ES/maps.json": [78895, 78895],
            "./es_ES/privacy.json": [6900, 6900],
            "./es_ES/pro.json": [70252, 70252],
            "./es_ES/profile.json": [6477, 6477],
            "./es_ES/results.json": [65611, 65611],
            "./es_ES/search.json": [84764, 84764],
            "./es_ES/start.json": [8160, 8160],
            "./es_ES/startpage.json": [16856, 16856],
            "./es_ES/streak.json": [41434, 41434],
            "./es_ES/streams.json": [63057, 63057],
            "./es_ES/support.json": [42100, 42100],
            "./es_ES/tutorial.json": [43085, 43085],
            "./es_ES/unsubscribe.json": [33255, 33255],
            "./es_ES/us-state-streak.json": [22829, 22829],
            "./es_ES/us.json": [96914, 96914],
            "./es_ES/user.json": [23066, 23066],
            "./fr_FR/all.json": [75279, 75279],
            "./fr_FR/api-badge-hint.json": [71680, 71680],
            "./fr_FR/api-badge-name.json": [34866, 34866],
            "./fr_FR/api-email.json": [82915, 82915],
            "./fr_FR/api-map-description.json": [60570, 60570],
            "./fr_FR/api-map-name.json": [68474, 68474],
            "./fr_FR/api-subscription-description.json": [48407, 48407],
            "./fr_FR/api-subscription-plan-name.json": [31171, 31171],
            "./fr_FR/api-subscription-plan-title.json": [56131, 56131],
            "./fr_FR/auth.json": [94208, 94208],
            "./fr_FR/br.json": [50432, 50432],
            "./fr_FR/campaign.json": [4218, 4218],
            "./fr_FR/career.json": [30985, 30985],
            "./fr_FR/challenge.json": [34857, 34857],
            "./fr_FR/city-streaks.json": [46964, 46964],
            "./fr_FR/components.json": [66878, 66878],
            "./fr_FR/country-streak.json": [76778, 76778],
            "./fr_FR/country.json": [22309, 22309],
            "./fr_FR/daily-challenge.json": [34512, 34512],
            "./fr_FR/duels.json": [4478, 4478],
            "./fr_FR/education.json": [83440, 83440],
            "./fr_FR/explorer.json": [53949, 53949],
            "./fr_FR/faq.json": [22997, 22997],
            "./fr_FR/free.json": [98633, 98633],
            "./fr_FR/friends.json": [8161, 8161],
            "./fr_FR/game.json": [37939, 37939],
            "./fr_FR/gift-card.json": [92713, 92713],
            "./fr_FR/infinity.json": [75777, 75777],
            "./fr_FR/layout.json": [68233, 68233],
            "./fr_FR/leagues.json": [29973, 29973],
            "./fr_FR/lobby.json": [78693, 78693],
            "./fr_FR/map-maker.json": [56742, 56742],
            "./fr_FR/maps.json": [1749, 1749],
            "./fr_FR/privacy.json": [43139, 43139],
            "./fr_FR/pro.json": [25828, 25828],
            "./fr_FR/profile.json": [20681, 20681],
            "./fr_FR/results.json": [3318, 3318],
            "./fr_FR/search.json": [94973, 94973],
            "./fr_FR/start.json": [21291, 21291],
            "./fr_FR/startpage.json": [9516, 9516],
            "./fr_FR/streak.json": [54453, 54453],
            "./fr_FR/streams.json": [90062, 90062],
            "./fr_FR/support.json": [68301, 68301],
            "./fr_FR/tutorial.json": [55879, 55879],
            "./fr_FR/unsubscribe.json": [34824, 34824],
            "./fr_FR/us-state-streak.json": [80756, 80756],
            "./fr_FR/us.json": [80018, 80018],
            "./fr_FR/user.json": [52296, 52296],
            "./it_IT/all.json": [5474, 5474],
            "./it_IT/api-badge-hint.json": [73667, 12881],
            "./it_IT/api-badge-name.json": [1655, 1655],
            "./it_IT/api-email.json": [31012, 31012],
            "./it_IT/api-map-description.json": [48806, 48806],
            "./it_IT/api-map-name.json": [71186, 71186],
            "./it_IT/api-subscription-description.json": [45064, 45064],
            "./it_IT/api-subscription-plan-name.json": [19967, 19967],
            "./it_IT/api-subscription-plan-title.json": [37536, 37536],
            "./it_IT/auth.json": [66479, 66479],
            "./it_IT/br.json": [21215, 21215],
            "./it_IT/campaign.json": [78462, 78462],
            "./it_IT/career.json": [85115, 85115],
            "./it_IT/challenge.json": [21497, 21497],
            "./it_IT/city-streaks.json": [15780, 15780],
            "./it_IT/components.json": [65801, 65801],
            "./it_IT/country-streak.json": [14715, 14715],
            "./it_IT/country.json": [51508, 51508],
            "./it_IT/daily-challenge.json": [62524, 62524],
            "./it_IT/duels.json": [28003, 28003],
            "./it_IT/education.json": [36494, 36494],
            "./it_IT/explorer.json": [82072, 82072],
            "./it_IT/faq.json": [38824, 38824],
            "./it_IT/free.json": [2929, 2929],
            "./it_IT/friends.json": [56729, 56729],
            "./it_IT/game.json": [16336, 16336],
            "./it_IT/gift-card.json": [14516, 14516],
            "./it_IT/infinity.json": [11731, 11731],
            "./it_IT/layout.json": [48003, 48003],
            "./it_IT/leagues.json": [32338, 32338],
            "./it_IT/lobby.json": [37170, 37170],
            "./it_IT/map-maker.json": [11037, 11037],
            "./it_IT/maps.json": [31507, 31507],
            "./it_IT/privacy.json": [96166, 96166],
            "./it_IT/pro.json": [82526, 82526],
            "./it_IT/profile.json": [68321, 68321],
            "./it_IT/results.json": [4123, 4123],
            "./it_IT/search.json": [92395, 92395],
            "./it_IT/start.json": [99175, 99175],
            "./it_IT/startpage.json": [53176, 53176],
            "./it_IT/streak.json": [14402, 14402],
            "./it_IT/streams.json": [10267, 10267],
            "./it_IT/support.json": [21295, 21295],
            "./it_IT/tutorial.json": [12026, 12026],
            "./it_IT/unsubscribe.json": [19508, 19508],
            "./it_IT/us-state-streak.json": [81327, 81327],
            "./it_IT/us.json": [87085, 87085],
            "./it_IT/user.json": [5186, 5186],
            "./nl_NL/all.json": [51339, 51339],
            "./nl_NL/api-badge-hint.json": [57352, 57352],
            "./nl_NL/api-badge-name.json": [38452, 38452],
            "./nl_NL/api-email.json": [94001, 94001],
            "./nl_NL/api-map-description.json": [88282, 88282],
            "./nl_NL/api-map-name.json": [70877, 70877],
            "./nl_NL/api-subscription-description.json": [49754, 49754],
            "./nl_NL/api-subscription-plan-name.json": [79480, 79480],
            "./nl_NL/api-subscription-plan-title.json": [77201, 77201],
            "./nl_NL/auth.json": [10235, 10235],
            "./nl_NL/br.json": [89760, 89760],
            "./nl_NL/campaign.json": [55323, 55323],
            "./nl_NL/career.json": [33200, 33200],
            "./nl_NL/challenge.json": [12387, 12387],
            "./nl_NL/city-streaks.json": [45899, 45899],
            "./nl_NL/components.json": [6489, 6489],
            "./nl_NL/country-streak.json": [62773, 62773],
            "./nl_NL/country.json": [10696, 10696],
            "./nl_NL/daily-challenge.json": [77254, 77254],
            "./nl_NL/duels.json": [92109, 92109],
            "./nl_NL/education.json": [53191, 53191],
            "./nl_NL/explorer.json": [63918, 63918],
            "./nl_NL/faq.json": [72549, 72549],
            "./nl_NL/free.json": [44026, 44026],
            "./nl_NL/friends.json": [42067, 42067],
            "./nl_NL/game.json": [672, 672],
            "./nl_NL/gift-card.json": [81119, 81119],
            "./nl_NL/infinity.json": [10751, 10751],
            "./nl_NL/layout.json": [45616, 45616],
            "./nl_NL/leagues.json": [45984, 45984],
            "./nl_NL/lobby.json": [98878, 98878],
            "./nl_NL/map-maker.json": [70532, 70532],
            "./nl_NL/maps.json": [95923, 95923],
            "./nl_NL/privacy.json": [28129, 28129],
            "./nl_NL/pro.json": [62345, 62345],
            "./nl_NL/profile.json": [96817, 25104],
            "./nl_NL/results.json": [6453, 6453],
            "./nl_NL/search.json": [19895, 19895],
            "./nl_NL/start.json": [55024, 55024],
            "./nl_NL/startpage.json": [95779, 95779],
            "./nl_NL/streak.json": [29005, 29005],
            "./nl_NL/streams.json": [83817, 83817],
            "./nl_NL/support.json": [35699, 35699],
            "./nl_NL/tutorial.json": [33758, 33758],
            "./nl_NL/unsubscribe.json": [94424, 94424],
            "./nl_NL/us-state-streak.json": [90716, 90716],
            "./nl_NL/us.json": [86882, 86882],
            "./nl_NL/user.json": [89246, 29195],
            "./pt_BR/all.json": [67499, 67499],
            "./pt_BR/api-badge-hint.json": [22821, 22821],
            "./pt_BR/api-badge-name.json": [84316, 84316],
            "./pt_BR/api-email.json": [63387, 63387],
            "./pt_BR/api-map-description.json": [99434, 99434],
            "./pt_BR/api-map-name.json": [82472, 82472],
            "./pt_BR/api-subscription-description.json": [1739, 1739],
            "./pt_BR/api-subscription-plan-name.json": [54063, 54063],
            "./pt_BR/api-subscription-plan-title.json": [3882, 3882],
            "./pt_BR/auth.json": [71707, 71707],
            "./pt_BR/br.json": [94515, 94515],
            "./pt_BR/campaign.json": [2640, 2640],
            "./pt_BR/career.json": [61937, 61937],
            "./pt_BR/challenge.json": [67511, 67511],
            "./pt_BR/city-streaks.json": [26626, 26626],
            "./pt_BR/components.json": [78150, 78150],
            "./pt_BR/country-streak.json": [18338, 18338],
            "./pt_BR/country.json": [74120, 74120],
            "./pt_BR/daily-challenge.json": [16871, 16871],
            "./pt_BR/duels.json": [32310, 32310],
            "./pt_BR/education.json": [37760, 37760],
            "./pt_BR/explorer.json": [50795, 50795],
            "./pt_BR/faq.json": [29231, 29231],
            "./pt_BR/free.json": [23343, 23343],
            "./pt_BR/friends.json": [83481, 83481],
            "./pt_BR/game.json": [65386, 91525],
            "./pt_BR/gift-card.json": [82683, 82683],
            "./pt_BR/infinity.json": [1174, 1174],
            "./pt_BR/layout.json": [74766, 74766],
            "./pt_BR/leagues.json": [12291, 12291],
            "./pt_BR/lobby.json": [87395, 87395],
            "./pt_BR/map-maker.json": [5982, 5982],
            "./pt_BR/maps.json": [54292, 54292],
            "./pt_BR/privacy.json": [61558, 61558],
            "./pt_BR/pro.json": [58831, 58831],
            "./pt_BR/profile.json": [15101, 15101],
            "./pt_BR/results.json": [16053, 16053],
            "./pt_BR/search.json": [19633, 19633],
            "./pt_BR/start.json": [9243, 9243],
            "./pt_BR/startpage.json": [3063, 3063],
            "./pt_BR/streak.json": [38560, 38560],
            "./pt_BR/streams.json": [96142, 96142],
            "./pt_BR/support.json": [89942, 89942],
            "./pt_BR/tutorial.json": [91577, 91577],
            "./pt_BR/unsubscribe.json": [32870, 32870],
            "./pt_BR/us-state-streak.json": [544, 544],
            "./pt_BR/us.json": [75972, 75972],
            "./pt_BR/user.json": [27807, 27807],
            "./sv_SE/all.json": [291, 291],
            "./sv_SE/api-badge-hint.json": [24289, 24289],
            "./sv_SE/api-badge-name.json": [435, 435],
            "./sv_SE/api-email.json": [65110, 65110],
            "./sv_SE/api-map-description.json": [81701, 81701],
            "./sv_SE/api-map-name.json": [58297, 58297],
            "./sv_SE/api-subscription-description.json": [11478, 11478],
            "./sv_SE/api-subscription-plan-name.json": [30806, 30806],
            "./sv_SE/api-subscription-plan-title.json": [53648, 53648],
            "./sv_SE/auth.json": [29614, 29614],
            "./sv_SE/br.json": [73965, 73965],
            "./sv_SE/campaign.json": [56263, 56263],
            "./sv_SE/career.json": [72036, 72036],
            "./sv_SE/challenge.json": [14267, 14267],
            "./sv_SE/city-streaks.json": [33469, 33469],
            "./sv_SE/components.json": [37294, 37294],
            "./sv_SE/country-streak.json": [44562, 44562],
            "./sv_SE/country.json": [21226, 21226],
            "./sv_SE/daily-challenge.json": [42447, 42447],
            "./sv_SE/duels.json": [21182, 21182],
            "./sv_SE/education.json": [69248, 69248],
            "./sv_SE/explorer.json": [77625, 77625],
            "./sv_SE/faq.json": [53443, 53443],
            "./sv_SE/free.json": [89969, 89969],
            "./sv_SE/friends.json": [19165, 19165],
            "./sv_SE/game.json": [16388, 16388],
            "./sv_SE/gift-card.json": [64425, 64425],
            "./sv_SE/infinity.json": [61371, 61371],
            "./sv_SE/layout.json": [74673, 74673],
            "./sv_SE/leagues.json": [40886, 40886],
            "./sv_SE/lobby.json": [25654, 25654],
            "./sv_SE/map-maker.json": [29161, 29161],
            "./sv_SE/maps.json": [57050, 57050],
            "./sv_SE/privacy.json": [44422, 44422],
            "./sv_SE/pro.json": [15921, 15921],
            "./sv_SE/profile.json": [3821, 3821],
            "./sv_SE/results.json": [40840, 40840],
            "./sv_SE/search.json": [92037, 92037],
            "./sv_SE/start.json": [59389, 59389],
            "./sv_SE/startpage.json": [95741, 95741],
            "./sv_SE/streak.json": [52368, 52368],
            "./sv_SE/streams.json": [34017, 34017],
            "./sv_SE/support.json": [90621, 90621],
            "./sv_SE/tutorial.json": [25678, 25678],
            "./sv_SE/unsubscribe.json": [86248, 86248],
            "./sv_SE/us-state-streak.json": [25525, 25525],
            "./sv_SE/us.json": [37143, 37143],
            "./sv_SE/user.json": [51032, 51032],
            "./tr_TR/all.json": [42368, 42368],
            "./tr_TR/api-badge-hint.json": [74521, 74521],
            "./tr_TR/api-badge-name.json": [93404, 93404],
            "./tr_TR/api-email.json": [81620, 81620],
            "./tr_TR/api-map-description.json": [88891, 88891],
            "./tr_TR/api-map-name.json": [17116, 17116],
            "./tr_TR/api-subscription-description.json": [15211, 15211],
            "./tr_TR/api-subscription-plan-name.json": [90022, 90022],
            "./tr_TR/api-subscription-plan-title.json": [95331, 95331],
            "./tr_TR/auth.json": [60048, 60048],
            "./tr_TR/br.json": [40201, 40201],
            "./tr_TR/campaign.json": [88176, 88176],
            "./tr_TR/career.json": [72904, 72904],
            "./tr_TR/challenge.json": [20104, 20104],
            "./tr_TR/city-streaks.json": [98698, 98698],
            "./tr_TR/components.json": [84377, 84377],
            "./tr_TR/country-streak.json": [40976, 40976],
            "./tr_TR/country.json": [16204, 16204],
            "./tr_TR/daily-challenge.json": [80641, 80641],
            "./tr_TR/duels.json": [39158, 39158],
            "./tr_TR/education.json": [2050, 2050],
            "./tr_TR/explorer.json": [80199, 80199],
            "./tr_TR/faq.json": [53968, 53968],
            "./tr_TR/free.json": [42441, 42441],
            "./tr_TR/friends.json": [96658, 96658],
            "./tr_TR/game.json": [72325, 72325],
            "./tr_TR/gift-card.json": [60337, 60337],
            "./tr_TR/infinity.json": [58860, 58860],
            "./tr_TR/layout.json": [63732, 63732],
            "./tr_TR/leagues.json": [5814, 5814],
            "./tr_TR/lobby.json": [20942, 20942],
            "./tr_TR/map-maker.json": [48455, 48455],
            "./tr_TR/maps.json": [17063, 17063],
            "./tr_TR/privacy.json": [28223, 28223],
            "./tr_TR/pro.json": [26747, 26747],
            "./tr_TR/profile.json": [42527, 42527],
            "./tr_TR/results.json": [2056, 2056],
            "./tr_TR/search.json": [89655, 89655],
            "./tr_TR/start.json": [94776, 94776],
            "./tr_TR/startpage.json": [95780, 95780],
            "./tr_TR/streak.json": [1190, 1190],
            "./tr_TR/streams.json": [76378, 76378],
            "./tr_TR/support.json": [18673, 18673],
            "./tr_TR/tutorial.json": [78856, 78856],
            "./tr_TR/unsubscribe.json": [52515, 52515],
            "./tr_TR/us-state-streak.json": [42102, 42102],
            "./tr_TR/us.json": [34146, 34146],
            "./tr_TR/user.json": [93978, 93978]
        };
     */
    /// <summary>
    /// Class providing access to GeoGuessr API endpoints
    /// </summary>
    public static class GeoGuessrClient
    {
        #region URLs
        /// <summary>
        /// GeoGuessr base url
        /// </summary>
        public const string GeoGuessr = "https://www.geoguessr.com/";
        /// <summary>
        /// GeoGuessr API versionless path
        /// </summary>
        public const string GeoGuessrAPI = $"{GeoGuessr}api/";
        /// <summary>
        /// GeoGuessr API v3 path
        /// </summary>
        public const string GeoGuessrAPIv3 = $"{GeoGuessrAPI}v3/";

        /// <summary>
        /// GeoGuessr API v4 path
        /// </summary>
        public const string GeoGuessrAPIv4 = $"{GeoGuessrAPI}v4/";

        /// <summary>
        /// GeoGuessr API games endpoint for getting and creating games
        /// </summary>
        public const string GeoGuessrAPIGames = $"{GeoGuessrAPIv3}games/";

        /// <summary>
        /// GeoGuessr API chalenges endpoint for getting and creating games
        /// </summary>
        public const string GeoGuessrAPIChallenges = $"{GeoGuessrAPIv3}challenges/";

        /// <summary>
        /// GeoGuessr challenge results
        /// </summary>
        public const string GeoGuessrChallengeResultsAddress = $"{GeoGuessrAPIv3}results/scores/";

        /// <summary>
        /// GeoGuessr single player games path
        /// </summary>
        public const string GeoGuessrGameAddress = "https://www.geoguessr.com/game/";

        /// <summary>
        /// GeoGuessr challenge games path
        /// </summary>
        public const string GeoGuessrChallengeAddress = "https://www.geoguessr.com/challenge/";

   
        /// <summary>
        /// GeoGuessr challenge games path
        /// </summary>
        public const string GeoGuessrSignInAddress = "https://www.geoguessr.com/signin/";

        /// <summary>
        /// GeoGuessr API game server
        /// </summary>
        public const string GeoGuessrAPIGameServer = "https://game-server.geoguessr.com/api/";

        #endregion

        private static readonly ILog logger = LogManager.GetLogger(typeof(GeoGuessrClient));

        /// <summary>
        /// Client for making GeoGuessr API requests
        /// </summary>
        public static RestClient Client { get; } = new RestClient();

        /// <summary>
        /// GeoGuessr cookie used with GeoGuessr API requests
        /// </summary>
        public static string Cookie { get; set; } = string.Empty;

        #region API Map browser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsBrowseAllRequest(int page = 0, int count = 6)
        {
            return new($"{GeoGuessrAPIv3}social/maps/browse/popular/all?page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsBrowseMonthRequest(int page = 0, int count = 6)
        {
            return new($"{GeoGuessrAPIv3}social/maps/browse/popular/month?page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsBrowseFeaturedRequest(int page = 0, int count = 3)
        {
            return new($"{GeoGuessrAPIv3}social/maps/browse/featured?page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsBrowseNewRequest(int page = 0, int count = 6)
        {
            return new($"{GeoGuessrAPIv3}social/maps/browse/new?page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsBrowseOfficialRequest(int page = 0, int count = 8)
        {
            return new($"{GeoGuessrAPIv3}social/maps/browse/official?page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest MapsBrowsePersonalizedRequest()
        {
            return new($"{GeoGuessrAPIv3}social/maps/browse/personalized");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsCreatedByRequest(string userid, int page = 0, int count = 9)
        {
            return new($"{GeoGuessrAPI}maps?createdBy={userid}&page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsBrowseMyMapsRequest(int page = 0, int count = 6)
        {
            return new($"{GeoGuessrAPIv3}profiles/maps?page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest MapsBrowseLikesRequest(int page = 0, int count = 6)
        {
            return new($"{GeoGuessrAPIv3}likes?page={page}&count={count}");
        }
        #endregion

        #region API Search and Explore
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest SearchRequest(string query, int page = 0, int count = 10)
        {
            return new($"{GeoGuessrAPIv3}search/any?page={page}&count={count}&q={query}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest ExplorerRequest()
        {
            return new($"{GeoGuessrAPIv3}explorer");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static RestRequest ExplorerRequest(string userid)
        {
            return new($"{GeoGuessrAPIv3}explorer/user/{userid}");
        }
        #endregion

        #region API Friends and Notifications
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest FriendsRequest(int page = 0, int count = 21)
        {
            return new($"{GeoGuessrAPIv3}social/friends?page={page}&count={count}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest FriendsRecievedRequest()
        {
            return new($"{GeoGuessrAPIv3}social/friends/received");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest FriendshipsRequest()
        {
            return new($"{GeoGuessrAPIv3}social/friendships");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest ProfilesRequest()
        {
            return new($"{GeoGuessrAPIv3}profiles");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static RestRequest NotificationsV4Request(int page = 0, int count = 21)
        {
            return new($"{GeoGuessrAPIv4}notifications?page={page}&count={count}");
        }
        #endregion

        #region API Stats
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static RestRequest BadgesRequest(string userid)
        {
            return new($"{GeoGuessrAPIv3}social/badges/{userid}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest SubscriptionsRequest()
        {
            return new($"{GeoGuessrAPIv3}subscriptions");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest AchievementsRequest()
        {
            return new($"{GeoGuessrAPIv3}profiles/achievements");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest StatsRequest()
        {
            return new($"{GeoGuessrAPIv3}profiles/stats");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static RestRequest StatsRequest(string userid)
        {
            return new($"{GeoGuessrAPIv3}users/{userid}/stats");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest StatsV4Request()
        {
            return new($"{GeoGuessrAPIv4}stats/me");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static RestRequest StatsV4Request(string userid)
        {
            return new($"{GeoGuessrAPIv4}stats/users/{userid}");
        }
        #endregion

        #region API Games
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static RestRequest GamesRequest(string id)
        {
            return new($"{GeoGuessrAPIGames}{id}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static RestRequest GamesRequest(Method method = Method.Post)
        {
            return new($"{GeoGuessrAPIGames}", method);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static RestRequest ChallangeGamesRequest(string id)
        {
            return new($"{GeoGuessrAPIChallenges}{id}/game");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset">Empty to start from 0,otherwise <c>1{user_id}_{offset_game_token}_{offset_game_starting_datetime_as_ticks}</c></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static RestRequest UnfinishedGamesRequest(string offset, int limit = 11)
        {
            return new($"{GeoGuessrAPIv3}social/events/unfinishedgames?offset={offset}&limit={limit}");
        }
        #endregion

        #region API Multiplayer
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest PartiesRequest()
        {
            return new($"{GeoGuessrAPIGameServer}parties");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="party"></param>
        /// <returns></returns>
        public static RestRequest PartyRequest(string party)
        {
            return new($"{GeoGuessrAPIGameServer}parties/{party}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="period"></param>
        /// <param name="count"></param>
        /// <param name="paginateFrom"></param>
        /// <returns></returns>
        public static RestRequest PartyLobbyLeaderboardRequest(string id, string period = "alltime", int count = 20, int paginateFrom = 0)
        {
            return new($"{GeoGuessrAPIGameServer}parties/{id}/leaderboard?period={period}&count={count}&paginateFrom={paginateFrom}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="party"></param>
        /// <returns></returns>
        public static RestRequest PostPartyLobbyCreateRequest(string party)
        {
            return new($"{GeoGuessrAPIGameServer}parties/{party}/create-game", Method.Post);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="party"></param>
        /// <returns></returns>
        public static RestRequest PutPartyJoinRequest(string party)
        {
            return new($"{GeoGuessrAPIGameServer}parties/{party}/join", Method.Put);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lobby"></param>
        /// <returns></returns>
        public static RestRequest PostPartyLobbyJoinRequest(string lobby)
        {
            return new($"{GeoGuessrAPIGameServer}lobby/{lobby}/join", Method.Post);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="party"></param>
        /// <returns></returns>
        public static RestRequest PostPartyLobbyBanRequest(string party)
        {
            return new($"{GeoGuessrAPIGameServer}parties/{party}/ban", Method.Post);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="party"></param>
        /// <returns></returns>
        public static RestRequest PutPartyLobbyDiscardRequest(string party)
        {
            return new($"{GeoGuessrAPIGameServer}parties/{party}/remove-game", Method.Put);
        }
        #endregion

        #region Sign In/Out
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest PostSignInRequest()
        {
            return new($"{GeoGuessrAPIv3}accounts/signin", Method.Post);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RestRequest PostSignOutRequest()
        {
            return new($"{GeoGuessrAPIv3}accounts/signout", Method.Post);
        }
        #endregion

        #region Validator Methods
        /// <summary>
        /// Validate that <paramref name="address"/> is not null or empty. Throw if <paramref name="shouldThrow"/> is <see langword="true"/>
        /// </summary>
        /// <param name="address"></param>
        /// <param name="shouldThrow"></param>
        /// <returns><see langword="true"/> if <paramref name="address"/> is non-null and non-empty, otherwise <see langword="false"/> or throws.</returns>
        private static bool ValidateAddress(string address, bool shouldThrow = true)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                if (shouldThrow)
                {
                    GCUtils.ThrowIfNull(address, nameof(address), "Address was invalid.");
                }
                return false;
            }
            return true;
        }

        /// <summary>
        /// Wheter a URL points to a GeoGuessr single player game
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static bool IsSinglePlayerGame(string address)
        {
            return ValidateAddress(address) && address.StartsWithDefault(GeoGuessrGameAddress);
        }
        /// <summary>
        /// Wheter a URL points to a GeoGuessr challenge game
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static bool IsChallengeGame(string address)
        {
            return ValidateAddress(address) && address.StartsWithDefault(GeoGuessrChallengeAddress);
        }
        /// <summary>
        /// Wheter a URL points to a GeoGuessr game 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static bool IsGameAddress(string address)
        {
            return ValidateAddress(address, false) && (IsSinglePlayerGame(address) || IsChallengeGame(address));
        }
        /// <summary>
        /// Wheter a URL points to a GeoGuessr game 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static bool IsGameStartAddress(string address)
        {
            return ValidateAddress(address, false) && ((address.EndsWithDefault("/play") && address.StartsWithDefault($"{GeoGuessr}maps/")) || address.EndsWithDefault("/country-streak") || address.EndsWithDefault("/us-state-streak"));
        }
        #endregion

        #region GET API Requests and Utils
        /// <summary>
        /// Get game id for <see cref="GameID.ID"/> from given URL
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string GetGameId(string address)
        {
            ValidateAddress(address);

            return IsSinglePlayerGame(address)
                ? address[GeoGuessrGameAddress.Length..]
                : IsChallengeGame(address) ? address[GeoGuessrChallengeAddress.Length..] : string.Empty;
        }

        /// <summary>
        /// Get game by id from GeoGuessr api
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content">Response content</param>
        /// <returns><see langword="true"/> if requests succeds, otherwise <see langword="false"/></returns>
        private static bool GameData(string id, out string content)
        {
            bool status;
            content = null;
            RestRequest req = GamesRequest(id);
            req.AddHeader("Cookie", Cookie);
            
            logger.Info($"Getting game data for {id}");

            RestResponse resp = Client.Execute(req);
            if (resp.StatusCode == HttpStatusCode.BadRequest)
            {
                logger.Info($"Trying getting game data for {id} as a challenge game");
                req = ChallangeGamesRequest(id);
                req.AddHeader("Cookie", Cookie);
                resp = Client.Execute(req);
                if (resp.Content == "{\"message\":\"Could not find the result for this challenge and user.\"}")
                {
                    logger.Warn($"Game data for {id} found but challenge hasn't started");
                    return false; // First launch of challenge
                }
            }

            status = resp.StatusCode == HttpStatusCode.OK;

            while (!status && req.Attempts < 3)
            {
                resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(resp.Content))
            {
                logger.Error($"Game data for {id} was empty");
                return false;
            }

            content = resp.Content;
            return true;
        } 
        
        /// <summary>
        /// Get game by id from GeoGuessr api
        /// </summary>
        /// <param name="content">Response content</param>
        /// <returns><see langword="true"/> if requests succeds, otherwise <see langword="false"/></returns>
        private static bool UserData(out string content)
        {
            bool status;        
            content = null;
            RestRequest req = ProfilesRequest();
            req.AddHeader("Cookie", GeoGuessrClient.Cookie);
            

            RestResponse resp = Client.Execute(req);
            if (resp.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
             }

            status = resp.StatusCode == HttpStatusCode.OK;

            while (!status && req.Attempts < 3)
            {
                resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(resp.Content))
            {
                return false;
            }

            content = resp.Content;
            return true;
        }

        /// <summary>
        /// Update a <see cref="GeoGuessrGame"/> <paramref name="game"/> instance from GeoGuessr API
        /// </summary>
        /// <param name="game"></param>
        /// <param name="ischallenge"></param>
        /// <returns></returns>
        public static bool UpdateGameData(GeoGuessrGame game, bool ischallenge)
        {
            GCUtils.ThrowIfNull(game, nameof(game));
            string content = string.Empty;
            try
            {
                if (!GameData(game.token, out content)
                    || string.IsNullOrWhiteSpace(content))
                {
                    logger.Error($"Game data getter for {game.token} failed. Content: {content}");
                    return false;
                }
                int gameplayerid = game.player.GcId;
                int gameboundsid = game.bounds.Id;
                JsonConvert.PopulateObject(content, game);
                game.player.GcId = gameplayerid;
                game.bounds.Id = gameboundsid;

                int pad = 0;
                int extra = game.rounds.Count - game.round;
                if (extra == game.round)
                {
                    pad = 1; // Because after last round game.round isnt incremented
                }

                while (extra-- > 0)
                {
                    game.rounds.RemoveAt(game.round - 1 + pad);
                }

                logger.Info($"Found and update game data for {game.token}");
                return true;
            }
            catch (Exception ex)
            {
                logger.Error($"Game data getter for {game.token} failed. Content: {content}\r\n\tException: {ex.Summarize()}");
                return false;
            }
        }
        /// <summary>
        /// Create a <see cref="GeoGuessrGame"/> instance from <see cref="GameID"/>
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public static GeoGuessrGame GetGameData(GameID gameId)
        {
            GCUtils.ThrowIfNull(gameId, nameof(gameId));

            try
            {
                GeoGuessrGame game = null;

                if (!GameData(gameId.ID, out string content))
                {
                    return new();
                }

                game = JsonConvert.DeserializeObject<GeoGuessrGame>(content);
                logger.Info($"Found and parsed game data for {gameId.ID}");
                return game;
            }
            catch (Exception ex)
            {
                logger.Error($"Game data getter for {gameId.ID} failed. {ex.Summarize()}");
                return null;
            }
        }
        /// <summary>
        /// Gets the profile of the currently logged in user
        /// </summary>
        /// 
        /// <returns>The <see cref="GGProfile"/></returns>
        public static GGProfile GetProfile()
        {

            try
            {

                if (!UserData(out string content))
                {
                    return new();
                }
                GGProfile profile = JsonConvert.DeserializeObject<GGProfile>(content);
                //game = JsonConvert.DeserializeObject<G>(content);
                logger.Info($"Found and parsed profile data for {profile.user.nick} ({profile.user.id})");
                return profile;
            }
            catch (Exception ex)
            {
                logger.Error($"Could not get profile of logged in user. {ex.Summarize()}");
                return null;
            }
        }
        #endregion

        #region POST & PUT API Requests and Utils
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gamedata"></param>
        /// <returns></returns>
        public static GeoGuessrGame CreateGame(GGPostGame gamedata)
        {
            GCUtils.ThrowIfNull(gamedata, nameof(gamedata));

            try
            {
                GeoGuessrGame game = null;
                string ser = JsonConvert.SerializeObject(gamedata);

                RestRequest req = GamesRequest(Method.Post);
                req.AddHeader("Cookie", Cookie);
                req.AddJsonBody(ser);

                logger.Info($"Creating a game of type '{gamedata.type}' in map '{gamedata.map}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    game = JsonConvert.DeserializeObject<GeoGuessrGame>(resp.Content);
                }
                else
                {
                    logger.Error($"Game create request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
                return game;
            }
            catch (Exception ex)
            {
                logger.Error($"Game create request failed of type '{gamedata.type}' in map '{gamedata.map}' => {ex.Summarize()}");
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static GGSignInResponse SignInWith(string email, string password, out string cookie, out string error)
        {
            error = string.Empty;

            try
            {
                string ser = JsonConvert.SerializeObject(new GGSignInBody() { email = email, password = password });
                GGSignInResponse result = null;
                cookie = null;
                RestRequest req = PostSignInRequest();
                req.AddJsonBody(ser);

                logger.Info($"Sign in '{email}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<GGSignInResponse>(resp.Content);
                    cookie = resp.Headers?.ToList().Find(x => x.Name.ToLowerInvariant() == "set-cookie")?.Value?.ToString();
                }
                else
                {
                    logger.Error($"Sign in request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                    error = resp.ErrorException.Message;
                }
                return result;
            }
            catch (Exception ex)
            {
                cookie = string.Empty;
                logger.Info($"Sign in '{email}' failed => {ex.Summarize()}");
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="removeCookie">Wheter to removed static cookie after successful sign out</param>
        /// <returns></returns>
        public static bool SignOutWithCookie(bool removeCookie = false)
        {
            try
            {
                RestRequest req = PostSignOutRequest();
                req.AddHeader("Cookie", Cookie);

                logger.Info($"Sign out");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    logger.Info($"Sign out success");
                    return true;
                }
                else
                {
                    logger.Error($"Sign out request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
                if (removeCookie)
                {
                    Cookie = null;
                }
            }
            catch (Exception ex)
            {
                logger.Info($"Sign out failed => {ex.Summarize()}");
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gametype"></param>
        /// <returns></returns>
        public static CreatePartyLobbyResponse CreatePartyLobby(string party, string gametype = "Duels")
        {
            try
            {
                string ser = JsonConvert.SerializeObject(new PartyCreateGame() { gameType = gametype });
                CreatePartyLobbyResponse result = null;
                RestRequest req = PostPartyLobbyCreateRequest(party);
                req.AddHeader("Cookie", Cookie);
                req.AddJsonBody(ser);

                logger.Info($"CreatePartyGame '{gametype}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<CreatePartyLobbyResponse>(resp.Content);
                }
                else
                {
                    logger.Error($"CreatePartyGame request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
                return result;
            }
            catch (Exception ex)
            {
                logger.Info($"CreatePartyGame '{gametype}' failed => {ex.Summarize()}");
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gametype"></param>
        /// <returns></returns>
        public static GGPartyLobby GetPartyData(string partyID)
        {
            try
            {
                GGPartyLobby result = null;
                RestRequest req = PartyRequest(partyID);
                req.AddHeader("Cookie", Cookie);

                logger.Info($"GetPartyData '{partyID}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<GGPartyLobby>(resp.Content);
                    logger.Info($"GetPartyData {partyID} success");
                    return result;
                }
                else
                {
                    logger.Error($"GetPartyData request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
            }
            catch (Exception ex)
            {
                logger.Info($"GetPartyData '{partyID}' failed => {ex.Summarize()}");
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gametype"></param>
        /// <returns></returns>
        public static CreatedPartyGameResponse JoinPartyLobby(string lobbyID)
        {
            try
            {
                CreatedPartyGameResponse result = null;
                RestRequest req = PostPartyLobbyJoinRequest(lobbyID);
                req.AddJsonBody("{}");
                req.AddHeader("Cookie", Cookie);

                logger.Info($"JoinPartyLobby '{lobbyID}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<CreatedPartyGameResponse>(resp.Content);
                    logger.Info($"Join lobby {lobbyID} success");
                    return result;
                }
                else
                {
                    logger.Error($"JoinPartyLobby request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
            }
            catch (Exception ex)
            {
                logger.Info($"JoinPartyLobby '{lobbyID}' failed => {ex.Summarize()}");
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gametype"></param>
        /// <returns></returns>
        public static GGPartyGame JoinParty(string partyID)
        {
            try
            {
                string ser = "{\"password\":\"\"}";
                GGPartyGame result = null;
                RestRequest req = PutPartyJoinRequest(partyID);
                req.AddHeader("Cookie", Cookie);
                req.AddJsonBody(ser);

                logger.Info($"JoinParty '{partyID}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<GGPartyGame>(resp.Content);
                    logger.Info($"JoinParty {partyID} success");
                    return result;
                }
                else
                {
                    logger.Error($"JoinParty request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
            }
            catch (Exception ex)
            {
                logger.Info($"JoinParty '{partyID}' failed => {ex.Summarize()}");
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="partyID"></param>
        /// <param name="lobbyID"></param>
        /// <returns></returns>
        public static GGPartyGame DiscardPartyLobby(string partyID, string lobbyID)
        {
            try
            {
                string ser = JsonConvert.SerializeObject(new PartyDiscardGame() { gameLobbyId = lobbyID });
                GGPartyGame result = null;
                RestRequest req = PutPartyLobbyDiscardRequest(partyID);
                req.AddHeader("Cookie", Cookie);
                req.AddJsonBody(ser);

                logger.Info($"DiscardPartyLobby '{partyID}' '{lobbyID}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<GGPartyGame>(resp.Content);
                }
                else
                {
                    logger.Error($"DiscardPartyLobby request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
                return result;
            }
            catch (Exception ex)
            {
                logger.Info($"DiscardPartyLobby '{partyID}' '{lobbyID}' failed => {ex.Summarize()}");
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partyId"></param>
        /// <param name="userId"></param>
        /// <param name="banState"></param>
        /// <returns></returns>
        public static GGPartyGame SetPlayerBanState(string partyId, string userId, bool banState)
        {
            try
            {
                string ser = JsonConvert.SerializeObject(new PartyBan() { userId = userId, ban = banState });
                GGPartyGame result = null;
                RestRequest req = PostPartyLobbyBanRequest(partyId);
                req.AddHeader("Cookie", Cookie);
                req.AddJsonBody(ser);

                logger.Info($"PlayerBanState '{partyId}'");

                RestResponse resp = Client.Execute(req);
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<GGPartyGame>(resp.Content);
                    logger.Info($"PlayerBanState {partyId} {userId} {banState} success");
                    return result;
                }
                else
                {
                    logger.Error($"PlayerBanState request failed. {resp.ErrorMessage} => {resp.ErrorException?.Summarize()}");
                }
            }
            catch (Exception ex)
            {
                logger.Info($"PlayerBanState '{partyId}' '{userId}' '{banState}' failed => {ex.Summarize()}");
            }
            return null;
        }
        #endregion
    }

}
