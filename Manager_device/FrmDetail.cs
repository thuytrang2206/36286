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
    public partial class FrmDetail : Form
    {
        Manager_deviceEntities db = new Manager_deviceEntities();
        List<DETAIL_CHECK> listdetail;
        BindingSource binds;
        DETAIL_CHECK det = new DETAIL_CHECK();
        public FrmDetail()
        {
            InitializeComponent();
            binds = new BindingSource();
            Load_Data();
        }
        string name;
        public FrmDetail(string giatri) : this()
        {
            name = giatri;
            txtUser.Text = name;
        }
        void Load_Data()
        {
            var listdetail = from dt in db.DETAIL_CHECK select new { dt.ID_DETAIL, dt.ID_DEVICE,dt.DATECHECK,dt.INFOCHECK};
            binds.DataSource = listdetail.ToList();
            dataGridView1.DataSource = binds;
        }
        private void FrmDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_deviceDataSet4.DEVICE' table. You can move, or remove it, as needed.
            this.dEVICETableAdapter.Fill(this.manager_deviceDataSet4.DEVICE);

        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            det.ID_DETAIL = txtId.Text;
            det.ID_DEVICE = cbbId.Text;
            det.DATECHECK = DateTime.Parse(dtcheck.Value.ToString());
            det.INFOCHECK = txtinfo.Text;
            db.DETAIL_CHECK.Add(det);
            db.SaveChanges();
            Load_Data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            cbbId.Text = row.Cells[1].Value.ToString();
            dateTimePicker2.Value =DateTime.Parse(row.Cells[2].Value.ToString());
            txtinfo.Text = row.Cells[3].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(txtUser.Text);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].OwningRow.Cells["ID_DETAIL"].Value.ToString();
            det = db.DETAIL_CHECK.Find(id);
            det.ID_DETAIL = txtId.Text;
            det.ID_DEVICE = cbbId.Text;
            det.DATECHECK= DateTime.Parse(dateTimePicker2.Value.ToString());
            det.INFOCHECK = txtinfo.Text;
            db.SaveChanges();
            Load_Data();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            det = db.DETAIL_CHECK.Where(d => d.ID_DETAIL == id).SingleOrDefault();
            db.DETAIL_CHECK.Remove(det);
            db.SaveChanges();
            Load_Data();
        }
    }
}
