namespace WindowsFormsApp
{
    partial class ThongTinHocPhan
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
            this.button__LamMoi = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_MADV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SOSVTD = new System.Windows.Forms.TextBox();
            this.textBox_STTH = new System.Windows.Forms.TextBox();
            this.textBox_STLT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SOTC = new System.Windows.Forms.TextBox();
            this.textBox_TENHP = new System.Windows.Forms.TextBox();
            this.textBox_MAHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.groupBox1.Controls.Add(this.button__LamMoi);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_MADV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_SOSVTD);
            this.groupBox1.Controls.Add(this.textBox_STTH);
            this.groupBox1.Controls.Add(this.textBox_STLT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_SOTC);
            this.groupBox1.Controls.Add(this.textBox_TENHP);
            this.groupBox1.Controls.Add(this.textBox_MAHP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hoặc sửa học phần";
            // 
            // button__LamMoi
            // 
            this.button__LamMoi.Location = new System.Drawing.Point(627, 139);
            this.button__LamMoi.Name = "button__LamMoi";
            this.button__LamMoi.Size = new System.Drawing.Size(93, 23);
            this.button__LamMoi.TabIndex = 15;
            this.button__LamMoi.Text = "Làm mới";
            this.button__LamMoi.UseVisualStyleBackColor = true;
            this.button__LamMoi.Click += new System.EventHandler(this.button__LamMoi_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(627, 96);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(93, 23);
            this.button_Them.TabIndex = 14;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_MADV
            // 
            this.textBox_MADV.Location = new System.Drawing.Point(666, 47);
            this.textBox_MADV.Name = "textBox_MADV";
            this.textBox_MADV.Size = new System.Drawing.Size(112, 22);
            this.textBox_MADV.TabIndex = 13;
            this.textBox_MADV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MADV_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã đơn vị";
            // 
            // textBox_SOSVTD
            // 
            this.textBox_SOSVTD.Location = new System.Drawing.Point(444, 140);
            this.textBox_SOSVTD.Name = "textBox_SOSVTD";
            this.textBox_SOSVTD.Size = new System.Drawing.Size(100, 22);
            this.textBox_SOSVTD.TabIndex = 11;
            this.textBox_SOSVTD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SOSVTD_KeyDown);
            // 
            // textBox_STTH
            // 
            this.textBox_STTH.Location = new System.Drawing.Point(444, 97);
            this.textBox_STTH.Name = "textBox_STTH";
            this.textBox_STTH.Size = new System.Drawing.Size(100, 22);
            this.textBox_STTH.TabIndex = 10;
            this.textBox_STTH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_STTH_KeyDown);
            // 
            // textBox_STLT
            // 
            this.textBox_STLT.Location = new System.Drawing.Point(444, 47);
            this.textBox_STLT.Name = "textBox_STLT";
            this.textBox_STLT.Size = new System.Drawing.Size(100, 22);
            this.textBox_STLT.TabIndex = 9;
            this.textBox_STLT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_STLT_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số sinh viên tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiết thực hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiết lý thuyết";
            // 
            // textBox_SOTC
            // 
            this.textBox_SOTC.Location = new System.Drawing.Point(164, 140);
            this.textBox_SOTC.Name = "textBox_SOTC";
            this.textBox_SOTC.Size = new System.Drawing.Size(100, 22);
            this.textBox_SOTC.TabIndex = 5;
            this.textBox_SOTC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SOTC_KeyDown);
            // 
            // textBox_TENHP
            // 
            this.textBox_TENHP.Location = new System.Drawing.Point(164, 94);
            this.textBox_TENHP.Name = "textBox_TENHP";
            this.textBox_TENHP.Size = new System.Drawing.Size(100, 22);
            this.textBox_TENHP.TabIndex = 4;
            this.textBox_TENHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TENHP_KeyDown);
            // 
            // textBox_MAHP
            // 
            this.textBox_MAHP.Location = new System.Drawing.Point(164, 47);
            this.textBox_MAHP.Name = "textBox_MAHP";
            this.textBox_MAHP.Size = new System.Drawing.Size(100, 22);
            this.textBox_MAHP.TabIndex = 3;
            this.textBox_MAHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MAHP_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần";
            // 
            // ThongTinHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongTinHocPhan";
            this.Text = "Thông tin học phần";
            this.Load += new System.EventHandler(this.ThongTinHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MAHP;
        private System.Windows.Forms.TextBox textBox_SOTC;
        private System.Windows.Forms.TextBox textBox_TENHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MADV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SOSVTD;
        private System.Windows.Forms.TextBox textBox_STTH;
        private System.Windows.Forms.TextBox textBox_STLT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button__LamMoi;
        private System.Windows.Forms.Button button_Them;
    }
}