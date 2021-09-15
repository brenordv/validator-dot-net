using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when A is not less than or equal to B.
    /// </summary>
    [Serializable]
    public class NotLessThanOrEqualToException: ElementComparisonException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NotLessThanOrEqualToException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotLessThanOrEqualToException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotLessThanOrEqualToException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NotLessThanOrEqualToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}