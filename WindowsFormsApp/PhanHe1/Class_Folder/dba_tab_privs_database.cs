using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp
{
    internal class dba_tab_privs_database
    {
        ConnectServer cs;
        OracleDataAdapter odbc;
        string user, role;
        public dba_tab_privs_database(ConnectServer con, string user)
        {
            this.cs = con;
            this.user = user;
        }

        public DataTable getPrivs()
        {
            // Tạo câu lệnh lấy toàn bộ danh sách người dùng 
            string str = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{this.user}'";

            OracleConnection conn = this.cs.getConnect();

            odbc = new OracleDataAdapter(str, conn);

            conn.Open();
            DataTable data = new DataTable();
            odbc.Fill(data);
            conn.Close();

            return data;
        }

        public DataTable getRole()
        {
            string str = $"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{this.user}'";

            OracleConnection conn = this.cs.getConnect();

            odbc = new OracleDataAdapter(str, conn);

            conn.Open();
            DataTable data = new DataTable();
            odbc.Fill(data);
            conn.Close();

            return data;
        }
    }
}
