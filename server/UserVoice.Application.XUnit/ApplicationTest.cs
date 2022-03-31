using GroupeIsa.Neos.Application.XUnit;
using GroupeIsa.Neos.Application.XUnit.Persistence;
using GroupeIsa.Neos.Domain.XUnit.Persistence;
using Xunit.Abstractions;

namespace UserVoice.Application.XUnit
{
    /// <inheritdoc/>
    public abstract class ApplicationTest : ApplicationTestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationTest"/> class.
        /// </summary>
        /// <param name="output">Output.</param>
        protected ApplicationTest(ITestOutputHelper output)
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