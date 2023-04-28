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
    public partial class Login : Form
    {
        
        private string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        OracleConnection conn;
        string dbstr = "data source = orcl; user id=hr; password=hr";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(dbstr);
            conn.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            var register = new Register();
            this.Hide();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Email can't be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!Regex.IsMatch(textBox1.Text.Trim(), pattern))
            {
                MessageBox.Show("Invalid Email", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Password can't be empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                login(textBox1.Text.Trim(), textBox2.Text.Trim());

            }


        }

        void login (string email , string password)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "SELECT Count(*) FROM users WHERE email = :email AND password = :password";
            command.CommandType = CommandType.Text;
            command.Parameters.Add("email", textBox1.Text.Trim());
            command.Parameters.Add("password", textBox2.Text.Trim());

            //Execute scalar returns a cell in the first row and the first column
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0) // login successful
            {
                command.CommandText = "SELECT isAdmin FROM users WHERE email = :email AND password = :password";
                bool isAdmin = Convert.ToBoolean(command.ExecuteScalar());

                if (isAdmin)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Hide();
                }
                else
                {
                    command.CommandText = "SELECT id FROM users WHERE email = :email AND password = :password";
                    var id = Convert.ToInt32(command.ExecuteScalar());

                    Home home = new Home(id);
                    home.Show();
                    Hide();

                }
            }
            else //login failed
            {
                MessageBox.Show("Incorrect email or password, please try again.");

            }

            command.Dispose();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }
    }
}
