namespace Web3Lib.Console
{
    public static class StringUtils
    {
        public static string Shorten(this string s)
        {
            if(s.Length <= 10)
                return s;

            return $"{s.Substring(0, 4)}...{s.Substring(s.Length -4)}";
        }
    }
}
