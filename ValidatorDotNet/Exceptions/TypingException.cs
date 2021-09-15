using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class TypingException: ElementComparisonException
    {
        public TypingException(string message) : base(message)
        {
        }

        public TypingException(string message, Exception e) : base(message, e)
        {
        }

        public TypingException(Exception e) : base(e)
        {
        }
        
        protected TypingException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}