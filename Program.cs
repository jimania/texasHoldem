using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Poker_Holdem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static public PokerController pc;
        static void Main()
        {

            pc = new PokerController();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}
