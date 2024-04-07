using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    internal class Data
    {
        public string[] keys = { "None", "LButton", "RButton", "Cancel", "MButton", "XButton1", "XButton2", "LButton, XButton2", "Back", "Tab", "LineFeed", "LButton, LineFeed", "Clear", "Return", "RButton, Clear", "RButton, Return", "ShiftKey", "ControlKey", "Menu", "Pause", "Capital", "KanaMode", "RButton, Capital", "JunjaMode", "FinalMode", "HanjaMode", "RButton, FinalMode", "Escape", "IMEConvert", "IMENonconvert", "IMEAceept", "IMEModeChange", "Space", "PageUp", "Next", "End", "Home", "Left", "Up", "Right", "Down", "Select", "Print", "Execute", "PrintScreen", "Insert", "Delete", "Help", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "RButton, D8", "RButton, D9", "MButton, D8", "MButton, D9", "XButton2, D8", "XButton2, D9", "64", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "LWin", "RWin", "Apps", "RButton, RWin", "Sleep", "NumPad0", "NumPad1", "NumPad2", "NumPad3", "NumPad4", "NumPad5", "NumPad6", "NumPad7", "NumPad8", "NumPad9", "Multiply", "Add", "Separator", "Subtract", "Decimal", "Divide", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "F13", "F14", "F15", "F16", "F17", "F18", "F19", "F20", "F21", "F22", "F23", "F24", "Back, F17", "Back, F18", "Back, F19", "Back, F20", "Back, F21", "Back, F22", "Back, F23", "Back, F24", "NumLock", "Scroll", "RButton, NumLock", "RButton, Scroll", "MButton, NumLock", "MButton, Scroll", "XButton2, NumLock", "XButton2, Scroll", "Back, NumLock", "Back, Scroll", "LineFeed, NumLock", "LineFeed, Scroll", "Clear, NumLock", "Clear, Scroll", "RButton, Clear, NumLock", "RButton, Clear, Scroll", "LShiftKey", "RShiftKey", "LControlKey", "RControlKey", "LMenu", "RMenu", "BrowserBack", "BrowserForward", "BrowserRefresh", "BrowserStop", "BrowserSearch", "BrowserFavorites", "BrowserHome", "VolumeMute", "VolumeDown", "VolumeUp", "MediaNextTrack", "MediaPreviousTrack", "MediaStop", "MediaPlayPause", "LaunchMail", "SelectMedia", "LaunchApplication1", "LaunchApplication2", "Back, MediaNextTrack", "Back, MediaPreviousTrack", "Oem1", "Oemplus", "Oemcomma", "OemMinus", "OemPeriod", "OemQuestion", "Oemtilde", "LButton, Oemtilde", "RButton, Oemtilde", "Cancel, Oemtilde", "MButton, Oemtilde", "XButton1, Oemtilde", "XButton2, Oemtilde", "LButton, XButton2, Oemtilde", "Back, Oemtilde", "Tab, Oemtilde", "LineFeed, Oemtilde", "LButton, LineFeed, Oemtilde", "Clear, Oemtilde", "Return, Oemtilde", "RButton, Clear, Oemtilde", "RButton, Return, Oemtilde", "ShiftKey, Oemtilde", "ControlKey, Oemtilde", "Menu, Oemtilde", "Pause, Oemtilde", "Capital, Oemtilde", "KanaMode, Oemtilde", "RButton, Capital, Oemtilde", "JunjaMode, Oemtilde", "FinalMode, Oemtilde", "HanjaMode, Oemtilde", "RButton, FinalMode, Oemtilde", "OemOpenBrackets", "Oem5", "Oem6", "Oem7", "Oem8", "Space, Oemtilde", "PageUp, Oemtilde", "OemBackslash", "LButton, OemBackslash", "Home, Oemtilde", "ProcessKey", "MButton, OemBackslash", "Packet", "Down, Oemtilde", "Select, Oemtilde", "Back, OemBackslash", "Tab, OemBackslash", "PrintScreen, Oemtilde", "Back, ProcessKey", "Clear, OemBackslash", "Back, Packet", "D0, Oemtilde", "D1, Oemtilde", "ShiftKey, OemBackslash", "ControlKey, OemBackslash", "D4, Oemtilde", "ShiftKey, ProcessKey", "Attn", "Crsel", "Exsel", "EraseEof", "Play", "Zoom", "NoName", "Pa1", "OemClear", "LButton, OemClear" };
        /*public Hotkeys keys = new Hotkeys
        {
            None = "-",
            LButton = "-",
            RButton = "-",
            Cancel = "-",
            MButton = "-",
            XButton1 = "-",
            XButton2 = "-",
            LButtonXButton = "-",
            Back = "-",
            Tab = "-",
            LineFeed = "-",
            LButton_LineFeed = "-",
            Clear = "-",
            Return = "-",
            RButtonClear = "-",
            RButton_Return = "-",
            ShiftKey = "-",
            ControlKey = "-",
            Menu = "-",
            Pause = "-",
            Capital = "-",
            KanaMode = "-",
            RButton_Capital = "-",
            JunjaMode = "-",
            FinalMode = "-",
            HanjaMode = "-",
            RButton_FinalMode = "-",
            Escape = "-",
            IMEConvert = "-",
            IMENonconvert = "-",
            IMEAceept = "-",
            IMEModeChange = "-",
            Space = "-",
            PageUp = "-",
            Next = "-",
            End = "-",
            Home = "-",
            Left = "-",
            Up = "-",
            Right = "-",
            Down = "-",
            Select = "-",
            Print = "-",
            Execute = "-",
            PrintScreen = "-",
            Insert = "-",
            Delete = "-",
            Help = "-",
            D0 = "-",
            D1 = "-",
            D2 = "-",
            D3 = "-",
            D4 = "-",
            D5 = "-",
            D6 = "-",
            D7 = "-",
            D8 = "-",
            D9 = "-",
            RButton_D8 = "-",
            RButton_D9 = "-",
            MButton_D8 = "-",
            MButton_D9 = "-",
            XButton2_D8 = "-",
            XButton2_D9 = "-",
            _64 = "-",
            A = "-",
            B = "-",
            C = "-",
            D = "-",
            E = "-",
            F = "-",
            G = "-",
            H = "-",
            I = "-",
            J = "-",
            K = "-",
            L = "-",
            M = "-",
            N = "-",
            O = "-",
            P = "-",
            Q = "-",
            R = "-",
            S = "-",
            T = "-",
            U = "-",
            V = "-",
            W = "-",
            X = "-",
            Y = "-",
            Z = "-",
            LWin = "-",
            RWin = "-",
            Apps = "-",
            RButton_RWin = "-",
            Sleep = "-",
            NumPad0 = "-",
            NumPad1 = "-",
            NumPad2 = "-",
            NumPad3 = "-",
            NumPad4 = "-",
            NumPad5 = "-",
            NumPad6 = "-",
            NumPad7 = "-",
            NumPad8 = "-",
            NumPad9 = "-",
            Multiply = "-",
            Add = "-",
            Separator = "-",
            Subtract = "-",
            Decimal = "-",
            Divide = "-",
            F1 = "-",
            F2 = "-",
            F3 = "-",
            F4 = "-",
            F5 = "-",
            F6 = "-",
            F7 = "-",
            F8 = "-",
            F9 = "-",
            F10 = "-",
            F11 = "-",
            F12 = "-",
            F13 = "-",
            F14 = "-",
            F15 = "-",
            F16 = "-",
            F17 = "-",
            F18 = "-",
            F19 = "-",
            F20 = "-",
            F21 = "-",
            F22 = "-",
            F23 = "-",
            F24 = "-",
            Back_F17 = "-",
            Back_F18 = "-",
            Back_F19 = "-",
            Back_F20 = "-",
            Back_F21 = "-",
            Back_F22 = "-",
            Back_F23 = "-",
            Back_F24 = "-",
            NumLock = "-",
            Scroll = "-",
            RButton_NumLock = "-",
            RButton_Scroll = "-",
            MButton_NumLock = "-",
            MButton_Scroll = "-",
            XButton2_NumLock = "-",
            XButton2_Scroll = "-",
            Back_NumLock = "-",
            Back_Scroll = "-",
            LineFeed_NumLock = "-",
            LineFeed_Scroll = "-",
            Clear_NumLock = "-",
            Clear_Scroll = "-",
            RButton_Clear_NumLock = "-",
            RButton_Clear_Scroll = "-",
            LShiftKey = "-",
            RShiftKey = "-",
            LControlKey = "-",
            RControlKey = "-",
            LMenu = "-",
            RMenu = "-",
            BrowserBack = "-",
            BrowserForward = "-",
            BrowserRefresh = "-",
            BrowserStop = "-",
            BrowserSearch = "-",
            BrowserFavorites = "-",
            BrowserHome = "-",
            VolumeMute = "-",
            VolumeDown = "-",
            VolumeUp = "-",
            MediaNextTrack = "-",
            MediaPreviousTrack = "-",
            MediaStop = "-",
            MediaPlayPause = "-",
            LaunchMail = "-",
            SelectMedia = "-",
            LaunchApplication1 = "-",
            LaunchApplication2 = "-",
            Back_MediaNextTrack = "-",
            Back_MediaPreviousTrack = "-",
            Oem1 = "-",
            Oemplus = "-",
            Oemcomma = "-",
            OemMinus = "-",
            OemPeriod = "-",
            OemQuestion = "-",
            Oemtilde = "-",
            LButton_Oemtilde = "-",
            RButton_Oemtilde = "-",
            Cancel_Oemtilde = "-",
            MButton_Oemtilde = "-",
            XButton1_Oemtilde = "-",
            XButton2_Oemtilde = "-",
            LButton_XButton2_Oemtilde = "-",
            Back_Oemtilde = "-",
            Tab_Oemtilde = "-",
            LineFeed_Oemtilde = "-",
            LButton_LineFeed_Oemtilde = "-",
            Clear_Oemtilde = "-",
            Return_Oemtilde = "-",
            RButton_Clear_Oemtilde = "-",
            RButton_Return_Oemtilde = "-",
            ShiftKey_Oemtilde = "-",
            ControlKey_Oemtilde = "-",
            Menu_Oemtilde = "-",
            Pause_Oemtilde = "-",
            Capital_Oemtilde = "-",
            KanaMode_Oemtilde = "-",
            RButton_Capital_Oemtilde = "-",
            JunjaMode_Oemtilde = "-",
            FinalMode_Oemtilde = "-",
            HanjaMode_Oemtilde = "-",
            RButton_FinalMode_Oemtilde = "-",
            OemOpenBrackets = "-",
            Oem5 = "-",
            Oem6 = "-",
            Oem7 = "-",
            Oem8 = "-",
            Space_Oemtilde = "-",
            PageUp_Oemtilde = "-",
            OemBackslash = "-",
            LButton_OemBackslash = "-",
            Home_Oemtilde = "-",
            ProcessKey = "-",
            MButton_OemBackslash = "-",
            Packet = "-",
            Down_Oemtilde = "-",
            Select_Oemtilde = "-",
            Back_OemBackslash = "-",
            Tab_OemBackslash = "-",
            PrintScreen_Oemtilde = "-",
            Back_ProcessKey = "-",
            Clear_OemBackslash = "-",
            Back_Packet = "-",
            D0_Oemtilde = "-",
            D1_Oemtilde = "-",
            ShiftKey_OemBackslash = "-",
            ControlKey_OemBackslash = "-",
            D4_Oemtilde = "-",
            ShiftKey_ProcessKey = "-",
            Attn = "-",
            Crsel = "-",
            Exsel = "-",
            EraseEof = "-",
            Play = "-",
            Zoom = "-",
            NoName = "-",
            Pa1 = "-",
            OemClear = "-",
            LButton_OemClear = "-"
        };*/
    }

    /*class Hotkeys
    {
        public string None { get; set; };
        public string LButton { get; set; };
        public string RButton { get; set; };
        public string Cancel { get; set; };
        public string MButton { get; set; };
        public string XButton1 { get; set; };
        public string XButton2 { get; set; };
        public string LButtonXButton { get; set; };
        public string Back { get; set; };
        public string Tab { get; set; };
        public string LineFeed { get; set; };
        public string LButton_LineFeed { get; set; };
        public string Clear { get; set; };
        public string Return { get; set; };
        public string RButtonClear { get; set; };
        public string RButton_Return { get; set; };
        public string ShiftKey { get; set; };
        public string ControlKey { get; set; };
        public string Menu { get; set; };
        public string Pause { get; set; };
        public string Capital { get; set; };
        public string KanaMode { get; set; };
        public string RButton_Capital { get; set; };
        public string JunjaMode { get; set; };
        public string FinalMode { get; set; };
        public string HanjaMode { get; set; };
        public string RButton_FinalMode { get; set; };
        public string Escape { get; set; };
        public string IMEConvert { get; set; };
        public string IMENonconvert { get; set; };
        public string IMEAceept { get; set; };
        public string IMEModeChange { get; set; };
        public string Space { get; set; };
        public string PageUp { get; set; };
        public string Next { get; set; };
        public string End { get; set; };
        public string Home { get; set; };
        public string Left { get; set; };
        public string Up { get; set; };
        public string Right { get; set; };
        public string Down { get; set; };
        public string Select { get; set; };
        public string Print { get; set; };
        public string Execute { get; set; };
        public string PrintScreen { get; set; };
        public string Insert { get; set; };
        public string Delete { get; set; };
        public string Help { get; set; };
        public string D0 { get; set; };
        public string D1 { get; set; };
        public string D2 { get; set; };
        public string D3 { get; set; };
        public string D4 { get; set; };
        public string D5 { get; set; };
        public string D6 { get; set; };
        public string D7 { get; set; };
        public string D8 { get; set; };
        public string D9 { get; set; };
        public string RButton_D8 { get; set; };
        public string RButton_D9 { get; set; };
        public string MButton_D8 { get; set; };
        public string MButton_D9 { get; set; };
        public string XButton2_D8 { get; set; };
        public string XButton2_D9 { get; set; };
        public string _64 { get; set; };
        public string A { get; set; };
        public string B { get; set; };
        public string C { get; set; };
        public string D { get; set; };
        public string E { get; set; };
        public string F { get; set; };
        public string G { get; set; };
        public string H { get; set; };
        public string I { get; set; };
        public string J { get; set; };
        public string K { get; set; };
        public string L { get; set; };
        public string M { get; set; };
        public string N { get; set; };
        public string O { get; set; };
        public string P { get; set; };
        public string Q { get; set; };
        public string R { get; set; };
        public string S { get; set; };
        public string T { get; set; };
        public string U { get; set; };
        public string V { get; set; };
        public string W { get; set; };
        public string X { get; set; };
        public string Y { get; set; };
        public string Z { get; set; };
        public string LWin { get; set; };
        public string RWin { get; set; };
        public string Apps { get; set; };
        public string RButton_RWin { get; set; };
        public string Sleep { get; set; };
        public string NumPad0 { get; set; };
        public string NumPad1 { get; set; };
        public string NumPad2 { get; set; };
        public string NumPad3 { get; set; };
        public string NumPad4 { get; set; };
        public string NumPad5 { get; set; };
        public string NumPad6 { get; set; };
        public string NumPad7 { get; set; };
        public string NumPad8 { get; set; };
        public string NumPad9 { get; set; };
        public string Multiply { get; set; };
        public string Add { get; set; };
        public string Separator { get; set; };
        public string Subtract { get; set; };
        public string Decimal { get; set; };
        public string Divide { get; set; };
        public string F1 { get; set; };
        public string F2 { get; set; };
        public string F3 { get; set; };
        public string F4 { get; set; };
        public string F5 { get; set; };
        public string F6 { get; set; };
        public string F7 { get; set; };
        public string F8 { get; set; };
        public string F9 { get; set; };
        public string F10 { get; set; };
        public string F11 { get; set; };
        public string F12 { get; set; };
        public string F13 { get; set; };
        public string F14 { get; set; };
        public string F15 { get; set; };
        public string F16 { get; set; };
        public string F17 { get; set; };
        public string F18 { get; set; };
        public string F19 { get; set; };
        public string F20 { get; set; };
        public string F21 { get; set; };
        public string F22 { get; set; };
        public string F23 { get; set; };
        public string F24 { get; set; };
        public string Back_F17 { get; set; };
        public string Back_F18 { get; set; };
        public string Back_F19 { get; set; };
        public string Back_F20 { get; set; };
        public string Back_F21 { get; set; };
        public string Back_F22 { get; set; };
        public string Back_F23 { get; set; };
        public string Back_F24 { get; set; };
        public string NumLock { get; set; };
        public string Scroll { get; set; };
        public string RButton_NumLock { get; set; };
        public string RButton_Scroll { get; set; };
        public string MButton_NumLock { get; set; };
        public string MButton_Scroll { get; set; };
        public string XButton2_NumLock { get; set; };
        public string XButton2_Scroll { get; set; };
        public string Back_NumLock { get; set; };
        public string Back_Scroll { get; set; };
        public string LineFeed_NumLock { get; set; };
        public string LineFeed_Scroll { get; set; };
        public string Clear_NumLock { get; set; };
        public string Clear_Scroll { get; set; };
        public string RButton_Clear_NumLock { get; set; };
        public string RButton_Clear_Scroll { get; set; };
        public string LShiftKey { get; set; };
        public string RShiftKey { get; set; };
        public string LControlKey { get; set; };
        public string RControlKey { get; set; };
        public string LMenu { get; set; };
        public string RMenu { get; set; };
        public string BrowserBack { get; set; };
        public string BrowserForward { get; set; };
        public string BrowserRefresh { get; set; };
        public string BrowserStop { get; set; };
        public string BrowserSearch { get; set; };
        public string BrowserFavorites { get; set; };
        public string BrowserHome { get; set; };
        public string VolumeMute { get; set; };
        public string VolumeDown { get; set; };
        public string VolumeUp { get; set; };
        public string MediaNextTrack { get; set; };
        public string MediaPreviousTrack { get; set; };
        public string MediaStop { get; set; };
        public string MediaPlayPause { get; set; };
        public string LaunchMail { get; set; };
        public string SelectMedia { get; set; };
        public string LaunchApplication1 { get; set; };
        public string LaunchApplication2 { get; set; };
        public string Back_MediaNextTrack { get; set; };
        public string Back_MediaPreviousTrack { get; set; };
        public string Oem1 { get; set; };
        public string Oemplus { get; set; };
        public string Oemcomma { get; set; };
        public string OemMinus { get; set; };
        public string OemPeriod { get; set; };
        public string OemQuestion { get; set; };
        public string Oemtilde { get; set; };
        public string LButton_Oemtilde { get; set; };
        public string RButton_Oemtilde { get; set; };
        public string Cancel_Oemtilde { get; set; };
        public string MButton_Oemtilde { get; set; };
        public string XButton1_Oemtilde { get; set; };
        public string XButton2_Oemtilde { get; set; };
        public string LButton_XButton2_Oemtilde { get; set; };
        public string Back_Oemtilde { get; set; };
        public string Tab_Oemtilde { get; set; };
        public string LineFeed_Oemtilde { get; set; };
        public string LButton_LineFeed_Oemtilde { get; set; };
        public string Clear_Oemtilde { get; set; };
        public string Return_Oemtilde { get; set; };
        public string RButton_Clear_Oemtilde { get; set; };
        public string RButton_Return_Oemtilde { get; set; };
        public string ShiftKey_Oemtilde { get; set; };
        public string ControlKey_Oemtilde { get; set; };
        public string Menu_Oemtilde { get; set; };
        public string Pause_Oemtilde { get; set; };
        public string Capital_Oemtilde { get; set; };
        public string KanaMode_Oemtilde { get; set; };
        public string RButton_Capital_Oemtilde { get; set; };
        public string JunjaMode_Oemtilde { get; set; };
        public string FinalMode_Oemtilde { get; set; };
        public string HanjaMode_Oemtilde { get; set; };
        public string RButton_FinalMode_Oemtilde { get; set; };
        public string OemOpenBrackets { get; set; };
        public string Oem5 { get; set; };
        public string Oem6 { get; set; };
        public string Oem7 { get; set; };
        public string Oem8 { get; set; };
        public string Space_Oemtilde { get; set; };
        public string PageUp_Oemtilde { get; set; };
        public string OemBackslash { get; set; };
        public string LButton_OemBackslash { get; set; };
        public string Home_Oemtilde { get; set; };
        public string ProcessKey { get; set; };
        public string MButton_OemBackslash { get; set; };
        public string Packet { get; set; };
        public string Down_Oemtilde { get; set; };
        public string Select_Oemtilde { get; set; };
        public string Back_OemBackslash { get; set; };
        public string Tab_OemBackslash { get; set; };
        public string PrintScreen_Oemtilde { get; set; };
        public string Back_ProcessKey { get; set; };
        public string Clear_OemBackslash { get; set; };
        public string Back_Packet { get; set; };
        public string D0_Oemtilde { get; set; };
        public string D1_Oemtilde { get; set; };
        public string ShiftKey_OemBackslash { get; set; };
        public string ControlKey_OemBackslash { get; set; };
        public string D4_Oemtilde { get; set; };
        public string ShiftKey_ProcessKey { get; set; };
        public string Attn { get; set; };
        public string Crsel { get; set; };
        public string Exsel { get; set; };
        public string EraseEof { get; set; };
        public string Play { get; set; };
        public string Zoom { get; set; };
        public string NoName { get; set; };
        public string Pa1 { get; set; };
        public string OemClear { get; set; };
        public string LButton_OemClear { get; set; };
    }*/
}
