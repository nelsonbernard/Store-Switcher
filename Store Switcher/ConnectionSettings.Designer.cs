namespace Store_Switcher
{
    partial class ConnectionSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label serverAddressLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label localDriveLetterLabel1;
            this.listConnections = new System.Windows.Forms.ListBox();
            this.networkConnectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionsDatabaseDataSet = new Store_Switcher.ConnectionsDatabaseDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.networkConnectionsTableAdapter = new Store_Switcher.ConnectionsDatabaseDataSetTableAdapters.NetworkConnectionsTableAdapter();
            this.tableAdapterManager = new Store_Switcher.ConnectionsDatabaseDataSetTableAdapters.TableAdapterManager();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.networkConnectionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboxAvailableDrives = new System.Windows.Forms.ComboBox();
            serverAddressLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            localDriveLetterLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.networkConnectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkConnectionsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // serverAddressLabel
            // 
            serverAddressLabel.AutoSize = true;
            serverAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serverAddressLabel.Location = new System.Drawing.Point(251, 30);
            serverAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            serverAddressLabel.Name = "serverAddressLabel";
            serverAddressLabel.Size = new System.Drawing.Size(113, 18);
            serverAddressLabel.TabIndex = 13;
            serverAddressLabel.Text = "Server Address:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(251, 65);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(81, 18);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(251, 100);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(79, 18);
            passwordLabel.TabIndex = 17;
            passwordLabel.Text = "Password:";
            // 
            // localDriveLetterLabel1
            // 
            localDriveLetterLabel1.AutoSize = true;
            localDriveLetterLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localDriveLetterLabel1.Location = new System.Drawing.Point(251, 135);
            localDriveLetterLabel1.Name = "localDriveLetterLabel1";
            localDriveLetterLabel1.Size = new System.Drawing.Size(87, 18);
            localDriveLetterLabel1.TabIndex = 23;
            localDriveLetterLabel1.Text = "Drive Letter:";
            // 
            // listConnections
            // 
            this.listConnections.DataSource = this.networkConnectionsBindingSource;
            this.listConnections.DisplayMember = "Store";
            this.listConnections.FormattingEnabled = true;
            this.listConnections.ItemHeight = 20;
            this.listConnections.Location = new System.Drawing.Point(13, 31);
            this.listConnections.Margin = new System.Windows.Forms.Padding(4);
            this.listConnections.Name = "listConnections";
            this.listConnections.Size = new System.Drawing.Size(228, 184);
            this.listConnections.TabIndex = 0;
            this.listConnections.ValueMember = "Store";
            this.listConnections.SelectedIndexChanged += new System.EventHandler(this.listConnections_SelectedIndexChanged);
            // 
            // networkConnectionsBindingSource
            // 
            this.networkConnectionsBindingSource.DataMember = "NetworkConnections";
            this.networkConnectionsBindingSource.DataSource = this.connectionsDatabaseDataSet;
            // 
            // connectionsDatabaseDataSet
            // 
            this.connectionsDatabaseDataSet.DataSetName = "ConnectionsDatabaseDataSet";
            this.connectionsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Connection List";
            // 
            // networkConnectionsTableAdapter
            // 
            this.networkConnectionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NetworkConnectionsTableAdapter = this.networkConnectionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Store_Switcher.ConnectionsDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.networkConnectionsBindingSource, "ServerAddress", true));
            this.serverAddressTextBox.Location = new System.Drawing.Point(370, 31);
            this.serverAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(173, 27);
            this.serverAddressTextBox.TabIndex = 14;
            this.serverAddressTextBox.ModifiedChanged += new System.EventHandler(this.serverAddressTextBox_ModifiedChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.networkConnectionsBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(370, 66);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(173, 27);
            this.usernameTextBox.TabIndex = 16;
            this.usernameTextBox.ModifiedChanged += new System.EventHandler(this.usernameTextBox_ModifiedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.networkConnectionsBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(370, 101);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(173, 27);
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.ModifiedChanged += new System.EventHandler(this.passwordTextBox_ModifiedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(254, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 37);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 37);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "(192.168.3.10\\Path\\To\\Executable)";
            // 
            // networkConnectionsBindingSource1
            // 
            this.networkConnectionsBindingSource1.DataMember = "NetworkConnections";
            this.networkConnectionsBindingSource1.DataSource = this.connectionsDatabaseDataSet;
            // 
            // cboxAvailableDrives
            // 
            this.cboxAvailableDrives.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.networkConnectionsBindingSource, "LocalDriveLetter", true));
            this.cboxAvailableDrives.FormattingEnabled = true;
            this.cboxAvailableDrives.Location = new System.Drawing.Point(370, 135);
            this.cboxAvailableDrives.Name = "cboxAvailableDrives";
            this.cboxAvailableDrives.Size = new System.Drawing.Size(173, 28);
            this.cboxAvailableDrives.TabIndex = 24;
            this.cboxAvailableDrives.SelectionChangeCommitted += new System.EventHandler(this.cboxAvailableDrives_SelectionChangeCommitted);
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(555, 227);
            this.Controls.Add(localDriveLetterLabel1);
            this.Controls.Add(this.cboxAvailableDrives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(serverAddressLabel);
            this.Controls.Add(this.serverAddressTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listConnections);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Manager";
            this.Load += new System.EventHandler(this.ConnectionSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.networkConnectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkConnectionsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listConnections;
        private System.Windows.Forms.Label label5;
        private ConnectionsDatabaseDataSet connectionsDatabaseDataSet;
        private System.Windows.Forms.BindingSource networkConnectionsBindingSource;
        private ConnectionsDatabaseDataSetTableAdapters.NetworkConnectionsTableAdapter networkConnectionsTableAdapter;
        private ConnectionsDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox serverAddressTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource networkConnectionsBindingSource1;
        private System.Windows.Forms.ComboBox cboxAvailableDrives;
    }
}