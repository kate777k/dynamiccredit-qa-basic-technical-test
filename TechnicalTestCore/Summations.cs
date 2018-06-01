namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int sumOfNumbers = 0;
            for (int i = 1; i <= maxNrAsInt; i++)
            {
                sumOfNumbers = sumOfNumbers + i;
            }
            return sumOfNumbers;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            uint maxNrAsInt = uint.Parse(maxNrAsString);
            uint sumOfNumbers = 0;
            for (uint i = 1; i <= maxNrAsInt; i++)
            {
                sumOfNumbers = sumOfNumbers + i;
            }
            return sumOfNumbers.ToString();            
        }
    }
}
