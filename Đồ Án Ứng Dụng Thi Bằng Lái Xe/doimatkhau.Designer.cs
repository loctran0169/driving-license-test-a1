namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    partial class doimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doimatkhau));
            this.label1 = new System.Windows.Forms.Label();
            this.TK = new System.Windows.Forms.TextBox();
            this.btDMK = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mk2 = new System.Windows.Forms.TextBox();
            this.mk1 = new System.Windows.Forms.TextBox();
            this.mk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản:";
            // 
            // TK
            // 
            this.TK.Location = new System.Drawing.Point(142, 38);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(191, 20);
            this.TK.TabIndex = 4;
            // 
            // btDMK
            // 
            this.btDMK.Location = new System.Drawing.Point(106, 244);
            this.btDMK.Name = "btDMK";
            this.btDMK.Size = new System.Drawing.Size(101, 54);
            this.btDMK.TabIndex = 6;
            this.btDMK.Text = "Đổi Mật Khẩu";
            this.btDMK.UseVisualStyleBackColor = true;
            this.btDMK.Click += new System.EventHandler(this.btDMK_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(272, 244);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(110, 54);
            this.thoat.TabIndex = 7;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mk2);
            this.groupBox1.Controls.Add(this.mk1);
            this.groupBox1.Controls.Add(this.mk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TK);
            this.groupBox1.Location = new System.Drawing.Point(49, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 182);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điền Thông Tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập Lại Mật Khẩu:";
            // 
            // mk2
            // 
            this.mk2.Location = new System.Drawing.Point(142, 116);
            this.mk2.Name = "mk2";
            this.mk2.Size = new System.Drawing.Size(191, 20);
            this.mk2.TabIndex = 9;
            // 
            // mk1
            // 
            this.mk1.Location = new System.Drawing.Point(142, 90);
            this.mk1.Name = "mk1";
            this.mk1.Size = new System.Drawing.Size(191, 20);
            this.mk1.TabIndex = 8;
            // 
            // mk
            // 
            this.mk.Location = new System.Drawing.Point(142, 64);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(191, 20);
            this.mk.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu Củ:";
            // 
            // doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.btDMK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doimatkhau";
            this.Text = "login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TK;
        private System.Windows.Forms.Button btDMK;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mk2;
        private System.Windows.Forms.TextBox mk1;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}