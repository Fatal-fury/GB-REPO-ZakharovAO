using System;

namespace Lessons_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("ВВедите Имя пользователя");
            userName = Console.ReadLine();
            string DateNow = DateTime.Now.ToShortDateString();
            Console.WriteLine("Привет," + userName +$", сегодня {DateNow}");
        }
    }
}
