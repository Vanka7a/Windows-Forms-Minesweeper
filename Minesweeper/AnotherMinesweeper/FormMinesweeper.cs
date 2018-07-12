using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace AnotherMinesweeper
{
    public partial class FormMinesweeper : Form
    {
        // Call the other two programs 
        GameActions game = new GameActions();
        Mines mines = new Mines();
        // Get the number of mines and number of buttons from FormLvlSelect
        public byte numMines;
        private byte numRows;
        private byte numCols;
        private int clicks;
        private short count;
        private int timePlayed;
        public FormMinesweeper(byte mines, byte rows, byte cols)
        {
            InitializeComponent();
            numMines = mines;
            numRows = rows;
            numCols = cols;
            count = mines;
        }
        private void FormMinesweeper_Load(object sender, EventArgs e)
        {
            // board size
            Size = new Size(numRows * 25 + 55, numCols * 25 + 120);
            mines.GenerateMines(numMines, numRows, numCols);
            Button[,] fields = new Button[numRows, numCols];
            int x = 25;
            int y = 40;
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    // set buttons properties
                    Button button = new Button();
                    button.Name = string.Format("btnR{0}C{1}", i, j);
                    button.Size = new Size(25, 25);
                    button.Text = "";
                    button.Location = new Point(x + (25 * i), y + 25 + (25 * j));
                    button.Click += (sender1, ex) =>
                    {
                        ButtonClickEvent(button, fields);
                    };
                    button.MouseDown += (sender2, ex2) =>
                    {
                        if(ex2.Button == MouseButtons.Right && button.Text == "")
                        {
                            button.BackgroundImage = Properties.Resources.redflag;
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.Text = "*";
                            count--;
                            labelBombsCount.Text = string.Format("Mines: {0}", count);
                        }
                        else if(ex2.Button == MouseButtons.Right && button.Text == "*")
                        {
                            button.BackgroundImage = Properties.Resources.nothing;
                            button.Text = "";
                            count++;
                            labelBombsCount.Text = string.Format("Mines: {0}", count);
                        }
                    };
                    fields[i, j] = button;
                    Controls.Add(button);
                }
            }
            labelBombsCount.Text = string.Format("Mines: {0}", count);
        }
        private void ButtonClickEvent(Button button, Button[,] fields)
        {
            if(button.Text == "*")
            {
                return;
            }
            mines.minesAroundCounter(button, fields);
            if(button.Text == "0")
            {
                game.OpenFields(button, fields);
            }
            clicks++;
            if(clicks > (numRows * numCols - numMines * 2))
            {
                mines.winner(fields);
                //StreamWriter score = File.CreateText("highscores.txt");
                //score.WriteLine(labelTime.Text);
            }
        }
        private void toolStripMenuNewGame_Click(object sender, EventArgs e)
        {
            this.Text = "New Game";
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuMinesweeper_Click(object sender, EventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Minesweeper_(video_game)");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timePlayed++;
            labelTime.Text = string.Format("Time played: {0}s", timePlayed);
        }
    }
}
