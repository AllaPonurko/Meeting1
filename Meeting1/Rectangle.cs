using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting1
{
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
            this.BackColor=Color.White; 
        }

        private void Rectangle_Load(object sender, EventArgs e)
        {
            
        }
        Graphics g;
        Pen pen = new Pen(Color.Black);
        private void Rectangle_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Blue);
            g.DrawRectangle(pen, 10, 10,Width-40,Height-60);
        }
        Point click;
        private void Rectangle_MouseClick(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            click = e.Location;
            g.DrawEllipse(pen, click.X, click.Y, 300, 100);

        }

        private void Rectangle_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
            if (e.Button == MouseButtons.Left)
            {if(click.X==10||click.Y==10||click.X== this.Width - 40
                    ||click.Y== this.Height - 60)
                MessageBox.Show("Точка находится на границе прямоугольника");
                if(click.X < 10 || click.Y < 10 || click.X> this.Width - 40
                    || click.Y > this.Height - 60)
                    MessageBox.Show("Точка находится за границей прямоугольника");
                else { MessageBox.Show("Точка находится внутри прямоугольника"); }
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Ширина окна "+Convert.ToString(this.Size.Width)+
                    " Высота окна  "+ Convert.ToString(this.Size.Height));
                
            }
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
             Text = MousePosition.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GasStation gasstation = new GasStation();
            gasstation.Show();
        }
    }
}