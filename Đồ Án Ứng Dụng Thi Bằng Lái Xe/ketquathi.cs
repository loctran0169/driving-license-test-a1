using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class ketquathi : UserControl
    {
        public ketquathi()
        {
            InitializeComponent();
        }
        string dbsv = @"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True";
        SqlConnection con;
        DataSet ds = new DataSet();
        public void ketquadau()
        {
            con = new SqlConnection(dbsv);
            con.Open();
            string sqlselect = "select diemso.MSTS,HOTEN,NGAYSINH,cmnd,GIOITINH,DIENTHOAI,DIACHI,DIENTHOAI from DSTHISINH, DIEMSO where DIEMSO.msts = DSTHISINH.MSTS and diem>= 16";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dt;
        }
        public void ketquarot()
        {
            con = new SqlConnection(dbsv);
            con.Open();
            string sqlselect = "select diemso.MSTS,HOTEN,NGAYSINH,cmnd,GIOITINH,DIENTHOAI,DIACHI,DIENTHOAI from DSTHISINH, DIEMSO where DIEMSO.msts = DSTHISINH.MSTS and diem < 16";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dt;
        }
        private void ketquathi_Load(object sender, EventArgs e)
        {

        }
    }
}
