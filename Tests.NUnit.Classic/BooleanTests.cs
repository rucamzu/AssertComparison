using NUnit.Framework.Legacy;

namespace Tests.NUnit.Classic;

public class BooleanTests
{
    [Test]
    public void BooleanIsTrue() => ClassicAssert.IsTrue(booleanFalse);

    [Test]
    public void BooleanIsFalse() => ClassicAssert.IsFalse(booleanTrue);

    [Test]
    public void MethodReturnsTrue() => ClassicAssert.IsTrue(ReturnBoolean(false));

    [Test]
    public void MethodReturnsFalse() => ClassicAssert.IsFalse(ReturnBoolean(true));

    private static readonly bool booleanTrue = true;

    private static readonly bool booleanFalse = false;

    private static bool ReturnBoolean(bool value) => value;
}