using Requirements.IntegrationTests.Fixtures;

namespace Requirements.IntegrationTests.Collections
{
    [CollectionDefinition(nameof(DatabaseCollection), DisableParallelization = true)]
    public class DatabaseCollection : ICollectionFixture<DatabaseFixture>
    {
    }
}
