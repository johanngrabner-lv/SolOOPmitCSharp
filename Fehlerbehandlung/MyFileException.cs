using System;
using System.Runtime.Serialization;

namespace Fehlerbehandlung
{
    [Serializable]
    internal class MyFileException : Exception
    {
        public MyFileException()
        {
        }

        public MyFileException(string message) : base(message)
        {
        }

        public MyFileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}