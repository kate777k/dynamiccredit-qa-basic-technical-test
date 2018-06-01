namespace TechnicalTestCore
{
    using System.Collections.Generic;
    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int minElement = intlist[0];
            for (int i = 1; i < intlist.ToArray().Length; i++)
            {
                if (minElement > intlist[i])
                {
                    minElement = intlist[i];
                }
            }
            return minElement;
        }
    }
}
