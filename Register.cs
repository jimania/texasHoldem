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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Program.pc.setRegistered(true);

            Form LogIn = new LogIn();
            this.Close();
            LogIn.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.pc.setRegisteredName(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Program.pc.setRegisteredPass(textBox1.Text);
        }
    }
}
