using CalculationService;
using Xunit;
namespace CalculationService.Tests;

public class DevTest
{
    [Fact]
    public void Test1()
    {
        Dev dev = new Dev();
        int five = dev.GetFive();
        Assert.Equal(5, five);
    }
}