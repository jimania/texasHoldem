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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            if (Program.pc.registered()==false)
            {
                Program.pc.checkUser.setName("user");
                Program.pc.checkUser.setPass("123");
                if (Program.pc.player.checkData(Program.pc.checkUser))
                {
                    Form JoinTournament = new JoinTournament();
                    this.Close();
                    JoinTournament.Show();
                }
                else
                    textBox3.Text = "Wrong data attempts " + (3 - Program.pc.player.getLogAttempts() + " remaining");
            }
            else
            {
                if (Program.pc.player.checkData(Program.pc.registeredUser))
                {
                    Form JoinTournament = new JoinTournament();
                    this.Close();
                    JoinTournament.Show();
                }
                else
                    textBox3.Text = "Wrong data attempts " + (3 - Program.pc.player.getLogAttempts() + " remaining");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.pc.player.setName(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Program.pc.player.setPass(textBox2.Text);
        }
    }
}
