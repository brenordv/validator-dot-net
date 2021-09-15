using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NotAllNumbersPositiveException: NumberException
    {
        public NotAllNumbersPositiveException(string message) : base(message)
        {
        }

        public NotAllNumbersPositiveException(string message, Exception e) : base(message, e)
        {
        }

        public NotAllNumbersPositiveException(Exception e) : base(e)
        {
        }

        protected NotAllNumbersPositiveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}