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
    public partial class People : Form
    {
        int id=1;
        int n = 10;
        public People()
        {
            
            
            InitializeComponent();
            for (int i = 0; i < n; i++)
            {
                int y = 30;
                //
                Label newid = new Label();
                newid.Width = 76;
                newid.Height = 16;
                newid.Text = "People №" + id;
                newid.Location = new Point(15 , 75 + y *i);
                //
                Label newstatus = new Label();
                newstatus.Width = 82;
                newstatus.Height = 16;
                newstatus.Text = "Не в лифте" ;
                newstatus.Location = new Point(125, 75 + y * i);
                //
                Label newf = new Label();
                newf.Width = 57;
                newf.Height = 16;
                newf.Text = id+ " Этаж";
                newf.Location = new Point(230, 75 + y * i);
                //
                Label newm = new Label();
                newm.Width = 57;
                newm.Height = 16;
                newm.Text = id + "0кг";
                newm.Location = new Point(320, 75 + y * i);
                //
                this.Controls.Add(newid);
                this.Controls.Add(newstatus);
                this.Controls.Add(newf);
                this.Controls.Add(newm);
                id++;
                //
                label5.Text = n + "";
            }
        }

        
    }
}
