namespace WindowsFormsApp
{
    partial class PhanHe2
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
            this.button_CapQuyenTryCap = new System.Windows.Forms.Button();
            this.button_Audit = new System.Windows.Forms.Button();
            this.button_ThongBao = new System.Windows.Forms.Button();
            this.button_Backup = new System.Windows.Forms.Button();
            this.button_Restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CapQuyenTryCap
            // 
            this.button_CapQuyenTryCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CapQuyenTryCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapQuyenTryCap.Location = new System.Drawing.Point(232, 62);
            this.button_CapQuyenTryCap.Name = "button_CapQuyenTryCap";
            this.button_CapQuyenTryCap.Size = new System.Drawing.Size(362, 50);
            this.button_CapQuyenTryCap.TabIndex = 0;
            this.button_CapQuyenTryCap.Text = "Cấp quyền truy cập cho người dùng";
            this.button_CapQuyenTryCap.UseVisualStyleBackColor = true;
            this.button_CapQuyenTryCap.Click += new System.EventHandler(this.button_CapQuyenTryCap_Click);
            // 
            // button_Audit
            // 
            this.button_Audit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Audit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Audit.Location = new System.Drawing.Point(232, 212);
            this.button_Audit.Name = "button_Audit";
            this.button_Audit.Size = new System.Drawing.Size(362, 50);
            this.button_Audit.TabIndex = 1;
            this.button_Audit.Text = "Xem nhật ký Audit";
            this.button_Audit.UseVisualStyleBackColor = true;
            this.button_Audit.Click += new System.EventHandler(this.button_Audit_Click);
            // 
            // button_ThongBao
            // 
            this.button_ThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongBao.Location = new System.Drawing.Point(232, 138);
            this.button_ThongBao.Name = "button_ThongBao";
            this.button_ThongBao.Size = new System.Drawing.Size(362, 50);
            this.button_ThongBao.TabIndex = 2;
            this.button_ThongBao.Text = "Xem thông báo";
            this.button_ThongBao.UseVisualStyleBackColor = true;
            this.button_ThongBao.Click += new System.EventHandler(this.button_ThongBao_Click);
            // 
            // button_Backup
            // 
            this.button_Backup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Backup.Location = new System.Drawing.Point(232, 291);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(362, 50);
            this.button_Backup.TabIndex = 3;
            this.button_Backup.Text = "Backup dữ liệu";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // button_Restore
            // 
            this.button_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Restore.Location = new System.Drawing.Point(232, 371);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(362, 50);
            this.button_Restore.TabIndex = 4;
            this.button_Restore.Text = "Restore dữ liệu";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // PhanHe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Restore);
            this.Controls.Add(this.button_Backup);
            this.Controls.Add(this.button_ThongBao);
            this.Controls.Add(this.button_Audit);
            this.Controls.Add(this.button_CapQuyenTryCap);
            this.Name = "PhanHe2";
            this.Text = "Màn hình yêu cầu của phân hệ 2";
            this.Load += new System.EventHandler(this.PhanHe2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CapQuyenTryCap;
        private System.Windows.Forms.Button button_Audit;
        private System.Windows.Forms.Button button_ThongBao;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.Button button_Restore;
    }
}