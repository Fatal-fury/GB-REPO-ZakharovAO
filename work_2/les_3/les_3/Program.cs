using System;

namespace les_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внимание!!!! Проверка на четность, введенного Вами числа!");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
                
            }
            else { Console.WriteLine("Число не четное"); }
        }
    }
}
