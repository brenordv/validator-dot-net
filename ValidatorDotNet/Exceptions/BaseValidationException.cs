using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class BaseValidationException: Exception
    {
        
        public BaseValidationException(string message) : base(message)
        {
        }

        public BaseValidationException(string message, Exception e) : base(message, e)
        {
        }

        public BaseValidationException(Exception e) : base(e?.ToString(), e)
        {
        }
        
        /// <summary>
        ///     Serialization Constructor.
        /// </summary>
        /// <param name="info">Serialization Info</param>
        /// <param name="context">Serialization Context</param>
        protected BaseValidationException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}