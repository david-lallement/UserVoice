using GroupeIsa.Neos.Domain.Rules.ValidationRules;
using GroupeIsa.Neos.Domain.XUnit.Persistence;
using GroupeIsa.Neos.Domain.XUnit.Rules.ValidationRules;
using Xunit.Abstractions;

namespace UserVoice.Domain.XUnit.Rules
{
    /// <inheritdoc/>
    public abstract class ValidationRuleTest<TValidationRule, TEntity> : ValidationRuleTestBase<TValidationRule, TEntity>
        where TValidationRule : class, IValidationRule<TEntity>
        where TEntity : GroupeIsa.Neos.Domain.Entities.BusinessEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationRuleTest{TValidationRule, TEntity}"/> class.
        /// </summary>
        /// <param name="output">Output.</param>
        protected ValidationRuleTest(ITestOutputHelper output)
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