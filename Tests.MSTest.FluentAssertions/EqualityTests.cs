using FluentAssertions;
using Tested;

namespace Tests.MSTest.FluentAssertions;

[TestClass]
public class EqualityTests
{
    [TestMethod]
    public void NumbersAreEqual() => Numbers.Values.One.Should().Be(Numbers.Values.Two, because: $"{Numbers.Values.One} and {Numbers.Values.Two} are supposed to be equal");

    [TestMethod]
    public void NumbersAreNotEqual() => Numbers.Values.FortyTwo.Should().NotBe(Numbers.Values.FortyTwo, because: $"{Numbers.Values.FortyTwo} and {Numbers.Values.FortyTwo} are supposed to be different");

    [TestMethod]
    public void StringsAreEqual() => Strings.Values.Blue.Should().Be(Strings.Values.Green, because: $"'{Strings.Values.Blue}' and '{Strings.Values.Green}' are supposed to be equal");

    [TestMethod]
    public void StringsAreNotEqual() => Strings.Values.Red.Should().NotBe(Strings.Values.Red, because: $"'{Strings.Values.Red}' and '{Strings.Values.Red}' are supposed to be different");

    [TestMethod]
    public void RecordsAreEqual() => Records.Values.JaneDoe.Should().Be(Records.Values.JohnDoe, because: $"{Records.Values.JaneDoe} and {Records.Values.JohnDoe} are supposed to be equal");

    [TestMethod]
    public void RecordsAreNotEqual() => Records.Values.JaneDoe.Should().NotBe(Records.Values.JaneDoe, because: $"{Records.Values.JaneDoe} and {Records.Values.JaneDoe} are supposed to be equal");
}