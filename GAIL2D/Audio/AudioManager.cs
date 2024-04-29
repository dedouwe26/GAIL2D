using OxDED.Terminal.Logging;

namespace GAIL2D.Audio;

/// <summary>
/// Handles all stuff for the audio.
/// </summary>
public class AudioManager : IManager {
    /// <summary>
    /// The logger corresponding to the audio part of the application.
    /// </summary>
    public readonly Logger Logger;
    /// <summary>
    /// Creates an audio manager.
    /// </summary>
    /// <param name="logger">The logger of this manager.</param>
    public AudioManager(Logger logger) {
        Logger = logger;
    }

    /// <summary>
    /// Initializes the audio part of the application.
    /// </summary>
    public void Init() {
        
    }

    /// <inheritdoc/>
    public void Dispose() {
        
    }
}