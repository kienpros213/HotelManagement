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
            updateCusData.Update(customerID.Text, customerFName.Text, customerLName.Text, customerAddress.Text, customerStatus.Text);

            customerID.Clear();
            customerFName.Clear();
            customerLName.Clear();
            reservation.Clear();
            customerAddress.Clear();
            customerStatus.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView.Refresh();
        }
    }
}
