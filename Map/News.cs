using System;
using System.Drawing;
using System.Windows.Forms;

namespace Map
{
    public partial class News : Form
    {
        public News()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm fm = new MainForm();
            fm.Location = this.Location;
            fm.Show();
        }

        private void News_Load(object sender, EventArgs e)
        {

        }
    }
}
