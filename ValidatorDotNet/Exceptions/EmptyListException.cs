using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Thrown when a given list is empty (and should not be).
    /// </summary>
    [Serializable]
    public class EmptyListException: BaseValidationException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public EmptyListException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public EmptyListException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public EmptyListException(Exception e) : base(e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        protected EmptyListException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}