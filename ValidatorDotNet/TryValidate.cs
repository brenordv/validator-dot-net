using System;
using System.Collections.Generic;
using System.Linq;
using Raccoon.Ninja.ValidatorDotNet.Constants;
using Raccoon.Ninja.ValidatorDotNet.ExtensionMethods;

namespace Raccoon.Ninja.ValidatorDotNet
{
    public static partial class Validate
    {
        /// <summary>
        ///     Checks if a given string has less than or the same amount of chars indicated be the argument.
        /// </summary>
        /// <param name="text">text to validate</param>
        /// <param name="maxChars">maximum chars</param>
        /// <returns>true if it has lesser than or the same amount of chars/false otherwise</returns>
        public static bool TryIsTextWithinCharLimit(string text, int maxChars)
        {
            return text.Length <= maxChars;
        }


        /// <summary>
        ///     Checks if an object is null.
        /// </summary>
        /// <param name="obj">object to be checked</param>
        /// <returns>true if it is null/false otherwise.</returns>
        public static bool TryIsNull(object obj)
        {
            return obj == null;
        }

        /// <summary>
        ///     Checks if a text is null or composed only by whitespaces.
        /// </summary>
        /// <param name="text">object to be checked</param>
        /// <returns>true if it is null/false otherwise.</returns>
        public static bool TryIsTextNull(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        /// <summary>
        ///     Checks if a dynamic object has a certain property.
        ///     Attention: The lookup is case sensitive!
        /// </summary>
        /// <param name="obj">object to be checked</param>
        /// <param name="propertyName">param name</param>
        /// <returns>true if has parameter/false otherwise</returns>
        public static bool TryDynamicHasProperty(dynamic obj, string propertyName)
        {
            return !TryIsNull(obj) && obj.GetType().GetProperty(propertyName) != null;
        }

        /// <summary>
        ///     Checks if a string can be converted to an Int.
        /// </summary>
        /// <param name="text">Text to be converted.</param>
        /// <returns>true if it can/false otherwise</returns>
        public static bool TryCanBeInt(string text)
        {
            return int.TryParse(text, out _);
        }

        /// <summary>
        ///     Checks if a list has any elements.
        ///     If it's null, will return false.
        /// </summary>
        /// <param name="list">Object to be checked</param>
        /// <typeparam name="T">Type of the list</typeparam>
        /// <returns>true if it has any elements/false otherwise.</returns>
        public static bool TryHasElements<T>(ICollection<T> list)
        {
            if (TryIsNull(list)) return false;
            return list.Count > 0;
        }

        /// <summary>
        ///     Checks if all elements of a list are positive.
        ///     Zero does does not count, because the real numbers can be partitioned into the positive real numbers,
        ///     the negative real numbers, and zero. A real number is one and only one of those three possibilities.
        ///     This is called "trichotomy." Non-negative (or, correspondingly, non-positive) means not negative
        ///     (not positive), so zero or positive (zero or negative). That is, non-negative includes zero whereas
        ///     positive does not.
        ///     For clarity:
        ///     Non-negative means zero or positive.
        ///     Non-positive means zero or negative.
        ///     That is, non-negative includes zero whereas positive does not and vice versa.
        /// </summary>
        /// <param name="list">list to be checked</param>
        /// <typeparam name="T">Type of the elements of the list.</typeparam>
        /// <returns>True if all elements are numeric AND positive.</returns>
        public static bool TryAllPositiveElements<T>(ICollection<T> list) where T : struct, IComparable
        {
            if (TryIsNull(list) || !TryHasElements(list))
                return false;

            return list.All(i => i.IsNumeric() && TryIsGreaterThan(i, default));
        }

        /// <summary>
        ///     Checks if A is greater than B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <returns>true if A is greater than B/false otherwise.</returns>
        public static bool TryIsGreaterThan<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0;
        }

        /// <summary>
        ///     Checks if A is greater than or equal to B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <returns>true if A is greater than or equal to B/false otherwise.</returns>
        public static bool TryIsGreaterThanOrEqualTo<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) >= 0;
        }

        /// <summary>
        ///     Checks if A is less than B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <returns>true if A is less than B/false otherwise.</returns>
        public static bool TryIsLessThan<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) < 0;
        }
        
        /// <summary>
        ///     Checks if A is less than or equal to B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <returns>true if A is less than or equal to B/false otherwise.</returns>
        public static bool TryIsLessThanOrEqualTo<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) <= 0;
        }

        /// <summary>
        ///     Checks if A is equal to B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <returns>true if A is equal to B/false otherwise.</returns>
        public static bool TryIsEqualTo<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) == 0;
        }

        /// <summary>
        ///     Checks if a given datetime is set to UTC.
        /// </summary>
        /// <param name="dt">object to be checked</param>
        /// <returns>true if it is set to UTC/false otherwise.</returns>
        public static bool TryIsDateTimeUtc(DateTime dt)
        {
            return dt.Kind == DateTimeKind.Utc;
        }

        /// <summary>
        ///     Checks if a datetime is after (or the equal to) the minimum value passed.
        /// </summary>
        /// <param name="dt">object to be checked</param>
        /// <param name="minDate">Minimum DateTime allowed. By default, will use Sql Server minimum</param>
        /// <returns>true if it is/false otherwise.</returns>
        public static bool TryIsDateTimeAfterMin(DateTime dt, DateTime? minDate = null)
        {
            minDate ??= Constraints.MinDateForDatabase.SqlServer;
            return dt >= minDate.Value;
        }

        /// <summary>
        ///     Validates if an Enum is defined or not.
        /// </summary>
        /// <param name="enumObj">to be validated</param>
        /// <typeparam name="T">type of Enum</typeparam>
        /// <returns>true if it is. false otherwise</returns>
        public static bool TryIsEnumValid<T>(T enumObj) where T : Enum
        {
            return Enum.IsDefined(typeof(T), enumObj);
        }

        /// <summary>
        ///     Validates if a Guid is not an Empty one.
        /// </summary>
        /// <param name="guid">guid to be checked</param>
        /// <returns>true if it's not an empty guid, false otherwise.</returns>
        public static bool TryIsValidGuid(string guid)
        {
            var success = Guid.TryParseExact(guid, "D", out var parsed);
            return success && parsed != Guid.Empty;
        }
        
        /// <summary>
        ///     Checks if an integer represents a valid UTC offset.
        /// </summary>
        /// <param name="utcOffset">to be checked</param>
        /// <returns>true if it is a valid utc-offset, false otherwise.</returns>
        public static bool TryIsValidUtcOffset(int utcOffset)
        {
            return TryIsGreaterThanOrEqualTo(utcOffset, Constraints.Utc.MinValue) && 
                   TryIsLessThanOrEqualTo(utcOffset, Constraints.Utc.MaxValue);
        }
    }
}