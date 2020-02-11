using System;

namespace PowersOf
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerOf = new PowerOf();

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

                bool result = powerOf.isPowerOf(numberToCheck, powerToCheck);

                Console.WriteLine($"{numberToCheck} is power of {powerToCheck}: {result}");
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Couldn't convert to int");
            }

        }        
    }
}
