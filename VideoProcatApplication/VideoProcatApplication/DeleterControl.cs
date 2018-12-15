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
    }
}
