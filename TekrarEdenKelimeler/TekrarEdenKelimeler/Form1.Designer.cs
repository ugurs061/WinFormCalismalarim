namespace TekrarEdenKelimeler
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(14, 13);
            this.txtMetin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(476, 130);
            this.txtMetin.TabIndex = 0;
            this.txtMetin.Text = "Metin Giriniz...";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(149, 196);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(182, 64);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 29;
            this.lbSonuc.Location = new System.Drawing.Point(14, 308);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(476, 120);
            this.lbSonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 476);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tekrar Eden Kelimeleri Bulma by Uğur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.ListBox lbSonuc;
    }
}

