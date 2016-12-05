using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestEncryptDecrypt
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {                
                EncryptDecrypt.MyEncryptor enc = new EncryptDecrypt.MyEncryptor(txtPhrase.Text.Trim());
                txtDecrypt.Text = enc.Encrypt(txtEncrypt.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptDecrypt.MyEncryptor enc = new EncryptDecrypt.MyEncryptor(txtPhrase.Text.Trim());
                txtEncrypt.Text = enc.Decrypt(txtDecrypt.Text.Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            //Setup the open dialog.
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Pilih file yang akan di dekripsi";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Encrypted Files (*.encrypt) | *.encrypt";

            string strFileToDecrypt = "";            
            string strOutputDecrypt = "";

            //Find out if the user chose a file.
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileToDecrypt = openFileDialog1.FileName;               
                txtFileToDecrypt.Text = strFileToDecrypt;
                int iPosition;                
                /* Get the position of the last "\" in the OpenFileDialog.FileName path.
                * -1 is when the character your searching for is not there.
                * IndexOf searches from left to right.*/
                iPosition = strFileToDecrypt.LastIndexOf(".encrypt");
                if((iPosition == -1) || (iPosition != (strFileToDecrypt.Length-8)))
                {
                    MessageBox.Show("File salah. Tolomg pilih file enkripsi yang benar.");
                }

                //strOutputFile = the file path minus the last 8 characters (.encrypt)
                strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8);                       
                //Assign strOutputFile to the position after the last "\" in the path.
                iPosition = strOutputDecrypt.IndexOf("z_z");
                if (iPosition == -1)
                {
                    strOutputDecrypt = strOutputDecrypt + ".dat";
                }
                else
                {
                    strOutputDecrypt = strOutputDecrypt.Replace("z_z", ".");
                }
                txtDestinationDecrypt.Text = strOutputDecrypt;
                //Update buttons
                btnFileDecrypt.Enabled = true;            

            }
        }

        private void btnBrowseEncrypt_Click(object sender, EventArgs e)
        {
            //Setup the open dialog.
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Pilih file yang akan di enkripsi";
            openFileDialog1.InitialDirectory = @"C:\";
           // openFileDialog1.Filter = "Encrypted Files (*.encrypt) | *.encrypt";

            string strFileToEncrypt = "";
            string strOutputEncrypt = "";
            string strExtension = "";

            //Find out if the user chose a file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileToEncrypt = openFileDialog1.FileName;
                txtFileToEncrypt.Text = strFileToEncrypt;
                int iPosition;               
                /* Get the position of the last "\" in the OpenFileDialog.FileName path.
                * -1 is when the character your searching for is not there.
                * IndexOf searches from left to right.*/
                iPosition = strFileToEncrypt.LastIndexOf(".");
                if (iPosition == -1)
                {
                    MessageBox.Show("File salah. Tolong pilih file yang benar.");
                }

                //strOutputFile = the file path minus the last 8 characters (.encrypt)
                strExtension = strFileToEncrypt.Substring(iPosition, (strFileToEncrypt.Length - iPosition));
                //Assign strOutputFile to the position after the last "\" in the path.  
                string strEncryptedExt = "z_z" + strExtension.Substring(1) + ".encrypt";         
                strOutputEncrypt = strFileToEncrypt.Replace(strExtension, strEncryptedExt);

                txtDestinationEncrypt.Text = strOutputEncrypt;
                //Update buttons
                btnFileEncrypt.Enabled = true;
            }
        }

        private void btnFileDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConPassDecrypt.Text != txtPassDecrypt.Text)
                {
                    txtConPassDecrypt.Text = "";
                    MessageBox.Show("Password tidak sesuai. Tolong coba lagi.");
                    return;
                }
                string strSecretKey = txtPassDecrypt.Text.Trim();
                EncryptDecrypt.MyEncryptor enc = new EncryptDecrypt.MyEncryptor(strSecretKey);
                enc.Decrypt(txtFileToDecrypt.Text, txtDestinationDecrypt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConPassEncrypt.Text != txtPassEncrypt.Text)
                {
                    txtConPassEncrypt.Text = "";
                    MessageBox.Show("Password tidak sesuai. Tolong coba lagi.");
                    return;
                }
                string strSecretKey = txtPassEncrypt.Text.Trim();
                EncryptDecrypt.MyEncryptor enc = new EncryptDecrypt.MyEncryptor(strSecretKey);
                enc.Encrypt(txtFileToEncrypt.Text, txtDestinationEncrypt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConPassDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFileToDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDestinationDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabFileDecryption_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEncrypted_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }
    }
}