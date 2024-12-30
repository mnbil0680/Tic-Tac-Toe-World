using GUI.GUI_problem8_UTTT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using GUI.GUI_problem9_SUS;

namespace GUI
{

    public partial class MainMenu_Game : Form
    {
        SoundPlayer _soundPlayer = new SoundPlayer(GUI.Properties.Resources.button);
        public MainMenu_Game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            //waiting for the sound to finish
            System.Threading.Thread.Sleep(100);
            // call main menu of problem 8 UTTT
            this.Hide();
            MainMenu_P8_UTTT mainMenu_UTTT = new MainMenu_P8_UTTT();
            mainMenu_UTTT.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            System.Threading.Thread.Sleep(100);
            // call main menu of problem 9 SUS
            this.Hide();
            MainMenu_P9_SUS mainMenu_SUS = new MainMenu_P9_SUS();   
            mainMenu_SUS.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            // exit the game
            Application.Exit();
            
        }

        private void MainMenu_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
