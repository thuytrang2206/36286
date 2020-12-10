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
    public partial class frmMain : Form
    {
        public frmMain(string strname)
        {
            InitializeComponent();
            Form1 frm1 = new Form1();
            frm1.Hide();
            label2.Text = strname;
        }
        
        //public frmMain(string giatri) : this()
        //{
        //    strname = giatri;
        //    label2.Text = strname;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            frmgoupdevice fmg = new frmgoupdevice(label2.Text);
            this.Hide();
            fmg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmdevice frd = new frmdevice(label2.Text);
            this.Hide();
            frd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmuser frmu = new frmuser();
            this.Hide();
            frmu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmrules frmr = new frmrules();
            this.Hide();
            frmr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDetail frmd = new FrmDetail();
            this.Hide();
            frmd.ShowDialog();
        }
    }
}
