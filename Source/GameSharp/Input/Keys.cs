using SDL_Keycode = SDL2.SDL.SDL_Keycode;

namespace  GameSharp
{
    public enum Keys
    {
        Unknown = SDL_Keycode.SDLK_UNKNOWN,

        Return = SDL_Keycode.SDLK_RETURN,
        Escape = SDL_Keycode.SDLK_ESCAPE,
        Backspace = SDL_Keycode.SDLK_BACKSPACE,
        Tab = SDL_Keycode.SDLK_TAB,
        Space = SDL_Keycode.SDLK_SPACE,
        Exclaim = SDL_Keycode.SDLK_EXCLAIM,
        Quotedbl = SDL_Keycode.SDLK_QUOTEDBL,
        Hash = SDL_Keycode.SDLK_HASH,
        Percent = SDL_Keycode.SDLK_PERCENT,
        Dollar = SDL_Keycode.SDLK_DOLLAR,
        Ampersand = SDL_Keycode.SDLK_AMPERSAND,
        Quote = SDL_Keycode.SDLK_QUOTE,
        Leftparen = SDL_Keycode.SDLK_LEFTPAREN,
        Rightparen = SDL_Keycode.SDLK_RIGHTPAREN,
        Asterisk = SDL_Keycode.SDLK_ASTERISK,
        Plus = SDL_Keycode.SDLK_PLUS,
        Comma = SDL_Keycode.SDLK_COMMA,
        Minus = SDL_Keycode.SDLK_MINUS,
        Period = SDL_Keycode.SDLK_PERIOD,
        Slash = SDL_Keycode.SDLK_SLASH,
        D0 = SDL_Keycode.SDLK_0,
        D1 = SDL_Keycode.SDLK_1,
        D2 = SDL_Keycode.SDLK_2,
        D3 = SDL_Keycode.SDLK_3,
        D4 = SDL_Keycode.SDLK_4,
        D5 = SDL_Keycode.SDLK_5,
        D6 = SDL_Keycode.SDLK_6,
        D7 = SDL_Keycode.SDLK_7,
        D8 = SDL_Keycode.SDLK_8,
        D9 = SDL_Keycode.SDLK_9,
        Colon = SDL_Keycode.SDLK_COLON,
        Semicolon = SDL_Keycode.SDLK_SEMICOLON,
        Less = SDL_Keycode.SDLK_LESS,
        Equals = SDL_Keycode.SDLK_EQUALS,
        Greater = SDL_Keycode.SDLK_GREATER,
        Question = SDL_Keycode.SDLK_QUESTION,
        At = SDL_Keycode.SDLK_AT,
        Leftbracket = SDL_Keycode.SDLK_LEFTBRACKET,
        Backslash = SDL_Keycode.SDLK_BACKSLASH,
        Rightbracket = SDL_Keycode.SDLK_RIGHTBRACKET,
        Caret = SDL_Keycode.SDLK_CARET,
        Underscore = SDL_Keycode.SDLK_UNDERSCORE,
        BACKQUOTE = SDL_Keycode.SDLK_BACKQUOTE,
        A = SDL_Keycode.SDLK_a,
        B = SDL_Keycode.SDLK_b,
        C = SDL_Keycode.SDLK_c,
        D = SDL_Keycode.SDLK_d,
        E = SDL_Keycode.SDLK_e,
        F = SDL_Keycode.SDLK_f,
        G = SDL_Keycode.SDLK_g,
        H = SDL_Keycode.SDLK_h,
        I = SDL_Keycode.SDLK_i,
        J = SDL_Keycode.SDLK_j,
        K = SDL_Keycode.SDLK_k,
        L = SDL_Keycode.SDLK_l,
        M = SDL_Keycode.SDLK_m,
        N = SDL_Keycode.SDLK_n,
        O = SDL_Keycode.SDLK_o,
        P = SDL_Keycode.SDLK_p,
        Q = SDL_Keycode.SDLK_q,
        R = SDL_Keycode.SDLK_r,
        S = SDL_Keycode.SDLK_s,
        T = SDL_Keycode.SDLK_t,
        U = SDL_Keycode.SDLK_u,
        V = SDL_Keycode.SDLK_v,
        W = SDL_Keycode.SDLK_w,
        X = SDL_Keycode.SDLK_x,
        Y = SDL_Keycode.SDLK_y,
        Z = SDL_Keycode.SDLK_z,

