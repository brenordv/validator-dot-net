using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when a validation involving numbers fail.
    /// </summary>
    [Serializable]
    public class NumberException: TypingException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NumberException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NumberException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NumberException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}