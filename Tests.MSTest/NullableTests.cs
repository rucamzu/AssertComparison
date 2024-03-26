using Tested;

namespace Tests.MSTest;

[TestClass]
public class NullableTests
{
    [TestMethod]
    public void ReferenceIsNull() => Assert.IsNull(Nullables.References.NotNull);

    [TestMethod]
    public void ReferenceIsNotNull() => Assert.IsNotNull(Nullables.References.Null);

    [TestMethod]
    public void PropertyIsNull() => Assert.IsNull(Nullables.Properties.NotNull);

    [TestMethod]
    public void PropertyIsNotNull() => Assert.IsNotNull(Nullables.Properties.Null);

    [TestMethod]
    public void MethodReturnsNull() => Assert.IsNull(Nullables.Return<string>("not null"));

    [TestMethod]
    public void MethodReturnsNotNull() => Assert.IsNotNull(Nullables.Return<string>(null));

    [TestMethod]
    public void ExpressionEvaluatesToNull() => Assert.IsNull(Nullables.Return<string>("not null")?.ToUpper());

    [TestMethod]
    public void ExpressionEvaluatesToNotNull() => Assert.IsNotNull(Nullables.Return<string>(null)?.ToUpper());
}