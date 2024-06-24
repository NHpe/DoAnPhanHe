namespace WindowsFormsApp
{
    partial class ThongTinKeHoachMo
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
            this.textBox_MACT = new System.Windows.Forms.TextBox();
            this.textBox_NAM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_HK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MAHP = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.button_LamMoi);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_MACT);
            this.groupBox1.Controls.Add(this.textBox_NAM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_HK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_MAHP);
            this.groupBox1.Location = new System.Drawing.Point(0, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(644, 114);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(90, 37);
            this.button_LamMoi.TabIndex = 9;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(644, 53);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(90, 37);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_MACT
            // 
            this.textBox_MACT.Location = new System.Drawing.Point(477, 111);
            this.textBox_MACT.Name = "textBox_MACT";
            this.textBox_MACT.Size = new System.Drawing.Size(100, 22);
            this.textBox_MACT.TabIndex = 7;
            this.textBox_MACT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MACT_KeyDown);
            // 
            // textBox_NAM
            // 
            this.textBox_NAM.Location = new System.Drawing.Point(477, 53);
            this.textBox_NAM.Name = "textBox_NAM";
            this.textBox_NAM.Size = new System.Drawing.Size(100, 22);
            this.textBox_NAM.TabIndex = 6;
            this.textBox_NAM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NAM_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã chương trình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm";
            // 
            // textBox_HK
            // 
            this.textBox_HK.Location = new System.Drawing.Point(182, 114);
            this.textBox_HK.Name = "textBox_HK";
            this.textBox_HK.Size = new System.Drawing.Size(100, 22);
            this.textBox_HK.TabIndex = 3;
            this.textBox_HK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_HK_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học phần";
            // 
            // textBox_MAHP
            // 
            this.textBox_MAHP.Location = new System.Drawing.Point(182, 53);
            this.textBox_MAHP.Name = "textBox_MAHP";
            this.textBox_MAHP.Size = new System.Drawing.Size(100, 22);
            this.textBox_MAHP.TabIndex = 0;
            this.textBox_MAHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MAHP_KeyDown);
            // 
            // ThongTinKeHoachMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongTinKeHoachMo";
            this.Text = "Thông tin kế hoạch mở";
            this.Load += new System.EventHandler(this.ThongTinKhoaHocMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MAHP;
        private System.Windows.Forms.Button button_LamMoi;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_MACT;
        private System.Windows.Forms.TextBox textBox_NAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_HK;
        private System.Windows.Forms.Label label2;
    }
}