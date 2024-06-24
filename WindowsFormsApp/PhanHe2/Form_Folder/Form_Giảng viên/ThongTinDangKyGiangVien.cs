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
    public partial class ThongTinDangKyGiangVien : Form
    {
        string username;
        string password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinDangKyGiangVien(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.VIEW_DANG_KY_GIANG_VIEN";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            return data;
        }

        private void ThongTinDangKyGiangVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadData();
        }

        string masv, magv, mahp, hk, nam, mact;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            masv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            groupBox_CapNhatDiem.Text = masv;
            magv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            mahp = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            hk = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            nam = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mact = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_DTH.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_DQT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox_DCK.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox_DTK.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void textBox_DQT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_DANG_KY_GIANG_VIEN SET DIEMQT = {textBox_DQT.Text} WHERE MASV = '{masv}' AND MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_DTH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_DANG_KY_GIANG_VIEN SET DIEMTH = {textBox_DTH.Text} WHERE MASV = '{masv}' AND MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_DCK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_DANG_KY_GIANG_VIEN SET DIEMCK = {textBox_DCK.Text} WHERE MASV = '{masv}' AND MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }

        private void textBox_DTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_DANG_KY_GIANG_VIEN SET DIEMTK = {textBox_DTK.Text} WHERE MASV = '{masv}' AND MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery(); 
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                }
                catch { }
            }
        }
    }
}
