namespace WindowsFormsApp
{
    partial class CapQuyenChoNguoiDungVaiTro
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
            this.label_GrantPrivilegesToUserRole = new System.Windows.Forms.Label();
            this.textBox_GrantUserRole = new System.Windows.Forms.TextBox();
            this.label_GrantUserRole = new System.Windows.Forms.Label();
            this.radioButton_GRANT = new System.Windows.Forms.RadioButton();
            this.button_HoanTatGRANT = new System.Windows.Forms.Button();
            this.comboBox_ChonQuyen = new System.Windows.Forms.ComboBox();
            this.comboBox_TableList = new System.Windows.Forms.ComboBox();
            this.comboBox_ColumnList = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton_WITH_GRANT = new System.Windows.Forms.RadioButton();
            this.groupBox_UserRole = new System.Windows.Forms.GroupBox();
            this.groupBox_Grant = new System.Windows.Forms.GroupBox();
            this.groupBox_UserRole.SuspendLayout();
            this.groupBox_Grant.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_GrantPrivilegesToUserRole
            // 
            this.label_GrantPrivilegesToUserRole.AutoSize = true;
            this.label_GrantPrivilegesToUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GrantPrivilegesToUserRole.Location = new System.Drawing.Point(216, 27);
            this.label_GrantPrivilegesToUserRole.Name = "label_GrantPrivilegesToUserRole";
            this.label_GrantPrivilegesToUserRole.Size = new System.Drawing.Size(333, 25);
            this.label_GrantPrivilegesToUserRole.TabIndex = 38;
            this.label_GrantPrivilegesToUserRole.Text = "Cấp Quyền Cho Người Dùng/Vai Trò";
            // 
            // textBox_GrantUserRole
            // 
            this.textBox_GrantUserRole.Location = new System.Drawing.Point(350, 70);
            this.textBox_GrantUserRole.Name = "textBox_GrantUserRole";
            this.textBox_GrantUserRole.Size = new System.Drawing.Size(234, 22);
            this.textBox_GrantUserRole.TabIndex = 42;
            // 
            // label_GrantUserRole
            // 
            this.label_GrantUserRole.AutoSize = true;
            this.label_GrantUserRole.Location = new System.Drawing.Point(124, 75);
            this.label_GrantUserRole.Name = "label_GrantUserRole";
            this.label_GrantUserRole.Size = new System.Drawing.Size(175, 16);
            this.label_GrantUserRole.TabIndex = 43;
            this.label_GrantUserRole.Text = "Nhập vào người dùng/vai trò";
            // 
            // radioButton_GRANT
            // 
            this.radioButton_GRANT.AutoSize = true;
            this.radioButton_GRANT.Location = new System.Drawing.Point(37, 18);
            this.radioButton_GRANT.Name = "radioButton_GRANT";
            this.radioButton_GRANT.Size = new System.Drawing.Size(76, 20);
            this.radioButton_GRANT.TabIndex = 46;
            this.radioButton_GRANT.TabStop = true;
            this.radioButton_GRANT.Text = "GRANT";
            this.radioButton_GRANT.UseVisualStyleBackColor = true;
            this.radioButton_GRANT.CheckedChanged += new System.EventHandler(this.radioButton_GRANT_CheckedChanged);
            // 
            // button_HoanTatGRANT
            // 
            this.button_HoanTatGRANT.Location = new System.Drawing.Point(339, 288);
            this.button_HoanTatGRANT.Name = "button_HoanTatGRANT";
            this.button_HoanTatGRANT.Size = new System.Drawing.Size(97, 23);
            this.button_HoanTatGRANT.TabIndex = 51;
            this.button_HoanTatGRANT.Text = "Hoàn Tất";
            this.button_HoanTatGRANT.UseVisualStyleBackColor = true;
            this.button_HoanTatGRANT.Click += new System.EventHandler(this.button_HoanTatGRANT_Click);
            // 
            // comboBox_ChonQuyen
            // 
            this.comboBox_ChonQuyen.FormattingEnabled = true;
            this.comboBox_ChonQuyen.Location = new System.Drawing.Point(28, 228);
            this.comboBox_ChonQuyen.Name = "comboBox_ChonQuyen";
            this.comboBox_ChonQuyen.Size = new System.Drawing.Size(178, 24);
            this.comboBox_ChonQuyen.TabIndex = 52;
            // 
            // comboBox_TableList
            // 
            this.comboBox_TableList.FormattingEnabled = true;
            this.comboBox_TableList.Location = new System.Drawing.Point(265, 228);
            this.comboBox_TableList.Name = "comboBox_TableList";
            this.comboBox_TableList.Size = new System.Drawing.Size(220, 24);
            this.comboBox_TableList.TabIndex = 55;
            this.comboBox_TableList.SelectedIndexChanged += new System.EventHandler(this.comboBox_TableList_SelectedIndex_Changed);
            // 
            // comboBox_ColumnList
            // 
            this.comboBox_ColumnList.FormattingEnabled = true;
            this.comboBox_ColumnList.Location = new System.Drawing.Point(524, 228);
            this.comboBox_ColumnList.Name = "comboBox_ColumnList";
            this.comboBox_ColumnList.Size = new System.Drawing.Size(220, 24);
            this.comboBox_ColumnList.TabIndex = 56;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 33);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 20);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Người dùng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(206, 33);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 59;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vai trò";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton_WITH_GRANT
            // 
            this.radioButton_WITH_GRANT.AutoSize = true;
            this.radioButton_WITH_GRANT.Location = new System.Drawing.Point(206, 18);
            this.radioButton_WITH_GRANT.Name = "radioButton_WITH_GRANT";
            this.radioButton_WITH_GRANT.Size = new System.Drawing.Size(114, 20);
            this.radioButton_WITH_GRANT.TabIndex = 47;
            this.radioButton_WITH_GRANT.TabStop = true;
            this.radioButton_WITH_GRANT.Text = "WITH GRANT";
            this.radioButton_WITH_GRANT.UseVisualStyleBackColor = true;
            this.radioButton_WITH_GRANT.CheckedChanged += new System.EventHandler(this.radioButton_WITH_GRANT_CheckedChanged);
            // 
            // groupBox_UserRole
            // 
            this.groupBox_UserRole.Controls.Add(this.radioButton2);
            this.groupBox_UserRole.Controls.Add(this.radioButton1);
            this.groupBox_UserRole.Location = new System.Drawing.Point(190, 97);
            this.groupBox_UserRole.Name = "groupBox_UserRole";
            this.groupBox_UserRole.Size = new System.Drawing.Size(394, 64);
            this.groupBox_UserRole.TabIndex = 60;
            this.groupBox_UserRole.TabStop = false;
            // 
            // groupBox_Grant
            // 
            this.groupBox_Grant.Controls.Add(this.radioButton_GRANT);
            this.groupBox_Grant.Controls.Add(this.radioButton_WITH_GRANT);
            this.groupBox_Grant.Location = new System.Drawing.Point(190, 178);
            this.groupBox_Grant.Name = "groupBox_Grant";
            this.groupBox_Grant.Size = new System.Drawing.Size(394, 44);
            this.groupBox_Grant.TabIndex = 61;
            this.groupBox_Grant.TabStop = false;
            // 
            // CapQuyenChoNguoiDungVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Grant);
            this.Controls.Add(this.groupBox_UserRole);
            this.Controls.Add(this.comboBox_ColumnList);
            this.Controls.Add(this.comboBox_TableList);
            this.Controls.Add(this.comboBox_ChonQuyen);
            this.Controls.Add(this.button_HoanTatGRANT);
            this.Controls.Add(this.label_GrantUserRole);
            this.Controls.Add(this.textBox_GrantUserRole);
            this.Controls.Add(this.label_GrantPrivilegesToUserRole);
            this.Name = "CapQuyenChoNguoiDungVaiTro";
            this.Text = "CapQuyenChoNguoiDungVaiTro";
            this.Load += new System.EventHandler(this.CapQuyenChoNguoiDungVaiTro_Load);
            this.groupBox_UserRole.ResumeLayout(false);
            this.groupBox_UserRole.PerformLayout();
            this.groupBox_Grant.ResumeLayout(false);
            this.groupBox_Grant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_GrantPrivilegesToUserRole;
        private System.Windows.Forms.TextBox textBox_GrantUserRole;
        private System.Windows.Forms.Label label_GrantUserRole;
        private System.Windows.Forms.RadioButton radioButton_GRANT;
        private System.Windows.Forms.Button button_HoanTatGRANT;
        private System.Windows.Forms.ComboBox comboBox_ChonQuyen;
        private System.Windows.Forms.ComboBox comboBox_TableList;
        private System.Windows.Forms.ComboBox comboBox_ColumnList;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton_WITH_GRANT;
        private System.Windows.Forms.GroupBox groupBox_UserRole;
        private System.Windows.Forms.GroupBox groupBox_Grant;
    }
}