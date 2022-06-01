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
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblReservation");
            
            //COLUMN SIZE
            
            if (roomDataList.Columns.Count > 0)
            {
                roomDataList.Columns[0].Width = 50;
                roomDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                roomDataList.Columns[1].Width = 50;
                roomDataList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                roomDataList.Columns[2].Width = 120;
                roomDataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                roomDataList.Columns[3].Width = 150;
                roomDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                roomDataList.Columns[4].Width = 150;
                roomDataList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                roomDataList.Columns[5].Width = 150;
                roomDataList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

            //BUTTON CLICK

        private void allRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE roomStatus = 'occupied'");
        }

        private void singleRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 1 AND roomStatus = 'occupied')");
        }

        private void doubleRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 2 AND roomStatus = 'occupied')");
        }

        private void familyRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 3 AND roomStatus = 'occupied')");
        }

        private void suitRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 4 AND roomStatus = 'occupied')");
        }

        public static string tempCusID;

        private void roomDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempCusID = roomDataList.CurrentRow.Cells[0].Value.ToString();

            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "reserveCheck")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isOpen == false)
            {
                reservationCheck reserveCheck = new reservationCheck();
                reserveCheck.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerIDReserve = customerForm.customerText;
            MessageBox.Show(customerIDReserve);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updateHistory.Update("2");
        }
    }
}
