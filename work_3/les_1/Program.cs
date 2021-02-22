using System;

namespace les_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[3, 3] {{1,2,3},{4,5,6},{7,8,9}};
            for (int i=0; i <mas.GetLength(0); i++) 
            {
            for (int j=0; j<mas.GetLength(1); j++) 
                {
                    if (i == j) 
                    {
                        Console.Write($"{mas[i,j]} \t");
                    }
                    else
                    {
                        mas[i, j] = 0;

                        Console.Write($"{mas[i, j]} \t"); 
                    }
                }
                Console.WriteLine();

            }           
           
        }
    }
}
