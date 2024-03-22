namespace Tests.MSTest;

[TestClass]
public class BooleanTests
{
    [TestMethod]
    public void BooleanIsTrue() => Assert.IsTrue(booleanFalse);

    [TestMethod]
    public void BooleanIsFalse() => Assert.IsFalse(booleanTrue);

    [TestMethod]
    public void MethodReturnsTrue() => Assert.IsTrue(ReturnBoolean(false));

    [TestMethod]
    public void MethodReturnsFalse() => Assert.IsFalse(ReturnBoolean(true));

    private static readonly bool booleanTrue = true;

    private static readonly bool booleanFalse = false;

    private static bool ReturnBoolean(bool value) => value;
}