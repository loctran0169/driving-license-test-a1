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
    public partial class TaoPhongThi : UserControl
    {
        public TaoPhongThi()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string temp_phong;
        string temp_xoa;
        string dsts = @"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True";
        public void hienthi_DSTS()
        {
            string sql = "select a.msts,a.hoten, a.cmnd from DSTHISINH a, ((SELECT msts FROM DSTHISINH) EXCEPT (SELECT msts FROM dsthi)) b where a.MSTS = b.MSTS";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv1.DataSource = dt;
        }
        public void hienthi_DSTS_ed(string a, string b)
        {
            string sql = "select a.msts,a.hoten,a.cmnd,tenphong, b.ngaythi  from DSTHISINH a,DSTHI b  where a.msts=b.msts AND b.tenphong='"+ a +"' AND b.ngaythi='"+ngaythi.Value.Date+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
        }
        private bool CheckPrimayKey(string s, string db)
        {
            bool tatkt = true;
            SqlDataAdapter kt = new SqlDataAdapter(db, con);
            DataTable dt = new DataTable();
            kt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = false;
            }
            kt.Dispose();
            return tatkt;
        }
        private void TaoPhongThi_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dsts);
            con.Open();
            hienthi_DSTS();
            hienthi_DSTS_ed(temp_phong,"1-1-1999");
            string them = "select tenphong from phongthi";
            SqlCommand cmd = new SqlCommand(them, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                phongthi.Items.Add(dr["tenphong"].ToString());
            }
        }

        public bool checkchonphong()
        {
            if (string.IsNullOrEmpty(phongthi.Text))
            {
                MessageBox.Show("Bạn Chưa chọn phòng thi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                phongthi.Focus();
                return false;
            }
            if (ngaythi.Value.Date<DateTime.Now)
            {
                MessageBox.Show("Bạn ngày thi sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ngaythi.Focus();
                return false;
            }
            return true;
        }
        public bool checkthemphong()
        {
            if (string.IsNullOrEmpty(tenphong.Text))
            {
                MessageBox.Show("Bạn Chưa nhập tên phòng thi phòng thi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tenphong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(diadiemphong.Text))
            {
                MessageBox.Show("Chưa nhập địa điểm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                diadiemphong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(soluong.Text))
            {
                MessageBox.Show("Chưa nhập số lượng tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                soluong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nguoigac.Text))
            {
                MessageBox.Show("Chưa nhập địa điểm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nguoigac.Focus();
                return false;
            }
            return true;
        }
        void hienthi_sothisinh()
        {
            int iCount = 0;
            if (dataGridView2.RowCount > 1)
            {

                for (int i = 0; i <= dataGridView2.RowCount - 2; i++)
                {
                    //Nếu cột đầu tiên (checkbok) tồn tại
                    if (dataGridView2.Rows[i].Cells[0].Value != null)
                    {
                        //Nếu checkbox được đánh dấu chọn thì tăng biến đếm lên

                        iCount++;

                    }
                    else continue;
                }

            }
            label4.Text = iCount.ToString();
        }
        string temp;
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                temp = row.Cells["msts"].Value.ToString();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                temp = row.Cells["msts"].Value.ToString();
            }
        }
       
        private void addroom_Click(object sender, EventArgs e)
        {
            if (checkthemphong() == false)
                return;
            if(CheckPrimayKey(tenphong.Text,"select * from phongthi where tenphong='"+tenphong.Text+"'") == false)
            {
                MessageBox.Show("Trùng Phòng Thi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tenphong.Focus();
                return;
            }
            string sqlthem = "INSERT INTO PHONGTHI (tenphong,diadiem,max,nguoigacthi) VALUES ('" + tenphong.Text + "','" + diadiemphong.Text + "','" + soluong.Text + "','" + nguoigac.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlthem, con);
            cmd.ExecuteNonQuery();
            string them = "select tenphong from phongthi";
            cmd = new SqlCommand(them, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            phongthi.Items.Clear();
            foreach (DataRow dr in ds.Rows)
            {
                phongthi.Items.Add(dr["tenphong"].ToString());
            }
            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phai_Click(object sender, EventArgs e)
        {
            if (checkchonphong() == false)
                return;
            if (CheckPrimayKey(temp, "select * from dsthi where msts='" + temp + "'") == false)
            {
                MessageBox.Show("Trùng Thí Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlsua = "INSERT INTO dsthi (tenphong,msts,ngaythi) VALUES ('" +phongthi.Text+"','"+temp+"','"+ngaythi.Value.Date.ToString()+"')";
            SqlCommand cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            hienthi_DSTS();
            hienthi_DSTS_ed(temp_phong,ngaythi.Value.Date.ToString());
        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            temp_phong = phongthi.Text;
            MessageBox.Show(ngaythi.Value.Date.ToString() + "...." + DateTime.Now.Date.ToString());
            hienthi_DSTS_ed(temp_phong,ngaythi.Value.Date.ToString());
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select msts from dsthisinh where msts='" + txtmsts.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.GetValue(0).ToString() == txtmsts.Text)
            {
                reader.Close();
                temp=txtmsts.Text;
                cmd = new SqlCommand("select * from dsthisinh where msts='"+temp+"'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da1.Fill(ds);
                dgv1.DataSource = ds;
                return;
            }
            else
            {
                MessageBox.Show("Mã số thí sinh không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void trái_Click(object sender, EventArgs e)
        {
            string sqlsua = "delete from dsthi where msts='" + temp_xoa + "'";
            SqlCommand cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            hienthi_DSTS();
            hienthi_DSTS_ed(temp_phong,ngaythi.Value.Date.ToString());
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                temp_xoa = row.Cells["msts"].Value.ToString();
            }
        }
    }
}
