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
    public partial class XemThongTinQuyenUser : Form
    {
        ConnectServer connectServer;
        string username;
        OracleDataAdapter odbc;
        dba_tab_privs_database dba_Tab_Privs_Database;
        public XemThongTinQuyenUser(ConnectServer conn, string username)
        {
            InitializeComponent();
            this.connectServer = conn;
            this.username = username;
            dba_Tab_Privs_Database = new dba_tab_privs_database(connectServer, username);
        }

        public void XemThongTinQuyen_Load(object sender, EventArgs e)
        {
            dataGridView_XemQuyen.DataSource = dba_Tab_Privs_Database.getPrivs();
        }

        public void XemThongTinRole_Load(object sender, EventArgs e)
        {
            dataGridView_XemRole.DataSource = dba_Tab_Privs_Database.getRole();
        }
    }
}
