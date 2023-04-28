using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class Register : Form
    {
        private string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        OracleConnection conn;
        string dbstr = "data source = orcl; user id=hr; password=hr";

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(dbstr);
            conn.Open();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (emailTV.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Email can't be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } 
            else if (!Regex.IsMatch(emailTV.Text.Trim(), pattern))
            {
                MessageBox.Show("Invalid Email", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passwordTV.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Password can't be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (passwordTV.Text.Trim() != passwordConfTV.Text.Trim())
            {
                MessageBox.Show("The Password and Password confirmation fields do not match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                register();

                


            }
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getMaxId().ToString(), "ddd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            var login = new Login();
            this.Hide();
            login.Show();
        }

        private void register()
        {

            string sqlQuery = "INSERT INTO users values (:id, :name , :email , :phone_number , :password , :balance , :isAdmin)";

            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = sqlQuery;
            comm.Parameters.Add("id", getMaxId());
            comm.Parameters.Add("name", nameTV.Text.Trim());
            comm.Parameters.Add("email", emailTV.Text.Trim());
            comm.Parameters.Add("phone_number", phoneTV.Text.Trim());
            comm.Parameters.Add("password", passwordTV.Text.Trim());
            comm.Parameters.Add("balance", balanceTV.Text.Trim());
            comm.Parameters.Add("isAdmin", isAdminCheckBox.Checked ? 1 : 0);

            int res = comm.ExecuteNonQuery();

            if (res != -1)
            {
                var login = new Login();
                this.Hide();
                login.Show();


            } else
            {
                MessageBox.Show("Something went wrong", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        private int getMaxId()
        {
            string procName = "GetMaxUserID";
            int lastId, newId;

            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = procName;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            comm.ExecuteNonQuery();
            try
            {
                lastId = Convert.ToInt32(comm.Parameters["id"].Value.ToString());
                newId = lastId + 1;
            }
            catch
            {
                newId = -1;
            }
            return newId;
        }
    }
}
