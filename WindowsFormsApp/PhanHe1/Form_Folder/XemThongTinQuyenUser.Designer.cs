namespace WindowsFormsApp
{
    partial class XemThongTinQuyenUser
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
            this.dataGridView_XemQuyen = new System.Windows.Forms.DataGridView();
            this.dataGridView_XemRole = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XemQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XemRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_XemQuyen
            // 
            this.dataGridView_XemQuyen.AllowUserToAddRows = false;
            this.dataGridView_XemQuyen.AllowUserToDeleteRows = false;
            this.dataGridView_XemQuyen.AllowUserToResizeColumns = false;
            this.dataGridView_XemQuyen.AllowUserToResizeRows = false;
            this.dataGridView_XemQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_XemQuyen.Location = new System.Drawing.Point(-2, 11);
            this.dataGridView_XemQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_XemQuyen.Name = "dataGridView_XemQuyen";
            this.dataGridView_XemQuyen.ReadOnly = true;
            this.dataGridView_XemQuyen.RowHeadersWidth = 51;
            this.dataGridView_XemQuyen.RowTemplate.Height = 24;
            this.dataGridView_XemQuyen.Size = new System.Drawing.Size(602, 178);
            this.dataGridView_XemQuyen.TabIndex = 45;
            // 
            // dataGridView_XemRole
            // 
            this.dataGridView_XemRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_XemRole.Location = new System.Drawing.Point(-2, 194);
            this.dataGridView_XemRole.Name = "dataGridView_XemRole";
            this.dataGridView_XemRole.Size = new System.Drawing.Size(602, 172);
            this.dataGridView_XemRole.TabIndex = 46;
            // 
            // XemThongTinQuyenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView_XemRole);
            this.Controls.Add(this.dataGridView_XemQuyen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "XemThongTinQuyenUser";
            this.Text = "XemThongTinQuyenUser";
            this.Load += new System.EventHandler(this.XemThongTinQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XemQuyen)).EndInit();
            this.Load += new System.EventHandler(this.XemThongTinRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XemRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_XemQuyen;
        private System.Windows.Forms.DataGridView dataGridView_XemRole;
    }
}