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
    public partial class BanksForm : Form
    {
        public List<Bank> banks = new List<Bank>();
        public BanksForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banks.Add(new Bank(textBox1.Text));
            dataGridView1.Rows.Add(banks[banks.Count - 1].Id, banks[banks.Count - 1].Name, banks[banks.Count - 1].OutAmt, banks[banks.Count - 1].InAmt, banks[banks.Count - 1].Sum);
        }

        private void ביתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refs.HomeRef.Show();
            Refs.BanksRef.Hide();
        }

        private void תנועותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refs.MovesRef.Show();
            Refs.BanksRef.Hide();
        }
        public void UpdateBanks()
        {
            dataGridView1.Rows.Clear();
            foreach(Bank b in banks)
            {
                b.InAmt = 0;
                b.OutAmt = 0;
                b.Sum = 0;
                foreach(Move m in Refs.MovesRef.moves)
                {
                    if(m.InId == b.Id)
                    {
                        b.InAmt++;
                        b.Sum += m.Sum;
                    }
                    else if(m.OutId == b.Id)
                    {
                        b.OutAmt++;
                        b.Sum -= m.Sum;
                    }
                }
                dataGridView1.Rows.Add(b.Id, b.Name, b.OutAmt, b.InAmt, b.Sum);
            }
        }
    }
}
