using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRes.Exceptions
{
    public class UserInputException : ApplicationException
    {
        public string MessageForUser { get; set; }
        public UserInputException(string message)
        {
            MessageForUser = message;
        }
    }
}
