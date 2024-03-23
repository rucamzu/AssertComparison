using Shouldly;
using Tested;

namespace Tests.MSTest.Shouldly;

[TestClass]
public class BooleansTests
{
    [TestMethod]
    public void BooleansIsTrue() => Booleans.False.ShouldBeTrue();

    [TestMethod]
    public void BooleansIsFalse() => Booleans.True.ShouldBeFalse();

    [TestMethod]
    public void MethodReturnsTrue() => Booleans.Return(false).ShouldBeTrue();

    [TestMethod]
    public void MethodReturnsFalse() => Booleans.Return(true).ShouldBeFalse();
}