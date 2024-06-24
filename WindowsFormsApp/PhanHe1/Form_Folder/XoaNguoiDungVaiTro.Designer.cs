namespace WindowsFormsApp
{
    partial class XoaNguoiDungVaiTro
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
            this.label_XoaUserRole = new System.Windows.Forms.Label();
            this.radioButton_XoaUser = new System.Windows.Forms.RadioButton();
            this.radioButton_XoaRole = new System.Windows.Forms.RadioButton();
            this.textBox_XoaUserRole = new System.Windows.Forms.TextBox();
            this.button_HoanTatXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_XoaUserRole
            // 
            this.label_XoaUserRole.AutoSize = true;
            this.label_XoaUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XoaUserRole.Location = new System.Drawing.Point(252, 41);
            this.label_XoaUserRole.Name = "label_XoaUserRole";
            this.label_XoaUserRole.Size = new System.Drawing.Size(226, 25);
            this.label_XoaUserRole.TabIndex = 30;
            this.label_XoaUserRole.Text = "Xóa Người Dùng/Vai Trò";
            // 
            // radioButton_XoaUser
            // 
            this.radioButton_XoaUser.AutoSize = true;
            this.radioButton_XoaUser.Location = new System.Drawing.Point(145, 100);
            this.radioButton_XoaUser.Name = "radioButton_XoaUser";
            this.radioButton_XoaUser.Size = new System.Drawing.Size(126, 20);
            this.radioButton_XoaUser.TabIndex = 31;
            this.radioButton_XoaUser.TabStop = true;
            this.radioButton_XoaUser.Text = "Xóa Người Dùng";
            this.radioButton_XoaUser.UseVisualStyleBackColor = true;
            this.radioButton_XoaUser.CheckedChanged += new System.EventHandler(this.radioButton_XoaUser_CheckedChanged);
            // 
            // radioButton_XoaRole
            // 
            this.radioButton_XoaRole.AutoSize = true;
            this.radioButton_XoaRole.Location = new System.Drawing.Point(450, 100);
            this.radioButton_XoaRole.Name = "radioButton_XoaRole";
            this.radioButton_XoaRole.Size = new System.Drawing.Size(99, 20);
            this.radioButton_XoaRole.TabIndex = 32;
            this.radioButton_XoaRole.TabStop = true;
            this.radioButton_XoaRole.Text = "Xóa Vai Trò";
            this.radioButton_XoaRole.UseVisualStyleBackColor = true;
            this.radioButton_XoaRole.CheckedChanged += new System.EventHandler(this.radioButton_XoaRole_CheckedChanged);
            // 
            // textBox_XoaUserRole
            // 
            this.textBox_XoaUserRole.Location = new System.Drawing.Point(269, 146);
            this.textBox_XoaUserRole.Name = "textBox_XoaUserRole";
            this.textBox_XoaUserRole.Size = new System.Drawing.Size(172, 22);
            this.textBox_XoaUserRole.TabIndex = 33;
            // 
            // button_HoanTatXoa
            // 
            this.button_HoanTatXoa.Location = new System.Drawing.Point(306, 192);
            this.button_HoanTatXoa.Name = "button_HoanTatXoa";
            this.button_HoanTatXoa.Size = new System.Drawing.Size(97, 23);
            this.button_HoanTatXoa.TabIndex = 34;
            this.button_HoanTatXoa.Text = "Hoàn Tất";
            this.button_HoanTatXoa.UseVisualStyleBackColor = true;
            this.button_HoanTatXoa.Click += new System.EventHandler(this.button_HoanTatXoa_Click);
            // 
            // XoaNguoiDungVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_HoanTatXoa);
            this.Controls.Add(this.textBox_XoaUserRole);
            this.Controls.Add(this.radioButton_XoaRole);
            this.Controls.Add(this.radioButton_XoaUser);
            this.Controls.Add(this.label_XoaUserRole);
            this.Name = "XoaNguoiDungVaiTro";
            this.Text = "XoaNguoiDungVaiTro";
            this.Load += new System.EventHandler(this.XoaNguoiDungVaiTro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_XoaUserRole;
        private System.Windows.Forms.RadioButton radioButton_XoaUser;
        private System.Windows.Forms.RadioButton radioButton_XoaRole;
        private System.Windows.Forms.TextBox textBox_XoaUserRole;
        private System.Windows.Forms.Button button_HoanTatXoa;
    }
}