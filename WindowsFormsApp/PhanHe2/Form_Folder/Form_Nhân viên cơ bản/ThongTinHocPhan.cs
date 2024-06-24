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
    public partial class ThongTinHocPhan : Form
    {
        string username;
        string password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinHocPhan(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.DAPH_HOCPHAN";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            return data;
        }
        private void ThongTinHocPhan_Load(object sender, EventArgs e)
        {
            if (type != 3) { groupBox1.Hide(); }
            dataGridView1.DataSource = LoadData();
        }

        string mahp;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == 3)
            {
                textBox_MAHP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                mahp = textBox_MAHP.Text;
                textBox_TENHP.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_SOTC.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_STLT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_STTH.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_SOSVTD.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_MADV.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void textBox_MAHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_HOCPHAN SET MAHP = '{textBox_MAHP.Text}' WHERE MAHP = '{mahp}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                    mahp = textBox_MAHP.Text;
                }
                catch { }
            }
        }

        private void textBox_TENHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_HOCPHAN SET TENHP = '{textBox_TENHP.Text}' WHERE MAHP = '{textBox_MAHP.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_SOTC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_HOCPHAN SET SOTC = {textBox_SOTC.Text} WHERE MAHP = '{textBox_MAHP.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_STLT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_HOCPHAN SET STLT = {textBox_STLT.Text} WHERE MAHP = '{textBox_MAHP.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_STTH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_HOCPHAN SET STTH = '{textBox_STTH.Text}' WHERE MAHP = '{textBox_MAHP.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_SOSVTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_HOCPHAN SET SOSVTD = '{textBox_SOSVTD.Text}' WHERE MAHP = '{textBox_MAHP.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_MADV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_HOCPHAN SET MADV = '{textBox_MADV.Text}' WHERE MAHP = '{textBox_MAHP.Text}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void button__LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MAHP.Text = "";
            textBox_TENHP.Text = "";
            textBox_SOTC.Text = "";
            textBox_STLT.Text = "";
            textBox_STTH.Text = "";
            textBox_SOSVTD.Text = "";
            textBox_MADV.Text = "";
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.DAPH_HOCPHAN VALUES ('{textBox_MAHP.Text}', '{textBox_TENHP.Text}', {textBox_SOTC.Text}, {textBox_STLT.Text}, {textBox_STTH.Text}, {textBox_SOSVTD.Text}, '{textBox_MADV.Text}')";
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
