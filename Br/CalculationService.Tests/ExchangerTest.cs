using CalculationService;
using Xunit;
namespace CalculationService.Tests;

public class ExchangerTest
{
    [Fact]
    public void Convert_3372000WON_Success()
    {
        //Arange
        Exchanger exchanger = new();
        decimal input = 100000;
        string currency = "WON";
        //Act
        decimal result = exchanger.Convert(input, currency);
        //Assert
        decimal expectation = 3372000m;
        Assert.Equal(expectation, result);
    }
    [Fact]
    public void Convert_2800USD_Success()
    {
        //Arange
        Exchanger exchanger = new();
        decimal input = 100000;
        string currency = "USD";
        //Act
        decimal result = exchanger.Convert(input, currency);
        //Assert
        decimal expectation = 2800m;
        Assert.Equal(expectation, result);
    }
    [Fact]
    public void Convert_340000YEN_Success()
    {
        //Arange
        Exchanger exchanger = new();
        decimal input = 100000;
        string currency = "YEN";
        //Act
        decimal result = exchanger.Convert(input, currency);
        //Assert
        decimal expectation = 340000m;
        Assert.Equal(expectation, result);
    }
}