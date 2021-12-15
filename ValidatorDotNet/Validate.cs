using System;
using System.Collections.Generic;
using System.Linq;
using Raccoon.Ninja.ValidatorDotNet.Constants;
using Raccoon.Ninja.ValidatorDotNet.Exceptions;
using Raccoon.Ninja.ValidatorDotNet.Internationalization;
using ValidatorDotNet;

namespace Raccoon.Ninja.ValidatorDotNet
{
    public static partial class Validate
    {
        /// <summary>
        ///     Checks if a given string has less than or the same amount of chars indicated be the argument.
        /// </summary>
        /// <param name="text">text to validate</param>
        /// <param name="maxChars">maximum chars</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <exception cref="TextTooBigException">If text exceeds maxChars</exception>
        /// <exception cref="TextNullOrEmptyException">If the object is null or only spaces</exception>
        public static void IsTextWithinCharLimit(string text, int maxChars, string label = null)
        {
            label ??= DefaultLabels.Text;
            
            IsTextNotNull(text, label);
            if (TryIsTextWithinCharLimit(text, maxChars)) return;
            
            throw new TextTooBigException(string.Format(ValidationErrorMessages.TextSizeExceededMaxChars, label,
                maxChars));
        }


        /// <summary>
        ///     Checks if an object is null.
        /// </summary>
        /// <param name="obj">object to be checked</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <exception cref="NullRequiredValueException">If the object is null</exception>
        public static void IsNotNull(object obj, string label = null)
        {
            if (!TryIsNull(obj)) return;
            label ??= DefaultLabels.Object;
            throw new NullRequiredValueException(string.Format(ValidationErrorMessages.NullRequiredValue, label));
        }

        /// <summary>
        ///     Checks if a text is not null or composed only by whitespaces.
        /// </summary>
        /// <param name="text">object to be checked</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <exception cref="TextNullOrEmptyException">If the object is null or only spaces</exception>
        public static void IsTextNotNull(string text, string label = null)
        {
            if (!TryIsTextNull(text)) return;
            label ??= DefaultLabels.Text;
            throw new TextNullOrEmptyException(string.Format(ValidationErrorMessages.NullRequiredValue, label));
        }

        /// <summary>
        ///     Checks if a dynamic object has a certain property.
        ///     Attention: The lookup is case sensitive!
        /// </summary>
        /// <param name="obj">object to be checked</param>
        /// <param name="propertyName">param name</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <exception cref="DynamicPropertyNotFoundException">If the object is null or only spaces</exception>
        public static void DynamicHasProperty(dynamic obj, string propertyName, string label = null)
        {
            if (TryDynamicHasProperty(obj, propertyName)) return;
            label ??= DefaultLabels.Object;
            throw new DynamicPropertyNotFoundException(string.Format(ValidationErrorMessages.DynamicPropMissing,
                propertyName, label));
        }

        /// <summary>
        ///     Checks if a string can be converted to an Int.
        /// </summary>
        /// <param name="text">Text to be converted.</param>
        /// <exception cref="InvalidIntegerException">If the text cannot be converted to an integer.</exception>
        public static void CanBeInt(string text)
        {
            IsTextNotNull(text, nameof(text));
            if (TryCanBeInt(text)) return;
            throw new InvalidIntegerException(string.Format(ValidationErrorMessages.StringIsNotANumber, text));
        }

