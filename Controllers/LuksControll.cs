using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomat.Controllers
{
    public partial class LuksControll : UserControl
    {
        private List<Bitmap> images = new List<Bitmap>();
        private int currentIndex = 0;
        public LuksControll()
        {
            InitializeComponent();
            LoadImages();
            DisplayImages();
            DisplayCurrentImage();
        }

        private void LoadImages()
        {
            // Загрузка изображений из файлов или из ресурсов
            images.Add(new Bitmap(Properties.Resources.l1));
            images.Add(new Bitmap(Properties.Resources.l2));
            images.Add(new Bitmap(Properties.Resources.l3));
            images.Add(new Bitmap(Properties.Resources.l4));
            images.Add(new Bitmap(Properties.Resources.l5));
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            DisplayCurrentImage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            DisplayCurrentImage();
        }
    }
}
