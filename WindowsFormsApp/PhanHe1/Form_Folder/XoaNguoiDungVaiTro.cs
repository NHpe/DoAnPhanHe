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
using WindowsFormsApp;

namespace WindowsFormsApp
{
    public partial class XoaNguoiDungVaiTro : Form
    {
        string dropObj = "ROLE";
        string name = "";
        ConnectServer connectServer;
        dba_roles_Database dba_Roles_Database;
        dba_users_Database users_Database;
        public XoaNguoiDungVaiTro(ConnectServer conn)
        {
            InitializeComponent();
            this.connectServer = conn;
        }

        private void XoaNguoiDungVaiTro_Load(object sender, EventArgs e)
        {
            dba_Roles_Database = new dba_roles_Database(connectServer);
            users_Database = new dba_users_Database(connectServer);
        }

        private void button_HoanTatXoa_Click(object sender, EventArgs e)
        {
            name = textBox_XoaUserRole.Text;
            executeRoleUserDrop();
        }

        private void radioButton_XoaUser_CheckedChanged(object sender, EventArgs e)
        {
            dropObj = "USER";
        }

        private void radioButton_XoaRole_CheckedChanged(object sender, EventArgs e)
        {
            dropObj = "ROLE";
        }

        bool roleExists(string role)
        {
            using (OracleConnection connection = connectServer.getConnect())
            {
                connection.Open();
                // Thực hiện truy vấn kiểm tra sự tồn tại của người dùng
                string query = $"SELECT COUNT(*) FROM dba_roles WHERE role = '{role.ToUpper()}'";
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

        bool userExists(string username)
        {
            using (OracleConnection connection = connectServer.getConnect())
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
        void executeRoleUserDrop()
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    if (dropObj == "USER")
                    {
                        if (!userExists(name))
                        {
                            MessageBox.Show("Nguoi dung khong ton tai!");
                            return;
                        }
                        string dropUserSql = "BEGIN SYS.USP_DROP_USER(:name); END;";
                        using (OracleConnection conn = connectServer.getConnect())
                        {
                            conn.Open();
                            using (OracleCommand command = new OracleCommand(dropUserSql, conn))
                            {
                                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                                command.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Thao tac thuc hien thanh cong!", "Thanh cong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if (dropObj == "ROLE")
                    {
                        if (!roleExists(name))
                        {
                            MessageBox.Show("Vai tro nguoi dung khong ton tai!");
                            return;
                        }
                        string dropUserSql = "BEGIN SYS.USP_DROP_ROLE(:name); END;";
                        using (OracleConnection conn = connectServer.getConnect())
                        {
                            conn.Open();
                            using (OracleCommand command = new OracleCommand(dropUserSql, conn))
                            {
                                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                                command.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Thao tac thuc hien thanh cong!", "Thanh cong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }
        }
    }
}
