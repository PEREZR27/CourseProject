using System;
namespace ProgEXA
{
    class Program
    {

        public static void Main(string[] args)
        {
            //1.
             Console.WriteLine("Number of test");
            double sum = 0;
            double testScore1 = 0;

            for (int count = 0; count < 10; count++)
            {
            sumloop:
                Console.WriteLine("Please enter a test score between 0 and 100");
                testScore1 = double.Parse(Console.ReadLine());
                if (testScore1 < 0 || testScore1 > 100)
                {
                    Console.WriteLine("Invalid input");
                    goto sumloop;
                }
                sum = sum + testScore1;

            }
            Console.WriteLine($"The sum of your test score is : {sum}");
            //2.
            double sum3 = 0;
            double testScore3 = 0;
            double average3 = 0;

            for (int count = 0; count < 10; count++)
            {
            sumloop:
                Console.WriteLine("Please enter a test score between 0 and 100");
                testScore3 = double.Parse(Console.ReadLine());
                if (testScore3 < 0 || testScore3 > 100)
                {
                    Console.WriteLine("Invalid input");
                    goto sumloop;
                }
                sum3 = sum3 + testScore3;

            }
            average3 = sum3 / 10;
            Console.WriteLine($"The average of your test score is : {Math.Round(average3, 2)}");
            if (average3 >= 90)
            {
                Console.WriteLine("A average");
            }
            else if (average3 >= 80)
            {
                Console.WriteLine("B average");
            }
            else if (average3 >= 70)
            {
                Console.WriteLine("C average");
            }
            else if (average3 >= 60)
            {
                Console.WriteLine("D average");
            }
            else
            {
                Console.WriteLine("F average");
            }
            //3.
            Console.WriteLine("Number of test");
            double sum4 = 0;
            double maxIterations = double.Parse(Console.ReadLine());
            double average = 0;
            double testScore = 0;

            for (int count = 0; count < maxIterations; count++)
            {
            sumloop:

                Console.WriteLine("Please enter a test score between 0 and 100");
                testScore = double.Parse(Console.ReadLine());
                if (testScore < 0 || testScore > 100)
                {
                    Console.WriteLine("Invalid input");
                    goto sumloop;
                }
                sum4 = sum4 + testScore;

            }
            average = sum4 / maxIterations;
            Console.WriteLine($"The average of your test score is : {Math.Round(average, 2)}");

            if (average >= 90)
            {
                Console.WriteLine("A average");
            }
            else if (average >= 80)
            {
                Console.WriteLine("B average");
            }
            else if (average >= 70)
            {
                Console.WriteLine("C average");
            }
            else if (average >= 60)
            {
                Console.WriteLine("D average");
            }
            else
            {
                Console.WriteLine("F average");
            }
            //4.
            Console.WriteLine("This console app will accept multiple test scores between 0 and 100, take the average, and the give letter grade.");
            double inputUser = 0;
            double avgUser = 0;
            double totalUser = 0;
            int j = 0;

            for (; ; )
            {
            userloop:

                Console.WriteLine("Please enter a test score between 0 and 100, when ready to quit input \"808\"");
                inputUser = double.Parse(Console.ReadLine());
                if (inputUser == 808)
                    break;
                else if(inputUser < 0 || inputUser > 100)
                {
                    Console.WriteLine("Invalid input");
                    goto userloop;
                }
                else if (inputUser > 0 || inputUser <= 100)
                {
                    totalUser = inputUser + totalUser;
                    j ++;
                }

            }
            avgUser =  totalUser / j;
            Console.WriteLine($"The average of your test score is : {Math.Round(avgUser, 2)}");

            if (avgUser >= 90)
            {
                Console.WriteLine("A average");
            }
            else if (avgUser >= 80)
            {
                Console.WriteLine("B average");
            }
            else if (avgUser >= 70)
            {
                Console.WriteLine("C average");
            }
            else if (avgUser >= 60)
            {
                Console.WriteLine("D average");
            }
            else
            {
                Console.WriteLine("F average");
            }
        }
    }

}
