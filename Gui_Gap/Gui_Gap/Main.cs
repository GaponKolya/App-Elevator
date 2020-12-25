using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Gui_Gap
{

    class Main
    {
        
        static void Main1(string[] args)
        {
           
           

           
                //Заключается в добавлении в список нового экземпляра BouncingBall
                // Всю инициализацию положения, скорости, размера, цвета
                // BouncingBall выполняет сам в конструкторе
                

          
            
           

            //у нас есть лифт
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
            Console.WriteLine("Лифт поехал на 6 этаж");
            //elevator.GoTo(6).GetAwaiter().GetResult();
            Console.WriteLine("Лифт приехал на 6 этаж и открыл двери");
            Console.WriteLine($"Лифт на этаже: {elevator.Level}");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}


    
    

