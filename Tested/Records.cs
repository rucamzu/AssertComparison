namespace Tested;

public static class Records
{
    public record Name(string First, string Last);

    public record Person(Name Name, int Age);

    public static class Values
    {
        public static readonly Person JaneDoe = new(new("Jane", "Doe"), 35);

        public static readonly Person JohnDoe = new(new("John", "Doe"), 34);
    }
}