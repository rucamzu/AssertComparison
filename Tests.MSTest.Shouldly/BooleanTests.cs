using Shouldly;

namespace Tests.MSTest.Shouldly;

[TestClass]
public class BooleanTests
{
    [TestMethod]
    public void BooleanIsTrue() => booleanFalse.ShouldBeTrue();

    [TestMethod]
    public void BooleanIsFalse() => booleanTrue.ShouldBeFalse();

    [TestMethod]
    public void MethodReturnsTrue() => ReturnBoolean(false).ShouldBeTrue();

    [TestMethod]
    public void MethodReturnsFalse() => ReturnBoolean(true).ShouldBeFalse();

    private static readonly bool booleanTrue = true;

    private static readonly bool booleanFalse = false;

    private static bool ReturnBoolean(bool value) => value;
}