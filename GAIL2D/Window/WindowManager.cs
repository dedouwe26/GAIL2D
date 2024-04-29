using GAIL2D.Core;
using OxDED.Terminal.Logging;
using SFML.System;
using SFML.Window;

namespace GAIL2D.Window;

/// <summary>
/// Handles all stuff for the window.
/// </summary>
public class WindowManager : IManager {
    /// <summary>
    /// The logger corresponding to the window part of the application.
    /// </summary>
    public readonly Logger Logger;

    /// <summary>
    /// The SFML window, for custom usage.
    /// </summary>
    public SFML.Window.Window? Window { get; private set; }

    /// <summary>
    /// The clock that is keeping the time.
    /// </summary>
    public Clock? Clock { get; private set; }

    /// <summary>
    /// Creates a window manager.
    /// </summary>
    /// <param name="logger">The logger of this manager.</param>
    public WindowManager(Logger logger) {
        Logger = logger;
    }

    /// <summary>
    /// Initializes the window.
    /// </summary>
    public void Init(string windowName, uint width, uint height) {
        Window = new SFML.Window.Window(new VideoMode(width, height), windowName);
        Window.SetVerticalSyncEnabled(true);
        Clock = new();
    }

    /// <summary>
    /// Updates SFML and dispatches all events.
    /// </summary>
    public void Update() {
        Window!.DispatchEvents();
    }

    /// <summary>
    /// If the window is still open.
    /// </summary>
    public bool IsOpen { get { return Window!.IsOpen; } }

    /// <summary>
    /// Sets the size of the window, optionally maximized and/or minimized.
    /// </summary>
    /// <param name="width">The new width of the window (pixels).</param>
    /// <param name="height">The new height of the window (pixels).</param>
    public void SetWindowSize(uint width, uint height) {
        Window!.Size = new Vector2u(width, height);
    }

    /// <summary>
    /// Sets the window title to the given string.
    /// </summary>
    /// <param name="newTitle">The new title.</param>
    public void SetWindowTitle(string newTitle) {
        Window!.SetTitle(newTitle);
    }
    
    /// <summary>
    /// Sets the window icon to the given image.
    /// </summary>
    /// <remarks>
    /// Some recommended sizes include: 16x16, 32x32, 48x48.
    /// </remarks>
    /// <param name="newIcon">The new icon texture.</param>
    public void SetWindowIcon(Texture newIcon) {
        Window!.SetIcon(newIcon.Width, newIcon.Height, newIcon.);
    }

    /// <summary>
    /// The current time on the timer.
    /// </summary>
    public double Time { get { return Clock!.ElapsedTime.AsMicroseconds() * 0.000001; } }

    /// <inheritdoc/>
    public void Dispose() {
        
    }
}