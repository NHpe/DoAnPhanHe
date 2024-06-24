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
using WindowsFormsApp;
using System.Timers;
using System.Diagnostics;
using System.Security.Policy;

namespace WindowsFormsApp
{
    public partial class PhanHe2 : Form
    {
        string username;
        string password;
        private System.Timers.Timer backupTimer;
        ConnectServer connectServer;
        public PhanHe2(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.connectServer = new ConnectServer(username, password);
        }

        private void PhanHe2_Load(object sender, EventArgs e)
        {

        }

        private void button_CapQuyenTryCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new CapVaiTroChoNguoiDung(connectServer);
            form.ShowDialog();
        }

        private void button_Audit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Audit(connectServer);
            form.ShowDialog();
        }

        private void button_ThongBao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new ThongBao(connectServer);
            form.ShowDialog();
        }

        private void button_Backup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Backup(connectServer);
            form.ShowDialog();
        }

    private void RecoverDatabase()
        {
            try
            {
                string rmanScript = @"
            run {
                ALLOCATE CHANNEL c1 DEVICE TYPE DISK;
                RESTORE CONTROLFILE FROM 'D:\\backup\\controlfile.bak';
                ALTER DATABASE MOUNT;
                RESTORE DATABASE;
                RECOVER DATABASE;
                ALTER DATABASE OPEN RESETLOGS;
            }";

                System.IO.File.WriteAllText("D:\\backup\\recover.rman", rmanScript);

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C rman target / @D:\\backup\\recover.rman";
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;

                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show("Recovery completed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error during recovery: " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during recovery: " + ex.Message);
            }
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            RecoverDatabase();
        }
    }
}
