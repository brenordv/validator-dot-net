using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NullRequiredValueException: TypingException
    {
        public NullRequiredValueException(string message) : base(message)
        {
        }

        public NullRequiredValueException(string message, Exception e) : base(message, e)
        {
        }

        public NullRequiredValueException(Exception e) : base(e)
        {
        }

        protected NullRequiredValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}