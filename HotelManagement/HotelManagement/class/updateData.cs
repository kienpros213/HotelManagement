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
    class updateData
    {
        public static void Update(string _customerID, string _customerFName, string _customerLName, string _reservation, string _customerAddress, string _customerStatus)
        {
            MessageBox.Show("lmao");
            string sqlstring = "INSERT INTO tblCustomer(customerID,customerFName,customerLName,reservation,customerAddress,customerStatus) VALUES('" + _customerID + "','" + _customerFName + "','" + _customerLName + "','" + _reservation + "','" + _customerAddress + "','" + _customerAddress + "')";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("success");
            con.Close();
        }
    }
}
