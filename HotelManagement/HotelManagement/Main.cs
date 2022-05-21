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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button1, Color.LightBlue, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button1, Color.White, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button2, Color.LightBlue, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button2, Color.White, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }

        private void button3_MouseHover_1(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button3, Color.LightBlue, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button3, Color.White, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button4, Color.LightBlue, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(button4, Color.White, XanderUI.XUIObjectAnimator.ColorAnimation.SlideFill, true, 3);
        }
    }
}
