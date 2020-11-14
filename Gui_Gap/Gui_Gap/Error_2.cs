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
    public partial class Error_2 : Form
    {
        public Error_2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parameters param = new Parameters();
            param.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            application app = new application();
            app.Show();
        }
    }
}
