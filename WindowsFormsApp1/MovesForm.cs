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
    public partial class MovesForm : Form
    {
        public List<Move> moves = new List<Move>();
        public MovesForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank inBank = Refs.BanksRef.banks.FirstOrDefault(i => i.Id == int.Parse(textBox3.Text));
            Bank outBank = Refs.BanksRef.banks.FirstOrDefault(i => i.Id == int.Parse(textBox2.Text));
            if (inBank != null && outBank != null)
            {
                moves.Add(new Move(textBox1.Text, int.Parse(textBox4.Text), int.Parse(textBox3.Text), int.Parse(textBox2.Text),dateTimePicker1.Value));
                dataGridView1.Rows.Add(moves[moves.Count - 1].Id, moves[moves.Count - 1].Name, outBank.Name, inBank.Name, moves[moves.Count - 1].Sum, moves[moves.Count - 1].Date);
                inBank.InAmt++;
                inBank.Sum += moves[moves.Count - 1].Sum;
                outBank.OutAmt++;
                outBank.Sum -= moves[moves.Count - 1].Sum;
            }
            else MessageBox.Show("מזהה בנק שגוי");
        }

        private void בנקיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refs.BanksRef.UpdateBanks();
            Refs.BanksRef.Show();
            Refs.MovesRef.Hide();
        }

        private void תנועותToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void ביתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refs.HomeRef.Show();
            Refs.MovesRef.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
