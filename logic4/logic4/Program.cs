using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How fast where you driving.");
            int speed = Int32.Parse(Console.ReadLine());

            bool birthday = false;
            Console.WriteLine("Is it your birthday (y/n)?");
            if (Console.ReadLine() == "y")
                birthday = true;


            int printOut = CaughtSpeeding(speed, birthday);

            Console.WriteLine(Responds(printOut));
            Console.ReadLine();
        }

        private static string Responds(int printOut)
        {
           if (printOut == 2)
                return "Your getting a Big ticket.";
            else if (printOut == 1)
                return "Your getting a small ticket.";
            else
                return "no ticket for you.";

        }
        public static int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday == true)
            speed = speed - 5;
            if (speed <= 60)
                return 0;
            else if (speed > 60 && speed <= 80)
                return 1;
            else
                return 2;
        }
    }
}
