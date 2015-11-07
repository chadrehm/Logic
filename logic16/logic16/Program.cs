using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic16
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = CheckForNumber();
            int number2 = CheckForNumber();
            int number3 = CheckForNumber();

            bool printOut = LastDigit(number1, number2, number3);

            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }

        public static bool LastDigit(int a, int b, int c)
        {

            if (Math.Abs(a - b) % 10 == 0 || Math.Abs(a - c) % 10 == 0 || Math.Abs(b - c) % 10 == 0)
                    return true;
            return false;
        }

        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "Two numbers have the same last digits.";
            else
                return "None of the numbers have the same last digits.";
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
