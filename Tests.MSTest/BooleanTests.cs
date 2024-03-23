using Tested;

namespace Tests.MSTest;

[TestClass]
public class BooleansTests
{
    [TestMethod]
    public void ValueIsTrue() => Assert.IsTrue(Booleans.Values.False);

    [TestMethod]
    public void ValueIsFalse() => Assert.IsFalse(Booleans.Values.True);

    [TestMethod]
    public void PropertyIsTrue() => Assert.IsTrue(Booleans.Properties.False);

    [TestMethod]
    public void PropertyIsFalse() => Assert.IsFalse(Booleans.Properties.True);

    [TestMethod]
    public void MethodReturnsTrue() => Assert.IsTrue(Booleans.Return(false));

    [TestMethod]
    public void MethodReturnsFalse() => Assert.IsFalse(Booleans.Return(true));

    [TestMethod]
    public void ExpressionEvaluatesToTrue() => Assert.IsTrue(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) > 1);

    [TestMethod]
    public void ExpressionEvaluatesToFalse() => Assert.IsFalse(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) < 2);
}