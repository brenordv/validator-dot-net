using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class TextNullOrEmptyException: NullRequiredValueException
    {
        public TextNullOrEmptyException(string message) : base(message)
        {
        }

        public TextNullOrEmptyException(string message, Exception e) : base(message, e)
        {
        }

        public TextNullOrEmptyException(Exception e) : base(e)
        {
        }

        protected TextNullOrEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}