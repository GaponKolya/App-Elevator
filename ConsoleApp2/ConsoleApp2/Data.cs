using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Data
    {
        
        int n = 1;
        public int Lift()
        {
            int lvl = SortAsync(n);
            var elevator = new ElevatorClass();
            //подпишемся на изменение состояния лифта
            elevator.StateChanged +=
                (s, e) => Console.WriteLine($"Состояние лифта: {e}");
            //подпишемся на изменение этажа у лифта
            elevator.LevelChanged +=
                (s, e) => Console.WriteLine($"Лифт на этаже: {e}");

            //изначально лифт на 1 этаже
            Console.WriteLine($"Лифт на этаже: {elevator.Level}");
            //лифт пустой в ожидании
            Console.WriteLine($"Состояние лифта: {elevator.State}");
            Console.WriteLine(new string('-', 50));

            //поступил вызов с 6 этажа
            Console.WriteLine("Лифт поехал на" + lvl + " этаж");
            elevator.GoTo(lvl, Global.b).GetAwaiter().GetResult();
            Console.WriteLine("Лифт приехал на " + lvl + " этаж и открыл двери");
            Console.WriteLine($"Лифт на этаже: {elevator.Level}");
            Console.WriteLine(new string('-', 50));
            People pep = new People();
            Global.b = elevator.Level;
            return elevator.Level;

        }
        private int SortAsync(int l)
        {
            int min;
            int nam = 0;



            int count = Global.qwe.Count;
            // min = Math.Abs(minlvl[0] - lvl);
            min = (Global.qwe[0] - l);
            for (int i = 0; i < count; i++)
            {

                if (Math.Abs(Global.qwe[i] - l) <= min)
                {
                    min = Math.Abs(Global.qwe[i] - l);
                    nam = i;
                }
            }

            int lvl1 = Global.qwe[nam];
            Global.qwe.RemoveAt(nam);
            int coun = Global.qwe.Count;

            //label1.Text = oldbutton.Text;
            return lvl1;
        }
    }
}