        Capslock = SDL_Keycode.SDLK_CAPSLOCK,

        F1 = SDL_Keycode.SDLK_F1,
        F2 = SDL_Keycode.SDLK_F2,
        F3 = SDL_Keycode.SDLK_F3,
        F4 = SDL_Keycode.SDLK_F4,
        F5 = SDL_Keycode.SDLK_F5,
        F6 = SDL_Keycode.SDLK_F6,
        F7 = SDL_Keycode.SDLK_F7,
        F8 = SDL_Keycode.SDLK_F8,
        F9 = SDL_Keycode.SDLK_F9,
        F10 = SDL_Keycode.SDLK_F10,
        F11 = SDL_Keycode.SDLK_F11,
        F12 = SDL_Keycode.SDLK_F12,

        Printscreen = SDL_Keycode.SDLK_PRINTSCREEN,
        Scrolllock = SDL_Keycode.SDLK_SCROLLLOCK,
        Pause = SDL_Keycode.SDLK_PAUSE,
        Insert = SDL_Keycode.SDLK_INSERT,
        Home = SDL_Keycode.SDLK_HOME,
        Pageup = SDL_Keycode.SDLK_PAGEUP,
        Delete = SDL_Keycode.SDLK_DELETE,
        End = SDL_Keycode.SDLK_END,
        Pagedown = SDL_Keycode.SDLK_PAGEDOWN,
        Right = SDL_Keycode.SDLK_RIGHT,
        Left = SDL_Keycode.SDLK_LEFT,
        Down = SDL_Keycode.SDLK_DOWN,
        UP = SDL_Keycode.SDLK_UP,

        Numlockclear = SDL_Keycode.SDLK_NUMLOCKCLEAR,
        KP_Divide = SDL_Keycode.SDLK_KP_DIVIDE,
        KP_Multiply = SDL_Keycode.SDLK_KP_MULTIPLY,
        KP_Minus = SDL_Keycode.SDLK_KP_MINUS,
        KP_Plus = SDL_Keycode.SDLK_KP_PLUS,
        KP_Enter = SDL_Keycode.SDLK_KP_ENTER,
        KP_1 = SDL_Keycode.SDLK_KP_1,
        KP_2 = SDL_Keycode.SDLK_KP_2,
        KP_3 = SDL_Keycode.SDLK_KP_3,
        KP_4 = SDL_Keycode.SDLK_KP_4,
        KP_5 = SDL_Keycode.SDLK_KP_5,
        KP_6 = SDL_Keycode.SDLK_KP_6,
        KP_7 = SDL_Keycode.SDLK_KP_7,
        KP_8 = SDL_Keycode.SDLK_KP_8,
        KP_9 = SDL_Keycode.SDLK_KP_9,
        KP_0 = SDL_Keycode.SDLK_KP_0,
        KP_Period = SDL_Keycode.SDLK_KP_PERIOD,

