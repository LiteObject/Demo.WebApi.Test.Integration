namespace Demo.WebApi.IntegrationTest
{
    using Demo.WebApi.SUT;
    using Microsoft.AspNetCore.Mvc.Testing;
    using System;
    using System.Threading.Tasks;
    using Xunit;

    public class WeatherForecastControllerTest
        : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public WeatherForecastControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldReturn200OkAsync() 
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/WeatherForecast");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
        }
    }
}
