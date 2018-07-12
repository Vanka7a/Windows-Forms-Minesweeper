namespace AnotherMinesweeper
{
    partial class FormLvlSelect
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
            this.labelSelectDifficulty = new System.Windows.Forms.Label();
            this.pictureBoxEasy = new System.Windows.Forms.PictureBox();
            this.labelEasy = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.labelHard = new System.Windows.Forms.Label();
            this.pictureBoxHard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHard)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectDifficulty
            // 
            this.labelSelectDifficulty.AutoSize = true;
            this.labelSelectDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectDifficulty.Location = new System.Drawing.Point(58, 9);
            this.labelSelectDifficulty.Name = "labelSelectDifficulty";
            this.labelSelectDifficulty.Size = new System.Drawing.Size(138, 22);
            this.labelSelectDifficulty.TabIndex = 0;
            this.labelSelectDifficulty.Text = "Select Difficulty:";
            // 
            // pictureBoxEasy
            // 
            this.pictureBoxEasy.Location = new System.Drawing.Point(25, 57);
            this.pictureBoxEasy.Name = "pictureBoxEasy";
            this.pictureBoxEasy.Size = new System.Drawing.Size(83, 75);
            this.pictureBoxEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEasy.TabIndex = 1;
            this.pictureBoxEasy.TabStop = false;
            this.pictureBoxEasy.Click += new System.EventHandler(this.pictureBoxEasy_Click);
            // 
            // labelEasy
            // 
            this.labelEasy.AutoSize = true;
            this.labelEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEasy.Location = new System.Drawing.Point(153, 82);
            this.labelEasy.Name = "labelEasy";
            this.labelEasy.Size = new System.Drawing.Size(52, 17);
            this.labelEasy.TabIndex = 2;
            this.labelEasy.Text = "-  Easy";
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormal.Location = new System.Drawing.Point(153, 173);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(66, 17);
            this.labelNormal.TabIndex = 4;
            this.labelNormal.Text = "-  Normal";
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Location = new System.Drawing.Point(25, 149);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(83, 75);
            this.pictureBoxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNormal.TabIndex = 3;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Click += new System.EventHandler(this.pictureBoxNormal_Click);
            // 
            // labelHard
            // 
            this.labelHard.AutoSize = true;
            this.labelHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHard.Location = new System.Drawing.Point(153, 266);
            this.labelHard.Name = "labelHard";
            this.labelHard.Size = new System.Drawing.Size(52, 17);
            this.labelHard.TabIndex = 6;
            this.labelHard.Text = "-  Hard";
            // 
            // pictureBoxHard
            // 
            this.pictureBoxHard.Location = new System.Drawing.Point(25, 240);
            this.pictureBoxHard.Name = "pictureBoxHard";
            this.pictureBoxHard.Size = new System.Drawing.Size(83, 75);
            this.pictureBoxHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHard.TabIndex = 5;
            this.pictureBoxHard.TabStop = false;
            this.pictureBoxHard.Click += new System.EventHandler(this.pictureBoxHard_Click);
            // 
            // FormLvlSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AnotherMinesweeper.Properties.Resources.cool_background;
            this.ClientSize = new System.Drawing.Size(253, 340);
            this.Controls.Add(this.labelHard);
            this.Controls.Add(this.pictureBoxHard);
            this.Controls.Add(this.labelNormal);
            this.Controls.Add(this.pictureBoxNormal);
            this.Controls.Add(this.labelEasy);
            this.Controls.Add(this.pictureBoxEasy);
            this.Controls.Add(this.labelSelectDifficulty);
            this.Name = "FormLvlSelect";
            this.Text = "FormLvlSelect";
            this.Load += new System.EventHandler(this.FormLvlSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectDifficulty;
        private System.Windows.Forms.PictureBox pictureBoxEasy;
        private System.Windows.Forms.Label labelEasy;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Label labelHard;
        private System.Windows.Forms.PictureBox pictureBoxHard;
    }
}

