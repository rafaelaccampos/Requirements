using Requirements.Data;
using Requirements.IntegrationTests.Collections;
using Requirements.IntegrationTests.Fixtures;

namespace Requirements.IntegrationTests.Setup
{
    [Collection(nameof(DatabaseCollection))]
    public class RepositoryTestBase
    {
        private readonly DatabaseFixture _databaseFixture;

        public RepositoryTestBase(DatabaseFixture databaseFixture)
        {
            _databaseFixture = databaseFixture;
            RequirementContext = _databaseFixture.GetService<RequirementContext>();
        }

        protected RequirementContext RequirementContext { get; }
    }
}
