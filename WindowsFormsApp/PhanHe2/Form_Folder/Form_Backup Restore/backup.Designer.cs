namespace WindowsFormsApp
{
    partial class Backup
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
            this.btnManualBackup = new System.Windows.Forms.Button();
            this.btnAutoBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManualBackup
            // 
            this.btnManualBackup.Location = new System.Drawing.Point(140, 115);
            this.btnManualBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManualBackup.Name = "btnManualBackup";
            this.btnManualBackup.Size = new System.Drawing.Size(144, 54);
            this.btnManualBackup.TabIndex = 0;
            this.btnManualBackup.Text = "Thủ công";
            this.btnManualBackup.UseVisualStyleBackColor = true;
            this.btnManualBackup.Click += new System.EventHandler(this.btnManualBackup_Click);
            // 
            // btnAutoBackup
            // 
            this.btnAutoBackup.Location = new System.Drawing.Point(416, 115);
            this.btnAutoBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutoBackup.Name = "btnAutoBackup";
            this.btnAutoBackup.Size = new System.Drawing.Size(144, 54);
            this.btnAutoBackup.TabIndex = 1;
            this.btnAutoBackup.Text = "Tự động";
            this.btnAutoBackup.UseVisualStyleBackColor = true;
            this.btnAutoBackup.Click += new System.EventHandler(this.btnAutoBackup_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnAutoBackup);
            this.Controls.Add(this.btnManualBackup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Backup";
            this.Text = "Màn hình thực hiện backup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManualBackup;
        private System.Windows.Forms.Button btnAutoBackup;
    }
}