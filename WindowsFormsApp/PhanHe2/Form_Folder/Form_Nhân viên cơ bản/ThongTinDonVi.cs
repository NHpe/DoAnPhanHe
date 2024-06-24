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
    public partial class ThongTinDonVi : Form
    {
        string username;
        string password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinDonVi(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.DAPH_DONVI";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            return data;
        }

        private void ThongTinDonVi_Load(object sender, EventArgs e)
        {
            if (type != 3) { groupBox1.Hide(); }

            dataGridView1.DataSource = LoadData();
        }

        string madv;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == 3)
            {
                textBox_MADV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                madv = textBox_MADV.Text;
                textBox_TENDV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_TRGDV.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void textBox_MADV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_DONVI SET MADV = '{label_MADV.Text}' WHERE MADV = '{madv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                    madv = textBox_MADV.Text;
                }
                catch { }
            }
        }

        private void textBox_TENDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_DONVI SET TENDV = '{textBox_TENDV.Text}' WHERE MADV = '{textBox_MADV.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_TRGDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_DONVI SET TRGDV = '{textBox_TRGDV.Text}' WHERE MADV = '{textBox_MADV.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MADV.Text = "";
            textBox_TENDV.Text = "";
            textBox_TRGDV.Text = "";
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.DAPH_DONVI VALUES ('{textBox_MADV.Text}', '{textBox_TENDV.Text}', '{textBox_TRGDV.Text}')";
                OracleCommand cmd = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                cmd.ExecuteNonQuery();
                oracleConnection.Close();

                dataGridView1.DataSource = LoadData();
            }
            catch { }
        }
    }
}
