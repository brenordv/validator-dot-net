using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NotLessThanOrEqualToException: ElementComparisonException
    {
        public NotLessThanOrEqualToException(string message) : base(message)
        {
        }

        public NotLessThanOrEqualToException(string message, Exception e) : base(message, e)
        {
        }

        public NotLessThanOrEqualToException(Exception e) : base(e)
        {
        }

        protected NotLessThanOrEqualToException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}