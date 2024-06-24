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
    public partial class NhanSu_Screen : Form
    {
        string username;
        string password;
        int type;
        ConnectServer connectServer;
        OracleConnection oracleConnection;
        private Form currentChildForm;
        public NhanSu_Screen(int type, string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.type = type;
            connectServer = new ConnectServer(username, password);
            oracleConnection = connectServer.getConnect();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinNhanVien(username, password, oracleConnection));
        }

        private void button_SINHVIEN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinSinhVien(type, username, password, oracleConnection));
        }

        private void button_HOCPHAN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinHocPhan(type, username, password, oracleConnection));
        }

        private void button_DONVI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinDonVi(type, username, password, oracleConnection));
        }

        private void button_KHMO_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinKeHoachMo(type, username, password, oracleConnection)); 
        }

        private void button_GIANGDAY_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinGiangDay(type, username, password, oracleConnection));
        }

        private void button_DANGKY_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinDangKyGiangVien(type, username, password, oracleConnection));
        }
        private void NhanVienCoBan_Screen_Load(object sender, EventArgs e)
        {
            // Nhân viên cơ bản hoặc giáo vụ
            if (type == 1 || type == 3) 
            { 
                button_DANGKY.Hide();
                button_GIANGDAY.Hide();
            }
            if (type != 3)
            {
                button_PHANCONG.Hide();
                button_QUANLYDANGKYHOCPHAN.Hide();
            }
            if (type != 4)
            {
                button_PHANCONGTRGDV.Hide();
            }
            if (type != 5)
            {
                button_PHANCONG_TK.Hide();
                button_NHANSU.Hide();
            }
        }

        private void button_PHANCONG_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinPhanCong(type, username, password, oracleConnection));
        }

        private void button_QUANLYDANGKYHOCPHAN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDangKyHocPhan(type, username, password, oracleConnection));
        }

        private void button_PHANCONGTRGDV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanCongTruongDonVi(type, username, password, oracleConnection));
        }

        private void button_PHANCONG_TK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinPhanCong(type,username, password, oracleConnection));
        }

        private void button_NHANSU_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinNhanSu(type, username, password, oracleConnection));
        }
    }
}
