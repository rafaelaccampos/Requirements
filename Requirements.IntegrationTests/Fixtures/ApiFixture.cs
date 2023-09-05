using Microsoft.Extensions.DependencyInjection;

namespace Requirements.IntegrationTests.Fixtures
{
    public class ApiFixture
    {
        private readonly CustomWebApplicationFactory _factory;

        public ApiFixture()
        {
            _factory = new CustomWebApplicationFactory();
        }

        public HttpClient GetClient()
        {
            return _factory.CreateClient();
        }

        public T Get<T>() where T : class
        {
            return _factory.Services.CreateScope().ServiceProvider.GetRequiredService<T>();
        }
    }
}
