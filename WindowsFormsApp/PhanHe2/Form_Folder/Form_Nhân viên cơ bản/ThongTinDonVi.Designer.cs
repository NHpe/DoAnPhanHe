namespace WindowsFormsApp
{
    partial class ThongTinDonVi
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
            this.textBox_TRGDV = new System.Windows.Forms.TextBox();
            this.textBox_TENDV = new System.Windows.Forms.TextBox();
            this.textBox_MADV = new System.Windows.Forms.TextBox();
            this.label_TRGDV = new System.Windows.Forms.Label();
            this.label_TENDV = new System.Windows.Forms.Label();
            this.label_MADV = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.textBox_TRGDV);
            this.groupBox1.Controls.Add(this.textBox_TENDV);
            this.groupBox1.Controls.Add(this.textBox_MADV);
            this.groupBox1.Controls.Add(this.label_TRGDV);
            this.groupBox1.Controls.Add(this.label_TENDV);
            this.groupBox1.Controls.Add(this.label_MADV);
            this.groupBox1.Location = new System.Drawing.Point(0, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hoặc sửa đơn vị";
            // 
            // button_LamMoi
            // 
            this.button_LamMoi.Location = new System.Drawing.Point(436, 132);
            this.button_LamMoi.Name = "button_LamMoi";
            this.button_LamMoi.Size = new System.Drawing.Size(110, 41);
            this.button_LamMoi.TabIndex = 9;
            this.button_LamMoi.Text = "Làm mới";
            this.button_LamMoi.UseVisualStyleBackColor = true;
            this.button_LamMoi.Click += new System.EventHandler(this.button_LamMoi_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(436, 54);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(110, 41);
            this.button_Them.TabIndex = 8;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_TRGDV
            // 
            this.textBox_TRGDV.Location = new System.Drawing.Point(218, 151);
            this.textBox_TRGDV.Name = "textBox_TRGDV";
            this.textBox_TRGDV.Size = new System.Drawing.Size(100, 22);
            this.textBox_TRGDV.TabIndex = 7;
            this.textBox_TRGDV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TRGDV_KeyDown);
            // 
            // textBox_TENDV
            // 
            this.textBox_TENDV.Location = new System.Drawing.Point(218, 104);
            this.textBox_TENDV.Name = "textBox_TENDV";
            this.textBox_TENDV.Size = new System.Drawing.Size(100, 22);
            this.textBox_TENDV.TabIndex = 6;
            this.textBox_TENDV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TENDV_KeyDown);
            // 
            // textBox_MADV
            // 
            this.textBox_MADV.Location = new System.Drawing.Point(218, 54);
            this.textBox_MADV.Name = "textBox_MADV";
            this.textBox_MADV.Size = new System.Drawing.Size(100, 22);
            this.textBox_MADV.TabIndex = 5;
            this.textBox_MADV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MADV_KeyDown);
            // 
            // label_TRGDV
            // 
            this.label_TRGDV.AutoSize = true;
            this.label_TRGDV.Location = new System.Drawing.Point(71, 151);
            this.label_TRGDV.Name = "label_TRGDV";
            this.label_TRGDV.Size = new System.Drawing.Size(89, 16);
            this.label_TRGDV.TabIndex = 4;
            this.label_TRGDV.Text = "Trưởng đơn vị";
            // 
            // label_TENDV
            // 
            this.label_TENDV.AutoSize = true;
            this.label_TENDV.Location = new System.Drawing.Point(71, 104);
            this.label_TENDV.Name = "label_TENDV";
            this.label_TENDV.Size = new System.Drawing.Size(70, 16);
            this.label_TENDV.TabIndex = 3;
            this.label_TENDV.Text = "Tên đơn vị";
            // 
            // label_MADV
            // 
            this.label_MADV.AutoSize = true;
            this.label_MADV.Location = new System.Drawing.Point(71, 54);
            this.label_MADV.Name = "label_MADV";
            this.label_MADV.Size = new System.Drawing.Size(65, 16);
            this.label_MADV.TabIndex = 2;
            this.label_MADV.Text = "Mã đơn vị";
            // 
            // ThongTinDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongTinDonVi";
            this.Text = "Thông tin đơn vị";
            this.Load += new System.EventHandler(this.ThongTinDonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_TRGDV;
        private System.Windows.Forms.Label label_TENDV;
        private System.Windows.Forms.Label label_MADV;
        private System.Windows.Forms.TextBox textBox_MADV;
        private System.Windows.Forms.Button button_LamMoi;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_TRGDV;
        private System.Windows.Forms.TextBox textBox_TENDV;
    }
}