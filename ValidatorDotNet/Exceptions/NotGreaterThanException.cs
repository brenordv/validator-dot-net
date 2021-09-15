using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///  Thrown when A is not greater than B.
    /// </summary>
    [Serializable]
    public class NotGreaterThanException: ElementComparisonException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NotGreaterThanException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotGreaterThanException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotGreaterThanException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NotGreaterThanException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}