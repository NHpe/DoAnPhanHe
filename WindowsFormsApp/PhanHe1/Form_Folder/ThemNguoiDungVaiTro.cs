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
    public partial class ThemNguoiDungVaiTro : Form
    {
        string createObj = "USER";
        string name = "";
        ConnectServer ConnectServer;
        dba_roles_Database dba_Roles_Database;
        dba_users_Database users_Database;

        public ThemNguoiDungVaiTro(ConnectServer conn)
        {
            InitializeComponent();
            this.ConnectServer = conn;

        }

        private void ThemNguoiDungVaiTro_Load(object sender, EventArgs e)
        {
            dba_Roles_Database = new dba_roles_Database(ConnectServer);
            users_Database = new dba_users_Database(ConnectServer);
        }

        private void radioButton_ThemUser_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radio = sender as RadioButton;
            //if (radio.Checked)
            //{
            //    createObj = radio.Text;
            //}
            createObj = "USER";
        }

        private void radioButton_ThemRole_CheckedChanged(object sender, EventArgs e)
        {
            createObj = "ROLE";
        }

        void executeRoleUserCreate()
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    if (createObj == "ROLE")
                    {
                        string createRoleSql = "BEGIN SYS.USP_CREATE_ROLE(:name); END;";
                        using (OracleConnection conn = ConnectServer.getConnect())
                        {
                            conn.Open();
                            using (OracleCommand command = new OracleCommand(createRoleSql, conn))
                            {
                                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                                command.ExecuteNonQuery();
                            }
                            conn.Close();
                            MessageBox.Show("Thao tac thuc hien thanh cong!", "Thanh cong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if (createObj == "USER")
                    {
                        string createUserSql = "BEGIN SYS.USP_CREATE_USER(:name,:pass); END;";
                        using (OracleConnection conn = ConnectServer.getConnect())
                        {
                            conn.Open();
                            using (OracleCommand command = new OracleCommand(createUserSql, conn))
                            {
                                command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                                command.Parameters.Add(":pass", OracleDbType.Varchar2).Value = name;
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

        private void button_HoanTatThem_Click(object sender, EventArgs e)
        {
            name = textBox_ThemUserRole.Text;
            executeRoleUserCreate();
        }
    }
}
