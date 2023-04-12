using System.Runtime.Serialization;

namespace CalculateExceptionApp.Model
{
    [Serializable]
    internal class NegativeValueNotSupportedException : Exception
    {
        private int firstNumber;
        private int secondNumber;

        public NegativeValueNotSupportedException()
        {
        }

        public NegativeValueNotSupportedException(string? message) : base(message)
        {
        }

        public NegativeValueNotSupportedException(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public NegativeValueNotSupportedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NegativeValueNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}