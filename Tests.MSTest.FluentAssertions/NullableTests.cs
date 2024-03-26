using FluentAssertions;
using Tested;

namespace Tests.MSTest.FluentAssertions;

[TestClass]
public class NullableTests
{
    [TestMethod]
    public void ReferenceIsNull() => Nullables.References.NotNull.Should().BeNull();

    [TestMethod]
    public void ReferenceIsNotNull() => Nullables.References.Null.Should().NotBeNull();

    [TestMethod]
    public void PropertyIsNull() => Nullables.Properties.NotNull.Should().BeNull();

    [TestMethod]
    public void PropertyIsNotNull() => Nullables.Properties.Null.Should().NotBeNull();

    [TestMethod]
    public void MethodReturnsNull() => Nullables.Return<string>("not null").Should().BeNull();

    [TestMethod]
    public void MethodReturnsNotNull() => Nullables.Return<string>(null).Should().NotBeNull();

    [TestMethod]
    public void ExpressionEvaluatesToNull() => (Nullables.Return<string>("not null")?.ToUpper()).Should().BeNull();

    [TestMethod]
    public void ExpressionEvaluatesToNotNull() => (Nullables.Return<string>(null)?.ToUpper()).Should().NotBeNull();
}