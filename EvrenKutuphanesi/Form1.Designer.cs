
namespace EvrenKutuphanesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdGiristxt = new System.Windows.Forms.TextBox();
            this.SifreGiristxt = new System.Windows.Forms.TextBox();
            this.PersonelGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(38, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(38, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // AdGiristxt
            // 
            this.AdGiristxt.Location = new System.Drawing.Point(126, 159);
            this.AdGiristxt.Name = "AdGiristxt";
            this.AdGiristxt.Size = new System.Drawing.Size(161, 20);
            this.AdGiristxt.TabIndex = 2;
            // 
            // SifreGiristxt
            // 
            this.SifreGiristxt.Location = new System.Drawing.Point(126, 223);
            this.SifreGiristxt.Name = "SifreGiristxt";
            this.SifreGiristxt.Size = new System.Drawing.Size(161, 20);
            this.SifreGiristxt.TabIndex = 3;
            // 
            // PersonelGirisBtn
            // 
            this.PersonelGirisBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.PersonelGirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonelGirisBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PersonelGirisBtn.Location = new System.Drawing.Point(41, 283);
            this.PersonelGirisBtn.Name = "PersonelGirisBtn";
            this.PersonelGirisBtn.Size = new System.Drawing.Size(220, 45);
            this.PersonelGirisBtn.TabIndex = 4;
            this.PersonelGirisBtn.Text = "GİRİŞ";
            this.PersonelGirisBtn.UseVisualStyleBackColor = false;
            this.PersonelGirisBtn.Click += new System.EventHandler(this.PersonelGirisBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(299, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PersonelGirisBtn);
            this.Controls.Add(this.SifreGiristxt);
            this.Controls.Add(this.AdGiristxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdGiristxt;
        private System.Windows.Forms.TextBox SifreGiristxt;
        private System.Windows.Forms.Button PersonelGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

