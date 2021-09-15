using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class UnexpectedException: BaseValidationException
    {
        public UnexpectedException(string message) : base(message)
        {
        }

        public UnexpectedException(string message, Exception e) : base(message, e)
        {
        }

        public UnexpectedException(Exception e) : base(e)
        {
        }

        protected UnexpectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}