using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class firstTask
    {
        private double a;
       

        public firstTask(double a)
        {
            try
            {
                this.a = a + 10;//cоздан констурктор
                
            }
            catch (Exception ex)//используется конструкция try catch
            {
                Console.WriteLine($"Исключение -> {ex.Message}");
            }
        }
        public override string ToString() //вывод значения числа
        {
            return "Значение числа: " + a;
            
        }
        
       

    }

    
}
