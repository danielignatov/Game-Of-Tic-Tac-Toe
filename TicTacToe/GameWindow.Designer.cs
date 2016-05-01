namespace TicTacToe
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.R1C1 = new System.Windows.Forms.Button();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R3C3 = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.winCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.winCountShow = new System.Windows.Forms.ToolStripStatusLabel();
            this.drawCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.drawCountShow = new System.Windows.Forms.ToolStripStatusLabel();
            this.loseCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loseCountShow = new System.Windows.Forms.ToolStripStatusLabel();
            this.soundLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.soundButton = new System.Windows.Forms.ToolStripStatusLabel();
            this.musicLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.musicButton = new System.Windows.Forms.ToolStripStatusLabel();
            this.introBox = new System.Windows.Forms.PictureBox();
            this.introTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.introBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(500, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.howToPlayToolStripMenuItem.Text = "How To Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // R1C1
            // 
            this.R1C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R1C1.Location = new System.Drawing.Point(90, 35);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(100, 100);
            this.R1C1.TabIndex = 1;
            this.R1C1.UseVisualStyleBackColor = true;
            this.R1C1.Click += new System.EventHandler(this.buttonClick);
            this.R1C1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R1C1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R1C2
            // 
            this.R1C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R1C2.Location = new System.Drawing.Point(200, 35);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(100, 100);
            this.R1C2.TabIndex = 2;
            this.R1C2.UseVisualStyleBackColor = true;
            this.R1C2.Click += new System.EventHandler(this.buttonClick);
            this.R1C2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R1C2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R2C2
            // 
            this.R2C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R2C2.Location = new System.Drawing.Point(200, 145);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(100, 100);
            this.R2C2.TabIndex = 3;
            this.R2C2.UseVisualStyleBackColor = true;
            this.R2C2.Click += new System.EventHandler(this.buttonClick);
            this.R2C2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R2C2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R1C3
            // 
            this.R1C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R1C3.Location = new System.Drawing.Point(310, 35);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(100, 100);
            this.R1C3.TabIndex = 4;
            this.R1C3.UseVisualStyleBackColor = true;
            this.R1C3.Click += new System.EventHandler(this.buttonClick);
            this.R1C3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R1C3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R2C1
            // 
            this.R2C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R2C1.Location = new System.Drawing.Point(90, 145);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(100, 100);
            this.R2C1.TabIndex = 5;
            this.R2C1.UseVisualStyleBackColor = true;
            this.R2C1.Click += new System.EventHandler(this.buttonClick);
            this.R2C1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R2C1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R2C3
            // 
            this.R2C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R2C3.Location = new System.Drawing.Point(310, 145);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(100, 100);
            this.R2C3.TabIndex = 6;
            this.R2C3.UseVisualStyleBackColor = true;
            this.R2C3.Click += new System.EventHandler(this.buttonClick);
            this.R2C3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R2C3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R3C2
            // 
            this.R3C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R3C2.Location = new System.Drawing.Point(200, 255);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(100, 100);
            this.R3C2.TabIndex = 7;
            this.R3C2.UseVisualStyleBackColor = true;
            this.R3C2.Click += new System.EventHandler(this.buttonClick);
            this.R3C2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R3C2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R3C1
            // 
            this.R3C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R3C1.Location = new System.Drawing.Point(90, 255);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(100, 100);
            this.R3C1.TabIndex = 8;
            this.R3C1.UseVisualStyleBackColor = true;
            this.R3C1.Click += new System.EventHandler(this.buttonClick);
            this.R3C1.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R3C1.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // R3C3
            // 
            this.R3C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R3C3.Location = new System.Drawing.Point(310, 255);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(100, 100);
            this.R3C3.TabIndex = 9;
            this.R3C3.UseVisualStyleBackColor = true;
            this.R3C3.Click += new System.EventHandler(this.buttonClick);
            this.R3C3.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.R3C3.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winCountLabel,
            this.winCountShow,
            this.drawCountLabel,
            this.drawCountShow,
            this.loseCountLabel,
            this.loseCountShow,
            this.soundLable,
            this.soundButton,
            this.musicLabel,
            this.musicButton});
            this.statusStrip.Location = new System.Drawing.Point(0, 361);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(500, 25);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // winCountLabel
            // 
            this.winCountLabel.Name = "winCountLabel";
            this.winCountLabel.Size = new System.Drawing.Size(44, 20);
            this.winCountLabel.Text = "Wins:";
            // 
            // winCountShow
            // 
            this.winCountShow.Name = "winCountShow";
            this.winCountShow.Size = new System.Drawing.Size(17, 20);
            this.winCountShow.Text = "0";
            // 
            // drawCountLabel
            // 
            this.drawCountLabel.Name = "drawCountLabel";
            this.drawCountLabel.Size = new System.Drawing.Size(53, 20);
            this.drawCountLabel.Text = "Draws:";
            // 
            // drawCountShow
            // 
            this.drawCountShow.Name = "drawCountShow";
            this.drawCountShow.Size = new System.Drawing.Size(17, 20);
            this.drawCountShow.Text = "0";
            // 
            // loseCountLabel
            // 
            this.loseCountLabel.Name = "loseCountLabel";
            this.loseCountLabel.Size = new System.Drawing.Size(48, 20);
            this.loseCountLabel.Text = "Loses:";
            // 
            // loseCountShow
            // 
            this.loseCountShow.Name = "loseCountShow";
            this.loseCountShow.Size = new System.Drawing.Size(17, 20);
            this.loseCountShow.Text = "0";
            // 
            // soundLable
            // 
            this.soundLable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.soundLable.Name = "soundLable";
            this.soundLable.Size = new System.Drawing.Size(60, 20);
            this.soundLable.Text = "Sounds:";
            // 
            // soundButton
            // 
            this.soundButton.ForeColor = System.Drawing.Color.Green;
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(28, 20);
            this.soundButton.Text = "On";
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            // 
            // musicLabel
            // 
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // musicButton
            // 
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(0, 20);
            // 
            // introBox
            // 
            this.introBox.Image = global::TicTacToe.Properties.Resources.intro2;
            this.introBox.Location = new System.Drawing.Point(0, 35);
            this.introBox.Name = "introBox";
            this.introBox.Size = new System.Drawing.Size(500, 320);
            this.introBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.introBox.TabIndex = 11;
            this.introBox.TabStop = false;
            // 
            // introTimer
            // 
            this.introTimer.Enabled = true;
            this.introTimer.Interval = 5000;
            this.introTimer.Tick += new System.EventHandler(this.introTimer_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 386);
            this.Controls.Add(this.introBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.R1C1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Of Tic Tac Toe";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.introBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button R1C1;
        private System.Windows.Forms.Button R1C2;
        private System.Windows.Forms.Button R2C2;
        private System.Windows.Forms.Button R1C3;
        private System.Windows.Forms.Button R2C1;
        private System.Windows.Forms.Button R2C3;
        private System.Windows.Forms.Button R3C2;
        private System.Windows.Forms.Button R3C1;
        private System.Windows.Forms.Button R3C3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel winCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel winCountShow;
        private System.Windows.Forms.ToolStripStatusLabel drawCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel drawCountShow;
        private System.Windows.Forms.ToolStripStatusLabel loseCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel loseCountShow;
        private System.Windows.Forms.ToolStripStatusLabel soundLable;
        private System.Windows.Forms.ToolStripStatusLabel soundButton;
        private System.Windows.Forms.ToolStripStatusLabel musicLabel;
        private System.Windows.Forms.ToolStripStatusLabel musicButton;
        private System.Windows.Forms.PictureBox introBox;
        private System.Windows.Forms.Timer introTimer;
    }
}