using System;
using System.Runtime.Serialization;

namespace Klausurvorbereitung
{
    [Serializable]
    internal class NachnameException : Exception
    {
        public NachnameException()
        {
        }

        public NachnameException(string message) : base(message)
        {
        }

        public NachnameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NachnameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}