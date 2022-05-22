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
            bool lastName = us.CheckLASTName("Desale");
            Assert.IsTrue(lastName);
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnEmail()
        {
            User us = new User();
            
            bool email = us.CheckEmail("Chetana+desale1999@gmail.com.in");
            bool email1 = us.CheckEmail("abc@yahoo.com");
            bool email2 = us.CheckEmail("abc-100@yahoo.com");
            bool email3 = us.CheckEmail("abc.100@yahoo.com");
            bool email4 = us.CheckEmail("abc111@abc.com");
            bool email5 = us.CheckEmail("abc-100@abc.net");
            bool email6 = us.CheckEmail("abc.100@abc.com.au");
            bool email7 = us.CheckEmail("abc@1.com");
            bool email8 = us.CheckEmail("abc@gmail.com.com");
            bool email9 = us.CheckEmail("abc+100@gmail.com");
            Assert.IsTrue(email);
            Assert.IsTrue(email1);
            Assert.IsTrue(email2);
            Assert.IsTrue(email3);
            Assert.IsTrue(email4);
            Assert.IsTrue(email5);
            Assert.IsTrue(email6);
            Assert.IsTrue(email7);
            Assert.IsTrue(email8);
            Assert.IsTrue(email9);
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