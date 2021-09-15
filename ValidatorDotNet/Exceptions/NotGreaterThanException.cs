using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NotGreaterThanException: ElementComparisonException
    {
        public NotGreaterThanException(string message) : base(message)
        {
        }

        public NotGreaterThanException(string message, Exception e) : base(message, e)
        {
        }

        public NotGreaterThanException(Exception e) : base(e)
        {
        }

        protected NotGreaterThanException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}