using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = CheckForNumber();
            int sum2 = CheckForNumber();

            string printOut = WhattoPrint(SkipSum(sum1, sum2));
            Console.WriteLine("{0} + {1} {2}",sum1,sum2,printOut);
            Console.ReadLine();
        }

        private static string WhattoPrint(int printOut)
        {
            if (printOut == 20)
                return "!= " + printOut;
         
            else
                return "= " + printOut;

        }

        public static int SkipSum(int a, int b)
        {
            int sumAB = a + b;
            if (sumAB >= 10 && sumAB <= 19)
                return 20;
            return sumAB;

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
