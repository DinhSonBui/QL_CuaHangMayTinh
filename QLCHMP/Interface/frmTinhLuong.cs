using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHMP.Database;

namespace QLCHMP.Interface
{
    public partial class frmTinhLuong : Form
    {
        Connect conn = new Connect();
        public frmTinhLuong()
        {
            InitializeComponent();
        }

        private void frmTinhLuong_Load(object sender, EventArgs e)
        {
            // Connect to the database
            string connectionString = "data source = LAPTOP-0TC4M5HB\\SQLEXPRESS;initial catalog=ql_chmt;integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Execute your SQL query to fetch data
                string sqlQuery = "SELECT MaNV, \r\n       SUM(CASE WHEN [1] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [2] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [3] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [4] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [5] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [6] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [7] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [8] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [9] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [10] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [11] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [12] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [13] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [14] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [15] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [16] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [17] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [18] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [19] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [20] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [21] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [22] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [23] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [24] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [25] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [26] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [27] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [28] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [29] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [30] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [31] = 'X' THEN 1 ELSE 0 END ) AS SoNgayDiLam,\r\n\r\n\t   SUM(CASE WHEN [1] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [2] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [3] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [4] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [5] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [6] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [7] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [8] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [9] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [10] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [11] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [12] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [13] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [14] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [15] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [16] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [17] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [18] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [19] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [20] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [21] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [22] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [23] = 'X' THEN 1 ELSE 0 END +\r\n           CASE WHEN [24] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [25] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [26] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [27] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [28] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [29] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [30] = 'X' THEN 1 ELSE 0 END +\r\n\t\t   CASE WHEN [31] = 'X' THEN 1 ELSE 0 END )*200000 AS Luong\r\nFROM ChamCong\r\nGROUP BY MaNV;\r\n";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assign data to DataGridView
                dgvBangLuong.DataSource = dataTable;
            }
        }
    }
}
