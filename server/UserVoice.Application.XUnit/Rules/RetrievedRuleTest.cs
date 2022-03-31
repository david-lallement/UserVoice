using GroupeIsa.Neos.Application.Rules.EventRules;
using GroupeIsa.Neos.Application.XUnit.Persistence;
using GroupeIsa.Neos.Application.XUnit.Rules.EventRules;
using GroupeIsa.Neos.Domain.XUnit.Persistence;
using Xunit.Abstractions;

namespace UserVoice.Application.XUnit.Rules
{
    /// <inheritdoc/>
    public abstract class RetrievedRuleTest<TRetrievedRule, TEntityView> : RetrievedRuleTestBase<TRetrievedRule, TEntityView>
        where TRetrievedRule : class, IRetrievedRule<TEntityView>
        where TEntityView : class, GroupeIsa.Neos.Application.IEntityView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievedRuleTest{TRetrievedRule, TEntityView}"/> class.
        /// </summary>
        /// <param name="output">Output.</param>
        protected RetrievedRuleTest(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <inheritdoc/>
        protected override EntityViewRepositoryResolverBase CreateEntityViewRepositoryResolver()
        {
            return new UserVoice.Application.XUnit.Persistence.EntityViewRepositoryResolver();
        }

        /// <inheritdoc/>
        protected override EntityRepositoryResolverBase CreateEntityRepositoryResolver()
        {
            return new UserVoice.Domain.XUnit.Persistence.EntityRepositoryResolver();
        }
    }
}