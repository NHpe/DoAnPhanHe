using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    internal class dba_tables_Database
    {
        ConnectServer cs;
        OracleDataAdapter odbc;
        public dba_tables_Database(ConnectServer cs)
        {
            this.cs = cs;
        }

        public DataTable getAllTable()
        {
            string str = "select TABLE_NAME from dba_tables where TABLE_NAME like 'DAPH_%'";

            OracleConnection conn = this.cs.getConnect();

            odbc = new OracleDataAdapter(str, conn);

            conn.Open();
            DataTable dt = new DataTable();
            odbc.Fill(dt);
            conn.Close();

            return dt;
        }
        public DataTable getGrantedTables(string name)
        {
            string str = $"SELECT DISTINCT TABLE_NAME FROM DBA_TAB_PRIVS WHERE GRANTEE = '{name}' AND TABLE_NAME LIKE 'DAPH_%'";

            OracleConnection conn = this.cs.getConnect();

            odbc = new OracleDataAdapter(str, conn);

            conn.Open();
            DataTable dt = new DataTable();
            odbc.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable getTabPrivs(string name, string table)
        {
            string str = $"SELECT PRIVILEGE FROM DBA_TAB_PRIVS WHERE GRANTEE = '{name}' AND TABLE_NAME = '{table}'";

            OracleConnection conn = this.cs.getConnect();

            odbc = new OracleDataAdapter(str, conn);

            conn.Open();
            DataTable dt = new DataTable();
            odbc.Fill(dt);
            conn.Close();

            return dt;
        }
    }
}
