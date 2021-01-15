using System;
using System.Runtime.Serialization;

namespace AufgabeZwei
{
    [Serializable]
    internal class LaengeBreiteException : Exception
    {
        public LaengeBreiteException()
        {
        }

        public LaengeBreiteException(string message) : base(message)
        {
        }

        public LaengeBreiteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LaengeBreiteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}