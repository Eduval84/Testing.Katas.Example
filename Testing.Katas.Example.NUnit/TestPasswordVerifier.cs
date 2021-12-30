using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Testing.Katas.Example.Test
{
    [TestFixture]
    [Category("PasswordVerifyerKata NET Core")]
    public class TestPasswordVerifier
    {

        private readonly IEnumerable<IRule> rules = new IRule[]
        {
            new MoreThanEightCharacters(),
            new ContainsAtLeastOneUppercaseCharacter(),
            new ContainsAtLeastOneLowercaseCharacter(),
            new ContainsAtLeastOneNumber()
        };

        [TestCase("ValidPass12", "Valid")]
        public void Should_verify_password(string password, string expectation)
        {
            var verifier = new PasswordVerifier(rules, password);
            Assert.AreEqual(verifier.Verify(), expectation);
        }

        [TestCase("short1", "Password should be at least 8 characters")]
        [TestCase("1passwithoutupper", "Password should contain at least one uppercase character")]
        [TestCase("1PASSWITHOUTLOWER", "Password should contain at least one lowercase character")]
        [TestCase("Passwithoutnumber", "Password should contain at least one number")]
        public void Passwords_throws_exception_if_conditions_not_met(string password, string exceptation)
        {
            var verifier = new PasswordVerifier(rules, password);
            var ex = Assert.Throws<IncorrectPassword>(() => verifier.Verify());
            Assert.That(ex.Message, Is.EqualTo(exceptation));
        }

        [Test]
        public void Should_return_invalid_for_null_passwords()
        {
            var ex = Assert.Throws<IncorrectPassword>(() => new PasswordVerifier(rules, null));
            Assert.AreEqual(ex.Message, "Password is null or empty");
        }

    }
}