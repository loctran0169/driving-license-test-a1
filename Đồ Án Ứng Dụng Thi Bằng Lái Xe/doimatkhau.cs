using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class doimatkhau : Form
    {
        static public bool login_ed { get; set; }
        public doimatkhau()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True");

        private bool PK_TaiKhoan(string s)
        {
            con.Open();
            bool tatkt = true;
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from TaiKhoan_admin where taikhoan='" + s + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                tatkt = false;
            }
            da_kiemtra.Dispose();
            con.Close();
            return tatkt;
        }

        public void btDMK_Click(object sender, EventArgs e)
        {

                if (PK_TaiKhoan(TK.Text) == true)
                {
                    MessageBox.Show("Tài Khoản Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TK.Focus();
                    con.Close();
                    return;
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Select matkhau from TaiKhoan_admin where taikhoan='" + TK.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
 
                if (reader.GetValue(0).ToString() == mk.Text)
                {
                    con.Close();
                    if (mk1.Text == mk2.Text)
                    {
                        con.Open();
                        string sqlsua = "  UPDATE taikhoan_admin SET matkhau ='" + mk1.Text +  "'WHERE taikhoan='" + TK.Text + "'";
                        cmd = new SqlCommand(sqlsua, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Mật Khẩu Của Bạn Đã Được Thay Đổi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("2 mật khẩu không khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mk1.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật sai khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mk.Focus();
                    return;
                }
                con.Close();
        }


        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
