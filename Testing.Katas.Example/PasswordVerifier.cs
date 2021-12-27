// Copyright (c) Eduardo Valderrama

namespace Testing.Katas.Example
{
    /// <summary>
    /// PasswordVerifier
    /// </summary>
    public class PasswordVerifier
    {

        /// <summary>
        /// Verifies the specified password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>Bool indicates if password is valid</returns>
        public static bool Verify(string password)
        {
            bool correctPassword = true;

            IsPasswordPassedNullOrEmptyRule(password);            
            if (IsPasswordPassedLengthRule(password, 8) == false)
                return false;
            if (PasswordHaveOneUpperCaseLetterAtLeast(password) == false)
                return false;
            if (PasswordHaveOneLowerCaseLetterAtLeast(password) == false)
                return false;
            if (PasswordHaveOneNumberAtLeast(password) == false)
                return false;

            return correctPassword;
        }
            

        private static bool IsPasswordPassedNullOrEmptyRule(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Null or Empty Rule Violation. Password should not be null or empty");
            return true;
        }

        private static bool IsPasswordPassedLengthRule(string password, int minlength)
        {
            return (password.Length > minlength) ;            
        }

        private static bool PasswordHaveOneUpperCaseLetterAtLeast(string password)
        {
            return (password.Any(char.IsUpper));               
        }

        private static bool PasswordHaveOneLowerCaseLetterAtLeast(string password)
        {
            return (password.Any(char.IsLower));                
        }

        private static bool PasswordHaveOneNumberAtLeast(string password)
        {
            return (password.Any(char.IsNumber));
        }
    }
}