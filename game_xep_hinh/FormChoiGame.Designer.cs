﻿namespace game_xep_hinh
{
    partial class FormChoiGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbMucChoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnTroChoiMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(368, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(527, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mức chơi:";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.Black;
            this.lbDiem.Location = new System.Drawing.Point(424, 25);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(43, 20);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "điểm";
            // 
            // lbMucChoi
            // 
            this.lbMucChoi.AutoSize = true;
            this.lbMucChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMucChoi.ForeColor = System.Drawing.Color.Black;
            this.lbMucChoi.Location = new System.Drawing.Point(600, 25);
            this.lbMucChoi.Name = "lbMucChoi";
            this.lbMucChoi.Size = new System.Drawing.Size(72, 20);
            this.lbMucChoi.TabIndex = 1;
            this.lbMucChoi.Text = "mức chơi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(368, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian:";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.Color.Black;
            this.lblMinute.Location = new System.Drawing.Point(443, 67);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(27, 20);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "00";
            this.lblMinute.Click += new System.EventHandler(this.lbThoiGian_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.BackColor = System.Drawing.Color.Aquamarine;
            this.btnTamDung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTamDung.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamDung.Location = new System.Drawing.Point(25, 360);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(100, 40);
            this.btnTamDung.TabIndex = 2;
            this.btnTamDung.Text = "Bắt đầu chơi";
            this.btnTamDung.UseVisualStyleBackColor = false;
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnTroChoiMoi
            // 
            this.btnTroChoiMoi.BackColor = System.Drawing.Color.Aquamarine;
            this.btnTroChoiMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTroChoiMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroChoiMoi.Location = new System.Drawing.Point(131, 360);
            this.btnTroChoiMoi.Name = "btnTroChoiMoi";
            this.btnTroChoiMoi.Size = new System.Drawing.Size(100, 40);
            this.btnTroChoiMoi.TabIndex = 2;
            this.btnTroChoiMoi.Text = "Trò chơi mới";
            this.btnTroChoiMoi.UseVisualStyleBackColor = false;
            this.btnTroChoiMoi.Click += new System.EventHandler(this.btnTroChoiMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(237, 360);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImage = global::game_xep_hinh.Properties.Resources.Untitled_1;
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.Location = new System.Drawing.Point(372, 100);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(300, 300);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh9;
            this.pb9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb9.Location = new System.Drawing.Point(237, 237);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(100, 100);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 0;
            this.pb9.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh6;
            this.pb6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb6.Location = new System.Drawing.Point(237, 131);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(100, 100);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 0;
            this.pb6.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh3;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(237, 25);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 100);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 0;
            this.pb3.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh8;
            this.pb8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb8.Location = new System.Drawing.Point(131, 237);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(100, 100);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 0;
            this.pb8.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh5;
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.Location = new System.Drawing.Point(131, 131);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(100, 100);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 0;
            this.pb5.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh7;
            this.pb7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb7.Location = new System.Drawing.Point(25, 237);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(100, 100);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 0;
            this.pb7.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh4;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(25, 131);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(100, 100);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 0;
            this.pb4.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh2;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(131, 25);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 100);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImage = global::game_xep_hinh.Properties.Resources.Anh1;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(25, 25);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 100);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(466, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            this.label4.Click += new System.EventHandler(this.lbThoiGian_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Black;
            this.lblSecond.Location = new System.Drawing.Point(474, 67);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(27, 20);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "00";
            this.lblSecond.Click += new System.EventHandler(this.lbThoiGian_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChoiGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTroChoiMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMucChoi);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "FormChoiGame";
            this.Text = "XẾP HÌNH";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lbMucChoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnTroChoiMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

