using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace VideoProcatApplication
{
    public partial class AddNewFilmControl : UserControl
    {
        string connectionString = @"Data Source=(local)\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\VideoProcat.mdf;Integrated Security=True";
        string path, imageName, copyTo, treylerName;
        string path1, copyTo1;

        Form1 form;

        public AddNewFilmControl(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }        

        private void metroButton2_Click(object sender, EventArgs e)
        {
            copyTo = Application.StartupPath + mtbImage.Text;
            AddData();
            pictureBox1.Image = null;
            mtbName.Text = String.Empty;
            mtbImage.Text = String.Empty;
            mtbTreyler.Text = String.Empty;
            mtbTreyler.Text = String.Empty;
            mtbYear.Text = String.Empty;
            mtbDescryption.Text = String.Empty;
        }


        private void AddData()
        {
            if (pictureBox1.Image != null && !File.Exists(copyTo) && !File.Exists(copyTo1))
            {
                if (mtbName.Text != String.Empty && !String.IsNullOrWhiteSpace(mtbName.Text))
                {
                    if (mtbDescryption.Text != String.Empty && !String.IsNullOrWhiteSpace(mtbDescryption.Text))
                    {
                        if (mtbImage.Text != String.Empty && !String.IsNullOrWhiteSpace(mtbImage.Text))
                        {
                            if (mtbTreyler.Text != String.Empty && !String.IsNullOrWhiteSpace(mtbTreyler.Text))
                            {
                                //Копирование картинки в папку DishImages
                                try
                                {
                                    CopyFile(path, copyTo);
                                    CopyFile(path1, copyTo1);
                                }
                                catch
                                {
                                    MessageBox.Show("Очень плохой знак!");
                                }

                                //Добавление записей в БД
                                SqlConnection connection = new SqlConnection(connectionString);
                                try
                                {
                                    connection.Open();
                                    SqlCommand command_proverka = new SqlCommand("SELECT Video_Id FROM Video WHERE Video_name = N'" + mtbName.Text + "'", connection);
                                    SqlDataReader reader_proverka = command_proverka.ExecuteReader();
                                    int count = 0;
                                    while (reader_proverka.Read())
                                    {
                                        count++;
                                    }
                                    reader_proverka.Close();
                                    if (count == 0)
                                    {
                                        SqlCommand command = new SqlCommand("INSERT INTO Video(Video_name, Video_zhanr, Video_Descryption, Video_Year, Video_Image, Video_Treyler) VALUES (N'" + mtbName.Text + "', N'" + metroComboBox1.Text + "', N'" + mtbDescryption.Text + "', N'" + mtbYear.Text + "', N'" + mtbImage.Text + "', N'" + mtbTreyler.Text + "')", connection);
                                        command.ExecuteNonQuery();

                                        connection.Close();
                                        copyTo = "";
                                        UpdateForm(form);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Такой фильм уже есть, смените название или выберите другой фильм!");
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
                                connection.Close();
                            }
                        }
                    }
                }
                
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateForm(Form1 form)
        {
            form.flowLayoutPanel1.Controls.Clear();
            form.getFilms();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "MP4 files (*.mp4)|*.mp4";
           
            if (opfd.ShowDialog(this) == DialogResult.OK)
            {
                //полный путь к видосу
                path1 = opfd.FileName;

                //имяФайла.mp4
                treylerName = Path.GetFileName(opfd.FileName);

                //...\Debug\Treyler\имяФайла.mp4
                copyTo1 = Application.StartupPath + @"\Treyler\" + treylerName;

                mtbTreyler.Text = @"\Treyler\" + treylerName;
            }
        }

        void CopyFile(string from, string to)
        {
            FileInfo fn = new FileInfo(from);
            fn.CopyTo(to);
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "jpeg files (*.jpg)|*.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (opfd.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opfd.FileName);
                //полный путь к картинке
                path = opfd.FileName;
                //имяФайла.jpg
                imageName = Path.GetFileName(opfd.FileName);
                //...\Debug\Images\имяФайла.jpg
                copyTo = Application.StartupPath + @"\Images\" + imageName;
                
                mtbImage.Text = @"\Images\" + imageName;
            }
        }
    }
}
