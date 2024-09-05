using CalculationService;
using Xunit;
namespace CalculationService.Tests;

public class CarTest
{
    [Fact]
    public void CalculateDistance_123KM_Success()
    {
        Car car = new Car();
        int result = car.CalculateDistance(10);
        Assert.Equal(123, result);
    }
    [Fact]
    public void CalculateDistance_0KM_Success()
    {
        Car car = new Car();
        int result = car.CalculateDistance(0);
        Assert.Equal(0, result);
    }

}