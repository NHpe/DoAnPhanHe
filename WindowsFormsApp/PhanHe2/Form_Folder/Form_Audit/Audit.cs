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

namespace WindowsFormsApp
{
    public partial class Audit : Form
    {
        ConnectServer server;
        string[] tables;
        
        public Audit(ConnectServer connectServer)
        {
            InitializeComponent();
            server = connectServer;
            tables = new string[]{ "DAPH_DANGKY", "DAPH_KHMO", "DAPH_PHANCONG", "DAPH_SINHVIEN" };

            cbbStandard.DataSource = tables;
        }

        private void NhatKyCSDL_Load(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbStandard.Text.Length > 0)
                {
                    string name = cbbStandard.Text;
                    string sql = $"SELECT USERNAME,TIMESTAMP,OBJ_NAME,ACTION_NAME,SQL_TEXT FROM DBA_AUDIT_TRAIL" +
                        $" WHERE OBJ_NAME = '{name}'";

                    OracleConnection conn = this.server.getConnect();

                    OracleDataAdapter odbc = new OracleDataAdapter(sql, conn);

                    conn.Open();
                    DataTable data = new DataTable();
                    odbc.Fill(data);

                    tblAudit.DataSource = data;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                lblState.Text = $"Trạng thái: Thất bại. Lỗi {ex.Message}";
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbStandard.Text.Length > 0)
                {
                    string name = cbbStandard.Text;
                    string sql = $"SELECT USERNAME,TIMESTAMP,OBJ_NAME,ACTION_NAME,SQL_TEXT FROM DBA_AUDIT_TRAIL" +
                        $" WHERE OBJ_NAME = '{name}'";

                    OracleConnection conn = this.server.getConnect();

                    OracleDataAdapter odbc = new OracleDataAdapter(sql, conn);

                    conn.Open();
                    DataTable data = new DataTable();
                    odbc.Fill(data);

                    tblAudit.DataSource = data;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                lblState.Text = $"Trạng thái: Thất bại. Lỗi {ex.Message}";
            }
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbStandard.Text.Length > 0)
                {
                    string name = cbbStandard.Text;
                    string sql = $"SELECT DB_USER, TIMESTAMP, OBJECT_NAME,STATEMENT_TYPE,SQL_TEXT FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_NAME = 'DAPH_DANGKY'";

                    OracleConnection conn = this.server.getConnect();

                    OracleDataAdapter odbc = new OracleDataAdapter(sql, conn);

                    conn.Open();
                    DataTable data = new DataTable();
                    odbc.Fill(data);

                    tblAudit.DataSource = data;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                lblState.Text = $"Trạng thái: Thất bại. Lỗi {ex.Message}";
            }
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbStandard.Text.Length > 0)
                {
                    string name = cbbStandard.Text;
                    string sql = $"SELECT DB_USER, TIMESTAMP, OBJECT_NAME,STATEMENT_TYPE,SQL_TEXT FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_NAME = 'DAPH_NHANSU'";


                    OracleConnection conn = this.server.getConnect();

                    OracleDataAdapter odbc = new OracleDataAdapter(sql, conn);

                    conn.Open();
                    DataTable data = new DataTable();
                    odbc.Fill(data);

                    tblAudit.DataSource = data;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                lblState.Text = $"Trạng thái: Thất bại. Lỗi {ex.Message}";
            }
        }
    }
}
