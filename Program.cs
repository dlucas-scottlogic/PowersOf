using System;

namespace PowersOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check :");
            var numberToCheckInput = Console.ReadLine();
            Console.WriteLine("Enter power to check for :");
            var powerToCheckInput = Console.ReadLine();
            int numberToCheck = 0;
            int powerToCheck = 0;

            try
            {
                numberToCheck = int.Parse(numberToCheckInput);
                powerToCheck = int.Parse(powerToCheckInput);

                bool result = isPowerOf(numberToCheck, powerToCheck);

                Console.WriteLine($"{numberToCheck} is power of {powerToCheck}: {result}");
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Couldn't convert to int");
            }

        }

        public static bool isPowerOf(int x, int powerToCheck)
        {
            if (!(x > 0))
            {
                return false;
            }

            if (x == 1)
            {
                return true;
            }

            // check if x is evenly divisible by the power we want to test.
            if (!(x % powerToCheck == 0))
            {
                return false;
            }

            return isPowerOf(x / powerToCheck, powerToCheck);
        }
    }
}
