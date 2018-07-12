using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

namespace AnotherMinesweeper
{
    class Mines
    {
        // get the generated bomb matrix here
        private byte[,] anotherMatrix;
        private GameActions action = new GameActions();
        // pretty self-explanatory
        public void GenerateMines(byte mines, byte rows, byte cols)
        {
            byte[,] matrix = new byte[rows, cols];
            Random generateMine = new Random();
            while(mines>0)
            {
                for (int row = 1; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                    {
                        if(matrix[row, col] != 1 && generateMine.Next(0,8) == 1)
                        {
                            mines--;
                            matrix[row, col] = 1;
                            if(mines == 0)
                            {
                                break;
                            }
                        }
                    }
                    if(mines == 0)
                    {
                        break;
                    }
                }
            }
            anotherMatrix = matrix;
        }
        public void minesAroundCounter(Button clickedButton, Button[,] surroundingButtons)
        {
            byte[] rowCol = clickedButton.Name.ToString().Split(new string[] { "btnR", "C" },
                StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();
            byte curRow = rowCol[0];
            byte curCol = rowCol[1];
            byte minesAround = 0;
            if(curRow < 0 || curRow >= anotherMatrix.GetLength(0) || curCol<0 || curCol >= anotherMatrix.GetLength(1))
            {
                return;
            }
            if(anotherMatrix[curRow,curCol] == 1)
            {
                action.ActivateAllMines(surroundingButtons, anotherMatrix);
                DialogResult endgame = MessageBox.Show("You died! Try again?", "BOOM", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(endgame == DialogResult.Yes)
                {
                    FormMinesweeper.ActiveForm.Text = "New Game";
                }
                else if(endgame == DialogResult.No)
                {
                    FormMinesweeper.ActiveForm.Close();
                }
                return;
            }
            if(curRow - 1 >=0 && curCol - 1 >=0)
            {
                if(anotherMatrix[curRow - 1, curCol - 1] == 1)
                {
                    minesAround++; //1
                }
            }
            if(curRow - 1 >=0)
            {
                if(anotherMatrix[curRow - 1, curCol] == 1)
                {
                    minesAround++; //2
                }
            }
            if(curRow - 1 >=0 && curCol + 1 < anotherMatrix.GetLength(1))
            {
                if(anotherMatrix[curRow - 1, curCol + 1] == 1)
                {
                    minesAround++; //3
                }
            }
            if(curCol - 1 >= 0)
            {
                if(anotherMatrix[curRow, curCol-1] == 1)
                {
                    minesAround++; //4
                }
            }
            if(curCol + 1 < anotherMatrix.GetLength(1))
            {
                if(anotherMatrix[curRow, curCol+1] == 1)
                {
                    minesAround++; //6
                }
            }
            if(curRow + 1 < anotherMatrix.GetLength(0) && curCol - 1 >= 0)
            {
                if(anotherMatrix[curRow + 1,curCol - 1] == 1)
                {
                    minesAround++; //7
                }
            }
            if(curRow + 1 < anotherMatrix.GetLength(0))
            {
                if(anotherMatrix[curRow+1,curCol] == 1)
                {
                    minesAround++; //8
                }
            }
            if(curRow + 1 < anotherMatrix.GetLength(0) && curCol + 1 < anotherMatrix.GetLength(1))
            {
                if(anotherMatrix[curRow + 1,curCol + 1] == 1)
                {
                    minesAround++; //9
                }
            }
            clickedButton.Text = minesAround.ToString();
            clickedButton.Enabled = false;
            clickedButton.BackColor = Color.LightGray;
        }
        public void winner(Button[,] tempMatrix)
        {
            bool bombsLeft = false;
            for (int row = 0; row < tempMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < tempMatrix.GetLength(1); col++)
                {
                    if(tempMatrix[row,col].Enabled == true)
                    {
                        if(anotherMatrix[row,col] == 0)
                        {
                            bombsLeft = true;
                        }
                    }
                }
            }
            if(bombsLeft == false)
            {
                MessageBox.Show("Winner!");
                FormMinesweeper.ActiveForm.Close();
            }
        }
    }
}
