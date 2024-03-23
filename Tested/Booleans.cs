namespace Tested;

public static class Booleans
{
    public static class Values
    {
        public static readonly bool True = true;

        public static readonly bool False = false;
    }

    public static class Properties
    {
        public static bool True => true;

        public static bool False => false;
    }

    public static bool Return(bool value) => value;
}
