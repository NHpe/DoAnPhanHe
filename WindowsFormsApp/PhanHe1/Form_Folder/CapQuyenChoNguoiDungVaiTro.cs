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
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp
{
    public partial class CapQuyenChoNguoiDungVaiTro : Form
    {
        string grant = "";
        string quyen;
        string bang;
        string cot;
        ConnectServer con;
        dba_tables_Database dba_Tables_Database;
        all_tab_cols_Database dba_tab_columns;
        public CapQuyenChoNguoiDungVaiTro()
        {
            InitializeComponent();
        }

        public CapQuyenChoNguoiDungVaiTro(ConnectServer connectServer)
        {
            InitializeComponent();
            this.con = connectServer;
        }

        private void CapQuyenChoNguoiDungVaiTro_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox_ChonQuyen.SelectedIndex = -1;
                comboBox_ChonQuyen.SelectedText = "Chọn quyền";
                comboBox_ChonQuyen.Items.Add("SELECT");
                comboBox_ChonQuyen.Items.Add("INSERT");
                comboBox_ChonQuyen.Items.Add("DELETE");
                comboBox_ChonQuyen.Items.Add("UPDATE");

                dba_Tables_Database = new dba_tables_Database(con);
                comboBox_TableList.DataSource = dba_Tables_Database.getAllTable();

                comboBox_TableList.DisplayMember = "TABLE_NAME";
                comboBox_TableList.ValueMember = "TABLE_NAME";

                comboBox_TableList.SelectedIndex = -1;
                comboBox_TableList.SelectedText = "Chọn bảng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }
        }

        private void radioButton_WITH_GRANT_CheckedChanged(object sender, EventArgs e)
        {
            grant = " WITH GRANT OPTION";
        }

        private void radioButton_GRANT_CheckedChanged(object sender, EventArgs e)
        {
            grant = "";
        }

        private void comboBox_TableList_SelectedIndex_Changed(object sender, EventArgs e)
        {
            if (comboBox_TableList.SelectedIndex >= 0)
            {
                bang = comboBox_TableList.SelectedValue.ToString();
                dba_tab_columns = new all_tab_cols_Database(con, bang);
                comboBox_ColumnList.DataSource = dba_tab_columns.getColumn();

                comboBox_ColumnList.DisplayMember = "COLUMN_NAME";
                comboBox_ColumnList.ValueMember = "COLUMN_NAME";
            }
        }

        bool IsUserExists(string username)
        {
            OracleConnection connection = this.con.getConnect();
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
            return false;
        }

        bool IsRoleExists(string rolename)
        {
            OracleConnection connection = this.con.getConnect();
            
            connection.Open();
            // Thực hiện truy vấn kiểm tra sự tồn tại của vai trò
            string query = $"SELECT COUNT(*) FROM dba_roles WHERE role = '{rolename.ToUpper()}'";
            // Thực hiện truy vấn và lấy kết quả
            // Ví dụ: count = con.ExecuteScalar(query);

            // Nếu số lượng bằng 1 thì vai trò tồn tại
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                // Thực hiện truy vấn và lấy kết quả
                // Ví dụ: count = con.ExecuteScalar(query);
                int count1 = Convert.ToInt32(command.ExecuteScalar());
                if (count1 >= 1)
                    return true;
            }
            connection.Close();
           
            return false;
        }



        void GrantPermissionToUser(string username, string permission, string table, string column, string grant)
        {
            OracleConnection connection = this.con.getConnect();
            string grantSql;
            string grantSql0;
            connection.Open();

            grantSql0 = $"alter session set \"_ORACLE_SCRIPT\"=true";
            grantSql = $"GRANT {permission} ON SYS.{table} TO {username}";

            /*if (permission == "SELECT" || permission == "UPDATE")
            {
                if (column != "Tất cả các quyền")
                {
                    grantSql0 = $"alter session set \"_ORACLE_SCRIPT\"=true";
                    grantSql = $"GRANT {permission}({column}) ON SYS.{table} TO {username}";
                }
                
                else
                {
                    grantSql0 = $"alter session set \"_ORACLE_SCRIPT\"=true";
                    grantSql = $"GRANT {permission} ON SYS.{table} TO {username}";
                }
            }
            else
            {
                grantSql0 = $"alter session set \"_ORACLE_SCRIPT\"=true";
                grantSql = $"GRANT {permission} ON SYS.{table} TO {username}";
            }*/
            


            using (OracleCommand command0 = new OracleCommand(grantSql0, connection))
            {
                // Thực thi câu lệnh SQL
                command0.ExecuteNonQuery();
            }
            using (OracleCommand command = new OracleCommand(grantSql, connection))
            {
                // Thực thi câu lệnh SQL
                command.ExecuteNonQuery();
            }
            connection.Close();
                // Thực thi câu lệnh SQL
                // Ví dụ: con.ExecuteSqlCommand(grantSql);
        }


        void GrantPermissionToRole(string rolename, string permission, string table, string column)
        {
            OracleConnection connection = this.con.getConnect();
            
            string grantSql;
            string grantSql0;
            connection.Open();
            if (permission == "SELECT" || permission == "UPDATE")
            {
                grantSql0 = $"alter session set \"_ORACLE_SCRIPT\"=true";
                grantSql = $"GRANT {permission}({column}) ON SYS.{table} TO {rolename}";
            }
            else
            {
                grantSql0 = $"alter session set \"_ORACLE_SCRIPT\"=true";
                grantSql = $"GRANT {permission} ON SYS.{table} TO {rolename}";
            }

            using (OracleCommand command0 = new OracleCommand(grantSql0, connection))
            {
                // Thực thi câu lệnh SQL
                command0.ExecuteNonQuery();
            }
            using (OracleCommand command = new OracleCommand(grantSql, connection))
            {
                // Thực thi câu lệnh SQL
                command.ExecuteNonQuery();
            }
            // Thực thi câu lệnh SQL
            // Ví dụ: con.ExecuteSqlCommand(grantSql);
            connection.Close();
        }


        public void button_HoanTatGRANT_Click(object sender, EventArgs e)
        {
            {
                // Kiểm tra xem đã chọn quyền, bảng, cột và nhập tên người dùng hoặc user chưa

                string selectedQuyen = comboBox_ChonQuyen.SelectedValue?.ToString();
                string selectedTableList = comboBox_TableList.SelectedValue?.ToString();
                if (comboBox_ChonQuyen.SelectedIndex == -1 || comboBox_TableList.SelectedIndex == -1 || comboBox_ColumnList.SelectedIndex == -1 || string.IsNullOrEmpty(textBox_GrantUserRole.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng chọn quyền, bảng, cột và nhập tên người dùng hoặc user trước khi nhấn Hoàn tất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem đã chọn radio button tương ứng cho user hoặc role không
                if (!(radioButton1.Checked || radioButton2.Checked))
                {
                    MessageBox.Show("Vui lòng chọn User hoặc Role.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string selectedUserOrRole = textBox_GrantUserRole.Text.Trim();
                if (radioButton1.Checked && IsUserExists(selectedUserOrRole) != true)
                {
                    MessageBox.Show("User không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsRoleExists(selectedUserOrRole) != true && radioButton2.Checked)
                {
                    MessageBox.Show("Role không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (radioButton_WITH_GRANT.Checked == true && radioButton2.Checked == true)
                {
                    MessageBox.Show("Không thể thực hiện WITH GRANT OPTION cho vai trò", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thực hiện gán quyền cho user hoặc role tương ứng
                try
                {
                    string selectedPermission = comboBox_ChonQuyen.SelectedItem.ToString();
                    string selectedTable = comboBox_TableList.SelectedValue?.ToString();
                    string selectedColumn = comboBox_ColumnList.SelectedValue?.ToString();

                    if (radioButton1.Checked)
                    {
                        // Thực hiện gán quyền cho user
                        // Gọi phương thức để thực hiện việc gán quyền cho user
                        GrantPermissionToUser(selectedUserOrRole, selectedPermission, selectedTable, selectedColumn, grant);
                    }
                    else if (radioButton2.Checked)
                    {
                        // Thực hiện gán quyền cho role
                        // Gọi phương thức để thực hiện việc gán quyền cho role
                        GrantPermissionToRole(selectedUserOrRole, selectedPermission, selectedTable, selectedColumn);
                    }

                    // Hiển thị thông báo thành công
                    MessageBox.Show($"Đã gán quyền '{selectedPermission}' cho '{selectedUserOrRole}' trên bảng '{selectedTable}'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (radioButton2.Checked == true)
                    {
                        string role = textBox_GrantUserRole.Text;
                        Form form = new XemThongTinRole(con, role);
                        form.Show();
                    }
                    else
                    {
                        string name = textBox_GrantUserRole.Text;
                        Form form = new XemThongTinQuyenUser(con, name);
                        form.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi gán quyền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

