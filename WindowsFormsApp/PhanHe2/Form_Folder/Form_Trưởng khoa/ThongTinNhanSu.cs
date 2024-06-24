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
    public partial class ThongTinNhanSu : Form
    {
        string username, password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinNhanSu(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = "SELECT * FROM DAPH_ADMIN1.DAPH_NHANSU";
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            return data;
        }    

        private void ThongTinNhanSu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadData();
        }

        string manv;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            manv = textBox_MANV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_HOTEN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_PHAI.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_NGSINH.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_PHUCAP.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_DT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_VAITRO.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_MADV.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void textBox_MANV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET MANV = '{textBox_MANV.Text}' WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                    manv = textBox_MANV.Text;
                }
                catch { 
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_HOTEN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET HOTEN = N'{textBox_HOTEN.Text}' WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_PHAI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET PHAI = '{textBox_PHAI.Text}' WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_NGSINH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET NGSINH = TO_DATE('{textBox_NGSINH.Text}', 'DD/MM/YYYY') WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_PHUCAP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET PHUCAP = {textBox_PHUCAP.Text} WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_DT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET DT = '{textBox_DT.Text}' WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        } 

        private void textBox_VAITRO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET VAITRO = N'{textBox_VAITRO.Text}' WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_MADV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_NHANSU SET MADV = '{textBox_MADV.Text}' WHERE MANV = '{manv}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    cmd.ExecuteNonQuery();
                    oracleConnection.Close();

                    dataGridView1.DataSource = LoadData();
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.DAPH_NHANSU VALUES ('{textBox_MANV.Text}', N'{textBox_HOTEN.Text}', '{textBox_PHAI.Text}', TO_DATE('{textBox_NGSINH.Text}', 'DD/MM/YYYY'), {textBox_PHUCAP.Text}, '{textBox_DT.Text}', N'{textBox_VAITRO.Text}', '{textBox_MADV.Text}')";
                OracleCommand cmd = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                cmd.ExecuteNonQuery();
                oracleConnection.Close();

                dataGridView1.DataSource = LoadData();
                manv = textBox_MANV.Text;
            }
            catch
            {
                if (oracleConnection.State == ConnectionState.Open)
                {
                    oracleConnection.Close();
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"DELETE FROM DAPH_ADMIN1.DAPH_NHANSU WHERE MANV = '{textBox_MANV.Text}'";
                OracleCommand cmd = new OracleCommand(str , oracleConnection);
                oracleConnection.Open();
                cmd.ExecuteNonQuery();
                oracleConnection.Close();

                dataGridView1.DataSource = LoadData();
                manv = textBox_MANV.Text = "";
                textBox_HOTEN.Text = "";
                textBox_PHAI.Text = "";
                textBox_NGSINH.Text = "";
                textBox_PHUCAP.Text = "";
                textBox_DT.Text = "";
                textBox_VAITRO.Text = "";
                textBox_MADV.Text = "";
            }
            catch
            {
                if (oracleConnection.State == ConnectionState.Open)
                {
                    oracleConnection.Close();
                }
            }
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            manv = textBox_MANV.Text = "";
            textBox_HOTEN.Text = "";
            textBox_PHAI.Text = "";
            textBox_NGSINH.Text = "";
            textBox_PHUCAP.Text = "";
            textBox_DT.Text = "";
            textBox_VAITRO.Text = "";
            textBox_MADV.Text = "";
        }
    }
}
