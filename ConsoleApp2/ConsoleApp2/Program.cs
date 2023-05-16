using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");

            int n = int.Parse(Console.ReadLine());
            double[] items = new double[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter item {0}: ", i + 1);
                items[i] = double.Parse(Console.ReadLine());
            }


            Array.Sort(items);
            double median;
            if (n % 2 == 0)
            {
                median = (items[n / 2 - 1] + items[n / 2]) / 2.0;
            }
            else
            {
                median = items[n / 2];
            }
            Console.WriteLine("Median =" + median);

            double range = items.Max() - items.Min();

            Console.WriteLine("Range=" + range);

            double q1 = items[n / 4];

            double q3 = items[(n * 3) / 4];

            Console.WriteLine("Q1=" + q1);

            Console.WriteLine("Q3=" + q3);

            double p90 = items[(n * 90 / 100)];

            Console.WriteLine("p90=" + p90);
            double iqr = q3 - q1;
            Console.WriteLine("Interquartile Range=" + iqr);

            double lower = q1 - 1.5 * iqr;

            double upper = q3 + 1.5 * iqr;

            Console.WriteLine("Outlier Boundaries= " + lower + " , " + upper);

            Console.Write("Enter an input value to check for outlier: ");
            double input = double.Parse(Console.ReadLine());

            if (input < lower || input > upper)
            {
                Console.WriteLine("{0} is an outlier." + input);
            }
            else
            {
                Console.WriteLine("{0} is not an outlier." + input);
            }
        }
    }
}
