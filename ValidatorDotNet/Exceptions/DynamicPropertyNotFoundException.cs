using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Exception used while validating dynamic objects.
    /// </summary>
    [Serializable]
    public class DynamicPropertyNotFoundException : BaseValidationException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public DynamicPropertyNotFoundException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public DynamicPropertyNotFoundException(string message, Exception e) : base(message, e)
        {
        }
        
        /// <inheritdoc cref="BaseValidationException"/>
        public DynamicPropertyNotFoundException(Exception e) : base(e)
        {
        }
        
        /// <inheritdoc cref="BaseValidationException"/>
        protected DynamicPropertyNotFoundException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}