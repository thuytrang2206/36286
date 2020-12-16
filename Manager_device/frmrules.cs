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
        USER user = new USER();

        void Check_user()
        {
            string id = txtUser.Text;
            user = db.USERs.Where(x => x.ID_USER == id).FirstOrDefault();
            if (user.ID_RULE == "R002")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDel.Visible = false;
                txtID_r.Visible = false;
                txtName.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }
        public frmrules()
        {
            InitializeComponent();
            Form1 frm = new Form1();
            binds = new BindingSource();
            Load_Data();
        }

        string name;
        public frmrules(string giatri) : this()
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
        void Load_Data()
        {
            var listrule = from d in db.RULEs select new { d.ID_RULE, d.NAME };
            binds.DataSource = listrule.ToList();
            dtgvrule.DataSource = binds;
        }

        private string Matang()
        {
            string ma = "";
            if (dtgvrule.RowCount < 0)
            {
                ma = "R001";
            }
            else
            {
                ma = "R";
                int k = int.Parse(dtgvrule.Rows[dtgvrule.Rows.Count - 1].Cells[0].Value.ToString().Substring(1, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if(k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            rule.ID_RULE = Matang();
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
            //foreach(var user in db.USERs.Where(d => d.ID_RULE == id))
            //{
            //    db.USERs.Remove(user);
            //}
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

        private void frmrules_Load(object sender, EventArgs e)
        {
            Check_user();
        }
    }
}
