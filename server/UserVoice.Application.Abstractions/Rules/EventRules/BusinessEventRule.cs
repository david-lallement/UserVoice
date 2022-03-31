using System;
using GroupeIsa.Neos.Application.Rules.EventRules;
using UserVoice.Application.Abstractions.Persistence;

namespace UserVoice.Application.Abstractions.Rules.EventRules
{
    /// <inheritdoc/>
    public abstract class BusinessEventRule : EventRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessEventRule"/> class.
        /// </summary>
        /// <param name="serviceProvider">ServiceProvider.</param>
        protected BusinessEventRule(IServiceProvider serviceProvider)
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