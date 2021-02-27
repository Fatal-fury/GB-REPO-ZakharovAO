using System;

namespace les_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Magazine = "Строительный двор";
            DateTime Data = new DateTime(2021, 01, 12, 15, 20, 30);
            int Sale = 1400;
            string Product = "Смеситель";
            Console.WriteLine(
                "       "+Magazine+ "      "+'\n'
              + "Товар"+"               "+"Цена"+'\n'
              +Product+ " x 1 шт.   "+Sale+'\n'
              +"Всего"+"               "+Sale+'\n'+
              '\n'
              + Data+ '\n'
              +"ИТОГ:               "+ Sale);        
        
        
        
        
        
        }
    }
}
