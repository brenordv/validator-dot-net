using System;
using System.Runtime.Serialization;

namespace Raccoon.Ninja.ValidatorDotNet.Exceptions
{
    [Serializable]
    public class ElementComparisonException: BaseValidationException
    {
        public ElementComparisonException(string message) : base(message)
        {
        }

        public ElementComparisonException(string message, Exception e) : base(message, e)
        {
        }

        public ElementComparisonException(Exception e) : base(e)
        {
        }
        
        protected ElementComparisonException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}