using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_device
{
    public partial class frmdevice : Form
    {
        Manager_deviceEntities db = new Manager_deviceEntities();
        
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
                if (txtId.Text == dev.ID_DEVICE)
                {
                    MessageBox.Show("Mã thiết bị không được trùng!");
                }
                else
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
        private string selectgroupID;
        private void cbbsearch_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbsearch_group.SelectedIndex != -1)
            {
                string str = cbbsearch_group.SelectedValue.ToString();
                str = str.TrimStart('{').TrimEnd('}').Trim(' ').Split('=')[1].Trim(' ');
                var listID = from gr in db.GROUP_DEVICE
                             where (gr.NAME.Equals(str))
                             select new { gr.ID_GROUP, gr.NAME };
                foreach (var item in listID)
                {
                    selectgroupID = item.ID_GROUP.ToString();
                }
                var listdevice = from d in db.DEVICEs
                                 where (d.ID_GROUP.Contains(selectgroupID))
                                 select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP, d.ENABLE, d.USER };
                binds.DataSource = listdevice.ToList();
                dtgvdevice.DataSource = binds;
            }
        }
        struct DataParameter
        {
           public List<DEVICE> listdevice;
            public string FileName { get; set; }
        }
        DataParameter _inputParamater;
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    binds.DataSource = db.DEVICEs.ToList();
                    _inputParamater.listdevice = binds.DataSource as List<DEVICE>;
                    _inputParamater.FileName = sfd.FileName;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker1.RunWorkerAsync(_inputParamater);
                }
            }
            #region xuat file csv khg sd backgroundworker
            //========================================================
            //không sử dụng backgroundwoker
            //using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //{
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        binds.DataSource = db.DEVICEs.ToList();
            //        _inputParamater.listdevice = binds.DataSource as List<DEVICE>;
            //        _inputParamater.FileName = sfd.FileName;
            //        List<DEVICE> list = _inputParamater.listdevice;
            //        string fileName = _inputParamater.FileName;
            //        int index = 1;
            //        int process = list.Count();
            //        using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            //        {
            //            StringBuilder sb = new StringBuilder();
            //            sb.AppendLine("ID_DEVICE,NAME,UPDATETIME,DATEPLAN,ID_GROUP");
            //            foreach (DEVICE d in list)
            //            {
            //                    sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP));
            //            }
            //            sw.Write(sb.ToString());
            //        }
            //    }
            //}
            #endregion 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<DEVICE> list = ((DataParameter)e.Argument).listdevice;
            string fileName = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process = list.Count();
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("ID_DEVICE,NAME,UPDATETIME,DATEPLAN,ID_GROUP");
                foreach (DEVICE d in list)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP));
                    }
                }
                sw.Write(sb.ToString());
            }
        }
       
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
        }
        
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }
    }
}