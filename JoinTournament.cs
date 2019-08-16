using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poker_Holdem
{
    public partial class JoinTournament : Form
    {
        public JoinTournament()
        {
            InitializeComponent();
        }

        private void Tournament1_Click(object sender, EventArgs e)
        {
            Form TournamentOne = new TournamentOne();
            this.Close();
            TournamentOne.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
