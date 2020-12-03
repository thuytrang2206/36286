using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_device
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Manager_deviceEntities db = new Manager_deviceEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(db.USERs.Where(r=>r.ID_USER==txtuser.Text && r.PASSWORD == txtpass.Text).Count()>0)
                { 

                    MessageBox.Show("Login is correct!");
                    frmMain frm = new frmMain();
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
    }
}
