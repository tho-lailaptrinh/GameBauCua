using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBauCua
{
    public partial class Form1 : Form
    {
        int limit = 0;
        public Form1()
        {
            InitializeComponent(); // khởi tạo các controll
            // Set ánh cho pictrubox
            ptb_Bau.Image = Image.FromFile(@"E:\ảnh nền\Bầu cua tôm cá\bầu.jpg");
            ptb_Bau.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Cua.Image = Image.FromFile(@"E:\ảnh nền\Bầu cua tôm cá\cua.jpg");
            ptb_Cua.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Tom.Image = Image.FromFile(@"E:\ảnh nền\Bầu cua tôm cá\tôm.jpg");
            ptb_Tom.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Ca.Image = Image.FromFile(@"E:\ảnh nền\Bầu cua tôm cá\cá.jpg");
            ptb_Ca.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Ga.Image = Image.FromFile(@"E:\ảnh nền\Bầu cua tôm cá\gà.jpg");
            ptb_Ga.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Hieu.Image = Image.FromFile(@"E:\ảnh nền\Bầu cua tôm cá\hiêu.jpg");
            ptb_Hieu.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            // Tạo 1 mảng chứa các đường dẫn đến ảnh
            string[] arrBauCua = new string[]
            {
                @"E:\ảnh nền\Bầu cua tôm cá\bầu.jpg",
                @"E:\ảnh nền\Bầu cua tôm cá\cua.jpg",
                @"E:\ảnh nền\Bầu cua tôm cá\tôm.jpg",
                @"E:\ảnh nền\Bầu cua tôm cá\cá.jpg",
                @"E:\ảnh nền\Bầu cua tôm cá\gà.jpg",
                @"E:\ảnh nền\Bầu cua tôm cá\hiêu.jpg",
            };
            // Ramdom vị trí link ảnh trong mảng trên để gán cho pictrubox
            Random ramdom = new Random();
            int ramdom1 = ramdom.Next(0, 5); int ramdom2 = ramdom.Next(0,5); int ramdom3 = ramdom.Next(0,5);
            // Gản ảnh cho pictureBox thông qua URL 
            ptb_R1.Image = Image.FromFile(arrBauCua[ramdom1]);
            ptb_R1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_R2.Image = Image.FromFile(arrBauCua[ramdom2]);
            ptb_R2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_R3.Image = Image.FromFile(arrBauCua[ramdom3]);
            ptb_R3.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void ptb_Click(Label lb)
        {
            lb.Text = Convert.ToInt32(lb.Text) + 1 + "";
            limit++;    
            if (limit > 3)
            {
                limit -= Convert.ToInt32(lb.Text);
                lb.Text = "0";
            }
        }
       
        public void TotaBet()
        {
            if(lb_bau.Text !="0" ) check[0] = Convert.ToInt32(lb_bau.Text);
            if(lb_cua.Text !="0" ) check[0] = Convert.ToInt32(lb_cua.Text);
            if(lb_tom.Text !="0" ) check[0] = Convert.ToInt32(lb_tom.Text);
            if(lb_ca.Text !="0" ) check[0] = Convert.ToInt32(lb_ca.Text);
            if(lb_ga.Text !="0" ) check[0] = Convert.ToInt32(lb_ga.Text);
            if(lb_hieu.Text !="0" ) check[0] = Convert.ToInt32(lb_hieu.Text);
            MessageBox.Show(string.Join("-", check));
            // Tính tổng số lượng đặt cược
            int count = 0;
            foreach (var item in check) count += item;
            TotaBet = count * bet
        }

        private void ptb_Bau_Click(object sender, EventArgs e)
        {
            ptb_Click(lb_bau);
        }

        private void ptb_Hieu_Click(object sender, EventArgs e)
        {
            ptb_Click(lb_hieu);
        }

        private void ptb_Cua_Click(object sender, EventArgs e)
        {
            ptb_Click( lb_cua);
        }

        private void ptb_Tom_Click(object sender, EventArgs e)
        {
            ptb_Click(lb_tom);
        }

        private void ptb_Ca_Click(object sender, EventArgs e)
        {
            ptb_Click( lb_ca);
        }

        private void ptb_Ga_Click(object sender, EventArgs e)
        {
            ptb_Click( lb_ga);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
