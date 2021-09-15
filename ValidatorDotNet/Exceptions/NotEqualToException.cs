using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when A is not igual to B.
    /// </summary>
    [Serializable]
    public class NotEqualToException: ElementComparisonException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NotEqualToException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotEqualToException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotEqualToException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NotEqualToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}