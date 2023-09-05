using Requirements.IntegrationTests.Fixtures;

namespace Requirements.IntegrationTests.Collections
{
    [CollectionDefinition(nameof(ApiCollection), DisableParallelization = true)]
    public class ApiCollection : 
        ICollectionFixture<ApiFixture>,
        ICollectionFixture<DatabaseFixture>
    {
    }
}
