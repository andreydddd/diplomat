using diplomat.Controllers;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomat
{
    public partial class Bronirovanie : Form
    {
        bool sidebarExpand;

        private List<Bitmap> images = new List<Bitmap>();
        private int currentIndex = 0;
       

        public Bronirovanie()
        {
            InitializeComponent();
            LoadImages();
            DisplayImages();
            DisplayCurrentImage();
        }

        private void LoadImages()
        {
            // Загрузка изображений из файлов или из ресурсов
            images.Add(new Bitmap(Properties.Resources.number1));
            images.Add(new Bitmap(Properties.Resources.number2));
            images.Add(new Bitmap(Properties.Resources.number3));
            // Загрузите все необходимые изображения в список
        }
        private void DisplayImages()
        {
            
            guna2Standartp.BorderColor = Color.FromArgb(239, 232, 213);
            guna2Standartp.BorderRadius = 10;
            guna2Standartp.BorderThickness = 3;
        }
        private void DisplayCurrentImage()
        {

            guna2PictureBox4.Image = images[currentIndex];
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime startDate = dateTimePicker1.Value;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           // DateTime endDate = dateTimePicker2.Value;
        }



        private void label3_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MasterClass ms = new MasterClass();
            ms.Show();
            this.Hide();
        }

        private void Bronirovanie_Load(object sender, EventArgs e)
        {

        }

        private void SlideBarTimer_Tick_1(object sender, EventArgs e)
        {
            panelMenu.Location = new Point(-2, -2);
            panelMenu.Show();

            if (sidebarExpand)
                {
                panelMenu.Width -= 500;
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SlideBarTimer.Stop();
                }
            }

            else
            {
                panelMenu.Width += 500;
                if (panelMenu.Width == panelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SlideBarTimer.Stop();
                }
            }
        }
        


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SlideBarTimer.Start();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
            this.Hide();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            guna2Standartp.BringToFront();

            pictureBox2.Show();
            guna2Panel1.Controls.Add(pictureBox2);

            pictureBox2.Location = new Point(11, 6);
            standart.Visible = false;
           
            komfort.Visible = true;
            pictureBox4.Visible = false;

            luks.Visible = true;
            pictureBox7.Visible = false;

           /* StandartControl standartControl1 = new StandartControl();
            standartControl1.Location = new Point(220, 80);
            standartControl1.Size = new Size(1113, 477);
            this.Controls.Add(standartControl1);
            standartControl1.BringToFront();*/
        }

        private void label5_Click_2(object sender, EventArgs e)
        {
            KomfortControl komfortControl1 = new KomfortControl();
            komfortControl1.Location = new Point(135, 290);
            komfortControl1.Size = new Size(1131, 502);
            this.Controls.Add(komfortControl1);
            komfortControl1.BringToFront();

            pictureBox4.Show();
            guna2Panel1.Controls.Add(pictureBox4);

            pictureBox4.Location = new Point(181, 6);
            komfort.Visible = false;

            standart.Visible = true;
            pictureBox2.Visible = false;

            luks.Visible = true;
            pictureBox7.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LuksControll ls = new LuksControll();
            ls.Location = new Point(135, 290);
            ls.Size = new Size(1131, 502);
            this.Controls.Add(ls);
            ls.BringToFront();

            pictureBox7.Show();

            guna2Panel1.Controls.Add(pictureBox7);

            pictureBox7.Location = new Point(351, 6);

           luks.Visible = false;

            pictureBox4.Visible= false;
            komfort.Visible= true;
            standart.Visible= true;
            pictureBox2.Visible= false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            DisplayCurrentImage();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            DisplayCurrentImage();
        }
    }
}
