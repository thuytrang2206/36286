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

        }
    }
}
