using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, F(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
            Console.ReadKey();
        }
        static double F(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение 
                if (x == -1) throw new Exception();
                else return (x + 4 / x * x - 2) + Math.Sqrt(x * x * x - 1);
            }
            catch
            {
                throw;
            }
        }
    }
}
