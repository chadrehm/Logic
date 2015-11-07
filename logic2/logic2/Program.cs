using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How stylish is the man?");
            int styleMan = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How stylish is the woman?");
            int styleWoman = Int32.Parse(Console.ReadLine());


            int printOut = CanHazTable(styleMan, styleWoman);

            Console.WriteLine(GetATable(printOut));
            Console.ReadLine();
        }
        private static string GetATable(int printOut)
        {
            if (printOut == 2)
                return "You will be seated soon.";
            else if (printOut == 1)
                return "We have a twenty minute wait.";
            else
                return "We are booked solid tonight, oh those tables they are reserved!";

        }
        public static int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle >= 8 || dateStyle >= 8 && yourStyle > 2 && dateStyle > 2)
                return 2;
            else if (yourStyle > 2 && dateStyle > 2)
                return 1;
            else
                return 0;
        }
    }
}
