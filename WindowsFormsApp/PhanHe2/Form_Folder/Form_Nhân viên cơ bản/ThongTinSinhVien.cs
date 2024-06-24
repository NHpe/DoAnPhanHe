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
    public partial class ThongTinSinhVien : Form
    {
        string username;
        string password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinSinhVien(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.DAPH_SINHVIEN";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            
            return data;
        }

        private void ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            if (type != 3) { groupBox1.Hide(); }
            dataGridView1.DataSource = LoadData();
        }

        string masv;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == 3)
            {
                textBox_MASV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                masv = textBox_MASV.Text;
                textBox_HOTEN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_PHAI.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_NGSINH.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_DCHI.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_DT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_MACT.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_MANGANH.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox_SOTCTL.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox_DTBTL.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void textBox_HOTEN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET HOTEN = '{textBox_HOTEN.Text}' WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_PHAI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET PHAI = '{textBox_PHAI.Text}' WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_NGSINH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET NGSINH = TO_DATE('{textBox_NGSINH.Text}', 'DD/MM/YYYY') WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_DCHI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET DCHI = '{textBox_DCHI.Text}' WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_DT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET DT = '{textBox_DT.Text}' WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_MACT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET MACT = '{textBox_MACT.Text}' WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_MANGANH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET MANGANH = '{textBox_MANGANH.Text}' WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_SOTCTL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET SOTCTL = {textBox_SOTCTL.Text} WHERE MASV = '{textBox_MASV.Text}'";
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

        private void textBox_DTBTL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET DTBTL = {textBox_DTBTL.Text} WHERE MASV = '{textBox_MASV.Text}'";
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

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_MASV.Text = "";
            textBox_HOTEN.Text = "";
            textBox_PHAI.Text = "";
            textBox_NGSINH.Text = "";
            textBox_DCHI.Text = "";
            textBox_DT.Text = "";
            textBox_MACT.Text = "";
            textBox_MANGANH.Text = "";
            textBox_SOTCTL.Text = "";
            textBox_DTBTL.Text = "";
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.DAPH_SINHVIEN VALUES ('{textBox_MASV.Text}', '{textBox_HOTEN.Text}', '{textBox_PHAI.Text}', TO_DATE('{textBox_NGSINH.Text}', 'DD/MM/YYYY'), '{textBox_DCHI.Text}', '{textBox_DT.Text}', '{textBox_MACT.Text}', '{textBox_MANGANH.Text}', {textBox_SOTCTL.Text}, {textBox_DTBTL.Text})";
                OracleCommand cmd = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    string commit = "COMMIT";
                    OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                    cmdCommit.ExecuteNonQuery();
                };
                oracleConnection.Close();
                dataGridView1.DataSource = LoadData();
            }
            catch { }
        }

        private void textBox_MASV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET MASV = {textBox_MASV.Text} WHERE MASV = '{masv}'";
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
                    masv = textBox_MASV.Text;
                }
                catch { }
            }
        }
    }
}
