namespace Mustache
{
    /// <summary>
    /// Provides utility methods that require regular expressions.
    /// </summary>
    static class ObjectExtensions
    {
        public static bool IsNumeric(this object obj) {
            return obj is byte
                || obj is sbyte
                || obj is ushort
                || obj is uint
                || obj is ulong
                || obj is short
                || obj is int
                || obj is long
                || obj is decimal
                || obj is double
                || obj is float;
        }

    }
}
