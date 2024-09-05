using CalculationService;
using Xunit;
namespace CalculationService.Tests;

public class TreeTest
{
    [Fact]
    public void BuildTree_4Rows_Success()
    {
        //Arange
        Tree tree = new();
        int input = 4;
        //Act
        string result = tree.BuildTree(input);
        //Assert
        string expectation = @"   *
  ***
 *****
   *
  ***";
        Assert.Equal(expectation, result);
    }

    [Fact]
    public void BuildTree_5Rows_Success()
    {
        //Arange
        Tree tree = new();
        int input = 5;
        //Act
        string result = tree.BuildTree(input);
        //Assert
        string expectation = @"    *
   ***
  *****
 *******
    *
   ***";
        Assert.Equal(expectation, result);
    }
    [Fact]
    public void BuildTree_6Rows_Success()
    {
        //Arange
        Tree tree = new();
        int input = 6;
        //Act
        string result = tree.BuildTree(input);
        //Assert
        string expectation = @"     *
    ***
   *****
  *******
 *********
     *
    ***";
        Assert.Equal(expectation, result);
    }


}