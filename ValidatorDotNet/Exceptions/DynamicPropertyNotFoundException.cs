using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class DynamicPropertyNotFoundException : BaseValidationException
    {
        public DynamicPropertyNotFoundException(string message) : base(message)
        {
        }

        public DynamicPropertyNotFoundException(string message, Exception e) : base(message, e)
        {
        }

        public DynamicPropertyNotFoundException(Exception e) : base(e)
        {
        }
        
        protected DynamicPropertyNotFoundException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}