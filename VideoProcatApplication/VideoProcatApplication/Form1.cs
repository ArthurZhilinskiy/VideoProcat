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

namespace VideoProcatApplication
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=(local)\SQLEXPRESS;AttachDbFilename="+ Application.StartupPath +@"\VideoProcat.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getFilms();
        }

        public void getFilms()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Video", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string image_path = Application.StartupPath + reader["Video_Image"].ToString();
                string video_tryler = Application.StartupPath + reader["Video_treyler"].ToString();
                FilmCard cart = new FilmCard(reader["Video_name"].ToString(), reader["Video_zhanr"].ToString(), reader["Video_Descryption"].ToString(), reader["Video_Year"].ToString(), video_tryler, image_path, this);

                flowLayoutPanel1.Controls.Add(cart);
            }
            connection.Close();
        }

        private void cart_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Video WHERE Video_zhanr = 'Премьера'", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string image_path = Application.StartupPath + reader["Video_Image"].ToString();
                string video_tryler = Application.StartupPath + reader["Video_treyler"].ToString();
                FilmCard cart = new FilmCard(reader["Video_name"].ToString(), reader["Video_zhanr"].ToString(), reader["Video_Descryption"].ToString(), reader["Video_Year"].ToString(), video_tryler, image_path, this);

                cart.metroTile1.Click += new System.EventHandler(cart_Click);

                flowLayoutPanel1.Controls.Add(cart);
            }
            connection.Close();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Video WHERE Video_zhanr = 'Фильм'", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string image_path = Application.StartupPath + reader["Video_Image"].ToString();
                string video_tryler = Application.StartupPath + reader["Video_treyler"].ToString();
                FilmCard cart = new FilmCard(reader["Video_name"].ToString(), reader["Video_zhanr"].ToString(), reader["Video_Descryption"].ToString(), reader["Video_Year"].ToString(), video_tryler, image_path, this);

                cart.metroTile1.Click += new System.EventHandler(cart_Click);

                flowLayoutPanel1.Controls.Add(cart);
            }
            connection.Close();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Video WHERE Video_zhanr = 'Мультфильм'", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string image_path = Application.StartupPath + reader["Video_Image"].ToString();
                string video_tryler = Application.StartupPath + reader["Video_treyler"].ToString();
                FilmCard cart = new FilmCard(reader["Video_name"].ToString(), reader["Video_zhanr"].ToString(), reader["Video_Descryption"].ToString(), reader["Video_Year"].ToString(), video_tryler, image_path, this);

                cart.metroTile1.Click += new System.EventHandler(cart_Click);

                flowLayoutPanel1.Controls.Add(cart);
            }
            connection.Close();
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            getFilms();
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Video WHERE Video_name LIKE N'%" + metroTextBox1.Text + "%'", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string image_path = Application.StartupPath + reader["Video_Image"].ToString();
                string video_tryler = Application.StartupPath + reader["Video_treyler"].ToString();
                FilmCard cart = new FilmCard(reader["Video_name"].ToString(), reader["Video_zhanr"].ToString(), reader["Video_Descryption"].ToString(), reader["Video_Year"].ToString(), video_tryler, image_path, this);

                cart.metroTile1.Click += new System.EventHandler(cart_Click);

                flowLayoutPanel1.Controls.Add(cart);
            }
            connection.Close();
        }

        

        private void metroLink6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Video WHERE Video_zhanr = 'Сериал'", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string image_path = Application.StartupPath + reader["Video_Image"].ToString();
                string video_tryler = Application.StartupPath + reader["Video_treyler"].ToString();
                FilmCard cart = new FilmCard(reader["Video_name"].ToString(), reader["Video_zhanr"].ToString(), reader["Video_Descryption"].ToString(), reader["Video_Year"].ToString(), video_tryler, image_path, this);

                cart.metroTile1.Click += new System.EventHandler(cart_Click);

                flowLayoutPanel1.Controls.Add(cart);
            }
            connection.Close();
        }
    }
}
