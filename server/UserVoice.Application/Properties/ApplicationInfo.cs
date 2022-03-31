using GroupeIsa.Neos.Application;

namespace UserVoice.Application.Properties
{
    /// <summary>
    /// Represents the informations of the application.
    /// </summary>
    public class ApplicationInfo : IApplicationInfo
    {
        /// <summary>
        /// Gets RootNamespace.
        /// </summary>
        /// <value>
        /// RootNamespace.
        /// </value>
        public string RootNamespace
        {
            get { return "UserVoice"; }
        }

        /// <summary>
        /// Gets ClusterName.
        /// </summary>
        /// <value>
        /// ClusterName.
        /// </value>
        public string ClusterName
        {
            get { return "UserVoice"; }
        }

        /// <summary>
        /// Gets ClusterVersion.
        /// </summary>
        /// <value>
        /// ClusterVersion.
        /// </value>
        public string ClusterVersion
        {
            get { return "0.0.1"; }
        }

        /// <summary>
        /// Gets ClusterTitle.
        /// </summary>
        /// <value>
        /// ClusterTitle.
        /// </value>
        public string ClusterTitle
        {
            get { return "UserVoice"; }
        }

        /// <summary>
        /// Gets Company.
        /// </summary>
        /// <value>
        /// Company.
        /// </value>
        public string Company
        {
            get { return "Groupe Isagri Services"; }
        }
    }
}