using System;
using System.Drawing;
using System.Windows.Forms;

namespace Map
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm fm = new MainForm();
            fm.Location = this.Location;
            fm.Show();
        }

        private void buttonMetall_Click(object sender, EventArgs e)
        {
            textBoxPlastic.Visible = false;
            picturePlasticMarkers.Visible = false;
            pictureTime.Visible = false;
            textBoxMetall.Visible = true;
        }

        private void buttonPlastic_Click(object sender, EventArgs e)
        {
            textBoxMetall.Visible = false;
            picturePlasticMarkers.Visible = false;
            pictureTime.Visible = false;
            textBoxPlastic.Visible = true;
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            textBoxMetall.Visible = false;
            textBoxPlastic.Visible = false;
            picturePlasticMarkers.Visible = false;
            pictureTime.Visible = true;
        }

        private void buttonPlasticMarkers_Click(object sender, EventArgs e)
        {
            textBoxPlastic.Visible = false;
            textBoxMetall.Visible = false;
            pictureTime.Visible = false;
            picturePlasticMarkers.Visible = true;
        }
    }
}
