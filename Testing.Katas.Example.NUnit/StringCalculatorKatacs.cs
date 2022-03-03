using NUnit.Framework;

namespace Testing.Katas.Example.NUnit
{
    public class StringCalculatorKatacs
    {

        [Test]
        [TestCase("", 0)]
        private void A_simple_string_will_return_0(string input, int expectation)
        {
            StringCalculator Calculator = new StringCalculator();
            var result = Calculator.Add(input);

            Assert.Equals(result, expectation);

        }

    }
}
