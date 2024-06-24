namespace WindowsFormsApp
{
    partial class Audit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.tblAudit = new System.Windows.Forms.DataGridView();
            this.groupBoxSTD = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbbStandard = new System.Windows.Forms.ComboBox();
            this.groupBoxFGA = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAudit)).BeginInit();
            this.groupBoxSTD.SuspendLayout();
            this.groupBoxFGA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblTableTitle);
            this.panel1.Controls.Add(this.tblAudit);
            this.panel1.Location = new System.Drawing.Point(176, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 334);
            this.panel1.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(4, 311);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(81, 17);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Trạng thái: ";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTitle.Location = new System.Drawing.Point(5, 4);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(156, 31);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "Bảng Audit";
            this.lblTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblAudit
            // 
            this.tblAudit.AllowUserToDeleteRows = false;
            this.tblAudit.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblAudit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAudit.Location = new System.Drawing.Point(0, 38);
            this.tblAudit.Name = "tblAudit";
            this.tblAudit.ReadOnly = true;
            this.tblAudit.Size = new System.Drawing.Size(580, 269);
            this.tblAudit.TabIndex = 0;
            // 
            // groupBoxSTD
            // 
            this.groupBoxSTD.Controls.Add(this.label4);
            this.groupBoxSTD.Controls.Add(this.btnAll);
            this.groupBoxSTD.Controls.Add(this.btnFilter);
            this.groupBoxSTD.Controls.Add(this.cbbStandard);
            this.groupBoxSTD.Location = new System.Drawing.Point(1, 120);
            this.groupBoxSTD.Name = "groupBoxSTD";
            this.groupBoxSTD.Size = new System.Drawing.Size(175, 152);
            this.groupBoxSTD.TabIndex = 1;
            this.groupBoxSTD.TabStop = false;
            this.groupBoxSTD.Text = "Standard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Theo dõi hành động ghi trên các\r\nbảng";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Salmon;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Location = new System.Drawing.Point(7, 78);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(162, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "Xem tất cả bảng";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Salmon;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(7, 48);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(162, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Chỉ xem bảng này";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbbStandard
            // 
            this.cbbStandard.FormattingEnabled = true;
            this.cbbStandard.Location = new System.Drawing.Point(7, 20);
            this.cbbStandard.Name = "cbbStandard";
            this.cbbStandard.Size = new System.Drawing.Size(162, 21);
            this.cbbStandard.TabIndex = 0;
            // 
            // groupBoxFGA
            // 
            this.groupBoxFGA.Controls.Add(this.label5);
            this.groupBoxFGA.Controls.Add(this.label3);
            this.groupBoxFGA.Controls.Add(this.btnOption2);
            this.groupBoxFGA.Controls.Add(this.btnOption1);
            this.groupBoxFGA.Location = new System.Drawing.Point(1, 278);
            this.groupBoxFGA.Name = "groupBoxFGA";
            this.groupBoxFGA.Size = new System.Drawing.Size(175, 171);
            this.groupBoxFGA.TabIndex = 2;
            this.groupBoxFGA.TabStop = false;
            this.groupBoxFGA.Text = "FGA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Theo dõi hành vi tra cứu cột\r\nPHUCAP của nhân viên khác";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Theo dõi hành vi cập nhật điểm\r\ntrên bảng DANGKY đối với các \r\nngười không là giả" +
    "ng viên";
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.Salmon;
            this.btnOption2.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnOption2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Location = new System.Drawing.Point(7, 94);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(162, 23);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Text = "Chính sách 2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.Salmon;
            this.btnOption1.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnOption1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Location = new System.Drawing.Point(7, 20);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(162, 23);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Text = "Chính sách 1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(211, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tra bảng Audit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFGA);
            this.Controls.Add(this.groupBoxSTD);
            this.Controls.Add(this.panel1);
            this.Name = "Audit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NhatKyCSDL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAudit)).EndInit();
            this.groupBoxSTD.ResumeLayout(false);
            this.groupBoxSTD.PerformLayout();
            this.groupBoxFGA.ResumeLayout(false);
            this.groupBoxFGA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tblAudit;
        private System.Windows.Forms.GroupBox groupBoxSTD;
        private System.Windows.Forms.GroupBox groupBoxFGA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.ComboBox cbbStandard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
    }
}