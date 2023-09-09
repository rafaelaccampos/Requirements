using Requirements.IntegrationTests.Fixtures;
using System.Net.Http.Json;

namespace Requirements.IntegrationTests.Specs.Controllers
{
    public class WeatherForecastControllerTests : ApiTestBase
    {
        public WeatherForecastControllerTests(ApiFixture apiFixture, DatabaseFixture databaseFixture)
            : base(apiFixture, databaseFixture)
        {
            
        }

        [Fact]
        public async Task GetShouldReturnArrayWithPredictions()
        {
            var response = await Client.GetFromJsonAsync<WeatherForecast[]>("weatherForecast");

            Assert.Equal(5, response!.Length);
        }
    }
}
