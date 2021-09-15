using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NumberException: TypingException
    {
        public NumberException(string message) : base(message)
        {
        }

        public NumberException(string message, Exception e) : base(message, e)
        {
        }

        public NumberException(Exception e) : base(e)
        {
        }

        protected NumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}