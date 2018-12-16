using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VideoProcatApplication
{
    public partial class DeleterControl : UserControl
    {
        string connectionString = @"Data Source=(local)\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\VideoProcat.mdf;Integrated Security=True";

        PanelAdminaForm form;
        Form1 form1;
        public DeleterControl(PanelAdminaForm form, Form1 form1)
        {
            InitializeComponent();
            this.form = form;
            this.form1 = form1;

            fillGrid();
        }

        private void fillGrid()
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

            SqlCommand command = new SqlCommand("SELECT Video_Id, Video_name FROM Video", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }

            foreach (string[] s in data)
                metroGrid1.Rows.Add(s);
            connection.Close();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != String.Empty && !String.IsNullOrWhiteSpace(metroTextBox1.Text))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    string deletingImage = "";
                    string deletingTreyler = "";
                    SqlCommand command1 = new SqlCommand("SELECT Video_Image, Video_Treyler FROM Video WHERE Video_Id = N'" + metroTextBox1.Text + "' ", connection);
                    SqlDataReader reader;
                    reader = command1.ExecuteReader();
                    while (reader.Read())
                    {
                        deletingImage = Application.StartupPath + reader["Video_Image"];
                        deletingTreyler = Application.StartupPath + reader["Video_Treyler"];
                    }
                    reader.Close();

                    SqlCommand command = new SqlCommand("DELETE FROM Video WHERE Video_Id = N'" + metroTextBox1.Text + "' ", connection);
                    command.ExecuteNonQuery();
                    metroGrid1.Rows.Clear();
                    fillGrid();
                    UpdateForm(form1);

                    try
                    {
                        if (File.Exists(deletingImage))
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            FileInfo f = new FileInfo(deletingImage);
                            f.Delete();
                        }
                        if (File.Exists(deletingTreyler))
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            FileInfo f = new FileInfo(deletingTreyler);
                            f.Delete();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

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
        }

        private void UpdateForm(Form1 form)
        {
            form.flowLayoutPanel1.Controls.Clear();

            form.getFilms();
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            metroTextBox1.Text = (string) metroGrid1.CurrentRow.Cells[0].Value;
        }
    }
}
