using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_problem8_UTTT
{
    public partial class MainMenu_P8_UTTT : Form
    {
        public MainMenu_P8_UTTT()
        {
            InitializeComponent();
        }

        private void MainMenu_P8_UTTT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_P8_UTTT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // make the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // go to main menu
            MainMenu_Game mainMenu = new MainMenu_Game();
            mainMenu.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // make the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // go to the game
            PvP game = new PvP();
            game.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // make the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // go to the game
            RandomPlayer game = new RandomPlayer();
            game.Show();
            this.Hide();
        }
    }
}
