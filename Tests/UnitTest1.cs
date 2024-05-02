using Xunit;
using static Tests.Calculator;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2, 2));
    }
    
    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(2, 2));
    }
    
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(3, 3, 6)]
    [InlineData(2, 2, 5)]
    public void MyTheory(int x, int y, int sum)
    {
        Assert.Equal(sum, Calculator.Add(x, y));
    }
}