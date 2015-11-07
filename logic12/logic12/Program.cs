using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please answer y or n");
            
            bool isMorning = false;
            Console.WriteLine("Is it morning time?");
            if (Console.ReadLine() == "y")
                isMorning = true;
           
            bool isMom = false;
            Console.WriteLine("Look at the caller ID. Is it your mom");
            if (Console.ReadLine() == "y")
                isMom = true;
            
            bool isAsleep = false;
            Console.WriteLine("If your sleeping your not answering. Are you asleep?");
            if (Console.ReadLine() == "y")    
                isAsleep = true;

            bool printOut = AnswerCell(isMorning, isMom, isAsleep);

            Console.WriteLine(Responds(printOut));
            Console.ReadLine();
        }

        private static string Responds(bool printOut)
        {
            if (printOut == true)
                return "Quick your phone is ringing pick it up.";
            else
                return "Aww they will call back later.";

        }

        public static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep == true)
                return false;
            
            if(isMorning == true)
                if (isMom == true)
                    return true;
                else
                    return false;

            return true;

        }
    }
}
