namespace Tests.NUnit.Constraint;

public class BooleanTests
{
    [Test]
    public void BooleanIsTrue() => Assert.That(booleanFalse, Is.True);

    [Test]
    public void BooleanIsFalse() => Assert.That(booleanTrue, Is.False);

    [Test]
    public void MethodReturnsTrue() => Assert.That(ReturnBoolean(false), Is.True);

    [Test]
    public void MethodReturnsFalse() => Assert.That(ReturnBoolean(true), Is.False);

    private static readonly bool booleanTrue = true;

    private static readonly bool booleanFalse = false;

    private static bool ReturnBoolean(bool value) => value;
}