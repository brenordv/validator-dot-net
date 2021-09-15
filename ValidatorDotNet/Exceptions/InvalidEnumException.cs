using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class InvalidEnumException: TypingException
    {
        public InvalidEnumException(string message) : base(message)
        {
        }

        public InvalidEnumException(string message, Exception e) : base(message, e)
        {
        }

        public InvalidEnumException(Exception e) : base(e)
        {
        }

        protected InvalidEnumException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}