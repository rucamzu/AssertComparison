using Shouldly;
using Tested;

namespace Tests.MSTest.Shouldly;

[TestClass]
public class NullableTests
{
    [TestMethod]
    public void ReferenceIsNull() => Nullables.References.NotNull.ShouldBeNull();

    [TestMethod]
    public void ReferenceIsNotNull() => Nullables.References.Null.ShouldNotBeNull();

    [TestMethod]
    public void PropertyIsNull() => Nullables.Properties.NotNull.ShouldBeNull();

    [TestMethod]
    public void PropertyIsNotNull() => Nullables.Properties.Null.ShouldNotBeNull();

    [TestMethod]
    public void MethodReturnsNull() => Nullables.Return<string>("not null").ShouldBeNull();

    [TestMethod]
    public void MethodReturnsNotNull() => Nullables.Return<string>(null).ShouldNotBeNull();

    [TestMethod]
    public void ExpressionEvaluatesToNull() => (Nullables.Return<string>("not null")?.ToUpper()).ShouldBeNull();

    [TestMethod]
    public void ExpressionEvaluatesToNotNull() => (Nullables.Return<string>(null)?.ToUpper()).ShouldNotBeNull();
}