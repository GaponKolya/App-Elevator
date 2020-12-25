using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gui_Gap
{
    class ElevatorClass
    {
        public enum States
        {
            EmptyWaiting,
            EmptyClimbingUp,
            EmptyClimbingDown,
            OpenDoorsWaiting
        }

        public event EventHandler<States> StateChanged;
        public event EventHandler<int> LevelChanged;
        public event EventHandler<int> Butt;
        // public List<int> minlvl = new List<int>(10);
        public int Level { get; private set; }
        public States State { get; private set; }
        public int lvl;
        int m ;
        public ElevatorClass()
        {
           Level = 1;
            lvl = Data.lvl;
            m = Data.m;
        }
        //public async Task AddF( int l)
        //{
        //    await Task.Delay(500);
        //    minlvl.Add(l);
        //}
        public async Task GoTo(int level)
        {

            int min;
            int nam = 0;
            //Data.minlvl.Add(2); 
            //Data.minlvl.Add(3);
            //var s = Data.minlvl.ElementAt(2);
            //var level = minlvl.ElementAt(0) ;
            

            //////int count = minlvl.Count;
            //////// min = Math.Abs(minlvl[0] - lvl);
            //////min = Data.Cfloor;
            //////for (int i = 0; i < count; i++)
            //////{

            //////    if (Math.Abs(minlvl.ElementAt(i) - m) <= min)
            //////    {
            //////        min = Math.Abs(minlvl.ElementAt(i) - m);
            //////        nam = i;
            //////    }
            //////}

            //var lvl1 = minlvl.ElementAt(nam);
            //minlvl.RemoveAt(nam);
            //var lvl1 = 1;
            //level = minlvl[nam];
            if (m < level)
            {
                State = States.EmptyClimbingUp;
                StateChanged?.Invoke(this, this.State);

                for (int i = m; i <= level; i++)
                {
                    await Task.Delay(1000);
                    Level = i;
                    LevelChanged?.Invoke(this, this.Level);
                    Butt?.Invoke(this, this.Level);

                }
                
                await Task.Delay(1000);
                State = States.OpenDoorsWaiting;
                StateChanged?.Invoke(this, this.State);

                await Task.Delay(1000);
                State = States.EmptyWaiting;
                StateChanged?.Invoke(this, this.State);

            }
            else
                if (m > level)
            {
                State = States.EmptyClimbingDown;
                StateChanged?.Invoke(this, this.State);

                for (int i = m; i >= level; i--)
                {
                    await Task.Delay(1000);
                    Level = i;
                    LevelChanged?.Invoke(this, this.Level);
                    Butt?.Invoke(this, this.Level);
                }
                
                await Task.Delay(1000);
                Butt?.Invoke(this.Level, this.Level);
                State = States.OpenDoorsWaiting;
                StateChanged?.Invoke(this, this.State);

                await Task.Delay(1000);
                State = States.EmptyWaiting;
                StateChanged?.Invoke(this, this.State);

            }
           
           
        }
    }
}
