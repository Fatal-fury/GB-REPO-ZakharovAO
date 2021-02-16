using System;

namespace les_2
{
    class Program
    {

        [Flags]
        public enum Month
        {
            January  = 1,
            February = 2,
            March    = 3,
            April    = 4,
            May      = 5,
            June     = 6,
            July     = 7,
            August   = 8,
            September= 9,
            October  = 10,
            November = 11,
            December = 12,
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер месяца");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Month)numberMonth);
        }
    }
}
