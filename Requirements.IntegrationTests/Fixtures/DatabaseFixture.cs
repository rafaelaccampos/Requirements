using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Requirements.Data;

namespace Requirements.IntegrationTests.Fixtures
{
    public class DatabaseFixture
    {
        protected static IServiceScope _scope;
        protected static RequirementContext _context;
        private readonly CustomWebApplicationFactory _customWebApplicationFactory;

        public DatabaseFixture()
        {
            _customWebApplicationFactory = new CustomWebApplicationFactory();
            _scope = _customWebApplicationFactory.Services.CreateScope();
            _context = _customWebApplicationFactory.Services.CreateScope().ServiceProvider.GetService<RequirementContext>()!;
        }

        public async Task EraseData()
        {
            var configuration = (IConfigurationRoot)_customWebApplicationFactory.Services.GetService(typeof(IConfiguration))!;
            var connectionString = configuration.GetConnectionString("Requirements");
            await DatabaseSetup.Reset(connectionString!);
        }

        public T GetService<T>() where T : class
        {
            return _scope.ServiceProvider.GetService<T>()!;
        }
    }
}
