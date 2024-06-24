namespace WindowsFormsApp
{
    partial class SuaNguoiDungVaiTro
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
            this.label_SuaUserRole = new System.Windows.Forms.Label();
            this.label_UserRoleMuonDoi = new System.Windows.Forms.Label();
            this.label_UserRoleSauDoi = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.button_HoanTatSua = new System.Windows.Forms.Button();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_SuaUserRole
            // 
            this.label_SuaUserRole.AutoSize = true;
            this.label_SuaUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuaUserRole.Location = new System.Drawing.Point(253, 54);
            this.label_SuaUserRole.Name = "label_SuaUserRole";
            this.label_SuaUserRole.Size = new System.Drawing.Size(226, 25);
            this.label_SuaUserRole.TabIndex = 31;
            this.label_SuaUserRole.Text = "Sửa Người Dùng/Vai Trò";
            // 
            // label_UserRoleMuonDoi
            // 
            this.label_UserRoleMuonDoi.AutoSize = true;
            this.label_UserRoleMuonDoi.Location = new System.Drawing.Point(119, 117);
            this.label_UserRoleMuonDoi.Name = "label_UserRoleMuonDoi";
            this.label_UserRoleMuonDoi.Size = new System.Drawing.Size(213, 16);
            this.label_UserRoleMuonDoi.TabIndex = 34;
            this.label_UserRoleMuonDoi.Text = "Nhập vào User muốn đổi mật khẩu";
            // 
            // label_UserRoleSauDoi
            // 
            this.label_UserRoleSauDoi.AutoSize = true;
            this.label_UserRoleSauDoi.Location = new System.Drawing.Point(210, 155);
            this.label_UserRoleSauDoi.Name = "label_UserRoleSauDoi";
            this.label_UserRoleSauDoi.Size = new System.Drawing.Size(122, 16);
            this.label_UserRoleSauDoi.TabIndex = 35;
            this.label_UserRoleSauDoi.Text = "Nhập mật khẩu mới";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(392, 111);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(172, 22);
            this.userTextBox.TabIndex = 36;
            // 
            // button_HoanTatSua
            // 
            this.button_HoanTatSua.Location = new System.Drawing.Point(323, 208);
            this.button_HoanTatSua.Name = "button_HoanTatSua";
            this.button_HoanTatSua.Size = new System.Drawing.Size(97, 23);
            this.button_HoanTatSua.TabIndex = 38;
            this.button_HoanTatSua.Text = "Hoàn Tất";
            this.button_HoanTatSua.UseVisualStyleBackColor = true;
            this.button_HoanTatSua.Click += new System.EventHandler(this.button_HoanTatSua_Click);
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(392, 149);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(172, 22);
            this.pwTextBox.TabIndex = 39;
            // 
            // SuaNguoiDungVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.button_HoanTatSua);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label_UserRoleSauDoi);
            this.Controls.Add(this.label_UserRoleMuonDoi);
            this.Controls.Add(this.label_SuaUserRole);
            this.Name = "SuaNguoiDungVaiTro";
            this.Text = "SuaNguoiDungVaiTro";
            this.Load += new System.EventHandler(this.SuaNguoiDungVaiTro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SuaUserRole;
        private System.Windows.Forms.Label label_UserRoleMuonDoi;
        private System.Windows.Forms.Label label_UserRoleSauDoi;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button button_HoanTatSua;
        private System.Windows.Forms.TextBox pwTextBox;
    }
}