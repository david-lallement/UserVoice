using GroupeIsa.Neos.AspNetCore;

namespace UserVoice.AspNetCore
{
    /// <summary>
    /// Represents the program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public static void Main(string[] args)
        {
            WebHost.Run<Startup>(args);
        }
    }
}