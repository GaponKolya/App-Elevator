using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Gap
{
    public partial class Elevator : Form
    {
        int i;
        int zxc=1;
        int tk;
        int colbutton = 1;
        int j = 0;
        int k = 0;
        int l = 1;
        int N = Data.Cfloor;
        string a;
        public List<int> minlvl = new List<int>(10);
        public Elevator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //var elevator = new ElevatorClass();
            //elevator.AddF(1);
            //elevator.minlvl.Add(1);
            this.Load += Elevator_Load;
            //button2.Enabled = false;
            for (int i = 0; i < N; i++)
            {
                int x = 80;
                int y = 65;

                Button newbutton = new Button();

                newbutton.Name = "" + colbutton;
                newbutton.Text = "" + colbutton;
                newbutton.Width = 50;
                newbutton.Height = 50;
                newbutton.Cursor = System.Windows.Forms.Cursors.Hand;
                newbutton.BackColor = Color.White;

                newbutton.Location = new Point(50 + x * k, 210 + y * j);
                k++;


                this.Controls.Add(newbutton);
                newbutton.Click += Newbutton_ClickAsync;
                if (k == 3)
                {
                    k = 0;
                    j++;
                }
                colbutton++;
            }
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            

        }

        private void Newbutton_ClickAsync(object sender, EventArgs e)
        {
           
            Button oldbutton = (Button)sender;
           
            int.TryParse(oldbutton.Text, out int l);
          
            minlvl.Add(l);
            zxc = minlvl.Count;
            label5.Text = zxc.ToString();
            oldbutton.Enabled = false;
            oldbutton.BackColor = Color.Red;
            oldbutton.ForeColor = Color.White;
            

        }

        private void Elevator_Load(object sender, EventArgs e)
        {
            
            //var elevator = new ElevatorClass();
            //elevator.AddF(1);
            //button1.Click += button1_ClickAsync;


        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            Data.potok = 1;
            label5.Text = minlvl.Count.ToString();
            
            if (minlvl.Count > 0 )
            {
                

                button1.Enabled = false;
                int level = this.SortAsync();
                //label1.Text = oldbutton.Text;
                var elevator = new ElevatorClass();
                elevator.StateChanged += Elevator_StateChanged;
                elevator.LevelChanged += Elevator_LevelChanged;

                l = 1;
                // await elevator.AddF();
                await Task.Delay(1000);
                await elevator.GoTo(level);
                
            }
           // Controls.Find
            button1.Enabled = true;
            label5.Text = minlvl.Count.ToString();
            
            
        }

        private void Elevator_LevelChanged(object sender, int e)
        {
            label1.Text = e.ToString();
            Data.m = e;
        }
        private void Elevator_StateChanged(object sender, ElevatorClass.States e)
        {
            switch (e)
            {
                case ElevatorClass.States.EmptyWaiting:
                    label2.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    break;
                case ElevatorClass.States.EmptyClimbingUp:
                    label2.ForeColor = Color.Red;
                    label4.ForeColor = Color.Black;
                    break;
                case ElevatorClass.States.EmptyClimbingDown:
                    label2.ForeColor = Color.Black;
                    label4.ForeColor = Color.Red;
                    break;
                case ElevatorClass.States.OpenDoorsWaiting:
                    label2.ForeColor = Color.Yellow;
                    label4.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }
        private void Elevator_Butt(object sender, EventArgs e)
        {
            Button oldbutton = (Button)sender;
            
            
            oldbutton.BackColor = Color.Yellow;
            oldbutton.ForeColor = Color.Black;
            
        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {
            tk = i++;
            
            if (tk % 2 == 0)
            { label6.ForeColor = Color.Red; }
            else
            { label6.ForeColor = Color.White; }

        }
        int tp;
        private async Task button_ClickAsync(object sender, EventArgs e)
        {


        }
        private int SortAsync()
        {
            int min;
            int nam = 0;



            int count = minlvl.Count;
            // min = Math.Abs(minlvl[0] - lvl);
            min = Data.Cfloor;
            for (int i = 0; i < count; i++)
            {

                if (Math.Abs(minlvl[i] - l) <= min)
                {
                    min = Math.Abs(minlvl[i] - l);
                    nam = i;
                }
            }

            int lvl1 = minlvl[nam];
            minlvl.RemoveAt(nam);
            int coun = minlvl.Count;

            //label1.Text = oldbutton.Text;
            return lvl1;
        }

      
    }
    
}






//if (zxc == 2) button1.Enabled = false;
//else button1.Enabled = true;