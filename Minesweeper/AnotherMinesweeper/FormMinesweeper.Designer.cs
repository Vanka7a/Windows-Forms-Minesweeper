namespace AnotherMinesweeper
{
    partial class FormMinesweeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuMinesweeper = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBombsCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuGame,
            this.toolStripMenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuGame
            // 
            this.toolStripMenuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuNewGame,
            this.toolStripMenuExit});
            this.toolStripMenuGame.Name = "toolStripMenuGame";
            this.toolStripMenuGame.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuGame.Text = "Game";
            // 
            // toolStripMenuNewGame
            // 
            this.toolStripMenuNewGame.Name = "toolStripMenuNewGame";
            this.toolStripMenuNewGame.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuNewGame.Text = "New Game";
            this.toolStripMenuNewGame.Click += new System.EventHandler(this.toolStripMenuNewGame_Click);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // toolStripMenuAbout
            // 
            this.toolStripMenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuMinesweeper});
            this.toolStripMenuAbout.Name = "toolStripMenuAbout";
            this.toolStripMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuAbout.Text = "About";
            // 
            // toolStripMenuMinesweeper
            // 
            this.toolStripMenuMinesweeper.Name = "toolStripMenuMinesweeper";
            this.toolStripMenuMinesweeper.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuMinesweeper.Text = "Minesweeper";
            this.toolStripMenuMinesweeper.Click += new System.EventHandler(this.toolStripMenuMinesweeper_Click);
            // 
            // labelBombsCount
            // 
            this.labelBombsCount.AutoSize = true;
            this.labelBombsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBombsCount.Location = new System.Drawing.Point(191, 34);
            this.labelBombsCount.Name = "labelBombsCount";
            this.labelBombsCount.Size = new System.Drawing.Size(59, 20);
            this.labelBombsCount.TabIndex = 1;
            this.labelBombsCount.Text = "Mines: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(38, 34);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(101, 20);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time played: ";
            // 
            // FormMinesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 433);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelBombsCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMinesweeper";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.FormMinesweeper_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNewGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMinesweeper;
        private System.Windows.Forms.Label labelBombsCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
    }
}