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
        }
    }
}
