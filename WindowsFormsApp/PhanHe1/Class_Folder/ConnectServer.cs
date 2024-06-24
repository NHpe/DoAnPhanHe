using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class ConnectServer
    {
        string conStr;
        public ConnectServer(string userID, string password)
        {
            if (userID == "DAPH_ADMIN")
            {
                conStr = $"DATA SOURCE=localhost:1521/XE;DBA PRIVILEGE = SYSDBA;PERSIST SECURITY INFO=True;USER ID={userID};PASSWORD={password}";
            }
            else
            {
                conStr = $"DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True;USER ID={userID};PASSWORD={password}";
            }
        }
        public OracleConnection getConnect()
        {
            return new OracleConnection(conStr);
        }
    }
}
