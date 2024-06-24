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
using System.Xml.Linq;

namespace WindowsFormsApp
{
    public partial class SuaNguoiDungVaiTro : Form
    {
        ConnectServer ConnectServer;
        
        public SuaNguoiDungVaiTro(ConnectServer conn)
        {
            InitializeComponent();
            ConnectServer = conn;
        }

        private void SuaNguoiDungVaiTro_Load(object sender, EventArgs e)
        {

        }

        bool userExists(string username)
        {
            using (OracleConnection connection = ConnectServer.getConnect())
            {
                connection.Open();
                // Thực hiện truy vấn kiểm tra sự tồn tại của người dùng
                string query = $"SELECT COUNT(*) FROM all_users WHERE username = '{username.ToUpper()}'";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    // Thực hiện truy vấn và lấy kết quả
                    // Ví dụ: count = con.ExecuteScalar(query);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count >= 1)
                        return true;
                }
                connection.Close();
            }
            return false;
        }
        void changePassword(string user, string pass)
        {
            try
            {
                if (!userExists(user))
                {
                    MessageBox.Show("Nguoi dung khong hop le!");
                    return;
                }
                string sql = "BEGIN SYS.USP_ALTER_USER(:user,:pass); END;";

                using (OracleConnection conn = ConnectServer.getConnect())
                {
                    conn.Open();
                    using (OracleCommand command = new OracleCommand(sql, conn))
                    {
                        command.Parameters.Add(":user", OracleDbType.Varchar2).Value = user;
                        command.Parameters.Add(":pass", OracleDbType.Varchar2).Value = pass;
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("Thao tac thuc hien thanh cong!", "Thanh cong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi khi co gang sua mat khau nguoi dung: {ex.Message}","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_HoanTatSua_Click(object sender, EventArgs e)
        {
            try
            {

                string user = userTextBox.Text;
                string pass = pwTextBox.Text;
                changePassword(user, pass);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
