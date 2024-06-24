using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp
{
    public partial class ThongBao : Form
    {
        ConnectServer connectServer;

        public ThongBao(ConnectServer conn)
        {
            InitializeComponent();
            connectServer = conn;
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            OracleConnection conn = this.connectServer.getConnect();
            string query = "SELECT NOIDUNG FROM DAPH_ADMIN1.DAPH_THONGBAO";

            OracleDataAdapter oda = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();

            oda.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
