using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace diplomat
{
    public partial class Fcreate : Form
    {
        DataBases dataBases = new DataBases();

        public Fcreate()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var log = textBox2.Text;
            var pass = textBox.Text;
            var mail = textBox1.Text;

            string querystring = $"insert into userr(login, password, mail) values ('{log}', '{pass}', '{mail}')";

            SqlCommand command = new SqlCommand(querystring, dataBases.getConnection());

            dataBases.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("аккаунт успешно создан!");
                Authorization frmlgn = new Authorization();
                this.Hide();
                frmlgn.ShowDialog();
            }
            else
            {
                MessageBox.Show("произошла ошибка");
            }
            dataBases.closeConnection();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Authorization au = new Authorization();
            au.Show();
            this.Hide();
        }
    }
}
