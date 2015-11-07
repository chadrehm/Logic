using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int numberA = CheckForNumber();
            int numberB = CheckForNumber();

            bool printOut = LoveSix(numberA, numberB);

            Console.WriteLine(Responds(printOut));
            Console.ReadLine();
        }

        private static string Responds(bool printOut)
        {
            if (printOut == true)
                return "I love six! Wait I said six, right.";
            else
                return "No sixes come on man.";

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
        public static bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6 || a + b == 6)
                return true;
            else
                return false;
        }
        
    }
}
