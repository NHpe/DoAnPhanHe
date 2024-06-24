namespace WindowsFormsApp
{
    partial class PhanCongTruongDonVi
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
            this.buttmớ_LamMoi = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_MACT = new System.Windows.Forms.TextBox();
            this.textBox_NAM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_HK = new System.Windows.Forms.TextBox();
            this.textBox_MAHP = new System.Windows.Forms.TextBox();
            this.textBox_MAGV = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.buttmớ_LamMoi);
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_MACT);
            this.groupBox1.Controls.Add(this.textBox_NAM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_HK);
            this.groupBox1.Controls.Add(this.textBox_MAHP);
            this.groupBox1.Controls.Add(this.textBox_MAGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác với dữ liệu phân công của đơn vị đang quản lý";
            // 
            // buttmớ_LamMoi
            // 
            this.buttmớ_LamMoi.Location = new System.Drawing.Point(659, 150);
            this.buttmớ_LamMoi.Name = "buttmớ_LamMoi";
            this.buttmớ_LamMoi.Size = new System.Drawing.Size(97, 29);
            this.buttmớ_LamMoi.TabIndex = 12;
            this.buttmớ_LamMoi.Text = "Làm mới";
            this.buttmớ_LamMoi.UseVisualStyleBackColor = true;
            this.buttmớ_LamMoi.Click += new System.EventHandler(this.buttmớ_LamMoi_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(659, 95);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(97, 29);
            this.button_Xoa.TabIndex = 11;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(659, 45);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(97, 29);
            this.button_Them.TabIndex = 10;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_MACT
            // 
            this.textBox_MACT.Location = new System.Drawing.Point(481, 98);
            this.textBox_MACT.Name = "textBox_MACT";
            this.textBox_MACT.Size = new System.Drawing.Size(100, 22);
            this.textBox_MACT.TabIndex = 9;
            this.textBox_MACT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MACT_KeyDown);
            // 
            // textBox_NAM
            // 
            this.textBox_NAM.Location = new System.Drawing.Point(481, 52);
            this.textBox_NAM.Name = "textBox_NAM";
            this.textBox_NAM.Size = new System.Drawing.Size(100, 22);
            this.textBox_NAM.TabIndex = 8;
            this.textBox_NAM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NAM_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã chương trình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm";
            // 
            // textBox_HK
            // 
            this.textBox_HK.Location = new System.Drawing.Point(189, 150);
            this.textBox_HK.Name = "textBox_HK";
            this.textBox_HK.Size = new System.Drawing.Size(100, 22);
            this.textBox_HK.TabIndex = 5;
            this.textBox_HK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_HK_KeyDown);
            // 
            // textBox_MAHP
            // 
            this.textBox_MAHP.Location = new System.Drawing.Point(189, 101);
            this.textBox_MAHP.Name = "textBox_MAHP";
            this.textBox_MAHP.Size = new System.Drawing.Size(100, 22);
            this.textBox_MAHP.TabIndex = 4;
            this.textBox_MAHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MAHP_KeyDown);
            // 
            // textBox_MAGV
            // 
            this.textBox_MAGV.Location = new System.Drawing.Point(189, 52);
            this.textBox_MAGV.Name = "textBox_MAGV";
            this.textBox_MAGV.Size = new System.Drawing.Size(100, 22);
            this.textBox_MAGV.TabIndex = 3;
            this.textBox_MAGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MAGV_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên";
            // 
            // PhanCongTruongDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PhanCongTruongDonVi";
            this.Text = "Thông tin phân công đơn vị đang quản lý";
            this.Load += new System.EventHandler(this.PhanCongTruongDonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_HK;
        private System.Windows.Forms.TextBox textBox_MAHP;
        private System.Windows.Forms.TextBox textBox_MAGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MACT;
        private System.Windows.Forms.TextBox textBox_NAM;
        private System.Windows.Forms.Button buttmớ_LamMoi;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
    }
}