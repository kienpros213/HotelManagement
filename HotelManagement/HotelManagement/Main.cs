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
            {
                //Create a new instance of the MDI child template form
                bookingForm _bookingForm = new bookingForm();

                //Set parent form for the child window 
                _bookingForm.MdiParent = this;

                //Display the child window
                _bookingForm.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MDI child template form
            scheduleForm _scheduleForm = new scheduleForm();

            //Set parent form for the child window 
            _scheduleForm.MdiParent = this;

            //Display the child window
            _scheduleForm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
