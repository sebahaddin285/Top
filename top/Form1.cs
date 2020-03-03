using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace top
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 5;
        int y = -5;
        Point topBaslangic;
        Point cubukBaslangic;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Left && cubuk.Location.X > 0)
            {
                cubuk.Location = new Point(cubuk.Location.X - 5, cubuk.Location.Y);
            }
            else if(e.KeyData == Keys.Right && cubuk.Location.X < this.Width - 150)
            {
                cubuk.Location = new Point(cubuk.Location.X + 5, cubuk.Location.Y);
            }
            else if(e.KeyData == Keys.Space && timer_sure.Enabled == false)
            {
                y = -5;
                x = 5;
                timer_sure.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            topBaslangic = top.Location;
            cubukBaslangic = cubuk.Location;
            timer_sure.Start();
        }

        private void timer_sure_Tick(object sender, EventArgs e)
        {
            if(top.Location.Y <= 0)
            {
                y = +5;
            }
            else if(top.Location.X >= this.Size.Width - 55)
            {
                x = -5;
            }
            else if(top.Location.X <= 0)
            {
                x = +5;
            }
            else if(top.Location.Y >= cubuk.Location.Y-30 
               &&(top.Location.X >=cubuk.Location.X && top.Location.X <=cubuk.Location.X+cubuk.Width))
            {
                y = -5;
            }

            if (top.Location.Y > cubuk.Location.Y - 10)
            {
                timer_sure.Stop();
                MessageBox.Show("yandınız");
                cubuk.Location = cubukBaslangic;
                top.Location = topBaslangic;
                return;
            }
            top.Location = new Point(top.Location.X +x, top.Location.Y +y);
        }
    }
}
