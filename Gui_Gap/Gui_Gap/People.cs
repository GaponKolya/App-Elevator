using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Gui_Gap
{
    public partial class People : Form
    {
        int id = 1;
        int n = 10;
        int a = 1;
        Random rnd = new Random();
        
        List<ClassPeople> a1 = new List<ClassPeople>(10);

        public void Add()
        {
            ClassPeople p1 = new ClassPeople();
            //Заключается в добавлении в список нового экземпляра BouncingBall
            // Всю инициализацию положения, скорости, размера, цвета
            // BouncingBall выполняет сам в конструкторе
            a1.Add(p1);

        }
        //ClassPeople objByIndex = (ClassPeople)p1[1];

        
        public People()
        {

            

            InitializeComponent();
            for (int i = 0; i < Data.Cpeople; i++)
            { this.Add(); }
            foreach (ClassPeople p in a1)
            {
                p.getWT();
            }
            var qqq = a1[1];
            var qq = a1[2];
            for (int i = 0; i < Data.Cpeople; i++)
            {
                int y = 30;

                //
                Label newid = new Label();

                newid.Width = 76;
                newid.Height = 16;
                newid.Text = qqq.getWT().ToString() ;
                newid.Location = new Point(15, 75 + y * i);
                //
                Label newstatus = new Label();
                newstatus.Width = 82;
                newstatus.Height = 16;
                newstatus.Text = qq.getWT().ToString();
                newstatus.Location = new Point(125, 75 + y * i);
                //
                Label newf = new Label();
                newf.Width = 57;
                newf.Height = 16;
                foreach (ClassPeople p in a1)
                {
                    newf.Text = p.getWT().ToString();
                }
                
                newf.Location = new Point(230, 75 + y * i);
                //
                Label newm = new Label();
                newm.Width = 57;
                newm.Height = 16;
                //newm.Text = pep.getWT().ToString();
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

        private void People_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
