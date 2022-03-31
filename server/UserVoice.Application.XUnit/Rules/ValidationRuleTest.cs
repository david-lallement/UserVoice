using GroupeIsa.Neos.Application.Rules.ValidationRules;
using GroupeIsa.Neos.Application.XUnit.Persistence;
using GroupeIsa.Neos.Application.XUnit.Rules.ValidationRules;
using GroupeIsa.Neos.Domain.XUnit.Persistence;
using Xunit.Abstractions;

namespace UserVoice.Application.XUnit.Rules
{
    /// <inheritdoc/>
    public abstract class ValidationRuleTest<TValidationRule, TEntityView> : ValidationRuleTestBase<TValidationRule, TEntityView>
        where TValidationRule : class, IValidationRule<TEntityView>
        where TEntityView : class, GroupeIsa.Neos.Application.IEntityView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationRuleTest{TValidationRule, TEntityView}"/> class.
        /// </summary>
        /// <param name="output">Output.</param>
        protected ValidationRuleTest(ITestOutputHelper output)
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