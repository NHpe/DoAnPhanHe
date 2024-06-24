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
    public partial class ThongTinNhanVien : Form
    {
        string username;
        string password;
        OracleConnection oracleConnection;
        public ThongTinNhanVien(string username, string password, OracleConnection oracleConnection)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.oracleConnection = oracleConnection;
        }

        string manv, hoten, phai, ngsinh, phucap, dt, vaitro, madv;
        private void LoadData()
        {
            string str = $"SELECT * FROM DAPH_ADMIN1.VIEW_THONG_TIN_NHAN_VIEN_CO_BAN";

            OracleCommand cmd = new OracleCommand(str);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = str;
            cmd.Connection = oracleConnection;

            if (oracleConnection.State == ConnectionState.Closed)
                oracleConnection.Open();
            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            oracleDataReader.Read();
            manv = oracleDataReader.GetString(0);
            hoten = oracleDataReader.GetString(1);
            phai = oracleDataReader.GetString(2);
            ngsinh = oracleDataReader.GetString(3);
            phucap = oracleDataReader.GetString(4);
            dt = oracleDataReader.GetString(5);
            vaitro = oracleDataReader.GetString(6);
            madv = oracleDataReader.GetString(7);

            oracleConnection.Close();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            textBox_MANV.Text = username;

            LoadData();

            textBox_HOTEN.Text = hoten;
            textBox_PHAI.Text = phai;
            textBox_NGSINH.Text = ngsinh;
            textBox_PHUCAP.Text = phucap;
            textBox_DT.Text = dt;
            textBox_VAITRO.Text = vaitro;
            textBox_MADV.Text = madv;
        }

        private void textBox_DT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string str = $"UPDATE DAPH_ADMIN1.VIEW_THONG_TIN_NHAN_VIEN_CO_BAN SET DT = '" + textBox_DT.Text + "' WHERE MANV = '" + username + "'";
                    OracleCommand cmd = new OracleCommand(str, oracleConnection);
                    oracleConnection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        string commit = "COMMIT";
                        OracleCommand cmdCommit = new OracleCommand(commit, oracleConnection);
                        cmdCommit.ExecuteNonQuery();
                    }
                    oracleConnection.Close();
                }
                catch { }
            }
        }
    }
}
