using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class NoRowsAffectedException: BaseValidationException
    {
        public NoRowsAffectedException(string message) : base(message)
        {
        }

        public NoRowsAffectedException(string message, Exception e) : base(message, e)
        {
        }

        public NoRowsAffectedException(Exception e) : base(e)
        {
        }

        protected NoRowsAffectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}