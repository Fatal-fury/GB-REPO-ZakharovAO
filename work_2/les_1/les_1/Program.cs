using System;

namespace les_1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Введите максимальную температуру за сутки");
          int TemperatureMax = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Введите минимальную температуру за сутки");
          int TemperatureMin = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Средняя температура в сутки: " + (TemperatureMax+TemperatureMin)/2 );
        }
    }
}
