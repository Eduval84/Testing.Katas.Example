using System;
using Xunit;

namespace Testing.Katas.Example.XUnit
{
    public class TestPasswordVerifierXUnit
    {


        /// <summary>
        /// password should not be null
        /// </summary>
        [Fact]
        public void VerifyPasswordValid()
        {

            string validPassword = "ValidPassword12";

            Assert.True(PasswordVerifier.Verify(validPassword));
        }


        /// <summary>
        /// password should not be null
        /// </summary>
        [Fact]
        public void VerifyPasswordNotBeNull()
        {

            string nullPassword = null;          

            Assert.Throws<ArgumentNullException>(() => PasswordVerifier.Verify(nullPassword));
        }

        /// <summary>
        /// password should not be null
        /// </summary>
        [Fact]
        public void VerifyPasswordNotBeEmpty()
        {

            string nullPassword = "";

            Assert.Throws<ArgumentNullException>(() => PasswordVerifier.Verify(nullPassword));
        }

        /// <summary>
        /// password not should be null
        /// password shoul have one number
        /// password not should be larger than 8 chars
        /// </summary>
        [Fact]
        public void VerifyPasswordIsNotLargerThan8Chars()
        {
            string validLengthpassword = "1Prueb";

            Assert.False(PasswordVerifier.Verify(validLengthpassword));
        }


        /// <summary>
        /// password should be larger than 8 chars
        /// </summary>
        [Fact]
        public void VerifyPasswordIsLargerThan8Chars()
        {
            string validLengthpassword = "PruebaPas12";

            Assert.True(PasswordVerifier.Verify(validLengthpassword));
        }

        /// <summary>
        /// password should be larger than 8 chars
        /// </summary>
        [Fact]
        public void VerifyPasswordIsLargerThan8Chars()
        {
            string validLengthpassword = "PruebaPas12";

            Assert.True(PasswordVerifier.Verify(validLengthpassword));
        }

    }
}