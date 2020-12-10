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
    public partial class frmuser : Form
    {
        Manager_deviceEntities db = new Manager_deviceEntities();
        USER user = new USER();
        List<USER> listuser;
        BindingSource binds;
        public frmuser()
        {
            InitializeComponent();
            binds = new BindingSource();
            Load_data();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //frmMain frm = new frmMain();
            this.Hide();
           // frm.ShowDialog();
        }

        private void frmuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_deviceDataSet1.RULE' table. You can move, or remove it, as needed.
            this.rULETableAdapter.Fill(this.manager_deviceDataSet1.RULE);

        }
        void Load_data()
        {
            var listuser = from u in db.USERs select new { u.ID_USER, u.NAME, u.PASSWORD, u.ID_RULE };
            binds.DataSource = listuser.ToList();
            dtgvUser.DataSource = binds;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            user.ID_USER = txtId_user.Text;
            user.NAME = txtName.Text;
            user.PASSWORD = txtPass.Text;
            user.ID_RULE = cbbId_rule.Text;
            db.USERs.Add(user);
            db.SaveChanges();
            Load_data();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtId_user.Enabled = false;
            string Id = dtgvUser.SelectedCells[0].OwningRow.Cells["ID_USER"].Value.ToString();
            user = db.USERs.Find(Id);
            user.NAME = txtName.Text;
            user.PASSWORD = txtPass.Text;
            user.ID_RULE = cbbId_rule.Text;
            db.SaveChanges();
            Load_data();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtId_user.Text;
            user = db.USERs.Where(x => x.ID_RULE == id).SingleOrDefault();
            db.USERs.Remove(user);
            db.SaveChanges();
            Load_data();
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId_user.Enabled = false;
            int selectIndex = e.RowIndex;
            DataGridViewRow row= dtgvUser.Rows[selectIndex];
            txtId_user.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPass.Text = row.Cells[2].Value.ToString();
            cbbId_rule.Text = row.Cells[3].Value.ToString();
        }
       
       
    }
}
