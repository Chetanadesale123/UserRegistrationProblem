using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserDetailsException:Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,INVALID_LASTNAME,INVALID_EMAIL,INVALID_MOBILENO,INVALID_PASSWORD
        }
        public ExceptionType exceptionType;
        public UserDetailsException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
