using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace ExampleApi.UnitTests
{
    public class Tests
    {
        private TestHarness _testHarness;
        
        [SetUp]
        public void Setup()
        {
            _testHarness = new TestHarness();
        }

        [Test]
        public async Task WeatherReturnsCorrectly()
        {
            // Arrange
            var client = _testHarness.CreateClient();
            
            // Act
            var response = await client.GetAsync("WeatherForecast");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}