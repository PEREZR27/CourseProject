using System;

namespace progex01
{
    class Program
    {
        private static int bottom;
        private static int height;

        // first comment
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here
            double area = Math.PI * Math.Pow(intradius, 2);
            Console.WriteLine($"The area is {area}");


            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            // Implementation here
            Console.Write("Enter an integer for the radius: ");
            string strradius1 = Console.ReadLine();
            int intradius1 = int.Parse(strradius1);
            double v2 = 2 / 3.0 * Math.PI * Math.Pow(intradius1, 3);
            double volume = v2;
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            // Implementation here
            Console.Write("Enter an integer for the bottom ");
            string strbottom = Console.ReadLine();
            int intbottom = int.Parse(strbottom);
            Console.Write("Enter an integer for the height ");
            string strheight = Console.ReadLine();
            int intheight = int.Parse(strheight);
            double v1 = intbottom * intheight * .5;
            double area1 = v1;
            Console.WriteLine($"The area is {area1}");


            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");

            // Implementation here
            Console.Write("Enter an integer for the a ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter an integer for the b ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter an integer for the c ");
            float c = float.Parse(Console.ReadLine()) ;
            double deltaRoot = Math.Sqrt(b * b - 4 * a * c);

                if(deltaRoot >= 0){ 
            double x1 = ( -b + deltaRoot) / 2.0 * a;
            double x2 = ( b + deltaRoot) / 2.0 * a;
            Console.WriteLine($"The positive solution is { x1 }");
            Console.WriteLine($"The negative solution is  { x2 }");
            }
            else
            {
                Console.WriteLine($"there are no roots");
            }
            
            
        }
    }
}




