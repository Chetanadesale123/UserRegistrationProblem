using NUnit.Framework;
using UserRegistrationProblem;
namespace TestUserRegestration
{
    public class UnitTest1
    {
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnFirstName(string message)
        {
            try
            {
                User us = new User("INVALID_FIRSTNAME");
                bool firstName = us.CheckFirstName("chetana");
                Assert.IsTrue(firstName);
            }
            catch(UserDetailsException ex) 
            {
                Assert.AreEqual("FirstName is invalid", ex.Message);
            }
             
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnLastName(string message)
        {
            try
            {
                User us = new User("INVALID_LASTNAME");
                bool lastName = us.CheckLASTName("Desale");
                Assert.IsTrue(lastName);
            }
            catch(UserDetailsException ex)
            {
                Assert.AreEqual("LastName Is invalid", ex.Message);
            }
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnEmail(string message)
        {
            try
            {
                User us = new User("INVALID_EMAIL");
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
            catch(UserDetailsException ex)
            {
                Assert.AreEqual("Email is Invalid",ex.Message);
            }
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnMobileNo()
        {
            try
            {
                User us = new User("INVALID_MOBILENO"); 
                bool mobileNo = us.CheckMobNo("7875278951");
                Assert.IsTrue(mobileNo);
            }
            catch(UserDetailsException ex)
            {
                Assert.AreEqual("Mobile No is invalid", ex.Message);
            }
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnPassword()
        {
            try
            {
                User us = new User("INVALID_PASSWORD");
                bool password = us.CheckPassword("@India12");
                Assert.IsTrue(password);
            }
            catch (UserDetailsException ex)
            {
                Assert.AreEqual("Password Is Invalid", ex.Message);
            }
        }
        [Test]
        [TestCase("abc@yahoo.com")]
        [TestCase("abc-100@yahoo.com")]
        [TestCase("Chetana+desale1999@gmail.com.in")]
        [TestCase("abc.100@abc.com.au")]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnEmailParameterizedTest(string emailAddress)
        {
            User us = new User("Chetana@.com");
            string result = us.CheckEmailsUsingParameterizedTest(emailAddress);
            Assert.AreEqual(result, emailAddress);
        }
    }
}