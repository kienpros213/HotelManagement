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
    public partial class bookingForm : Form
    {
        public bookingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstring = "INSERT INTO tblCustomer(customerID,customerFName,customerLName,reservation,customerAddress,customerStatus) VALUES('"+customerID.Text+"','" + customerFName.Text + "','" + customerLName.Text + "','" + reservation.Text + "','" + customerAddress.Text + "','" + customerStatus.Text + "')";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("success");
            con.Close();
        }
    }
}
