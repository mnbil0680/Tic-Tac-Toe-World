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

namespace GUI.GUI_problem9_SUS
{
    public partial class Decision : Form
    {
        public Decision()
        {
            InitializeComponent();
        }

        private void Decision_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Decision_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // make sound of click button by resource file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // go to the main menu of SUS
            MainMenu_P9_SUS main = new MainMenu_P9_SUS();
            main.Show();
            this.Hide();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // make sound of click button by resource file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // open Random Player and Make player letter S
            RandomPlayer randomPlayercs = new RandomPlayer();
            randomPlayercs.Show();
            foreach (Control c in randomPlayercs.Controls)
            {
                if (c is Label)
                {
                    Label l = (Label)c;
                    if (l.Tag == "U")
                    {
                        l.Text = "Random Player U ";
                    }
                }
            }

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // make sound of click button by resource file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // open Random Player and Make player letter S
            RandomPlayer randomPlayercs = new RandomPlayer();
            foreach (Control c in randomPlayercs.Controls)
            {
                if (c is Label)
                {
                    Label ll = (Label)c;
                    if (ll.Tag == "S")
                    {
                        ll.Text = "Random Player S";
                    }
                }
            }
            // make a move for Random player S
            Random rnd = new Random();
            int choice = rnd.Next(1, 9);
            Button button = (Button)randomPlayercs.Controls.Find("button" + choice, true)[0];
            button.Image = Properties.Resources.S_letter;
            button.Tag = "S";
            Label lsl = (Label)randomPlayercs.Controls.Find("label7", true)[0];
            lsl.Text = "Player U";
            lsl.Tag = "U";

            randomPlayercs.counter--;
            randomPlayercs.CalculateScore();
            // make second condition true

            randomPlayercs.Show();
            this.Hide();
        }
    }
}
