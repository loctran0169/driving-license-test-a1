using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.IO;
using System.Data.SqlClient;
namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        string dbsv = @"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True";
        SqlConnection con;
        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            if(DangNhap.DDN==false)
                ReadOnly_QuanLy();
            barStaticItem2.Caption = "Trạng thái: Chưa đăng nhập";
        }
        public void ReadOnly_QuanLy()
        {
            capnhat.Enabled = false;
            DSdau.Enabled = false;
            DSrot.Enabled = false;
            ThemCauHoi.Enabled = false;
            DSthi.Enabled = false;
            dmk.Enabled = false;
            Dsts.Enabled = false;
            dangxuat.Enabled = false;
            thoat.Enabled = false;
            dscauhoi_tb.Enabled = false;
        }
        public void Edit_QuanLy()
        {
            capnhat.Enabled = true;
            DSdau.Enabled = true;
            DSrot.Enabled = true;
            ThemCauHoi.Enabled = true;
            DSthi.Enabled = true;
            dmk.Enabled = true;
            Dsts.Enabled = true;
            dangnhap.Enabled = false;
            dangxuat.Enabled = true;
            thoat.Enabled = true;
            dscauhoi_tb.Enabled = true;
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            doimatkhau.login_ed = false;
            this.ReadOnly_QuanLy();
        }


        private void dangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            if (DangNhap.DDN == true)
            {
                Edit_QuanLy();
                barStaticItem2.Caption = "Trạng thái: Đã đăng nhập";
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            doimatkhau dmk = new doimatkhau();
            dmk.ShowDialog();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangNhap.DDN = false;
            barStaticItem2.Caption = "Trạng thái: Chưa đăng nhập";
            ReadOnly_QuanLy();
            dangnhap.Enabled = true;
        }

        private void ThemCauHoi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CauHoi ch = new CauHoi();
            panel1.Controls.Clear();
            panel1.Controls.Add(ch);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dscauhoi dsch = new dscauhoi();
            panel1.Controls.Clear();
            panel1.Controls.Add(dsch);
        }

        private void capnhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThiSinh ts = new ThiSinh();
            panel1.Controls.Clear();
            panel1.Controls.Add(ts);
        }

        private void DSthi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaoPhongThi pt = new TaoPhongThi();
            panel1.Controls.Clear();
            panel1.Controls.Add(pt);
        }

        private void DSdau_ItemClick(object sender, ItemClickEventArgs e)
        {
            ketquathi kq = new ketquathi();
            panel1.Controls.Clear();
            panel1.Controls.Add(kq);
            kq.ketquadau();
        }

        private void DSrot_ItemClick(object sender, ItemClickEventArgs e)
        {
            ketquathi kq = new ketquathi();
            panel1.Controls.Clear();
            panel1.Controls.Add(kq);
            kq.ketquarot();
        }

        private void Dsts_ItemClick(object sender, ItemClickEventArgs e)
        {
            danhsachthisinh ds = new danhsachthisinh();
            panel1.Controls.Clear();
            panel1.Controls.Add(ds);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }
    }
}
