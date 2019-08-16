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
    public partial class TournamentOne : Form
    {
        public TournamentOne()
        {
            InitializeComponent();
        }

        private void ExitTournament_Click_1(object sender, EventArgs e)
        {
            Form JoinTournament = new JoinTournament();
            this.Close();
        }

        private void TournamentOne_Load(object sender, EventArgs e)
        {
            
            //Program.pc.initializeGame(this);
        }

        private void TournamentOne_Paint(object sender, PaintEventArgs e)
        {
            if (Program.pc.getGameCount() != 0)
            {
                if (Program.pc.checkIfActive(0))
                {
                    label1.Text = Program.pc.getPlayerName(0);
                    Image im1 = Image.FromFile(Program.pc.getPlayerCard(0));
                    pictureBox1.Image = im1;
                    Image im2 = Image.FromFile(Program.pc.getPlayerSecondCard(0));
                    pictureBox2.Image = im2;
                    label10.Text = (Program.pc.getPlayerChips(0)).ToString();
                    label19.Text = (Program.pc.getPlayerPot(0)).ToString();
                }
                else
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    label1.Visible = false;
                    label10.Visible = false;
                    label19.Visible = false;
                }
                if (Program.pc.checkIfActive(1))
                {
                    label2.Text = Program.pc.getPlayerName(1);
                    Image im3 = Image.FromFile(Program.pc.getPlayerCard(1));
                    pictureBox3.Image = im3;
                    Image im4 = Image.FromFile(Program.pc.getPlayerSecondCard(1));
                    pictureBox4.Image = im4;
                    label11.Text = (Program.pc.getPlayerChips(1)).ToString();
                    label20.Text = (Program.pc.getPlayerPot(1)).ToString();
                }
                else
                {
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    label2.Visible = false;
                    label11.Visible = false;
                    label20.Visible = false;
                }
                if (Program.pc.checkIfActive(2))
                {
                    label3.Text = Program.pc.getPlayerName(2);
                    Image im5 = Image.FromFile(Program.pc.getPlayerCard(2));
                    pictureBox5.Image = im5;
                    Image im6 = Image.FromFile(Program.pc.getPlayerSecondCard(2));
                    pictureBox6.Image = im6;
                    label12.Text = (Program.pc.getPlayerChips(2)).ToString();
                    label21.Text = (Program.pc.getPlayerPot(2)).ToString();
                }
                else
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    label3.Visible = false;
                    label12.Visible = false;
                    label21.Visible = false;
                }
                if (Program.pc.checkIfActive(3))
                {
                    label4.Text = Program.pc.getPlayerName(3);
                    Image im7 = Image.FromFile(Program.pc.getPlayerCard(3));
                    pictureBox7.Image = im7;
                    Image im8 = Image.FromFile(Program.pc.getPlayerSecondCard(3));
                    pictureBox8.Image = im8;
                    label13.Text = (Program.pc.getPlayerChips(3)).ToString();
                    label22.Text = (Program.pc.getPlayerPot(3)).ToString();
                }
                else
                {
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    label4.Visible = false;
                    label13.Visible = false;
                    label22.Visible = false;
                }
                if (Program.pc.checkIfActive(4))
                {
                    label5.Text = Program.pc.getPlayerName(4);
                    Image im9 = Image.FromFile(Program.pc.getPlayerCard(4));
                    pictureBox9.Image = im9;
                    Image im10 = Image.FromFile(Program.pc.getPlayerSecondCard(4));
                    pictureBox10.Image = im10;
                    label14.Text = (Program.pc.getPlayerChips(4)).ToString();
                    label23.Text = (Program.pc.getPlayerPot(4)).ToString();
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    label5.Visible = false;
                    label14.Visible = false;
                    label23.Visible = false;
                }
                if (Program.pc.checkIfActive(5))
                {
                    label6.Text = Program.pc.getPlayerName(5);
                    Image im11 = Image.FromFile(Program.pc.getPlayerCard(5));
                    pictureBox11.Image = im11;
                    Image im12 = Image.FromFile(Program.pc.getPlayerSecondCard(5));
                    pictureBox12.Image = im12;
                    label15.Text = (Program.pc.getPlayerChips(5)).ToString();
                    label24.Text = (Program.pc.getPlayerPot(5)).ToString();
                }
                else
                {
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    label6.Visible = false;
                    label15.Visible = false;
                    label24.Visible = false;
                }
                if (Program.pc.checkIfActive(6))
                {
                    label7.Text = Program.pc.getPlayerName(6);
                    Image im13 = Image.FromFile(Program.pc.getPlayerCard(6));
                    pictureBox13.Image = im13;
                    Image im14 = Image.FromFile(Program.pc.getPlayerSecondCard(6));
                    pictureBox14.Image = im14;
                    label16.Text = (Program.pc.getPlayerChips(6)).ToString();
                    label25.Text = (Program.pc.getPlayerPot(6)).ToString();
                }
                else
                {
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    label7.Visible = false;
                    label16.Visible = false;
                    label25.Visible = false;
                }
                if (Program.pc.checkIfActive(7))
                {
                    label8.Text = Program.pc.getPlayerName(7);
                    Image im15 = Image.FromFile(Program.pc.getPlayerCard(7));
                    pictureBox15.Image = im15;
                    Image im16 = Image.FromFile(Program.pc.getPlayerSecondCard(7));
                    pictureBox16.Image = im16;
                    label17.Text = (Program.pc.getPlayerChips(7)).ToString();
                    label26.Text = (Program.pc.getPlayerPot(7)).ToString();
                }
                else
                {
                    pictureBox15.Visible = false;
                    pictureBox16.Visible = false;
                    label8.Visible = false;
                    label17.Visible = false;
                    label26.Visible = false;
                }
                if (Program.pc.checkIfActive(8))
                {
                    label9.Text = Program.pc.getPlayerName(8);
                    Image im17 = Image.FromFile(Program.pc.getPlayerCard(8));
                    pictureBox17.Image = im17;
                    Image im18 = Image.FromFile(Program.pc.getPlayerSecondCard(8));
                    pictureBox18.Image = im18;
                    label18.Text = (Program.pc.getPlayerChips(8)).ToString();
                    label27.Text = (Program.pc.getPlayerPot(8)).ToString();
                }
                else
                {
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    label9.Visible = false;
                    label18.Visible = false;
                    label27.Visible = false;
                }
                if (Program.pc.getBoardActivity())
                {
                    Image im19 = Image.FromFile(Program.pc.getBoardCard(0));
                    pictureBox19.Image = im19;
                    Image im20 = Image.FromFile(Program.pc.getBoardCard(1));
                    pictureBox20.Image = im20;
                    Image im21 = Image.FromFile(Program.pc.getBoardCard(2));
                    pictureBox21.Image = im21;
                    Image im22 = Image.FromFile(Program.pc.getBoardCard(3));
                    pictureBox22.Image = im22;
                    Image im23 = Image.FromFile(Program.pc.getBoardCard(4));
                    pictureBox23.Image = im23;

                }
                else
                {
                    pictureBox19.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox23.Visible = false;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.pc.check();
            Program.pc.gameLoop(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.pc.playerRaise();
            Program.pc.gameLoop(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // perform user related actions
            Program.pc.gameLoop(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.pc.fold();
            Program.pc.gameLoop(this);
        }

        private void StartRound_Click(object sender, EventArgs e)
        {
            Program.pc.initializeGame(this);
        }




    }
}
