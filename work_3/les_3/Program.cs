using System;

namespace les_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы");
            
            
            string userString = Console.ReadLine();
            char[] userChars = userString.ToCharArray();
            for (int i = userChars.Length; i >0; i--)
            {
                Console.Write($"{userChars[i-1]}");
            }
            //Console.WriteLine($"{userChars[0]}");
        }
    }
}
