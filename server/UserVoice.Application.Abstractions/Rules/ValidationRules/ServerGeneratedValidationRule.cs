using System;
using GroupeIsa.Neos.Application;
using GroupeIsa.Neos.Application.Rules.ValidationRules;
using UserVoice.Application.Abstractions.Persistence;

namespace UserVoice.Application.Abstractions.Rules.ValidationRules
{
    /// <inheritdoc/>
    public abstract class ServerGeneratedValidationRule<TEntityView> : GeneratedValidationRule<TEntityView>
        where TEntityView : IEntityView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerGeneratedValidationRule{TEntityView}"/> class.
        /// </summary>
        /// <param name="serviceProvider">ServiceProvider.</param>
        protected ServerGeneratedValidationRule(IServiceProvider serviceProvider)
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