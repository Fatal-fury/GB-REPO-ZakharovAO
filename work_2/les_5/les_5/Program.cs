using System;

namespace les_5
{
    class Program
    {
        [Flags]
        public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int numberMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднюю температуру за месяц");
            int TemperatureAVG = Convert.ToInt32(Console.ReadLine());
            if ((numberMonth > 0 && numberMonth <= 2 || numberMonth == 12) && TemperatureAVG > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
            

        }
    }
}
