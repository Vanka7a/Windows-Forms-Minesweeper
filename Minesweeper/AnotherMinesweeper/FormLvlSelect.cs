using System;
using System.Windows.Forms;

namespace AnotherMinesweeper
{
    public partial class FormLvlSelect : Form
    {
        public FormLvlSelect()
        {
            InitializeComponent();
        }

        private void pictureBoxEasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            pictureBoxEasy.Image = Properties.Resources.lvlOne;
            FormMinesweeper levelOne = new FormMinesweeper(10, 9, 9);
            levelOne.Text = "Level One";
            levelOne.Closed += (sender1, ex1) => this.Close();
            levelOne.TextChanged += (sender2, ex2) =>
            {
                FormMinesweeper.ActiveForm.Hide();
                this.Show();
            };
            levelOne.Show();
        }

        private void pictureBoxNormal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMinesweeper levelTwo = new FormMinesweeper(40, 16, 16);
            levelTwo.Text = "Level Two";
            levelTwo.Closed += (sender1, ex1) => this.Close();
            levelTwo.TextChanged += (sender2, ex2) =>
            {
                FormMinesweeper.ActiveForm.Hide();
                this.Show();
            };
            levelTwo.Show();
        }

        private void pictureBoxHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMinesweeper levelThree = new FormMinesweeper(100, 30, 16);
            levelThree.Text = "Level Three";
            levelThree.Closed += (sender1, ex1) => this.Close();
            levelThree.TextChanged += (sender2, ex2) =>
            {
                FormMinesweeper.ActiveForm.Hide();
                this.Show();
            };
            levelThree.Show();
        }

        private void FormLvlSelect_Load(object sender, EventArgs e)
        {
            pictureBoxEasy.Image = Properties.Resources.lvlOne;
            pictureBoxNormal.Image = Properties.Resources.lvlTwo;
            pictureBoxHard.Image = Properties.Resources.lvlThree;
        }
    }
}
