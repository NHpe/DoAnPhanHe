namespace WindowsFormsApp
{
    partial class ThongTinDangKyGiangVien
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
            this.groupBox_CapNhatDiem = new System.Windows.Forms.GroupBox();
            this.textBox_DTK = new System.Windows.Forms.TextBox();
            this.textBox_DCK = new System.Windows.Forms.TextBox();
            this.label_DTK = new System.Windows.Forms.Label();
            this.label_DCK = new System.Windows.Forms.Label();
            this.textBox_DTH = new System.Windows.Forms.TextBox();
            this.textBox_DQT = new System.Windows.Forms.TextBox();
            this.label_DTH = new System.Windows.Forms.Label();
            this.label_DQT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_CapNhatDiem.SuspendLayout();
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
            // groupBox_CapNhatDiem
            // 
            this.groupBox_CapNhatDiem.Controls.Add(this.textBox_DTK);
            this.groupBox_CapNhatDiem.Controls.Add(this.textBox_DCK);
            this.groupBox_CapNhatDiem.Controls.Add(this.label_DTK);
            this.groupBox_CapNhatDiem.Controls.Add(this.label_DCK);
            this.groupBox_CapNhatDiem.Controls.Add(this.textBox_DTH);
            this.groupBox_CapNhatDiem.Controls.Add(this.textBox_DQT);
            this.groupBox_CapNhatDiem.Controls.Add(this.label_DTH);
            this.groupBox_CapNhatDiem.Controls.Add(this.label_DQT);
            this.groupBox_CapNhatDiem.Location = new System.Drawing.Point(0, 293);
            this.groupBox_CapNhatDiem.Name = "groupBox_CapNhatDiem";
            this.groupBox_CapNhatDiem.Size = new System.Drawing.Size(801, 129);
            this.groupBox_CapNhatDiem.TabIndex = 1;
            this.groupBox_CapNhatDiem.TabStop = false;
            this.groupBox_CapNhatDiem.Text = "Sinh viên";
            // 
            // textBox_DTK
            // 
            this.textBox_DTK.Location = new System.Drawing.Point(456, 84);
            this.textBox_DTK.Name = "textBox_DTK";
            this.textBox_DTK.Size = new System.Drawing.Size(100, 22);
            this.textBox_DTK.TabIndex = 7;
            this.textBox_DTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DTK_KeyDown);
            // 
            // textBox_DCK
            // 
            this.textBox_DCK.Location = new System.Drawing.Point(456, 36);
            this.textBox_DCK.Name = "textBox_DCK";
            this.textBox_DCK.Size = new System.Drawing.Size(100, 22);
            this.textBox_DCK.TabIndex = 6;
            this.textBox_DCK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DCK_KeyDown);
            // 
            // label_DTK
            // 
            this.label_DTK.AutoSize = true;
            this.label_DTK.Location = new System.Drawing.Point(333, 84);
            this.label_DTK.Name = "label_DTK";
            this.label_DTK.Size = new System.Drawing.Size(88, 16);
            this.label_DTK.TabIndex = 5;
            this.label_DTK.Text = "Điểm tổng kết";
            // 
            // label_DCK
            // 
            this.label_DCK.AutoSize = true;
            this.label_DCK.Location = new System.Drawing.Point(333, 36);
            this.label_DCK.Name = "label_DCK";
            this.label_DCK.Size = new System.Drawing.Size(83, 16);
            this.label_DCK.TabIndex = 4;
            this.label_DCK.Text = "Điểm cuối kỳ";
            // 
            // textBox_DTH
            // 
            this.textBox_DTH.Location = new System.Drawing.Point(183, 84);
            this.textBox_DTH.Name = "textBox_DTH";
            this.textBox_DTH.Size = new System.Drawing.Size(100, 22);
            this.textBox_DTH.TabIndex = 3;
            this.textBox_DTH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DTH_KeyDown);
            // 
            // textBox_DQT
            // 
            this.textBox_DQT.Location = new System.Drawing.Point(183, 36);
            this.textBox_DQT.Name = "textBox_DQT";
            this.textBox_DQT.Size = new System.Drawing.Size(100, 22);
            this.textBox_DQT.TabIndex = 2;
            this.textBox_DQT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DQT_KeyDown);
            // 
            // label_DTH
            // 
            this.label_DTH.AutoSize = true;
            this.label_DTH.Location = new System.Drawing.Point(53, 84);
            this.label_DTH.Name = "label_DTH";
            this.label_DTH.Size = new System.Drawing.Size(97, 16);
            this.label_DTH.TabIndex = 1;
            this.label_DTH.Text = "Điểm thực hành";
            // 
            // label_DQT
            // 
            this.label_DQT.AutoSize = true;
            this.label_DQT.Location = new System.Drawing.Point(53, 36);
            this.label_DQT.Name = "label_DQT";
            this.label_DQT.Size = new System.Drawing.Size(91, 16);
            this.label_DQT.TabIndex = 0;
            this.label_DQT.Text = "Điểm quá trình";
            // 
            // ThongTinDangKyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_CapNhatDiem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongTinDangKyGiangVien";
            this.Text = "Thông tin đăng ký";
            this.Load += new System.EventHandler(this.ThongTinDangKyGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_CapNhatDiem.ResumeLayout(false);
            this.groupBox_CapNhatDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_CapNhatDiem;
        private System.Windows.Forms.TextBox textBox_DTK;
        private System.Windows.Forms.TextBox textBox_DCK;
        private System.Windows.Forms.Label label_DTK;
        private System.Windows.Forms.Label label_DCK;
        private System.Windows.Forms.TextBox textBox_DTH;
        private System.Windows.Forms.TextBox textBox_DQT;
        private System.Windows.Forms.Label label_DTH;
        private System.Windows.Forms.Label label_DQT;
    }
}