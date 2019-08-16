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
    public partial class Welcome : Form
    {
        public Welcome()
        {

            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form Register = new Register();
            this.Hide();
            Register.Show();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {

        
            Form LogIn = new LogIn();
            this.Hide();
            LogIn.Show();
        }
    }
}
