using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 0.001;
            double e1;
            double a = 0.6;
            double b = 0.7;
            double x;

            double fa, fb, fa1, fb1;
            fa = Math.Pow(2, -a) - Math.Sin(a);
            fb = Math.Pow(2, -b) - Math.Sin(b);
            fa1 = Math.Sin(a) + Math.Pow(2, Math.Log(2)) / Math.Pow(2, a);
            fb1 = Math.Sin(b) + Math.Pow(2, Math.Log(2)) / Math.Pow(2, b);

            if ((fa < 0 && fa1 < 0) || (fa > 0 && fa1 > 0))
            {
                x = a;
            }
            else
            {
                x = b;
            }

            double c = x;
            double xh;
            if (c == a)
            {
                xh = b;
            }
            else
            {
                xh = a;
            }

            int i = 0;
            Console.WriteLine("Решение методом касательных \n");
            do
            {
                i = i + 1;

                x = x - (Math.Pow(2, -x) - Math.Sin(x)) / (-Math.Cos(x) - Math.Log(2) / Math.Pow(2, x));
                e1 = (Math.Abs(Math.Pow(2, -x) - Math.Sin(x))) / 1.1;
                Console.WriteLine("x" + i + " = " + x);
                if (e1 > 0.001)
                {
                    Console.WriteLine("e" + " = " + e1 + " > 0.001" + "\n");
                }
                else
                {
                    Console.WriteLine("e" + " = " + e1 + " < 0.001" + "\n");
                }
            }
            while (e1 > e);
            Console.WriteLine( x + "\n\n");


            i = 0;
            Console.WriteLine("Решение методом хорд \n");
            do
            {
                i = i + 1;

                xh = (c * (Math.Pow(2, -xh) - Math.Sin(xh)) - xh * (Math.Pow(2, -c) - Math.Sin(c))) / (Math.Pow(2, -xh) - Math.Sin(xh) - (Math.Pow(2, -c) - Math.Sin(c)));
                e1 = (Math.Abs(Math.Pow(2, -xh) - Math.Sin(xh))) / 1.1;
                Console.WriteLine("x" + i + " = " + xh);
                if (e1 > 0.001)
                {
                    Console.WriteLine("e" + " = " + e1 + " > 0.001" + "\n");
                }
                else
                {
                    Console.WriteLine("e" + " = " + e1 + " < 0.001" + "\n");
                }
            }
            while (e1 > e);
            Console.WriteLine( xh);


        }
    }
}