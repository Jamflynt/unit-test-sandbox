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
}