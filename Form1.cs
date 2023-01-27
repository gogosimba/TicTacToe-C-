namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; 
        string playerSymbol = "X";
        string cpuSymbol = "O";
        public Form1()
        {
            InitializeComponent();
        }

        public void NewGame()
        {
            MessageBox.Show("New Game works");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Jonathan Johansson\n2023\nhttps://github.com/gogosimba");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                turn = false;
                b.ForeColor = Color.Green;
                b.Text = playerSymbol;
            }
            else
            {
                turn = true;
                b.ForeColor = Color.Red;
                b.Text = cpuSymbol;
            }
               
        }
    }
}