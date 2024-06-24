namespace WindowsFormsApp
{
    partial class ThongTinNhanSu
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
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_MADV = new System.Windows.Forms.TextBox();
            this.textBox_VAITRO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_DT = new System.Windows.Forms.TextBox();
            this.textBox_PHUCAP = new System.Windows.Forms.TextBox();
            this.textBox_NGSINH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PHAI = new System.Windows.Forms.TextBox();
            this.textBox_HOTEN = new System.Windows.Forms.TextBox();
            this.textBox_MANV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_MADV);
            this.groupBox1.Controls.Add(this.textBox_VAITRO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_DT);
            this.groupBox1.Controls.Add(this.textBox_PHUCAP);
            this.groupBox1.Controls.Add(this.textBox_NGSINH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_PHAI);
            this.groupBox1.Controls.Add(this.textBox_HOTEN);
            this.groupBox1.Controls.Add(this.textBox_MANV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác với dữ liệu nhân sự";
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(694, 154);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(75, 35);
            this.button_LamMoi.TabIndex = 20;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(694, 105);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 35);
            this.button_Xoa.TabIndex = 19;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(694, 51);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 35);
            this.button_Them.TabIndex = 18;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_MADV
            // 
            this.textBox_MADV.Location = new System.Drawing.Point(557, 102);
            this.textBox_MADV.Name = "textBox_MADV";
            this.textBox_MADV.Size = new System.Drawing.Size(100, 22);
            this.textBox_MADV.TabIndex = 17;
            this.textBox_MADV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MADV_KeyDown);
            // 
            // textBox_VAITRO
            // 
            this.textBox_VAITRO.Location = new System.Drawing.Point(557, 51);
            this.textBox_VAITRO.Name = "textBox_VAITRO";
            this.textBox_VAITRO.Size = new System.Drawing.Size(100, 22);
            this.textBox_VAITRO.TabIndex = 16;
            this.textBox_VAITRO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_VAITRO_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã đơn vị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vai trò";
            // 
            // textBox_DT
            // 
            this.textBox_DT.Location = new System.Drawing.Point(345, 160);
            this.textBox_DT.Name = "textBox_DT";
            this.textBox_DT.Size = new System.Drawing.Size(100, 22);
            this.textBox_DT.TabIndex = 13;
            this.textBox_DT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DT_KeyDown);
            // 
            // textBox_PHUCAP
            // 
            this.textBox_PHUCAP.Location = new System.Drawing.Point(345, 102);
            this.textBox_PHUCAP.Name = "textBox_PHUCAP";
            this.textBox_PHUCAP.Size = new System.Drawing.Size(100, 22);
            this.textBox_PHUCAP.TabIndex = 12;
            this.textBox_PHUCAP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PHUCAP_KeyDown);
            // 
            // textBox_NGSINH
            // 
            this.textBox_NGSINH.Location = new System.Drawing.Point(345, 48);
            this.textBox_NGSINH.Name = "textBox_NGSINH";
            this.textBox_NGSINH.Size = new System.Drawing.Size(100, 22);
            this.textBox_NGSINH.TabIndex = 11;
            this.textBox_NGSINH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NGSINH_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phụ cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh";
            // 
            // textBox_PHAI
            // 
            this.textBox_PHAI.Location = new System.Drawing.Point(132, 160);
            this.textBox_PHAI.Name = "textBox_PHAI";
            this.textBox_PHAI.Size = new System.Drawing.Size(100, 22);
            this.textBox_PHAI.TabIndex = 7;
            this.textBox_PHAI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PHAI_KeyDown);
            // 
            // textBox_HOTEN
            // 
            this.textBox_HOTEN.Location = new System.Drawing.Point(132, 102);
            this.textBox_HOTEN.Name = "textBox_HOTEN";
            this.textBox_HOTEN.Size = new System.Drawing.Size(100, 22);
            this.textBox_HOTEN.TabIndex = 6;
            this.textBox_HOTEN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_HOTEN_KeyDown);
            // 
            // textBox_MANV
            // 
            this.textBox_MANV.Location = new System.Drawing.Point(132, 48);
            this.textBox_MANV.Name = "textBox_MANV";
            this.textBox_MANV.Size = new System.Drawing.Size(100, 22);
            this.textBox_MANV.TabIndex = 5;
            this.textBox_MANV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MANV_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // ThongTinNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongTinNhanSu";
            this.Text = "Thông tin nhân sự";
            this.Load += new System.EventHandler(this.ThongTinNhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_PHAI;
        private System.Windows.Forms.TextBox textBox_HOTEN;
        private System.Windows.Forms.TextBox textBox_MANV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DT;
        private System.Windows.Forms.TextBox textBox_PHUCAP;
        private System.Windows.Forms.TextBox textBox_NGSINH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_MADV;
        private System.Windows.Forms.TextBox textBox_VAITRO;
        private System.Windows.Forms.Button button_LamMoi;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
    }
}