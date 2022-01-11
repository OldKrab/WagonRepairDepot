using System;
using System.Runtime.Serialization;

namespace WagonRepairDepot
{
    [Serializable]
    internal class ReferenceConstraintException : Exception
    {
        public ReferenceConstraintException()
        {
        }

        public ReferenceConstraintException(string? message) : base(message)
        {
        }

        public ReferenceConstraintException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ReferenceConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}