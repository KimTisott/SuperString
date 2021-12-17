using System;
using Xunit;

namespace SuperString.Tests
{
    public class Converters
    {
        [Theory]
        [InlineData("f", false)]
        [InlineData("1", true)]
        [InlineData("correct", true, new[] { "incorrect" }, new[] { "correct" })]
        [InlineData("incorrect", false, new[] { "incorrect" })]
        [InlineData("unknown", default(bool))]
        public void ToBool(string s, bool b, string[] falseValues = null, string[] trueValues = null)
            => Assert.Equal(s.ToBool(falseValues: falseValues, trueValues: trueValues), b);

        [Theory]
        [InlineData("0", 0)]
        [InlineData("255", 255)]
        [InlineData("256", default(byte))]
        [InlineData("a", default(byte))]
        [InlineData("-1", default(byte))]
        public void ToByte(string s, byte b)
            => Assert.Equal(s.ToByte(), b);

        [Theory]
        [InlineData("a", 'a')]
        [InlineData("Z", 'Z')]
        [InlineData("1", '1')]
        [InlineData("", default(char))]
        [InlineData("666", default(char))]
        public void ToChar(string s, char c)
            => Assert.Equal(s.ToChar(), c);


        public static readonly object[][] ToDateTimeData =
        {
            new object[] { "2099-12-31T23:59:59.999", new DateTime(2099, 12, 31, 23, 59, 59, 999) },
            new object[] { "2000-01-01 00:00:00.000", new DateTime(2000, 1, 1, 0, 0, 0, 0) },
            new object[] { "0", new DateTime(0) },
            new object[] { "thisisnotdatetime", default },
            new object[] { "-1", default }
        };
        [Theory]
        [MemberData(nameof(ToDateTimeData))]
        public void ToDateTime(string s, DateTime d)
            => Assert.Equal(s.ToDateTime(), d);   
    }
}