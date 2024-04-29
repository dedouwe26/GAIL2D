using GAIL2D.Audio;
using GAIL2D.Graphics;
using GAIL2D.Input;
using GAIL2D.Window;
using OxDED.Terminal;
using OxDED.Terminal.Logging;

namespace GAIL2D;

/// <summary>
/// The central part of GAIL2D. Includes all the Managers.
/// </summary>
public class Application : IDisposable {
    /// <summary>
    /// Stores all the managers for other managers.
    /// </summary>
    public struct Globals {
        /// <summary>
        /// The graphics manager for this application.
        /// </summary>
        public GraphicsManager graphicsManager;
        /// <summary>
        /// The audio manager for this application.
        /// </summary>
        public AudioManager audioManager;
        /// <summary>
        /// The input manager for this application.
        /// </summary>
        public InputManager inputManager;
        /// <summary>
        /// The window manager for this application.
        /// </summary>
        public WindowManager windowManager;
        /// <summary>
        /// The main logger for this application.
        /// </summary>
        public Logger logger;
    }

    /// <summary>
    /// The Globals of this Application, contains all the managers.
    /// </summary>
    public readonly Globals globals;
    /// <summary>
    /// The manager for the graphics.
    /// </summary>
    public GraphicsManager GraphicsManager {get {return globals.graphicsManager;}}
    /// <summary>
    /// The manager for the audio.
    /// </summary>
    public AudioManager AudioManager {get {return globals.audioManager;}}
    /// <summary>
    /// The manager for the input.
    /// </summary>
    public InputManager InputManager {get {return globals.inputManager;}}
    /// <summary>
    /// The manager for the window.
    /// </summary>
    public WindowManager WindowManager {get {return globals.windowManager;}}
    /// <summary>
    /// The logger of this application.
    /// </summary>
    public Logger Logger {get {return globals.logger;}}

    /// <summary>
    /// The update event (calls every frame).
    /// </summary>
    public event UpdateCallback? OnUpdate;
    /// <summary>
    /// The load event (calls at the start).
    /// </summary>
    public event LoadCallback? OnLoad;
    /// <summary>
    /// The stop event (calls at disposal).
    /// </summary>
    public event StopCallback? OnStop;

    /// <summary>
    /// Creates a GAIL2D application
    /// </summary>
    /// <param name="windowName">The name of the window (also used for the <paramref name="loggerID"/>).</param>
    /// <param name="width">The width of the window (in pixels).</param>
    /// <param name="height">The height of the window (in pixels).</param>
    /// <param name="loggerID">The ID for the logger (default: GAIL2D.App.{windowName replace ' ' with '_'}).</param>
    /// <param name="logLevel">The log level of all the loggers in this application (default: Info).</param>
    /// <param name="logTargets">All the log targets for all the loggers in this application (default: TerminalTarget).</param>
    public Application(string windowName = "GAIL2D Window", int width = 1000, int height = 600, string? loggerID = null, Severity logLevel = Severity.Info, Dictionary<Type, ITarget>? logTargets = null) {
        globals = new() {
            logger = new Logger(loggerID??"GAIL2D.App."+windowName.Replace(' ', '_'), "GAIL2D", logLevel, logTargets??new(){[typeof(TerminalTarget)] = new TerminalTarget()})
        };
        if (globals.logger.HasTarget<TerminalTarget>()) {
            globals.logger.GetTarget<TerminalTarget>().Format = "<{0}>: ("+Color.DarkBlue.ToForegroundANSI()+"{2}"+ANSI.Styles.ResetAll+")[{5}"+ANSI.Styles.Bold+"{3}"+ANSI.Styles.ResetAll+"] : {5}{4}"+ANSI.Styles.ResetAll;
            globals.logger.GetTarget<TerminalTarget>().NameFormat =  "{0} - {1}";
        }
        if (globals.logger.HasTarget<FileTarget>()) {
            globals.logger.GetTarget<FileTarget>().Format = "<{0}>: ({2})[{3}] : {4}";
            globals.logger.GetTarget<FileTarget>().NameFormat =  "{0} - {1}";
        }

        globals.logger.LogDebug("Initialising all managers.");

        globals.windowManager = new WindowManager(globals.logger.CreateSubLogger("Window", "Window", logLevel));
        globals.windowManager.Init();

        globals.inputManager = new InputManager(globals.logger.CreateSubLogger("Input", "Input", logLevel));
        globals.inputManager.Init();

        globals.graphicsManager = new GraphicsManager(globals.logger.CreateSubLogger("Graphics", "Graphics", logLevel));
        globals.graphicsManager.Init();

        globals.audioManager = new AudioManager(globals.logger.CreateSubLogger("Audio", "Audio", logLevel));
        globals.audioManager.Init();
    }
    /// <summary>
    /// Stops this application.
    /// </summary>
    ~Application() {
        Dispose();
    }
    /// <summary>
    /// Starts the application, use after subscribing on events.
    /// </summary>
    public void Start() {
        Logger.LogInfo("Starting...");
        OnLoad?.Invoke(this);

        double CurrentTime = 0;
        double lastTime = CurrentTime;
        // TODO: main loop.

        Dispose();
    }
    /// <summary>
    /// Stops the application (see: <see cref="Dispose"/>).
    /// </summary>
    public void Stop() {
        Dispose();
    }

    /// <inheritdoc/>
    /// <remarks>Stops the program (don't use this application after disposal).</remarks>
    public void Dispose() {
        Logger.LogInfo("Stopping...");
        OnStop?.Invoke(this);
        globals.audioManager.Dispose();
        globals.graphicsManager.Dispose();
        globals.inputManager.Dispose();
        globals.windowManager.Dispose();
        GC.SuppressFinalize(this);
    }
}