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
            Console.WriteLine($"Hypotenuse above one divided by iterations multiplied by four is {(4.0 * total) / iterations}");
            Console.WriteLine($"Hypotenuse above one divided by iterations multiplied by four subtracted from pie is {Math.Abs((Math.PI)) - (total / iterations) * 4}");
            //foreach (string arg in args)
            //    Console.WriteLine("arg");


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

