using NUnit.Framework;

namespace Testing.Katas.Example.NUnit
{
    public class StringCalculatorKatacs
    {

        [Test]
        [TestCase("", 0)]
        public void should_returs_zero_when_string_is_empty(string input, int expectation)
        {

            StringCalculator Calculator = new StringCalculator();
            int result = Calculator.Add(input);

            Assert.AreEqual(result, expectation);

        }

        [Test]
        [TestCase("1", 1)]
        public void should_return_a_number_1_when_string_contains_a_number_1(string input, int expectation)
        {

            StringCalculator Calculator = new StringCalculator();
            int result = Calculator.Add(input);

            Assert.AreEqual(result, expectation);

        }

        [Test]
        [TestCase("2", 2)]
        public void should_return_a_number_2_when_string_contains_a_number_1(string input, int expectation)
        {

            StringCalculator Calculator = new StringCalculator();
            int result = Calculator.Add(input);

            Assert.AreEqual(result, expectation);

        }

    }
}
