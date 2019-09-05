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
    public partial class CauHoi : UserControl
    {
        public CauHoi()
        {
            InitializeComponent();
        }
        string da="";
        string dblx = @"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        private bool CheckPrimayKey(string s)
        {

            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from danhsachcauhoi_vanban where macau='" + s + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);

            if (dt_kiemtra.Rows.Count > 0)
            {
                return false;
            }
            da_kiemtra.Dispose();
            return true;
        }
        public bool checkdata()
        {
            if (string.IsNullOrEmpty(noidung.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Nội Dung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                noidung.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(hang.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập mức bằng lái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nguoisoan.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập người soạn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nguoisoan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(macau.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập mã câu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                macau.Focus();
                return false;
            }
            if(noidung.Text== "Câu hỏi lý thuyết")
            {
                if(tb_vb.Text=="")
                {
                    MessageBox.Show("Bạn Chưa Nhập câu hỏi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    macau.Focus();
                    return false;
                }
            }
            else
            {
                if (pt_anh.Image == Properties.Resources.nền_trắng)
                {
                    MessageBox.Show("Bạn chọn ảnh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    macau.Focus();
                    return false;
                }
            }      
            if (string.IsNullOrEmpty(tbA.Text))
            {
                MessageBox.Show("Bạn chưa nhập đáp án A", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbA.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tbB.Text))
            {
                MessageBox.Show("Bạn chưa nhập đáp án B", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbB.Focus();
                return false;
            }
            if (A.Checked || B.Checked || C.Checked || D.Checked)
            { }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn đáp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            };
            if((tbA.Text!=""&&A.Checked==true)|| (tbB.Text != "" && B.Checked == true)|| (tbC.Text != "" && C.Checked == true)|| (tbD.Text != "" && D.Checked == true))  {           }
            else
            {
                MessageBox.Show("Bạn Chọn đáp án không hợp lý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                A.Focus();
                return false;
            }
            return true;
        }
        public void freedata()
        {
            noidung.Text = "";
            hang.Text = "";
            nguoisoan.Text = "";
            macau.Text = "";
            tb_vb.Text = "";
            pt_anh.Image = Properties.Resources.nền_trắng;
            A.Checked = B.Checked = C.Checked = D.Checked = false;
            tbA.Text = tbB.Text = tbC.Text = tbD.Text = "";
        }
        public void readOnly()
        {
            noidung.Enabled = false;
            hang.Enabled = false;
            nguoisoan.Enabled = false;
            macau.Enabled = false;
            tb_vb.Enabled = false;
            pt_anh.Image = Properties.Resources.nền_trắng;
            A.Enabled = B.Enabled = C.Enabled = D.Enabled = false;
            tbA.Enabled = tbB.Enabled = tbC.Enabled = tbD.Enabled = false;
        }
        public void alowedit()
        {
            noidung.Enabled = true;
            hang.Enabled = true;
            nguoisoan.Enabled = true;
            macau.Enabled = true;
            tb_vb.Enabled = true;
            A.Enabled = B.Enabled = C.Enabled = D.Enabled = true;
            tbA.Enabled = tbB.Enabled = tbC.Enabled = tbD.Enabled = true;
        }
        int flag_them = 0;
        private void btLog_Click_1(object sender, EventArgs e)
        {
            if (A.Checked == true)
                da = "a";
            else if (B.Checked == true)
                da = "b";
            else if (C.Checked == true)
                da = "c";
            else
                da = "d";
            if (flag_them == 0)
            {
                alowedit();
                btLog.Text = "Lưu";
                flag_them = 1;
                return;
            }
            if (CheckPrimayKey(macau.Text) == false)
            {
                MessageBox.Show("Mã đề bị trùng");
                macau.Focus();
            }
            if (checkdata() == false)
                return;
            else
            {

                con = new SqlConnection(dblx);
                
                string sqlthem = "INSERT INTO DANHSACHCAUHOI_VANBAN VALUES ('"
                    + macau.Text + "',N'"
                    + tb_vb.Text
                    + "',N'" + tbA.Text
                    + "',N'" + tbB.Text
                    + "',N'" + tbC.Text
                    + "',N'" + tbD.Text
                    + "','" + da
                    + "',N'" + nguoisoan.Text
                    + "',N'" + hang.Text
                    + "',N'" + noidung.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(sqlthem, con);
                SqlDataReader myreader;
                try
                {
                    con.Open();
                    myreader = cmd.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (noidung.Visible == true)
                {
                    string chuoi;
                    try
                    {

                        if (tenanh != "")
                        {
                            FileStream frm = new FileStream(@tenanh, FileMode.Open, FileAccess.Read);
                            byte[] picbyte = new byte[frm.Length];
                            frm.Read(picbyte, 0, System.Convert.ToInt32(frm.Length));
                            frm.Close();
                            // ketnoi
                            con = new SqlConnection(dblx);
                            con.Open();
                            chuoi = "insert into danhsachcauhoi_hinhanh values(@macau,@pic)";
                            SqlParameter picpara = new SqlParameter();
                            picpara.SqlDbType = SqlDbType.Image;
                            picpara.ParameterName = "pic";
                            picpara.Value = picbyte;
                            cmd = new SqlCommand(chuoi, con);
                            cmd.Parameters.Add(picpara);
                            cmd.Parameters.AddWithValue("@macau", @macau.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    freedata();
                    MessageBox.Show("Thêm câu hỏi mới thành công");
                    btLog.Text = "Thêm";
                    flag_them = 0;
                }
            }
        }
        string tenanh;
        private void button_hinhanh_Click(object sender, EventArgs e)
        {
            pt_anh.Visible = true;
            tb_vb.Hide();
            tb_vb.Text = "";
            try
            {
                FileDialog fdg = new OpenFileDialog();
                fdg.InitialDirectory = @"d:\";
                fdg.Filter = "File anh(*.jpg;*.bmp;*.gif)|*jpg;*bmp;*gif";
                if (fdg.ShowDialog() == DialogResult.OK)
                {
                    tenanh = fdg.FileName;
                    Bitmap anh = new Bitmap(tenanh);
                    pt_anh.SizeMode = PictureBoxSizeMode.Zoom;
                    pt_anh.Image = (Image)anh;
                }
                fdg = null;
            }
            catch (Exception ex)
            {
                tenanh = "";
            }

        }

        private void button_vanban_Click(object sender, EventArgs e)
        {
            tb_vb.Visible = true;
            pt_anh.Image = Properties.Resources.nền_trắng;
            pt_anh.Hide();
        }

        private void D_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
                da = radio.Name;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
             con = new SqlConnection(dblx);
            readOnly();
        }

        private void tim_Click(object sender, EventArgs e)
        {
            flag_sua = 0;
            if (string.IsNullOrEmpty(mscau.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập mã số cần tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mscau.Focus();
                return;
            }
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from danhsachcauhoi_vanban where macau='" + mscau.Text + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);
            //
            SqlDataAdapter da_kiemtra_1 = new SqlDataAdapter("Select anh from danhsachcauhoi_hinhanh where macau='" + mscau.Text + "'", con);
            DataTable dt_kiemtra_1 = new DataTable();
            da_kiemtra_1.Fill(dt_kiemtra_1);

            if (dt_kiemtra.Rows.Count == 0&& dt_kiemtra.Rows.Count==0)
            {
                MessageBox.Show("Không Có Trong Danh Sách");
                return;
            }

            if (dt_kiemtra != null)
            {
                pt_anh.Visible = true;
                tb_vb.Hide();
                foreach (DataRow dr in dt_kiemtra.Rows)
                {
                    noidung.Text = dr["chude"].ToString();
                    hang.Text = dr["hang"].ToString();
                    nguoisoan.Text = dr["ngsoan"].ToString();
                    macau.Text = dr["macau"].ToString();
                    tb_vb.Text = dr["cauhoi"].ToString();
                    string dapan= dr["dapan_dung"].ToString();
                    if (dapan == "a")
                        A.Checked = true;
                    else if (dapan == "b")
                        B.Checked = true;
                    else if (dapan == "c")
                        C.Checked = true;
                    else
                        D.Checked = true;
                    tbA.Text = dr["dapan_A"].ToString();
                    tbB.Text = dr["dapan_B"].ToString();
                    tbC.Text = dr["dapan_C"].ToString();
                    tbD.Text = dr["dapan_D"].ToString();
                }
            }
            if (dt_kiemtra_1 != null)
            {
                pt_anh.Visible = true;
                tb_vb.Hide();
                DataSet ds = new DataSet();
                da_kiemtra_1.Fill(ds);
                foreach (DataRow dr in dt_kiemtra_1.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["anh"]);
                    pt_anh.Image = new Bitmap(ms);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            if (mscau.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn Muốn Xóa Thí Sinh Này ?", "Question", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;
            }
            // chạy lệnh xóa SQL
            string sqlxoa = "DELETE FROM danhsachcauhoi_vanban WHERE macau = @macau";
            SqlCommand cmd = new SqlCommand(sqlxoa, con);
            cmd.Parameters.AddWithValue("macau", macau.Text);
            cmd.ExecuteNonQuery();
            // xóa ảnh trong SQl Ảnh
            sqlxoa = "DELETE FROM danhsachcauhoi_hinhanh WHERE macau = @macau";
            cmd = new SqlCommand(sqlxoa, con);
            cmd.Parameters.AddWithValue("macau", macau.Text);
            cmd.ExecuteNonQuery();
            pt_anh.Image = Properties.Resources.nền_trắng;
            tb_vb.Text = "";
            MessageBox.Show("Xóa Thành Công");
            readOnly();
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        int flag_sua = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag_sua == 0)
            {
                alowedit();
                button1.Text = "Lưu";
                flag_sua = 1;
                return;
            }
            if (A.Checked == true)
                da = "a";
            else if (B.Checked == true)
                da = "b";
            else if (C.Checked == true)
                da = "c";
            else
                da = "d";
            if (checkdata() == false)
                return;
            //update data zoo SQL
            con.Open();
            string sqlsua = "UPDATE DANHSACHCAUHOI_VANBAN  SET cauhoi=N'"+ tb_vb.Text
                    + "',dapan_a=N'" + tbA.Text
                    + "',dapan_b=N'" + tbB.Text
                    + "',dapan_c=N'" + tbC.Text
                    + "',dapan_d=N'" + tbD.Text
                    + "',dapan_dung='" + da
                    + "',ngsoan=N'" + nguoisoan.Text
                    + "',hang=N'" + hang.Text
                    + "',chude=N'" + noidung.Text.ToString() + "'WHERE macau='" + mscau.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            //tìm xem có mssv này trong ảnh không
            string sqlsua2 = "select * from DANHSACHCAUHOI_HINHANH where macau = '" + mscau.Text + "'";
            cmd = new SqlCommand(sqlsua2, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            //// không có thì add ảnh vào SQl
            //if (dt1.Rows.Count == 0)
            //{
            //    string chuoi;
            //    try
            //    {
                    
            //                if (tenanh != "")
            //                {
            //                    FileStream frm = new FileStream(@tenanh, FileMode.Open, FileAccess.Read);
            //                    byte[] picbyte = new byte[frm.Length];
            //                    frm.Read(picbyte, 0, System.Convert.ToInt32(frm.Length));
            //                    frm.Close();
            //                    // ketnoi
            //                    con = new SqlConnection(dblx);
            //                    con.Open();
            //                    chuoi = "insert into danhsachcauhoi_hinhanh values(@macau,@pic)";
            //                    SqlParameter picpara1 = new SqlParameter();
            //                    picpara1.SqlDbType = SqlDbType.Image;
            //                    picpara1.ParameterName = "pic";
            //                    picpara1.Value = picbyte;
            //                    cmd = new SqlCommand(chuoi, con);
            //                    cmd.Parameters.Add(picpara1);
            //                    cmd.Parameters.AddWithValue("@macau", @macau.Text);
            //                    cmd.ExecuteNonQuery();
            //                    flag_sua = 1;                      
            //            con.Close();
            //                }
                    
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    return;
            //}
            //có thì update ảnh
            string sqlsua1 = "  UPDATE danhsachcauhoi_hinhanh SET anh = @pic WHERE macau='" + macau.Text + "'";
            SqlParameter picpara = new SqlParameter();
            picpara.SqlDbType = SqlDbType.Image;
            picpara.ParameterName = "pic";
            picpara.Value = imageToByteArray(pt_anh.Image);

            cmd = new SqlCommand(sqlsua1, con);
            cmd.Parameters.Add(picpara);
            cmd.Parameters.AddWithValue("@mssv", mscau.Text);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sữa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Text = "Sữa";
            flag_sua = 0;
            readOnly();
            con.Close();
        }
        
    }
}
