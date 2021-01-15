using System;
using System.Runtime.Serialization;

namespace AufgabeZwei
{
    [Serializable]
    internal class MyLaengeBreiteException : Exception
    {
        public MyLaengeBreiteException()
        {
        }

        public MyLaengeBreiteException(string message) : base(message)
        {
        }

        public MyLaengeBreiteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyLaengeBreiteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}