namespace McDonaldConsulting
{
    using System;

    public static class MiscellaneousExtensions
    {
        public static bool IsBetween<T>(this T value, T lower, T upper) where T : IComparable
        {
            return value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0;
        }
    }
}
