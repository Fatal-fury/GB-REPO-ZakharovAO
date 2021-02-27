using System;

namespace les_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи числа через пробел");
            string numbers = Console.ReadLine();
            Console.WriteLine(sum(numbers));
        }

        static int sum(string numbers)
        {
            int number = 0;
            string s = "0";
            for (int i = 0;i<numbers.Length; i++)
            {
                s = "0";
                while ((i < numbers.Length)&&(numbers[i]!=' '))
                {
                    s = s + numbers[i];       
                    i++;
                }
                number += Convert.ToInt32(s);
            }
            return number;
        }

    }
}
