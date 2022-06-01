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
    public partial class roomForm : Form
    {
        public static bool checkinState = false;
        public roomForm()
        {
            InitializeComponent();
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE roomStatus = 'unoccupied'");
            if (roomDataList.Columns.Count > 0)
            {
                roomDataList.Columns[0].Width = 85;
                roomDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                roomDataList.Columns[1].Width = 77;
                roomDataList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                roomDataList.Columns[2].Width = 250;
                roomDataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                roomDataList.Columns[3].Width = 115;
                roomDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                roomDataList.Columns[4].Width = 150;
                roomDataList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void allRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE roomStatus = 'unoccupied'");
        }

        private void singleRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 1 AND roomStatus = 'unoccupied')");
        }

        private void doubleRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 2 AND roomStatus = 'unoccupied')");
        }

        private void familyRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 3 AND roomStatus = 'unoccupied')");
        }

        private void suitRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE (classID = 4 AND roomStatus = 'unoccupied')");
        }

        private void roomDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomIDBox.Text = roomDataList.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerIDReserve = customerForm.customerText;
            updateReserveData.Update(reserveIDBox.Text, customerIDReserve, roomIDBox.Text, reserveDateBox.Text, dateInBox.Text, dateOutBox.Text);
            updateReserveData.UpdateRoomStatus(roomIDBox.Text);
        }
    }
}
