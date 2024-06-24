using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Backup : Form
    {
        ConnectServer connectServer;
        System.Timers.Timer backupTimer;
        Label lblState;

        public Backup(ConnectServer connectServer)
        {
            InitializeComponent();
            this.connectServer = connectServer;
        }

        private void BackupDatabase()
        {
            try
            {
                using (OracleConnection conn = connectServer.getConnect())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        // Backup control file
                        cmd.CommandText = "ALTER DATABASE BACKUP CONTROLFILE TO 'D:\\backup\\controlfile.bak'";
                        cmd.ExecuteNonQuery();
                        // Backup log files
                        cmd.CommandText = "ALTER SYSTEM ARCHIVE LOG CURRENT";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "ALTER SYSTEM SWITCH LOGFILE";
                        cmd.ExecuteNonQuery();
                    }

                    // Backup audit logs
                    BackupAuditLogs(conn, "DBA_AUDIT_TRAIL", "D:\\backup\\dba_audit_trail.bak");
                    BackupAuditLogs(conn, "DBA_FGA_AUDIT_TRAIL", "D:\\backup\\dba_fga_audit_trail.bak");

                }
                MessageBox.Show("Backup completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during backup: {ex.Message}");
            }
        }

        private void BackupAuditLogs(OracleConnection conn, string tableName, string backupPath)
        {
            string query = $"SELECT * FROM {tableName}";
            using (OracleCommand cmd = new OracleCommand(query, conn))
            using (OracleDataReader reader = cmd.ExecuteReader())
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(backupPath))
            {
                // Write column headers
                string[] columnNames = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                writer.WriteLine(string.Join(",", columnNames));

                // Write rows
                while (reader.Read())
                {
                    string[] rowValues = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        rowValues[i] = reader[i].ToString();
                    }
                    writer.WriteLine(string.Join(",", rowValues));
                }
            }
        }

        private void StartAutoBackup()
        {
            backupTimer = new System.Timers.Timer(86400000); // 24 hours in milliseconds
            backupTimer.Elapsed += PerformAutoBackup;
            backupTimer.AutoReset = true;
            backupTimer.Enabled = true;
            MessageBox.Show("Auto Backup started. It will run every 24 hours.");
        }

        private void PerformAutoBackup(object source, ElapsedEventArgs e)
        {
            BackupDatabase();
        }

        private void btnManualBackup_Click(object sender, EventArgs e)
        {
            BackupDatabase();
        }

        private void btnAutoBackup_Click(object sender, EventArgs e)
        {
            StartAutoBackup();
        }
    }
}