using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UselessBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Tag = Properties.Settings.Default.MyCounter++;
            Properties.Settings.Default.Save();
            string name = Properties.Settings.Default.ApplicationName;
            this.Text = $"{name}, run count: {this.Tag}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
