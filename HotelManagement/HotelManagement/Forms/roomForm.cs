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
        public roomForm()
        {
            InitializeComponent();
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom");
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

                int temp = roomDataList.Columns.Count;
                MessageBox.Show(temp.ToString());
            }
        }

        private void allRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom");
        }

        private void singleRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE classID = 1");
        }

        private void doubleRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE classID = 2");
        }

        private void familyRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE classID = 3");
        }

        private void suitRoomBtn_Click(object sender, EventArgs e)
        {
            getDataGridView.bindGrid(roomDataList, "SELECT * FROM tblRoom WHERE classID = 4");
        }
    }
}
