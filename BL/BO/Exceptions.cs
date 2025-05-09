

namespace BO
{
    internal class Exceptions
    {

        [Serializable]

        public class BLIdNotFoundException : Exception
        {
            public BLIdNotFoundException(string message) : base(message) { }

            public BLIdNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
        }
        [Serializable]

        public class BLExistAlreadyException : Exception
        {
            public BLExistAlreadyException(string message) : base(message) { }

            public BLExistAlreadyException(string? message, Exception? innerException) : base(message, innerException) { }
        }
    }
}




