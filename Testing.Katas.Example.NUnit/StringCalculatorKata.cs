using NUnit.Framework;

namespace Testing.Katas.Example.NUnit
{
    public class StringCalculatorKata
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
        [TestCase("5", 5)]
        [TestCase("9", 9)]
        public void should_return_a_number_when_string_contains_a_number(string input, int expectation)
        {

            StringCalculator Calculator = new StringCalculator();
            int result = Calculator.Add(input);

            Assert.AreEqual(result, expectation);

        }

        [Test]
        [TestCase("1,1",2)]
        [TestCase("2,1", 3)]
        [TestCase("2,2", 4)]
        public void Should_return_the_sum_when_the_input_is_a_string_of_two_numbers_separated_by_commas(string input, int expectation)
        {
            StringCalculator Calculator = new StringCalculator();
            int result = Calculator.Add(input);

            Assert.AreEqual(result, expectation);
        }

        [Test]
        [TestCase("1\n2", 3)]
        [TestCase("1\n2,3", 6)]        
        public void Should_return_the_sum_when_the_input_is_a_string_of_two_numbers_separated_by_new_lines(string input, int expectation)
        {
            StringCalculator Calculator = new StringCalculator();
            int result = Calculator.Add(input);

            Assert.AreEqual(result, expectation);
        }

    }
}
