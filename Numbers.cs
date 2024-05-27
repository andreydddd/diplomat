using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace diplomat
{
    public partial class Numbers : Form
    {

        private List<Bitmap> images = new List<Bitmap>();
        private int currentIndex = 0;
        private Timer timer;

        public Numbers()
        {
            InitializeComponent();
            LoadImages();
            DisplayCurrentImage();

            timer = new Timer();
            timer.Interval = 5000; // Устанавливаем интервал в 5 секунды
            timer.Tick += TimerSlider_Tick; // Подписываемся на событие Tick
            timer.Start();
        }

        private void LoadImages()
        {
            // Загрузка изображений из файлов или из ресурсов
            images.Add (new Bitmap(Properties.Resources.krendel));
            images.Add(new Bitmap(Properties.Resources.kuznec));
            images.Add(new Bitmap(Properties.Resources.okno));
            // Загрузите все необходимые изображения в список
        }

        private void DisplayCurrentImage()
        {
            guna2PictureBox1.BorderRadius = 50;
            guna2PictureBox1.Image = images[currentIndex];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Остановить таймер TimerSlider при ручном переключении
            TimerSlider.Stop();

            currentIndex = (currentIndex + 1) % images.Count;
            DisplayCurrentImage();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Остановить таймер TimerSlider при ручном переключении
            TimerSlider.Stop();

            // Переход к предыдущему изображению
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            DisplayCurrentImage();

        }

        private void TimerSlider_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            DisplayCurrentImage();
        }

        private void Numbers_Load(object sender, EventArgs e)
        {

        }


        /*
         private List<Bitmap> images = new List<Bitmap>();
        private int currentIndex = 0;
        private Guna2PictureBox[] pictureBoxes;
        private int numPictureBoxes = 3; // Количество pictureBoxes
        private Timer TimerSlider;

        public Bronirovanie()
        {
            InitializeComponent();
            LoadImages();
            pictureBoxes = new Guna2PictureBox[] { guna2PictureBox1, guna2PictureBox2, guna2PictureBox3 };
            DisplayImages();

            TimerSlider = new Timer();
            TimerSlider.Interval = 5000; // Устанавливаем интервал в 5 секунды
            TimerSlider.Tick += TimerSliders_Tick;
            TimerSlider.Start();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void LoadImages()
        {
            images.Add(new Bitmap(Properties.Resources.krendel));
            images.Add(new Bitmap(Properties.Resources.kuznec));
            images.Add(new Bitmap(Properties.Resources.okno));
            images.Add(new Bitmap(Properties.Resources.gonchar));
            // Загрузите все необходимые изображения в список
        }
        private void DisplayImages()
        {
            for (int i = 0; i < numPictureBoxes; i++)
            {
                int index = (currentIndex + i) % images.Count;
                pictureBoxes[i].Image = images[index];
                pictureBoxes[i].BorderRadius = 30; // Добавляем скругление углов

                guna2Panel1.BackColor = Color.White;

                // Установка цвета границы панели в зеленый
                guna2Panel1.BorderColor = Color.FromArgb(239, 232, 213);

                // Установка толщины границы панели (если нужно)
                guna2Panel1.BorderThickness = 3;

                // Установка скругленных углов панели
                guna2Panel1.BorderRadius = 10;
                guna2Standartp.BorderColor = Color.FromArgb(239, 232, 213);
                guna2Standartp.BorderRadius = 10;
                guna2Standartp.BorderThickness = 3;


            }
        }

         private void ShiftImagesRight()
        {
            currentIndex = (currentIndex + 1) % images.Count;
            DisplayImages();
        }
        private void ShiftImagesLeft()
        {
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            DisplayImages();
        }

        private void TimerSliders_Tick(object sender, EventArgs e)
        {
            ShiftImagesRight();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerSliders.Stop();
            ShiftImagesRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerSliders.Stop();

            ShiftImagesLeft();

        }
         */
    }
}
