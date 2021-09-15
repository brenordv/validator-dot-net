using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when the the value for "affected rows" variable is igual to zero.
    /// </summary>
    [Serializable]
    public class NoRowsAffectedException: BaseValidationException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public NoRowsAffectedException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NoRowsAffectedException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public NoRowsAffectedException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected NoRowsAffectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}