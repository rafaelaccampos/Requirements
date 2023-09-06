using Requirements.Data;
using Requirements.IntegrationTests.Collections;
using Requirements.IntegrationTests.Fixtures;

namespace Requirements.IntegrationTests.Setup
{
    [Collection(nameof(DatabaseCollection))]
    public class RepositoryTestBase : IAsyncLifetime
    {
        private readonly DatabaseFixture _databaseFixture;

        public RepositoryTestBase(DatabaseFixture databaseFixture)
        {
            _databaseFixture = databaseFixture;
            RequirementContext = _databaseFixture.GetService<RequirementContext>();
        }

        protected RequirementContext RequirementContext { get; }

        public async Task InitializeAsync()
        {
            await _databaseFixture.EraseData();
        }

        public async Task DisposeAsync()
        {
            await RequirementContext.DisposeAsync();
        }
    }
}
