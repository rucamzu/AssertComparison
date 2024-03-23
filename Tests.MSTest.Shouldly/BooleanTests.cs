using Shouldly;
using Tested;

namespace Tests.MSTest.Shouldly;

[TestClass]
public class BooleansTests
{
    [TestMethod]
    public void ValueIsTrue() => Booleans.Values.False.ShouldBeTrue();

    [TestMethod]
    public void ValueIsFalse() => Booleans.Values.True.ShouldBeFalse();

    [TestMethod]
    public void PropertyIsTrue() => Booleans.Properties.False.ShouldBeTrue();

    [TestMethod]
    public void PropertyIsFalse() => Booleans.Properties.True.ShouldBeFalse();

    [TestMethod]
    public void MethodReturnsTrue() => Booleans.Return(false).ShouldBeTrue();

    [TestMethod]
    public void MethodReturnsFalse() => Booleans.Return(true).ShouldBeFalse();

    [TestMethod]
    public void ExpressionEvaluatesToTrue() => (new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) > 1).ShouldBeTrue();

    [TestMethod]
    public void ExpressionEvaluatesToFalse() => (new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) < 2).ShouldBeFalse();
}