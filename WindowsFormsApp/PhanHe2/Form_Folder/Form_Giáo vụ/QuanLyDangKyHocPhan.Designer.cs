namespace WindowsFormsApp
{
    partial class QuanLyDangKyHocPhan
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
            this.groupBox_ThemXoa = new System.Windows.Forms.GroupBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.textBox_MACT = new System.Windows.Forms.TextBox();
            this.textBox_NAM = new System.Windows.Forms.TextBox();
            this.textBox_HK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_MAHP = new System.Windows.Forms.TextBox();
            this.textBox_MAGV = new System.Windows.Forms.TextBox();
            this.textBox_MASV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_ThongBao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_ThemXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ThemXoa
            // 
            this.groupBox_ThemXoa.Controls.Add(this.button_Them);
            this.groupBox_ThemXoa.Controls.Add(this.button_Xoa);
            this.groupBox_ThemXoa.Controls.Add(this.textBox_MACT);
            this.groupBox_ThemXoa.Controls.Add(this.textBox_NAM);
            this.groupBox_ThemXoa.Controls.Add(this.textBox_HK);
            this.groupBox_ThemXoa.Controls.Add(this.label7);
            this.groupBox_ThemXoa.Controls.Add(this.label8);
            this.groupBox_ThemXoa.Controls.Add(this.label9);
            this.groupBox_ThemXoa.Controls.Add(this.textBox_MAHP);
            this.groupBox_ThemXoa.Controls.Add(this.textBox_MAGV);
            this.groupBox_ThemXoa.Controls.Add(this.textBox_MASV);
            this.groupBox_ThemXoa.Controls.Add(this.label10);
            this.groupBox_ThemXoa.Controls.Add(this.label11);
            this.groupBox_ThemXoa.Controls.Add(this.label12);
            this.groupBox_ThemXoa.Location = new System.Drawing.Point(0, 277);
            this.groupBox_ThemXoa.Name = "groupBox_ThemXoa";
            this.groupBox_ThemXoa.Size = new System.Drawing.Size(801, 188);
            this.groupBox_ThemXoa.TabIndex = 1;
            this.groupBox_ThemXoa.TabStop = false;
            this.groupBox_ThemXoa.Text = "Thêm/Xóa thông tin đăng ký học phần của sinh viên";
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(642, 41);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(97, 44);
            this.button_Them.TabIndex = 13;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(642, 112);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(97, 44);
            this.button_Xoa.TabIndex = 12;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // textBox_MACT
            // 
            this.textBox_MACT.Location = new System.Drawing.Point(478, 150);
            this.textBox_MACT.Name = "textBox_MACT";
            this.textBox_MACT.Size = new System.Drawing.Size(100, 22);
            this.textBox_MACT.TabIndex = 11;
            // 
            // textBox_NAM
            // 
            this.textBox_NAM.Location = new System.Drawing.Point(478, 101);
            this.textBox_NAM.Name = "textBox_NAM";
            this.textBox_NAM.Size = new System.Drawing.Size(100, 22);
            this.textBox_NAM.TabIndex = 10;
            // 
            // textBox_HK
            // 
            this.textBox_HK.Location = new System.Drawing.Point(478, 52);
            this.textBox_HK.Name = "textBox_HK";
            this.textBox_HK.Size = new System.Drawing.Size(100, 22);
            this.textBox_HK.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã chương trình";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Năm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Học kỳ";
            // 
            // textBox_MAHP
            // 
            this.textBox_MAHP.Location = new System.Drawing.Point(184, 150);
            this.textBox_MAHP.Name = "textBox_MAHP";
            this.textBox_MAHP.Size = new System.Drawing.Size(100, 22);
            this.textBox_MAHP.TabIndex = 5;
            // 
            // textBox_MAGV
            // 
            this.textBox_MAGV.Location = new System.Drawing.Point(184, 101);
            this.textBox_MAGV.Name = "textBox_MAGV";
            this.textBox_MAGV.Size = new System.Drawing.Size(100, 22);
            this.textBox_MAGV.TabIndex = 4;
            // 
            // textBox_MASV
            // 
            this.textBox_MASV.Location = new System.Drawing.Point(184, 52);
            this.textBox_MASV.Name = "textBox_MASV";
            this.textBox_MASV.Size = new System.Drawing.Size(100, 22);
            this.textBox_MASV.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã học phần";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã giáo viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã sinh viên";
            // 
            // label_ThongBao
            // 
            this.label_ThongBao.AutoSize = true;
            this.label_ThongBao.Location = new System.Drawing.Point(288, 248);
            this.label_ThongBao.Name = "label_ThongBao";
            this.label_ThongBao.Size = new System.Drawing.Size(270, 16);
            this.label_ThongBao.TabIndex = 13;
            this.label_ThongBao.Text = "Hiện tại không thể tùy chỉnh thông tin đăng ký";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 221);
            this.dataGridView1.TabIndex = 14;
            // 
            // QuanLyDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_ThongBao);
            this.Controls.Add(this.groupBox_ThemXoa);
            this.Name = "QuanLyDangKyHocPhan";
            this.Text = "Quản lý đăng ký học phần";
            this.Load += new System.EventHandler(this.QuanLyDangKyHocPhan_Load);
            this.groupBox_ThemXoa.ResumeLayout(false);
            this.groupBox_ThemXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_ThemXoa;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.TextBox textBox_MACT;
        private System.Windows.Forms.TextBox textBox_NAM;
        private System.Windows.Forms.TextBox textBox_HK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_MAHP;
        private System.Windows.Forms.TextBox textBox_MAGV;
        private System.Windows.Forms.TextBox textBox_MASV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_ThongBao;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}