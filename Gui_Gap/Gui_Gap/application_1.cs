using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace Gui_Gap
{
    public partial class application_1 : Form
    {
        int i;
        int tk;


        
        public application_1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            string c;

            i = 0;
            c = "00:00:00";

            label4.Text = c;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CloseApp closeapp = new CloseApp();
            closeapp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tk = i++;
            TimeSpan span = TimeSpan.FromSeconds(tk);
            string label = span.ToString(@"hh\:mm\:ss");
            label4.Text = label.ToString();
            label5.Text = Data.potok.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Elevator ele = new Elevator();

            ele.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {


            People people = new People();
            people.Show();

        }

        private void application_1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            People people = new People();
            people.Add();
        }
    } 


}
