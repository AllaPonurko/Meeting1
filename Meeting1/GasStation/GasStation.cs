using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting1.GasStation
{
    public partial class GasStation : Form
    {
        

        public GasStation()
        {
            InitializeComponent();
            this.OilPrice.Text = this.PriceOil.Text;
            this.ListOil.Items.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CountAmericano_Click(object sender, EventArgs e)
        {
            
        }

        private void CountAmericano_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumFood_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListOil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        double sumOil;
        private void Choice_Click(object sender, EventArgs e)
        { 
            double p = double.Parse(OilPrice.Text);
            double c = double.Parse(CountOil.Text);
            sumOil = p * c;
            SummGas.Text = sumOil.ToString();
        }

        private void CountOil_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            
        }
        double sumProduct = 0;
        double sumFood;
        private void CountAmericano_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                int c = int.Parse(CountAmericano.Text);
                double p = double.Parse(PriceAmericano.Text);
                sumProduct = c * p;
                sumFood += sumProduct;
                SumFood.Text = sumFood.ToString();
            }
            
        }

        private void CountCappuchino_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                int c = int.Parse(CountCappuchino.Text);
                double p = double.Parse(PriceCappuchino.Text);
                sumProduct = c * p;
                sumFood += sumProduct;
                SumFood.Text = sumFood.ToString();
            }
        }

        private void CountCola_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                int c = int.Parse(CountCola.Text);
                double p = double.Parse(PriceCola.Text);
                sumProduct = c * p;
                sumFood += sumProduct;
                SumFood.Text = sumFood.ToString();
            }
        }

        private void CountHamburger_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                int c = int.Parse(CountHamburger.Text);
                double p = double.Parse(PriceHamburger.Text);
                sumProduct = c * p;
                sumFood += sumProduct;
                SumFood.Text = sumFood.ToString();
            }
        }

        private void CountCheeseBurger_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                int c = int.Parse(CountCheeseBurger.Text);
                double p = double.Parse(PriceCheeseBurger.Text);
                sumProduct = c * p;
                sumFood += sumProduct;
                SumFood.Text = sumFood.ToString();
            }
        }

        private void CountHotDog_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                int c = int.Parse(CountHotDog.Text);
                double p = double.Parse(PriceHotDog.Text);
                sumProduct = c * p;
                sumFood += sumProduct;
                SumFood.Text = sumFood.ToString();
            }
            
        }
        double totalAmount;
        private void button1_Click(object sender, EventArgs e)
        { totalAmount = sumFood + sumOil;
            Amount.Text = totalAmount.ToString();
        }
    }
}
