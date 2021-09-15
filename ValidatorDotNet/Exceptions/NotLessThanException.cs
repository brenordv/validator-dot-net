using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NotLessThanException: ElementComparisonException
    {
        public NotLessThanException(string message) : base(message)
        {
        }

        public NotLessThanException(string message, Exception e) : base(message, e)
        {
        }

        public NotLessThanException(Exception e) : base(e)
        {
        }

        protected NotLessThanException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}