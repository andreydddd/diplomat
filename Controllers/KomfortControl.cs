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
    public partial class KomfortControl : UserControl
    {
        private List<Bitmap> images = new List<Bitmap>();
        private int currentIndex = 0;

        public KomfortControl()
        {
            InitializeComponent();
            LoadImages();
            DisplayCurrentImage();
            DisplayImages();
            
        }

        private void LoadImages()
        {
            // Загрузка изображений из файлов или из ресурсов
            images.Add(new Bitmap(Properties.Resources.num1));
            images.Add(new Bitmap(Properties.Resources.num2));
            images.Add(new Bitmap(Properties.Resources.num3));
            images.Add(new Bitmap(Properties.Resources.num4));
            // Загрузите все необходимые изображения в список
        }

       
        private void DisplayImages()
        {

            guna2Standartp.BorderColor = Color.FromArgb(239, 232, 213);
            guna2Standartp.BorderRadius = 10;
            guna2Standartp.BorderThickness = 3;

           guna2Elipse1.BorderRadius = 10;
            
            
        }
        private void DisplayCurrentImage()
        {

            guna2PictureBox4.Image = images[currentIndex];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            DisplayCurrentImage();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Переход к предыдущему изображению
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            DisplayCurrentImage();
        }

        private void StandartControl_Load(object sender, EventArgs e)
        {

        }

       
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            

        }
    }
}
