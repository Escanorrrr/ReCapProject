
namespace VeriTabanı
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
            this.Kayıt_Button = new System.Windows.Forms.Button();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soy = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.txt_pas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kayıt_Button
            // 
            this.Kayıt_Button.Location = new System.Drawing.Point(153, 244);
            this.Kayıt_Button.Name = "Kayıt_Button";
            this.Kayıt_Button.Size = new System.Drawing.Size(138, 23);
            this.Kayıt_Button.TabIndex = 0;
            this.Kayıt_Button.Text = "Kaydet";
            this.Kayıt_Button.UseVisualStyleBackColor = true;
            this.Kayıt_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(153, 89);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(138, 20);
            this.txt_Ad.TabIndex = 1;
            this.txt_Ad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Soy
            // 
            this.txt_Soy.Location = new System.Drawing.Point(153, 132);
            this.txt_Soy.Name = "txt_Soy";
            this.txt_Soy.Size = new System.Drawing.Size(138, 20);
            this.txt_Soy.TabIndex = 2;
            this.txt_Soy.TextChanged += new System.EventHandler(this.txt_Soy_TextChanged);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(153, 171);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(138, 20);
            this.txt_ma.TabIndex = 3;
            this.txt_ma.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(153, 207);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(138, 20);
            this.txt_pw.TabIndex = 8;
            this.txt_pw.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txt_pas
            // 
            this.txt_pas.AutoSize = true;
            this.txt_pas.Location = new System.Drawing.Point(48, 214);
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.Size = new System.Drawing.Size(28, 13);
            this.txt_pas.TabIndex = 9;
            this.txt_pas.Text = "Şifre";
            this.txt_pas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_pas.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 279);
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.txt_Soy);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.Kayıt_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kayıt_Button;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soy;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label txt_pas;
    }
}

