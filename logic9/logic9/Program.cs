using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic9
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = CheckForNumber();

            bool printOut = SpecialEleven(number);

            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }

        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "I love multiple of 11's. If your close I like it too.";
            else
                return "Too far from 11.";

        }

        public static bool SpecialEleven(int n)
        {
            if (n%11 == 0 || n%11 == 1 || n%11 == 9)
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
