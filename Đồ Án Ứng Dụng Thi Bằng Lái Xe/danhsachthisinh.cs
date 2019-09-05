using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class danhsachthisinh : UserControl
    {
        public danhsachthisinh()
        {
            InitializeComponent();
        }

        private void danhsachthisinh_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True");
            con.Open();
            string sqlselect = "select * from DSTHISINH";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
