using OxDED.Terminal.Logging;

namespace GAIL2D.Input;

/// <summary>
/// Handles all inputs.
/// </summary>
public class InputManager : IManager {
    /// <summary>
    /// The logger corresponding to the input part of the application.
    /// </summary>
    public readonly Logger Logger;
    /// <summary>
    /// Creates an input manager.
    /// </summary>
    /// <param name="logger">The logger of this manager.</param>
    public InputManager(Logger logger) {
        Logger = logger;
    }

    /// <summary>
    /// Initializes all the inputs.
    /// </summary>
    public void Init() {
        
    }

    /// <inheritdoc/>
    public void Dispose() {
        
    }
}