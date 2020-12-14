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
            var listdetail = from dt in db.HISTORies select new { dt.ID_HISTORY, dt.ID_DEVICE,dt.UPDATE_CHECK,dt.INFOCHECK,dt.NOTE,dt.QUANTITY,dt.STATUS,dt.ID_USER};
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
            var id = Guid.NewGuid().ToString();
            det.ID_HISTORY = id;
            det.ID_DEVICE = cbbId.Text;
            det.UPDATE_CHECK = DateTime.Parse(dtcheck.Value.ToString());
            det.INFOCHECK = cbbinfo.SelectedIndex;
            det.NOTE = txtnote.Text;
            det.QUANTITY = int.Parse(txtquantity.Text);
            det.STATUS = cbbstatus.SelectedIndex;
            det.ID_USER = txtUser.Text;
            db.HISTORies.Add(det);
            db.SaveChanges();
            Load_Data();
           
        }
        private int get_countdevice()
        {
            string id;
            int count = 0;
            id = cbbId.Text;
            if (cbbId.Text == dev.ID_DEVICE)
            {
            } 
            return count;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            cbbId.Text = row.Cells[1].Value.ToString();
            dtcheck.Value =DateTime.Parse(row.Cells[2].Value.ToString());
            if(row.Cells[3].Value.ToString()== "0")
            {
                cbbinfo.Text = TaskTypeInfo.Pass.ToString();
            }
            else
            {
                cbbinfo.Text = TaskTypeInfo.NG.ToString();
            }
            txtnote.Text = row.Cells[4].Value.ToString();
            txtquantity.Text = row.Cells[5].Value.ToString();
           // cbbstatus.Text = row.Cells[6].Value.ToString();
            if (row.Cells[6].Value.ToString() == "0")
            {
                cbbstatus.Text =TaskType.New.ToString();
            }
            else if(row.Cells[6].Value.ToString() == "1")
            {
                cbbstatus.Text = TaskType.Update.ToString();
            }
            else
            {
                cbbstatus.Text = TaskType.Remove.ToString();
            }
          
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(txtUser.Text);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].OwningRow.Cells["ID_HISTORY"].Value.ToString();
            det = db.HISTORies.Find(id);
            det.ID_DEVICE = cbbId.Text; 
            det.UPDATE_CHECK = DateTime.Parse(dtcheck.Value.ToString());
            det.INFOCHECK = cbbinfo.SelectedIndex;
            det.NOTE = txtinfo.Text;
            det.QUANTITY = int.Parse(txtquantity.Text);
            det.STATUS = cbbstatus.SelectedIndex;
            db.SaveChanges();
            Load_Data();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //string id = txtId.Text;
            //det = db.DETAIL_CHECK.Where(d => d.ID_DETAIL == id).SingleOrDefault();
            //db.DETAIL_CHECK.Remove(det);
            //db.SaveChanges();
            //Load_Data();
        }

        private void cbbinfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
