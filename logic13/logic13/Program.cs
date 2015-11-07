using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = CheckForNumber();
            int number2 = CheckForNumber();
            int number3 = CheckForNumber();

            bool printOut = TwoIsOne(number1,number2,number3);
       
            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }

        public static bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c)
                return true;
            if (a + c == b)
                return true;
            if (b + c == a)
                return true;
            return false;
        }

        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "Two add to the third.";
            else
                return "These don't add to each other.";
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
