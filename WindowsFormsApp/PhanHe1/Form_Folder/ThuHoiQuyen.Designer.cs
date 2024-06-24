namespace WindowsFormsApp
{
    partial class ThuHoiQuyen
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
            this.label_ThuHoiQuyen = new System.Windows.Forms.Label();
            this.revokeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbChonBang = new System.Windows.Forms.ComboBox();
            this.cbChonView = new System.Windows.Forms.ComboBox();
            this.cbChonSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.cbQuyenTab = new System.Windows.Forms.ComboBox();
            this.cbQuyenView = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ThuHoiQuyen
            // 
            this.label_ThuHoiQuyen.AutoSize = true;
            this.label_ThuHoiQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThuHoiQuyen.Location = new System.Drawing.Point(319, 36);
            this.label_ThuHoiQuyen.Name = "label_ThuHoiQuyen";
            this.label_ThuHoiQuyen.Size = new System.Drawing.Size(145, 25);
            this.label_ThuHoiQuyen.TabIndex = 49;
            this.label_ThuHoiQuyen.Text = "Thu Hồi Quyền";
            // 
            // revokeButton
            // 
            this.revokeButton.Enabled = false;
            this.revokeButton.Location = new System.Drawing.Point(336, 380);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(109, 31);
            this.revokeButton.TabIndex = 50;
            this.revokeButton.Text = "Thu hồi";
            this.revokeButton.UseVisualStyleBackColor = true;
            this.revokeButton.Click += new System.EventHandler(this.revokeButton_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 51;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(175, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 20);
            this.radioButton1.TabIndex = 53;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Người dùng";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(521, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 20);
            this.radioButton2.TabIndex = 54;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vai trò";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbChonBang
            // 
            this.cbChonBang.Enabled = false;
            this.cbChonBang.FormattingEnabled = true;
            this.cbChonBang.Items.AddRange(new object[] {
            "Tất cả các quyền",
            "Quyền SELECT",
            "Quyền UPDATE",
            "Quyền INSERT",
            "Quyền DELETE"});
            this.cbChonBang.Location = new System.Drawing.Point(304, 253);
            this.cbChonBang.Name = "cbChonBang";
            this.cbChonBang.Size = new System.Drawing.Size(178, 24);
            this.cbChonBang.TabIndex = 55;
            this.cbChonBang.SelectionChangeCommitted += new System.EventHandler(this.cbChonBang_SelectedIndexChanged);
            // 
            // cbChonView
            // 
            this.cbChonView.Enabled = false;
            this.cbChonView.FormattingEnabled = true;
            this.cbChonView.Items.AddRange(new object[] {
            "Tất cả các quyền",
            "Quyền SELECT",
            "Quyền UPDATE",
            "Quyền INSERT",
            "Quyền DELETE"});
            this.cbChonView.Location = new System.Drawing.Point(304, 280);
            this.cbChonView.Name = "cbChonView";
            this.cbChonView.Size = new System.Drawing.Size(178, 24);
            this.cbChonView.TabIndex = 56;
            // 
            // cbChonSP
            // 
            this.cbChonSP.Enabled = false;
            this.cbChonSP.FormattingEnabled = true;
            this.cbChonSP.Items.AddRange(new object[] {
            "Tất cả các quyền",
            "Quyền SELECT",
            "Quyền UPDATE",
            "Quyền INSERT",
            "Quyền DELETE"});
            this.cbChonSP.Location = new System.Drawing.Point(304, 306);
            this.cbChonSP.Name = "cbChonSP";
            this.cbChonSP.Size = new System.Drawing.Size(178, 24);
            this.cbChonSP.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Loai Quyen";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(125, 257);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 20);
            this.radioButton3.TabIndex = 62;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Table";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(125, 284);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 20);
            this.radioButton4.TabIndex = 63;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "View";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(125, 310);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(91, 20);
            this.radioButton5.TabIndex = 64;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Procedure";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // cbQuyenTab
            // 
            this.cbQuyenTab.Enabled = false;
            this.cbQuyenTab.FormattingEnabled = true;
            this.cbQuyenTab.Location = new System.Drawing.Point(547, 253);
            this.cbQuyenTab.Name = "cbQuyenTab";
            this.cbQuyenTab.Size = new System.Drawing.Size(142, 24);
            this.cbQuyenTab.TabIndex = 65;
            this.cbQuyenTab.SelectionChangeCommitted += new System.EventHandler(this.cbQuyenTab_SelectedIndexChanged);
            // 
            // cbQuyenView
            // 
            this.cbQuyenView.Enabled = false;
            this.cbQuyenView.FormattingEnabled = true;
            this.cbQuyenView.Location = new System.Drawing.Point(547, 280);
            this.cbQuyenView.Name = "cbQuyenView";
            this.cbQuyenView.Size = new System.Drawing.Size(142, 24);
            this.cbQuyenView.TabIndex = 66;
            // 
            // findButton
            // 
            this.findButton.Enabled = false;
            this.findButton.Location = new System.Drawing.Point(336, 175);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(109, 31);
            this.findButton.TabIndex = 67;
            this.findButton.Text = "Tìm kiếm";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // ThuHoiQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.cbQuyenView);
            this.Controls.Add(this.cbQuyenTab);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChonSP);
            this.Controls.Add(this.cbChonView);
            this.Controls.Add(this.cbChonBang);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.revokeButton);
            this.Controls.Add(this.label_ThuHoiQuyen);
            this.Name = "ThuHoiQuyen";
            this.Text = "ThuHoiQuyen";
            this.Load += new System.EventHandler(this.ThuHoiQuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ThuHoiQuyen;
        private System.Windows.Forms.Button revokeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbChonBang;
        private System.Windows.Forms.ComboBox cbChonView;
        private System.Windows.Forms.ComboBox cbChonSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.ComboBox cbQuyenTab;
        private System.Windows.Forms.ComboBox cbQuyenView;
        private System.Windows.Forms.Button findButton;
    }
}