using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Refs.HomeRef = this;
            Refs.BanksRef = new BanksForm();
            Refs.MovesRef = new MovesForm();
        }

        private void בנקיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refs.BanksRef.Show();
            Refs.HomeRef.Hide();
        }

        private void תנועותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refs.MovesRef.Show();
            Refs.HomeRef.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
