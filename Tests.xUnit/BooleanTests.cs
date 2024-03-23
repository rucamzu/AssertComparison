using Tested;

namespace Tests.xUnit;

public class BooleansTests
{
    [Fact]
    public void BooleansIsTrue() => Assert.True(Booleans.False);

    [Fact]
    public void BooleansIsFalse() => Assert.False(Booleans.True);

    [Fact]
    public void MethodReturnsTrue() => Assert.True(Booleans.Return(false));

    [Fact]
    public void MethodReturnsFalse() => Assert.False(Booleans.Return(true));
}