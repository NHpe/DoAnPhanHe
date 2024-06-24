namespace WindowsFormsApp
{
    partial class Chon_Form
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
            this.button_PH1 = new System.Windows.Forms.Button();
            this.button_PH2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_PH1
            // 
            this.button_PH1.Location = new System.Drawing.Point(152, 187);
            this.button_PH1.Name = "button_PH1";
            this.button_PH1.Size = new System.Drawing.Size(140, 70);
            this.button_PH1.TabIndex = 0;
            this.button_PH1.Text = "Phân hệ 1";
            this.button_PH1.UseVisualStyleBackColor = true;
            this.button_PH1.Click += new System.EventHandler(this.button_PH1_Click);
            // 
            // button_PH2
            // 
            this.button_PH2.Location = new System.Drawing.Point(503, 187);
            this.button_PH2.Name = "button_PH2";
            this.button_PH2.Size = new System.Drawing.Size(140, 70);
            this.button_PH2.TabIndex = 1;
            this.button_PH2.Text = "Phân hệ 2";
            this.button_PH2.UseVisualStyleBackColor = true;
            this.button_PH2.Click += new System.EventHandler(this.button_PH2_Click);
            // 
            // Chon_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_PH2);
            this.Controls.Add(this.button_PH1);
            this.Name = "Chon_Form";
            this.Text = "Chon phân hệ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PH1;
        private System.Windows.Forms.Button button_PH2;
    }
}