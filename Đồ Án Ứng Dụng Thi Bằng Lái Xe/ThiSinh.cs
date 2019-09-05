using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class ThiSinh : UserControl
    {
        public ThiSinh()
        {
            InitializeComponent();
            ChiDoc();
        }
        string tenanh;
        int selectrow = 1;
        string gt = "";
        string dblx = @"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True";
        SqlConnection con;
        private void sepic_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fdg = new OpenFileDialog();
                fdg.InitialDirectory = @"d:\";
                fdg.Filter = "File anh(*.jpg;*.bmp;*.gif)|*jpg;*bmp;*gif";
                if (fdg.ShowDialog() == DialogResult.OK)
                {
                    tenanh = fdg.FileName;
                    Bitmap anh = new Bitmap(tenanh);
                    photo.SizeMode = PictureBoxSizeMode.Zoom;
                    photo.Image = (Image)anh;
                }
                fdg = null;
            }
            catch (Exception ex)
            {
                tenanh = "";
            }
        }
        public void empty()
        {
            msts.Text = "";
            hoten.Text = "";
            diachi.Text = "";
            sodienthoai.Text = "";
            cmnd.Text = "";
            txtngaysinh.Text = "1999-05-21";
            radioButton1.Checked = false;
            radioButton2.Checked = false;    
        }
        public void ChiDoc()
        {
            msts.ReadOnly = false;
            hoten.ReadOnly = true;
            sodienthoai.ReadOnly = true;
            cmnd.ReadOnly = true;
            diachi.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            txtngaysinh.Enabled = false;
            tim.Enabled = true;
            sepic.Enabled = false;
        }
        public void ChiSua()
        {
            msts.ReadOnly = false;
            hoten.ReadOnly = false;
            sodienthoai.ReadOnly = false;
            cmnd.ReadOnly = false;
            diachi.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            txtngaysinh.Enabled = true;
            sepic.Enabled = true;
        }
        public bool checkdata()
        {
            if (string.IsNullOrEmpty(msts.Text))
            {
                MessageBox.Show("Bạn Chưa mã số thí sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msts.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(hoten.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hoten.Focus();
                return false;
            }
            if(radioButton1.Checked || radioButton2.Checked)
            { }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Giới Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Focus();
                return false;
            };
            if (string.IsNullOrEmpty(diachi.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                diachi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sodienthoai.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sodienthoai.Focus();
                return false;
            }
            if (txtngaysinh.Value.Year > DateTime.Now.Year - 18)
            {
                MessageBox.Show("Ngày Sinh Giới Hạn lớn hơn 17 Tuổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngaysinh.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtngaysinh.Text))
            {
                MessageBox.Show("Bạn chưa chọn Ngày Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngaysinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cmnd.Text))
            {
                MessageBox.Show("Bạn Chưa nhập CMND", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmnd.Focus();
                return false;
            }
            return true;
        }
        private bool CheckPrimayKey(string s)
        {
            bool tatkt = true;
            SqlDataAdapter da = new SqlDataAdapter("Select * from DSTHISINH where MSTS='" + s + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                tatkt = false;
            }
            da.Dispose();
            return tatkt;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
                gt = radio.Text;
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void them_Click(object sender, EventArgs e)
        {
            photo.Image = Properties.Resources.account_512;
            empty();
            ChiSua();
            msts.Focus();
            luu_them.Visible = true;
            sua.Enabled = false;
            xoa.Enabled = false;
            selectrow = 1;
        }

        private void luu_them_Click(object sender, EventArgs e)
        {
            if (checkdata() == false)
                return;
            if (CheckPrimayKey(msts.Text) == false)
            {
                MessageBox.Show("Trùng Mã Số Thí Sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msts.Focus();
                return;
            }
            //add data zoo SQL           
            string sqlthem = "INSERT INTO DSTHISINH (msts, hoten,ngaysinh,gioitinh,dienthoai,diachi,cmnd) VALUES (N'" + msts.Text + "',N'" + hoten.Text + "','" + txtngaysinh.Value.Date.Month + "-" + txtngaysinh.Value.Date.Day + "-" + txtngaysinh.Value.Date.Year + "',N'" + gt + "','" + sodienthoai.Text + "',N'" + diachi.Text + "','" + cmnd.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlthem, con);
            cmd.ExecuteNonQuery();
            string chuoi;
            //add ảnh zoo SQl
           
            string sqlsua1 = "  UPDATE DSTHISINH SET image = @pic WHERE msts='" + msts.Text + "'";
            SqlParameter picpara = new SqlParameter();
            picpara.SqlDbType = SqlDbType.Image;
            picpara.ParameterName = "pic";
            picpara.Value = imageToByteArray(photo.Image);

            cmd = new SqlCommand(sqlsua1, con);
            cmd.Parameters.Add(picpara);
            cmd.Parameters.AddWithValue("@msts", msts.Text);
            cmd.ExecuteNonQuery();
            
            them.Visible = true;
            luu_them.Hide();
            sua.Enabled = true;
            xoa.Enabled = true;
            ChiDoc();
            MessageBox.Show("Thêm Thành Công");
            empty();
            selectrow = 1;
        }

        private void ThiSinh_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dblx);
            con.Open();
            luu_them.Hide();
            sua_luu.Hide();
        }

        private void msts_Leave(object sender, EventArgs e)
        {
            msts.Text = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(msts.Text.ToLower());
        }

        private void hoten_Leave(object sender, EventArgs e)
        {
            hoten.Text = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(hoten.Text.ToLower());
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (msts.Text == "")
                return;
            ChiSua();
            msts.ReadOnly = true;
            sua.Hide();
            sua_luu.Visible = true;
            them.Enabled = false;
            xoa.Enabled = false;
            selectrow = 1;
        }

        private void sua_luu_Click(object sender, EventArgs e)
        {
            if (checkdata() == false)
                return;
            //update data zoo SQL
            string sqlsua = "  UPDATE DSTHISINH SET HOTEN =N'" + hoten.Text + "',cmnd='" + cmnd.Text + "',NGAYSINH='" + txtngaysinh.Value.Date.Month + "-" + txtngaysinh.Value.Date.Day + "-" + txtngaysinh.Value.Date.Year + "',GIOITINH=N'" + gt + "',DIENTHOAI='" + sodienthoai.Text + "',diachi='" + diachi.Text + "'WHERE msts='" + msts.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            //update ảnh
            string sqlsua1 = "  UPDATE DSTHISINH SET image = @pic WHERE msts='" + msts.Text + "'";
            SqlParameter picpara = new SqlParameter();
            picpara.SqlDbType = SqlDbType.Image;
            picpara.ParameterName = "pic";
            picpara.Value = imageToByteArray(photo.Image);

            cmd = new SqlCommand(sqlsua1, con);
            cmd.Parameters.Add(picpara);
            cmd.Parameters.AddWithValue("@msts", msts.Text);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            sua.Visible = true;
            sua_luu.Hide();
            them.Enabled = true;
            xoa.Enabled = true;
            ChiDoc();
            selectrow = 1;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(msts.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập mã số cần tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msts.Focus();
                return;
            }
            string temp = msts.Text;
            if (selectrow == 1)
            {
                empty();
                them.Visible = true;
                sua.Visible = true;
                sua.Enabled = true;
                xoa.Visible = true;
                luu_them.Hide();
                sua_luu.Hide();
            }
            msts.Text = temp;
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from DSTHISINH where msts='" + msts.Text + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                foreach (DataRow dr in dt_kiemtra.Rows)
                {
                    msts.Text = dr["msts"].ToString();
                    hoten.Text = dr["hoten"].ToString();
                    cmnd.Text = dr["cmnd"].ToString();
                    if (dr["gioitinh"].ToString() == "nam")
                         radioButton1.Checked = true;
                    else
                         radioButton2.Checked = true;
                    txtngaysinh.Text= dr["ngaysinh"].ToString();
                    sodienthoai.Text= dr["dienthoai"].ToString();
                    diachi.Text = dr["diachi"].ToString();
                    DataSet ds = new DataSet();
                    da_kiemtra.Fill(ds);
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                    photo.Image = new Bitmap(ms);
                }
                ChiDoc();
                sua.Visible = true;
                sua_luu.Hide();
                xoa.Enabled = true;
            }
            else
            {
                empty();
                MessageBox.Show("Mã thí sinh không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sqlxoa = "DELETE FROM DSTHISINH WHERE msts = @msts";
            SqlCommand cmd = new SqlCommand(sqlxoa, con);
            cmd.Parameters.AddWithValue("msts", msts.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tim.Enabled = false;
            empty();
            ChiDoc();
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            empty();
            ChiDoc();
            them.Visible = sua.Visible = true;
            sua_luu.Hide();
            luu_them.Hide();
        }
    }
}
