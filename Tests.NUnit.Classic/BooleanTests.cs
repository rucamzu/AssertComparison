using NUnit.Framework.Legacy;
using Tested;

namespace Tests.NUnit.Classic;

public class BooleansTests
{
    [Test]
    public void BooleansIsTrue() => ClassicAssert.IsTrue(Booleans.False);

    [Test]
    public void BooleansIsFalse() => ClassicAssert.IsFalse(Booleans.True);

    [Test]
    public void MethodReturnsTrue() => ClassicAssert.IsTrue(Booleans.Return(false));

    [Test]
    public void MethodReturnsFalse() => ClassicAssert.IsFalse(Booleans.Return(true));
}