using System.Text.RegularExpressions;
namespace UserRegistrationProblem
{
    public class User
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILE_NUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string PASSWORD_REGEX = "^[!@#]{1}[A-Za-z0-9]{7,}$";
        public string message;
        public string firstName;
        public User(string message)
        {
            this.message = message;
            
        }
        public bool CheckFirstName(string firstName)
        { 
            try
            {
                if (NAME_REGEX != firstName )
                {
                    throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_FIRSTNAME, "name is invalid");
                }
                return Regex.IsMatch(firstName, NAME_REGEX);
            }
            catch(UserDetailsException ex)
            {
                return ex.Message == "FirstName is invalid";
            }
        }
        public bool CheckLASTName(string lastName)
        {
            try
            {
                if (NAME_REGEX != lastName)
                {
                    throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_LASTNAME, "Lastname is invalid");
                }
                return Regex.IsMatch(lastName, NAME_REGEX);
            }
            catch(UserDetailsException ex)
            {
                return ex.Message == "Last Name Is Invalid";
            }
        }
        public bool CheckEmail(string email)
        {
            try
            {
                if (NAME_REGEX != email)
                {
                    throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_EMAIL, "Email is invalid");
                }
                return Regex.IsMatch(email, EMAIL_REGEX);
            }catch(UserDetailsException ex)
            {
                return ex.Message == "Email is Invalid";
            }
            
        }
        public bool CheckMobNo(string mobileno)
        {
            try
            {
                if (NAME_REGEX != mobileno)
                {
                    throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_MOBILENO, "Mobile is invalid");
                }
                return Regex.IsMatch(mobileno, MOBILE_NUMBER_REGEX);
            }catch (UserDetailsException ex)
            {
                return ex.Message == "Mobile No is invalid";
            }
        }
        public bool CheckPassword(string password)
        {
            try
            {
                if (NAME_REGEX != password)
                {
                    throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_PASSWORD, "Password is invalid");
                }
                return Regex.IsMatch(password, PASSWORD_REGEX);
            }
            catch(UserDetailsException ex)
            {
                return ex.Message == "Password Is Invalid";
            }
        }
        public string CheckEmailsUsingParameterizedTest(string emailAddress)
        {
            if(Regex.IsMatch(emailAddress, EMAIL_REGEX))
            {
                Console.WriteLine("Email is matches");
            }
            else
            {
                Console.WriteLine("Invalid EmailId");
            }
            return emailAddress;
        }
    }
}
