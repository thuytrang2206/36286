namespace Manager_device
{
    partial class FrmDetail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbbId = new System.Windows.Forms.ComboBox();
            this.dEVICEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manager_deviceDataSet4 = new Manager_device.Manager_deviceDataSet4();
            this.dEVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dtcheck = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dEVICETableAdapter = new Manager_device.Manager_deviceDataSet4TableAdapters.DEVICETableAdapter();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.cbbinfo = new System.Windows.Forms.ComboBox();
            this.cbbstatus = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID_DETAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID_DEVICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INFO";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 258);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // cbbId
            // 
            this.cbbId.DataSource = this.dEVICEBindingSource1;
            this.cbbId.DisplayMember = "ID_DEVICE";
            this.cbbId.FormattingEnabled = true;
            this.cbbId.Location = new System.Drawing.Point(92, 284);
            this.cbbId.Name = "cbbId";
            this.cbbId.Size = new System.Drawing.Size(121, 21);
            this.cbbId.TabIndex = 5;
            // 
            // dEVICEBindingSource1
            // 
            this.dEVICEBindingSource1.DataMember = "DEVICE";
            this.dEVICEBindingSource1.DataSource = this.manager_deviceDataSet4;
            // 
            // manager_deviceDataSet4
            // 
            this.manager_deviceDataSet4.DataSetName = "Manager_deviceDataSet4";
            this.manager_deviceDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEVICEBindingSource
            // 
            this.dEVICEBindingSource.DataSource = typeof(Manager_device.DEVICE);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DATE_CHECK";
            // 
            // dtcheck
            // 
            this.dtcheck.Location = new System.Drawing.Point(92, 311);
            this.dtcheck.Name = "dtcheck";
            this.dtcheck.Size = new System.Drawing.Size(200, 20);
            this.dtcheck.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dEVICETableAdapter
            // 
            this.dEVICETableAdapter.ClearBeforeFill = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(330, 304);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 13;
            this.txtUser.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(87, 113);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(6, 113);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "NOTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "QUANTITY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(806, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "STATUS";
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(113, 380);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(100, 20);
            this.txtnote.TabIndex = 20;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(113, 407);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 20);
            this.txtquantity.TabIndex = 21;
            // 
            // cbbinfo
            // 
            this.cbbinfo.FormattingEnabled = true;
            this.cbbinfo.Location = new System.Drawing.Point(92, 345);
            this.cbbinfo.Name = "cbbinfo";
            this.cbbinfo.Size = new System.Drawing.Size(121, 21);
            this.cbbinfo.TabIndex = 23;
            // 
            // cbbstatus
            // 
            this.cbbstatus.FormattingEnabled = true;
            this.cbbstatus.Location = new System.Drawing.Point(330, 260);
            this.cbbstatus.Name = "cbbstatus";
            this.cbbstatus.Size = new System.Drawing.Size(121, 21);
            this.cbbstatus.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(457, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 149);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(234, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbstatus);
            this.Controls.Add(this.cbbinfo);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.dtcheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmDetail";
            this.Text = "FrmDetail";
            this.Load += new System.EventHandler(this.FrmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtcheck;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource dEVICEBindingSource;
        private Manager_deviceDataSet4 manager_deviceDataSet4;
        private System.Windows.Forms.BindingSource dEVICEBindingSource1;
        private Manager_deviceDataSet4TableAdapters.DEVICETableAdapter dEVICETableAdapter;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.ComboBox cbbinfo;
        private System.Windows.Forms.ComboBox cbbstatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}