        Application = SDL_Keycode.SDLK_APPLICATION,
        Power = SDL_Keycode.SDLK_POWER,
        KP_Equals = SDL_Keycode.SDLK_KP_EQUALS,
        F13 = SDL_Keycode.SDLK_F13,
        F14 = SDL_Keycode.SDLK_F14,
        F15 = SDL_Keycode.SDLK_F15,
        F16 = SDL_Keycode.SDLK_F16,
        F17 = SDL_Keycode.SDLK_F17,
        F18 = SDL_Keycode.SDLK_F18,
        F19 = SDL_Keycode.SDLK_F19,
        F20 = SDL_Keycode.SDLK_F20,
        F21 = SDL_Keycode.SDLK_F21,
        F22 = SDL_Keycode.SDLK_F22,
        F23 = SDL_Keycode.SDLK_F23,
        F24 = SDL_Keycode.SDLK_F24,
        Execute = SDL_Keycode.SDLK_EXECUTE,
        Help = SDL_Keycode.SDLK_HELP,
        Menu = SDL_Keycode.SDLK_MENU,
        Select = SDL_Keycode.SDLK_SELECT,
        Stop = SDL_Keycode.SDLK_STOP,
        Again = SDL_Keycode.SDLK_AGAIN,
        Undo = SDL_Keycode.SDLK_UNDO,
        Cut = SDL_Keycode.SDLK_CUT,
        Copy = SDL_Keycode.SDLK_COPY,
        Paste = SDL_Keycode.SDLK_PASTE,
        Find = SDL_Keycode.SDLK_FIND,
        Mute = SDL_Keycode.SDLK_MUTE,
        Volumeup = SDL_Keycode.SDLK_VOLUMEUP,
        Volumedown = SDL_Keycode.SDLK_VOLUMEDOWN,
        KP_Comma = SDL_Keycode.SDLK_KP_COMMA,
        KP_Equalsas400 = SDL_Keycode.SDLK_KP_EQUALSAS400,

        Alterase = SDL_Keycode.SDLK_ALTERASE,
        Sysreq = SDL_Keycode.SDLK_SYSREQ,
        Cancel = SDL_Keycode.SDLK_CANCEL,
        Clear = SDL_Keycode.SDLK_CLEAR,
        Prior = SDL_Keycode.SDLK_PRIOR,
        Return2 = SDL_Keycode.SDLK_RETURN2,
        Separator = SDL_Keycode.SDLK_SEPARATOR,
        Out = SDL_Keycode.SDLK_OUT,
        Oper = SDL_Keycode.SDLK_OPER,
        Clearagain = SDL_Keycode.SDLK_CLEARAGAIN,
        Crsel = SDL_Keycode.SDLK_CRSEL,
        Exsel = SDL_Keycode.SDLK_EXSEL,

        KP_00 = SDL_Keycode.SDLK_KP_00,
        KP_000 = SDL_Keycode.SDLK_KP_000,
        Thousandsseparator = SDL_Keycode.SDLK_THOUSANDSSEPARATOR,
        Decimalseparator = SDL_Keycode.SDLK_DECIMALSEPARATOR,
        Currencyunit = SDL_Keycode.SDLK_CURRENCYUNIT,
        Currencysubunit = SDL_Keycode.SDLK_CURRENCYSUBUNIT,
        KP_Leftparen = SDL_Keycode.SDLK_KP_LEFTPAREN,
        KP_Rightparen = SDL_Keycode.SDLK_KP_RIGHTPAREN,
        KP_Leftbrace = SDL_Keycode.SDLK_KP_LEFTBRACE,
        KP_Rightbrace = SDL_Keycode.SDLK_KP_RIGHTBRACE,
        KP_Tab = SDL_Keycode.SDLK_KP_TAB,
        KP_Backspace = SDL_Keycode.SDLK_KP_BACKSPACE,
        KP_A = SDL_Keycode.SDLK_KP_A,
        KP_B = SDL_Keycode.SDLK_KP_B,
        KP_C = SDL_Keycode.SDLK_KP_C,
        KP_D = SDL_Keycode.SDLK_KP_D,
        KP_E = SDL_Keycode.SDLK_KP_E,
        KP_F = SDL_Keycode.SDLK_KP_F,
        KP_Xor = SDL_Keycode.SDLK_KP_XOR,
        KP_Power = SDL_Keycode.SDLK_KP_POWER,
        KP_Percent = SDL_Keycode.SDLK_KP_PERCENT,
        KP_Less = SDL_Keycode.SDLK_KP_LESS,
        KP_Greater = SDL_Keycode.SDLK_KP_GREATER,
        KP_Ampersand = SDL_Keycode.SDLK_KP_AMPERSAND,
        KP_Dblampersand = SDL_Keycode.SDLK_KP_DBLAMPERSAND,
        KP_Verticalbar = SDL_Keycode.SDLK_KP_VERTICALBAR,
        KP_Dblverticalbar = SDL_Keycode.SDLK_KP_DBLVERTICALBAR,
        KP_Colon = SDL_Keycode.SDLK_KP_COLON,
        KP_Hash = SDL_Keycode.SDLK_KP_HASH,
        KP_Space = SDL_Keycode.SDLK_KP_SPACE,
        KP_At = SDL_Keycode.SDLK_KP_AT,
        KP_Exclam = SDL_Keycode.SDLK_KP_EXCLAM,
        KP_Memstore = SDL_Keycode.SDLK_KP_MEMSTORE,
        KP_Memrecall = SDL_Keycode.SDLK_KP_MEMRECALL,
        KP_Memclear = SDL_Keycode.SDLK_KP_MEMCLEAR,
        KP_Memadd = SDL_Keycode.SDLK_KP_MEMADD,
        KP_Memsubtract = SDL_Keycode.SDLK_KP_MEMSUBTRACT,
        KP_Memmultiply = SDL_Keycode.SDLK_KP_MEMMULTIPLY,
        KP_Memdivide = SDL_Keycode.SDLK_KP_MEMDIVIDE,
        KP_Plusminus = SDL_Keycode.SDLK_KP_PLUSMINUS,
        KP_Clear = SDL_Keycode.SDLK_KP_CLEAR,
        KP_Clearentry = SDL_Keycode.SDLK_KP_CLEARENTRY,
        KP_Binary = SDL_Keycode.SDLK_KP_BINARY,
        KP_Octal = SDL_Keycode.SDLK_KP_OCTAL,
        KP_Decimal = SDL_Keycode.SDLK_KP_DECIMAL,
        KP_Hexadecimal = SDL_Keycode.SDLK_KP_HEXADECIMAL,

