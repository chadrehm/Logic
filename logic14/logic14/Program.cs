using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = CheckForNumber();
            int number2 = CheckForNumber();
            int number3 = CheckForNumber();

            bool isBok = false;
            Console.WriteLine("Is b Ok (y/n)?");
            if (Console.ReadLine() == "y")
                isBok = true;

            bool printOut = AreInOrder(number1, number2, number3,isBok);

            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }

        public static bool AreInOrder(int a, int b, int c,bool bOk)
        {
            if (bOk == true)
            {
                if (c > b)
                    return true;
            }
            if (b > a && c > b )
                return true;
            return false;
        }

        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "C is the biggest.";
            else
                return "Its hard to see who is the biggest.";
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
