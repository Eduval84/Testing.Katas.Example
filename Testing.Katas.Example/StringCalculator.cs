namespace Testing.Katas.Example
{
    public class StringCalculator
    {
        public int Add(string stringValue)
        {
            if (stringValue == String.Empty) return 0;
            if (stringValue.Length > 1)
            {
                int sumNumbers = 0;
                string[] numbers = SplitStringValue(stringValue);
                foreach (string n in numbers)
                {
                    sumNumbers += int.Parse(n);
                }
                return sumNumbers;
            }

            return int.Parse(stringValue);

        }

        private static string[] SplitStringValue(string stringValue)
        {
            
            return stringValue.Split(',');
        }
    }
}
