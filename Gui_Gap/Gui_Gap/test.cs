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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();

           
            
        }
        int colbutton = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //Получаем ссылку на кнопку, на которую нажали
            Button oldbutton = (Button)sender;
            //Создаем новую кнопку
            for (int i = 0; i < 10; i++)
            {
                Button newbutton = new Button();
                //Меняем текст на новой кнопке
                newbutton.Text = "Кнопка №" + colbutton;
                newbutton.Width = oldbutton.Width;
                newbutton.Height = oldbutton.Height;
                //Размещаем ее ниже (на 10px) кнопки, на которую мы нажали
                newbutton.Location = new Point(oldbutton.Location.X + oldbutton.Height + 50*i, oldbutton.Location.Y + oldbutton.Height + 10*i);

                //Добавляем элемент на форму
                this.Controls.Add(newbutton);
                colbutton++;
            }
        }
    }
}
