using FluentAssertions;
using Tested;

namespace Tests.MSTest.FluentAssertions;

[TestClass]
public class BooleansTests
{
    [TestMethod]
    public void ValueIsTrue() => Booleans.Values.False.Should().BeTrue();

    [TestMethod]
    public void ValueIsFalse() => Booleans.Values.True.Should().BeFalse();

    [TestMethod]
    public void PropertyIsTrue() => Booleans.Properties.False.Should().BeTrue();

    [TestMethod]
    public void PropertyIsFalse() => Booleans.Properties.True.Should().BeFalse();

    [TestMethod]
    public void MethodReturnsTrue() => Booleans.Return(false).Should().BeTrue();

    [TestMethod]
    public void MethodReturnsFalse() => Booleans.Return(true).Should().BeFalse();

    [TestMethod]
    public void ExpressionEvaluatesToTrue() => (new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) > 1).Should().BeTrue();

    [TestMethod]
    public void ExpressionEvaluatesToFalse() => (new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) < 2).Should().BeFalse();
}