
using Xunit;
using DemoApi.Models;

namespace DemoApi.Tests;

public class WeatherTests
{
    [Fact]
    public void TemperatureF_ComputedCorrectly()
    {
        var forecast = new WeatherForecast { TemperatureC = 0 };
        Assert.Equal(32, forecast.TemperatureF);
    }
}
