using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = CheckForNumber();
            int number2 = CheckForNumber();
            int number3 = CheckForNumber();

            bool isBok = false;
            Console.WriteLine("Is it Ok be equal (y/n)?");
            if (Console.ReadLine() == "y")
                isBok = true;

            bool printOut = InOrderEqual(number1, number2, number3, isBok);

            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }

        public static bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk == true)
            {
                if (a <= b && b <= c)
                    return true;
            }
            if (a < b && b < c)
                return true;
            return false;
        }

        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "First number <= Second number <= Third number.";
            else
                return "Not assending or equal not ok.";
        }

        private static int CheckForNumber()
        {
            bool validInput = false;
            int numberCheck;
            do
            {
                Console.WriteLine("Enter a number.");
                validInput = int.TryParse(Console.ReadLine(), out numberCheck);
                if (!validInput)
                    Console.WriteLine("That is not a number");
            } while (!validInput);
            return numberCheck;
        }
    }
}
