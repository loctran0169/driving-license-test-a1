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
    public partial class thi : Form
    {
        public thi()
        {
            InitializeComponent();
        }
        public int CAU = 1;
        public int id;

        int[] a = new int[20];
        string[] dapan_chon = new string[20] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        string[] dapan_dung = new string[20];
        int DIEM = 0;
        Button[] bt = new Button[20];

        string dbsv = @"Data Source=DESKTOP-AH1QL2I;Initial Catalog=THIBLX;Integrated Security=True";
        SqlConnection con;
        DataSet ds = new DataSet();

        int phut = 15, giay = 0;

        private void bt_batdau_Click(object sender, EventArgs e)
        {

            //timer1.Enabled = true;
            taode();
            laycauhoi(a[CAU - 1], ref dapan_dung[CAU - 1]);
            kt_sodapan();
            //bt_hientai();
            timer1.Start();
            textBox_Cau.Text = CAU.ToString();
            bt_batdau.Enabled = false;
            bt_down.Enabled = false;
            bt_up.Enabled = true;
            bt_ketthuc.Enabled = true;
        }
        void kt_sodapan()
        {
            textBox_C.Enabled = true;
            radioButton_C.Enabled = true;
            textBox_D.Enabled = true;
            radioButton_D.Enabled = true;
            if (textBox_C.Text == "")
            {
                textBox_C.Enabled = false;
                radioButton_C.Enabled = false;
                textBox_D.Enabled = false;
                radioButton_D.Enabled = false;

            }
            else if (textBox_D.Text == "")
            {
                textBox_D.Enabled = false;
                radioButton_D.Enabled = false;

            }



        }

        static bool Timx(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return true;
            return false;
        }
        void taode()
        {


            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x;
                do
                {
                     x = r.Next(1, 81);
                } while (Timx(a,x));
                a[i] = x;
            }
            for (int i = 10; i < 15; i++)
            {
                int x;
                do
                {
                    x = r.Next(81, 116);
                } while (Timx(a, x));
                a[i] = x;
            }
            for (int i = 15; i < 20; i++)
            {
                int x;
                do
                {
                    x = r.Next(116, 151);
                } while (Timx(a, x));
                a[i] = x;
            }
        }
        private void radioButton_A_CheckedChanged(object sender, EventArgs e)
        {

            dapan_chon[CAU - 1] = "a";
        }
        private void radioButton_B_CheckedChanged(object sender, EventArgs e)
        {

            dapan_chon[CAU - 1] = "b";
        }
        private void radioButton_C_CheckedChanged(object sender, EventArgs e)
        {
            dapan_chon[CAU - 1] = "c";
        }

        private void radioButton_D_CheckedChanged(object sender, EventArgs e)
        {
            dapan_chon[CAU - 1] = "d";
        }

        void add_cauhoihinh(int a)
        {
            pictureBox_cauhoi.Visible = true;
            con = new SqlConnection(dbsv);
            con.Open();
            string sqlselect = "select * from danhsachcauhoi_hinhanh where macau='" + a + "'";
            //SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataAdapter dr = new SqlDataAdapter(sqlselect, con);

            DataSet ds = new DataSet();
            dr.Fill(ds);
            DataTable dt_kiemtra_1 = new DataTable();
            dr.Fill(dt_kiemtra_1);
            foreach (DataRow dr1 in dt_kiemtra_1.Rows)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["anh"]);
                pictureBox_cauhoi.Image = new Bitmap(ms);
            }
        }
        void laycauhoi(int arr, ref string dapan)
        {
            
            con = new SqlConnection(dbsv);
            con.Open();
            string sqlselect = "select * from danhsachcauhoi_vanban where macau='" + arr + "'";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox5.Text = dr.GetValue(1).ToString();
            if(textBox5.Text=="")
            {
                add_cauhoihinh(arr);
            }
            textBox_A.Text = dr.GetValue(2).ToString();
            textBox_B.Text = dr.GetValue(3).ToString();
            textBox_C.Text = dr.GetValue(4).ToString();
            textBox_D.Text = dr.GetValue(5).ToString();
            dapan = dr.GetValue(6).ToString();
            con.Close();
        }
        void tao_bt_cauhoi()
        {
            int left = 0, top = 0;

            for (int i = 0; i < 20; i++)
            {
                bt[i] = new Button();
                bt[i].Size = new Size(40, 30);
                bt[i].Text = (i + 1).ToString();
                bt[i].Location = new Point(left, top);
                bt[i].BackColor = Color.White;
                panel1.Controls.Add(bt[i]);
                left += bt[i].Width;
                if ((i + 1) % 5 == 0)
                {
                    left = 0;
                    top += bt[i].Height;
                }

            }
        }
        private void bt_ketthuc_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            button1.Visible = true;
            bt_ketthuc.Enabled = false;
            for (int i = 0; i < 20; i++)
            {
                if (dapan_chon[i] == dapan_dung[i])
                {
                    DIEM++;
                    bt[i].BackColor = Color.Green;
                }


            }
            timer1.Stop();
            TXTPASS.Text = DIEM.ToString();
            if (DIEM >= 16)
                label1.Text = "ĐẬU";
            else label1.Text = "RỚT";


        }
        void to_dapan(int cau)
        {
            textBox_A.BackColor = groupBox1.BackColor;
            textBox_B.BackColor = groupBox1.BackColor;
            textBox_C.BackColor = groupBox1.BackColor;
            textBox_D.BackColor = groupBox1.BackColor;
            if (dapan_dung[cau] == "a")
                textBox_A.BackColor = Color.Red;
            else if (dapan_dung[cau] == "b")
                textBox_B.BackColor = Color.Red;
            else if (dapan_dung[cau] == "c")
                textBox_C.BackColor = Color.Red;
            else
                textBox_D.BackColor = Color.Red;

        }
        void bt_hientai()
        {
            textBox_Cau.Text = CAU.ToString();
            for (int i = 0; i < 20; i++)
            {
                bt[i].BackColor = Color.White;
            }
            bt[CAU - 1].BackColor = Color.LightGray;
        }
        void reset_radiobt()
        {
            if (dapan_chon[CAU - 1] == "a")
                radioButton_A.Checked = true;
            else if (dapan_chon[CAU - 1] == "b")
                radioButton_B.Checked = true;
            else if (dapan_chon[CAU - 1] == "c")
                radioButton_C.Checked = true;
            else if (dapan_chon[CAU - 1] == "d")
                radioButton_D.Checked = true;
            else
            {
                radioButton_A.Checked = false;
                radioButton_B.Checked = false;
                radioButton_C.Checked = false;
                radioButton_D.Checked = false;
            }


        }
        private void bt_up_Click(object sender, EventArgs e)
        {
            bt_down.Enabled = true;
            CAU++;
            textBox_Cau.Text = CAU.ToString();
            //bt_hientai();
            bt[CAU - 1].Focus();
            laycauhoi(a[CAU - 1], ref dapan_dung[CAU - 1]);
            reset_radiobt();
            kt_sodapan();
            if (CAU == 20)
                bt_up.Enabled = false;
            if (bt_ketthuc.Enabled == false)
            {
                to_dapan(CAU - 1);
            }
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            bt_up.Enabled = true;
            CAU--;
            //bt_hientai();
            bt[CAU - 1].Focus();
            textBox_Cau.Text = CAU.ToString();
            laycauhoi(a[CAU - 1], ref dapan_dung[CAU - 1]);
            reset_radiobt();
            kt_sodapan();
            if (CAU == 1)
                bt_down.Enabled = false;
            if (bt_ketthuc.Enabled == false)
            {
                to_dapan(CAU - 1);
            }
        }

        

        
        private void textBox_A_Click(object sender, EventArgs e)
        {
            radioButton_A.Checked = true;
        }

        private void textBox_B_Click(object sender, EventArgs e)
        {
            radioButton_B.Checked = true;
        }

        private void textBox_C_Click(object sender, EventArgs e)
        {
            radioButton_C.Checked = true;
        }

        private void textBox_D_Click(object sender, EventArgs e)
        {
            radioButton_D.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (phut == 0 && giay == 0)
            {
                timer1.Stop();
                button1.Visible = true;
                label13.Visible = true;
            }
            txtTIME.Text = phut.ToString() + ":" + giay.ToString();
            if (phut > 0)
            {
                if (giay > 0)
                {
                    giay--;

                }
                else
                {
                    giay = 59;
                    phut--;
                }
            }
            else
            {
                giay--;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlthem = "INSERT INTO diemso values ('" + id.ToString() + "','" + DIEM.ToString() + "')";
            SqlCommand cmd = new SqlCommand(sqlthem, con);
            cmd.ExecuteNonQuery();
            this.Close();
        }

       
        private void thi_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(dbsv);
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("select dsthisinh.msts,hoten,cmnd,image from dsthisinh,dsthi where dsthi.msts=dsthisinh.msts and dsthi.msts='" + id + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);
            //
            SqlDataAdapter da_kiemtra_1 = new SqlDataAdapter("select dsthisinh.msts,hoten,cmnd,image from dsthisinh,dsthi where dsthi.msts=dsthisinh.msts and dsthi.msts='" + id + "'", con);
            DataTable dt_kiemtra_1 = new DataTable();
            da_kiemtra_1.Fill(dt_kiemtra_1);

            if (dt_kiemtra.Rows.Count == 0 && dt_kiemtra.Rows.Count == 0)
            {
                MessageBox.Show("Không Có Trong Danh Sách");
                return;
            }
            if (dt_kiemtra != null)
            {

                foreach (DataRow dr in dt_kiemtra.Rows)
                {
                    
                    txHoTen.Text = dr["hoten"].ToString();
                    txtCMND.Text = dr["cmnd"].ToString();
                    txtMaTS.Text = dr["msts"].ToString();                   
                }
            }
            if (dt_kiemtra_1 != null)
            {
                DataSet ds = new DataSet();
                da_kiemtra_1.Fill(ds);
                foreach (DataRow dr in dt_kiemtra_1.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                    avatar.Image = new Bitmap(ms);
                }
            }
            bt_down.Enabled = false;
            bt_up.Enabled = false;
            bt_ketthuc.Enabled = false;
            textBox_Cau.Text = CAU.ToString();
            tao_bt_cauhoi();

        }
    }
}
