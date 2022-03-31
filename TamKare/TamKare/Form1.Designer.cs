namespace TamKare
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
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 29;
            this.lbSonuc.Location = new System.Drawing.Point(19, 17);
            this.lbSonuc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(96, 410);
            this.lbSonuc.TabIndex = 0;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(330, 149);
            this.btnBul.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(132, 64);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(130, 162);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(153, 35);
            this.txtSayi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "(0 - ?) Kaça kadar tam kare sayıları bulmak istiyorsunuz ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.lbSonuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tam Kare by Uğur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label1;
    }
}

