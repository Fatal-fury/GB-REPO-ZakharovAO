using System;

namespace les_6
{
    class Program
    {
        [Flags]
        public enum Day
        {
            monday    = 0b_000000, 
            tuesday   = 0b_000001,
            wednesday = 0b_000010,
            thursday  = 0b_000100,
            friday    = 0b_001000,
            saturday  = 0b_010000,
            sunday    = 0b_100000,
        }


        static void Main(string[] args)
        {
            Day work = (Day)0b_111111;
            Console.WriteLine($"Офис №1 работает по:{work}") ;
        }
    }
}
