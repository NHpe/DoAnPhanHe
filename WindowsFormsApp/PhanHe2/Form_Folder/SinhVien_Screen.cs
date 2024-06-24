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
    public partial class SinhVien_Screen : Form
    {
        string username;
        string password;
        ConnectServer connectServer;
        OracleConnection oracleConnection;
        int bang;
        public SinhVien_Screen(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            connectServer = new ConnectServer(username, password);
            oracleConnection = connectServer.getConnect();
            bang = 0;
        }

        private void LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.DAPH_SINHVIEN";

            OracleCommand cmd = new OracleCommand(str, oracleConnection);
            oracleConnection.Open();
            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            if (oracleDataReader.Read())
            {
                textBox_MASV.Text = oracleDataReader.GetString(0);
                textBox_HOTEN.Text = oracleDataReader.GetString(1);
                textBox_PHAI.Text = oracleDataReader.GetString(2);
                textBox_NGSINH.Text = oracleDataReader.GetString(3);
                textBox_DCHI.Text = oracleDataReader.GetString(4);
                textBox_DT.Text = oracleDataReader.GetString(5);
                textBox_MACT.Text = oracleDataReader.GetString(6);
                textBox_MANGANH.Text = oracleDataReader.GetString(7);
                textBox_STCTL.Text = oracleDataReader.GetString(8);
                textBox_DTBTL.Text = oracleDataReader.GetString(9);
            }
            oracleConnection.Close();
        }

        private void SinhVien_Screen_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime k1Begin = new DateTime(now.Year, 1, 1);
            DateTime k1End = new DateTime(now.Year, 1, 14);
            DateTime k2Begin = new DateTime(now.Year, 5, 1);
            DateTime k2End = new DateTime(now.Year, 5, 14);
            DateTime k3Begin = new DateTime(now.Year, 9, 1);
            DateTime k3End = new DateTime(now.Year, 9, 14);

            if (now > k1Begin && now < k1End || now > k2Begin && now < k2End || now > k3Begin && now < k3End)
            {

            }
            else
            {
                //groupBox1.Hide();
                //button_DANGKY_SV.Hide();    
            }

            LoadData();
        }

        private void button_KHMO_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM DAPH_ADMIN1.DAPH_KHMO";

            DataTable dt = new DataTable();

            OracleDataAdapter cmd = new OracleDataAdapter(str, oracleConnection);
            oracleConnection.Open();
            cmd.Fill(dt);
            oracleConnection.Close();

            dataGridView1.DataSource = dt;
            bang = 1;
        }

        private void button_HOCPHAN_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM DAPH_ADMIN1.DAPH_HOCPHAN";

            DataTable dt = new DataTable();

            OracleDataAdapter cmd = new OracleDataAdapter(str, oracleConnection);
            oracleConnection.Open();
            cmd.Fill(dt);
            oracleConnection.Close();

            dataGridView1.DataSource = dt;
            bang = 2;
        }

        private void button_DANGKY_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM DAPH_ADMIN1.DAPH_DANGKY";

            DataTable dt = new DataTable();

            OracleDataAdapter cmd = new OracleDataAdapter(str, oracleConnection);
            oracleConnection.Open();
            cmd.Fill(dt);
            oracleConnection.Close();

            dataGridView1.DataSource = dt;
            bang = 3;
        }

        private void textBox_NGSINH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET NGSINH = TO_DATE('{textBox_NGSINH.Text}', 'DD/MM/YYYY') WHERE MASV = '{username}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int check = cmd.ExecuteNonQuery();

                    if (check != 0)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close() ;
                }
                catch {
                    if (oracleConnection.State != ConnectionState.Closed) { oracleConnection.Close(); }
                }
            }
        }

        private void textBox_DT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.DAPH_SINHVIEN SET DT = '{textBox_DT.Text}' WHERE MASV = '{username}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int check = cmd.ExecuteNonQuery();

                    if (check != 0)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                }
                catch
                {
                    if (oracleConnection.State != ConnectionState.Closed) { oracleConnection.Close(); }
                }
            }
        }

        private void button_DANGKY_SV_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM DAPH_ADMIN1.DAPH_DANGKY_SV";

            DataTable dt = new DataTable();

            OracleDataAdapter cmd = new OracleDataAdapter(str, oracleConnection);
            oracleConnection.Open();
            cmd.Fill(dt);
            oracleConnection.Close();

            dataGridView1.DataSource = dt;
        }

        private void button_DangKyHocPhan_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.DAPH_DANGKY_SV VALUES ('{username}', '{textBox_MAHP_BOX.Text}', {textBox_HK_BOX.Text}, {textBox_NAM_BOX.Text}, '{textBox_MACT_BOX.Text}')";
                OracleCommand cmd = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    string commit = "COMMIT";
                    OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                    cmdCommit.ExecuteNonQuery();
                }
                oracleConnection.Close();
            }
            catch
            {
                if (oracleConnection.State != ConnectionState.Closed) { oracleConnection.Close(); }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"DELETE FROM DAPH_ADMIN1.DAPH_DANGKY_SV WHERE MASV = '{username}' AND MAHP = '{textBox_MAHP_BOX.Text}' AND HK = {textBox_HK_BOX.Text} AND NAM = {textBox_NAM_BOX.Text} AND MACT '{textBox_MACT_BOX.Text}'";
                OracleCommand cmd = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    string commit = "COMMIT";
                    OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                    cmdCommit.ExecuteNonQuery();
                }
                oracleConnection.Close();
            }
            catch
            {
                if (oracleConnection.State != ConnectionState.Closed) { oracleConnection.Close(); }
            }
        }
    }
}