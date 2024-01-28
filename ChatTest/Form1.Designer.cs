namespace ChatTest
{
    partial class Form1
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
            this.PortText = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.msgText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.IPText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PortText)).BeginInit();
            this.SuspendLayout();
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(179, 17);
            this.PortText.Margin = new System.Windows.Forms.Padding(2);
            this.PortText.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PortText.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(80, 20);
            this.PortText.TabIndex = 0;
            this.PortText.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 181);
            this.textBox1.TabIndex = 3;
            // 
            // msgText
            // 
            this.msgText.Location = new System.Drawing.Point(22, 261);
            this.msgText.Margin = new System.Windows.Forms.Padding(2);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(333, 20);
            this.msgText.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(22, 16);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(152, 20);
            this.IPText.TabIndex = 6;
            this.IPText.Text = "127.000.000.001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PortText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PortText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PortText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox msgText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IPText;
    }
}

