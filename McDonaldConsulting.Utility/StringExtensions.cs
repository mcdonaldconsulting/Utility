namespace McDonaldConsulting
{
    using System.Collections.Generic;

    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static string Join(this IEnumerable<string> values, string separator)
        {
            return string.Join(separator, values);
        }

        public static string Join(this string[] values, string separator)
        {
            return string.Join(separator, values);
        }

        public static string Join(this object[] values, string separator)
        {
            return string.Join(separator, values);
        }

        public static string FormatWith(this string format, object arg0)
        {
            return string.Format(format, arg0);
        }

        public static string FormatWith(this string format, object arg0, object arg1)
        {
            return string.Format(format, arg0, arg1);
        }
    }
}
