using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     A really bad exception.
    ///     Initially used when "affected rows" variable is greater than 1 (used mainly on deletes and updates that should involve only 1 row in the database)
    /// </summary>
    [Serializable]
    public class UnexpectedException: BaseValidationException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public UnexpectedException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public UnexpectedException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public UnexpectedException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected UnexpectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}