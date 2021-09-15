using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when any non-positive number is detected inside a list.
    /// </summary>
    [Serializable]
    public class NotAllNumbersPositiveException: NumberException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NotAllNumbersPositiveException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotAllNumbersPositiveException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotAllNumbersPositiveException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NotAllNumbersPositiveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}