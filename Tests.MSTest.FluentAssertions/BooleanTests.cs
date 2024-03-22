using FluentAssertions;

namespace Tests.MSTest.FluentAssertions;

[TestClass]
public class BooleanTests
{
    [TestMethod]
    public void BooleanIsTrue() => booleanFalse.Should().BeTrue();

    [TestMethod]
    public void BooleanIsFalse() => booleanTrue.Should().BeFalse();

    [TestMethod]
    public void MethodReturnsTrue() => ReturnBoolean(false).Should().BeTrue();

    [TestMethod]
    public void MethodReturnsFalse() => ReturnBoolean(true).Should().BeFalse();

    private static readonly bool booleanTrue = true;

    private static readonly bool booleanFalse = false;

    private static bool ReturnBoolean(bool value) => value;
}