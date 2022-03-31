using GroupeIsa.Neos.Domain.Rules.EventRules;
using GroupeIsa.Neos.Domain.XUnit.Persistence;
using GroupeIsa.Neos.Domain.XUnit.Rules.EventRules;
using Xunit.Abstractions;

namespace UserVoice.Domain.XUnit.Rules
{
    /// <inheritdoc/>
    public abstract class SavedRuleTest<TSavedRule, TEntity> : SavedRuleTestBase<TSavedRule, TEntity>
        where TSavedRule : class, ISavedRule<TEntity>
        where TEntity : GroupeIsa.Neos.Domain.Entities.BusinessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedRuleTest{TSavedRule, TEntity}"/> class.
        /// </summary>
        /// <param name="output">Output.</param>
        protected SavedRuleTest(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <inheritdoc/>
        protected override EntityRepositoryResolverBase CreateEntityRepositoryResolver()
        {
            return new UserVoice.Domain.XUnit.Persistence.EntityRepositoryResolver();
        }
    }
}