using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace Store_Switcher
{
    class Connection : IDisposable
    {
        #region defines
        [DllImport("Mpr.dll", EntryPoint = "WNetAddConnection2", CallingConvention = CallingConvention.Winapi)]
        private static extern int WNetAddConnection2(NETRESOURCE lpNetResource, string lpPassword,
                      string lpUsername, System.UInt32 dwFlags);

        [DllImport("Mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags, bool force);

        [StructLayout(LayoutKind.Sequential)]
        private class NETRESOURCE
        {
            public ResourceScope dwScope = 0;
            public ResourceType dwType = 0;
            public ResourceDisplayType dwDisplayType = 0;
            public ResourceUsage dwUsage = 0;
            public string lpLocalName = null;
            public string lpRemoteName = null;
            public string lpComment = null;
            public string lpProvider = null;
        };

        public enum ResourceScope
        {
            RESOURCE_CONNECTED = 1,
            RESOURCE_GLOBALNET,
            RESOURCE_REMEMBERED,
            RESOURCE_RECENT,
            RESOURCE_CONTEXT
        };

        public enum ResourceType
        {
            RESOURCETYPE_ANY,
            RESOURCETYPE_DISK,
            RESOURCETYPE_PRINT,
            RESOURCETYPE_RESERVED
        };

        public enum ResourceUsage
        {
            RESOURCEUSAGE_CONNECTABLE = 0x00000001,
            RESOURCEUSAGE_CONTAINER = 0x00000002,
            RESOURCEUSAGE_NOLOCALDEVICE = 0x00000004,
            RESOURCEUSAGE_SIBLING = 0x00000008,
            RESOURCEUSAGE_ATTACHED = 0x00000010,
            RESOURCEUSAGE_ALL = (RESOURCEUSAGE_CONNECTABLE | RESOURCEUSAGE_CONTAINER | RESOURCEUSAGE_ATTACHED),
        };

        public enum ResourceDisplayType
        {
            RESOURCEDISPLAYTYPE_GENERIC,
            RESOURCEDISPLAYTYPE_DOMAIN,
            RESOURCEDISPLAYTYPE_SERVER,
            RESOURCEDISPLAYTYPE_SHARE,
            RESOURCEDISPLAYTYPE_FILE,
            RESOURCEDISPLAYTYPE_GROUP,
            RESOURCEDISPLAYTYPE_NETWORK,
            RESOURCEDISPLAYTYPE_ROOT,
            RESOURCEDISPLAYTYPE_SHAREADMIN,
            RESOURCEDISPLAYTYPE_DIRECTORY,
            RESOURCEDISPLAYTYPE_TREE,
            RESOURCEDISPLAYTYPE_NDSCONTAINER
        };
        #endregion defines       

        public string serverName;
        public string username;
        public string password;
        public string localName;
        public string storeName;

        public Connection(string storeName)
        {
            this.storeName = storeName;
            Initialize();            
        }

        public int Connect()
        {
            NETRESOURCE nr = new NETRESOURCE();
            nr.dwType = ResourceType.RESOURCETYPE_DISK;
            nr.lpLocalName = this.localName;
            nr.lpRemoteName = this.serverName;
            nr.lpProvider = null;

            int result = WNetAddConnection2(nr, this.password, this.username, 0);
            
            if (result != 0)
                MessageBox.Show("Could not connect to " + this.storeName);
            else
                MessageBox.Show("Connected successfully");

            return result;
        }

        public virtual void Disconnect()
        {
            WNetCancelConnection2(this.localName, 0, true);
        }

        public void StartPawndex()
        {
            KillOpenPawndex();

            ProcessStartInfo processInfo;
            Process process = new Process();
            string pawndexStartString = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";

            processInfo = new ProcessStartInfo(pawndexStartString, null);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = true;            

            process = Process.Start(processInfo);

            process.WaitForExit();
        }

        public void StartTitleLoans()
        {
            KillOpenTitleLoans();

            ProcessStartInfo processInfo;
            Process process = new Process();
            string titleLoansStartString = @"c:\program files (x86)\microsoft\office10\msaccess.exe " + serverName + "\try.bat";

            processInfo = new ProcessStartInfo(titleLoansStartString, null);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = true;

            process = Process.Start(processInfo);

            process.WaitForExit();
        }

        private void Initialize()
        {
            SqlConnection con = new SqlConnection(Store_Switcher.Properties.Settings.Default.ConnectionsDatabaseConnectionString);
            string sql = "SELECT * FROM NetworkConnections WHERE Store = @storeName";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@storeName", storeName);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.serverName = dr["ServerAddress"].ToString();
                this.localName = dr["LocalDriveLetter"].ToString();
                this.username = dr["Username"].ToString();
                this.password = dr["Password"].ToString();
            }

            con.Close();
        }
        
        public void KillOpenPawndex()
        {
            Process[] processes = Process.GetProcessesByName("pawndex");

            foreach(Process process in processes)
            {
                process.Kill();
            }
        }

        public void KillOpenTitleLoans()
        {
            Process[] processes = Process.GetProcessesByName("tlpro");

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
