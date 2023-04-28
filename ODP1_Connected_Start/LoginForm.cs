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
    public partial class LoginForm : Form
    {
        OracleConnection connection;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text.ToLower();
            string Password = txtPassword.Text;

            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Count(*) FROM users WHERE lower(email) = :email AND password = :password";
            command.CommandType= CommandType.Text;
            command.Parameters.Add("email", Email);
            command.Parameters.Add("password", Password);

            //Execute scalar returns a cell in the first row and the first column
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0) // login successful
            {
                command.CommandText = "SELECT isAdmin FROM users WHERE lower(email) = :email AND password = :password";
                bool isAdmin = Convert.ToBoolean(command.ExecuteScalar());

                if (isAdmin)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("normal user");
                }
            }
            else //login failed
            {
                MessageBox.Show("Incorrect email or password, please try again.");

            }

            command.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ConnectionManager.ConnectionString);
            connection.Open();

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Dispose();
        }
    }
}
