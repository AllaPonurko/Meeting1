
namespace Meeting1.GasStation
{
    partial class GasStation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PriceGas = new System.Windows.Forms.Panel();
            this.SummGas = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.Grivna = new System.Windows.Forms.TextBox();
            this.Litr = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.CheckBox();
            this.Count = new System.Windows.Forms.CheckBox();
            this.Choice = new System.Windows.Forms.Button();
            this.ListOil = new System.Windows.Forms.ComboBox();
            this.Oil = new System.Windows.Forms.TextBox();
            this.MiniCafe = new System.Windows.Forms.Panel();
            this.SumFood = new System.Windows.Forms.TextBox();
            this.SummaryFood = new System.Windows.Forms.TextBox();
            this.CountHotDog = new System.Windows.Forms.TextBox();
            this.CountCheeseBurger = new System.Windows.Forms.TextBox();
            this.CountHamburger = new System.Windows.Forms.TextBox();
            this.CountCola = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.CountCappuchino = new System.Windows.Forms.TextBox();
            this.CountAmericano = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.NameProduct = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HotDog = new System.Windows.Forms.CheckBox();
            this.CheesBurger = new System.Windows.Forms.CheckBox();
            this.Hamburger = new System.Windows.Forms.CheckBox();
            this.Cola = new System.Windows.Forms.CheckBox();
            this.Cappuchino = new System.Windows.Forms.CheckBox();
            this.Americano = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PriceCola = new System.Windows.Forms.TextBox();
            this.total_amount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.PriceGas.SuspendLayout();
            this.MiniCafe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriceGas
            // 
            this.PriceGas.Controls.Add(this.textBox9);
            this.PriceGas.Controls.Add(this.textBox3);
            this.PriceGas.Controls.Add(this.SummGas);
            this.PriceGas.Controls.Add(this.textBox11);
            this.PriceGas.Controls.Add(this.Grivna);
            this.PriceGas.Controls.Add(this.Litr);
            this.PriceGas.Controls.Add(this.Price);
            this.PriceGas.Controls.Add(this.Count);
            this.PriceGas.Controls.Add(this.Choice);
            this.PriceGas.Controls.Add(this.ListOil);
            this.PriceGas.Controls.Add(this.Oil);
            this.PriceGas.Location = new System.Drawing.Point(-2, -1);
            this.PriceGas.Name = "PriceGas";
            this.PriceGas.Size = new System.Drawing.Size(403, 265);
            this.PriceGas.TabIndex = 0;
            this.PriceGas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SummGas
            // 
            this.SummGas.Location = new System.Drawing.Point(210, 223);
            this.SummGas.Name = "SummGas";
            this.SummGas.Size = new System.Drawing.Size(100, 20);
            this.SummGas.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(15, 224);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 7;
            this.textBox11.Text = "К оплате:";
            // 
            // Grivna
            // 
            this.Grivna.Location = new System.Drawing.Point(210, 153);
            this.Grivna.Name = "Grivna";
            this.Grivna.Size = new System.Drawing.Size(100, 20);
            this.Grivna.TabIndex = 6;
            this.Grivna.Text = "грн.";
            this.Grivna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Litr
            // 
            this.Litr.Location = new System.Drawing.Point(210, 122);
            this.Litr.Name = "Litr";
            this.Litr.Size = new System.Drawing.Size(100, 20);
            this.Litr.TabIndex = 5;
            this.Litr.Text = "л.";
            this.Litr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(14, 153);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(52, 17);
            this.Price.TabIndex = 4;
            this.Price.Text = "Цена";
            this.Price.UseVisualStyleBackColor = true;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(15, 125);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(85, 17);
            this.Count.TabIndex = 3;
            this.Count.Text = "Количество";
            this.Count.UseVisualStyleBackColor = true;
            // 
            // Choice
            // 
            this.Choice.Location = new System.Drawing.Point(235, 23);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(75, 23);
            this.Choice.TabIndex = 2;
            this.Choice.Text = "Выбрать";
            this.Choice.UseVisualStyleBackColor = true;
            // 
            // ListOil
            // 
            this.ListOil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ListOil.FormattingEnabled = true;
            this.ListOil.Items.AddRange(new object[] {
            "Бензин А95",
            "Бензин А98",
            "Бензин А92",
            "Дизельное топливо"});
            this.ListOil.Location = new System.Drawing.Point(14, 23);
            this.ListOil.Name = "ListOil";
            this.ListOil.Size = new System.Drawing.Size(121, 21);
            this.ListOil.TabIndex = 1;
            this.ListOil.SelectedIndexChanged += new System.EventHandler(this.ListOil_SelectedIndexChanged);
            // 
            // Oil
            // 
            this.Oil.Location = new System.Drawing.Point(14, 71);
            this.Oil.Multiline = true;
            this.Oil.Name = "Oil";
            this.Oil.Size = new System.Drawing.Size(100, 20);
            this.Oil.TabIndex = 0;
            // 
            // MiniCafe
            // 
            this.MiniCafe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MiniCafe.Controls.Add(this.PriceCola);
            this.MiniCafe.Controls.Add(this.SumFood);
            this.MiniCafe.Controls.Add(this.SummaryFood);
            this.MiniCafe.Controls.Add(this.CountHotDog);
            this.MiniCafe.Controls.Add(this.CountCheeseBurger);
            this.MiniCafe.Controls.Add(this.CountHamburger);
            this.MiniCafe.Controls.Add(this.CountCola);
            this.MiniCafe.Controls.Add(this.textBox10);
            this.MiniCafe.Controls.Add(this.CountCappuchino);
            this.MiniCafe.Controls.Add(this.CountAmericano);
            this.MiniCafe.Controls.Add(this.textBox7);
            this.MiniCafe.Controls.Add(this.textBox6);
            this.MiniCafe.Controls.Add(this.textBox5);
            this.MiniCafe.Controls.Add(this.textBox4);
            this.MiniCafe.Controls.Add(this.NameProduct);
            this.MiniCafe.Controls.Add(this.textBox2);
            this.MiniCafe.Controls.Add(this.textBox1);
            this.MiniCafe.Controls.Add(this.HotDog);
            this.MiniCafe.Controls.Add(this.CheesBurger);
            this.MiniCafe.Controls.Add(this.Hamburger);
            this.MiniCafe.Controls.Add(this.Cola);
            this.MiniCafe.Controls.Add(this.Cappuchino);
            this.MiniCafe.Controls.Add(this.Americano);
            this.MiniCafe.Location = new System.Drawing.Point(407, -1);
            this.MiniCafe.Name = "MiniCafe";
            this.MiniCafe.Size = new System.Drawing.Size(397, 265);
            this.MiniCafe.TabIndex = 1;
            // 
            // SumFood
            // 
            this.SumFood.Location = new System.Drawing.Point(281, 223);
            this.SumFood.Name = "SumFood";
            this.SumFood.Size = new System.Drawing.Size(100, 20);
            this.SumFood.TabIndex = 21;
            this.SumFood.TextChanged += new System.EventHandler(this.SumFood_TextChanged);
            // 
            // SummaryFood
            // 
            this.SummaryFood.Location = new System.Drawing.Point(20, 223);
            this.SummaryFood.Name = "SummaryFood";
            this.SummaryFood.Size = new System.Drawing.Size(100, 20);
            this.SummaryFood.TabIndex = 20;
            this.SummaryFood.Text = "К оплате:";
            // 
            // CountHotDog
            // 
            this.CountHotDog.Location = new System.Drawing.Point(281, 174);
            this.CountHotDog.Name = "CountHotDog";
            this.CountHotDog.Size = new System.Drawing.Size(100, 20);
            this.CountHotDog.TabIndex = 19;
            this.CountHotDog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountCheeseBurger
            // 
            this.CountCheeseBurger.Location = new System.Drawing.Point(281, 148);
            this.CountCheeseBurger.Name = "CountCheeseBurger";
            this.CountCheeseBurger.Size = new System.Drawing.Size(100, 20);
            this.CountCheeseBurger.TabIndex = 18;
            this.CountCheeseBurger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountHamburger
            // 
            this.CountHamburger.Location = new System.Drawing.Point(281, 121);
            this.CountHamburger.Name = "CountHamburger";
            this.CountHamburger.Size = new System.Drawing.Size(100, 20);
            this.CountHamburger.TabIndex = 17;
            this.CountHamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountCola
            // 
            this.CountCola.Location = new System.Drawing.Point(281, 95);
            this.CountCola.Name = "CountCola";
            this.CountCola.Size = new System.Drawing.Size(100, 20);
            this.CountCola.TabIndex = 16;
            this.CountCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(151, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 15;
            this.textBox10.Text = "Цена";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountCappuchino
            // 
            this.CountCappuchino.Location = new System.Drawing.Point(281, 67);
            this.CountCappuchino.Name = "CountCappuchino";
            this.CountCappuchino.Size = new System.Drawing.Size(100, 20);
            this.CountCappuchino.TabIndex = 14;
            this.CountCappuchino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountAmericano
            // 
            this.CountAmericano.Location = new System.Drawing.Point(281, 41);
            this.CountAmericano.Name = "CountAmericano";
            this.CountAmericano.Size = new System.Drawing.Size(100, 20);
            this.CountAmericano.TabIndex = 13;
            this.CountAmericano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountAmericano.Click += new System.EventHandler(this.CountAmericano_Click);
            this.CountAmericano.TextChanged += new System.EventHandler(this.CountAmericano_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(281, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "Количество";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(151, 175);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "30.00";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "21.00";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "24.00";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameProduct
            // 
            this.NameProduct.Location = new System.Drawing.Point(20, 3);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(100, 20);
            this.NameProduct.TabIndex = 22;
            this.NameProduct.Text = "Наименование";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "30.00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "25.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HotDog
            // 
            this.HotDog.AutoSize = true;
            this.HotDog.Location = new System.Drawing.Point(20, 175);
            this.HotDog.Name = "HotDog";
            this.HotDog.Size = new System.Drawing.Size(64, 17);
            this.HotDog.TabIndex = 5;
            this.HotDog.Text = "Хот-дог";
            this.HotDog.UseVisualStyleBackColor = true;
            // 
            // CheesBurger
            // 
            this.CheesBurger.AutoSize = true;
            this.CheesBurger.Location = new System.Drawing.Point(20, 148);
            this.CheesBurger.Name = "CheesBurger";
            this.CheesBurger.Size = new System.Drawing.Size(80, 17);
            this.CheesBurger.TabIndex = 4;
            this.CheesBurger.Text = "Чизбургер";
            this.CheesBurger.UseVisualStyleBackColor = true;
            // 
            // Hamburger
            // 
            this.Hamburger.AutoSize = true;
            this.Hamburger.Location = new System.Drawing.Point(20, 125);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(80, 17);
            this.Hamburger.TabIndex = 3;
            this.Hamburger.Text = "Гамбургер";
            this.Hamburger.UseVisualStyleBackColor = true;
            // 
            // Cola
            // 
            this.Cola.AutoSize = true;
            this.Cola.Location = new System.Drawing.Point(20, 99);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(51, 17);
            this.Cola.TabIndex = 2;
            this.Cola.Text = "Кола";
            this.Cola.UseVisualStyleBackColor = true;
            // 
            // Cappuchino
            // 
            this.Cappuchino.AutoSize = true;
            this.Cappuchino.Location = new System.Drawing.Point(20, 71);
            this.Cappuchino.Name = "Cappuchino";
            this.Cappuchino.Size = new System.Drawing.Size(73, 17);
            this.Cappuchino.TabIndex = 1;
            this.Cappuchino.Text = "Капучино";
            this.Cappuchino.UseVisualStyleBackColor = true;
            // 
            // Americano
            // 
            this.Americano.AutoSize = true;
            this.Americano.Location = new System.Drawing.Point(20, 44);
            this.Americano.Name = "Americano";
            this.Americano.Size = new System.Drawing.Size(83, 17);
            this.Americano.TabIndex = 0;
            this.Americano.Text = "Американо";
            this.Americano.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.total_amount);
            this.panel1.Location = new System.Drawing.Point(-2, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 189);
            this.panel1.TabIndex = 2;
            // 
            // PriceCola
            // 
            this.PriceCola.Location = new System.Drawing.Point(151, 94);
            this.PriceCola.Name = "PriceCola";
            this.PriceCola.Size = new System.Drawing.Size(100, 20);
            this.PriceCola.TabIndex = 23;
            this.PriceCola.Text = "15,00";
            this.PriceCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_amount
            // 
            this.total_amount.Location = new System.Drawing.Point(15, 84);
            this.total_amount.Name = "total_amount";
            this.total_amount.Size = new System.Drawing.Size(100, 20);
            this.total_amount.TabIndex = 0;
            this.total_amount.Text = "Итого к оплате:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(219, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(543, 80);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 60);
            this.textBox8.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(104, 153);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            // 
            // GasStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MiniCafe);
            this.Controls.Add(this.PriceGas);
            this.Name = "GasStation";
            this.Text = "GasStation";
            this.PriceGas.ResumeLayout(false);
            this.PriceGas.PerformLayout();
            this.MiniCafe.ResumeLayout(false);
            this.MiniCafe.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PriceGas;
        private System.Windows.Forms.Button Choice;
        private System.Windows.Forms.ComboBox ListOil;
        private System.Windows.Forms.TextBox Oil;
        private System.Windows.Forms.Panel MiniCafe;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox NameProduct;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox HotDog;
        private System.Windows.Forms.CheckBox CheesBurger;
        private System.Windows.Forms.CheckBox Hamburger;
        private System.Windows.Forms.CheckBox Cola;
        private System.Windows.Forms.CheckBox Cappuchino;
        private System.Windows.Forms.CheckBox Americano;
        private System.Windows.Forms.TextBox SummGas;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox Grivna;
        private System.Windows.Forms.TextBox Litr;
        private System.Windows.Forms.CheckBox Price;
        private System.Windows.Forms.CheckBox Count;
        private System.Windows.Forms.TextBox SumFood;
        private System.Windows.Forms.TextBox SummaryFood;
        private System.Windows.Forms.TextBox CountHotDog;
        private System.Windows.Forms.TextBox CountCheeseBurger;
        private System.Windows.Forms.TextBox CountHamburger;
        private System.Windows.Forms.TextBox CountCola;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox CountCappuchino;
        private System.Windows.Forms.TextBox CountAmericano;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PriceCola;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox total_amount;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox3;
    }
}