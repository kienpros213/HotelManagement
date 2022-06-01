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
        public static void getData(string _cusIDPar, System.Windows.Forms.TextBox _cusID, System.Windows.Forms.TextBox _reservationID, System.Windows.Forms.TextBox _roomID, System.Windows.Forms.TextBox _reserveDate, System.Windows.Forms.TextBox _dateIn, System.Windows.Forms.TextBox _dateOut, System.Windows.Forms.TextBox _cusFName, System.Windows.Forms.TextBox _cusLName, System.Windows.Forms.TextBox _cusAddress)
        {
            string sqlstring = "SELECT * FROM reservationDataView WHERE customerID = '" + _cusIDPar + "'";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                _cusID.Text = dataReader.GetValue(0).ToString();
                _reservationID.Text = dataReader.GetValue(1).ToString();
                _reserveDate.Text = dataReader.GetValue(2).ToString();
                _roomID.Text = dataReader.GetValue(3).ToString();
                _dateIn.Text = dataReader.GetValue(4).ToString();
                _dateOut.Text = dataReader.GetValue(5).ToString();
                _cusFName.Text = dataReader.GetValue(6).ToString();
                _cusLName.Text = dataReader.GetValue(7).ToString();
                _cusAddress.Text = dataReader.GetValue(8).ToString();
            }
            con.Close();
        }
    }
}
