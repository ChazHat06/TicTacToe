using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            string filePath = "StatsFile.txt";
            string[] lines = File.ReadAllLines(filePath);
            label1.Text = "Placed Squares: " + (lines[0].TrimStart('0'));
            label2.Text = "Played Games: " + (lines[1].TrimStart('0'));
            label3.Text = "Won Games: " + (lines[2].TrimStart('0')); 
            label4.Text = "Lost Games: " + (lines[3].TrimStart('0'));
            label5.Text = "Drew Games: " + (lines[4].TrimStart('0'));
            label6.Text = "Time Spent Playing: " + (lines[5].TrimStart('0')) + " Seconds";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
