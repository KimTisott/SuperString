using System;
using System.Linq;

namespace SuperString
{
    public static class Operators
    {
        public static int Count(this string s, string s1, int defaultValue = default)
            => s1 != null ? s.Count(c => s.Substring(s.IndexOf(c), s1.Length) == s1) : defaultValue;

        public static string Capitalize(this string s, string defaulValue = default)
            => s.Length > 0 ? $"{s[0].ToString().ToUpper()}{s.AsSpan(1).ToString()}" : defaulValue;

        public static char GetChar(this string s, int index, char defaultValue = default)
            => index >= 0 && s.Length > index ? s[index] : defaultValue;

        public static string Remove(this string s, char c)
            => s.Replace(c.ToString(), "");

        public static string Remove(this string s, string s1, string defaulValue = default)
            => s1 != null ? s.Replace(s1, "") : defaulValue;

        public static string Format(this string s, object o, string defaulValue = default)
            => o != null ? string.Format(s, o) : defaulValue;

        public static string TrimStart(this string s, string s1, string defaultValue = default)
            => s1 != null ? s.StartsWith(s1) ? s.AsSpan(s1.Length).ToString() : s : defaultValue;

        public static string TrimEnd(this string s, string s1, string defaultValue = default)
            => s1 != null ? s.EndsWith(s1) ? s.AsSpan(s.Length - s1.Length - 1).ToString() : s : defaultValue;

        public static string Trim(this string s, string s1, string defaultValue = default)
            => s1 != null ? (s.StartsWith(s1) ? s.AsSpan(s1.Length).ToString() : s) + (s.EndsWith(s1) ? s.AsSpan(s.Length - s1.Length - 1).ToString() : s) : defaultValue;
    }
}