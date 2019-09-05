using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Đồ_Án_Ứng_Dụng_Thi_Bằng_Lái_Xe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //QuanLy f1 = new QuanLy();
            //f1.ShowDialog();
            
        }

        private void resourcesComboBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLy f1 = new QuanLy();
            f1.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thisinhdangnhap ts = new thisinhdangnhap();
            ts.ShowDialog();
            if (ts.DDN == true)
            {
                
                thi t = new thi();
                t.id = Convert.ToInt32(ts.MSTS);
                t.ShowDialog();
                

            }
        }
    }
}
