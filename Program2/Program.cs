using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            double[] y_eiler = new double[11];
            double[] y_eiler_koshi = new double[11];
            y_eiler[0] = 0.8;
            y_eiler_koshi[0] = 0.8;
            x = 0.6;
            y = 0.8;

            double func = x + Math.Cos(y / Math.Sqrt(10));
            Console.WriteLine("x"+ "\t  " + "y" + "\t\t\t  " + "f(x,y)");
            Console.WriteLine(x + "\t  " + y + "\t\t\t  " + func );

            int i = 1;
            for (x = 0.7; x < 1.7; x+= 0.1)
            {
                y = y + 0.1 * func;
                func = x + Math.Cos(y / Math.Sqrt(10));
                Console.WriteLine(Math.Round(x,1) + "\t  " + y + "\t  " + func);
                y_eiler[i] = y;
                i++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            x = 0.6;
            y = 0.8;

            double y_func = x + Math.Cos(y / Math.Sqrt(10));
            double y_null = 0;
            double y_null_func = 0;
            i = 1;
            Console.WriteLine("x" + "\t  " + "y" + "\t\t\t  " + "f(x,y)"+ "\t\t  " + "y0" + "\t\t\t  " + "f(x,y0)");
            Console.WriteLine(Math.Round(x, 1) + "\t  " + y + "\t\t\t  " + y_func);
            for (x = 0.7; x < 1.7; x += 0.1)
            {
                y_null = y + 0.1 * (y_func);
                y_null_func = x + Math.Cos(y_null / Math.Sqrt(10));
                y = y + 0.1 / 2 * (y_func + y_null_func);
                y_func = x + Math.Cos(y / Math.Sqrt(10));
                Console.WriteLine(Math.Round(x, 1) + "\t  " + y + "\t  " + y_func + "\t  " + y_null + "\t  " + y_null_func);
                y_eiler_koshi[i] = y;
                i++;
            }
            x = 0.6;
            y = 0.8;
            i = 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("x" + "\t  " + "y(Эйлера)" + "\t\t  " + "y(Эйлера-Коши)");
            Console.WriteLine(Math.Round(x, 1) + "\t  " + y_eiler[0] + "\t\t\t  " + y_eiler_koshi[0]);
            for (x = 0.7; x <1.7; x += 0.1)
            {             
                Console.WriteLine(Math.Round(x, 1) + "\t  " + y_eiler[i] + "\t  " + y_eiler_koshi[i]);
                i++;
            }
            Console.ReadLine();

        }
    }
}
