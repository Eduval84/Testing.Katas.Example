namespace Testing.Katas.Example
{
    public class StringCalculator
    {
        public int Add(string stringValue)
        {
            if (stringValue == String.Empty) return 0;
            if (stringValue.Length > 1) {
                int sumNumbers = 0;
                string[] numbers = stringValue.Split(',');
                for (int i = 0; i < numbers.Length; i++){
                    sumNumbers += int.Parse(numbers[i]);
                }
                return sumNumbers;
            }

            return int.Parse(stringValue);

        }
    }
}
