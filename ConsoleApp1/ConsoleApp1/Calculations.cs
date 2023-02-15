using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculations
    {
        public static string Calc(float a, float b, float c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                return "Стороны треугольника не могут быть меньше либо равны нулю";
            }
            else if ((a > b + c) || (b > a + c) || (c > a + b))
            {
                return "сумма любых 2 сторон не может быть меньше либо равна третьей стороне";
            }
            else if ((a == b) && (b == c) && (a == c))
            {
                return "Этот треугольник равносторонний";
            }
            else if ((a == b) || (b == c) || (a == c))
            {
                return "Этот треугольник равнобедренный";
            }
            else
            {
                return "Этот треугольник разносторонний";
            }
        }
    }
}
