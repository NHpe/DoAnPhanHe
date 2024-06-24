using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class CapVaiTroChoNguoiDung : Form
    {
        ConnectServer connectServer;
        dba_roles_Database dba_Roles_Database;
        dba_users_Database users_Database;
        Button applyRoleButton;



        public CapVaiTroChoNguoiDung(ConnectServer con)
        {
            InitializeComponent();
            this.connectServer = con;
        }

        private void CapVaiTroChoNguoiDung_Load(object sender, EventArgs e)
        {
            dba_Roles_Database = new dba_roles_Database(connectServer);
            users_Database = new dba_users_Database(connectServer);

            // Lấy DataTable chứa dữ liệu người dùng và vai trò
            DataTable userList = users_Database.getAllUser();
            DataTable roleList = dba_Roles_Database.getAllRole();

            // Thiết lập nguồn dữ liệu cho ComboBox và chỉ định cách hiển thị và giá trị
            userBox.DataSource = userList;
            userBox.DisplayMember = "USERNAME"; // Chọn cột hiển thị tên người dùng
            userBox.ValueMember = "USERNAME";   // Chọn cột chứa giá trị tên người dùng

            roleBox.DataSource = roleList;
            roleBox.DisplayMember = "ROLE"; // Chọn cột hiển thị tên vai trò
            roleBox.ValueMember = "ROLE";   // Chọn cột chứa giá trị tên vai trò

           // applyRoleButton.Click += button_HoanTatGanRoleUser_Click;
        }
        
        bool UserHasRole(string username)
        {
            OracleConnection connection = this.connectServer.getConnect();
            
            connection.Open();

            // Tạo câu lệnh SQL để kiểm tra vai trò của người dùng
            string sql = $"SELECT COUNT(*) FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{username}'";

            // Thực thi câu lệnh SQL
            using (OracleCommand command = new OracleCommand(sql, connection))
            {
                // Lấy số lượng vai trò của người dùng
                int count = Convert.ToInt32(command.ExecuteScalar());
                // Nếu người dùng có ít nhất một vai trò, trả về true
                if(count >= 1)
                    return true;
            }
            connection.Close();
            
            return false; 
        }

        private void button_HoanTatGanRoleUser_Click(object sender, EventArgs e)
        {
            // Lấy tên người dùng và vai trò đã chọn
            string selectedUser = userBox.SelectedValue?.ToString();
            string selectedRole = roleBox.SelectedValue?.ToString(); 
            OracleConnection connection = this.connectServer.getConnect();
            // Kiểm tra xem người dùng và vai trò có được chọn hay không
            if (!string.IsNullOrEmpty(selectedUser) && !string.IsNullOrEmpty(selectedRole))
            {
                //// Kiểm tra xem người dùng đã có vai trò hay chưa
                //if (UserHasRole(selectedUser) == true)
                //{
                //    MessageBox.Show($"Người dùng {selectedUser} đã có vai trò và không thể được cấp thêm vai trò mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return; // Không cần tiếp tục thực hiện
                //}
                //else
                {
                    try
                    {
                        connection.Open();

                        if (selectedRole != "DAPH_SINHVIEN")
                        {
                            // Sử dụng câu lệnh SQL để áp dụng vai trò cho người dùng
                            string sql = $"GRANT {selectedRole} TO {selectedUser}";
                            using (OracleCommand command = new OracleCommand(sql, connection))
                            {
                                // Thực thi câu lệnh SQL
                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string sql = $"BEGIN GAN_QUYEN_CHO_SINH_VIEN('{selectedUser}'); END; ";
                            using (OracleCommand command = new OracleCommand(sql, connection))
                            {
                                // Thực thi câu lệnh SQL
                                command.ExecuteNonQuery();
                            }
                        }

                        connection.Close();
                        

                        MessageBox.Show($"Đã áp dụng vai trò {selectedRole} cho người dùng {selectedUser} thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi áp dụng vai trò cho người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng và vai trò trước khi nhấp vào Hoàn tất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
