using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the day of the week. enter a number 0 = Sunday.");
            int day = Int32.Parse(Console.ReadLine());

            bool isVacation = false;
            Console.WriteLine("Are you on vacation (y/n)?");
            if (Console.ReadLine() == "y")
                isVacation = true;




            Console.WriteLine(AlarmClock(day, isVacation));
            Console.ReadLine();
        }

        public static string AlarmClock(int day, bool vacation)
        {
            if (day > 0 && day < 6)
            {
                if (vacation == false)
                    return "7:00";
                else
                    return "10:00";
            }
            if (day == 0 || day == 6)
            {
                if (vacation == false)
                    return "10:00";
                else
                    return "off day";
            }
            return "";
        }
    }
}
