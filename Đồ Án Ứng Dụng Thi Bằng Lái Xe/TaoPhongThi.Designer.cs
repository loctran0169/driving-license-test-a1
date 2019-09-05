namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    partial class TaoPhongThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xacnhan = new System.Windows.Forms.Button();
            this.tenphong = new System.Windows.Forms.TextBox();
            this.phongthi = new System.Windows.Forms.ComboBox();
            this.ngaythi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.addroom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trái = new System.Windows.Forms.Button();
            this.phai = new System.Windows.Forms.Button();
            this.groupBox_phong = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox_thisinh = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nguoigac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diadiemphong = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.txtmsts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_phong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox_thisinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(121, 69);
            this.soluong.Margin = new System.Windows.Forms.Padding(2);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(148, 20);
            this.soluong.TabIndex = 39;
            this.soluong.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Số thí sinh tối đa:";
            // 
            // xacnhan
            // 
            this.xacnhan.Location = new System.Drawing.Point(111, 119);
            this.xacnhan.Margin = new System.Windows.Forms.Padding(2);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(83, 24);
            this.xacnhan.TabIndex = 36;
            this.xacnhan.Text = "Xác nhận";
            this.xacnhan.UseVisualStyleBackColor = true;
            this.xacnhan.Click += new System.EventHandler(this.xacnhan_Click);
            // 
            // tenphong
            // 
            this.tenphong.Location = new System.Drawing.Point(121, 18);
            this.tenphong.Margin = new System.Windows.Forms.Padding(2);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(148, 20);
            this.tenphong.TabIndex = 35;
            // 
            // phongthi
            // 
            this.phongthi.FormattingEnabled = true;
            this.phongthi.Location = new System.Drawing.Point(111, 18);
            this.phongthi.Margin = new System.Windows.Forms.Padding(2);
            this.phongthi.Name = "phongthi";
            this.phongthi.Size = new System.Drawing.Size(131, 21);
            this.phongthi.TabIndex = 34;
            // 
            // ngaythi
            // 
            this.ngaythi.CustomFormat = "dMy";
            this.ngaythi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaythi.Location = new System.Drawing.Point(111, 50);
            this.ngaythi.Margin = new System.Windows.Forms.Padding(2);
            this.ngaythi.MinDate = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            this.ngaythi.Name = "ngaythi";
            this.ngaythi.Size = new System.Drawing.Size(131, 20);
            this.ngaythi.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ngày thi:";
            // 
            // addroom
            // 
            this.addroom.Location = new System.Drawing.Point(140, 119);
            this.addroom.Margin = new System.Windows.Forms.Padding(2);
            this.addroom.Name = "addroom";
            this.addroom.Size = new System.Drawing.Size(115, 28);
            this.addroom.TabIndex = 32;
            this.addroom.Text = "Thêm phòng thi";
            this.addroom.UseVisualStyleBackColor = true;
            this.addroom.Click += new System.EventHandler(this.addroom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phòng thi:";
            // 
            // trái
            // 
            this.trái.Location = new System.Drawing.Point(451, 346);
            this.trái.Margin = new System.Windows.Forms.Padding(2);
            this.trái.Name = "trái";
            this.trái.Size = new System.Drawing.Size(59, 30);
            this.trái.TabIndex = 30;
            this.trái.Text = "<<<";
            this.trái.UseVisualStyleBackColor = true;
            this.trái.Click += new System.EventHandler(this.trái_Click);
            // 
            // phai
            // 
            this.phai.Location = new System.Drawing.Point(451, 303);
            this.phai.Margin = new System.Windows.Forms.Padding(2);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(59, 30);
            this.phai.TabIndex = 29;
            this.phai.Text = ">>>";
            this.phai.UseVisualStyleBackColor = true;
            this.phai.Click += new System.EventHandler(this.phai_Click);
            // 
            // groupBox_phong
            // 
            this.groupBox_phong.Controls.Add(this.dataGridView2);
            this.groupBox_phong.Location = new System.Drawing.Point(538, 183);
            this.groupBox_phong.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_phong.Name = "groupBox_phong";
            this.groupBox_phong.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_phong.Size = new System.Drawing.Size(469, 266);
            this.groupBox_phong.TabIndex = 28;
            this.groupBox_phong.TabStop = false;
            this.groupBox_phong.Text = "Danh sách thí sinh trong phòng";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 15);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(465, 249);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // groupBox_thisinh
            // 
            this.groupBox_thisinh.Controls.Add(this.dgv1);
            this.groupBox_thisinh.Location = new System.Drawing.Point(3, 185);
            this.groupBox_thisinh.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_thisinh.Name = "groupBox_thisinh";
            this.groupBox_thisinh.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_thisinh.Size = new System.Drawing.Size(425, 266);
            this.groupBox_thisinh.TabIndex = 26;
            this.groupBox_thisinh.TabStop = false;
            this.groupBox_thisinh.Text = "Danh sách thí sinh";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(2, 15);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(421, 249);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 177);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt phòng thi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.xacnhan);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.phongthi);
            this.groupBox3.Controls.Add(this.ngaythi);
            this.groupBox3.Location = new System.Drawing.Point(108, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 152);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn phòng thi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nguoigac);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.diadiemphong);
            this.groupBox2.Controls.Add(this.tenphong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addroom);
            this.groupBox2.Controls.Add(this.soluong);
            this.groupBox2.Location = new System.Drawing.Point(537, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 152);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm Phòng Thi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Người coi thi:";
            // 
            // nguoigac
            // 
            this.nguoigac.Location = new System.Drawing.Point(121, 94);
            this.nguoigac.Name = "nguoigac";
            this.nguoigac.Size = new System.Drawing.Size(148, 20);
            this.nguoigac.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Địa điểm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tên phòng:";
            // 
            // diadiemphong
            // 
            this.diadiemphong.Location = new System.Drawing.Point(121, 43);
            this.diadiemphong.Name = "diadiemphong";
            this.diadiemphong.Size = new System.Drawing.Size(148, 20);
            this.diadiemphong.TabIndex = 36;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(433, 264);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 23);
            this.add.TabIndex = 41;
            this.add.Text = "Tìm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txtmsts
            // 
            this.txtmsts.Location = new System.Drawing.Point(431, 226);
            this.txtmsts.Name = "txtmsts";
            this.txtmsts.Size = new System.Drawing.Size(100, 20);
            this.txtmsts.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nhập MSTS";
            // 
            // TaoPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmsts);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trái);
            this.Controls.Add(this.phai);
            this.Controls.Add(this.groupBox_phong);
            this.Controls.Add(this.groupBox_thisinh);
            this.Name = "TaoPhongThi";
            this.Size = new System.Drawing.Size(1015, 478);
            this.Load += new System.EventHandler(this.TaoPhongThi_Load);
            this.groupBox_phong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox_thisinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button xacnhan;
        private System.Windows.Forms.TextBox tenphong;
        private System.Windows.Forms.ComboBox phongthi;
        private System.Windows.Forms.DateTimePicker ngaythi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trái;
        private System.Windows.Forms.Button phai;
        private System.Windows.Forms.GroupBox groupBox_phong;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox_thisinh;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txtmsts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diadiemphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nguoigac;
        private System.Windows.Forms.Label label4;
    }
}
