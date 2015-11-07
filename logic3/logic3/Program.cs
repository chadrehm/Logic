using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temprature outside.");
            int temprature = Int32.Parse(Console.ReadLine());

            bool isSummer = false;
            Console.WriteLine("Is it summer (y/n)?");
            if (Console.ReadLine() == "y")
                isSummer = true;


            bool printOut = PlayOutside(temprature, isSummer);

            Console.WriteLine(Responds(printOut));
            Console.ReadLine();
        }
        private static string Responds(bool printOut)
        {
            if (printOut == true)
                return "Go out and play!";
            else
                return "We will need to stay inside.";

        }
        public static bool PlayOutside(int temp, bool isSummer)
        {
            if (temp >= 60 && temp <= 90 && isSummer == false)
                return true;
            else if (temp >= 60 && temp <= 100 && isSummer == true)
                return true;
            else
                return false;
        }
    }
}
