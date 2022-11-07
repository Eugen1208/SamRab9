using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X;
            double Y;
            double total;
            char code;
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число X:");
            try
            {
                X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целое число Y:");
                Y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");
                Console.Write("Ваш выбор: ");
                code = Convert.ToChar(Console.ReadLine());
                if (code == '1')
                {
                    total = X + Y;
                    Console.WriteLine("Результат = " + total + ".");
                }

                else if (code == '2')
                {
                    total = X - Y;
                    Console.WriteLine("Результат = " + total + ".");
                }

                else if (code == '3')
                {
                    total = X * Y;
                    Console.WriteLine("Результат = " + total + ".");
                }

                else if (code == '4')
                {
                    total = X / Y;
                    Console.WriteLine("Результат = " + total + ".");
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
