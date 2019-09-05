namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    partial class QuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.ThemCauHoi = new DevExpress.XtraNavBar.NavBarItem();
            this.DSthi = new DevExpress.XtraNavBar.NavBarItem();
            this.dscauhoi_tb = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.capnhat = new DevExpress.XtraBars.BarButtonItem();
            this.DSdau = new DevExpress.XtraBars.BarButtonItem();
            this.DSrot = new DevExpress.XtraBars.BarButtonItem();
            this.dangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.dmk = new DevExpress.XtraBars.BarButtonItem();
            this.Dsts = new DevExpress.XtraBars.BarButtonItem();
            this.thoat = new DevExpress.XtraBars.BarButtonItem();
            this.dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.ThemCauHoi,
            this.DSthi,
            this.dscauhoi_tb});
            this.navBarControl1.Location = new System.Drawing.Point(12, 146);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 300);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "Q";
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Điều khiển";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Về trang chủ";
            this.navBarItem1.ImageOptions.SmallImage = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.back_16x16;
            this.navBarItem1.ImageOptions.SmallImageSize = new System.Drawing.Size(10, 10);
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Quản trị viên";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ThemCauHoi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.DSthi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.dscauhoi_tb)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // ThemCauHoi
            // 
            this.ThemCauHoi.Caption = "Cập Nhật Câu Hỏi";
            this.ThemCauHoi.ImageOptions.SmallImage = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.customer_service;
            this.ThemCauHoi.Name = "ThemCauHoi";
            this.ThemCauHoi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ThemCauHoi_LinkClicked);
            // 
            // DSthi
            // 
            this.DSthi.Caption = "Lập danh sách thi";
            this.DSthi.ImageOptions.SmallImage = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.list1;
            this.DSthi.ImageOptions.SmallImageSize = new System.Drawing.Size(28, 28);
            this.DSthi.Name = "DSthi";
            this.DSthi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.DSthi_LinkClicked);
            // 
            // dscauhoi_tb
            // 
            this.dscauhoi_tb.Caption = "Danh sách câu hỏi";
            this.dscauhoi_tb.ImageOptions.SmallImage = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.fffff;
            this.dscauhoi_tb.ImageOptions.SmallImageSize = new System.Drawing.Size(28, 28);
            this.dscauhoi_tb.Name = "dscauhoi_tb";
            this.dscauhoi_tb.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Soạn câu hỏi";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Tạo đề";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Lập danh sách thi";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // panel1
            // 
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(158, 146);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1015, 478);
            this.panel1.TabIndex = 2;
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.capnhat,
            this.DSdau,
            this.DSrot,
            this.dangnhap,
            this.dmk,
            this.Dsts,
            this.thoat,
            this.dangxuat,
            this.barStaticItem1,
            this.barStaticItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1180, 141);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // capnhat
            // 
            this.capnhat.Caption = "Cập Nhật";
            this.capnhat.Id = 3;
            this.capnhat.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.tải_xuống;
            this.capnhat.Name = "capnhat";
            this.capnhat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.capnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.capnhat_ItemClick);
            // 
            // DSdau
            // 
            this.DSdau.Caption = "Danh Sách Đậu";
            this.DSdau.Id = 4;
            this.DSdau.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources._5_7_20159_25_45_am745anylist_app_icon;
            this.DSdau.Name = "DSdau";
            this.DSdau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DSdau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DSdau_ItemClick);
            // 
            // DSrot
            // 
            this.DSrot.Caption = "Danh Sách Rớt";
            this.DSrot.Id = 5;
            this.DSrot.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.rot;
            this.DSrot.Name = "DSrot";
            this.DSrot.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.DSrot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DSrot_ItemClick);
            // 
            // dangnhap
            // 
            this.dangnhap.Caption = "Đăng Nhập";
            this.dangnhap.Id = 6;
            this.dangnhap.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.dangnhap;
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.dangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dangnhap_ItemClick);
            // 
            // dmk
            // 
            this.dmk.Caption = "Thay Đổi Mật Khẩu";
            this.dmk.Id = 7;
            this.dmk.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.images__32x32;
            this.dmk.Name = "dmk";
            this.dmk.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.dmk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // Dsts
            // 
            this.Dsts.Caption = "Danh Sách Thí Sinh";
            this.Dsts.Id = 8;
            this.Dsts.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources._5_7_20159_25_45_am745anylist_app_icon;
            this.Dsts.Name = "Dsts";
            this.Dsts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Dsts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Dsts_ItemClick);
            // 
            // thoat
            // 
            this.thoat.Caption = "Thoát Chương Trình";
            this.thoat.Id = 9;
            this.thoat.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.exit_png_32x32;
            this.thoat.Name = "thoat";
            this.thoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // dangxuat
            // 
            this.dangxuat.Caption = "Đăng Xuất";
            this.dangxuat.Id = 10;
            this.dangxuat.ImageOptions.Image = global::Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe.Properties.Resources.button_on_off;
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dangxuat_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "\"Thuộc thiết kế của: Nhóm Sức Mạnh Công Nghệ";
            this.barStaticItem1.Id = 12;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "barStaticItem2";
            this.barStaticItem2.Id = 13;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý Hệ Thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.dangnhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.dmk);
            this.ribbonPageGroup2.ItemLinks.Add(this.dangxuat);
            this.ribbonPageGroup2.ItemLinks.Add(this.thoat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tài Khoản";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản Lý Thí Sinh";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.capnhat);
            this.ribbonPageGroup3.ItemLinks.Add(this.Dsts);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Công cụ quản lý";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản Lý Kết Quả Thi";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.DSdau);
            this.ribbonPageGroup4.ItemLinks.Add(this.DSrot);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Danh sách";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 619);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1180, 27);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 646);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navBarControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem ThemCauHoi;
        private DevExpress.XtraNavBar.NavBarItem DSthi;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem capnhat;
        private DevExpress.XtraBars.BarButtonItem DSdau;
        private DevExpress.XtraBars.BarButtonItem DSrot;
        private DevExpress.XtraBars.BarButtonItem dangnhap;
        private DevExpress.XtraNavBar.NavBarItem dscauhoi_tb;
        private DevExpress.XtraBars.BarButtonItem dmk;
        private DevExpress.XtraBars.BarButtonItem Dsts;
        private DevExpress.XtraBars.BarButtonItem thoat;
        private DevExpress.XtraBars.BarButtonItem dangxuat;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    }
}