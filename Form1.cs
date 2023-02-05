namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public bool turn = true;
        string playerSymbol = "X";
        string cpuSymbol = "O";
        public int turn_count = 0;
        public bool winner;

        public Form1()
        {
            MessageBox.Show("This is a two player tic tac toe. X starts. Press New game or F2 to reset the board");
            InitializeComponent();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Jonathan Johansson\n2023\nhttps://github.com/gogosimba");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            //Har en gemensam funktion för alla knappar, skapar en knapp av objeketet sender vilket är knappen man trycker på 
            Button b = (Button)sender;
            if (turn)
            {
                turn = false;
                b.Text = playerSymbol;
                checkForWinner();
                
            }
            else
            {
                turn = true;
                b.Text = cpuSymbol;
                checkForWinner();
            }
            b.Enabled = false;
            Console.WriteLine(turn_count);
            turn_count++;

        }

        public void checkForWinner()
        {
            bool winner = false;
            //Buttons are renamed to A1-C3 for easier visualsation of a grid
            //Checking to see if a player won by checking if the button text is the same

            //Horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }

            //Vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }


            //Diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                winner = true;
            }


            if (winner)
            {
                disableButtons();
                if (turn)
                {
                    MessageBox.Show("O Wins!");
                }
                else
                {
                    MessageBox.Show("X Wins!");
                }
            }
            else
            {
                //If there's no more moves left it's a draw
                if (turn_count == 9)
                {
                    MessageBox.Show("It's a draw!");
                }
            }
            
        }

      
        private void disableButtons()
        {
            /*Loops through all our visible components and disable the buttons so the player can't keep playing 
            after someone wins.*/

            foreach (Control c in Controls)
            {
                //Try catch statement since we have other controls than buttons, if the loop encounters a non button it cant convert it into a button and moves on
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }

            }


        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Resets variables and buttons
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            {

            }
        }


        public void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }

    }
}