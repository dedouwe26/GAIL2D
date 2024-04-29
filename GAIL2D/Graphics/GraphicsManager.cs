using OxDED.Terminal.Logging;

namespace GAIL2D.Graphics;

/// <summary>
/// Handles all stuff for the graphics.
/// </summary>
public class GraphicsManager : IManager {
    /// <summary>
    /// The logger corresponding to the graphics part of the application.
    /// </summary>
    public readonly Logger Logger;
    /// <summary>
    /// Creates a graphics manager.
    /// </summary>
    /// <param name="logger">The logger of this manager.</param>
    public GraphicsManager(Logger logger) {
        Logger = logger;
    }

    /// <summary>
    /// Initializes the graphics part of the application.
    /// </summary>
    public void Init() {
        
    }

    /// <inheritdoc/>
    public void Dispose() {
        
    }
}