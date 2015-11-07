using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic1
{
    class Program
    {
        static void Main(string[] args)
        {

            int cigars = CheckForNumber();

            bool isWeekday = CheckForBool();
            

            
            bool printOut = GreatParty(cigars,isWeekday);

            Console.WriteLine(ForCouncel(printOut));
            Console.ReadLine();
        }
        private static string ForCouncel(bool printOut)
        {
            if (printOut == true)
                return "The party was successful!";
            else
                return "Try more advertising.";

        }
        public static bool GreatParty(int cigars, bool isWeekend)
        {
            if (cigars >= 40 && cigars <= 60 && isWeekend == true)
                return true;
            if (cigars >= 40 && isWeekend == false)
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
        private static bool CheckForBool()
        {
            bool validInput;
            bool userChoose = false;
            do
            {
                Console.WriteLine("Is this a weekday (y/n)?");
                string str = Console.ReadLine().ToUpper().Substring(0, 1);
                switch(str)
                {
                    case "Y":
                        validInput = true;
                        userChoose = true;
                    break;
                    case "N":
                        validInput = true;
                        userChoose = false;
                    break;
                    default:
                        validInput = false;
                        Console.WriteLine("That was not a valid input.");
                    break;

                }
                
            } while (!validInput);
            return userChoose;
        }
    }
}
