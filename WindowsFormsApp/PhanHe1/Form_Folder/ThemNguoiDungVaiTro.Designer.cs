namespace WindowsFormsApp
{
    partial class ThemNguoiDungVaiTro
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
            this.label_ThemUserRole = new System.Windows.Forms.Label();
            this.radioButton_ThemUser = new System.Windows.Forms.RadioButton();
            this.radioButton_ThemRole = new System.Windows.Forms.RadioButton();
            this.textBox_ThemUserRole = new System.Windows.Forms.TextBox();
            this.button_HoanTatThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ThemUserRole
            // 
            this.label_ThemUserRole.AutoSize = true;
            this.label_ThemUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThemUserRole.Location = new System.Drawing.Point(253, 49);
            this.label_ThemUserRole.Name = "label_ThemUserRole";
            this.label_ThemUserRole.Size = new System.Drawing.Size(241, 25);
            this.label_ThemUserRole.TabIndex = 29;
            this.label_ThemUserRole.Text = "Thêm Người Dùng/Vai Trò";
            // 
            // radioButton_ThemUser
            // 
            this.radioButton_ThemUser.AutoSize = true;
            this.radioButton_ThemUser.Location = new System.Drawing.Point(183, 88);
            this.radioButton_ThemUser.Name = "radioButton_ThemUser";
            this.radioButton_ThemUser.Size = new System.Drawing.Size(137, 20);
            this.radioButton_ThemUser.TabIndex = 30;
            this.radioButton_ThemUser.TabStop = true;
            this.radioButton_ThemUser.Text = "Thêm Người Dùng";
            this.radioButton_ThemUser.UseVisualStyleBackColor = true;
            this.radioButton_ThemUser.CheckedChanged += new System.EventHandler(this.radioButton_ThemUser_CheckedChanged);
            // 
            // radioButton_ThemRole
            // 
            this.radioButton_ThemRole.AutoSize = true;
            this.radioButton_ThemRole.Location = new System.Drawing.Point(449, 88);
            this.radioButton_ThemRole.Name = "radioButton_ThemRole";
            this.radioButton_ThemRole.Size = new System.Drawing.Size(110, 20);
            this.radioButton_ThemRole.TabIndex = 31;
            this.radioButton_ThemRole.TabStop = true;
            this.radioButton_ThemRole.Text = "Thêm Vai Trò";
            this.radioButton_ThemRole.UseVisualStyleBackColor = true;
            this.radioButton_ThemRole.CheckedChanged += new System.EventHandler(this.radioButton_ThemRole_CheckedChanged);
            // 
            // textBox_ThemUserRole
            // 
            this.textBox_ThemUserRole.Location = new System.Drawing.Point(285, 129);
            this.textBox_ThemUserRole.Name = "textBox_ThemUserRole";
            this.textBox_ThemUserRole.Size = new System.Drawing.Size(172, 22);
            this.textBox_ThemUserRole.TabIndex = 32;
            // 
            // button_HoanTatThem
            // 
            this.button_HoanTatThem.Location = new System.Drawing.Point(320, 174);
            this.button_HoanTatThem.Name = "button_HoanTatThem";
            this.button_HoanTatThem.Size = new System.Drawing.Size(97, 23);
            this.button_HoanTatThem.TabIndex = 33;
            this.button_HoanTatThem.Text = "Hoàn Tất";
            this.button_HoanTatThem.UseVisualStyleBackColor = true;
            this.button_HoanTatThem.Click += new System.EventHandler(this.button_HoanTatThem_Click);
            // 
            // ThemNguoiDungVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_HoanTatThem);
            this.Controls.Add(this.textBox_ThemUserRole);
            this.Controls.Add(this.radioButton_ThemRole);
            this.Controls.Add(this.radioButton_ThemUser);
            this.Controls.Add(this.label_ThemUserRole);
            this.Name = "ThemNguoiDungVaiTro";
            this.Text = "ThemNguoiDungVaiTro";
            this.Load += new System.EventHandler(this.ThemNguoiDungVaiTro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ThemUserRole;
        private System.Windows.Forms.RadioButton radioButton_ThemUser;
        private System.Windows.Forms.RadioButton radioButton_ThemRole;
        private System.Windows.Forms.TextBox textBox_ThemUserRole;
        private System.Windows.Forms.Button button_HoanTatThem;
    }
}