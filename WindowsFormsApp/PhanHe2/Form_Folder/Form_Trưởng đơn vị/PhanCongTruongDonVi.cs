using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class PhanCongTruongDonVi : Form
    {
        string username, password;
        int type;
        OracleConnection oracleConnection;
        public PhanCongTruongDonVi(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = "SELECT * FROM DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);
            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            return data;
        }

        private void PhanCongTruongDonVi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadData();
        }

        string magv, mahp, hk, nam, mact;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MAGV.Text  = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_MAHP.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_HK.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_NAM.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_MACT.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            magv = textBox_MAGV.Text;
            mahp = textBox_MAHP.Text;
            hk = textBox_HK.Text;
            nam = textBox_NAM.Text;
            mact = textBox_MACT.Text;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI VALUES ('{textBox_MAGV.Text}', '{textBox_MAHP.Text}', {textBox_HK.Text}, {textBox_NAM.Text}, '{textBox_MACT.Text}')";
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

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"DELETE FROM DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI WHERE MAGV = '{textBox_MAGV.Text}' AND MAHP = '{textBox_MAHP.Text}' AND HK = {textBox_HK.Text} AND NAM = {textBox_NAM.Text} AND MACT = '{textBox_MACT.Text}'";
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

        private void buttmớ_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MAGV.Text = "";
            textBox_MAHP.Text = "";
            textBox_HK.Text = "";
            textBox_NAM.Text = "";
            textBox_MACT.Text = "";
        }

        private void textBox_MAGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI SET MAGV = '{textBox_MAGV.Text}' WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
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
                    magv = textBox_MAGV.Text;
                }
                catch { }
            }
        }

        private void textBox_MAHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI SET MAHP = '{textBox_MAHP.Text}' WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
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
                    mahp = textBox_MAHP.Text;
                }
                catch { }
            }
        }

        private void textBox_HK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI SET HK = {textBox_MAHP.Text} WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
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
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI SET NAM = {textBox_NAM.Text} WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
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
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_DON_VI SET MACT = '{textBox_MACT.Text}' WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
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
                    mact = textBox_MACT.Text;
                }
                catch { }
            }
        }
    }
}
