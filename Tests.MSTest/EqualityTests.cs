using Tested;

namespace Tests.MSTest;

[TestClass]
public class EqualityTests
{
    [TestMethod]
    public void NumbersAreEqual() => Assert.AreEqual(Numbers.Values.One, Numbers.Values.Two, $"{Numbers.Values.One} and {Numbers.Values.Two} are supposed to be equal");

    [TestMethod]
    public void NumbersAreNotEqual() => Assert.AreNotEqual(Numbers.Values.FortyTwo, Numbers.Values.FortyTwo, $"{Numbers.Values.FortyTwo} and {Numbers.Values.FortyTwo} are supposed to be different");

    [TestMethod]
    public void StringsAreEqual() => Assert.AreEqual(Strings.Values.Blue, Strings.Values.Green, $"'{Strings.Values.Blue}' and '{Strings.Values.Green}' are supposed to be equal");

    [TestMethod]
    public void StringsAreNotEqual() => Assert.AreNotEqual(Strings.Values.Red, Strings.Values.Red, $"'{Strings.Values.Red}' and '{Strings.Values.Red}' are supposed to be different");

    [TestMethod]
    public void RecordsAreEqual() => Assert.AreEqual(Records.Values.JaneDoe, Records.Values.JohnDoe, $"{Records.Values.JaneDoe} and {Records.Values.JohnDoe} are supposed to be equal");

    [TestMethod]
    public void RecordsAreNotEqual() => Assert.AreNotEqual(Records.Values.JaneDoe, Records.Values.JaneDoe, $"{Records.Values.JaneDoe} and {Records.Values.JaneDoe} are supposed to be equal");
}