﻿using System;
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
    public partial class Parameters : Form
    {
        
        
        public Parameters()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            application app = new application();
            app.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Data.Cpeople = (int)numericUpDown1.Value;
            Data.Cfloor = (int)numericUpDown2.Value;
            this.Hide();
            application app = new application();
            app.Show();
        }

        
    }
}
