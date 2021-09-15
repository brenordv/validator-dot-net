using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///  Thrown when A is not less than B
    /// </summary>
    [Serializable]
    public class NotLessThanException: ElementComparisonException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NotLessThanException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotLessThanException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NotLessThanException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NotLessThanException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}