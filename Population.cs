using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int n = 0;
            while (initialPopulation < currentPopulation)
            {
                initialPopulation = initialPopulation + Convert.ToInt32(initialPopulation * percent / 100) + visitors;
                n++;
            }
            return n;
        }
    }
}