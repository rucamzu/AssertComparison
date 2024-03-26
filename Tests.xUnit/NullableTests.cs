using Tested;

namespace Tests.xUnit;

public class NullableTests
{
    [Fact]
    public void ReferenceIsNull() => Assert.Null(Nullables.References.NotNull);

    [Fact]
    public void ReferenceIsNotNull() => Assert.NotNull(Nullables.References.Null);

    [Fact]
    public void PropertyIsNull() => Assert.Null(Nullables.Properties.NotNull);

    [Fact]
    public void PropertyIsNotNull() => Assert.NotNull(Nullables.Properties.Null);

    [Fact]
    public void MethodReturnsNull() => Assert.Null(Nullables.Return<string>("not null"));

    [Fact]
    public void MethodReturnsNotNull() => Assert.NotNull(Nullables.Return<string>(null));

    [Fact]
    public void ExpressionEvaluatesToNull() => Assert.Null(Nullables.Return<string>("not null")?.ToUpper());

    [Fact]
    public void ExpressionEvaluatesToNotNull() => Assert.NotNull(Nullables.Return<string>(null)?.ToUpper());
}