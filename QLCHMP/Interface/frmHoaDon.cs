using QLCHMP.Database;
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

namespace QLCHMP.Interface
{
    public partial class frmHoaDon : Form
    {
        Connect conn = new Connect();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void showData()
        {
            String con_str = "data source = LAPTOP-0TC4M5HB\\SQLEXPRESS;initial catalog=ql_chmt;integrated security=true";

            try
            {
                String sql = "select * from HoaDon order by MaHD";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "HoaDon");

                dgvHoaDon.DataSource = rs.Tables["HoaDon"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_showData : " + ex.Message);
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String con_str = "data source = LAPTOP-0TC4M5HB\\SQLEXPRESS;initial catalog=ql_chmt;integrated security=true";
            String start = dateTimePickerStart.Text;
            String end = dateTimePickerEnd.Text;
            try
            {
                String sql = "SELECT * FROM HoaDon WHERE NgayBan BETWEEN @start AND @end";
                Console.WriteLine(start);
                Console.WriteLine(end);
                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new SqlParameter("@start", start));
                da.SelectCommand.Parameters.Add(new SqlParameter("@end", end));

                da.Fill(rs, "HoaDon");

                dgvHoaDon.DataSource = rs.Tables["HoaDon"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmHoaDon : " + ex.Message);
                Console.WriteLine("err_frmHoaDon : " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
