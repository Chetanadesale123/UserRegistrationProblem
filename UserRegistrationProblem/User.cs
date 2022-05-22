using System.Text.RegularExpressions;
namespace UserRegistrationProblem
{
    public class User
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILE_NUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string PASSWORD_REGEX = "^[!@#]{1}[A-Za-z0-9]{7,}$";
        public bool CheckFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, NAME_REGEX);
        }
        public bool CheckLASTName(string lastName)
        {
            return Regex.IsMatch(lastName, NAME_REGEX);
        }
        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
        public bool CheckMobNo(string mobileno)
        {
            return Regex.IsMatch(mobileno, MOBILE_NUMBER_REGEX);
        }
        public bool CheckPassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD_REGEX);
        }
    }
}