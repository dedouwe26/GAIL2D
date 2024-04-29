using SFML.Window;

namespace GAIL2D.Input;
/// <summary>
/// A key on a keyboard or mouse.
/// </summary>
public enum Key {
    /// <summary>
    /// A key that is not known to GLFW.
    /// </summary>
    Unknown = Keyboard.Key.Unknown,
    ///
    A = Keyboard.Key.A,
    ///
    B = Keyboard.Key.B,
    ///
    C = Keyboard.Key.C,
    ///
    D = Keyboard.Key.D,
    ///
    E = Keyboard.Key.E,
    ///
    F = Keyboard.Key.F,
    ///
    G = Keyboard.Key.G,
    ///
    H = Keyboard.Key.H,
    ///
    I = Keyboard.Key.I,
    ///
    J = Keyboard.Key.J,
    ///
    K = Keyboard.Key.K,
    ///
    L = Keyboard.Key.L,
    ///
    M = Keyboard.Key.M,
    ///
    N = Keyboard.Key.N,
    ///
    O = Keyboard.Key.O,
    ///
    P = Keyboard.Key.P,
    ///
    Q = Keyboard.Key.Q,
    ///
    R = Keyboard.Key.R,
    ///
    S = Keyboard.Key.S,
    ///
    T = Keyboard.Key.T,
    ///
    U = Keyboard.Key.U,
    ///
    V = Keyboard.Key.V,
    ///
    W = Keyboard.Key.W,
    ///
    X = Keyboard.Key.X,
    ///
    Y = Keyboard.Key.Y,
    ///
    Z = Keyboard.Key.Z,
    /// <summary>
    /// AKA esc
    /// </summary>
    Escape = Keyboard.Key.Escape,
    ///
    F1 = Keyboard.Key.F1,
    ///
    F2 = Keyboard.Key.F2,
    ///
    F3 = Keyboard.Key.F3,
    ///
    F4 = Keyboard.Key.F4,
    ///
    F5 = Keyboard.Key.F5,
    ///
    F6 = Keyboard.Key.F6,
    ///
    F7 = Keyboard.Key.F7,
    ///
    F8 = Keyboard.Key.F8,
    ///
    F9 = Keyboard.Key.F9,
    ///
    F10 = Keyboard.Key.F10,
    ///
    F11 = Keyboard.Key.F11,
    ///
    F12 = Keyboard.Key.F12,
    ///
    F13 = Keyboard.Key.F13, 
    ///
    F14 = Keyboard.Key.F14,
    ///
    F15 = Keyboard.Key.F15,
    /// <summary>
    /// Pause Break
    /// </summary>
    Pause = Keyboard.Key.Pause,
    /// <summary>
    /// (`) (~)
    /// </summary>
    GraveAccent = Keyboard.Key.Tilde,
    ///
    Num1 = Keyboard.Key.Num1,
    ///
    Num2 = Keyboard.Key.Num2,
    ///
    Num3 = Keyboard.Key.Num3,
    ///
    Num4 = Keyboard.Key.Num4,
    ///
    Num5 = Keyboard.Key.Num5,
    ///
    Num6 = Keyboard.Key.Num6,
    ///
    Num7 = Keyboard.Key.Num7,
    ///
    Num8 = Keyboard.Key.Num8,
    ///
    Num9 = Keyboard.Key.Num9,
    ///
    Num0 = Keyboard.Key.Num0,
    /// <summary>
    /// (-)
    /// </summary>
    Minus = Keyboard.Key.Hyphen,
    /// <summary>
    /// (=)
    /// </summary>
    Equals = Keyboard.Key.Equal,
    ///
    Backspace = Keyboard.Key.Backspace, 
    ///
    Tab = Keyboard.Key.Tab,
    /// <summary>
    /// ([)
    /// </summary>
    LeftBracket = Keyboard.Key.LBracket,
    /// <summary>
    /// (])
    /// </summary>
    RightBracket = Keyboard.Key.RBracket,
    /// (\)
    Backslash = Keyboard.Key.Backslash,
    /// <summary>
    /// (;)
    /// </summary>
    Semicolon = Keyboard.Key.Semicolon,
    /// <summary>
    /// (')
    /// </summary>
    Apostrophe = Keyboard.Key.Quote,
    /// <summary>
    /// AKA return.
    /// </summary>
    Enter = Keyboard.Key.Enter,
    ///
    LeftShift = Keyboard.Key.LShift,
    ///
    Comma = Keyboard.Key.Comma,
    ///
    Period = Keyboard.Key.Period,
    ///
    Slash = Keyboard.Key.Slash,
    ///
    RightShift = Keyboard.Key.RShift,
    /// <summary>
    /// AKA ctrl.
    /// </summary>
    LeftControl = Keyboard.Key.LControl,
    ///
    LeftAlt = Keyboard.Key.LAlt,
    ///
    Space = Keyboard.Key.Space,
    ///
    RightAlt = Keyboard.Key.RAlt,
    /// <summary>
    /// or context menu key.
    /// </summary>
    Menu = Keyboard.Key.Menu,
    /// <summary>
    /// AKA ctrl.
    /// </summary>
    RightControl = Keyboard.Key.RControl,
    /// <summary>
    /// like left Windows key.
    /// </summary>
    LeftSuper = Keyboard.Key.LSystem,
    /// <summary>
    /// like right Windows key.
    /// </summary>
    RightSuper = Keyboard.Key.RSystem,
    ///
    Insert = Keyboard.Key.Insert,
    ///
    Home = Keyboard.Key.Home,
    ///
    PageUp = Keyboard.Key.PageUp,
    ///
    PageDown = Keyboard.Key.PageDown,
    ///
    Delete = Keyboard.Key.Delete,
    ///
    End = Keyboard.Key.End,
    ///
    ArrowUp = Keyboard.Key.Up,
    ///
    ArrowLeft = Keyboard.Key.Left,
    ///
    ArrowDown = Keyboard.Key.Down,
    ///
    ArrowRight = Keyboard.Key.Right,
    /// <summary>
    /// (/)
    /// </summary>
    NumpadDivide = Keyboard.Key.Divide,
    /// <summary>
    /// (*)
    /// </summary>
    NumpadMultiply = Keyboard.Key.Multiply,
    /// <summary>
    /// (-)
    /// </summary>
    NumpadSubstract = Keyboard.Key.Subtract,
    /// <summary>
    /// Numpad 0
    /// </summary>
    Numpad0 = Keyboard.Key.Numpad0,
    /// <summary>
    /// Numpad 1
    /// </summary>
    Numpad1 = Keyboard.Key.Numpad1,
    /// <summary>
    /// Numpad 2
    /// </summary>
    Numpad2 = Keyboard.Key.Numpad2,
    /// <summary>
    /// Numpad 3
    /// </summary>
    Numpad3 = Keyboard.Key.Numpad3,
    /// <summary>
    /// Numpad 4
    /// </summary>
    Numpad4 = Keyboard.Key.Numpad4,
    /// <summary>
    /// Numpad 5
    /// </summary>
    Numpad5 = Keyboard.Key.Numpad5,
    /// <summary>
    /// Numpad 6
    /// </summary>
    Numpad6 = Keyboard.Key.Numpad6,
    /// <summary>
    /// Numpad 7
    /// </summary>
    Numpad7 = Keyboard.Key.Numpad7,
    /// <summary>
    /// Numpad 8
    /// </summary>
    Numpad8 = Keyboard.Key.Numpad8,
    /// <summary>
    /// Numpad 9
    /// </summary>
    Numpad9 = Keyboard.Key.Numpad9,
    /// <summary>
    /// (+)
    /// </summary>
    NumpadAdd = Keyboard.Key.Add
}
/// <summary>
/// Represents the mouse buttons.
/// </summary>
public enum MouseButton {
    /// <summary>
    /// AKA Mouse1
    /// </summary>
    Left = Mouse.Button.Left, 
    /// <summary>
    /// AKA Mouse2
    /// </summary>
    Right = Mouse.Button.Right,
    /// <summary>
    /// Mouse wheel button, AKA Mouse3
    /// </summary>
    Middle = Mouse.Button.Middle,
    ///
    Mouse4 = Mouse.Button.XButton1,
    ///
    Mouse5 = Mouse.Button.XButton2
}