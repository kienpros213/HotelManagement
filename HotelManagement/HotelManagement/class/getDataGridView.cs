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
    class getDataGridView
    {
        public static void bindGrid(System.Windows.Forms.DataGridView _dataGridViewObj)
        {
            string constring = "Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblCustomer", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            _dataGridViewObj.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
