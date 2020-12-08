namespace Manager_device
{
    partial class frmdevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtgvdevice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbbENABLE = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbbID_GROUP = new System.Windows.Forms.ComboBox();
            this.gROUPDEVICEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.manager_deviceDataSet = new Manager_device.Manager_deviceDataSet();
            this.gROUP_DEVICETableAdapter = new Manager_device.Manager_deviceDataSetTableAdapters.GROUP_DEVICETableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.manager_deviceDataSet2 = new Manager_device.Manager_deviceDataSet2();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gROUP_DEVICETableAdapter1 = new Manager_device.Manager_deviceDataSet2TableAdapters.GROUP_DEVICETableAdapter();
            this.manager_deviceDataSet3 = new Manager_device.Manager_deviceDataSet3();
            this.cbbsearch_group = new System.Windows.Forms.ComboBox();
            this.gROUPDEVICEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.gROUPDEVICEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gROUPDEVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtgvdevice
            // 
            this.dtgvdevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdevice.Location = new System.Drawing.Point(12, 12);
            this.dtgvdevice.Name = "dtgvdevice";
            this.dtgvdevice.Size = new System.Drawing.Size(622, 208);
            this.dtgvdevice.TabIndex = 1;
            this.dtgvdevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdevice_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID_DEVICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DATEPLAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID_GROUP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ENABLE";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(757, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // cbbENABLE
            // 
            this.cbbENABLE.FormattingEnabled = true;
            this.cbbENABLE.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbbENABLE.Location = new System.Drawing.Point(757, 161);
            this.cbbENABLE.Name = "cbbENABLE";
            this.cbbENABLE.Size = new System.Drawing.Size(121, 21);
            this.cbbENABLE.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(755, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(757, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            // 
            // cbbID_GROUP
            // 
            this.cbbID_GROUP.DataSource = this.gROUPDEVICEBindingSource3;
            this.cbbID_GROUP.DisplayMember = "ID_GROUP";
            this.cbbID_GROUP.FormattingEnabled = true;
            this.cbbID_GROUP.Location = new System.Drawing.Point(755, 134);
            this.cbbID_GROUP.Name = "cbbID_GROUP";
            this.cbbID_GROUP.Size = new System.Drawing.Size(121, 21);
            this.cbbID_GROUP.TabIndex = 14;
            // 
            // gROUPDEVICEBindingSource3
            // 
            this.gROUPDEVICEBindingSource3.DataMember = "GROUP_DEVICE";
            this.gROUPDEVICEBindingSource3.DataSource = this.manager_deviceDataSet;
            // 
            // manager_deviceDataSet
            // 
            this.manager_deviceDataSet.DataSetName = "Manager_deviceDataSet";
            this.manager_deviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gROUP_DEVICETableAdapter
            // 
            this.gROUP_DEVICETableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(259, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(178, 264);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(87, 264);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // manager_deviceDataSet2
            // 
            this.manager_deviceDataSet2.DataSetName = "Manager_deviceDataSet2";
            this.manager_deviceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(190, 229);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search";
            // 
            // gROUP_DEVICETableAdapter1
            // 
            this.gROUP_DEVICETableAdapter1.ClearBeforeFill = true;
            // 
            // manager_deviceDataSet3
            // 
            this.manager_deviceDataSet3.DataSetName = "Manager_deviceDataSet3";
            this.manager_deviceDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbsearch_group
            // 
            this.cbbsearch_group.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gROUPDEVICEBindingSource2, "ID_GROUP", true));
            this.cbbsearch_group.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.gROUPDEVICEBindingSource2, "NAME", true));
            this.cbbsearch_group.DataSource = this.gROUPDEVICEBindingSource2;
            this.cbbsearch_group.DisplayMember = "ID_GROUP";
            this.cbbsearch_group.FormattingEnabled = true;
            this.cbbsearch_group.Location = new System.Drawing.Point(12, 227);
            this.cbbsearch_group.Name = "cbbsearch_group";
            this.cbbsearch_group.Size = new System.Drawing.Size(121, 21);
            this.cbbsearch_group.TabIndex = 23;
            this.cbbsearch_group.ValueMember = "ID_GROUP";
            this.cbbsearch_group.SelectedIndexChanged += new System.EventHandler(this.cbbsearch_group_SelectedIndexChanged);
            // 
            // gROUPDEVICEBindingSource2
            // 
            this.gROUPDEVICEBindingSource2.DataSource = typeof(Manager_device.GROUP_DEVICE);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(764, 195);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "USER";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(398, 264);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 26;
            this.btnExport.Text = "Xuất file";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gROUPDEVICEBindingSource1
            // 
            this.gROUPDEVICEBindingSource1.DataSource = typeof(Manager_device.GROUP_DEVICE);
            // 
            // gROUPDEVICEBindingSource
            // 
            this.gROUPDEVICEBindingSource.DataSource = typeof(Manager_device.GROUP_DEVICE);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(514, 264);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(395, 23);
            this.progressBar.TabIndex = 27;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmdevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 303);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cbbsearch_group);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbID_GROUP);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.cbbENABLE);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvdevice);
            this.Controls.Add(this.btnExit);
            this.Name = "frmdevice";
            this.Text = "frmdevice";
            this.Load += new System.EventHandler(this.frmdevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPDEVICEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dtgvdevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbbENABLE;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbbID_GROUP;
        private Manager_deviceDataSet manager_deviceDataSet;
        private System.Windows.Forms.BindingSource gROUPDEVICEBindingSource3;
        private Manager_deviceDataSetTableAdapters.GROUP_DEVICETableAdapter gROUP_DEVICETableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private Manager_deviceDataSet2 manager_deviceDataSet2;
        private Manager_deviceDataSet2TableAdapters.GROUP_DEVICETableAdapter gROUP_DEVICETableAdapter1;
        private System.Windows.Forms.BindingSource gROUPDEVICEBindingSource;
        private System.Windows.Forms.BindingSource gROUPDEVICEBindingSource1;
        private Manager_deviceDataSet3 manager_deviceDataSet3;
        private System.Windows.Forms.ComboBox cbbsearch_group;
        private System.Windows.Forms.BindingSource gROUPDEVICEBindingSource2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}