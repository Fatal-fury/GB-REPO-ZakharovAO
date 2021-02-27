using System;

namespace les_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы");
            string userString = Console.ReadLine();
            char[] userChars = userString.ToCharArray();
            Console.WriteLine("введите число, на корое надо сместить элементы массива");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>=0)
            {
                for (int i = userChars.Length-1; i >= 0; i--)
                {
                    if (i-number<0)
                    {
                        userChars[i] = '0';
                        //break;
                    }else
                    {
                        userChars[i] = userChars[i - number];
                    } 
                }
            }
            else 
            {
                for (int i = 0; i < userChars.Length; i++)
                {
                    if (i - number > userChars.Length-1)
                    {
                        userChars[i] = '0';

                    }
                    else
                    {
                        userChars[i] = userChars[i - number];
                        
                    }
                }
            }
            for (int i = 0; i < userChars.Length; i++)
            Console.Write($"{userChars[i]} \t");
        }
    }
}
