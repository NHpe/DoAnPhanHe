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
    public partial class QuanLyDangKyHocPhan : Form
    {
        string username, password;
        int type;
        OracleConnection oracleConnection;

        public QuanLyDangKyHocPhan(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = "SELECT * FROM DAPH_ADMIN1.DAPH_DANGKY_SV";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);
            oracleConnection.Open();
            DataTable dt = new DataTable();
            oracleDataAdapter.Fill(dt);
            oracleConnection.Close();

            return dt;
        }

        private void QuanLyDangKyHocPhan_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime k1Begin = new DateTime(now.Year ,1, 1);
            DateTime k1End = new DateTime(now.Year, 1, 14);
            DateTime k2Begin = new DateTime(now.Year, 5, 1);
            DateTime k2End = new DateTime(now.Year, 5, 14);
            DateTime k3Begin = new DateTime(now.Year, 9, 1);
            DateTime k3End = new DateTime(now.Year, 9, 14);

            if (now > k1Begin && now < k1End || now > k2Begin && now < k2End || now > k3Begin && now < k3End)
            {
                label_ThongBao.Hide(); 
                dataGridView1.DataSource = LoadData();
            }
            else
            {
                groupBox_ThemXoa.Hide();
                dataGridView1.Hide();
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"INSERT INTO DAPH_ADMIN1.VIEW_DANG_KY_HOC_PHAN_CON_MO VALUES ('{textBox_MASV.Text}', '{textBox_MAGV.Text}', '{textBox_MAHP.Text}', {textBox_HK.Text} ,  {textBox_NAM.Text}, '{textBox_MACT.Text}', NULL, NULL, NULL, NULL)";

                OracleCommand command = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                int check = command.ExecuteNonQuery();

                if (check > 0)
                {
                    string COMMIT = "COMMIT";
                    OracleCommand cmdCommit = new OracleCommand(COMMIT, oracleConnection);
                    cmdCommit.ExecuteNonQuery();
                }
                oracleConnection.Close();
            }
            catch { 
                if (oracleConnection.State != ConnectionState.Closed) { oracleConnection.Close(); }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"DELETE FROM DAPH_ADMIN1.DAPH_DANGKY_SV WHERE MASV = '{textBox_MASV.Text}' AND MAHP = '{textBox_MAHP.Text}' AND HK = {textBox_HK.Text} AND NAM = {textBox_NAM.Text} AND '{textBox_MACT.Text}'";

                OracleCommand command = new OracleCommand(str, oracleConnection);
                oracleConnection.Open();
                int check = command.ExecuteNonQuery();

                if (check > 0)
                {
                    string COMMIT = "COMMIT";
                    OracleCommand cmdCommit = new OracleCommand(COMMIT, oracleConnection);
                    cmdCommit.ExecuteNonQuery();
                }
                oracleConnection.Close();
                dataGridView1.DataSource = LoadData();
            }
            catch
            {
                if (oracleConnection.State != ConnectionState.Closed) { oracleConnection.Close(); }
            }
        }
    }
}
