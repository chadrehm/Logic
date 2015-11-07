using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = CheckForNumber();

            bool printOut = Mod20(number);

            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }

        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "That is a multiple of 3 or 5.";
            else
                return "Either thats not a multiple of 3 or 5 or its a multiple of both.";
        }

        public static bool Mod20(int n)
        {
            if (n % 3 == 0 || n % 5 == 0)
                if (n%3 == 0 && n%5 == 0)
                    return false;
                else
                    return true;
            return false;
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
