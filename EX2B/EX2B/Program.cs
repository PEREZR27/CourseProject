/* 3. syntatic sugar makes code more concise and easy to read*/

using System;

namespace EX2B
{
    class Program
    {
        static void Main(string[] args)
        {
            dogBark();
            dogBark("Hershey");
            dogBark("Hobo", "HaHa");
        }
        //1.
        private static void dogBark(string dog = "Brutus", string sound = "Arf Arf")
        {
            Console.WriteLine($"The {dog} goes \"{sound}\"!");
        }
        // 2.

        private static void dogBark(string dog)
        {
            dogBark(dog, "woof");
        }
        private static void dogBark()
        {
            dogBark("Frenchie", "Howl");
        }
    }
}
