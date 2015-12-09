using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

    public class RuleMbTest4NetException : NullMbTest4NetException
    {
        private readonly List<ValidationResult> _errors;

        public RuleMbTest4NetException(List<ValidationResult> errors)
            : base("")
        {
            _errors = errors;
        }

        public override string Message
        {
            get
            {
                var message = "";
                foreach (var error in _errors)
                {
                    message += error.ErrorMessage + "\n";
                }
                return message;
            }
        }
    }
}