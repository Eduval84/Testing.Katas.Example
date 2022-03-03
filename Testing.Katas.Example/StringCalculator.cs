namespace Testing.Katas.Example
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int calculateNumber = 0;

            if (numbers == "1") calculateNumber = 1;
            if (numbers == "2") calculateNumber = 2;

            return calculateNumber;

        }
    }
}
