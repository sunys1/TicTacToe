using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int rounds = 0;
        int scoreX = 0;
        int scoreO = 0;
        
        private void buttonClick(object sender, EventArgs e)
        {
            Button click = (Button)sender;

            if(rounds % 2 == 0)
            {
                click.Text = "X";
                rounds++;
            }
            else if(rounds % 2 == 1)
            {
                click.Text = "O";
                rounds++;

            }

            click.Enabled = false;
            CheckWinner();

        }

        private void CheckWinner()
        {
            bool WinnerFound = false;
            
            if(button1.Text == button2.Text && button2.Text == button3.Text && !button1.Text.Equals (""))
            {
                WinnerFound = true;
            }
            else if(button4.Text == button5.Text && button5.Text == button6.Text && !button4.Text.Equals(""))
            {
                WinnerFound = true;
            }
            else if(button7.Text == button8.Text && button8.Text == button9.Text && !button7.Text.Equals(""))
            {
                WinnerFound = true;
            }
            else if(button1.Text == button4.Text && button4.Text == button7.Text && !button1.Text.Equals(""))
            {
                WinnerFound = true;
            }
            else if(button1.Text == button5.Text && button5.Text == button9.Text && !button1.Text.Equals(""))
            {
                WinnerFound = true;
            }
            else if(button2.Text == button5.Text && button5.Text == button8.Text && !button2.Text.Equals(""))
            {
                WinnerFound = true;
            }
            else if(button3.Text == button6.Text && button6.Text == button9.Text && !button3.Text.Equals(""))
            {
                WinnerFound = true;
            }
            else if(button3.Text == button5.Text && button5.Text == button7.Text && !button3.Text.Equals(""))
            {
                WinnerFound = true;
            }

            if (WinnerFound)
            {
                if(rounds % 2 == 1)
                {
                    label1.Text = " X wins!!!";
                    scoreX++;
                    X.Text = "X: " + scoreX;
                    O.Text = "O: " + scoreO;
                }
                else
                {
                    label1.Text = " O Wins!!!";
                    scoreO++;
                    X.Text = "X: " + scoreX;
                    O.Text = "O: " + scoreO;
                }

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
            else if(rounds == 9){
                label1.Text = "X-O Drawww!!!";
            }

        }

        private void New(object sender, EventArgs e)
        {
            buttonControl();
        }

        private void Reset(object sender, EventArgs e)
        {
            scoreX = scoreO = 0;
            X.Text = "X: " + scoreX;
            O.Text = "O: " + scoreO;
            buttonControl();
        }
        public void buttonControl()
        {
            rounds = 0;
            label1.Text = "";
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
