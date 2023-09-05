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

        public T GetService<T>() where T : class
        {
            return _scope.ServiceProvider.GetService<T>()!;
        }
    }
}
