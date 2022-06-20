using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionApp
{
    public partial class frmEcryptapp : Form
    {
        public frmEcryptapp()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //Default settings
            rtbOutput.Text = "";// Make sure that the output box is empty

            foreach (char c in rtbInput.Text)
            {
                char encrypt = (char)(c + nudKey.Value); //Takes each character inputed it and moves it up by the value the user enters in order to encrypt it 
                rtbOutput.Text += encrypt.ToString();
            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //Default settings
          //  rtbInput.Text = "";

            foreach (char c in rtbOutput.Text)
            {
                char encrypt = (char)(c - nudKey.Value);//Reverse the previous loop 
                rtbInput.Text += encrypt.ToString();
            }
        }
    private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //end application
        }
    }
}
