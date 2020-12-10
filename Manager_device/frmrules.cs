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
    public partial class frmrules : Form
    {
        Manager_deviceEntities db = new Manager_deviceEntities();
        List<RULE> listrule;
        BindingSource binds;
        RULE rule = new RULE();

        public frmrules()
        {
            InitializeComponent();
            Form1 frm = new Form1();
            binds = new BindingSource();
            Load_Data();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }
        void Load_Data()
        {
            var listrule = from d in db.RULEs select new { d.ID_RULE, d.NAME };
            binds.DataSource = listrule.ToList();
            dtgvrule.DataSource = binds;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            rule.ID_RULE = txtID_r.Text;
            rule.NAME = txtName.Text;
            db.RULEs.Add(rule);
            db.SaveChanges();
            Load_Data();
        }
        void Clear()
        {
            txtName.Text = "";
            txtID_r.Text = "";
            txtID_r.Enabled = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Id = dtgvrule.SelectedCells[0].OwningRow.Cells["ID_RULE"].Value.ToString();
            rule= db.RULEs.Find(Id);
            rule.ID_RULE = txtID_r.Text;
            rule.NAME = txtName.Text;
            db.SaveChanges();
            Load_Data();
            Clear(); 
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id=txtID_r.Text;
            rule = db.RULEs.First(x => x.ID_RULE == id);
            foreach(var user in db.USERs.Where(d => d.ID_RULE == id))
            {
                db.USERs.Remove(user);
            }
            db.RULEs.Remove(rule);
            db.SaveChanges();
            Load_Data();
            Clear();
        }

        private void dtgvrule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_r.Enabled = false;
            int selectIndex = e.RowIndex;
            DataGridViewRow row = dtgvrule.Rows[selectIndex];
            txtID_r.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();

        }
    }
}
