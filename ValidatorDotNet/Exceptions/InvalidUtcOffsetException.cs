using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class InvalidUtcOffsetException: NumberException
    {
        public InvalidUtcOffsetException(string message) : base(message)
        {
        }

        public InvalidUtcOffsetException(string message, Exception e) : base(message, e)
        {
        }

        public InvalidUtcOffsetException(Exception e) : base(e)
        {
        }

        protected InvalidUtcOffsetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}