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
    public partial class frmdevice : Form
    {
        Manager_deviceEntities db = new Manager_deviceEntities();
        List<DEVICE> listdevice;
        BindingSource binds;
        DEVICE dev = new DEVICE();
        public frmdevice()
        {
            InitializeComponent();
            binds = new BindingSource();
            Form1 frm = new Form1();
            Load_Data();
        }
        string strname;
        public frmdevice(string giatri) : this()
        {
            strname = giatri;
            txtUser.Text = strname;
        }
       void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            cbbENABLE.Text = "";
            cbbID_GROUP.Text = "";
        }
        void Load_Data()
        {
            var listdevice = from d in db.DEVICEs select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP, d.ENABLE, d.ID_USER };
            binds.DataSource = listdevice.ToList();
            //var temp = listdevice.ToList();
            dtgvdevice.DataSource = binds;
        }
  
        private void frmdevice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_deviceDataSet2.GROUP_DEVICE' table. You can move, or remove it, as needed.
            this.gROUP_DEVICETableAdapter1.Fill(this.manager_deviceDataSet2.GROUP_DEVICE);
            // TODO: This line of code loads data into the 'manager_deviceDataSet.GROUP_DEVICE' table. You can move, or remove it, as needed.
            this.gROUP_DEVICETableAdapter.Fill(this.manager_deviceDataSet.GROUP_DEVICE);
            cbbsearch_group.DataSource = (from g in db.GROUP_DEVICE select new { g.NAME }).ToList();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dev.ID_DEVICE = txtId.Text;
                dev.NAME = txtName.Text;
                dev.UPDATETIME = DateTime.Now;
                dev.DATEPLAN = DateTime.Parse(dateTimePicker2.Value.ToString());
                dev.ID_GROUP = cbbID_GROUP.Text;
                dev.ENABLE = bool.Parse(cbbENABLE.Text);
                dev.ID_USER = txtUser.Text;
                db.DEVICEs.Add(dev);
                db.SaveChanges();
                Load_Data();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        void Edit()
        {
            string id = dtgvdevice.SelectedCells[0].OwningRow.Cells["ID_DEVICE"].Value.ToString();
            dev = db.DEVICEs.Find(id);
            dev.NAME = txtName.Text;
            dev.DATEPLAN = DateTime.Parse(dateTimePicker2.Value.ToString());
            dev.ID_GROUP = cbbID_GROUP.Text;
            dev.ENABLE = bool.Parse(cbbENABLE.Text);
            db.SaveChanges();
            Load_Data();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            Clear();
        }
        private void dtgvdevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = false;
            int selecIndex = e.RowIndex;
            DataGridViewRow row = dtgvdevice.Rows[selecIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            dateTimePicker2.Value =DateTime.Parse(row.Cells[3].Value.ToString());
            cbbID_GROUP.Text = row.Cells[4].Value.ToString();
            cbbENABLE.Text = row.Cells[5].Value.ToString();
            txtUser.Text = row.Cells[6].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            dev = db.DEVICEs.Where(d => d.ID_DEVICE == id).SingleOrDefault();
            db.DEVICEs.Remove(dev);
            db.SaveChanges();
            Load_Data();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           var listdevice= from d in db.DEVICEs where(d.NAME.Contains(txtSearch.Text) )
                           select  new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP, d.ENABLE, d.USER };
            binds.DataSource = listdevice.ToList();
            dtgvdevice.DataSource = binds;
        }

        private void cbbsearch_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var listdevice = from d in db.GROUP_DEVICE
            //                 join g in db.DEVICEs on d.ID_GROUP equals g.ID_GROUP
            //                 where (g.ID_GROUP == cbbsearch_group.SelectedIndex.ToString())
            //                 select new { g.ID_DEVICE, g.NAME, g.UPDATETIME, g.DATEPLAN, g.ID_GROUP, g.ENABLE, g.USER };
            //binds.DataSource = listdevice.ToList();
            dtgvdevice.DataSource = binds;
        }
    }
}