using Tested;

namespace Tests.MSTest;

[TestClass]
public class BooleansTests
{
    [TestMethod]
    public void BooleansIsTrue() => Assert.IsTrue(Booleans.False);

    [TestMethod]
    public void BooleansIsFalse() => Assert.IsFalse(Booleans.True);

    [TestMethod]
    public void MethodReturnsTrue() => Assert.IsTrue(Booleans.Return(false));

    [TestMethod]
    public void MethodReturnsFalse() => Assert.IsFalse(Booleans.Return(true));
}