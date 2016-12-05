namespace TestEncryptDecrypt
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTextEncryption = new System.Windows.Forms.TabPage();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.tabFileEncryption = new System.Windows.Forms.TabPage();
            this.txtDestinationEncrypt = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.txtConPassEncrypt = new System.Windows.Forms.TextBox();
            this.txtPassEncrypt = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnBrowseEncrypt = new System.Windows.Forms.Button();
            this.txtFileToEncrypt = new System.Windows.Forms.TextBox();
            this.tabFileDecryption = new System.Windows.Forms.TabPage();
            this.txtDestinationDecrypt = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.txtConPassDecrypt = new System.Windows.Forms.TextBox();
            this.txtPassDecrypt = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnBrowseDecrypt = new System.Windows.Forms.Button();
            this.txtFileToDecrypt = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabTextEncryption.SuspendLayout();
            this.tabFileEncryption.SuspendLayout();
            this.tabFileDecryption.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTextEncryption);
            this.tabControl1.Controls.Add(this.tabFileEncryption);
            this.tabControl1.Controls.Add(this.tabFileDecryption);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 164);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTextEncryption
            // 
            this.tabTextEncryption.Controls.Add(this.lblSecretKey);
            this.tabTextEncryption.Controls.Add(this.lblEncrypted);
            this.tabTextEncryption.Controls.Add(this.lblDecrypted);
            this.tabTextEncryption.Controls.Add(this.btnDecrypt);
            this.tabTextEncryption.Controls.Add(this.btnEncrypt);
            this.tabTextEncryption.Controls.Add(this.txtPhrase);
            this.tabTextEncryption.Controls.Add(this.txtDecrypt);
            this.tabTextEncryption.Controls.Add(this.txtEncrypt);
            this.tabTextEncryption.Location = new System.Drawing.Point(4, 22);
            this.tabTextEncryption.Name = "tabTextEncryption";
            this.tabTextEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextEncryption.Size = new System.Drawing.Size(419, 138);
            this.tabTextEncryption.TabIndex = 0;
            this.tabTextEncryption.Text = "Enkripsi/Dekripsi Text";
            this.tabTextEncryption.UseVisualStyleBackColor = true;
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(197, 10);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(34, 13);
            this.lblSecretKey.TabIndex = 15;
            this.lblSecretKey.Text = "Kunci";
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Location = new System.Drawing.Point(315, 10);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(68, 13);
            this.lblEncrypted.TabIndex = 14;
            this.lblEncrypted.Text = "Text Enkripsi";
            this.lblEncrypted.Click += new System.EventHandler(this.lblEncrypted_Click);
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(37, 10);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(69, 13);
            this.lblDecrypted.TabIndex = 13;
            this.lblDecrypted.Text = "Text Dekripsi";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(181, 88);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Dekripsi";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(181, 59);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Enkripsi";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(163, 26);
            this.txtPhrase.MaxLength = 10;
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.PasswordChar = '*';
            this.txtPhrase.Size = new System.Drawing.Size(108, 20);
            this.txtPhrase.TabIndex = 10;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(289, 26);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(118, 90);
            this.txtDecrypt.TabIndex = 9;
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(12, 26);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(130, 90);
            this.txtEncrypt.TabIndex = 8;
            // 
            // tabFileEncryption
            // 
            this.tabFileEncryption.Controls.Add(this.txtDestinationEncrypt);
            this.tabFileEncryption.Controls.Add(this.Label4);
            this.tabFileEncryption.Controls.Add(this.btnFileEncrypt);
            this.tabFileEncryption.Controls.Add(this.txtConPassEncrypt);
            this.tabFileEncryption.Controls.Add(this.txtPassEncrypt);
            this.tabFileEncryption.Controls.Add(this.Label1);
            this.tabFileEncryption.Controls.Add(this.Label3);
            this.tabFileEncryption.Controls.Add(this.Label2);
            this.tabFileEncryption.Controls.Add(this.btnBrowseEncrypt);
            this.tabFileEncryption.Controls.Add(this.txtFileToEncrypt);
            this.tabFileEncryption.Location = new System.Drawing.Point(4, 22);
            this.tabFileEncryption.Name = "tabFileEncryption";
            this.tabFileEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileEncryption.Size = new System.Drawing.Size(419, 138);
            this.tabFileEncryption.TabIndex = 1;
            this.tabFileEncryption.Text = "Enkripsi File";
            this.tabFileEncryption.UseVisualStyleBackColor = true;
            // 
            // txtDestinationEncrypt
            // 
            this.txtDestinationEncrypt.Location = new System.Drawing.Point(127, 46);
            this.txtDestinationEncrypt.Name = "txtDestinationEncrypt";
            this.txtDestinationEncrypt.ReadOnly = true;
            this.txtDestinationEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtDestinationEncrypt.TabIndex = 21;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(31, 46);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 16);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "File tujuan:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.Enabled = false;
            this.btnFileEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileEncrypt.Location = new System.Drawing.Point(326, 86);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(72, 32);
            this.btnFileEncrypt.TabIndex = 19;
            this.btnFileEncrypt.Text = "Enkripsi";
            this.btnFileEncrypt.Click += new System.EventHandler(this.btnFileEncrypt_Click);
            // 
            // txtConPassEncrypt
            // 
            this.txtConPassEncrypt.Location = new System.Drawing.Point(127, 102);
            this.txtConPassEncrypt.Name = "txtConPassEncrypt";
            this.txtConPassEncrypt.PasswordChar = '*';
            this.txtConPassEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtConPassEncrypt.TabIndex = 18;
            // 
            // txtPassEncrypt
            // 
            this.txtPassEncrypt.Location = new System.Drawing.Point(127, 78);
            this.txtPassEncrypt.Name = "txtPassEncrypt";
            this.txtPassEncrypt.PasswordChar = '*';
            this.txtPassEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtPassEncrypt.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(21, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 20);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "File yg di enkripsi:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(3, 100);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(116, 20);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Konfirmasi password:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(31, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 16);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Ketik password:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowseEncrypt
            // 
            this.btnBrowseEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseEncrypt.BackgroundImage")));
            this.btnBrowseEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowseEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseEncrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowseEncrypt.Location = new System.Drawing.Point(341, 22);
            this.btnBrowseEncrypt.Name = "btnBrowseEncrypt";
            this.btnBrowseEncrypt.Size = new System.Drawing.Size(56, 58);
            this.btnBrowseEncrypt.TabIndex = 13;
            this.btnBrowseEncrypt.Click += new System.EventHandler(this.btnBrowseEncrypt_Click);
            // 
            // txtFileToEncrypt
            // 
            this.txtFileToEncrypt.Location = new System.Drawing.Point(127, 22);
            this.txtFileToEncrypt.Name = "txtFileToEncrypt";
            this.txtFileToEncrypt.ReadOnly = true;
            this.txtFileToEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtFileToEncrypt.TabIndex = 12;
            this.txtFileToEncrypt.Text = "Klik ikon untuk mencari file.";
            // 
            // tabFileDecryption
            // 
            this.tabFileDecryption.Controls.Add(this.txtDestinationDecrypt);
            this.tabFileDecryption.Controls.Add(this.Label5);
            this.tabFileDecryption.Controls.Add(this.btnFileDecrypt);
            this.tabFileDecryption.Controls.Add(this.txtConPassDecrypt);
            this.tabFileDecryption.Controls.Add(this.txtPassDecrypt);
            this.tabFileDecryption.Controls.Add(this.Label6);
            this.tabFileDecryption.Controls.Add(this.Label7);
            this.tabFileDecryption.Controls.Add(this.Label8);
            this.tabFileDecryption.Controls.Add(this.btnBrowseDecrypt);
            this.tabFileDecryption.Controls.Add(this.txtFileToDecrypt);
            this.tabFileDecryption.Location = new System.Drawing.Point(4, 22);
            this.tabFileDecryption.Name = "tabFileDecryption";
            this.tabFileDecryption.Size = new System.Drawing.Size(419, 138);
            this.tabFileDecryption.TabIndex = 2;
            this.tabFileDecryption.Text = "Dekripsi File";
            this.tabFileDecryption.UseVisualStyleBackColor = true;
            this.tabFileDecryption.Click += new System.EventHandler(this.tabFileDecryption_Click);
            // 
            // txtDestinationDecrypt
            // 
            this.txtDestinationDecrypt.Location = new System.Drawing.Point(127, 46);
            this.txtDestinationDecrypt.Name = "txtDestinationDecrypt";
            this.txtDestinationDecrypt.ReadOnly = true;
            this.txtDestinationDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtDestinationDecrypt.TabIndex = 32;
            this.txtDestinationDecrypt.TextChanged += new System.EventHandler(this.txtDestinationDecrypt_TextChanged);
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(31, 46);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 16);
            this.Label5.TabIndex = 31;
            this.Label5.Text = "File tujuan:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnFileDecrypt
            // 
            this.btnFileDecrypt.Enabled = false;
            this.btnFileDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileDecrypt.Location = new System.Drawing.Point(326, 86);
            this.btnFileDecrypt.Name = "btnFileDecrypt";
            this.btnFileDecrypt.Size = new System.Drawing.Size(72, 32);
            this.btnFileDecrypt.TabIndex = 30;
            this.btnFileDecrypt.Text = "Dekripsi";
            this.btnFileDecrypt.Click += new System.EventHandler(this.btnFileDecrypt_Click);
            // 
            // txtConPassDecrypt
            // 
            this.txtConPassDecrypt.Location = new System.Drawing.Point(127, 102);
            this.txtConPassDecrypt.Name = "txtConPassDecrypt";
            this.txtConPassDecrypt.PasswordChar = '*';
            this.txtConPassDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtConPassDecrypt.TabIndex = 29;
            this.txtConPassDecrypt.TextChanged += new System.EventHandler(this.txtConPassDecrypt_TextChanged);
            // 
            // txtPassDecrypt
            // 
            this.txtPassDecrypt.Location = new System.Drawing.Point(127, 78);
            this.txtPassDecrypt.Name = "txtPassDecrypt";
            this.txtPassDecrypt.PasswordChar = '*';
            this.txtPassDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtPassDecrypt.TabIndex = 28;
            this.txtPassDecrypt.TextChanged += new System.EventHandler(this.txtPassDecrypt_TextChanged);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(18, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(101, 20);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "File yg di dekripsi:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(6, 102);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(113, 16);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Konfirmasi password:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(31, 78);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(88, 16);
            this.Label8.TabIndex = 25;
            this.Label8.Text = "Ketik password:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // btnBrowseDecrypt
            // 
            this.btnBrowseDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseDecrypt.BackgroundImage")));
            this.btnBrowseDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowseDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDecrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowseDecrypt.Location = new System.Drawing.Point(341, 22);
            this.btnBrowseDecrypt.Name = "btnBrowseDecrypt";
            this.btnBrowseDecrypt.Size = new System.Drawing.Size(57, 58);
            this.btnBrowseDecrypt.TabIndex = 24;
            this.btnBrowseDecrypt.Click += new System.EventHandler(this.btnBrowseDecrypt_Click);
            // 
            // txtFileToDecrypt
            // 
            this.txtFileToDecrypt.Location = new System.Drawing.Point(127, 22);
            this.txtFileToDecrypt.Name = "txtFileToDecrypt";
            this.txtFileToDecrypt.ReadOnly = true;
            this.txtFileToDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtFileToDecrypt.TabIndex = 23;
            this.txtFileToDecrypt.Text = "Klik ikon untuk mencari file.";
            this.txtFileToDecrypt.TextChanged += new System.EventHandler(this.txtFileToDecrypt_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(419, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tentang";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Kontribusi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(136, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Dibuat dan dikembangkan oleh :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(137, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 62);
            this.label10.TabIndex = 29;
            this.label10.Text = "Adinda Amaliyah - Fajar Januriawan - Fery Andriyani - Hapsoro Sanjayatama - Irfan" +
    " Sanjaya - Khairul Azhar - Kurniawan Adhi Kusumajati -  Riswanti Rahmawati Putri" +
    "";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Cryptor 1.0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(136, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "© 2016. STMIK Amikom Yogyakarta";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 160);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cryptor 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTextEncryption.ResumeLayout(false);
            this.tabTextEncryption.PerformLayout();
            this.tabFileEncryption.ResumeLayout(false);
            this.tabFileEncryption.PerformLayout();
            this.tabFileDecryption.ResumeLayout(false);
            this.tabFileDecryption.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFileDecryption;
        private System.Windows.Forms.TabPage tabTextEncryption;
        private System.Windows.Forms.Label lblSecretKey;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.TextBox txtEncrypt;
        internal System.Windows.Forms.TextBox txtDestinationDecrypt;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnFileDecrypt;
        internal System.Windows.Forms.TextBox txtConPassDecrypt;
        internal System.Windows.Forms.TextBox txtPassDecrypt;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnBrowseDecrypt;
        internal System.Windows.Forms.TextBox txtFileToDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabFileEncryption;
        internal System.Windows.Forms.TextBox txtDestinationEncrypt;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnFileEncrypt;
        internal System.Windows.Forms.TextBox txtConPassEncrypt;
        internal System.Windows.Forms.TextBox txtPassEncrypt;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnBrowseEncrypt;
        internal System.Windows.Forms.TextBox txtFileToEncrypt;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label12;
    }
}

