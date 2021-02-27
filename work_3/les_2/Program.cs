using System;

namespace les_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] telDirectrory = new string[5, 2];
            telDirectrory[0,0] = "Вася";
            telDirectrory[1, 0] = "Федя";
            telDirectrory[2, 0] = "Сбер";
            telDirectrory[3, 0] = "ВТБ";
            telDirectrory[4, 0] = "Фрося";
            telDirectrory[0, 1] = "88005556565";
            telDirectrory[1, 1] = "asdad@mail.ru";
            telDirectrory[2, 1] = "adsasd@ya.ru";
            telDirectrory[3, 1] = "88008007005";
            telDirectrory[4, 1] = "88005556500";
            for (int i = 0; i < telDirectrory.GetLength(0); i++)
            {
                for (int j = 0; j < telDirectrory.GetLength(1); j++)
                {
                    Console.Write($"{telDirectrory[i,j]} \t");
                }
                Console.WriteLine();
            }




            
        }
    }
}
