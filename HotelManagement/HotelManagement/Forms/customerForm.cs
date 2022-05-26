using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }
        public static string customerText = "";
        private void button1_Click(object sender, EventArgs e)
        {
            customerText = customerIDBox.Text;
            if (string.IsNullOrWhiteSpace(customerIDBox.Text))
            {
                MessageBox.Show("lmao, điền vào customerID");
            }
            else
            {
               // updateCusData.Update(customerIDBox.Text, foreNameBox.Text, lastNameBox.Text, addressBox.Text, statusBox.Text);
                this.Close();
                roomForm _roomForm = new roomForm();
                _roomForm.Show();
                _roomForm.BringToFront();
            }
        }
    }
}
