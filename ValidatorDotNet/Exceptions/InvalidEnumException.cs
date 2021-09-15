using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when a given value is not a valid enum of type T.
    /// </summary>
    [Serializable]
    public class InvalidEnumException: TypingException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidEnumException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidEnumException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidEnumException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected InvalidEnumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}