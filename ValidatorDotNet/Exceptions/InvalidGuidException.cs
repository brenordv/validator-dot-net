using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when a given Guid is not valid (or empty).
    /// </summary>
    [Serializable]
    public class InvalidGuidException: TypingException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidGuidException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidGuidException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidGuidException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected InvalidGuidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}