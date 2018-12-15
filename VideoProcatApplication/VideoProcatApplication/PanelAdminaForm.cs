using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProcatApplication
{
    public partial class PanelAdminaForm : MetroFramework.Forms.MetroForm
    {
        Form1 form;
        public PanelAdminaForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            AddNewFilmControl fc = new AddNewFilmControl(form);
            flowLayoutPanel1.Controls.Add(fc);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DeleterControl df = new DeleterControl(this, form);
            flowLayoutPanel1.Controls.Add(df);
        }
    }
}
