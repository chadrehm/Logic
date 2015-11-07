using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic10
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
                return "If your 1 or 2 over a muliple of 20, I like it.";
            else
                return "That number sucks.";
        }

        public static bool Mod20(int n)
        {
            if (n % 20 == 1 || n % 20 == 2)
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
