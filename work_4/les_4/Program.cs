using System;

namespace les_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер элемента числа Фиббоначи: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Число Фиббоначи для элемент n={n} равно: {NumFibbonachi(n)}");
            Console.ReadKey();
        }

        static int NumFibbonachi(int n)
        {
            if (n ==0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;

             }
            else 
            {
                return NumFibbonachi(n-2) + NumFibbonachi(n - 1);
            }
        }
    }
}
