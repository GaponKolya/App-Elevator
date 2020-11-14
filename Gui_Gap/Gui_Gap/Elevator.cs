using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Gap
{
    public partial class Elevator : Form
    {
        int i;
        int tk;
        int colbutton = 1;
        int j = 0;
        int k = 0;
        public Elevator()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            

            for (int i = 0; i < 10; i++)
            {
                int x = 80;
                int y = 65;

                Button newbutton = new Button();


                newbutton.Text = "" + colbutton;
                newbutton.Width = 50;
                newbutton.Height = 50;
                newbutton.Cursor = System.Windows.Forms.Cursors.Hand;
                newbutton.BackColor = Color.White;

                newbutton.Location = new Point(50 + x * k, 210 + y * j);
                k++;

                newbutton.Click += new EventHandler(button_Click);
                this.Controls.Add(newbutton);
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

        

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            tk = i++;
            
            if (tk % 2 == 0)
            { label6.ForeColor = Color.Red; }
            else
            { label6.ForeColor = Color.White; }
              
        }
        int tp;
        private void button_Click(object sender, EventArgs e)
        {
            Button oldbutton = (Button)sender;
            tp++;
            oldbutton.BackColor = Color.Red;
            oldbutton.ForeColor = Color.White;
            
            if (tp == 2)
            {
                oldbutton.BackColor = Color.White;

                oldbutton.ForeColor = Color.Black;
                tp = 0;
            }


        }

        

        

        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
