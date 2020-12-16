using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Manager_device
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Manager_deviceEntities db = new Manager_deviceEntities();
        MD5 md5 = MD5.Create();
        private string getMD5(string txt)
        {
            txt = txtpass.Text;
            string str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string password = getMD5(txtpass.Text);
            try
            { 
                if (db.USERs.Where(r=>r.ID_USER==txtuser.Text && r.PASSWORD ==password).Count()>0)
                { 
                    frmMain frm = new frmMain(txtuser.Text);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login is not correct!");
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
      
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
