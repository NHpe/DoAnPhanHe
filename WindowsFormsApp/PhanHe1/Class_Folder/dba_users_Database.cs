using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    internal class dba_users_Database
    {
        ConnectServer cs;
        OracleDataAdapter odbc;
        public dba_users_Database(ConnectServer con)
        {
            this.cs = con;
        }

        public DataTable getAllUser()
        { 
            // Tạo câu lệnh lấy toàn bộ danh sách người dùng 
            string str = "select USERNAME from dba_users where USERNAME like 'DAPH_%'";

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
