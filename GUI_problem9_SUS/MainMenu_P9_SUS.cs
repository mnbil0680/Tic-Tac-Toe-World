using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_problem9_SUS
{
    public partial class MainMenu_P9_SUS : Form
    {
        public MainMenu_P9_SUS()
        {
            InitializeComponent();
        }

        private void MainMenu_P9_SUS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_P9_SUS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // make sound of button click
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.button);
            player.Play();
            // go to main menu
            MainMenu_Game mainMenu = new MainMenu_Game();
            mainMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // make sound of button click
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.button);
            player.Play();
            // go to PvP
            PvP pvp = new PvP();
            pvp.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // make sound of button click
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.button);
            player.Play();
            // go to decision
            Decision decision = new Decision();
            decision.Show();
            this.Hide();

        }
    }
}
