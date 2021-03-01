using DocuSign.eSign.Model;
using System;

namespace les_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GetFullName("Петров"+i, "Иван"+i, "Иваныч"+i));
            }
        }

        
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            {
                string summa=firstName+" "+lastName+ " " + patronymic;
                return summa;
                //return firstName;
                //return lastName; 
                //return patronymic;
            }
            
            
        }




    }
}
