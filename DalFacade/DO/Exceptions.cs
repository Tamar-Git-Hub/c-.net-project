

namespace DO;

[Serializable]

public class DalIdNotFoundException : Exception
{
    public DalIdNotFoundException(string message) : base(message) { }

    public DalIdNotFoundException(string? message, Exception? innerException) :base(message, innerException) { }
}
[Serializable]

public class DalExistAlreadyException : Exception
{
    public DalExistAlreadyException(string message) : base(message) { }

    public DalExistAlreadyException(string? message, Exception? innerException) : base(message, innerException) { }
}