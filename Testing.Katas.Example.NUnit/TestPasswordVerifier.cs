using NUnit.Framework;
using System;

namespace Testing.Katas.Example.Test
{
    [TestFixture]
    [Category("PasswordVerifyerKata NET Core")]
    public class TestPasswordVerifier
    {

        /// <summary>
        /// Verify password should not be null or empty.
        /// </summary>
        /// <param name="password">String to test.</param>  
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("ValidPassword12", true)]
        [TestCase("inValidPasswordwithoutnumber", false)]
        [TestCase("invalidpass12withoutupperletter", false)]
        [TestCase("INVALIDPASS12WITHOUTLOWERLETTER", false)]
        [Test]
        public void VerifyValidPassword(string password, bool expectedResult)
        {
            var result = PasswordVerifier.Verify(password);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        /// <summary>
        /// Verify password should not be null or empty.
        /// </summary>
        /// <param name="nullPassword">String to test.</param>             
        [TestCase(null)]
        [TestCase("")]        
        [Test]
        public void VerifyPasswordNotBeNullorEmpty(string nullPassword)
        {

            Assert.Throws<ArgumentNullException>(() => PasswordVerifier.Verify(nullPassword));

        }

        /// <summary>
        /// Verify password Lenght. 
        /// Verify password should be larger than 8 chars.
        /// </summary>
        /// <param name="validLength">String to test.</param>      
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("Password12", true)]
        [Test]
        public void VerifyPasswordIsLargerThan8Chars(string validLength, bool expectedResult)
        {
            var result = PasswordVerifier.Verify(validLength);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        /// <summary>
        /// Verify password Lenght. 
        /// Verify password should be larger than 8 chars.
        /// </summary>
        /// <param name="inValidLength">String to test.</param>  
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("Password", false)]
        [TestCase("Pass",false)]
        [Test]
        public void VerifyPasswordIsNotLargerThan8Chars(string inValidLength, bool expectedResult)
        {
            var result = PasswordVerifier.Verify(inValidLength);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        /// <summary>
        /// Verify password format should have one upper letter at least
        /// </summary>
        /// <param name="password">String to test.</param>      
        /// <param name="expectedResult">The expected result.</param>    
        [TestCase("passWhitUpperLetter12", true)]
        [TestCase("passwhitoutupperletter12", false)]
        [Test]
        public void VerifyPasswordShouldHaveOneUppercaseLetterAtLeast(string password, bool expectedResult)
        {
            var result = PasswordVerifier.Verify(password);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        /// <summary>
        /// Verify password format and should have one lower letter at least
        /// </summary>
        /// <param name="password">String to test.</param>      
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("PassWithLowLetter12", true)]
        [TestCase("PASSWITHOUTLOWERLETTER12", false)]
        [Test]
        public void VerifyPasswordShouldHaveOneLowercaseLetterAtLeast(string password, bool expectedResult)
        {
            var result = PasswordVerifier.Verify(password);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        /// <summary>
        /// Verify password format and should have one number at least
        /// </summary>
        /// <param name="password">String to test.</param>      
        /// <param name="expectedResult">The expected result.</param>
        //[TestCase("PASSWITHOUTLOWERLETTER", false)]
        [TestCase("PassValid12", true)]
        [TestCase("Pass69Valid", true)]
        [TestCase("PassInvalid", false)]
        [Test]
        public void VerifyPasswordShouldHaveOneNumberAtLeast(string password, bool expectedResult)
        {
            var result = PasswordVerifier.Verify(password);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

    }
}