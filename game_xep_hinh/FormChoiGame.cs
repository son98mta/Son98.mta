using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace game_xep_hinh
{
    public partial class FormChoiGame : Form
    {
        public FormChoiGame()
        {
            InitializeComponent();
        }
    

        public int x, y;
        int flag = 1;
        public int[] Arr = new int[9];
        public int Diem;
        public int Time;
        public int Level;
        public bool TT_Game = true; // Biến trạng thái game. Game chạy biến = true, game tạm dừng biến = false


        public void initArr()
        {
            for (int i = 1; i <= 9; i++)
            {
                Arr[i] = i;
            }
        }

        public void init()
        {
            x = 0;
            y = 0;
            Diem = 0;
            Time = 0;
            Level = 0;
        }

        public int GetVT(int x, int y)
        {
            return x + 3 * y;
        }

        
        private void lbThoiGian_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lblSecond.Text);                        //int32.parse(string s) dùng dể chuyển chuỗi dạng số có kiểu int
            int b = Int32.Parse(lblMinute.Text);
            a++;
            if (a > 59)
            {
                a = 0;
                b++;
            }
            if (a < 10)
                lblSecond.Text = "0" + a;
            else
                lblSecond.Text = a + "";
            if (b < 10)
                lblMinute.Text = "0" + b;
            else
                lblMinute.Text = b + "";
        }

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "Nhac-Game-Cover (online-audio-converter.com).wav";
            player.controls.play();
            if (!timer1.Enabled)
            {
                btnTamDung.Text = "Tạm dừng";
                timer1.Start();
                player.controls.stop();

            }
            else
            {
                btnTamDung.Text = "Tiếp tục";
                timer1.Stop();
                player.controls.play();

            }
        }

        private void btnTroChoiMoi_Click(object sender, EventArgs e)
        {
            init();
            //setmap();
            timer1.Start();

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "Nhac-Game-Cover (online-audio-converter.com).wav";
            player.controls.play();
            flag = 0;
            if (flag == 0)
            {
                button1.Text = " Bật nhạc";
                player.controls.stop();
                flag = 1;

            }
            if(flag == 1)
            {
                button1.Text = " Tắt nhạc ";
                player.controls.play();
            }

            


                


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        public void GetAnh(PictureBox pb, int a)
        {
            switch(a)
            {
                case 1: pb.Image = game_xep_hinh.Properties.Resources.Anh1; break;
                case 2: pb.Image = game_xep_hinh.Properties.Resources.Anh2; break;
                case 3: pb.Image = game_xep_hinh.Properties.Resources.Anh3; break;
                case 4: pb.Image = game_xep_hinh.Properties.Resources.Anh4; break;
                case 5: pb.Image = game_xep_hinh.Properties.Resources.Anh5; break;
                case 6: pb.Image = game_xep_hinh.Properties.Resources.Anh6; break;
                case 7: pb.Image = game_xep_hinh.Properties.Resources.Anh7; break;
                case 8: pb.Image = game_xep_hinh.Properties.Resources.Anh8; break;
                case 9: pb.Image = null; pb.BackColor = Color.White; break;
            }
        }
    }
}
