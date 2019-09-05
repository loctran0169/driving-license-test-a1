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
using System.IO;
namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class dscauhoi : UserControl
    {
        public dscauhoi()
        {
            InitializeComponent();
        }
        string dbsv = @"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True";
        SqlConnection con;
        DataSet ds = new DataSet();
        string tenanh;
        public void HienThi_lythuyet()
        {
            string sqlselect = "select * from danhsachcauhoi_vanban where chude=N'Câu hỏi lý thuyết'";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from danhsachcauhoi_vanban", con);
            da.Fill(ds);
            dataGridView_dsLythuyet.DataSource = dt;
           
        }
        public void HienThi_bienbao()
        {
            string sqlselect = "select macau,dapan_a,dapan_b,dapan_c,dapan_d,dapan_dung,ngsoan,hang from danhsachcauhoi_vanban where chude=N'câu hỏi biển báo'";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from danhsachcauhoi_vanban", con);
            da.Fill(ds);
            dataGridView_dsbienbao.DataSource = dt;

        }
        public void HienThi_xahinh()
        {
            string sqlselect = "select macau,dapan_a,dapan_b,dapan_c,dapan_d,dapan_dung,ngsoan,hang from danhsachcauhoi_vanban where chude=N'câu hỏi xa hình'";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from danhsachcauhoi_vanban", con);
            da.Fill(ds);
            dataGridView_dsxahinh.DataSource = dt;

        }
        private void dscauhoi_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dbsv);
            con.Open();
            HienThi_lythuyet();
            HienThi_bienbao();
            HienThi_xahinh();
        }

        private void dataGridView_dsbienbao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_dsbienbao.Rows[e.RowIndex];



                pictureBox_bienbao.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_bienbao.Visible = true;
                SqlCommand cmd = new SqlCommand("select anh from danhsachcauhoi_hinhanh where macau='" + row.Cells["macau"].Value.ToString() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["anh"]);
                    pictureBox_bienbao.Image = new Bitmap(ms);
                }
            }
        }
        private void dataGridView_dsxahinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_dsxahinh.Rows[e.RowIndex];



                pictureBox_xahinh.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox_xahinh.Visible = true;
                SqlCommand cmd = new SqlCommand("select anh from danhsachcauhoi_hinhanh where macau='" + row.Cells["macau"].Value.ToString() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["anh"]);
                    pictureBox_xahinh.Image = new Bitmap(ms);
                }
            }
        }
    }
}
