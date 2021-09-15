using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class InvalidIntegerException: NumberException
    {
        public InvalidIntegerException(string message) : base(message)
        {
        }

        public InvalidIntegerException(string message, Exception e) : base(message, e)
        {
        }

        public InvalidIntegerException(Exception e) : base(e)
        {
        }

        protected InvalidIntegerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}