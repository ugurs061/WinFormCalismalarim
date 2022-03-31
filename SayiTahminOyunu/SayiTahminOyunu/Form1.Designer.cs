namespace SayiTahminOyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblHakSayi = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Girin";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(116, 23);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 26);
            this.txtSayi.TabIndex = 1;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(245, 26);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(99, 20);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Yukarı-Aşağı";
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(37, 81);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(114, 41);
            this.btnTahminEt.TabIndex = 3;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Location = new System.Drawing.Point(373, 26);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(42, 20);
            this.lblHak.TabIndex = 5;
            this.lblHak.Text = "Hak:";
            // 
            // lblHakSayi
            // 
            this.lblHakSayi.AutoSize = true;
            this.lblHakSayi.Location = new System.Drawing.Point(422, 26);
            this.lblHakSayi.Name = "lblHakSayi";
            this.lblHakSayi.Size = new System.Drawing.Size(18, 20);
            this.lblHakSayi.TabIndex = 6;
            this.lblHakSayi.Text = "0";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(377, 60);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(79, 37);
            this.btnBasla.TabIndex = 7;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(377, 104);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(79, 34);
            this.btnCıkıs.TabIndex = 8;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 183);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblHakSayi);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Tahmin Oyunu By Uğur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblHakSayi;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnCıkıs;
    }
}

