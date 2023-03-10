namespace webApp
{
    public static class Version
    {
        public const int Major = 0;
        public const int Minor = 8;
        public const int Patch = 1;

        public static readonly string AsString = $"{Major}.{Minor}.{Patch}";
        public static readonly string Core = STAR.Version.AsString;
    }
}
