using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when A is not greater than or equal to B.
    /// </summary>
    [Serializable]
    public class NotGreaterThanOrEqualToException: ElementComparisonException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NotGreaterThanOrEqualToException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotGreaterThanOrEqualToException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotGreaterThanOrEqualToException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NotGreaterThanOrEqualToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}