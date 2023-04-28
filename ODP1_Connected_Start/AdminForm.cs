using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class AdminForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public AdminForm()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            string table = "";
            if (radioUsers.Checked)
            {
                table = "users";
            }
            else if (radioTrips.Checked)
            {
                table = "trips";
            }
            else if (radioReservations.Checked)
            {
                table = "reservations";
            }
            else if (radioRefunds.Checked)
            {
                table = "refunds";
            }
            string Command = "select * from " + table;
            adapter = new OracleDataAdapter(Command, ConnectionManager.ConnectionString);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGrd.DataSource = ds.Tables[0];
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ds != null)
            {
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Changes Saved!");
            }

        }
        private void radioUsers_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void radioTrips_CheckedChanged(object sender, EventArgs e)
        {
            loadData();

        }

        private void radioReservations_CheckedChanged(object sender, EventArgs e)
        {
            loadData();

        }

        private void radioRefunds_CheckedChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
    }
}
