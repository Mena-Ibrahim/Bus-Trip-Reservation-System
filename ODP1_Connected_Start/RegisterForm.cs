using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ODP1_Connected_Start
{
    public partial class RegisterForm : Form
    {
        OracleConnection connection;
        public RegisterForm()
        {
            InitializeComponent();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register(txtName.Text, txtEmail.Text, txtPassword.Text, txtConfirmPassword.Text, txtPhone.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void register(string Name, string Email, string Password, string ConfirmPassword, string Phone) {

            // Check if all fields are filled:
            if (Name == "" || Email == "" || Password == "" || ConfirmPassword == "" || Phone == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            // Check if email is unique:
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Count(*) FROM users WHERE lower(email) = :email";
            command.CommandType = CommandType.Text;
            command.Parameters.Add("email", Email);

            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Email already exists.");
                return;
            }
            // Check if passwords match:
            if (! Password.Equals(ConfirmPassword))
            {
                MessageBox.Show("Passwords not matching");
                return;
            }

            // Get max id and increment by 1:
            int maxID, newID;
            OracleCommand maxIDCommand = new OracleCommand();
            maxIDCommand.Connection = connection;
            maxIDCommand.CommandText = "GetMaxUserID";
            maxIDCommand.CommandType = CommandType.StoredProcedure;
            maxIDCommand.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            maxIDCommand.ExecuteNonQuery();

            try
            {
                maxID = Convert.ToInt32(maxIDCommand.Parameters["id"].Value.ToString());
                newID = maxID + 1;
            }
            catch 
            {
                // First user to be created.
                newID = 1;
            }

            // Insert user:
            OracleCommand insertCommand = new OracleCommand();
            insertCommand.Connection = connection;
            insertCommand.CommandText = "INSERT INTO users (id, name, email, phone_number, password, balance, isadmin) " +
                "VALUES (:id, :name, :email, :phone, :password, :balance, :isadmin)";
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.Add(new OracleParameter("id", newID));
            insertCommand.Parameters.Add(new OracleParameter("name", Name));
            insertCommand.Parameters.Add(new OracleParameter("email", Email));
            insertCommand.Parameters.Add(new OracleParameter("phone", Phone));
            insertCommand.Parameters.Add(new OracleParameter("password", Password));
            insertCommand.Parameters.Add(new OracleParameter("balance", OracleDbType.Decimal)).Value = 0;
            insertCommand.Parameters.Add(new OracleParameter("isadmin", OracleDbType.Decimal)).Value = 0;
            insertCommand.ExecuteNonQuery();

            command.Dispose();
            maxIDCommand.Dispose();
            insertCommand.Dispose();

            MessageBox.Show("Registered successfully");

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ConnectionManager.ConnectionString);
            connection.Open();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Dispose();
        }
    }
}
