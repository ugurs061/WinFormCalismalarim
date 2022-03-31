namespace SıcaklıkHesaplama
{
    partial class Form1
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelcius = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblK2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(827, 38);
            this.btnC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(135, 33);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "Hesapla";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(878, 207);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(84, 37);
            this.btnCıkıs.TabIndex = 7;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fahrenheit: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kelvin:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(144, 32);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 35);
            this.txtC.TabIndex = 11;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(476, 39);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(26, 29);
            this.lblF.TabIndex = 12;
            this.lblF.Text = "0";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(715, 39);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(26, 29);
            this.lblK.TabIndex = 13;
            this.lblK.Text = "0";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(12, 88);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(115, 29);
            this.lblFahrenheit.TabIndex = 8;
            this.lblFahrenheit.Text = "Farenheit";
            // 
            // lblCelcius
            // 
            this.lblCelcius.AutoSize = true;
            this.lblCelcius.Location = new System.Drawing.Point(301, 88);
            this.lblCelcius.Name = "lblCelcius";
            this.lblCelcius.Size = new System.Drawing.Size(105, 29);
            this.lblCelcius.TabIndex = 9;
            this.lblCelcius.Text = "Celcius: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kelvin:";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(144, 88);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 35);
            this.txtF.TabIndex = 11;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(476, 95);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 29);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "0";
            // 
            // lblK2
            // 
            this.lblK2.AutoSize = true;
            this.lblK2.Location = new System.Drawing.Point(715, 95);
            this.lblK2.Name = "lblK2";
            this.lblK2.Size = new System.Drawing.Size(26, 29);
            this.lblK2.TabIndex = 13;
            this.lblK2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kelvin";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(144, 147);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 35);
            this.txtK.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 29);
            this.label12.TabIndex = 12;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(715, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 29);
            this.label13.TabIndex = 13;
            this.label13.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Celcius: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Farenheit:";
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(827, 91);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(135, 36);
            this.btnF.TabIndex = 14;
            this.btnF.Text = "Hesapla";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(827, 147);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(135, 36);
            this.btnK.TabIndex = 15;
            this.btnK.Text = "Hesapla";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 266);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblK2);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCelcius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sıcaklık Hesaplama by Uğur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelcius;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblK2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnK;
    }
}

