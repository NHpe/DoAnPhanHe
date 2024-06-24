using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {// Biến để lưu trữ thông tin về user/role
        string username;
        string password;

        public Login() { 
            InitializeComponent();
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;

            string new_user = username.Substring(5);

            int checker = 0;
            try
            {
                username = textBox1.Text;
                password = textBox2.Text;

                new_user = username.Substring(5);

                ConnectServer connectServer = new ConnectServer(username, password);
                OracleConnection oracleConnection = connectServer.getConnect();

                checker = 0;

                if (username.Contains("SV") == true)
                {
                    string sql = $"SELECT MASV FROM DAPH_ADMIN1.DAPH_SINHVIEN WHERE MASV = '{username}'";
                    OracleCommand cmd = new OracleCommand(sql, oracleConnection);
                    oracleConnection.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        checker = 1;
                    }
                    oracleConnection.Close();
                }
                else if (username.Contains("NV") == true || username.Contains("GVI") == true || username.Contains("GVU") == true || username.Contains("TDV") == true || username.Contains("TK") == true)
                {
                    string sql = $"SELECT MANV FROM DAPH_ADMIN1.VIEW_THONG_TIN_NHAN_VIEN_CO_BAN WHERE MANV = '{username}'";
                    OracleCommand cmd = new OracleCommand(sql, oracleConnection);
                    oracleConnection.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        checker = 2;
                    }
                    oracleConnection.Close();
                }
            }
            catch { }

            // Người dùng ADMIN
            if (username == "DAPH_ADMIN" &&  password == "daph_admin")
            {
                this.Hide();
                Chon_Form form = new Chon_Form(username, password);
                form.ShowDialog();
                this.Close();
            }
            else if (username.Contains("NV") == true && new_user == password && checker == 2)
            {
                this.Hide();
                NhanSu_Screen form = new NhanSu_Screen(1, username, password);
                form.ShowDialog();
                Application.Restart();
            }
            else if (username.Contains("GVI") == true && new_user == password && checker == 2)
            {
                this.Hide();
                NhanSu_Screen form = new NhanSu_Screen(2, username, password);
                form.ShowDialog();
                Application.Restart();
            }
            else if (username.Contains("GVU") == true && new_user == password && checker == 2)
            {
                this.Hide();
                NhanSu_Screen form = new NhanSu_Screen(3, username, password);
                form.ShowDialog();
                Application.Restart();
            }
            else if (username.Contains("TDV") == true && new_user == password && checker == 2)
            {
                this.Hide();
                NhanSu_Screen form = new NhanSu_Screen(4, username, password);
                form.ShowDialog();
                Application.Restart();
            }       
            else if (username.Contains("TK") == true && new_user == password && checker == 2)
            {
                this.Hide();
                NhanSu_Screen form = new NhanSu_Screen(5, username, password);
                form.ShowDialog();
                Application.Restart();
            }
            else if (username.Contains("SV") == true && new_user == password && checker == 1)
            {
                this.Hide();
                SinhVien_Screen form = new SinhVien_Screen(username, password);
                form.ShowDialog();
                Application.Restart();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