        LCtrl = SDL_Keycode.SDLK_LCTRL,
        LShift = SDL_Keycode.SDLK_LSHIFT,
        LAlt = SDL_Keycode.SDLK_LALT,
        LGui = SDL_Keycode.SDLK_LGUI,
        RCtrl = SDL_Keycode.SDLK_RCTRL,
        RShift = SDL_Keycode.SDLK_RSHIFT,
        RAlt = SDL_Keycode.SDLK_RALT,
        RGui = SDL_Keycode.SDLK_RGUI,

        Mode = SDL_Keycode.SDLK_MODE,

        Audionext = SDL_Keycode.SDLK_AUDIONEXT,
        Audioprev = SDL_Keycode.SDLK_AUDIOPREV,
        Audiostop = SDL_Keycode.SDLK_AUDIOSTOP,
        Audioplay = SDL_Keycode.SDLK_AUDIOPLAY,
        Audiomute = SDL_Keycode.SDLK_AUDIOMUTE,
        Mediaselect = SDL_Keycode.SDLK_MEDIASELECT,
        Www = SDL_Keycode.SDLK_WWW,
        Mail = SDL_Keycode.SDLK_MAIL,
        Calculator = SDL_Keycode.SDLK_CALCULATOR,
        Computer = SDL_Keycode.SDLK_COMPUTER,
        AC_Search = SDL_Keycode.SDLK_AC_SEARCH,
        AC_Home = SDL_Keycode.SDLK_AC_HOME,
        AC_Back = SDL_Keycode.SDLK_AC_BACK,
        AC_Forward = SDL_Keycode.SDLK_AC_FORWARD,
        AC_StoP = SDL_Keycode.SDLK_AC_STOP,
        AC_Refresh = SDL_Keycode.SDLK_AC_REFRESH,
        AC_Bookmarks = SDL_Keycode.SDLK_AC_BOOKMARKS,

        Brightnessdown = SDL_Keycode.SDLK_BRIGHTNESSDOWN,
        Brightnessup = SDL_Keycode.SDLK_BRIGHTNESSUP,
        Displayswitch = SDL_Keycode.SDLK_DISPLAYSWITCH,
        Kbdillumtoggle = SDL_Keycode.SDLK_KBDILLUMTOGGLE,
        Kbdillumdown = SDL_Keycode.SDLK_KBDILLUMDOWN,
        Kbdillumup = SDL_Keycode.SDLK_KBDILLUMUP,
        Eject = SDL_Keycode.SDLK_EJECT,
        Sleep = SDL_Keycode.SDLK_SLEEP 
    }
}