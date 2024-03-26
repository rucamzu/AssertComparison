using Tested;

namespace Tests.NUnit.Constraint;

public class NullableTests
{
    [Test]
    public void ReferenceIsNull() => Assert.That(Nullables.References.NotNull, Is.Null);

    [Test]
    public void ReferenceIsNotNull() => Assert.That(Nullables.References.Null, Is.Not.Null);

    [Test]
    public void PropertyIsNull() => Assert.That(Nullables.Properties.NotNull, Is.Null);

    [Test]
    public void PropertyIsNotNull() => Assert.That(Nullables.Properties.Null, Is.Not.Null);

    [Test]
    public void MethodReturnsNull() => Assert.That(Nullables.Return<string>("not null"), Is.Null);

    [Test]
    public void MethodReturnsNotNull() => Assert.That(Nullables.Return<string>(null), Is.Not.Null);

    [Test]
    public void ExpressionEvaluatesToNull() => Assert.That(Nullables.Return<string>("not null")?.ToUpper(), Is.Null);

    [Test]
    public void ExpressionEvaluatesToNotNull() => Assert.That(Nullables.Return<string>(null)?.ToUpper(), Is.Not.Null);
}