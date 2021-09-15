using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class DateTimeNotInUtcException: TypingException
    {
        public DateTimeNotInUtcException(string message) : base(message)
        {
        }

        public DateTimeNotInUtcException(string message, Exception e) : base(message, e)
        {
        }

        public DateTimeNotInUtcException(Exception e) : base(e)
        {
        }

        protected DateTimeNotInUtcException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }
}