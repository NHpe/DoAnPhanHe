namespace WindowsFormsApp
{
    partial class PhanHe1
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
            this.button_UserList = new System.Windows.Forms.Button();
            this.dataGridView_UserList = new System.Windows.Forms.DataGridView();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_RoleList = new System.Windows.Forms.Button();
            this.dataGridView_RoleList = new System.Windows.Forms.DataGridView();
            this.ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ThemUserRole = new System.Windows.Forms.Button();
            this.button_XoaUserRole = new System.Windows.Forms.Button();
            this.button_SuaUserRole = new System.Windows.Forms.Button();
            this.button_CapRoleToUser = new System.Windows.Forms.Button();
            this.button_CapQuyenChoUserRole = new System.Windows.Forms.Button();
            this.button_ThuHoiQuyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoleList)).BeginInit();
            this.SuspendLayout();
            // 
            // button_UserList
            // 
            this.button_UserList.Location = new System.Drawing.Point(44, 29);
            this.button_UserList.Name = "button_UserList";
            this.button_UserList.Size = new System.Drawing.Size(172, 36);
            this.button_UserList.TabIndex = 0;
            this.button_UserList.Text = "Danh Sách Người Dùng";
            this.button_UserList.UseVisualStyleBackColor = true;
            this.button_UserList.Click += new System.EventHandler(this.button_UserList_Click);
            // 
            // dataGridView_UserList
            // 
            this.dataGridView_UserList.AllowUserToAddRows = false;
            this.dataGridView_UserList.AllowUserToDeleteRows = false;
            this.dataGridView_UserList.AllowUserToResizeColumns = false;
            this.dataGridView_UserList.AllowUserToResizeRows = false;
            this.dataGridView_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERNAME});
            this.dataGridView_UserList.Location = new System.Drawing.Point(12, 80);
            this.dataGridView_UserList.Name = "dataGridView_UserList";
            this.dataGridView_UserList.ReadOnly = true;
            this.dataGridView_UserList.RowHeadersWidth = 51;
            this.dataGridView_UserList.RowTemplate.Height = 24;
            this.dataGridView_UserList.Size = new System.Drawing.Size(222, 345);
            this.dataGridView_UserList.TabIndex = 1;
            this.dataGridView_UserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_UserList_CellContentClick);
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "Người dùng";
            this.USERNAME.MinimumWidth = 6;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // button_RoleList
            // 
            this.button_RoleList.Location = new System.Drawing.Point(298, 29);
            this.button_RoleList.Name = "button_RoleList";
            this.button_RoleList.Size = new System.Drawing.Size(172, 36);
            this.button_RoleList.TabIndex = 20;
            this.button_RoleList.Text = "Danh Sách Vai Trò";
            this.button_RoleList.UseVisualStyleBackColor = true;
            this.button_RoleList.Click += new System.EventHandler(this.button_RoleList_Click);
            // 
            // dataGridView_RoleList
            // 
            this.dataGridView_RoleList.AllowUserToAddRows = false;
            this.dataGridView_RoleList.AllowUserToDeleteRows = false;
            this.dataGridView_RoleList.AllowUserToResizeColumns = false;
            this.dataGridView_RoleList.AllowUserToResizeRows = false;
            this.dataGridView_RoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RoleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ROLE});
            this.dataGridView_RoleList.Location = new System.Drawing.Point(271, 80);
            this.dataGridView_RoleList.Name = "dataGridView_RoleList";
            this.dataGridView_RoleList.ReadOnly = true;
            this.dataGridView_RoleList.RowHeadersWidth = 51;
            this.dataGridView_RoleList.RowTemplate.Height = 24;
            this.dataGridView_RoleList.Size = new System.Drawing.Size(222, 345);
            this.dataGridView_RoleList.TabIndex = 21;
            this.dataGridView_RoleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RoleList_CellContentClick);
            // 
            // ROLE
            // 
            this.ROLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ROLE.DataPropertyName = "ROLE";
            this.ROLE.HeaderText = "Vai trò";
            this.ROLE.MinimumWidth = 6;
            this.ROLE.Name = "ROLE";
            this.ROLE.ReadOnly = true;
            // 
            // button_ThemUserRole
            // 
            this.button_ThemUserRole.Location = new System.Drawing.Point(522, 80);
            this.button_ThemUserRole.Name = "button_ThemUserRole";
            this.button_ThemUserRole.Size = new System.Drawing.Size(266, 36);
            this.button_ThemUserRole.TabIndex = 50;
            this.button_ThemUserRole.Text = "Thêm Người Dùng/Vai Trò";
            this.button_ThemUserRole.UseVisualStyleBackColor = true;
            this.button_ThemUserRole.Click += new System.EventHandler(this.button_ThemUserRole_Click);
            // 
            // button_XoaUserRole
            // 
            this.button_XoaUserRole.Location = new System.Drawing.Point(522, 133);
            this.button_XoaUserRole.Name = "button_XoaUserRole";
            this.button_XoaUserRole.Size = new System.Drawing.Size(266, 36);
            this.button_XoaUserRole.TabIndex = 51;
            this.button_XoaUserRole.Text = "Xóa Người Dùng/Vai Trò";
            this.button_XoaUserRole.UseVisualStyleBackColor = true;
            this.button_XoaUserRole.Click += new System.EventHandler(this.button_XoaUserRole_Click);
            // 
            // button_SuaUserRole
            // 
            this.button_SuaUserRole.Location = new System.Drawing.Point(522, 184);
            this.button_SuaUserRole.Name = "button_SuaUserRole";
            this.button_SuaUserRole.Size = new System.Drawing.Size(266, 36);
            this.button_SuaUserRole.TabIndex = 52;
            this.button_SuaUserRole.Text = "Sửa Người Dùng/Vai Trò";
            this.button_SuaUserRole.UseVisualStyleBackColor = true;
            this.button_SuaUserRole.Click += new System.EventHandler(this.button_SuaUserRole_Click);
            // 
            // button_CapRoleToUser
            // 
            this.button_CapRoleToUser.Location = new System.Drawing.Point(522, 235);
            this.button_CapRoleToUser.Name = "button_CapRoleToUser";
            this.button_CapRoleToUser.Size = new System.Drawing.Size(266, 36);
            this.button_CapRoleToUser.TabIndex = 53;
            this.button_CapRoleToUser.Text = "Cấp Vai Trò Cho Người Dùng";
            this.button_CapRoleToUser.UseVisualStyleBackColor = true;
            this.button_CapRoleToUser.Click += new System.EventHandler(this.button_CapRoleToUser_Click);
            // 
            // button_CapQuyenChoUserRole
            // 
            this.button_CapQuyenChoUserRole.Location = new System.Drawing.Point(522, 289);
            this.button_CapQuyenChoUserRole.Name = "button_CapQuyenChoUserRole";
            this.button_CapQuyenChoUserRole.Size = new System.Drawing.Size(266, 36);
            this.button_CapQuyenChoUserRole.TabIndex = 54;
            this.button_CapQuyenChoUserRole.Text = "Cấp Quyền Cho Người Dùng/Vai Trò";
            this.button_CapQuyenChoUserRole.UseVisualStyleBackColor = true;
            this.button_CapQuyenChoUserRole.Click += new System.EventHandler(this.button_CapQuyenChoUserRole_Click);
            // 
            // button_ThuHoiQuyen
            // 
            this.button_ThuHoiQuyen.Location = new System.Drawing.Point(522, 346);
            this.button_ThuHoiQuyen.Name = "button_ThuHoiQuyen";
            this.button_ThuHoiQuyen.Size = new System.Drawing.Size(266, 36);
            this.button_ThuHoiQuyen.TabIndex = 55;
            this.button_ThuHoiQuyen.Text = "Thu Hồi Quyền";
            this.button_ThuHoiQuyen.UseVisualStyleBackColor = true;
            this.button_ThuHoiQuyen.Click += new System.EventHandler(this.button_ThuHoiQuyen_Click);
            // 
            // PhanHe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ThuHoiQuyen);
            this.Controls.Add(this.button_CapQuyenChoUserRole);
            this.Controls.Add(this.button_CapRoleToUser);
            this.Controls.Add(this.button_SuaUserRole);
            this.Controls.Add(this.button_XoaUserRole);
            this.Controls.Add(this.button_ThemUserRole);
            this.Controls.Add(this.dataGridView_RoleList);
            this.Controls.Add(this.button_RoleList);
            this.Controls.Add(this.dataGridView_UserList);
            this.Controls.Add(this.button_UserList);
            this.Name = "PhanHe1";
            this.Text = "Phân Hệ 1";
            this.Load += new System.EventHandler(this.PhanHe1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RoleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_UserList;
        private System.Windows.Forms.DataGridView dataGridView_UserList;
        private System.Windows.Forms.Button button_RoleList;
        private System.Windows.Forms.DataGridView dataGridView_RoleList;
        private System.Windows.Forms.Button button_ThemUserRole;
        private System.Windows.Forms.Button button_XoaUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE;
        private System.Windows.Forms.Button button_SuaUserRole;
        private System.Windows.Forms.Button button_CapRoleToUser;
        private System.Windows.Forms.Button button_CapQuyenChoUserRole;
        private System.Windows.Forms.Button button_ThuHoiQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
    }
}

