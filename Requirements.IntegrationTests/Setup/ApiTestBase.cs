using Requirements.IntegrationTests.Collections;
using Requirements.IntegrationTests.Fixtures;

namespace Requirements.IntegrationTests.Setup
{
    [Collection(nameof(ApiCollection))]
    public class ApiTestBase : RepositoryTestBase
    {
        public ApiTestBase(ApiFixture apiFixture, DatabaseFixture databaseFixture)
            : base(databaseFixture)
        {
            ApiFixture = apiFixture;
            Client = apiFixture.GetClient();
        }

        protected ApiFixture ApiFixture { get; }
        protected HttpClient Client { get; }
    }
}
