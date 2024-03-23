using Tested;

namespace Tests.NUnit.Constraint;

public class BooleansTests
{
    [Test]
    public void ValueIsTrue() => Assert.That(Booleans.Values.False, Is.True);

    [Test]
    public void ValueIsFalse() => Assert.That(Booleans.Values.True, Is.False);

    [Test]
    public void PropertyIsTrue() => Assert.That(Booleans.Properties.False, Is.True);

    [Test]
    public void PropertyIsFalse() => Assert.That(Booleans.Properties.True, Is.False);

    [Test]
    public void MethodReturnsTrue() => Assert.That(Booleans.Return(false), Is.True);

    [Test]
    public void MethodReturnsFalse() => Assert.That(Booleans.Return(true), Is.False);

    [Test]
    public void ExpressionEvaluatesToTrue() => Assert.That(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) > 1, Is.True);

    [Test]
    public void ExpressionEvaluatesToFalse() => Assert.That(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) < 2, Is.False);
}