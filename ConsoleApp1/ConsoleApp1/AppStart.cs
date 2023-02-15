using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AppStart
    {
        public static void Start()
        {
            try
            {
                while (true)
                {
                    PrintAndRead print = new();

                    print.PrintAndReadConsole();

                    Console.WriteLine(Calculations.Calc(print.a, print.b, print.c));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы можете вводить только числа");
                Start();
            }

        }
    }
}
