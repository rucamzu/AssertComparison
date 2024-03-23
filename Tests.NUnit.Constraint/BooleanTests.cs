using Tested;

namespace Tests.NUnit.Constraint;

public class BooleansTests
{
    [Test]
    public void BooleansIsTrue() => Assert.That(Booleans.False, Is.True);

    [Test]
    public void BooleansIsFalse() => Assert.That(Booleans.True, Is.False);

    [Test]
    public void MethodReturnsTrue() => Assert.That(Booleans.Return(false), Is.True);

    [Test]
    public void MethodReturnsFalse() => Assert.That(Booleans.Return(true), Is.False);
}