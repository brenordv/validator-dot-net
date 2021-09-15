using System;
using System.Numerics;

namespace Raccoon.Ninja.ValidatorDotNet.ExtensionMethods
{
    /// <summary>
    ///     Extension methods for ValueType variables.
    /// </summary>
    public static class ValueTypeExtensions
    {
        /// <summary>
        ///     Checks if this ValueType instance is from any of the numeric types.
        ///     Enums are not numbers but, by default, they have an underlying integral numeric type, as can
        ///     be referenced in the official docs. For this reason, they will be considered as numeric.
        ///     Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
        /// </summary>
        /// <param name="value">value to be checked</param>
        /// <returns>True if it is, false otherwise.</returns>
        public static bool IsNumeric(this ValueType value)
        {
            return value is byte ||
                   value is short ||
                   value is int ||
                   value is long ||
                   value is sbyte ||
                   value is ushort ||
                   value is uint ||
                   value is ulong ||
                   value is BigInteger ||
                   value is decimal ||
                   value is double ||
                   value is float ||
                   value is Enum;
        }
    }
}