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
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtcheck = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dEVICETableAdapter = new Manager_device.Manager_deviceDataSet4TableAdapters.DEVICETableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID_DETAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID_DEVICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INFO";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(666, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // cbbId
            // 
            this.cbbId.DataSource = this.dEVICEBindingSource1;
            this.cbbId.DisplayMember = "ID_DEVICE";
            this.cbbId.FormattingEnabled = true;
            this.cbbId.Location = new System.Drawing.Point(666, 73);
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
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(666, 153);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(100, 20);
            this.txtinfo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DATE_CHECK";
            // 
            // dtcheck
            // 
            this.dtcheck.Location = new System.Drawing.Point(666, 113);
            this.dtcheck.Name = "dtcheck";
            this.dtcheck.Size = new System.Drawing.Size(200, 20);
            this.dtcheck.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(781, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(781, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dEVICETableAdapter
            // 
            this.dEVICETableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(666, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(443, 255);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 302);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtcheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtinfo);
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
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtcheck;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dEVICEBindingSource;
        private Manager_deviceDataSet4 manager_deviceDataSet4;
        private System.Windows.Forms.BindingSource dEVICEBindingSource1;
        private Manager_deviceDataSet4TableAdapters.DEVICETableAdapter dEVICETableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}