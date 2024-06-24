namespace WindowsFormsApp
{
    partial class ThongTinSinhVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_LamMoi = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_DTBTL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_SOTCTL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_MANGANH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_MACT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_DT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_DCHI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NGSINH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PHAI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_HOTEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MASV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_LamMoi);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_DTBTL);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_SOTCTL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_MANGANH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_MACT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_DT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_DCHI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_NGSINH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_PHAI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_HOTEN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_MASV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hoặc sửa sinh viên";
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(547, 160);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(105, 41);
            this.button_LamMoi.TabIndex = 21;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(398, 160);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(105, 41);
            this.button_Them.TabIndex = 20;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_DTBTL
            // 
            this.textBox_DTBTL.Location = new System.Drawing.Point(128, 162);
            this.textBox_DTBTL.Name = "textBox_DTBTL";
            this.textBox_DTBTL.Size = new System.Drawing.Size(115, 22);
            this.textBox_DTBTL.TabIndex = 19;
            this.textBox_DTBTL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DTBTL_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Điểm TBTL";
            // 
            // textBox_SOTCTL
            // 
            this.textBox_SOTCTL.Location = new System.Drawing.Point(639, 118);
            this.textBox_SOTCTL.Name = "textBox_SOTCTL";
            this.textBox_SOTCTL.Size = new System.Drawing.Size(115, 22);
            this.textBox_SOTCTL.TabIndex = 17;
            this.textBox_SOTCTL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SOTCTL_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số tín chỉ TL";
            // 
            // textBox_MANGANH
            // 
            this.textBox_MANGANH.Location = new System.Drawing.Point(639, 77);
            this.textBox_MANGANH.Name = "textBox_MANGANH";
            this.textBox_MANGANH.Size = new System.Drawing.Size(115, 22);
            this.textBox_MANGANH.TabIndex = 15;
            this.textBox_MANGANH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MANGANH_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã ngành";
            // 
            // textBox_MACT
            // 
            this.textBox_MACT.Location = new System.Drawing.Point(639, 32);
            this.textBox_MACT.Name = "textBox_MACT";
            this.textBox_MACT.Size = new System.Drawing.Size(115, 22);
            this.textBox_MACT.TabIndex = 13;
            this.textBox_MACT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MACT_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã chương trình";
            // 
            // textBox_DT
            // 
            this.textBox_DT.Location = new System.Drawing.Point(371, 118);
            this.textBox_DT.Name = "textBox_DT";
            this.textBox_DT.Size = new System.Drawing.Size(115, 22);
            this.textBox_DT.TabIndex = 11;
            this.textBox_DT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DT_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điện thoại";
            // 
            // textBox_DCHI
            // 
            this.textBox_DCHI.Location = new System.Drawing.Point(371, 77);
            this.textBox_DCHI.Name = "textBox_DCHI";
            this.textBox_DCHI.Size = new System.Drawing.Size(115, 22);
            this.textBox_DCHI.TabIndex = 9;
            this.textBox_DCHI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DCHI_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // textBox_NGSINH
            // 
            this.textBox_NGSINH.Location = new System.Drawing.Point(371, 32);
            this.textBox_NGSINH.Name = "textBox_NGSINH";
            this.textBox_NGSINH.Size = new System.Drawing.Size(115, 22);
            this.textBox_NGSINH.TabIndex = 7;
            this.textBox_NGSINH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NGSINH_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh";
            // 
            // textBox_PHAI
            // 
            this.textBox_PHAI.Location = new System.Drawing.Point(128, 118);
            this.textBox_PHAI.Name = "textBox_PHAI";
            this.textBox_PHAI.Size = new System.Drawing.Size(115, 22);
            this.textBox_PHAI.TabIndex = 5;
            this.textBox_PHAI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PHAI_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phái";
            // 
            // textBox_HOTEN
            // 
            this.textBox_HOTEN.Location = new System.Drawing.Point(128, 77);
            this.textBox_HOTEN.Name = "textBox_HOTEN";
            this.textBox_HOTEN.Size = new System.Drawing.Size(115, 22);
            this.textBox_HOTEN.TabIndex = 3;
            this.textBox_HOTEN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_HOTEN_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // textBox_MASV
            // 
            this.textBox_MASV.Location = new System.Drawing.Point(128, 32);
            this.textBox_MASV.Name = "textBox_MASV";
            this.textBox_MASV.Size = new System.Drawing.Size(115, 22);
            this.textBox_MASV.TabIndex = 1;
            this.textBox_MASV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MASV_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // ThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongTinSinhVien";
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.ThongTinSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_HOTEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MASV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PHAI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_DCHI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NGSINH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SOTCTL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_MANGANH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_MACT;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_DTBTL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_LamMoi;
    }
}