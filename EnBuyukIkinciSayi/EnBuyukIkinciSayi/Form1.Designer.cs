namespace EnBuyukIkinciSayi
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
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnIkinciSayi = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 20;
            this.lbListe.Location = new System.Drawing.Point(239, 27);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(102, 324);
            this.lbListe.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(142, 39);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(73, 38);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(24, 42);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 26);
            this.txtSayi.TabIndex = 2;
            // 
            // btnIkinciSayi
            // 
            this.btnIkinciSayi.Location = new System.Drawing.Point(13, 140);
            this.btnIkinciSayi.Name = "btnIkinciSayi";
            this.btnIkinciSayi.Size = new System.Drawing.Size(202, 37);
            this.btnIkinciSayi.TabIndex = 3;
            this.btnIkinciSayi.Text = "En Büyük İkinci Sayı";
            this.btnIkinciSayi.UseVisualStyleBackColor = true;
            this.btnIkinciSayi.Click += new System.EventHandler(this.btnIkinciSayi_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(106, 107);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(18, 20);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "0";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(250, 357);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(78, 27);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 396);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnIkinciSayi);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbListe);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "En Büyük İkinci Sayı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnIkinciSayi;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnGoster;
    }
}

