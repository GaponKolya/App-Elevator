using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class People
    {
        // Максимальный этаж, который может иметь человек
        private static int MAX_FLOOR = 10;
        // Минимальный вес, который может иметь мяч
        private static int MIN_WT = 20;
        // Максимальный вес, который может иметь человек
        private static int MAX_WT = 150;

        int wt;
        private int floor;
        private int Chosefloor;
        int floorLift;
        private string id;
        static object locker = new object();

        Data q = new Data();

        int colbutton = 0;
        Random rnd = new Random();
        public People()
        {



            //Получить случайное число 
            wt = rnd.Next(MIN_WT, MAX_WT);
            floor = rnd.Next(1, MAX_FLOOR);
            Chosefloor = rnd.Next(1, MAX_FLOOR);
            id = "1";
            Thread thread = new Thread(VizovLifta);
            thread.Start();

        }

       



        public void VizovLifta()
        {
            lock (locker)
            {
                Thread.Sleep(1000);
               
                Global.qwe.Add(floor);
                Console.WriteLine("sozdan chelovek " + wt + " " + floor);
                Thread.Sleep(1000);
                //perehod v sostojanie waitingLift
                Console.WriteLine(wt + " Ожидает лифта " + floor);
            }
            Thread.Sleep(1000);
            lock (locker)
            {
                if (floor != Global.b)
                {
                    lock (locker)
                    {

                        q.Lift();
                        Console.WriteLine(wt + " " + floor);

                    }
                }
                else
                {
                    //perehod v sostojanie "v lifte"
                    Console.WriteLine(wt + " в лифте " + floor);

                }
            }
            for (; ; )
            {
                if (floor == Global.b) { 
                Console.WriteLine(wt + " в лифте " + floor);
                break; }
            }
            //vizov metoda vibora floor
            lock (locker)
            {
                Thread.Sleep(1000);

                Global.qwe.Add(Chosefloor);
                Console.WriteLine("В лифте " + wt + " поедет на " + Chosefloor);
                Thread.Sleep(1000);
                //perehod v sostojanie ожидвние остановки
            }
            lock (locker)
            {
                if (Chosefloor != Global.b)
                {
                    lock (locker)
                    {

                        q.Lift();
                        

                    }
                }
                else
                {
                    //perehod v sostojanie "ne v lifte"
                    Console.WriteLine("Вышел из лифта " + wt + " " + Chosefloor);
                }
            }
            for (; ; )
            {
                if (floor == Global.b)
                {
                    Console.WriteLine(wt + " вышел  " + floor);
                    break;
                }
            }

        }
        public void setID(string id) { this.id = id; }

        public string getID() { return id; }
        public void setWT(int wt) { this.wt = wt; }

        public int getWT() { return wt; }
        public void setfloor(int floor) { this.floor = floor; }

        public int getfloor() { return floor; }
        public int GetfloorLift() { return floor; }
        public void SetfloorLift(int floorLift) { this.floorLift = floorLift; }
    }
    //    public async Task WaitingLift() 
    //{
    //    for (; ; )
    //    {
    //        await Task.Delay(1000);
    //        Console.WriteLine(floorLift);
    //        GetfloorLift();
    //        Console.WriteLine(floorLift);
    //        if (floorLift == 5)
    //        {
    //            Data q = new Data();
    //            q.qwe.Add(7);
    //            q.Lift(3);
    //        }
    //    }

    //}
    //    public void Chosefloor() 
    //    {
    //        Data q = new Data();
    //        q.qwe.Add(7);
    //        q.Lift(floorLift);

    //        //Start();
    //    }
    //    public async Task Start()
    //    {
    //        Data q = new Data();
    //        q.Lift(floorLift);
    //    }
    //    public async Task WaitingStop() 
    //    {

    //    }

    //}
}
    
