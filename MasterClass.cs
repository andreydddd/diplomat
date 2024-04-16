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
    public partial class MasterClass : Form
    {
        public MasterClass()
        {
            InitializeComponent();

            pictureBox5.MouseEnter += pictureBox5_MouseEnter;
            pictureBox5.MouseLeave += pictureBox5_MouseLeave;

            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;

            pictureBox4.MouseEnter += pictureBox4_MouseEnter;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;

            pictureBox6.MouseEnter += pictureBox6_MouseEnter;
            pictureBox6.MouseLeave += pictureBox6_MouseLeave;

            pictureBox7.MouseEnter += pictureBox7_MouseEnter;
            pictureBox7.MouseLeave += pictureBox7_MouseLeave;

            pictureBox8.MouseEnter += pictureBox8_MouseEnter;
            pictureBox8.MouseLeave += pictureBox8_MouseLeave;
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }


        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }


        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }


        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }


        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }


        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

        }


        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
