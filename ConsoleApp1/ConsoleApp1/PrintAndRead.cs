using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PrintAndRead
    {
        public float a;

        public float b;

        public float c;

        public void PrintAndReadConsole()
        {
            Console.WriteLine("Введите сторону a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            c = float.Parse(Console.ReadLine());
        }
    }
}
