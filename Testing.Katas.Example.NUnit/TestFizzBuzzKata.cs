using NUnit.Framework;

namespace Testing.Katas.Example.NUnit
{
    [TestFixture]
    [Category("FizzBuzzKata")]
    public class TestFizzBuzzKata
    {
        [Test]
        public void GivenNumberBelowOne_ReturnEmptyString()
        {
            var result = FizzBuzzKata.Generate(-1);

            Assert.That(result, Is.Empty);
        }

        [TestCase(1, "1,")]
        [TestCase(2, "1,2,")]       
        public void GivenNumberUpTo2_ReturnNumbersCommaDelimited(int input, string expectation)
        {
            Assert.AreEqual(FizzBuzzKata.Generate(input), expectation);
        }

        [TestCase(3, "1,2,Fizz,")]
        [TestCase(6, "1,2,Fizz,4,Buzz,Fizz,")]
        [TestCase(9, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,")]
        public void GivenNumberDividedBy_ReturnFizzInstead(int input, string expectation)
        {
            Assert.AreEqual(FizzBuzzKata.Generate(input), expectation);
        }

        [TestCase(5, "1,2,Fizz,4,Buzz,")]
        [TestCase(10, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,")]
        public void GivenNumberDividedBy5_ReturnBuzzInstead(int input, string expectation)
        {
            Assert.AreEqual(FizzBuzzKata.Generate(input), expectation);
        }

        [TestCase(15, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,")]
        public void GivenNumberDividedBy3And5_ReturnFizzBuzzInstead(int input, string expectation)
        {
            Assert.AreEqual(FizzBuzzKata.Generate(input), expectation);
        }
    }
}
