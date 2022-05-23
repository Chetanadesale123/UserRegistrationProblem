using NUnit.Framework;
using UserRegistrationProblem;
namespace TestUserRegestration
{
    public class UnitTest1
    {
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnFirstName()
        {
            try
            {
                User us = new User("INVALID_FIRSTNAME");
                bool firstName = us.CheckFirstName("Chetana");
                Assert.IsTrue(firstName);
            }
            catch(UserDetailsException ex) 
            {
                Assert.AreEqual(ex.Message,"FirstName is invalid");
            }
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnLastName()
        {
            try
            {
                User us = new User("INVALID_LASTNAME");
                bool lastName = us.CheckLastName("Desale");
                Assert.IsTrue(lastName);
            }
            catch(UserDetailsException ex)
            {
                Assert.AreEqual(ex.Message, "LastName Is invalid");
            }
        }
        [Test]
        public void GivenStringInput_WhenTestUserRegistration_ShouldReturnEmail()
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
                Assert.AreEqual(ex.Message,"Email is Invalid");
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
                bool password = us.CheckPassWord("@India12");
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
            try
            {
                User us = new User("INVALID_EMAIL");
                bool result = us.CheckEmailsUsingParameterizedTest("Chetana+desale1999@gmail.com.in");
            }
            catch (UserDetailsException ex)
            {
                Assert.AreEqual(ex.Message,"Email is Invalid");
            }
        }
    }
}