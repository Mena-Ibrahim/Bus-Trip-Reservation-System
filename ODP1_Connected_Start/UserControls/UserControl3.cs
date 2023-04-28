using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace NavigationView.UserControls
{
    public partial class UserControl3 : UserControl
    {
        OracleConnection conn;
        string dbstr = "data source = orcl; user id=hr; password=hr";
        static int userId;
        public UserControl3(int id)
        {
            userId = id;
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(dbstr);
            conn.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buy_Click(object sender, EventArgs e)
        {

            if (tripIdTV.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Please enter trip id", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            } else if (!radioButton1.Checked  && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please pick a payment method", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            } else
            {
                    MessageBox.Show("gamed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    string paymentMethod;

                    if (radioButton1.Checked)
                    {
                        paymentMethod = "Visa Card";
                    }
                    else if (radioButton2.Checked)
                    {
                        paymentMethod = "Credit Card";

                    }
                    else
                    {
                        paymentMethod = "Paypal";

                    }

                    string sqlQuery = "SELECT * FROM trips where id = :id";


                    OracleCommand comm = new OracleCommand();
                    comm.Connection = conn;
                    comm.CommandText = sqlQuery;
                    comm.Parameters.Add("id", tripIdTV.Text.Trim());

                    OracleDataReader dr = comm.ExecuteReader();

                    if (dr.Read())
                    {
                        comm = new OracleCommand();
                        comm.Connection = conn;
                        comm.CommandText = "Select Balance from users where id = :userId";
                        comm.Parameters.Add("userId", userId);

                        OracleDataReader userDr = comm.ExecuteReader();

                        if (userDr.Read())
                        {
                            if (Convert.ToInt32(userDr[0]) < Convert.ToInt32(dr[5]))
                            {
                                MessageBox.Show("There is no enough balance", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {

                                // ID
                                // USER_ID
                                // TRIP_ID
                                // AMOUNT
                                // PAYMENT_METHOD


                                comm = new OracleCommand();
                                comm.Connection = conn;
                                comm.CommandText = "INSERT INTO reservations values (:id, :user_id , :trip_id , :amount , :payment_method)";
                                //insert into reservations(id, user_id, trip_id, amount, payment_method) values(1, 1, 1, 100, 'Card');

                                comm.Parameters.Add("id", getMaxId());
                                comm.Parameters.Add("user_id", userId);
                                comm.Parameters.Add("trip_id", dr[0]);
                                comm.Parameters.Add("amount", dr[5]);
                                comm.Parameters.Add("payment_method", paymentMethod);

                                int res = comm.ExecuteNonQuery();


                                if (res != -1)
                                {

                                    MessageBox.Show("Done", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                else
                                {
                                    MessageBox.Show("Something went wrong", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("Something went wrong", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }


                    }
                    else
                    {
                        MessageBox.Show("Trip not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

            }

           


           

        }

        private int getMaxId()
        {
            string procName = "GetMaxReservationsID";
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
