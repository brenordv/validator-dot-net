using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when an UTC offset value is not valid.
    /// </summary>
    [Serializable]
    public class InvalidUtcOffsetException: NumberException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidUtcOffsetException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidUtcOffsetException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidUtcOffsetException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected InvalidUtcOffsetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}