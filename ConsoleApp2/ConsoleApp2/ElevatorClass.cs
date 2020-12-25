using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
        public List<int> minlvl = new List<int>();
        public int Level { get; private set; }
        public States State { get; private set; }
        //public int lvl;
        //public void setLVL(int lvl1)
        //{
        //    this.minlvl.Add(lvl1);
        //}
        public ElevatorClass()
        {

            Level =Global.b;
        }

        public async Task GoTo(int level,int lvl)
        {
            //int min;
            //int nam = 0;

            //minlvl.Add(level);
            //int count = minlvl.Count;
            //min = Math.Abs(minlvl[0] - lvl);
            //for (int i = 0; i < count; i++)
            //{

            //    if (Math.Abs(minlvl[i] - lvl) <= min)
            //    {
            //        min = Math.Abs(minlvl[i] - lvl);
            //        nam = i;
            //    }
            //}

            //int lvl1 = minlvl[nam];

            //int coun = minlvl.Count;
            if (lvl < level)
            {
                State = States.EmptyClimbingUp;
                StateChanged?.Invoke(this, this.State);

                for (int i = lvl; i <= level; i++)
                {
                    await Task.Delay(1000);
                    Level = i;
                    LevelChanged?.Invoke(this, this.Level);


                }
                await Task.Delay(1000);
                State = States.OpenDoorsWaiting;
                StateChanged?.Invoke(this, this.State);

                await Task.Delay(1000);
                State = States.EmptyWaiting;
                StateChanged?.Invoke(this, this.State);

            }
            else
                if (lvl > level)
            {
                State = States.EmptyClimbingDown;
                StateChanged?.Invoke(this, this.State);

                for (int i = lvl; i >= level; i--)
                {
                    await Task.Delay(1000);
                    Level = i;
                    LevelChanged?.Invoke(this, this.Level);

                }
                await Task.Delay(1000);
                State = States.OpenDoorsWaiting;
                StateChanged?.Invoke(this, this.State);

                await Task.Delay(1000);
                State = States.EmptyWaiting;
                StateChanged?.Invoke(this, this.State);

            }


        }
    }
}