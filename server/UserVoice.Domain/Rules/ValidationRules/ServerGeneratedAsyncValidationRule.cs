using System;
using GroupeIsa.Neos.Domain.Entities;
using GroupeIsa.Neos.Domain.Rules.ValidationRules;
using UserVoice.Domain.Persistence;

namespace UserVoice.Domain.Rules.ValidationRules
{
    /// <inheritdoc/>
    public abstract class ServerGeneratedAsyncValidationRule<TEntity> : GeneratedAsyncValidationRule<TEntity>
        where TEntity : BusinessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerGeneratedAsyncValidationRule{TEntity}"/> class.
        /// </summary>
        /// <param name="serviceProvider">ServiceProvider.</param>
        protected ServerGeneratedAsyncValidationRule(IServiceProvider serviceProvider)
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