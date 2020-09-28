using System;
using System.Threading;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[2];
            double[] y = new double[2];
            double[] length = new double[2];
            int lineCount = 0;

            Random random = new Random();

            while (lineCount < 2)
            {
                for (int index = 0; index < 2; index++)
                {
                    x[index] = random.Next(-100, 100);
                    y[index] = random.Next(-100, 100);
                }
                Console.WriteLine("Coordinates of line {0} are ({1}, {2}) & ({3}, {4})", lineCount + 1, x[0], y[0], x[1], y[1]);

                length[lineCount] = Math.Sqrt(Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2));
                Console.WriteLine("Length of the line {0}: {1}", lineCount + 1, Math.Round(length[lineCount], 4));

                lineCount++;
            }

            int value = length[0].CompareTo(length[1]);
            if (value < 0)
                Console.WriteLine("Line 1 is smaller than Line 2");
            else if (value == 0)
                Console.WriteLine("Both the lines are equal");
            else
                Console.WriteLine("Line 1 is greater than Line 2");
        }
    }
}