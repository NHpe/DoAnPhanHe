using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal class all_tab_cols_Database
    {
        ConnectServer cs;
        OracleDataAdapter odbc;
        string table;

        public all_tab_cols_Database(ConnectServer cs, string table)
        {
            this.cs = cs;
            this.table = table;
        }

        public DataTable getColumn()
        {
            string str = "select COLUMN_NAME from all_tab_cols where table_name = '" + table + "'";

            OracleConnection conn = this.cs.getConnect();

            odbc = new OracleDataAdapter(str, conn);

            conn.Open();
            DataTable dt = new DataTable();
            odbc.Fill(dt);
            conn.Close();

            DataRow dr = dt.NewRow();
            dr["COLUMN_NAME"] = "Tất cả các cột";
            dt.Rows.Add(dr);

            return dt;
        }
    }
}
