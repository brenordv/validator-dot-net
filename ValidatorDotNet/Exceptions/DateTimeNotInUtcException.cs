using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Exception used in DateTime validations
    /// </summary>
    [Serializable]
    public class DateTimeNotInUtcException: TypingException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public DateTimeNotInUtcException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public DateTimeNotInUtcException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public DateTimeNotInUtcException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected DateTimeNotInUtcException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }
}