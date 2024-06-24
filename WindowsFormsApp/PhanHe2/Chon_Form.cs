using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp 
{ 
    public partial class Chon_Form : Form
    {
        string username, password;
        
        public Chon_Form(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void button_PH2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new PhanHe2(username, password);
            form.ShowDialog();
        }

        private void button_PH1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new PhanHe1(username, password);
            form.ShowDialog();
        }
    }
}
