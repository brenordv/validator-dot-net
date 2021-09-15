using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class TextTooBigException: BaseValidationException
    {
        public TextTooBigException(string message) : base(message)
        {
        }

        public TextTooBigException(string message, Exception e) : base(message, e)
        {
        }

        public TextTooBigException(Exception e) : base(e)
        {
        }

        protected TextTooBigException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}