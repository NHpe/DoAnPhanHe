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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp
{
    public partial class ThongTinPhanCong : Form
    {
        string username;
        string password;
        int type;
        OracleConnection oracleConnection;
        public ThongTinPhanCong(int type, string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.type = type;
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        private DataTable LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.DAPH_PHANCONG";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(str, oracleConnection);

            DataTable data = new DataTable();
            oracleDataAdapter.Fill(data);
            return data;
        }

        private void ThongTinPhanCong_Load(object sender, EventArgs e)
        {
            if (type == 3)
            {
                button_Them.Hide();
                button_Xoa.Hide();
            }
            dataGridView1.DataSource = LoadData();
        }

        string magv, mahp, hk, nam, mact;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == 3 || type == 5) 
            { 
                try
                {
                    magv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    mahp = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    hk = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    nam = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    mact = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                    string str = $"SELECT * FROM DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    
                    if (oracleConnection.State != ConnectionState.Open)
                        oracleConnection.Open();
                    OracleDataReader check = cmd.ExecuteReader();
                    if (check.Read())
                    {
                        textBox_MAGV.Text = magv;
                        textBox_MAHP.Text = mahp;
                        textBox_HK.Text = hk;
                        textBox_NAM.Text = nam;
                        textBox_MACT.Text = mact;
                    }
                    else
                    {
                        magv = "";
                        mahp = "";
                        hk = "";
                        nam = "";
                        mact = "";
                    }
                    oracleConnection.Close();
                }
                catch 
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_MAGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA SET MAGV = '{textBox_MAGV.Text}' WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        string commnit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commnit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                    magv = textBox_MAGV.Text;
                }
                catch 
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_MAHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA SET MAHP = '{textBox_MAHP.Text}' WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        string commnit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commnit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                    mahp = textBox_MAHP.Text;
                }
                catch 
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_HK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA SET HK = {textBox_HK.Text} WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        string commnit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commnit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                    hk = textBox_HK.Text;
                }
                catch
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_NAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA SET NAM = {textBox_NAM.Text} WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        string commnit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commnit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                    nam = textBox_NAM.Text;
                }
                catch 
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void textBox_MACT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA SET MACT = '{textBox_MACT.Text}' WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        string commnit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commnit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                    dataGridView1.DataSource = LoadData();
                    mact = textBox_MACT.Text;
                }
                catch 
                {
                    if (oracleConnection.State == ConnectionState.Open)
                    {
                        oracleConnection.Close() ;
                    }
                }
            }
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            magv = textBox_MAGV.Text = "";
            mahp = textBox_MAHP.Text = "";
            hk = textBox_HK.Text = "";
            nam = textBox_NAM.Text = "";
            mact = textBox_MACT.Text = "";
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string chech_exist_mahp = $"SELECT HP.MAHP FROM DAPH_ADMIN1.DAPH_DONVI DV, DAPH_ADMIN1.DAPH_HOCPHAN HP WHERE DV.MADV = HP.MADV AND DV.TENDV = N'Văn phòng khoa' AND HP.MAHP = '{textBox_MAHP.Text}'";
                OracleCommand cmdCheckExist = new OracleCommand(chech_exist_mahp, oracleConnection);

                oracleConnection.Open();
                OracleDataReader check_exist_reader = cmdCheckExist.ExecuteReader();
                if (check_exist_reader.Read())
                {
                    string insert = $"INSERT INTO DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA VALUES ('{textBox_MAGV.Text}', '{textBox_MAHP.Text}', {textBox_HK.Text}, {textBox_NAM.Text}, '{textBox_MACT.Text}')";
                    OracleCommand cmdInsert = new OracleCommand(insert, oracleConnection);
                    int resultInsert = cmdInsert.ExecuteNonQuery();

                    if (resultInsert == 1)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }

                    dataGridView1.DataSource = LoadData();
                    magv = textBox_MAGV.Text;
                    mahp = textBox_MAHP.Text;
                    hk = textBox_HK.Text;
                    nam = textBox_NAM.Text;
                    mact = textBox_MACT.Text;
                }
                oracleConnection.Close( );
            }
            catch 
            {
                if (oracleConnection.State == ConnectionState.Open)
                {
                    oracleConnection.Close();
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string str = $"DELETE FROM DAPH_ADMIN1.VIEW_PHAN_CONG_HOC_PHAN_VAN_PHONG_KHOA WHERE MAGV = '{magv}' AND MAHP = '{mahp}' AND HK = {hk} AND NAM = {nam} AND MACT = '{mact}'";
                OracleCommand cmd = new OracleCommand(str, oracleConnection);

                oracleConnection.Open( );
                int result = cmd.ExecuteNonQuery();

                if ( result == 1 )
                {
                    string commit = "COMMIT";
                    OracleCommand cmdCommit = new OracleCommand( commit, oracleConnection);
                    cmdCommit.ExecuteNonQuery();
                }
                oracleConnection.Close();

                dataGridView1.DataSource = LoadData( );

                magv = textBox_MAGV.Text = "";
                mahp = textBox_MAHP.Text = "";
                hk = textBox_HK.Text = "";
                nam = textBox_NAM.Text = "";
                mact = textBox_MACT.Text = "";
            }
            catch 
            {
                if (oracleConnection.State == ConnectionState.Open)
                {
                    oracleConnection.Close();
                }
            }
        }
    }
}
