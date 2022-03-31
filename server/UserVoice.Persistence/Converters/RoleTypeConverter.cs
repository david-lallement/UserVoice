using System.Collections.Generic;

namespace UserVoice.Persistence.Converters
{
    /// <summary>
    /// Represents RoleType.
    /// </summary>
    public class RoleTypeConverter : GroupeIsa.Neos.Persistence.Yaml.Converters.EnumToStringConverter<UserVoice.Domain.Enums.RoleType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleTypeConverter"/> class.
        /// </summary>
        private RoleTypeConverter()
            : base(new Dictionary<string, UserVoice.Domain.Enums.RoleType>() { ["C"] = UserVoice.Domain.Enums.RoleType.Client, ["A"] = UserVoice.Domain.Enums.RoleType.Administrator })
        {
        }

        /// <summary>
        /// Gets Instance.
        /// </summary>
        /// <value>
        /// Instance.
        /// </value>
        public static RoleTypeConverter Instance { get; } = new();
    }
}