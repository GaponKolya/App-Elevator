using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Gui_Gap
{

    class ClassPeople 
    {

        // Максимальный этаж, который может иметь человек
        private static int MAX_FLOOR = Data.Cfloor;
        // Минимальный вес, который может иметь мяч
        private static int MIN_WT = 20;
        // Максимальный вес, который может иметь человек
        private static int MAX_WT = 150;
        
        private int wt;
        private int floor;
        private string id;


        private int i = Data.tid;

        int colbutton = 0;
        Random rnd = new Random();
        public ClassPeople()
        {


            
            //Получить случайное число (в диапазоне от 0 до 10)
            wt = rnd.Next(MIN_WT, MAX_WT);
            floor = rnd.Next(1, MAX_FLOOR);
            id = "1" ;
           
        }
        
        public void setID(string id) { this.id = id; }

        public string getID() { return id; }
        public void setWT(int wt) { this.wt = wt; }

        public int getWT() { return wt; }
        public void setfloor(int floor) { this.floor = floor; }

        public int getfloor() { return floor; }
        


        public void Viz() { }
        public void Chosefloor() { }

    }
}
