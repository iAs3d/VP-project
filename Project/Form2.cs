using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {

        Boolean checker;
        int plusone;

        void Enable_False()
        {
            but1.Enabled = false;
            but2.Enabled = false;
            but3.Enabled = false;
            but4.Enabled = false;
            but5.Enabled = false;
            but6.Enabled = false;
            but7.Enabled = false;
            but8.Enabled = false;
            but9.Enabled = false;
        }

        void Score()
        {

            // check if draw
            bool allFilled = but1.Text != "" && but2.Text != "" && but3.Text != "" &&
                     but4.Text != "" && but5.Text != "" && but6.Text != "" &&
                     but7.Text != "" && but8.Text != "" && but9.Text != "";

            if (allFilled) // If all buttons are filled and no winner
            {
                MessageBox.Show("It's a Draw!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelD.Text);
                labelD.Text = Convert.ToString(++plusone);
                Enable_False();
            }


            // Player X:

            if (but1.Text == "X" && but2.Text == "X" && but3.Text == "X")
            {
                but1.BackColor = Color.CadetBlue;
                but2.BackColor = Color.CadetBlue;
                but3.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but1.Text == "X" && but4.Text == "X" && but7.Text == "X")
            {
                but1.BackColor = Color.CadetBlue;
                but4.BackColor = Color.CadetBlue;
                but7.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but1.Text == "X" && but5.Text == "X" && but9.Text == "X")
            {
                but1.BackColor = Color.CadetBlue;
                but5.BackColor = Color.CadetBlue;
                but9.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but2.Text == "X" && but5.Text == "X" && but8.Text == "X")
            {
                but2.BackColor = Color.CadetBlue;
                but5.BackColor = Color.CadetBlue;
                but8.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but3.Text == "X" && but5.Text == "X" && but7.Text == "X")
            {
                but3.BackColor = Color.CadetBlue;
                but5.BackColor = Color.CadetBlue;
                but7.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but3.Text == "X" && but6.Text == "X" && but9.Text == "X")
            {
                but3.BackColor = Color.CadetBlue;
                but6.BackColor = Color.CadetBlue;
                but9.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but4.Text == "X" && but5.Text == "X" && but6.Text == "X")
            {
                but4.BackColor = Color.CadetBlue;
                but5.BackColor = Color.CadetBlue;
                but6.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but7.Text == "X" && but8.Text == "X" && but9.Text == "X")
            {
                but7.BackColor = Color.CadetBlue;
                but8.BackColor = Color.CadetBlue;
                but9.BackColor = Color.CadetBlue;

                MessageBox.Show("The winner is: X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelX.Text);
                labelX.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            // Player O:

            if (but1.Text == "O" && but2.Text == "O" && but3.Text == "O")
            {
                but1.BackColor = Color.PowderBlue;
                but2.BackColor = Color.PowderBlue;
                but3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but1.Text == "O" && but4.Text == "O" && but7.Text == "O")
            {
                but1.BackColor = Color.PowderBlue;
                but4.BackColor = Color.PowderBlue;
                but7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but1.Text == "O" && but5.Text == "O" && but9.Text == "O")
            {
                but1.BackColor = Color.PowderBlue;
                but5.BackColor = Color.PowderBlue;
                but9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but2.Text == "O" && but5.Text == "O" && but8.Text == "O")
            {
                but2.BackColor = Color.PowderBlue;
                but5.BackColor = Color.PowderBlue;
                but8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but3.Text == "O" && but5.Text == "O" && but7.Text == "O")
            {
                but3.BackColor = Color.PowderBlue;
                but5.BackColor = Color.PowderBlue;
                but7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but3.Text == "O" && but6.Text == "O" && but9.Text == "O")
            {
                but3.BackColor = Color.PowderBlue;
                but6.BackColor = Color.PowderBlue;
                but9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but4.Text == "O" && but5.Text == "O" && but6.Text == "O")
            {
                but4.BackColor = Color.PowderBlue;
                but5.BackColor = Color.PowderBlue;
                but6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

            if (but7.Text == "O" && but8.Text == "O" && but9.Text == "O")
            {
                but7.BackColor = Color.PowderBlue;
                but8.BackColor = Color.PowderBlue;
                but9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is: O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(labelO.Text);
                labelO.Text = Convert.ToString(++plusone);
                Enable_False();
            }

        }

        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                but1.Text = "X";
                checker = true;
            }
            else
            {
                but1.Text = "O";
                checker = false;
            }
            Score();
            but1.Enabled = false;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but2.Text = "X";
                checker = true;
            }
            else
            {
                but2.Text = "O";
                checker = false;
            }
            Score();
            but2.Enabled = false;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but3.Text = "X";
                checker = true;
            }
            else
            {
                but3.Text = "O";
                checker = false;
            }
            Score();
            but3.Enabled = false;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but4.Text = "X";
                checker = true;
            }
            else
            {
                but4.Text = "O";
                checker = false;
            }
            Score();
            but4.Enabled = false;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but5.Text = "X";
                checker = true;
            }
            else
            {
                but5.Text = "O";
                checker = false;
            }
            Score();
            but5.Enabled = false;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but6.Text = "X";
                checker = true;
            }
            else
            {
                but6.Text = "O";
                checker = false;
            }
            Score();
            but6.Enabled = false;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but7.Text = "X";
                checker = true;
            }
            else
            {
                but7.Text = "O";
                checker = false;
            }
            Score();
            but7.Enabled = false;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but8.Text = "X";
                checker = true;
            }
            else
            {
                but8.Text = "O";
                checker = false;
            }
            Score();
            but8.Enabled = false;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                but9.Text = "X";
                checker = true;
            }
            else
            {
                but9.Text = "O";
                checker = false;
            }
            Score();
            but9.Enabled = false;
        }

        // New game click
        private void button22_Click(object sender, EventArgs e)
        {
            Button[] buttons = { but1, but2, but3, but4, but5, but6, but7, but8, but9 };

            foreach (var button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
                button.BackColor = Color.WhiteSmoke;
            }

        }
        
        // Reset the game click
        private void button23_Click(object sender, EventArgs e)
        {
            Button[] buttons = { but1, but2, but3, but4, but5, but6, but7, but8, but9 };

            foreach (var button in buttons)
            {
                button.Enabled = true;
                button.Text = "";
                button.BackColor = Color.WhiteSmoke;
            }

         /*   labelX.Text = "0";
            labelO.Text = "0";
            labelD.Text = "0";*/

            Label[] labels = { labelX, labelO, labelD };

            foreach (var label in labels)
            {
                label.Text = "0";
            }
        }
    }
}
