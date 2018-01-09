using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Store_Switcher
{
    public partial class ConnectionSettings : Form
    {


        public ConnectionSettings()
        {
            InitializeComponent();
        }

        private void listConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.connectionsDatabaseDataSet.RejectChanges();
            //this.networkConnectionsBindingSource.EndEdit();

            //AvailableDrives();

            using (SqlConnection con = new SqlConnection(Store_Switcher.Properties.Settings.Default.ConnectionsDatabaseConnectionString))
            {
                string query = "SELECT * FROM NetworkConnections WHERE Store = @storeName";

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@storeName", listConnections.GetItemText(listConnections.SelectedItem));
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.serverAddressTextBox.Text = dr["ServerAddress"].ToString();
                   // this.localDriveLetterTextBox.Text = dr["LocalDriveLetter"].ToString();
                    this.usernameTextBox.Text = dr["Username"].ToString();
                    this.passwordTextBox.Text = dr["Password"].ToString();

                    if (dr["LocalDriveLetter"].ToString() != "")
                        this.cboxAvailableDrives.SelectedItem = dr["LocalDriveLetter"].ToString();
                    else
                        this.cboxAvailableDrives.Text = "";

                }

                con.Close();
            }



            this.serverAddressTextBox.Modified = false;
            this.usernameTextBox.Modified = false;
            this.passwordTextBox.Modified = false;
            //this.localDriveLetterTextBox.Modified = false;
            this.btnSave.Enabled = false;
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'connectionsDatabaseDataSet.NetworkConnections' table. You can move, or remove it, as needed.
            this.networkConnectionsTableAdapter.Fill(this.connectionsDatabaseDataSet.NetworkConnections);
            //AvailableDrives();
            btnSave.Enabled = false;     
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.serverAddressTextBox.Text))
                MessageBox.Show("Server Address and Local Drive box cannot be blank");
            else
                SaveChanges();
        }

        private void SaveChanges()
        {
            using (SqlConnection sqlconn = new SqlConnection(Store_Switcher.Properties.Settings.Default.ConnectionsDatabaseConnectionString))
            {
                string query = "UPDATE NetworkConnections SET ServerAddress = @ServerAddress, Username = @Username, Password = @Password, LocalDriveLetter = @LocalDrive WHERE Store = @storeName";
                SqlCommand cmd = new SqlCommand(query, sqlconn);

                cmd.Parameters.AddWithValue("@ServerAddress", serverAddressTextBox.Text);
                cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@LocalDrive", cboxAvailableDrives.Text);
                cmd.Parameters.AddWithValue("@storeName", listConnections.GetItemText(listConnections.SelectedItem));

                sqlconn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    throw new Exception("Error: Could not save changes " + e.Message);
                }

                sqlconn.Close();
            }

            btnSave.Enabled = false;
        }

        private void serverAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.serverAddressTextBox.Modified)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Modified)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Modified)
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void serverAddressTextBox_ModifiedChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void usernameTextBox_ModifiedChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void passwordTextBox_ModifiedChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
        }

        private void AvailableDrives()
        {
            List<string> availableDriveLetters = new List<string>();
            BindingSource bs = new BindingSource();
            bs.DataSource = availableDriveLetters;           

            for(int x = 65; x <= 90; x++)
            {
                char driveLetter = Convert.ToChar(x);
                string formattedDriveLetter = driveLetter + @":\";
                availableDriveLetters.Add(formattedDriveLetter);
            }

            foreach(string drive in System.IO.Directory.GetLogicalDrives())
            {
                availableDriveLetters.Remove(drive);
            }

            cboxAvailableDrives.DataSource = bs.DataSource;            
        }

        private void cboxAvailableDrives_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

    }
}
