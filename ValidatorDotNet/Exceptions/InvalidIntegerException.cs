using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     When the variable value is not a valid int.
    /// </summary>
    [Serializable]
    public class InvalidIntegerException: NumberException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidIntegerException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidIntegerException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public InvalidIntegerException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected InvalidIntegerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}