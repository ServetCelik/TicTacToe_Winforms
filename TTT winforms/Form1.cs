using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT_winforms
{
    public partial class Form1 : Form
    {
        static int[] wins = { 0, 0 };
        char[,] ticTacToeButtons = new char[3,3];
        private char[] symbols = { 'X' , 'O'};
        int currentTurn = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Current score is X:{wins[0]} and Y:{wins[1]} ";
        }


        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "asdasda";
        }

        private bool CheckRows()
        {
            for (int i = 0; i < 3; i++)
            {
                if (( ticTacToeButtons[i, 0]== 'X' & ticTacToeButtons[i, 1]== 'X' & ticTacToeButtons[i, 2]=='X') | (ticTacToeButtons[i, 0] == 'O' & ticTacToeButtons[i, 1] == 'O' & ticTacToeButtons[i, 2] == 'O'))
                {
                    return true;                                          
                }               

            }
            return false;
        }

        private bool CheckColumbs()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((ticTacToeButtons[0,i] == 'X' & ticTacToeButtons[1,i] == 'X' & ticTacToeButtons[2,i] == 'X') | (ticTacToeButtons[0,i] == 'O' & ticTacToeButtons[1,i] == 'O' & ticTacToeButtons[2,i] == 'O'))
                {
                    return true;

                }

            }
            return false;
        }

        private bool CheckDiagonalOne()
        {
            if ((ticTacToeButtons[0,0] == 'X' & ticTacToeButtons[1,1] == 'X' & ticTacToeButtons[2,2] == 'X') | (ticTacToeButtons[0,0] == 'O' & ticTacToeButtons[1, 1] == 'O' & ticTacToeButtons[2, 2] == 'O'))
            {
                return true;
            }
            return false;
        }

        private bool CheckDiagonaltwo()
        {
            if ((ticTacToeButtons[0,2] == 'X' & ticTacToeButtons[1, 1] == 'X' & ticTacToeButtons[2,0] == 'X') | (ticTacToeButtons[0,2] == 'O' & ticTacToeButtons[1, 1] == 'O' & ticTacToeButtons[2, 0] == 'O'))
            {
                return true;
            }
            return false;
        }

        private bool CheckAll()
        {
            if (CheckRows() | CheckColumbs() | CheckDiagonalOne() | CheckDiagonaltwo() )
            {
                wins[currentTurn % 2]++;
                label2.Text = $"Current score is X:{wins[0]} and Y:{wins[1]} ";
                return true;

            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[0,0]= symbols[currentTurn % 2];
            currentTurn++;
            button1.Enabled = false;

            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[0, 1] = symbols[currentTurn % 2];            
            button2.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[0, 2] = symbols[currentTurn % 2];            
            button3.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[1, 0] = symbols[currentTurn % 2];            
            button4.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[1,1] = symbols[currentTurn % 2];            
            button5.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[1,2] = symbols[currentTurn % 2];            
            button6.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[2, 0] = symbols[currentTurn % 2];            
            button7.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[2, 1] = symbols[currentTurn % 2];            
            button8.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = symbols[currentTurn % 2].ToString();
            ticTacToeButtons[2, 2] = symbols[currentTurn % 2];            
            button9.Enabled = false;
            if (CheckAll())
            {
                MessageBox.Show($"Congragulations, Player  {symbols[currentTurn % 2]} won...");
            }
            currentTurn++;
        }

        private void btnPlyGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            

        }
    }
}
