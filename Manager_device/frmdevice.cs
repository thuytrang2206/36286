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
        USER user = new USER();
        
        private List<GROUP_DEVICE> listGroupDevices1;
        public frmdevice()
        {
            InitializeComponent();
            binds = new BindingSource();
            // frmMain frmm = new frmMain();
            try
            {
                listGroupDevices1 = db.GROUP_DEVICE.ToList();

                foreach (var groupDevice in listGroupDevices1)
                {
                    cbbID_GROUP.Items.Add(groupDevice.NAME);
                }
            }
            catch (Exception)
            {
            }
        }
        string name;
        public frmdevice(string giatri) : this()
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
                txtId.Visible = false;
                txtName.Visible = false;
                txtUser.Visible = false;
                cbbENABLE.Visible = false;
                cbbID_GROUP.Visible = false;
                dateTimePicker2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
        }
        void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            cbbENABLE.Text = "";
            cbbID_GROUP.Text = "";
        }
        void Load_Data1()
        {
            var listd = from d in db.DEVICEs select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN,d.QUANTITY, d.ID_GROUP, d.ID_USER };
            binds.DataSource = listd.ToList();
            dtgvdevice.DataSource = binds;
        }
        void Load_Data(string textSearch = "")
        {
            var listd = from d in db.DEVICEs where ( d.NAME.Contains(textSearch)) select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN,d.QUANTITY, d.ID_GROUP, d.ID_USER };
            
            binds.DataSource = listd.ToList();
            dtgvdevice.DataSource = binds;
        }
        void Load_DataByGroupId(string groupID)
        {
            var listd = from d in db.DEVICEs where (d.ID_GROUP.Contains(groupID)) select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN,d.QUANTITY, d.ID_GROUP, d.ID_USER };
            binds.DataSource = listd.ToList();
            dtgvdevice.DataSource = binds;
        }
        private bool Check_data()
        {
            bool ok = false;
            
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox tx = ctrl as TextBox;
                    if (string.IsNullOrEmpty(tx.Text))
                    {
                        ok = false;
                        
                    }
                   
                }
            }
            return ok;
        }

        private void frmdevice_Load(object sender, EventArgs e)
        {
            //this.gROUP_DEVICETableAdapter.Fill(this.manager_deviceDataSet.GROUP_DEVICE);
          
            try
            {
                listGroupDevices = db.GROUP_DEVICE.ToList();

                foreach (var groupDevice in listGroupDevices)
                {
                    cbbsearch_group.Items.Add(groupDevice.NAME);
                }
                cbbsearch_group.SelectedIndex = 0;

            }
            catch (Exception)
            {
            }
            Check_user();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           frmMain frm = new frmMain(txtUser.Text);
            this.Hide();
            frm.ShowDialog();
        }

        //private string Matang()
        //{
        //    string ma = "";

        //    if (dtgvdevice.Rows.Count < 0)
        //    {
        //        dev.ID_DEVICE = "DE0001";
        //    }
        //    else
        //    {
        //        ma = "DE";
        //        int k = int.Parse(dtgvdevice.Rows[dtgvdevice.Rows.Count-1].Cells[0].Value.ToString().Substring(2,3));
        //        k = k + 1;
        //        if (k < 10)
        //        {
        //            ma = ma + "00";
        //        }
        //        else if (k < 100)
        //        {
        //            ma = ma + "0";
        //        }
        //        ma = ma + k.ToString();
        //    }
        //    return ma;
        //}
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
                    if(Check_data()== true)
                    {
                        MessageBox.Show("Dữ liệu không được để trống");
                    }
                    else

                    {
                        var id = Guid.NewGuid().ToString(); ;

                        dev.ID_DEVICE = id;
                        dev.NAME = txtName.Text;
                        dev.UPDATETIME = DateTime.Now;
                        dev.DATEPLAN = DateTime.Parse(dateTimePicker2.Value.ToString());
                        dev.QUANTITY = int.Parse(txtquantity.Text);
                        dev.ID_GROUP = listGroupDevices1[cbbID_GROUP.SelectedIndex].ID_GROUP;
                        dev.ENABLE = bool.Parse(cbbENABLE.Text);
                        dev.ID_USER = txtUser.Text;
                        db.DEVICEs.Add(dev);
                        db.SaveChanges();
                        Load_Data1();
                        Clear();
                    }
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
            dev.ID_GROUP = listGroupDevices1[cbbID_GROUP.SelectedIndex].ID_GROUP;
            //dev.ENABLE = bool.Parse(cbbENABLE.Text);
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
            dateTimePicker2.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            cbbID_GROUP.Text = row.Cells[4].Value.ToString();
            txtUser.Text = row.Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            dev = db.DEVICEs.Where(d => d.ID_DEVICE == id).SingleOrDefault();
            if (dev.ENABLE == true)
            {
                db.DEVICEs.Remove(dev);
                db.SaveChanges();
                Load_Data();
            }
            else
            {
                MessageBox.Show("Not delete value!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_Data(txtSearch.Text.Trim());
        }
        private string selectgroupID;
        private List<GROUP_DEVICE> listGroupDevices;
        private void cbbsearch_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbsearch_group.SelectedIndex != -1)
                {
                    selectgroupID = listGroupDevices[cbbsearch_group.SelectedIndex].ID_GROUP;
                    Load_DataByGroupId(selectgroupID);
                }
            }
            catch (Exception)
            {
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
                sb.AppendLine("ID_DEVICE,NAME,UPDATETIME,DATEPLAN,ID_GROUP,ID_USER");
                foreach (DEVICE d in list)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5}", d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP, d.ID_USER));
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
        





        //=================

        //Manager_deviceEntities db = new Manager_deviceEntities();

        //BindingSource binds;
        //DEVICE dev = new DEVICE();
        //public frmdevice()
        //{
        //    InitializeComponent();
        //    binds = new BindingSource();
        //    frmMain frmm = new frmMain();
        //    Load_Data();
        //}
        //string name;
        //public frmdevice(string giatri) : this()
        //{
        //    name = giatri;
        //    txtUser.Text = name;
        //}
        //void Clear()
        //{
        //    txtId.Text = "";
        //    txtName.Text = "";
        //    cbbENABLE.Text = "";
        //    cbbID_GROUP.Text = "";
        //}
        //void Load_Data()
        //{
        //    var listd = from d in db.DEVICEs  select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP, d.ID_USER };
        //    binds.DataSource = listd.ToList();
        //    dtgvdevice.DataSource = binds; 
        //}

        //private void frmdevice_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'manager_deviceDataSet2.GROUP_DEVICE' table. You can move, or remove it, as needed.
        //    this.gROUP_DEVICETableAdapter1.Fill(this.manager_deviceDataSet2.GROUP_DEVICE);
        //    // TODO: This line of code loads data into the 'manager_deviceDataSet.GROUP_DEVICE' table. You can move, or remove it, as needed.
        //    this.gROUP_DEVICETableAdapter.Fill(this.manager_deviceDataSet.GROUP_DEVICE);
        //    cbbsearch_group.DataSource = (from g in db.GROUP_DEVICE select new { g.NAME }).ToList();

        //}

        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    frmMain frm = new frmMain();
        //    this.Hide();
        //    frm.ShowDialog();
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtId.Text == dev.ID_DEVICE)
        //        {
        //            MessageBox.Show("Mã thiết bị không được trùng!");
        //        }
        //        else
        //        {
        //            dev.ID_DEVICE = txtId.Text;
        //            dev.NAME = txtName.Text;
        //            dev.UPDATETIME = DateTime.Now;
        //            dev.DATEPLAN = DateTime.Parse(dateTimePicker2.Value.ToString());
        //            dev.ID_GROUP = cbbID_GROUP.Text;
        //            dev.ENABLE = bool.Parse(cbbENABLE.Text);
        //            dev.ID_USER = txtUser.Text;
        //            db.DEVICEs.Add(dev);
        //            db.SaveChanges();
        //            Load_Data();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex.ToString());
        //    }
        //}

        //void Edit()
        //{
        //    string id = dtgvdevice.SelectedCells[0].OwningRow.Cells["ID_DEVICE"].Value.ToString();
        //    dev = db.DEVICEs.Find(id);
        //    dev.NAME = txtName.Text;
        //    dev.DATEPLAN = DateTime.Parse(dateTimePicker2.Value.ToString());
        //    dev.ID_GROUP = cbbID_GROUP.Text;
        //    dev.ENABLE = bool.Parse(cbbENABLE.Text);
        //    db.SaveChanges();
        //    Load_Data();

        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    Edit();
        //    Clear();
        //}
        //private void dtgvdevice_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtId.Enabled = false;
        //    int selecIndex = e.RowIndex;
        //    DataGridViewRow row = dtgvdevice.Rows[selecIndex];
        //    txtId.Text = row.Cells[0].Value.ToString();
        //    txtName.Text = row.Cells[1].Value.ToString();
        //    dateTimePicker2.Value = DateTime.Parse(row.Cells[3].Value.ToString());
        //    cbbID_GROUP.Text = row.Cells[4].Value.ToString();
        //   // cbbENABLE.Text = row.Cells[5].Value.ToString();
        //    txtUser.Text = row.Cells[5].Value.ToString();
        //}

        //private void btnDel_Click(object sender, EventArgs e)
        //{
        //    string id = txtId.Text;
        //    dev = db.DEVICEs.Where(d => d.ID_DEVICE == id).SingleOrDefault();
        //    if (dev.ENABLE == true) {
        //        db.DEVICEs.Remove(dev);
        //        db.SaveChanges();
        //        Load_Data();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Not delete value!");
        //    }
        //}

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    var listdevice = from d in db.DEVICEs
        //                     where (d.NAME.Contains(txtSearch.Text))
        //                     select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP, d.ID_USER };
        //    binds.DataSource = listdevice.ToList();
        //    dtgvdevice.DataSource = binds;
        //}
        //private string selectgroupID;
        //private void cbbsearch_group_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbbsearch_group.SelectedIndex != -1)
        //    {
        //        string str = cbbsearch_group.SelectedValue.ToString();
        //        str = str.TrimStart('{').TrimEnd('}').Trim(' ').Split('=')[1].Trim(' ');
        //        var listID = from gr in db.GROUP_DEVICE
        //                     where (gr.NAME.Equals(str))
        //                     select new { gr.ID_GROUP, gr.NAME };
        //        foreach (var item in listID)
        //        {
        //            selectgroupID = item.ID_GROUP.ToString();
        //        }
        //        var listdevice = from d in db.DEVICEs
        //                         where (d.ID_GROUP.Contains(selectgroupID))
        //                         select new { d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP, d.ID_USER };
        //        binds.DataSource = listdevice.ToList();
        //        dtgvdevice.DataSource = binds;
        //    }
        //}
        //struct DataParameter
        //{
        //    public List<DEVICE> listdevice;
        //    public string FileName { get; set; }
        //}
        //DataParameter _inputParamater;
        //private void btnExport_Click(object sender, EventArgs e)
        //{
        //    if (backgroundWorker1.IsBusy)
        //        return;
        //    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
        //    {
        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {
        //            binds.DataSource = db.DEVICEs.ToList();
        //            _inputParamater.listdevice = binds.DataSource as List<DEVICE>;
        //            _inputParamater.FileName = sfd.FileName;
        //            progressBar.Minimum = 0;
        //            progressBar.Value = 0;
        //            backgroundWorker1.RunWorkerAsync(_inputParamater);
        //        }
        //    }
        //    #region xuat file csv khg sd backgroundworker
        //    //========================================================
        //    //không sử dụng backgroundwoker
        //    //using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
        //    //{
        //    //    if (sfd.ShowDialog() == DialogResult.OK)
        //    //    {
        //    //        binds.DataSource = db.DEVICEs.ToList();
        //    //        _inputParamater.listdevice = binds.DataSource as List<DEVICE>;
        //    //        _inputParamater.FileName = sfd.FileName;
        //    //        List<DEVICE> list = _inputParamater.listdevice;
        //    //        string fileName = _inputParamater.FileName;
        //    //        int index = 1;
        //    //        int process = list.Count();
        //    //        using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
        //    //        {
        //    //            StringBuilder sb = new StringBuilder();
        //    //            sb.AppendLine("ID_DEVICE,NAME,UPDATETIME,DATEPLAN,ID_GROUP");
        //    //            foreach (DEVICE d in list)
        //    //            {
        //    //                    sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP));
        //    //            }
        //    //            sw.Write(sb.ToString());
        //    //        }
        //    //    }
        //    //}
        //    #endregion 
        //}

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    List<DEVICE> list = ((DataParameter)e.Argument).listdevice;
        //    string fileName = ((DataParameter)e.Argument).FileName;
        //    int index = 1;
        //    int process = list.Count();
        //    using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        sb.AppendLine("ID_DEVICE,NAME,UPDATETIME,DATEPLAN,ID_GROUP,ID_USER");
        //        foreach (DEVICE d in list)
        //        {
        //            if (!backgroundWorker1.CancellationPending)
        //            {
        //                backgroundWorker1.ReportProgress(index++ * 100 / process);
        //                sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5}", d.ID_DEVICE, d.NAME, d.UPDATETIME, d.DATEPLAN, d.ID_GROUP,d.ID_USER));
        //            }
        //        }
        //        sw.Write(sb.ToString());
        //    }
        //}

        //private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    Thread.Sleep(100);
        //}

        //private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    progressBar.Value = e.ProgressPercentage;
        //    progressBar.Update();
        //}
    }
}