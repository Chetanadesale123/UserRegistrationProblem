using System.Text.RegularExpressions;
namespace UserRegistrationProblem
{
    public class User
    {
        public static string First_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool CheckFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, First_NAME_REGEX);
        }
        public bool CheckLASTName(string lastName)
        {
            return Regex.IsMatch(lastName, LAST_NAME_REGEX);
        }
    }
}