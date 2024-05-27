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
    public partial class KomfortClass : Form
    {

        private List<Bitmap> images = new List<Bitmap>();
        private int currentIndex = 0;
        private Timer timer;


        public KomfortClass()
        {
            InitializeComponent();
            DisplayImages();
            LoadImages();
            DisplayCurrentImage();

            timer = new Timer();
            timer.Interval = 5000; // Устанавливаем интервал в 5 секунды
            timer.Tick += TimerNext_Tick; // Подписываемся на событие Tick
            timer.Start();
        }

        private void LoadImages()
        {
            // Загрузка изображений из файлов или из ресурсов
            images.Add(new Bitmap(Properties.Resources.num1));
            images.Add(new Bitmap(Properties.Resources.num2));
            images.Add(new Bitmap(Properties.Resources.num3));
            images.Add(new Bitmap(Properties.Resources.num4));
        }
        private void DisplayImages()
        {

            guna2Panel1.BorderColor = Color.FromArgb(128, 128, 128);
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.BorderThickness = 1;

           guna2Panel2.BorderColor = Color.FromArgb(239, 232, 213);
           guna2Panel2.BorderThickness = 3;
            //guna2Panel2.BackColor = Color.FromArgb(239, 232, 213);
            guna2Panel2.BorderRadius = 15;
           
        }
        private void DisplayCurrentImage()
        {
            guna2PictureBox1.BorderRadius = 25;
            guna2PictureBox1.Image = images[currentIndex];
        }

        private void TimerNext_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            DisplayCurrentImage();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           

            // Переход к предыдущему изображению
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            DisplayCurrentImage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            currentIndex = (currentIndex + 1) % images.Count;
            DisplayCurrentImage();
        }
    }
}
