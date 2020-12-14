namespace Manager_device
{
    partial class frmuser
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
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId_user = new System.Windows.Forms.TextBox();
            this.cbbId_rule = new System.Windows.Forms.ComboBox();
            this.rULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_deviceDataSet1 = new Manager_device.Manager_deviceDataSet1();
            this.rULETableAdapter = new Manager_device.Manager_deviceDataSet1TableAdapters.RULETableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rULEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtgvUser
            // 
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(12, 19);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.Size = new System.Drawing.Size(438, 150);
            this.dtgvUser.TabIndex = 3;
            this.dtgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(58, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(155, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(263, 226);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id_User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Id_Rule";
            // 
            // txtId_user
            // 
            this.txtId_user.Location = new System.Drawing.Point(518, 19);
            this.txtId_user.Name = "txtId_user";
            this.txtId_user.Size = new System.Drawing.Size(100, 20);
            this.txtId_user.TabIndex = 11;
            // 
            // cbbId_rule
            // 
            this.cbbId_rule.FormattingEnabled = true;
            this.cbbId_rule.Location = new System.Drawing.Point(519, 109);
            this.cbbId_rule.Name = "cbbId_rule";
            this.cbbId_rule.Size = new System.Drawing.Size(99, 21);
            this.cbbId_rule.TabIndex = 15;
            // 
            // rULEBindingSource
            // 
            this.rULEBindingSource.DataMember = "RULE";
            this.rULEBindingSource.DataSource = this.manager_deviceDataSet1;
            // 
            // manager_deviceDataSet1
            // 
            this.manager_deviceDataSet1.DataSetName = "Manager_deviceDataSet1";
            this.manager_deviceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rULETableAdapter
            // 
            this.rULETableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(518, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(518, 79);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 17;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(493, 226);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 18;
            this.txtUser.Visible = false;
            // 
            // frmuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbbId_rule);
            this.Controls.Add(this.txtId_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvUser);
            this.Controls.Add(this.btnExit);
            this.Name = "frmuser";
            this.Text = "frmuser";
            this.Load += new System.EventHandler(this.frmuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rULEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_deviceDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId_user;
        private System.Windows.Forms.ComboBox cbbId_rule;
        private Manager_deviceDataSet1 manager_deviceDataSet1;
        private System.Windows.Forms.BindingSource rULEBindingSource;
        private Manager_deviceDataSet1TableAdapters.RULETableAdapter rULETableAdapter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
    }
}