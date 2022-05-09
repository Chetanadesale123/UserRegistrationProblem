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
    }
}