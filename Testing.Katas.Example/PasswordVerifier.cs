// Copyright (c) Eduardo Valderrama

using System.Runtime.Serialization;

namespace Testing.Katas.Example
{
    /// <summary>
    /// PasswordVerifier
    /// </summary>
    public class PasswordVerifier
    {

        private readonly Dictionary<IRule, bool> conditionsToVerify;

        public PasswordVerifier(IEnumerable<IRule> rules, string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new IncorrectPassword("Password is null or empty");

            conditionsToVerify = new Dictionary<IRule, bool>();


            foreach (var rule in rules)
            {
                conditionsToVerify.Add(rule, rule.ConditionToValidate(password));
            }
        }

        public string Verify()
        {
            ErrorMessage();
            return Validation();
        }

        private string Validation()
        {
            return ConditionChecker() >=3 ? "Valid" : "Invalid";
        }

        private int ConditionChecker()
        {
            return conditionsToVerify.Values.Count(value => value.Equals(true));
        }

        private void ErrorMessage()
        {
            var key = conditionsToVerify.Where(failingRule => failingRule.Value == false)
                .Select(failingRule => failingRule.Key).ToList();

            if (key.Any())
                throw new IncorrectPassword(key.First().ExceptionMessage);
        }
    }

    public class ContainsAtLeastOneUppercaseCharacter : IRule
    {
        public string ExceptionMessage { get; }

        public ContainsAtLeastOneUppercaseCharacter()
        {
            ExceptionMessage = "Password should contain at least one uppercase character";
        }

        public bool ConditionToValidate(string password)
        {
            return password.Any(char.IsUpper);
        }
    }

    public class ContainsAtLeastOneLowercaseCharacter : IRule
    {
        public string ExceptionMessage { get; }

        public ContainsAtLeastOneLowercaseCharacter()
        {
            ExceptionMessage = "Password should contain at least one lowercase character";
        }

        public bool ConditionToValidate(string password)
        {
            return password.Any(char.IsLower);
        }
    }

    public class ContainsAtLeastOneNumber : IRule
    {
        public string ExceptionMessage { get; }

        public ContainsAtLeastOneNumber()
        {
            ExceptionMessage = "Password should contain at least one number";
        }

        public bool ConditionToValidate(string password)
        {
            return password.Any(char.IsNumber);
        }
    }
    public class MoreThanEightCharacters : IRule
    {
        public string ExceptionMessage { get; }

        public MoreThanEightCharacters()
        {
            ExceptionMessage = "Password should be at least 8 characters";
        }

        public bool ConditionToValidate(string password)
        {
            return password.Length > 8;
        }
    }

    public interface IRule
    {
        string ExceptionMessage { get; }
        bool ConditionToValidate(string conditionToTest);
    }

    [Serializable]
    public class IncorrectPassword : Exception
    { 

        public IncorrectPassword(string message) : base(message)
        {
        }

    }
}