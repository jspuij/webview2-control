﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.WebView2.Demo
{
    public enum Messages : int
    {
        MG_NAVIGATE=1,
        MG_UPDATE_URI=2,
        MG_GO_FORWARD=3,
        MG_GO_BACK=4,
        MG_NAV_STARTING=5,
        MG_NAV_COMPLETED=6,
        MG_RELOAD=7,
        MG_CANCEL=8,
        MG_CREATE_TAB=10,
        MG_UPDATE_TAB=11,
        MG_SWITCH_TAB=12,
        MG_CLOSE_TAB=13,
        MG_CLOSE_WINDOW=14,
        MG_SHOW_OPTIONS=15,
        MG_HIDE_OPTIONS=16,
        MG_OPTIONS_LOST_FOCUS=17,
        MG_OPTION_SELECTED=18,
        MG_SECURITY_UPDATE=19,
        MG_UPDATE_FAVICON=20,
        MG_GET_SETTINGS=21,
        MG_GET_FAVORITES=22,
        MG_REMOVE_FAVORITE=23,
        MG_CLEAR_CACHE=24,
        MG_CLEAR_COOKIES=25,
        MG_GET_HISTORY=26,
        MG_REMOVE_HISTORY_ITEM=27,
        MG_CLEAR_HISTORY=28,
    }
}