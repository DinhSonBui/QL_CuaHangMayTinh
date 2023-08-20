﻿using System;
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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void showData()
        {
            String con_str = "data source = LAPTOP-0TC4M5HB\\SQLEXPRESS;initial catalog=ql_chmt;integrated security=true";

            try
            {
                String sql = "select * from ChamCong";

                SqlConnection conn = new SqlConnection(con_str);

                DataSet rs = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "ChamCong");

                dgvChamCong.DataSource = rs.Tables["ChamCong"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("err_frmNV : " + ex.Message);
            }
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
