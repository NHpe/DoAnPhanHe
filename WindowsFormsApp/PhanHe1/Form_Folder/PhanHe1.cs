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
    public partial class PhanHe1 : Form
    {
        ConnectServer con;
        dba_users_Database dba_Users_Database;
        dba_roles_Database dba_Roles_Database;
        string username;
        string password;
        public PhanHe1(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void PhanHe1_Load(object sender, EventArgs e)
        {
            con = new ConnectServer(username, password);
            dba_Users_Database = new dba_users_Database(con);
            dba_Roles_Database = new dba_roles_Database(con);
        }

        private void button_UserList_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_UserList.DataSource = dba_Users_Database.getAllUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }
        }

        private void button_RoleList_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_RoleList.DataSource = dba_Roles_Database.getAllRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }
        }

        private void dataGridView_UserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string user = dataGridView_UserList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Form form = new XemThongTinQuyenUser(con, user);
            form.Show();
        }

        private void dataGridView_RoleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string role = dataGridView_RoleList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Form form = new XemThongTinRole(con, role);
            form.Show();
        }

        private void button_ThemUserRole_Click(object sender, EventArgs e)
        {
            Form form = new ThemNguoiDungVaiTro(con);
            form.Show();
        }

        private void button_XoaUserRole_Click(object sender, EventArgs e)
        {
            Form form = new XoaNguoiDungVaiTro(con);
            form.Show();
        }

        private void button_SuaUserRole_Click(Object sender, EventArgs e)
        {
            Form form = new SuaNguoiDungVaiTro(con);
            form.Show();
        }

        private void button_CapRoleToUser_Click(object sender, EventArgs e)
        {
            Form form = new CapVaiTroChoNguoiDung(con);
            form.Show();
        }

        private void button_CapQuyenChoUserRole_Click(object sender, EventArgs e)
        {
            Form form = new CapQuyenChoNguoiDungVaiTro(con);
            form.Show();
        }

        private void button_ThuHoiQuyen_Click(object sender, EventArgs e)
        {
            Form form = new ThuHoiQuyen(con);
            form.Show();
        }

    }
}
