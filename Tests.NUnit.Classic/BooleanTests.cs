using NUnit.Framework.Legacy;
using Tested;

namespace Tests.NUnit.Classic;

public class BooleansTests
{
    [Test]
    public void ValueIsTrue() => ClassicAssert.IsTrue(Booleans.Values.False);

    [Test]
    public void ValueIsFalse() => ClassicAssert.IsFalse(Booleans.Values.True);

    [Test]
    public void PropertyIsTrue() => ClassicAssert.IsTrue(Booleans.Properties.False);

    [Test]
    public void PropertyIsFalse() => ClassicAssert.IsFalse(Booleans.Properties.True);

    [Test]
    public void MethodReturnsTrue() => ClassicAssert.IsTrue(Booleans.Return(false));

    [Test]
    public void MethodReturnsFalse() => ClassicAssert.IsFalse(Booleans.Return(true));

    [Test]
    public void ExpressionEvaluatesToTrue() => ClassicAssert.IsTrue(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) > 1);

    [Test]
    public void ExpressionEvaluatesToFalse() => ClassicAssert.IsFalse(new[]{ Booleans.Values.True, Booleans.Values.False }.Count(boolean => boolean == true) < 2);
}