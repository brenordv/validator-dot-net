using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NotEqualToException: ElementComparisonException
    {
        public NotEqualToException(string message) : base(message)
        {
        }

        public NotEqualToException(string message, Exception e) : base(message, e)
        {
        }

        public NotEqualToException(Exception e) : base(e)
        {
        }

        protected NotEqualToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}