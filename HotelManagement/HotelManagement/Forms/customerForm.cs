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
        public static string sendtext = "";
        private void button1_Click(object sender, EventArgs e)
        {
            sendtext = customerIDBox.Text;
           // if (string.IsNullOrWhiteSpace(customerIDBox.Text))
            //{
                // Message box
               // MessageBox.Show("lmao");
           // }
           // else
            //{
           // updateCusData.Update(customerIDBox.Text, foreNameBox.Text, lastNameBox.Text, addressBox.Text, statusBox.Text);
                this.Close();
                roomForm _roomForm = new roomForm();
                _roomForm.Show();
                _roomForm.BringToFront();

            //}
        }
    }
}
