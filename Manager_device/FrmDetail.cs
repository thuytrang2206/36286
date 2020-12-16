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
        List<HISTORY> listdetail;
        BindingSource binds;
        HISTORY det = new HISTORY();
        DEVICE dev = new DEVICE();

        public FrmDetail()
        {
            InitializeComponent();
            binds = new BindingSource();
            Load_Data();
            frmdevice frmdevice = new frmdevice();

            cbbstatus.DataSource = Enum.GetValues(typeof(TaskType));
            cbbinfo.DataSource = Enum.GetValues(typeof(TaskTypeInfo));
        }
        string name;
        public FrmDetail(string giatri) : this()
        {
            name = giatri;
            txtUser.Text = name;
        }

        void Load_Data()
        {
            var listdetail = from dt in db.HISTORies select new { dt.ID_HISTORY, dt.ID_DEVICE, dt.UPDATE_CHECK, dt.INFOCHECK, dt.NOTE, dt.QUANTITY, dt.STATUS, dt.ID_USER };
            binds.DataSource = listdetail.ToList();
            dataGridView1.DataSource = binds;
        }
        private void FrmDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_deviceDataSet4.DEVICE' table. You can move, or remove it, as needed.
            this.dEVICETableAdapter.Fill(this.manager_deviceDataSet4.DEVICE);

        }
        void Clear()
        {
            txtId.Text = "";
            txtnote.Text = "";
            txtquantity.Text = "";
            cbbinfo.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var id = Guid.NewGuid().ToString();
            //det.ID_HISTORY = id;
            //det.ID_DEVICE = cbbId.Text;
            //det.UPDATE_CHECK = DateTime.Parse(dtcheck.Value.ToString());
            //det.INFOCHECK = cbbinfo.SelectedIndex;
            //det.NOTE = txtnote.Text;
            //det.QUANTITY = int.Parse(txtquantity.Text);
            //det.STATUS = cbbstatus.SelectedIndex;
            //det.ID_USER = txtUser.Text;
            //db.HISTORies.Add(det);
            //db.SaveChanges();
            //Load_Data();
            //try
            //{
            //    foreach (var d in db.DEVICEs.Where(f => f.ID_DEVICE == det.ID_DEVICE))
            //    {
            //        int count = d.QUANTITY.Value - det.QUANTITY.Value;
            //        int s = count;
            //        dev = db.DEVICEs.Find(d.ID_DEVICE);
            //        dev.QUANTITY = s;
            //    }
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.Write(ex.ToString());
            //}

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtId.Enabled = false;
            //int selectIndex = e.RowIndex;
            //DataGridViewRow row = dataGridView1.Rows[selectIndex];
            //txtId.Text = row.Cells[0].Value.ToString();
            //cbbId.Text = row.Cells[1].Value.ToString();
            //dtcheck.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            //if (row.Cells[3].Value.ToString() == "0")
            //{
            //    cbbinfo.Text = TaskTypeInfo.Pass.ToString();
            //}
            //else
            //{
            //    cbbinfo.Text = TaskTypeInfo.NG.ToString();
            //}
            //txtnote.Text = row.Cells[4].Value.ToString();
            //txtquantity.Text = row.Cells[5].Value.ToString();
            //// cbbstatus.Text = row.Cells[6].Value.ToString();
            //if (row.Cells[6].Value.ToString() == "0")
            //{
            //    cbbstatus.Text = TaskType.New.ToString();
            //}
            //else if (row.Cells[6].Value.ToString() == "1")
            //{
            //    cbbstatus.Text = TaskType.Update.ToString();
            //}
            //else
            //{
            //    cbbstatus.Text = TaskType.Remove.ToString();
            //}

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //frmMain frm = new frmMain(txtUser.Text);
            //this.Hide();
            //frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //string id = dataGridView1.SelectedCells[0].OwningRow.Cells["ID_HISTORY"].Value.ToString();
            //det = db.HISTORies.Find(id);
            //det.ID_DEVICE = cbbId.Text;
            //det.UPDATE_CHECK = DateTime.Parse(dtcheck.Value.ToString("MM-dd-yyyy"));
            //det.INFOCHECK = cbbinfo.SelectedIndex;
            //det.NOTE = txtnote.Text;
            //det.QUANTITY = int.Parse(txtquantity.Text);
            //det.STATUS = cbbstatus.SelectedIndex;
            //db.SaveChanges();
            //Load_Data();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //string id = txtId.Text;
            //det = db.HISTORies.Where(d => d.ID_HISTORY == id).SingleOrDefault();
            //db.HISTORies.Remove(det);
            //db.SaveChanges();
            //Load_Data();
            //Clear();
        }

        private void cbbinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void LoadData_txtSearch(string txtSearch = "")
        {
            //var list = from d in db.HISTORies where (d.ID_DEVICE.Contains(txtSearch)) select new { d.ID_HISTORY, d.ID_DEVICE, d.UPDATE_CHECK, d.INFOCHECK, d.NOTE, d.QUANTITY, d.STATUS, d.ID_USER };
            //binds.DataSource = list.ToList();
            //dataGridView1.DataSource = binds;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //LoadData_txtSearch(txtSearch.Text.Trim());
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime date = dateTimePicker1.Value.Date;
            //var list_date = from d in db.HISTORies where (date == d.UPDATE_CHECK) select new { d.ID_HISTORY, d.ID_DEVICE, d.UPDATE_CHECK, d.INFOCHECK, d.NOTE, d.QUANTITY, d.STATUS, d.ID_USER };
            //binds.DataSource = list_date.ToList();
            //dataGridView1.DataSource = binds;
        }
    }
}
