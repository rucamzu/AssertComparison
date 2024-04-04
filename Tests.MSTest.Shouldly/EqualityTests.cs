using Shouldly;
using Tested;

namespace Tests.MSTest.Shouldly;

[TestClass]
public class EqualityTests
{
    [TestMethod]
    public void NumbersAreEqual() => Numbers.Values.One.ShouldBe(Numbers.Values.Two, $"{Numbers.Values.One} and {Numbers.Values.Two} are supposed to be equal");

    [TestMethod]
    public void NumbersAreNotEqual() => Numbers.Values.FortyTwo.ShouldNotBe(Numbers.Values.FortyTwo, $"{Numbers.Values.FortyTwo} and {Numbers.Values.FortyTwo} are supposed to be different");

    [TestMethod]
    public void StringsAreEqual() => Strings.Values.Blue.ShouldBe(Strings.Values.Green, $"'{Strings.Values.Blue}' and '{Strings.Values.Green}' are supposed to be equal");

    [TestMethod]
    public void StringsAreNotEqual() => Strings.Values.Red.ShouldNotBe(Strings.Values.Red, $"'{Strings.Values.Red}' and '{Strings.Values.Red}' are supposed to be different");

    [TestMethod]
    public void RecordsAreEqual() => Records.Values.JaneDoe.ShouldBe(Records.Values.JohnDoe, $"{Records.Values.JaneDoe} and {Records.Values.JohnDoe} are supposed to be equal");

    [TestMethod]
    public void RecordsAreNotEqual() => Records.Values.JaneDoe.ShouldNotBe(Records.Values.JaneDoe, $"{Records.Values.JaneDoe} and {Records.Values.JaneDoe} are supposed to be equal");
}