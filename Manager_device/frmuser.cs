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
    public partial class frmuser : Form
    {
        Manager_deviceEntities db = new Manager_deviceEntities();
        USER user = new USER();
        List<USER> listuser;
        BindingSource binds;
        MD5 md5 = MD5.Create();
        List<RULE> listrule;
        public frmuser()
        {
            InitializeComponent();
            binds = new BindingSource();
            Load_data();
            
            try
            {
                listrule = db.RULEs.ToList();

                foreach (var name_rule in listrule)
                {
                    cbbId_rule.Items.Add(name_rule.NAME);
                }
            }
            catch (Exception)
            {
            }
        }
        string name;
        public frmuser(string giatri) : this()
        {
            name = giatri;
            txtUser.Text = name;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(txtUser.Text);
            this.Hide();
            frm.ShowDialog();
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
                txtId_user.Visible = false;
                txtName.Visible = false;
                txtPass.Visible = false;
                cbbId_rule.Visible = false;
                txtUser.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
               
            }
        }
        private void frmuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_deviceDataSet1.RULE' table. You can move, or remove it, as needed.
            //  this.rULETableAdapter.Fill(this.manager_deviceDataSet1.RULE);
            Check_user();

        }
        void Load_data()
        {
            var listuser = from u in db.USERs select new { u.ID_USER, u.NAME, u.PASSWORD, u.ID_RULE };
            binds.DataSource = listuser.ToList();
            dtgvUser.DataSource = binds;
        }
        private string getMD5(string txt)
        {
            txt = txtPass.Text;
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

        private string Matang()
        {
            string ma = "";
            if (dtgvUser.RowCount < 0)
            {
                user.ID_USER = "U00001";
            }
            else
            {
                ma = "U";
                int k = int.Parse(dtgvUser.Rows[dtgvUser.Rows.Count - 1].Cells[0].Value.ToString().Substring(1, 5));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0000";
                }
                else if (k < 100)
                {
                    ma = ma + "000";
                }
                else if (k < 1000)
                {
                    ma = ma + "00";
                }
                else if (k < 10000)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId_user.Enabled = false;
            user.ID_USER = Matang();
            user.NAME = txtName.Text;
            user.PASSWORD = getMD5(txtPass.Text);
            user.ID_RULE =listrule[cbbId_rule.SelectedIndex].ID_RULE;
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
            user = db.USERs.Where(u => u.ID_USER == id).First();
            db.USERs.Remove(user);
            db.SaveChanges();
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
