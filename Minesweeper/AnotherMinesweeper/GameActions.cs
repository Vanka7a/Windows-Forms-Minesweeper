using System;
using System.Linq;
using System.Windows.Forms;

namespace AnotherMinesweeper
{
    class GameActions
    {
        // Game Over
        public void ActivateAllMines(Button[,] board, byte[,] field)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (field[i, j] == 1)
                    {
                        board[i, j].Enabled = false;
                        board[i, j].BackgroundImage = Properties.Resources.mine;
                        board[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }
        // If you find a Zero, clear all surrounding fields
        public void OpenFields(Button clickedButton, Button[,] cleanButton)
        {
            int[] rowCol = clickedButton.Name.ToString().Split(new string[] { "btnR", "C" },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int curRow = rowCol[0];
            int curCol = rowCol[1];
            if(curRow == 0)
            {
                if(curCol == 0)
                {
                    cleanButton[curRow, curCol + 1].PerformClick();
                    cleanButton[curRow + 1, curCol].PerformClick();
                    cleanButton[curRow + 1, curCol + 1].PerformClick();
                }
                else if(curCol == cleanButton.GetLength(1) - 1)
                {
                    cleanButton[curRow, curCol - 1].PerformClick();
                    cleanButton[curRow + 1, curCol].PerformClick();
                    cleanButton[curRow + 1, curCol - 1].PerformClick();
                }
                else
                {
                    cleanButton[curRow, curCol - 1].PerformClick();
                    cleanButton[curRow, curCol + 1].PerformClick();
                    cleanButton[curRow + 1, curCol + 1].PerformClick();
                    cleanButton[curRow + 1, curCol].PerformClick();
                    cleanButton[curRow + 1, curCol -1].PerformClick();
                }
            }
            else if(curRow == cleanButton.GetLength(0) - 1)
            {
                if (curCol == 0)
                {
                    cleanButton[curRow, curCol + 1].PerformClick();
                    cleanButton[curRow - 1, curCol].PerformClick();
                    cleanButton[curRow - 1, curCol + 1].PerformClick();
                }
                else if (curCol == cleanButton.GetLength(1) - 1)
                {
                    cleanButton[curRow, curCol - 1].PerformClick();
                    cleanButton[curRow - 1, curCol].PerformClick();
                    cleanButton[curRow - 1, curCol - 1].PerformClick();
                }
                else
                {
                    cleanButton[curRow, curCol - 1].PerformClick();
                    cleanButton[curRow, curCol + 1].PerformClick();
                    cleanButton[curRow - 1, curCol + 1].PerformClick();
                    cleanButton[curRow - 1, curCol].PerformClick();
                    cleanButton[curRow - 1, curCol - 1].PerformClick();
                }
            }
            else if(curCol == 0)
            {
                cleanButton[curRow - 1, curCol].PerformClick();
                cleanButton[curRow - 1, curCol + 1].PerformClick();
                cleanButton[curRow, curCol + 1].PerformClick();
                cleanButton[curRow + 1, curCol].PerformClick();
                cleanButton[curRow + 1, curCol + 1].PerformClick();
            }
            else if(curCol == cleanButton.GetLength(1) - 1)
            {
                cleanButton[curRow - 1, curCol].PerformClick();
                cleanButton[curRow - 1, curCol - 1].PerformClick();
                cleanButton[curRow, curCol - 1].PerformClick();
                cleanButton[curRow + 1, curCol].PerformClick();
                cleanButton[curRow + 1, curCol - 1].PerformClick();
            }
            else
            {
                cleanButton[curRow - 1, curCol - 1].PerformClick();
                cleanButton[curRow - 1, curCol].PerformClick();
                cleanButton[curRow - 1, curCol + 1].PerformClick();
                cleanButton[curRow, curCol - 1].PerformClick();
                cleanButton[curRow, curCol + 1].PerformClick();
                cleanButton[curRow + 1, curCol - 1].PerformClick();
                cleanButton[curRow + 1, curCol].PerformClick();
                cleanButton[curRow + 1, curCol + 1].PerformClick();
            }
        }
    }
}
