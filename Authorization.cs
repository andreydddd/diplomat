using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace diplomat
{

    public partial class Authorization : Form
    {


        public Authorization()
        {
            InitializeComponent();
        }
        DataBases dataBases = new DataBases();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Fcreate cr = new Fcreate();
            cr.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var log = LoginBox.Text;
            var pass = PassBox.Text;
            var mail = MailBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"select login, password, mail from userr where login = '{log}' and password = '{pass}' and mail = '{mail}'";

            SqlCommand command = new SqlCommand(query, dataBases.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно зашли.");
                Bronirovanie frm1 = new Bronirovanie();
                frm1.ShowDialog();
                this.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Такого пользователя нет,пожалуйста проверьте введенные даные.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
           Fcreate rg = new Fcreate();
            rg.Show();
            this.Hide();
        }
    }
    }

