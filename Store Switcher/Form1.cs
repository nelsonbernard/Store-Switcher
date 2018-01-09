using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Store_Switcher
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection conDPN = new Connection("Pawndex North");

            conDPN.Disconnect();
            int result = conDPN.Connect();

            if(result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conDPN.StartPawndex();
                form.Enabled = true;
                form.Activate();
            }

            conDPN.Disconnect();
                        
        }

        private void btnPE_Click(object sender, EventArgs e)
        {
            Connection conDPE = new Connection("Pawndex East");
            conDPE.Disconnect();
            int result = conDPE.Connect();

            if (result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conDPE.StartPawndex();
                form.Enabled = true;
                form.Activate();
            }
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            Connection conDPS = new Connection("Pawndex South");
            conDPS.Disconnect();
            int result = conDPS.Connect();

            if (result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conDPS.StartPawndex();
                form.Enabled = true;
                form.Activate();
            }
        }

        private void btnPW_Click(object sender, EventArgs e)
        {
            Connection conDPW = new Connection("Pawndex West");
            conDPW.Disconnect();
            int result = conDPW.Connect();

            if (result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conDPW.StartPawndex();
                form.Enabled = true;
                form.Activate();
            }
        }

        private void btnTLNorth_Click(object sender, EventArgs e)
        {
            Connection conTLN = new Connection("Title Loan's North");
            conTLN.Disconnect();
            int result = conTLN.Connect();

            if (result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conTLN.StartTitleLoans();
                form.Enabled = true;
                form.Activate();
            }
        }

        private void btnTLEast_Click(object sender, EventArgs e)
        {
            Connection conTLE = new Connection("Title Loans East");
            conTLE.Disconnect();
            int result = conTLE.Connect();

            if (result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conTLE.StartTitleLoans();
                form.Enabled = true;
                form.Activate();
            }
        }

        private void btnTLS_Click(object sender, EventArgs e)
        {
            Connection conTLS = new Connection("Title Loans South");
            conTLS.Disconnect();
            int result = conTLS.Connect();

            if (result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conTLS.StartTitleLoans();
                form.Enabled = true;
                form.Activate();
            }
        }

        private void btnTLW_Click(object sender, EventArgs e)
        {
            Connection conTLW = new Connection("Title Loans West");
            conTLW.Disconnect();
            int result = conTLW.Connect();

            if (result != 0)
            {
                Form form = this.FindForm();
                form.Enabled = false;
                conTLW.StartTitleLoans();
                form.Enabled = true;
                form.Activate();
            }
        }

        private void connectionSetttingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionSettings formConnections = new ConnectionSettings();
            formConnections.ShowDialog(this);            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
