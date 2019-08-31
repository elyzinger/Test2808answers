using System;
using System.Runtime.Serialization;

namespace TestWpfTargil3
{
    [Serializable]
    internal class NotUrlException : Exception
    {
        public NotUrlException()
        {
        }

        public NotUrlException(string message) : base(message)
        {
        }

        public NotUrlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotUrlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}