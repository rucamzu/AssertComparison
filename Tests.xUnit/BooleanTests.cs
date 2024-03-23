using Tested;

namespace Tests.xUnit;

public class BooleansTests
{
    [Fact]
    public void ValueIsTrue() => Assert.True(Booleans.Values.False);

    [Fact]
    public void ValueIsFalse() => Assert.False(Booleans.Values.True);

    [Fact]
    public void PropertyIsTrue() => Assert.True(Booleans.Properties.False);

    [Fact]
    public void PropertyIsFalse() => Assert.False(Booleans.Properties.True);

    [Fact]
    public void MethodReturnsTrue() => Assert.True(Booleans.Return(false));

    [Fact]
    public void MethodReturnsFalse() => Assert.False(Booleans.Return(true));

    [Fact]
    public void ExpressionEvaluatesToTrue() => Assert.True(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) > 1);

    [Fact]
    public void ExpressionEvaluatesToFalse() => Assert.False(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) < 2);
}