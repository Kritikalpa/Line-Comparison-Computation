using System;
using System.Threading;

namespace LineComparison
{
    public class Line
    {
        public double[] x = new double[2];
        public double[] y = new double[2];
        public int lineNum;
        public double lineLength;

        Random random = new Random();
        public Line(int lineNum)
        {
            
            this.lineNum = lineNum;
            for (int index = 0; index < 2; index++)
            {
                this.x[index] = random.Next(-100, 100);
                this.y[index] = random.Next(-100, 100);
            }
        }
        public void computeLineLength()
        {
            this.lineLength = Math.Sqrt(Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2));
        }

        public void toString()
        {
            Console.WriteLine("Coordinates of line {0} are ({1}, {2}) & ({3}, {4})", this.lineNum, x[0], y[0], x[1], y[1]);
            Console.WriteLine("Length of Line {0} is {1} ", this.lineNum, Math.Round(this.lineLength, 4));
        }
    }

    public class LineComparison 
    { 
        public void checkEquality(Line line1, Line line2)
        {
            if (line1.lineLength.Equals(line2.lineLength))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }

        public void compareLines(Line line1, Line line2)
        {
            int value = line1.lineLength.CompareTo(line2.lineLength);
            if (value < 0)
                Console.WriteLine("Line 1 is smaller than Line 2");
            else if (value == 0)
                Console.WriteLine("Both the lines are equal");
            else
                Console.WriteLine("Line 1 is greater than Line 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line(1);
            Line line2 = new Line(2);

            line1.computeLineLength();
            line2.computeLineLength();

            line1.toString();
            line2.toString();

            LineComparison lineToLineCompare = new LineComparison();
            lineToLineCompare.checkEquality(line1, line2);
            lineToLineCompare.compareLines(line1, line2);
            
        }
    }
}