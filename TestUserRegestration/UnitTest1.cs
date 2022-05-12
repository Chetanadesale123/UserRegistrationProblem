using NUnit.Framework;
using UserRegistrationProblem;
namespace TestUserRegestration
{
    public class UnitTest1
    {
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnFirstName()
        {
            User us = new User();
            bool firstName = us.CheckFirstName("Chetana");
            Assert.IsTrue(firstName);
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnLastName()
        {
            User us = new User();
            bool lastName = us.CheckFirstName("Desale");
            Assert.IsTrue(lastName);
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnEmail()
        {
            User us = new User();
            bool email = us.CheckEmail("Chetana+desale1999@gmail.com.in");
            Assert.IsTrue(email);
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnMobileNo()
        {
            User us = new User();
            bool mobileNo = us.CheckMobNo("7987612345");
            Assert.IsTrue(mobileNo);
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnPassword()
        {
            User us = new User();
            bool password = us.CheckPassword("@India12");
            Assert.IsTrue(password);
        }
    }
}