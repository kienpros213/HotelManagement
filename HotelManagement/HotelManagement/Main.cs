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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "bookingForm")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                bookingForm _bookingForm = new bookingForm();
                _bookingForm.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "reportForm")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                reportForm _reportForm = new reportForm();
                _reportForm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
