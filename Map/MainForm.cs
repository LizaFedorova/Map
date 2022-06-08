using System;
using System.Windows.Forms;

namespace Map
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map g = new Map();
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
            info.Show();
        }
    }
}
