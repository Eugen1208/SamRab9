using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите целое число X:");

            try
            {
                X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите код операции:");
            code = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число Y:");
            Y = Convert.ToDouble(Console.ReadLine());
                double X = Convert.ToDouble(Console.ReadLine());
                double Y = Convert.ToDouble(Console.ReadLine());
                double r = X / Y;
                Console.WriteLine(r);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
