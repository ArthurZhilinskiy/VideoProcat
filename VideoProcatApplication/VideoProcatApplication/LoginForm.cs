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

        Form1 form;
        public LoginForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE User_name = N'" + metroTextBox1.Text + "' AND User_login = N'" + metroTextBox2.Text + "'", connection);
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
                    PanelAdminaForm panelAdminaForm = new PanelAdminaForm(form);
                    panelAdminaForm.Show();
                }
                else
                {
                    ErrorForm ef = new ErrorForm();
                    ef.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
