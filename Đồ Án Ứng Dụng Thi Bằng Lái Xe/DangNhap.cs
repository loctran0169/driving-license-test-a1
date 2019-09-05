using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        static public bool DDN = false;
        static public string STK;
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
        private void btdn_Click(object sender, EventArgs e)
        {
            if (PK_TaiKhoan(TK.Text) == false)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select matkhau from TaiKhoan_admin where taikhoan='" + TK.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.GetValue(0).ToString() == MK.Text)
                {
                    DDN = true;
                    this.Close();
                }
                else if (reader.GetValue(0).ToString() != MK.Text)
                {
                    MessageBox.Show("Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MK.Focus();
                    con.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TK.Focus();
                con.Close();
                return;
            }
            con.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
