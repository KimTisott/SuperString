using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SuperString
{
    public static class Validators
    {
        public static bool IsBool(this string s)
            => bool.TryParse(s, out _);

        public static bool IsByte(this string s)
            => byte.TryParse(s, out _);

        public static bool IsChar(this string s)
            => char.TryParse(s, out _);

        public static bool IsDateTime(this string s)
            => DateTime.TryParse(s, out _);

        public static bool IsDecimal(this string s)
            => decimal.TryParse(s, out _);

        public static bool IsDouble(this string s)
            => double.TryParse(s, out _);

        public static bool IsEnum<TEnum>(this string s)
            where TEnum : struct
            => Enum.TryParse<TEnum>(s, true, out _);

        public static bool IsFloat(this string s)
            => float.TryParse(s, out _);

        public static bool IsInt16(this string s)
            => short.TryParse(s, out _);

        public static bool IsInt32(this string s)
            => int.TryParse(s, out _);

        public static bool IsInt64(this string s)
            => long.TryParse(s, out _);

        public static bool IsIPAddress(this string s)
            => IPAddress.TryParse(s, out _);

        public static bool IsMailAddress(this string s)
            => MailAddress.TryCreate(s, out _);

        public static bool IsSByte(this string s)
            => sbyte.TryParse(s, out _);

        public static bool IsUInt16(this string s)
            => ushort.TryParse(s, out _);

        public static bool IsUInt32(this string s)
            => uint.TryParse(s, out _);

        public static bool IsUInt64(this string s)
            => ulong.TryParse(s, out _);

        public static bool IsLower(this string s)
            => s == s.ToLower();
        public static bool IsUpper(this string s)
            => s == s.ToUpper();

        public static bool IsInCollection(this string s, IEnumerable<string> e)
        {
            if (e == null)
                return false;

            foreach (var str in e)
                if (str == s)
                    return true;

            return false;
        }

        public static bool IsAlpha(this string s)
        {
            foreach (var c in s)
                if (c < 'A' || (c > 'Z' && c < 'a') || c > 'z')
                    return false;

            return true;
        }

        public static bool IsNumeric(this string s)
        {
            foreach (var c in s)
                if (c < '0' || c > '9')
                    return false;

            return true;
        }

        public static bool IsAlphaNumeric(this string s)
        {
            foreach (var c in s)
                if ((c < 'A' && (c < '0' || c > '9')) || (c > 'Z' && c < 'a') || c > 'z')
                    return false;

            return true;
        }
    }
}