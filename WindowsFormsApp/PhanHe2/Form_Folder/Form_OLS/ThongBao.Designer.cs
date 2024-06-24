namespace WindowsFormsApp
{
    partial class ThongBao
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
            this.label_thongbao = new System.Windows.Forms.Label();
            this.Thong_Bao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thong_Bao});
            this.dataGridView1.Location = new System.Drawing.Point(2, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_thongbao
            // 
            this.label_thongbao.AutoSize = true;
            this.label_thongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label_thongbao.Location = new System.Drawing.Point(328, 7);
            this.label_thongbao.Name = "label_thongbao";
            this.label_thongbao.Size = new System.Drawing.Size(184, 39);
            this.label_thongbao.TabIndex = 1;
            this.label_thongbao.Text = "Thông Báo";
            // 
            // Thong_Bao
            // 
            this.Thong_Bao.HeaderText = "Thông Báo";
            this.Thong_Bao.Name = "Thong_Bao";
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_thongbao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongBao";
            this.Text = "ThongBao";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_thongbao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thong_Bao;
    }
}