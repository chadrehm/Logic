using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic8
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = CheckForNumber();

            bool isRange = true;
            Console.WriteLine("Type \"y\" if you want a range of 1-10.");
            if (Console.ReadLine() == "y")
                isRange = false;


            bool printOut = InRange(number, isRange);

            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }

        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "You are in the choosen range.";
            else
                return "You are not in the choosen range.";

        }

        public static bool InRange(int n, bool outsideMode)
        {
            if (n < 1 || n > 10 &&  outsideMode == true)
                return true;
           if (n >= 1 && n <= 10 && outsideMode == false)
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
