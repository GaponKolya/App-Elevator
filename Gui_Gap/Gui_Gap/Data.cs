using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Gui_Gap
{
   static class Data
    {
        public static int Cpeople;
        public static int Cfloor;
        public static int m;
        public static int potok;
        public static string[] id;
        public static string[] floor; 
        public static string[] wt;
        public static int tid;
        public static int lvl = 1;
        //public static List<int> minlvl = new List<int>(10);
        static CancellationTokenSource cts = new CancellationTokenSource();
    }
}
