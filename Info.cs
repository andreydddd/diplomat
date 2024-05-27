using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GMap.NET.MapProviders;

namespace diplomat
{
    public partial class Info : Form
    {
        bool sidebarExpand;
        public Info()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SlideBarTimer.Start();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
   


        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = CzechTuristMapProvider.Instance; gMapControl1.CacheLocation = Application.StartupPath + @"\maps\OSMCache";
            GMaps.Instance.Mode = AccessMode.ServerAndCache; gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left; gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter; gMapControl1.MinZoom = 10;
            gMapControl1.MaxZoom = 20; gMapControl1.Zoom = 15;
            gMapControl1.Position = new PointLatLng(56.419333, 40.448757); gMapControl1.ShowCenter = false;
            Createmarker();
        }
        private void Createmarker()
        {
            GMapOverlay ListOfCar = new GMapOverlay("hotel ");
            // Загружаем изображение
            Bitmap originalImage = new Bitmap(@"E:\фотк\domik.png");
            // Уменьшаем размер изображения (например, до 50% от оригинала)    int newWidth = (int)(originalImage.Width * 0.03);
            int newHeight = (int)(originalImage.Height * 0.04); Bitmap resizedImage = new Bitmap(originalImage, new Size(newHeight, newHeight));

            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(56.420678, 40.456303), resizedImage);

            marker.ToolTip = new GMapRoundedToolTip(marker); marker.ToolTipText = "Ремесленная Усадьба";

            ListOfCar.Markers.Add(marker);
            gMapControl1.Overlays.Add(ListOfCar);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MasterClass ms = new MasterClass();
            ms.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Bronirovanie br = new Bronirovanie();
            br.Show();
            this.Hide();
        }

        private void SlideBarTimer_Tick(object sender, EventArgs e)
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
    }
}
