using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
    class updateReserveData
    {
        public static void Update(string _reservationID, string _customerID, string _roomID, string _reservationDate, string _dateIn, string _dateOut)
        {
            string sqlstring = "INSERT INTO tblReservation VALUES()";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer Data Updated");
            con.Close();
        }
    }
}
