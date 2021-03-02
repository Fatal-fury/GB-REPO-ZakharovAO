using System;
using System.IO;



namespace les_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "lessons1.txt";
            File.WriteAllText(filename, "hellow techer, this is work_5 - lesson_1");
            string text = File.ReadAllText(filename);
            Console.WriteLine(text);
        }
    }
}
