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
    public partial class CloseApp : Form
    {
        public CloseApp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            int value = rnd.Next(0, 10);
            int value1 = rnd.Next(0, 10);
            label5.Text = value.ToString();
            label6.Text = value1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            application app = new application();
            app.Show();
        }

      
    }
}
