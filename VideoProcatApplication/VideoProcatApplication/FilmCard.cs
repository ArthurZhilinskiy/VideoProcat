using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProcatApplication
{
    public partial class FilmCard : UserControl
    {
        public string name;
        public string zhanr;
        public string descryption;
        public string year;
        public string treyler;
        public string image;
        Form1 form;
        public FilmCard(string Video_name, string Video_zhanr, string Video_Descryption, string Video_Year, string Video_Treyler, string image_path, Form1 form)
        {
            InitializeComponent();
            this.name = Video_name;
            this.zhanr = Video_zhanr;
            this.descryption = Video_Descryption;
            this.year = Video_Year;
            this.treyler = Video_Treyler;
            this.image = image_path;
            this.form = form;

            fillData();
           

        }

        private void fillData()
        {
            // Загружаем исходное изображение
            var defaultImage = new Bitmap(Image.FromFile(image));
            // Масштабируем до нужного размера
            var scalingImage = new Bitmap(defaultImage, 133, 145);
            metroTile1.TileImage = scalingImage;

            metroLabel1.Text = name;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Text = name;
            form2.pictureBox1.Image = Image.FromFile(image);
            form2.tbDescryption.Text = descryption;
            form2.mlYear.Text = year;
            form2.mlZhanr.Text = zhanr;

            form2.Show();
            form2.axWindowsMediaPlayer1.URL = treyler;
            form2.axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.pictureBox1.Image = Image.FromFile(image);
            form3.mlName.Text = name;
            form3.mlZhanr.Text = zhanr;
            form3.mlYear.Text = year;
            form3.ShowDialog();
        }
    }
}
