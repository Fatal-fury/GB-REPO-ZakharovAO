using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace les_8
{
    class Program
    {


        static Process[] process { get; set; }
        public static int n;

        static void GetProcessList()
        {
            process = Process.GetProcesses();
        }
        static void Main(string[] args)
        {GetProcessList();
            viewproces();
            Console.WriteLine("--------------------------");
            Console.WriteLine("ВВедите имя процесса или PID процесса, который необходимо завершить");
            Console.ReadLine();
            
            ReadLineProc();
            KillProc();

        }
        public static void viewproces()
        {
                        
            foreach (var item in process)
            {
                Console.WriteLine($"{item.Id}\t{item.ProcessName}");
            }
            
        }
        public static void ReadLineProc()
        {
          // int n;
            string Proc = Console.ReadLine();
            if (int.TryParse(Proc,out n)
               
            );
            
            //else return Proc;      
        }
        public static void KillProc()
        {
            foreach (var item in process)
            {
                if (item.Id==n)
                {
                    item.Kill();
                }
                
            }
            

        }
    }






}
