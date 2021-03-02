using System;
using System.IO;
using System.Text;

namespace les_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи числа");
           // 
            string valueUser = Console.ReadLine();
            byte[] numUser = new byte[valueUser.Length];
            for (int i = 0; i < valueUser.Length; i++)
            {
                numUser[i] = Convert.ToByte(valueUser[i]);
            }
            File.WriteAllBytes("lesson_3.bin", numUser);
            byte[] fromFile = File.ReadAllBytes("lesson_3.bin");
            for (int i = 0; i < numUser.Length; i++)
            {
             Console.WriteLine(Convert.ToChar(numUser[i]));
            }
            
        }
    }
}
