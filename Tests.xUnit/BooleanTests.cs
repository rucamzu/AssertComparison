namespace Tests.xUnit;

public class BooleanTests
{
    [Fact]
    public void BooleanIsTrue() => Assert.True(booleanFalse);

    [Fact]
    public void BooleanIsFalse() => Assert.False(booleanTrue);

    [Fact]
    public void MethodReturnsTrue() => Assert.True(ReturnBoolean(false));

    [Fact]
    public void MethodReturnsFalse() => Assert.False(ReturnBoolean(true));

    private static readonly bool booleanTrue = true;

    private static readonly bool booleanFalse = false;

    private static bool ReturnBoolean(bool value) => value;
}