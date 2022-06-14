using System;
using System.Drawing;
using System.Windows.Forms;
namespace Map
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map g = new Map();
            g.Location = this.Location;
            g.Show();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information info = new Information();
            info.Location = this.Location;
            info.Show();
        }

        private void buttonNews_Click(object sender, EventArgs e)
        {
            this.Hide();
            News news = new News();
            news.Location = this.Location;
            news.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
