using ConsoleApp15;
using System;

namespace Входной_контроль
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ЗАДАЧА 1. Прибавить 10 к введенному числу");
            Console.WriteLine("\nВведите число и нажмите enter");
            //создан класс и объект класса
            double a = Convert.ToDouble(Console.ReadLine());
            firstTask obj1 = new firstTask(a);
            Console.WriteLine(obj1);
            Console.WriteLine();



            Console.WriteLine("Задача 2. Ограничить строку до выбранного символа");
            Console.WriteLine("Введите строку: ");
            actionChar.txt = Console.ReadLine();
            Console.WriteLine("Введите индекс: ");
            int k = Convert.ToInt32(Console.ReadLine());
            actionChar.DeletALineOfProccess(k);
            Console.WriteLine();
                  


        }
    }



}
