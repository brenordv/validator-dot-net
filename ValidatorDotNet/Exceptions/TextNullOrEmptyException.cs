using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     When a text is null or empty.
    /// </summary>
    [Serializable]
    public class TextNullOrEmptyException: NullRequiredValueException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public TextNullOrEmptyException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public TextNullOrEmptyException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public TextNullOrEmptyException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected TextNullOrEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}