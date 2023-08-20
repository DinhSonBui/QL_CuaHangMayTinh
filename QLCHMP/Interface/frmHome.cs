using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using QLCHMP.Database;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QLCHMP.Interface
{
    public partial class frmHome : Form
    {
        Connect conn = new Connect();
        public frmHome()
        {
            InitializeComponent();


        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.guna2Panel2.Controls.Add(childForm);
            this.guna2Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNNhanVien(), sender);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNKhoHang(), sender);
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNBCTK(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNHoaDon(), sender);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNBanHang(), sender);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCNDoiMatKhau(), sender);
        }

        private void BtnHoTro_Click(object sender, EventArgs e)
        {
            frmHoTro frm = new frmHoTro();
            frm.Show();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Restart();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

            String con_str = "data source = LAPTOP-0TC4M5HB\\SQLEXPRESS;initial catalog=ql_chmt;integrated security=true";
            
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                String sqlCountNV = "SELECT COUNT(*) FROM NhanVien";
                String sqlCountSP = "SELECT COUNT(*) FROM SanPham";
                String sqlCountHD = "SELECT COUNT(*) FROM HoaDon";

                SqlCommand commandNV = new SqlCommand(sqlCountNV, conn);
                SqlCommand commandSP = new SqlCommand(sqlCountSP, conn);
                SqlCommand commandHD = new SqlCommand(sqlCountHD, conn);

                int resultCountNV = (int)commandNV.ExecuteScalar();
                int resultCountSP = (int)commandSP.ExecuteScalar();
                int resultCountHD = (int)commandHD.ExecuteScalar();

                lblCountNV.Text = ""+ resultCountNV;
                lblCountSP.Text = "" + resultCountSP;
                lblCountHD.Text = "" + resultCountHD;

            }
            catch (Exception ex)
            {
                MessageBox.Show("err_Home : " + ex.Message);
               
            }

        }
    }
}
