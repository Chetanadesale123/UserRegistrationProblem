using NUnit.Framework;
using UserRegistrationProblem;
namespace TestUserRegestration
{
    public class UnitTest1
    {
        [Test]
        public void TestFirstName()
        {
            User us = new User();
            bool firstName = us.CheckFirstName("Chetana");
            Assert.IsTrue(firstName);
        }
        [Test]
        public void TestLastName()
        {
            User us = new User();
            bool lastName = us.CheckFirstName("Desale");
            Assert.IsTrue(lastName);
        }
        [Test]
        public void TestEmail()
        {
            User us = new User();
            bool email = us.CheckEmail("Chetana+desale1999@gmail.com.in");
            Assert.IsTrue(email);
        }
    }
}