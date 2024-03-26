using NUnit.Framework.Legacy;
using Tested;

namespace Tests.NUnit.Classic;

public class NullableTests
{
    [Test]
    public void ReferenceIsNull() => ClassicAssert.IsNull(Nullables.References.NotNull);

    [Test]
    public void ReferenceIsNotNull() => ClassicAssert.IsNotNull(Nullables.References.Null);

    [Test]
    public void PropertyIsNull() => ClassicAssert.IsNull(Nullables.Properties.NotNull);

    [Test]
    public void PropertyIsNotNull() => ClassicAssert.IsNotNull(Nullables.Properties.Null);

    [Test]
    public void MethodReturnsNull() => ClassicAssert.IsNull(Nullables.Return<string>("not null"));

    [Test]
    public void MethodReturnsNotNull() => ClassicAssert.IsNotNull(Nullables.Return<string>(null));

    [Test]
    public void ExpressionEvaluatesToNull() => ClassicAssert.IsNull(Nullables.Return<string>("not null")?.ToUpper());

    [Test]
    public void ExpressionEvaluatesToNotNull() => ClassicAssert.IsNotNull(Nullables.Return<string>(null)?.ToUpper());
}