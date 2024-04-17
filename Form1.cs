namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeMatrix();
        }

        int player = 1;
        int moves = 0;
        int[,] matrix = new int[3, 3];
        bool gameOver = false;

        private void initializeMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        private void select(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;
            PictureBox place = new PictureBox();
            int row = -1, col = -1;
            if (gameOver == false)
            {
                switch (selectedLabel.Top)
                {
                    case 9:
                        row = 0;
                        break;
                    case 136:
                        row = 1;
                        break;
                    case 263:
                        row = 2;
                        break;
                    default:
                        break;
                }
                switch (selectedLabel.Left)
                {
                    case 13:
                        col = 0;
                        break;
                    case 140:
                        col = 1;
                        break;
                    case 267:
                        col = 2;
                        break;
                    default:
                        break;
                }
                if (selectedLabel.Text == "")
                {
                    if (player % 2 == 0)
                    {
                        selectedLabel.Text = "X";
                        matrix[row, col] = 1;
                    }
                    else
                    {
                        selectedLabel.Text = "0";
                        matrix[row, col] = 2;
                    }
                }
                player++;
                moves++;
                if (moves == 9)
                {
                    winner.Text = "DRAW";
                    end();
                }
            }
        }

        private void checkRows()
        {
            for (int i = 0; i < 3; i++)
            {
                if (matrix[i, 0] != 0)
                {
                    if (matrix[i, 0] == matrix[i, 1] && matrix[i, 0] == matrix[i, 2])
                    {
                        if (matrix[i, 0] == 2)
                        {
                            winner.Text = "0 is the winner";
                            end();
                        }
                        if (matrix[i, 0] == 1)
                        {
                            winner.Text = "X is the winner";
                            end();
                        }
                    }
                }
            }
        }

        private void checkCol()
        {
            for (int i = 0; i < 3; i++)
            {
                if (matrix[0, i] != 0)
                {
                    if (matrix[0, i] == matrix[1, i] && matrix[0, i] == matrix[2, i])
                    {
                        if (matrix[0, i] == 2)
                        {
                            winner.Text = "0 is the winner";
                            end();
                        }
                        if (matrix[0, i] == 1)
                        {
                            winner.Text = "X is the winner";
                            end();
                        }
                    }
                }
            }
        }
        private void checkDiag()
        {
            if (matrix[0, 0] != 0)
            {
                if (matrix[0, 0] == matrix[1, 1] && matrix[0, 0] == matrix[2, 2])
                {
                    if (matrix[0, 0] == 2)
                    {
                        winner.Text = "0 is the winner";
                        end();
                    }
                    if (matrix[0, 0] == 1)
                    {
                        winner.Text = "X is the winner";
                        end();
                    }
                }
            }
            if (matrix[2, 0] != 0)
            {
                if (matrix[0, 2] == matrix[1, 1] && matrix[0, 2] == matrix[2, 0])
                {
                    if (matrix[2, 0] == 2)
                    {
                        winner.Text = "0 is the winner";
                        end();
                    }
                    if (matrix[2, 0] == 1)
                    {
                        winner.Text = "X is the winner";
                        end();
                    }
                }
            }
        }
        private void check(object sender, EventArgs e)
        {
            checkRows();
            checkCol();
            checkDiag();
        }

        private void end()
        {
            gameOver = true;
            timer1.Stop();
        }

        private void restart(object sender, EventArgs e)
        {
            initializeMatrix();
            foreach (Control i in this.Controls)
            {
                if (i is Label)
                {
                    ((Label)i).Text = "";
                }
            }
            timer1.Start();
            gameOver = false;
            moves = 0;
            player = 0;
        }
    }
}