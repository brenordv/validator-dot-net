using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    /// <summary>
    ///     Base Exception for all validations in this project.
    /// </summary>
    [Serializable]
    public class BaseValidationException: Exception
    {
        
        /// <summary>
        ///     Constructor that receives only the error message.
        /// </summary>
        /// <param name="message">error message</param>
        public BaseValidationException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Constructor that receives the error message and an inner exception.
        /// </summary>
        /// <param name="message">error message</param>
        /// <param name="e">inner exception</param>
        public BaseValidationException(string message, Exception e) : base(message, e)
        {
        }

        /// <summary>
        ///     Constructor that receives only an inner exception.
        ///     In this case, the error message will be the same as the inner exception.
        /// </summary>
        /// <param name="e">inner exception</param>
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