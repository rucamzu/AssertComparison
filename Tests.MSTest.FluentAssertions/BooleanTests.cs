using FluentAssertions;
using Tested;

namespace Tests.MSTest.FluentAssertions;

[TestClass]
public class BooleansTests
{
    [TestMethod]
    public void BooleansIsTrue() => Booleans.False.Should().BeTrue();

    [TestMethod]
    public void BooleansIsFalse() => Booleans.True.Should().BeFalse();

    [TestMethod]
    public void MethodReturnsTrue() => Booleans.Return(false).Should().BeTrue();

    [TestMethod]
    public void MethodReturnsFalse() => Booleans.Return(true).Should().BeFalse();
}