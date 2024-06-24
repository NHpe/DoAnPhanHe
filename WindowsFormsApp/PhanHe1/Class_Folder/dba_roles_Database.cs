using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    internal class dba_roles_Database
    {
        ConnectServer cs;
        OracleDataAdapter odbc;
        public dba_roles_Database(ConnectServer con)
        {
            this.cs = con;     
        }

        public DataTable getAllRole()
        {
            // Tạo câu lệnh lấy toàn bộ danh sách người dùng 
            string str = "select ROLE from dba_roles where ROLE like 'DAPH_%'";

            OracleConnection conn = cs.getConnect();

            odbc = new OracleDataAdapter(str, conn);

            conn.Open();
            DataTable data = new DataTable();
            odbc.Fill(data);

            DataRow dataRow = data.NewRow();
            dataRow[0] = "DAPH_SINHVIEN";
            data.Rows.Add(dataRow);

            conn.Close();

            return data;
        }
    }
}
