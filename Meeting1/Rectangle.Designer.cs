namespace Meeting1
{
    partial class Rectangle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Rectangle";
            this.Text = "Rectangle";
            this.Load += new System.EventHandler(this.Rectangle_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Rectangle_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Rectangle_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rectangle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rectangle_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

