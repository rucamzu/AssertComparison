namespace Tested;

public static class Nullables
{
    public static class References
    {
        public static readonly object? Null = null;

        public static readonly object? NotNull = new();
    }

    public static class Properties
    {
        public static object? Null => null;

        public static object? NotNull => new();
    }

    public static T? Return<T>(T? reference) where T : class => reference;
}
