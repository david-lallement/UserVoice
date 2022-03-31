using System.Globalization;
using System.Resources;

namespace UserVoice.AspNetCore.Properties
{
    /// <summary>
    /// Represents the assembly resources.
    /// </summary>
    internal static class Resources
    {
        private static ResourceManager? _resourceManager;

        /// <summary>
        /// Gets ResourceManager.
        /// </summary>
        /// <value>
        /// ResourceManager.
        /// </value>
        internal static ResourceManager ResourceManager
        {
            get { if (_resourceManager == null)
{
    _resourceManager = new ResourceManager("UserVoice.AspNetCore.Properties.Resources", typeof(Resources).Assembly);
}

return _resourceManager; }
        }

        /// <summary>
        /// Gets a localized string similar to UserVoice.
        /// </summary>
        /// <value>
        /// a localized string similar to UserVoice.
        /// </value>
        internal static string Swagger_Title
        {
            get { return ResourceManager.GetString("Swagger_Title", CultureInfo.CurrentUICulture) ?? string.Empty; }
        }

        /// <summary>
        /// Gets a localized string similar to API UserVoice.
        /// </summary>
        /// <value>
        /// a localized string similar to API UserVoice.
        /// </value>
        internal static string Swagger_Description
        {
            get { return ResourceManager.GetString("Swagger_Description", CultureInfo.CurrentUICulture) ?? string.Empty; }
        }
    }
}