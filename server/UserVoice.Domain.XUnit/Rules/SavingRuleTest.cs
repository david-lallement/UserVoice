using GroupeIsa.Neos.Domain.Rules.EventRules;
using GroupeIsa.Neos.Domain.XUnit.Persistence;
using GroupeIsa.Neos.Domain.XUnit.Rules.EventRules;
using Xunit.Abstractions;

namespace UserVoice.Domain.XUnit.Rules
{
    /// <inheritdoc/>
    public abstract class SavingRuleTest<TSavingRule, TEntity> : SavingRuleTestBase<TSavingRule, TEntity>
        where TSavingRule : class, ISavingRule<TEntity>
        where TEntity : GroupeIsa.Neos.Domain.Entities.BusinessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavingRuleTest{TSavingRule, TEntity}"/> class.
        /// </summary>
        /// <param name="output">Output.</param>
        protected SavingRuleTest(ITestOutputHelper output)
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