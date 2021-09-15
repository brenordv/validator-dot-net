using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class InvalidGuidException: TypingException
    {
        public InvalidGuidException(string message) : base(message)
        {
        }

        public InvalidGuidException(string message, Exception e) : base(message, e)
        {
        }

        public InvalidGuidException(Exception e) : base(e)
        {
        }

        protected InvalidGuidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}