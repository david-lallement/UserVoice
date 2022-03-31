using System;
using GroupeIsa.Neos.Application.Abstractions.Methods;
using UserVoice.Application.Abstractions.Persistence;

namespace UserVoice.Application.Abstractions.Methods
{
    /// <inheritdoc/>
    public abstract class BusinessMethod : Method
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessMethod"/> class.
        /// </summary>
        /// <param name="serviceProvider">ServiceProvider.</param>
        protected BusinessMethod(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        /// <summary>
        /// Gets EntityViewRepositories.
        /// </summary>
        /// <value>
        /// EntityViewRepositories.
        /// </value>
        public IEntityViewRepositories EntityViewRepositories
        {
            get { return GetService<IEntityViewRepositories>(); }
        }
    }
}