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

namespace ODP1_Connected_Start.UserControls
{
    public partial class Trips : UserControl
    {

        OracleConnection conn;
        string dbstr = "data source = orcl; user id=hr; password=hr";
        public Trips()
        {
            InitializeComponent();
        }

        private void Trips_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(dbstr);
            conn.Open();


            avaliableTrips.Columns.Add("ID", "ID");
            avaliableTrips.Columns.Add("From", "From");
            avaliableTrips.Columns.Add("To", "To");
            avaliableTrips.Columns.Add("Leaving Time", "Leaving Time");
            avaliableTrips.Columns.Add("ARRIVAL Time", "ARRIVAL Time");
            avaliableTrips.Columns.Add("Price", "Price");
            avaliableTrips.Columns.Add("Avaliable Seats", "Avaliable Seats");

            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "GetTrips";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("allTrips", OracleDbType.RefCursor, ParameterDirection.Output);


            OracleDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    avaliableTrips.Rows.Add(dr[0], dr[1] , dr[3] , dr[2] , dr[4] , dr[5] , dr[6]);
                
                }
            dr.Close();
        }

        private void avaliableTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void avaliableTrips_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
