using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class actionChar//изменено название класса
    {
        public static string txt;
        public static void DeletALineOfProccess(int numberDelete) //изменено название метода на более понятное
        {
            try
            {
                txt = txt.Remove(numberDelete);
                Console.WriteLine($"Измененная строка: {txt}"); //вывод измененной строки
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение -> {ex.Message}");//используется конструкция try catch
            }
        }
    }
}
