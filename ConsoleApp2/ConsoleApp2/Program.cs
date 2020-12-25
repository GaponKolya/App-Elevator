using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static async Task Main(string[] args)
        {
            int fl = 10;
            int pep = 5;
            //у нас есть лифт
            //Console.WriteLine("Введите имя и нажмите Enter: ");
            int k = 1;
            //string vlv = Console.ReadLine();
            //int.TryParse(vlv, out int lvl);
            //for (; ; )
            //{
            //    Console.WriteLine("Введите этаж или введите н чтобы выйти ");


            //    string vlv = Console.ReadLine();
            //    string v = "y";
            //    if (vlv == v)
            //        break;
            //    else
            //    {
            //        int.TryParse(vlv, out int lvl);
            //        k = Lift(lvl, k);
            //    }

            //}      









            Console.WriteLine();


            List<Thread> people = new List<Thread>();
            Global.b = 1;
            //for (int i = 0; i < 10; i++) 
            //{ 

            //    people.Add(new People());
            //    Thread.Sleep(1000);
            //}
            // people.Add(new People());
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
            People pepe = new People();
            people.Add(new Thread(pepe.VizovLifta));


               

            }
            people[1].Start();
            people[2].Start();
            people[0].Start();
            //for (int i = 0; i < 3; i++)
            //{
            //    people[i].Start();
            //}
            Console.ReadKey();

        }
        
    }
}
