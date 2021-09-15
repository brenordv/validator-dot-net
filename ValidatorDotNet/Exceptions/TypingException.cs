using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Exception related to type-checking validations.
    /// </summary>
    [Serializable]
    public class TypingException: ElementComparisonException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public TypingException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public TypingException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public TypingException(Exception e) : base(e)
        {
        }
        
        /// <inheritdoc cref="BaseValidationException"/>
        protected TypingException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}