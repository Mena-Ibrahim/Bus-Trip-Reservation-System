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

namespace ODP1_Connected_Start.UserControls
{
    public partial class UserControl2 : UserControl
    {
        OracleConnection conn;
        string dbstr = "data source = orcl; user id=hr; password=hr";
        static int userId;
        public UserControl2(int id)
        {
            userId = id;
            InitializeComponent();
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {

            string sqlQuery = "SELECT count(*) FROM reservations where user_id = :id";

            conn = new OracleConnection(dbstr);
            conn.Open();


            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = sqlQuery;
            comm.Parameters.Add("id", userId);

            int count = Convert.ToInt32(comm.ExecuteScalar());

            if (count > 0)
            {
                label1.Visible = false;

                comm.CommandText = "SELECT * FROM reservations where user_id = :id";

                OracleDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    reservationGrideView.Rows.Add(dr[0], dr[2], dr[4]);
                }

                reservationGrideView.Visible = true;

            } else
            {
                reservationGrideView.Visible = false;
                label1.Visible = true;


            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reservationGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
