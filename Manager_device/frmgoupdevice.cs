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
    public partial class frmgoupdevice : Form
    {
        Manager_deviceEntities db = new Manager_deviceEntities();
        List<GROUP_DEVICE> listgroup;
        BindingSource binds;
        GROUP_DEVICE gr = new GROUP_DEVICE();
        USER user = new USER();
        public frmgoupdevice()
        {
            InitializeComponent();
            Form1 frm = new Form1();
            binds = new BindingSource();
            frmMain frmm = new frmMain();
            Load1();
        }
        string name;
        public frmgoupdevice(string giatri) : this()
        {
            name = giatri;
            txtUser.Text = name;
        }
        void Check_user()
        {
            string id = txtUser.Text;
            user = db.USERs.Where(x => x.ID_USER == id).FirstOrDefault();
            if (user.ID_RULE == "R002")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDel.Visible = false;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }
        void Load1()
        {
            var listgroup = from g in db.GROUP_DEVICE select new { g.ID_GROUP, g.NAME };
            binds.DataSource = listgroup.ToList();
            dtgvgroup.DataSource = binds;
        }
        void Clear()
        {
            txtID.Text = "";
            txtNAME.Text = "";
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="" || txtNAME.Text=="")
            {
                MessageBox.Show("ID_GROUP AND NAME IS NOT VALUES");

            }
            else
            {
                try
                {
                    gr.ID_GROUP = txtID.Text;
                    gr.NAME = txtNAME.Text;
                    db.GROUP_DEVICE.Add(gr);
                    db.SaveChanges();
                    Load1();
                    MessageBox.Show("ADD DATA IS SUCCESS!");
                    txtID.Clear();
                    txtNAME.Clear();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
            }
            
        }
        void Edit_Data()
        {
            string id = dtgvgroup.SelectedCells[0].OwningRow.Cells["ID_GROUP"].Value.ToString();
            gr = db.GROUP_DEVICE.Find(id);
            gr.ID_GROUP = txtID.Text;
            gr.NAME = txtNAME.Text;
            db.SaveChanges();
            Load1();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Data();
            Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            gr = db.GROUP_DEVICE.First(p => p.ID_GROUP == id) ;
            foreach(var d in db.DEVICEs.Where(f => f.ID_GROUP == id))
            {
                db.DEVICEs.Remove(d);
            }
            db.GROUP_DEVICE.Remove(gr);
            db.SaveChanges();
            Load1();
            Clear();
        }

        private void dtgvgroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Enabled = false;
            int selectIndex = e.RowIndex;
            DataGridViewRow row = dtgvgroup.Rows[selectIndex];
            txtID.Text = row.Cells[0].Value.ToString();
            txtNAME.Text = row.Cells[1].Value.ToString();
        }

        private void frmgoupdevice_Load(object sender, EventArgs e)
        {
            Check_user();
        }
    }
}
