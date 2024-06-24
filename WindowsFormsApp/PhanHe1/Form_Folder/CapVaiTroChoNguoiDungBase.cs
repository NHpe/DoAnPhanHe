namespace WindowsFormsApp.PhanHe1.Form_Folder
{
    internal class CapVaiTroChoNguoiDungBase
    {
        private System.Windows.Forms.Button button_HoanTatGanRoleUser;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.Label label_GrantRoleToUser;
        private System.Windows.Forms.Label label_RoleGrant_1;
        private System.Windows.Forms.Label label_UserGrant_1;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.ComboBox userBox;

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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_GrantRoleToUser = new System.Windows.Forms.Label();
            this.label_RoleGrant_1 = new System.Windows.Forms.Label();
            this.label_UserGrant_1 = new System.Windows.Forms.Label();
            this.button_HoanTatGanRoleUser = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.userBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_GrantRoleToUser
            // 
            this.label_GrantRoleToUser.AutoSize = true;
            this.label_GrantRoleToUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GrantRoleToUser.Location = new System.Drawing.Point(271, 65);
            this.label_GrantRoleToUser.Name = "label_GrantRoleToUser";
            this.label_GrantRoleToUser.Size = new System.Drawing.Size(325, 29);
            this.label_GrantRoleToUser.TabIndex = 32;
            this.label_GrantRoleToUser.Text = "Cấp Vai Trò Cho Người Dùng";
            // 
            // label_RoleGrant_1
            // 
            this.label_RoleGrant_1.AutoSize = true;
            this.label_RoleGrant_1.Location = new System.Drawing.Point(157, 183);
            this.label_RoleGrant_1.Name = "label_RoleGrant_1";
            this.label_RoleGrant_1.Size = new System.Drawing.Size(122, 20);
            this.label_RoleGrant_1.TabIndex = 33;
            this.label_RoleGrant_1.Text = "Nhập vào vai trò";
            // 
            // label_UserGrant_1
            // 
            this.label_UserGrant_1.AutoSize = true;
            this.label_UserGrant_1.Location = new System.Drawing.Point(157, 128);
            this.label_UserGrant_1.Name = "label_UserGrant_1";
            this.label_UserGrant_1.Size = new System.Drawing.Size(159, 20);
            this.label_UserGrant_1.TabIndex = 34;
            this.label_UserGrant_1.Text = "Nhập vào người dùng";
            // 
            // button_HoanTatGanRoleUser
            // 
            this.button_HoanTatGanRoleUser.Location = new System.Drawing.Point(371, 245);
            this.button_HoanTatGanRoleUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_HoanTatGanRoleUser.Name = "button_HoanTatGanRoleUser";
            this.button_HoanTatGanRoleUser.Size = new System.Drawing.Size(109, 29);
            this.button_HoanTatGanRoleUser.TabIndex = 37;
            this.button_HoanTatGanRoleUser.Text = "Hoàn Tất";
            this.button_HoanTatGanRoleUser.UseVisualStyleBackColor = true;
            this.button_HoanTatGanRoleUser.Click += new System.EventHandler(this.button_HoanTatGanRoleUser_Click);
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(339, 175);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(174, 28);
            this.roleBox.TabIndex = 48;
            // 
            // userBox
            // 
            this.userBox.FormattingEnabled = true;
            this.userBox.Location = new System.Drawing.Point(339, 120);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(174, 28);
            this.userBox.TabIndex = 49;
            // 
            // CapVaiTroChoNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.button_HoanTatGanRoleUser);
            this.Controls.Add(this.label_UserGrant_1);
            this.Controls.Add(this.label_RoleGrant_1);
            this.Controls.Add(this.label_GrantRoleToUser);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CapVaiTroChoNguoiDung";
            this.Text = "CapVaiTroChoNguoiDung";
            this.Load += new System.EventHandler(this.CapVaiTroChoNguoiDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}