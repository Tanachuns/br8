using CalculationService;
using Xunit;
namespace CalculationService.Tests;

public class CarTest
{
    [Fact]
    public void CalculateDistance_123KM_Success()
    {
        //Arange
        Car car = new Car();
        int input = 10;
        //Act
        int result = car.CalculateDistance(input);
        //Assert
        int expectation = 123;
        Assert.Equal(expectation, result);
    }
    [Fact]
    public void CalculateDistance_0KM_Success()
    {
        //Arange
        Car car = new Car();
        int input = 0;
        //Act
        int result = car.CalculateDistance(input);
        //Assert
        int expectation = 0;
        Assert.Equal(expectation, result);
    }
    [Fact]
    public void CalculateDistance_NegativeKM_Success()
    {
        //Arange
        Car car = new Car();
        int input = -5;
        //Act
        int result = car.CalculateDistance(input);
        //Assert
        int expectation = -61;
        Assert.Equal(expectation, result);
    }

}