using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProcatApplication
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=(local)\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\VideoProcat.mdf;Integrated Security=True";


        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
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

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE User_name = N'"+metroTextBox1.Text+"' AND User_login = N'"+metroTextBox2.Text+"'", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            connection.Close();

            if (i == 1)
            {
                PanelAdminaForm panelAdminaForm = new PanelAdminaForm();
                panelAdminaForm.Show();
            }
            else
            {
                ErrorForm ef = new ErrorForm();
                ef.ShowDialog();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
