namespace UserVoice.Persistence
{
    /// <summary>
    /// Represents the persistence parameters.
    /// </summary>
    public class PersistenceSettings
    {
        /// <summary>
        /// Gets or sets the yaml data files path.
        /// </summary>
        /// <value>
        /// the yaml data files path.
        /// </value>
        public string YamlDataPath { get; set; } = string.Empty;
    }
}