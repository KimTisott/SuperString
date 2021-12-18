using System;
using System.Net;
using System.Net.Mail;

namespace SuperString
{
    public static class Converters
    {
        static readonly string[] FalseValues = { "f", "0" };
        static readonly string[] TrueValues = { "t", "1" };
        public static bool ToBool(this string s, bool defaultValue = default, string[] falseValues = default, string[] trueValues = default)
        {
            falseValues ??= FalseValues;
            trueValues ??= TrueValues;

            if (s.IsInCollection(falseValues))
                return false;

            if (s.IsInCollection(trueValues))
                return true;

            if (bool.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static byte ToByte(this string s, byte defaultValue = default)
        {
            if (byte.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static char ToChar(this string s, char defaultValue = default)
        {
            if (char.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static DateTime ToDateTime(this string s, DateTime defaultValue = default)
        {
            if (DateTime.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static decimal ToDecimal(this string s, decimal defaultValue = default)
        {
            if (decimal.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static double ToDouble(this string s, double defaultValue = default)
        {
            if (double.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static TEnum ToEnum<TEnum>(this string s, TEnum defaultValue = default) where TEnum : struct
        {
            if (Enum.TryParse<TEnum>(s, true, out var result))
                return result;

            return defaultValue;
        }

        public static float ToFloat(this string s, float defaultValue = default)
        {
            if (float.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static Guid ToGuid(this string s, Guid defaultValue = default)
        {
            if (Guid.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static short ToInt16(this string s, short defaultValue = default)
        {
            if (short.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static int ToInt32(this string s, int defaultValue = default)
        {
            if (int.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static long ToInt64(this string s, long defaultValue = default)
        {
            if (long.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static IPAddress ToIPAddress(this string s, IPAddress defaultValue = default)
        {
            if (IPAddress.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static MailAddress ToMailAddress(this string s, MailAddress defaultValue = default)
        {
            if (MailAddress.TryCreate(s, out var result))
                return result;

            return defaultValue;
        }

        public static sbyte ToSByte(this string s, sbyte defaultValue = default)
        {
            if (sbyte.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static ushort ToUInt16(this string s, ushort defaultValue = default)
        {
            if (ushort.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static uint ToUInt32(this string s, uint defaultValue = default)
        {
            if (uint.TryParse(s, out var result))
                return result;

            return defaultValue;
        }

        public static ulong ToUInt64(this string s, ulong defaultValue = default)
        {
            if (ulong.TryParse(s, out var result))
                return result;

            return defaultValue;
        }
    }
}