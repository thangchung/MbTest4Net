namespace MbTest4Net.Exception
{
    public class MbTest4NetException : System.Exception
    {
        public MbTest4NetException(string message)
            : base(message)
        {
        }
    }

    public class NullMbTest4NetException : MbTest4NetException
    {
        public NullMbTest4NetException(string message) : base(message)
        {
        }
    }
}