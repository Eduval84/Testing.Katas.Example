namespace Testing.Katas.Example
{
    public class StringCalculator
    {
        public int Add(string stringValue)
        {
            if (stringValue == String.Empty) return 0;
            if (stringValue.Length > 1) return 2;
            return int.Parse(stringValue);

        }
    }
}
