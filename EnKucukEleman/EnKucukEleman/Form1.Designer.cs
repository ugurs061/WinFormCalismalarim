namespace EnKucukEleman
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnSayiEkle = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(105, 114);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(153, 35);
            this.txtSayi.TabIndex = 0;
            // 
            // btnSayiEkle
            // 
            this.btnSayiEkle.Location = new System.Drawing.Point(287, 114);
            this.btnSayiEkle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSayiEkle.Name = "btnSayiEkle";
            this.btnSayiEkle.Size = new System.Drawing.Size(138, 38);
            this.btnSayiEkle.TabIndex = 1;
            this.btnSayiEkle.Text = "Sayı Ekle";
            this.btnSayiEkle.UseVisualStyleBackColor = true;
            this.btnSayiEkle.Click += new System.EventHandler(this.btnSayiEkle_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 29;
            this.lbSonuc.Location = new System.Drawing.Point(12, 12);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(75, 265);
            this.lbSonuc.TabIndex = 2;
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(272, 189);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(153, 66);
            this.btnSirala.TabIndex = 3;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(105, 189);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(153, 66);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(12, 284);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 31);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 351);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.btnSayiEkle);
            this.Controls.Add(this.txtSayi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "En Küçük Elemanı Bulma ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnSayiEkle;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnTemizle;
    }
}

