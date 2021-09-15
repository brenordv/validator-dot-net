using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class EmptyListException: BaseValidationException
    {
        public EmptyListException(string message) : base(message)
        {
        }

        public EmptyListException(string message, Exception e) : base(message, e)
        {
        }

        public EmptyListException(Exception e) : base(e)
        {
        }


        protected EmptyListException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}