        /// <summary>
        ///     Checks if a list has any elements.
        ///     If it's null, will return false.
        /// </summary>
        /// <param name="list">Object to be checked</param>
        /// <typeparam name="T">Type of the list</typeparam>
        /// <param name="label">Label to be used in the error message</param>
        /// <exception cref="EmptyListException">If the object is null or the list is empty.</exception>
        public static void HasElements<T>(ICollection<T> list, string label = null)
        {
            if (TryHasElements(list)) return;
            label ??= DefaultLabels.List;
            throw new EmptyListException(string.Format(ValidationErrorMessages.EmptyList, label));
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
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="T">Type of the elements of the list.</typeparam>
        /// <returns>None if OK.</returns>
        /// <exception cref="NotAllNumbersPositiveException">If any element is lesser than or equal to zero.</exception>
        public static void AllPositiveElements<T>(ICollection<T> list, string label = null)
            where T : struct, IComparable
        {
            if (TryAllPositiveElements(list)) return;
            label ??= DefaultLabels.List;
            throw new NotAllNumbersPositiveException(string.Format(ValidationErrorMessages.NotAllNumbersArePositive,
                label));
        }

        /// <summary>
        ///     Checks if A is greater than B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <exception cref="NotGreaterThanException">If a is not greater than or equal to b.</exception>
        public static void IsGreaterThan<T>(T a, T b, string label = null) where T : IComparable
        {
            if (TryIsGreaterThan(a, b)) return;
            label ??= DefaultLabels.Parameter;
            throw new NotGreaterThanException(string.Format(ValidationErrorMessages.NotGreaterThan, b, label, a));
        }

        /// <summary>
        ///     Checks if A is greater than or equal to B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <exception cref="NotGreaterThanOrEqualToException">If a is not greater than b.</exception>
        public static void IsGreaterThanOrEqualTo<T>(T a, T b, string label = null) where T : IComparable
        {
            if (TryIsGreaterThanOrEqualTo(a, b)) return;
            label ??= DefaultLabels.Parameter;
            throw new NotGreaterThanOrEqualToException(string.Format(ValidationErrorMessages.NotGreaterThanOrEqualTo, b, label,
                a));
        }

        /// <summary>
        ///     Checks if A is lesser than B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <exception cref="NotLessThanOrEqualToException">If a is greater than or equal to b.</exception>
        public static void IsLessThan<T>(T a, T b, string label = null) where T : IComparable
        {
            if (TryIsLessThan(a, b)) return;
            label ??= DefaultLabels.Parameter;
            throw new NotLessThanException(string.Format(ValidationErrorMessages.NotLessThan, b, label, a));
        }

        /// <summary>
        ///     Checks if A is less than or equal to B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <exception cref="NotLessThanOrEqualToException">If a is greater than b.</exception>
        public static void IsLessThanOrEqualTo<T>(T a, T b, string label = null) where T : IComparable
        {
            if (TryIsLessThanOrEqualTo(a, b)) return;
            label ??= DefaultLabels.Parameter;
            throw new NotLessThanOrEqualToException(string.Format(ValidationErrorMessages.NotLessThanOrEqualTo, b,
                label, a));
        }

        /// <summary>
        ///     Checks if A is equal to B.
        /// </summary>
        /// <param name="a">An object</param>
        /// <param name="b">Reference object</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="T">Type of parameters. Must be something that can be used with arithmetic operations</typeparam>
        /// <exception cref="NotEqualToException">If a is not equal to b.</exception>
        public static void IsEqualTo<T>(T a, T b, string label = null) where T : IComparable
        {
            if (TryIsEqualTo(a, b)) return;
            label ??= DefaultLabels.Parameter;
            throw new NotEqualToException(string.Format(ValidationErrorMessages.NotEqualTo, label, b, a));
        }

        /// <summary>
        ///     Checks if a given datetime is set to UTC.
        /// </summary>
        /// <param name="dt">object to be checked</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <exception cref="DateTimeNotInUtcException">If the datetime is not set to UTC.</exception>
        public static void IsDateTimeUtc(DateTime dt, string label = null)
        {
            if (TryIsDateTimeUtc(dt)) return;
            label ??= DefaultLabels.Parameter;
            throw new DateTimeNotInUtcException(string.Format(ValidationErrorMessages.DateTimeNotInUTC, label, dt));
        }

        /// <summary>
        ///     Checks if a datetime is after (or the equal to) the minimum value passed.
        /// </summary>
        /// <param name="dt">object to be checked</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <param name="minDate">Minimum DateTime allowed. By default, will use Sql Server minimum</param>
        /// <exception cref="NotGreaterThanOrEqualToException">if DateTime object is before the minimum accepted</exception>
        public static void IsDateTimeAfterMin(DateTime dt, string label = null, DateTime? minDate = null)
        {
            minDate ??= Constraints.MinDateForDatabase.SqlServer;
            if (TryIsDateTimeAfterMin(dt, minDate)) return;
            label ??= DefaultLabels.Parameter;
            throw new NotGreaterThanOrEqualToException(string.Format(ValidationErrorMessages.NotGreaterThanOrEqualTo, minDate,
                label, dt));
        }

        /// <summary>
        ///     Validates if an Enum is defined or not.
        /// </summary>
        /// <param name="enumObj">to be validated</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="TEnum">type of Enum</typeparam>
        /// <exception cref="InvalidEnumException">if value is not a valid Enum of type T</exception>
        public static void IsEnumValid<TEnum>(TEnum enumObj, string label = null) where TEnum : Enum
        {
            if (TryIsEnumValid(enumObj))
                return;
            label ??= DefaultLabels.Parameter;
            var enumType = enumObj.GetType();
            throw new InvalidEnumException(string.Format(ValidationErrorMessages.InvalidEnumValue, label, enumObj,
                enumType.Name));
        }

        /// <summary>
        ///     Checks if all enums in a list are valid.
        /// </summary>
        /// <param name="list">to be checked</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <typeparam name="T">type of enum</typeparam>
        /// <exception cref="NullRequiredValueException">If list is null</exception>
        /// <exception cref="InvalidEnumException">If any of the Enums are invalid</exception>
        public static void AllEnumValid<T>(ICollection<T> list, string label = null) where T : Enum
        {
            var enumType = typeof(T);
            label ??= DefaultLabels.List;

            IsNotNull(list, label);

            if (!list.Any() || list.All(TryIsEnumValid))
                return;

            throw new InvalidEnumException(string.Format(ValidationErrorMessages.InvalidEnumList, label, enumType.Name));
        }

        /// <summary>
        ///     Validates if a Guid is not an Empty one.
        /// </summary>
        /// <param name="guid">guid to be checked</param>
        /// <param name="label">Label to be used in the error message</param>
        /// <exception cref="InvalidGuidException">If the guid is empty.</exception>
        public static void IsGuidValid(string guid, string label = null)
        {
            if (TryIsValidGuid(guid)) return;
            label ??= DefaultLabels.Parameter;
            throw new InvalidGuidException(string.Format(ValidationErrorMessages.InvalidGuid, label));
        }
        
        /// <summary>
        ///     Checks if an integer represents a valid UTC offset.
        /// </summary>
        /// <param name="utcOffset">to be checked</param>
        /// <param name="label">Label to be used in the error message</param>
        public static void IsUtcOffsetValid(int utcOffset, string label = null)
        {
            
            if (TryIsValidUtcOffset(utcOffset)) return;
            label ??= DefaultLabels.UtcOffset;

            throw new InvalidUtcOffsetException(
                string.Format(
                    ValidationErrorMessages.InvalidUtcValue,
                    label,
                    utcOffset, 
                    Constraints.Utc.MinValue, 
                    Constraints.Utc.MaxValue));

        }
        

        
    }
}