using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine("enter a number");
            double total = 0.0;
            int iterations = int.Parse(Console.ReadLine());

        Loop:


            for (int i = 0; i < iterations; i++)
            {
                double output = GetHypotenuse(rand);

                if (output <= 1.0)
                {
                    total++;
                }

                Console.WriteLine($"output is {output}");

            }
            Console.WriteLine($"Hypotenuse above one Total is {total}");
            var myPI = (4.0 * total) / iterations;
            Console.WriteLine($"Hypotenuse above one divided by iterations multiplied by four subtracted from pie is {Math.Abs((Math.PI) - myPI)}");


        }
        //static (double, double) randomNums(Random rand)
        //{
        //    double c = rand.NextDouble();
        //    double d = rand.NextDouble();

        //    return new Tuple<double, double>(c, d);
        //}
        static double GetHypotenuse(Random rand)
        {
            double c = rand.NextDouble();
            double d = rand.NextDouble();
            return Math.Sqrt((Math.Pow(c, 2) + Math.Pow(d, 2)));
        }

    }
}
/*
* 7. 10- 1,632 ms 100- 1,700 ms 1000- 2,020 ms 10000 - 3,459 ms
*1. Why do we multiply the value from step 5 above by 4? 
*Because there are four quadrants in the unit circle
2.What do you observe in the output when running your program with parameters of increasing size? 
The percentage of numbers below or equal to one remains consistently within 70 - 80% of the total iterations. 
3.If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
No because the variables change each time
4.Find a parameter that requires multiple seconds of run time. What is that parameter? 
1.0 x 10^ 10
5.How accurate is the estimated value of pi?
The double is only accurate up to 3.14159265358979000000
6.Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
Monte Carlo simulation: Drawing a large number of pseudo-random uniform variables from the interval [0,1] (much like our code) at one time, 
or once at many different times, and assigning values less than or equal to 0.50 as heads and greater than 0.50 as tails, 
is a Monte Carlo simulation of the behavior of repeatedly tossing a coin.
 */

