namespace SayiTahminOyunuSabah
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
            components = new System.ComponentModel.Container();
            btnBaslat = new Button();
            label1 = new Label();
            txtSayi = new TextBox();
            btnTahmin = new Button();
            lblBilgi = new Label();
            progressBar = new ProgressBar();
            lblMesaj = new Label();
            oyunTimer = new System.Windows.Forms.Timer(components);
            lblSayac = new Label();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaslat.Location = new Point(21, 26);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(506, 95);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "OYUNU BAŞLAT";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 152);
            label1.Name = "label1";
            label1.Size = new Size(294, 25);
            label1.TabIndex = 1;
            label1.Text = "[1, 100] arasında bir sayı giriniz:";
            // 
            // txtSayi
            // 
            txtSayi.Enabled = false;
            txtSayi.Location = new Point(325, 154);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(202, 23);
            txtSayi.TabIndex = 2;
            txtSayi.TextChanged += txtSayi_TextChanged;
            // 
            // btnTahmin
            // 
            btnTahmin.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahmin.Location = new Point(27, 201);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(500, 42);
            btnTahmin.TabIndex = 3;
            btnTahmin.Text = "TAHMİN ET";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.BackColor = SystemColors.Info;
            lblBilgi.BorderStyle = BorderStyle.FixedSingle;
            lblBilgi.Location = new Point(27, 269);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(500, 35);
            lblBilgi.TabIndex = 4;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(27, 328);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(500, 34);
            progressBar.TabIndex = 5;
            // 
            // lblMesaj
            // 
            lblMesaj.BackColor = SystemColors.Info;
            lblMesaj.BorderStyle = BorderStyle.FixedSingle;
            lblMesaj.Location = new Point(27, 386);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(500, 35);
            lblMesaj.TabIndex = 5;
            // 
            // oyunTimer
            // 
            oyunTimer.Interval = 1000;
            oyunTimer.Tick += oyunTimer_Tick;
            // 
            // lblSayac
            // 
            lblSayac.BackColor = SystemColors.ScrollBar;
            lblSayac.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSayac.Location = new Point(342, 209);
            lblSayac.Name = "lblSayac";
            lblSayac.Size = new Size(41, 31);
            lblSayac.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 476);
            Controls.Add(lblSayac);
            Controls.Add(lblMesaj);
            Controls.Add(progressBar);
            Controls.Add(lblBilgi);
            Controls.Add(btnTahmin);
            Controls.Add(txtSayi);
            Controls.Add(label1);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Label label1;
        private TextBox txtSayi;
        private Button btnTahmin;
        private Label lblBilgi;
        private ProgressBar progressBar;
        private Label lblMesaj;
        private System.Windows.Forms.Timer oyunTimer;
        private Label lblSayac;
    }
}