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
    public partial class application : Form
    {
        
        
        public application()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
            
           
        }

        private void Param_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parameters parameters1 = new Parameters();
            parameters1.Show();
        }
        
        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            application_1 app1 = new application_1();
            app1.Show();
        }
        

        
    }
}
