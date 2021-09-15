using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NotGreaterThanOrEqualToException: ElementComparisonException
    {
        public NotGreaterThanOrEqualToException(string message) : base(message)
        {
        }

        public NotGreaterThanOrEqualToException(string message, Exception e) : base(message, e)
        {
        }

        public NotGreaterThanOrEqualToException(Exception e) : base(e)
        {
        }

        protected NotGreaterThanOrEqualToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}