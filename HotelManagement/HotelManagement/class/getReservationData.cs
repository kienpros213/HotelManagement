using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HotelManagement
{
    public class getReservationData
    {
        public static void getData(System.Windows.Forms.TextBox _reservationIDBox, System.Windows.Forms.TextBox _customerIDBox)
        {
            string sqlstring = "SELECT * FROM tblReservation";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                _reservationIDBox.Text = dataReader.GetValue(0).ToString();
                _customerIDBox.Text = dataReader.GetValue(4).ToString();
            }
            MessageBox.Show("Reservation Data Updated");
            con.Close();
        }
    }
}
