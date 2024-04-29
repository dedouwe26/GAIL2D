namespace GAIL2D.Audio;
    /// <summary>
    /// Reads audio from a microphone or sound output.
    /// </summary>
    public class SoundCapture : IDisposable {

        /// <summary>
        /// the sample rate of this sound capture.
        /// </summary>
        public readonly uint sampleRate;
        /// <summary>
        /// The format of this sound capture.
        /// </summary>
        public readonly SoundFormat format;
        /// <summary>
        /// All the already captured sound waves.
        /// </summary>
        byte[] buffer = [];

        /// <summary>
        /// Gets all the capture devices' names.
        /// </summary>
        /// <returns>A list of all the capture devices.</returns>
        public static List<string> GetCaptureDevices() {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Creates a new sound capture.
        /// </summary>
        /// <param name="format">The format in which to capture the sound.</param>
        /// <param name="sampleRate">The sample rate in which to capture the sound.</param>
        /// <param name="deviceName">Which capture device to use (get name at <see cref="GetCaptureDevices"/> <b>OR pass an empty string for the default</b>).</param>
        public SoundCapture(SoundFormat format, uint sampleRate, string deviceName) {
            
            this.format = format;
            this.sampleRate = sampleRate;

        }
        /// <summary></summary>
        ~SoundCapture() {
            Dispose();
        }
        /// <summary>
        /// Closes all the OpenAL devices
        /// </summary>
        /// <inheritdoc/>
        public void Dispose() {
            buffer = [];
            
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Starts capturing the audio.
        /// </summary>
        public void Start() {
            
        }
        /// <summary>
        /// The enum for capturing buffer
        /// </summary>
        public enum BufferFormat { }
        /// <summary>
        /// Stores all the already captured data into the buffer.
        /// </summary>
        /// <returns>The last captured wave.</returns>
        public byte Capture() {
            
            return buffer[^1];
        }

        /// <summary>
        /// Stops capturing the audio and returns the whole sound (including previous captures).
        /// </summary>
        /// <returns>The captured sound.</returns>
        public Sound Stop() {
            
            return new Sound((int)sampleRate, format, [.. buffer]);
        }
    }