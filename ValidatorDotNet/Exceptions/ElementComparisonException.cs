using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Exception used while validating by comparison.
    /// </summary>
    [Serializable]
    public class ElementComparisonException: BaseValidationException
    {
        /// <inheritdoc cref="BaseValidationException"/>
        public ElementComparisonException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public ElementComparisonException(string message, Exception e) : base(message, e)
        {
        }

        /// <inheritdoc cref="BaseValidationException"/>
        public ElementComparisonException(Exception e) : base(e)
        {
        }
        
        /// <inheritdoc cref="BaseValidationException"/>
        protected ElementComparisonException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}