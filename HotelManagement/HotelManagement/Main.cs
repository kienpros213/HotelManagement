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
                Form1 bookingForm = new Form1();

                //Set parent form for the child window 
                bookingForm.MdiParent = this;

                //Display the child window
                bookingForm.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
