using System;
using GroupeIsa.Neos.Domain.Entities;
using GroupeIsa.Neos.Domain.Rules.ValidationRules;
using UserVoice.Domain.Persistence;

namespace UserVoice.Domain.Rules.ValidationRules
{
    /// <inheritdoc/>
    public abstract class ServerGeneratedValidationRule<TEntity> : GeneratedValidationRule<TEntity>
        where TEntity : BusinessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerGeneratedValidationRule{TEntity}"/> class.
        /// </summary>
        /// <param name="serviceProvider">ServiceProvider.</param>
        protected ServerGeneratedValidationRule(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        /// <summary>
        /// Gets EntityRepositories.
        /// </summary>
        /// <value>
        /// EntityRepositories.
        /// </value>
        public IEntityRepositories EntityRepositories
        {
            get { return GetService<IEntityRepositories>(); }
        }
    }
}