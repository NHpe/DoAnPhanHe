using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp
{
    public partial class ThuHoiQuyen : Form
    {
        string revokee = "USER";
        string name = "";
        string role = "";
        string table = "";
        string priv = "";

        bool T = false, V = false, SP = false;
        ConnectServer ConnectServer;
        dba_roles_Database dba_Roles_Database;
        dba_tables_Database tables_Database;
        dba_users_Database users_Database;
        public ThuHoiQuyen(ConnectServer conn)
        {
            InitializeComponent();
            this.ConnectServer = conn;
        }

        private void ThuHoiQuyen_Load(object sender, EventArgs e)
        {
            tables_Database = new dba_tables_Database(ConnectServer);
            dba_Roles_Database = new dba_roles_Database(ConnectServer);
            users_Database = new dba_users_Database(ConnectServer);

            cbQuyenTab.SelectedIndex = -1;
            cbQuyenTab.SelectedText = "Chọn quyền";

            
            //cbChonBang.DataSource = tables_Database.getAllTable();

            //cbChonBang.DisplayMember = "TABLE_NAME";
            //cbChonBang.ValueMember = "TABLE_NAME";
        }

        private void revokeButton_click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    if (revokee == "ROLE")
                    {
                        using (OracleConnection conn = ConnectServer.getConnect())
                        {
                            conn.Open();
                            string sql = $"REVOKE {priv} ON SYS.{table} FROM {name}";
                            using (OracleCommand cmd = new OracleCommand(sql, conn)) { cmd.ExecuteNonQuery(); }

                            conn.Close();
                        }
                        MessageBox.Show("Thao tac thuc hien thanh cong!", "Thanh cong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (revokee == "USER")
                    {
                        using (OracleConnection conn = ConnectServer.getConnect())
                        {
                            conn.Open();
                            string sql = $"REVOKE {priv} ON SYS.{table} FROM {name}";
                            using (OracleCommand cmd = new OracleCommand(sql, conn)) { cmd.ExecuteNonQuery(); }

                            conn.Close();
                        }
                        MessageBox.Show("Thao tac thuc hien thanh cong!", "Thanh cong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            revokee = "USER";
            findButton.Enabled = false;
            revokeButton.Enabled = false;
            cbChonBang.Enabled = false;
            cbQuyenTab.Enabled = false;
            cbChonView.Enabled = false;
            cbQuyenView.Enabled = false;
            cbChonSP.Enabled = false;
        }

        private void cbChonBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChonBang.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cbChonBang.SelectedItem;
                table = drv["TABLE_NAME"].ToString();
                if (!string.IsNullOrEmpty(table))
                {
                    loadPrivilege(table);
                }
                cbQuyenTab.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cbChonBang.Enabled = true;
            loadCBTable(name);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            revokee = "ROLE";
            findButton.Enabled = false;
            revokeButton.Enabled = false;
            cbChonBang.Enabled = false;
            cbQuyenTab.Enabled = false;
            cbChonView.Enabled = false;
            cbQuyenView.Enabled = false;
            cbChonSP.Enabled = false;
        }

        void loadCBTable(string name)
        {
            tables_Database = new dba_tables_Database(ConnectServer);
            cbChonBang.DataSource = tables_Database.getGrantedTables(name);

            cbChonBang.DisplayMember = "TABLE_NAME";
            cbChonBang.ValueMember = "TABLE_NAME";

            cbChonBang.SelectedIndex = -1;
            cbChonBang.SelectedText = "Chọn bảng";
        }

        private void cbQuyenTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            priv = cbQuyenTab.SelectedValue.ToString();
            revokeButton.Enabled = true;
        }

        void loadPrivilege(string table)
        {
            tables_Database = new dba_tables_Database(ConnectServer);
            cbQuyenTab.DataSource = tables_Database.getTabPrivs(name,table);
            cbQuyenTab.DisplayMember = "PRIVILEGE";
            cbQuyenTab.ValueMember = "PRIVILEGE";
        }

        bool roleExists(string role)
        {
            using (OracleConnection connection = ConnectServer.getConnect())
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                findButton.Enabled = true;
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

        private void findButton_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    if (revokee == "ROLE")
                    {
                        // Kiem tra su ton tai
                        role = textBox1.Text;
                        if (!roleExists(role))
                        {
                            MessageBox.Show($"Loi: Role {role} khong tim thay! Vui long nhap lai.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }

                    }
                    if (revokee == "USER")
                    {
                        // Kiem tra su ton tai
                        name = textBox1.Text;
                        if (!userExists(name))
                        {
                            MessageBox.Show($"Loi: User {name} khong tim thay! Vui long nhap lai.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                radioButton3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi: {ex.Message}","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
