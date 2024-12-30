using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_problem9_SUS
{
    public partial class RandomPlayer : Form
    {
        public bool second_condition = false;
        public int counter = 9;
        public bool H1Flag = true;
        public bool H2Flag = true;
        public bool H3Flag = true;

        public bool V1Flag = true;
        public bool V2Flag = true;
        public bool V3Flag = true;

        public bool D159Flag = true;
        public bool D357Flag = true;

        public RandomPlayer()
        {
            InitializeComponent();
        }

        private void RandomPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RandomPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        public string CheckWinner()
        {
            if (int.Parse(CounterS.Text) > int.Parse(CounterU.Text))
            {
                if (label2.Text == "Player S  :")
                {
                    return "Player S";

                }
                else
                {
                    return "Random Player S";
                }
            }
            else if (int.Parse(CounterS.Text) < int.Parse(CounterU.Text))
            {
                if (label3.Text == "Player U :")
                {
                    return "Player U";
                }
                else
                {
                    return "Random Player U";
                }
            }
            else
            {
                return "No One";
            }
        }



        public void CounterAndLabel(string Symbol)
        {
            if (Symbol == "S")
            {
                CounterS.Text = (int.Parse(CounterS.Text) + 1).ToString();
            }
            else if (Symbol == "U")
            {
                CounterU.Text = (int.Parse(CounterU.Text) + 1).ToString();
            }
        }

        public void CalculateScore()
        {
            /*
             1 2 3
             4 5 6
             7 8 9
             */

            // check Horizental

            if (button1.Tag.ToString() == "S" && button2.Tag.ToString() == "U" && button3.Tag.ToString() == "S" && H1Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                H1Flag = false;
            }
            if (button4.Tag.ToString() == "S" && button5.Tag.ToString() == "U" && button6.Tag.ToString() == "S" && H2Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                H2Flag = false;
            }
            if (button7.Tag.ToString() == "S" && button8.Tag.ToString() == "U" && button9.Tag.ToString() == "S" && H3Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                H3Flag = false;
            }

            // check Horizental
            if (button1.Tag.ToString() == "S" && button4.Tag.ToString() == "U" && button7.Tag.ToString() == "S" && V1Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                V1Flag = false;
            }
            if (button2.Tag.ToString() == "S" && button5.Tag.ToString() == "U" && button8.Tag.ToString() == "S" && V2Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                V2Flag = false;
            }
            if (button3.Tag.ToString() == "S" && button6.Tag.ToString() == "U" && button9.Tag.ToString() == "S" && V3Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                V3Flag = false;
            }

            // check Diagonal
            if (button1.Tag.ToString() == "S" && button5.Tag.ToString() == "U" && button9.Tag.ToString() == "S" && D159Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                D159Flag = false;
            }
            if (button3.Tag.ToString() == "S" && button5.Tag.ToString() == "U" && button7.Tag.ToString() == "S" && D357Flag)
            {
                CounterAndLabel(label7.Tag.ToString());
                D357Flag = false;
            }
        }


        public void GameOver(string Winner)
        {
            // make sound of click button by resource file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.win);
            player.Play();
            MessageBox.Show($"Game Over\nWinner is {Winner}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Winner == "No One")
            {
                label9.Text = "Draw";
                label7.Text = "";
            }
            else
            {
                label9.Text = Winner;
                label7.Text = "Game Over";
            }
            // Stop the game



        }
        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
            end:
                if (label7.Text == "Player S")
                {
                    buttonSound();
                    btn.Image = Resources.S_letter;
                    btn.Tag = "S";
                    label7.Text = "Random Player U";
                    CalculateScore();
                    label7.Tag = "U";
                    counter--;
                    if (counter == 0)
                    {
                        GameOver(CheckWinner());
                        // Stop the game
                        goto end;
                    }
                    // make a random choice
                    Random rnd = new Random();
                    int choice = rnd.Next(1, 9);
                    Button button = (Button)this.Controls.Find("button" + choice, true)[0];
                    while (button.Tag.ToString() != "?")
                    {
                        choice = rnd.Next(1, 9);
                        button = (Button)this.Controls.Find("button" + choice, true)[0];
                    }
                    button.Image = Resources.U_letter;
                    button.Tag = "U";
                    label7.Text = "Player S";
                    CalculateScore();
                    label7.Tag = "S";
                    counter--;
                    if (counter == 0)
                    {
                        GameOver(CheckWinner());
                        goto end;
                    }



                }
                else if (label7.Text == "Random Player S")
                {
                    buttonSound();
                    Random rnd = new Random();
                    int choice = rnd.Next(1, 9);
                    Button button = (Button)this.Controls.Find("button" + choice, true)[0];
                    while (button.Tag.ToString() != "?")
                    {
                        choice = rnd.Next(1, 9);
                        button = (Button)this.Controls.Find("button" + choice, true)[0];
                    }
                    button.Image = Resources.S_letter;
                    button.Tag = "S";
                    label7.Text = "Player U";
                    CalculateScore();
                    label7.Tag = "U";
                    counter--;
                    if (counter == 0)
                    {
                        GameOver(CheckWinner());
                        // Stop the game
                        goto end;
                    }


                }
                else if (label7.Text == "Player U")
                {
                    buttonSound();
                    second_condition = true;
                    btn.Image = Resources.U_letter;
                    btn.Tag = "U";
                    label7.Text = "Random Player S";
                    CalculateScore();
                    label7.Tag = "S";
                    counter--;
                    if (counter == 0)
                    {
                        GameOver(CheckWinner());
                        // Stop the game
                        goto end;
                    }
                    // make a random choice
                    Random rnd = new Random();
                    int choice = rnd.Next(1, 9);
                    Button button = (Button)this.Controls.Find("button" + choice, true)[0];
                    if (counter > 5)
                    {
                        while (button.Tag.ToString() != "?")
                        {
                            choice = rnd.Next(1, 9);
                            button = (Button)this.Controls.Find("button" + choice, true)[0];
                        }

                    }
                    else
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            button = (Button)this.Controls.Find("button" + i, true)[0];
                            if (button.Tag.ToString() == "?")
                            {
                                break;
                            }
                        }
                    }
                    button.Image = Resources.S_letter;
                    button.Tag = "S";
                    label7.Text = "Player U";
                    CalculateScore();
                    label7.Tag = "U";
                    counter--;
                    if (counter == 0)
                    {
                        GameOver(CheckWinner());
                        goto end;
                    }
                }
                else if (label7.Text == "Random Player U")
                {
                    buttonSound();
                    second_condition = true;
                    Random rnd = new Random();
                    int choice = rnd.Next(1, 9);
                    Button button = (Button)this.Controls.Find("button" + choice, true)[0];
                    if (counter > 5)
                    {
                        while (button.Tag.ToString() != "?")
                        {
                            choice = rnd.Next(1, 9);
                            button = (Button)this.Controls.Find("button" + choice, true)[0];
                        }

                    }
                    else
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            button = (Button)this.Controls.Find("button" + i, true)[0];
                            if (button.Tag.ToString() == "?")
                            {
                                break;
                            }
                        }
                    }
                    button.Image = Resources.U_letter;
                    button.Tag = "U";
                    label7.Text = "Player S";
                    CalculateScore();
                    label7.Tag = "S";
                    counter--;
                    if (counter == 0)
                    {
                        GameOver(CheckWinner());
                        // Stop the game
                        goto end;
                    }
                }

            }
            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // make sound of click button by resource file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // go to the main menu of SUS
            MainMenu_P9_SUS main = new MainMenu_P9_SUS();
            main.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // make sound of click button by resource file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
            // Reset buttons
            button1.Image = Resources.Question_mark; button1.Tag = "?";
            button2.Image = Resources.Question_mark; button2.Tag = "?";
            button3.Image = Resources.Question_mark; button3.Tag = "?";
            button4.Image = Resources.Question_mark; button4.Tag = "?";
            button5.Image = Resources.Question_mark; button5.Tag = "?";
            button6.Image = Resources.Question_mark; button6.Tag = "?";
            button7.Image = Resources.Question_mark; button7.Tag = "?";
            button8.Image = Resources.Question_mark; button8.Tag = "?";
            button9.Image = Resources.Question_mark; button9.Tag = "?";
            CounterS.Text = "0";
            CounterU.Text = "0";
            counter = 9;

            label7.Text = "Player S";
            label9.Text = "in Progress";
            H1Flag = true;
            H2Flag = true;
            H3Flag = true;

            V1Flag = true;
            V2Flag = true;
            V3Flag = true;

            D159Flag = true;
            D357Flag = true;
            if (second_condition)
            {
                foreach (Control c in this.Controls)
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
                Button button = (Button)this.Controls.Find("button" + choice, true)[0];
                button.Image = Properties.Resources.S_letter;
                button.Tag = "S";
                Label lsl = (Label)this.Controls.Find("label7", true)[0];
                lsl.Text = "Player U";
                lsl.Tag = "U";
                counter--;
                CalculateScore();
                // make second condition true


            }

        }

        private void RandomPlayer_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 600, 300, 1250, 300);
            e.Graphics.DrawLine(whitePen, 600, 460, 1250, 460);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 810, 140, 810, 620);
            e.Graphics.DrawLine(whitePen, 1040, 140, 1040, 620);
        }
    
        public void buttonSound()
        {
            // make sound of click button by resource file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.button);
            player.Play();
        }
    
    
    }
}
