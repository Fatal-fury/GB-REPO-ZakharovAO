using System;

namespace les_3_SEE_Batle_
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] batle = new char[10][];
            char X = 'X';
            char O = 'O';
            batle[0] = new char[] { X, X, X, X, O, X, X, O, X, X };
            batle[1] = new char[] { O, O, O, O, O, O, O, O, O, O };
            batle[2] = new char[] { X, X, X, O, X, X, X, O, X, X };
            batle[3] = new char[] { O, O, O, O, O, O, O, O, O, O };
            batle[4] = new char[] { X, O, X, O, O, X, O, O, O, X };
            batle[5] = new char[] { O, O, O, O, O, O, O, O, O, O };
            batle[6] = new char[] { O, O, O, O, O, O, O, O, O, O };
            batle[7] = new char[] { O, O, O, O, O, O, O, O, O, O };
            batle[8] = new char[] { O, O, O, O, O, O, O, O, O, O };
            batle[9] = new char[] { O, O, O, O, O, O, O, O, O, O };

            foreach (char[] row in batle)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    Console.Write($"{row[i]} \t");
                }
                Console.WriteLine();

            }
            
        }
    }
}
