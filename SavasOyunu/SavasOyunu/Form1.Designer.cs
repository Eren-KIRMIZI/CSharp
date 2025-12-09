namespace SavasOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSec = new Button();
            txtOyuncu = new TextBox();
            txtIrk = new TextBox();
            txtBrans = new TextBox();
            txtSilah = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDusmanCan = new Label();
            pictureBox1 = new PictureBox();
            btnSaldir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSec
            // 
            btnSec.Location = new Point(167, 226);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(121, 56);
            btnSec.TabIndex = 0;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // txtOyuncu
            // 
            txtOyuncu.Location = new Point(124, 20);
            txtOyuncu.Name = "txtOyuncu";
            txtOyuncu.Size = new Size(164, 23);
            txtOyuncu.TabIndex = 1;
            // 
            // txtIrk
            // 
            txtIrk.Location = new Point(124, 69);
            txtIrk.Name = "txtIrk";
            txtIrk.Size = new Size(164, 23);
            txtIrk.TabIndex = 2;
            // 
            // txtBrans
            // 
            txtBrans.Location = new Point(124, 124);
            txtBrans.Name = "txtBrans";
            txtBrans.Size = new Size(164, 23);
            txtBrans.TabIndex = 3;
            // 
            // txtSilah
            // 
            txtSilah.Location = new Point(124, 172);
            txtSilah.Name = "txtSilah";
            txtSilah.Size = new Size(164, 23);
            txtSilah.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Oyuncu İsmi: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 77);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 6;
            label2.Text = "Irk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 132);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Brans:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 180);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "Silah:";
            // 
            // lblDusmanCan
            // 
            lblDusmanCan.BackColor = Color.DarkRed;
            lblDusmanCan.Location = new Point(400, 16);
            lblDusmanCan.Name = "lblDusmanCan";
            lblDusmanCan.Size = new Size(300, 22);
            lblDusmanCan.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(400, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnSaldir
            // 
            btnSaldir.BackColor = SystemColors.ActiveCaption;
            btnSaldir.Location = new Point(579, 226);
            btnSaldir.Name = "btnSaldir";
            btnSaldir.Size = new Size(121, 61);
            btnSaldir.TabIndex = 11;
            btnSaldir.Text = "Saldır";
            btnSaldir.UseVisualStyleBackColor = false;
            btnSaldir.Click += btnSaldir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 296);
            Controls.Add(btnSaldir);
            Controls.Add(pictureBox1);
            Controls.Add(lblDusmanCan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSilah);
            Controls.Add(txtBrans);
            Controls.Add(txtIrk);
            Controls.Add(txtOyuncu);
            Controls.Add(btnSec);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSec;
        private TextBox txtOyuncu;
        private TextBox txtIrk;
        private TextBox txtBrans;
        private TextBox txtSilah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDusmanCan;
        private PictureBox pictureBox1;
        private Button btnSaldir;
    }
}
