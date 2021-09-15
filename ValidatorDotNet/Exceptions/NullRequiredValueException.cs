using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///  Thrown when a given variable is null.
    /// </summary>
    [Serializable]
    public class NullRequiredValueException: TypingException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NullRequiredValueException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NullRequiredValueException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NullRequiredValueException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NullRequiredValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}