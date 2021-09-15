using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when a string exceeds the maximum allowed size.
    /// </summary>
    [Serializable]
    public class TextTooBigException: BaseValidationException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public TextTooBigException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public TextTooBigException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public TextTooBigException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected TextTooBigException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}