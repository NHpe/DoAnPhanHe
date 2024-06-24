using Oracle.ManagedDataAccess.Client;
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
    public partial class ThongTinGiangDay : Form
    {
        string username;
        string password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinGiangDay(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private void ThongTinGiangDay_Load(object sender, EventArgs e)
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.VIEW_DU_LIEU_GIANG_DAY";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);

            dataGridView1.DataSource = data;
        }
    }
}
