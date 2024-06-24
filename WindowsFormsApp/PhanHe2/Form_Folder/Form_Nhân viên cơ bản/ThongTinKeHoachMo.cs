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
    public partial class ThongTinKeHoachMo : Form
    {
        string username;
        string password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinKeHoachMo(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.DAPH_KHMO";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            return data;
        }

        private void ThongTinKhoaHocMo_Load(object sender, EventArgs e)
        {
            if (type != 3) { groupBox1.Hide(); }
            dataGridView1.DataSource = LoadData();
        }

        string mahp, hk, nam, mact;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == 3)
            {
                textBox_MAHP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_HK.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_NAM.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_MACT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                mahp = textBox_MAHP.Text;
                hk = textBox_HK.Text;
                nam = textBox_NAM.Text;
                mact = textBox_MACT.Text;
            }
        }

        private void textBox_MAHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_KHMO SET MAHP = '{textBox_MAHP.Text}' WHERE MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
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

        private void textBox_HK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_HK.Text == "1" || textBox_HK.Text == "2" || textBox_HK.Text == "3")
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_KHMO SET HK = {textBox_HK.Text} WHERE MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                    hk = textBox_HK.Text;
                }
                catch { }
            }
        }

        private void textBox_NAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_KHMO SET NAM = {textBox_NAM.Text} WHERE MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                    nam = textBox_NAM.Text;
                }
                catch { }
            }
        }

        private void textBox_MACT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_KHMO SET MACT = '{textBox_MACT.Text}' WHERE MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                    mact = textBox_MACT.Text;
                }
                catch { }
            }
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MAHP.Text = "";
            textBox_NAM.Text = "";
            textBox_HK.Text = "";
            textBox_MACT.Text = "";
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.DAPH_KHMO VALUES ('{textBox_MAHP.Text}', {textBox_HK.Text}, {textBox_NAM.Text}, '{textBox_MACT.Text}')";
                OracleCommand cmd = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                cmd.ExecuteNonQuery();
                oracleConnection.Close();

                dataGridView1.DataSource = LoadData();
                mahp = textBox_MAHP.Text;
                hk = textBox_HK.Text;
                nam = textBox_NAM.Text;
                mact = textBox_MACT.Text;
            }
            catch { }
        }
    }
}
