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
    public partial class GasStation : Form
    {
        
        public GasStation()
        {
            InitializeComponent();
            Text = "Автозаправка";
            
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

            if (!Char.IsDigit(number)&&!Char.IsPunctuation(number))
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
                
            }
            
        }

        private void CountCappuchino_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                
            }
        }

        private void CountCola_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                
            }
        }

        private void CountHamburger_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                
            }
        }

        private void CountCheeseBurger_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                
            }
        }

        private void CountHotDog_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
                
            }
            
        }
        double totalAmount;
        private void button1_Click(object sender, EventArgs e)
        { totalAmount = sumFood + sumOil;
            Amount.Text = totalAmount.ToString()+" грн.";
        }

        private void AmountFood_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes1 = new List<TextBox>();
            textBoxes1.Add(PriceAmericano);
            textBoxes1.Add(PriceCappuchino);
            textBoxes1.Add(PriceCola);
            textBoxes1.Add(PriceHamburger);
            textBoxes1.Add(PriceCheeseBurger);
            textBoxes1.Add(PriceHotDog);
            List<TextBox> textBoxes2 = new List<TextBox>();
            textBoxes2.Add(CountAmericano);
            textBoxes2.Add(CountCappuchino);
            textBoxes2.Add(CountCola);
            textBoxes2.Add(CountHamburger);
            textBoxes2.Add(CountCheeseBurger);
            textBoxes2.Add(CountHotDog);
            for (int i=0;i<textBoxes1.Count;i++)
                for(int j=0;j<textBoxes2.Count;j++)
                {
                  if (i == j&& textBoxes2[j].Text !=null)
                    {
                        sumProduct = Convert.ToDouble(textBoxes1[i].Text) * 
                            Convert.ToInt32( textBoxes2[j].Text);
                        sumFood += sumProduct;
                        SumFood.Text = sumFood.ToString();
                    }
                }
        }

        private void PriceOil_TextChanged(object sender, EventArgs e)
        {
            PriceOil.Text = OilPrice.Text;
        }

        private void OilPrice_TextChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(OilPrice.Text);
        }
    }
}
