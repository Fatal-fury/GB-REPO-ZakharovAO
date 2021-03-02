using System;
using System.IO;

namespace les_2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime timeNow = DateTime.Now;


            string filename = "lesson2";
            File.WriteAllText(filename, $"{timeNow:T}");
            string text = File.ReadAllText(filename);

            Console.WriteLine(text);
        }
    }
}
