using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class XemThongTinRole : Form { 
        ConnectServer connectServer;
        string role;
        OracleDataAdapter odbc;
        dba_role_privs_database dba_role_privs_Database;

        public XemThongTinRole(ConnectServer conn, string role)
        {
            InitializeComponent();
            this.connectServer = conn;
            this.role = role;
            dba_role_privs_Database = new dba_role_privs_database(connectServer, role);
        }

        public void XemThongTinRole_Load(object sender, EventArgs e)
        {
            dataGridView_XemQuyen.DataSource = dba_role_privs_Database.getRolePrivs();
        }

        public void XemThongTinBang_Load(object sender, EventArgs e)
        {
            dataGridView_XemRole.DataSource = dba_role_privs_Database.getRole();
        }
    }
}
