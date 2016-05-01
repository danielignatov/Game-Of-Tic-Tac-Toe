namespace TicTacToe
{
    using System;
    using System.Media;
    using System.Threading;
    using System.Windows.Forms;

    public partial class GameWindow : Form
    {
        // turnSwitch
        // True = Player Turn
        // False = AI Turn
        private bool turnSwitch = true;
        private bool enableSound = true;
        private byte turnCount = 0;
        private byte gameCount = 1;
        private byte playerWinCount = 0;
        private byte playerDrawCount = 0;
        private byte playerLoseCount = 0;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void artificialIntelligenceDoMove()
        {
            Button computerMove = null;

            if (turnCount == 0)
            {
                computerMove = artificialIntelligenceMakeFirstMove();
            }

            if (turnCount == 1)
            {
                computerMove = artificialIntelligenceMakeSecondMove();
            }

            if (computerMove == null)
            {
                computerMove = artificialIntelligenceCheckToWin();
            }

            if (computerMove == null)
            {
                computerMove = artificialIntelligenceCheckToDefend();
            }

            if (computerMove == null)
            {
                computerMove = artificialIntelligenceMakeMove();
            }

            computerMove.PerformClick();
        }

        private Button artificialIntelligenceMakeFirstMove()
        {
            Random randomFirstMove = new Random();
            int position = randomFirstMove.Next(1, 6);

            switch (position)
            {
                case 1: return R1C1;
                case 2: return R1C3;
                case 3: return R2C2;
                case 4: return R3C1;
                case 5: return R3C3;
                default: return R2C2;
            }
        }

        private Button artificialIntelligenceMakeSecondMove()
        {
            if (R1C1.Text == "X" && R2C2.Enabled == true)
            {
                return R2C2;
            }
            else if (R1C3.Text == "X" && R2C2.Enabled == true)
            {
                return R2C2;
            }
            else if (R3C1.Text == "X" && R2C2.Enabled == true)
            {
                return R2C2;
            }
            else if (R3C3.Text == "X" && R2C2.Enabled == true)
            {
                return R2C2;
            }
            else if (R2C2.Text == "X" && R3C3.Enabled == true)
            {
                return R3C3;
            }
            else if (R2C2.Text == "X" && R1C3.Enabled == true)
            {
                return R1C3;
            }
            else if (R2C2.Text == "X" && R1C1.Enabled == true)
            {
                return R1C1;
            }
            else if (R2C2.Text == "X" && R3C1.Enabled == true)
            {
                return R3C1;
            }
            // Enemy check
            else if (R1C1.Text == "O" && R1C3.Enabled == true)
            {
                return R1C3;
            }
            else if (R1C3.Text == "O" && R1C1.Enabled == true)
            {
                return R1C1;
            }
            else if (R3C1.Text == "O" && R3C3.Enabled == true)
            {
                return R3C3;
            }
            else if (R3C3.Text == "O" && R3C1.Enabled == true)
            {
                return R3C1;
            }
            else if (R2C2.Text == "O" && R3C3.Enabled == true)
            {
                return R3C3;
            }
            else if (R2C2.Text == "O" && R1C3.Enabled == true)
            {
                return R1C3;
            }
            else if (R2C2.Text == "O" && R1C1.Enabled == true)
            {
                return R1C1;
            }
            else if (R2C2.Text == "O" && R3C1.Enabled == true)
            {
                return R3C1;
            }
            // Failsafe
            else if (R2C2.Enabled == true)
            {
                return R1C1;
            }
            else if (R1C2.Enabled == true)
            {
                return R1C2;
            }
            else if (R1C3.Enabled == true)
            {
                return R1C3;
            }
            else if (R2C1.Enabled == true)
            {
                return R2C1;
            }
            else if (R1C1.Enabled == true)
            {
                return R1C1;
            }
            else if (R2C3.Enabled == true)
            {
                return R2C3;
            }
            else if (R3C1.Enabled == true)
            {
                return R3C1;
            }
            else if (R3C2.Enabled == true)
            {
                return R3C2;
            }
            else
            {
                return R3C3;
            }
        }

        private Button artificialIntelligenceCheckToWin()
        {
            // First row 
            if ((R1C1.Text == "X") && (R1C2.Text == "X") && (R1C3.Enabled == true))
            {
                return R1C3;
            }
            else if ((R1C1.Text == "X") && (R1C3.Text == "X") && (R1C2.Enabled == true))
            {
                return R1C2;
            }
            else if ((R1C2.Text == "X") && (R1C3.Text == "X") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            // Second row
            else if ((R2C1.Text == "X") && (R2C2.Text == "X") && (R2C3.Enabled == true))
            {
                return R2C3;
            }
            else if ((R2C1.Text == "X") && (R2C3.Text == "X") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "X") && (R2C3.Text == "X") && (R2C1.Enabled == true))
            {
                return R2C1;
            }
            // Third row
            else if ((R3C1.Text == "X") && (R3C2.Text == "X") && (R3C3.Enabled == true))
            {
                return R3C3;
            }
            else if ((R3C1.Text == "X") && (R3C3.Text == "X") && (R3C2.Enabled == true))
            {
                return R3C2;
            }
            else if ((R3C2.Text == "X") && (R3C3.Text == "X") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            // First column
            else if ((R1C1.Text == "X") && (R2C1.Text == "X") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            else if ((R1C1.Text == "X") && (R3C1.Text == "X") && (R2C1.Enabled == true))
            {
                return R2C1;
            }
            else if ((R2C1.Text == "X") && (R3C1.Text == "X") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            // Second column
            else if ((R1C2.Text == "X") && (R2C2.Text == "X") && (R3C2.Enabled == true))
            {
                return R3C2;
            }
            else if ((R1C2.Text == "X") && (R3C2.Text == "X") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "X") && (R3C2.Text == "X") && (R1C2.Enabled == true))
            {
                return R1C2;
            }
            // Third column
            else if ((R1C3.Text == "X") && (R2C3.Text == "X") && (R3C3.Enabled == true))
            {
                return R3C3;
            }
            else if ((R1C3.Text == "X") && (R3C3.Text == "X") && (R2C3.Enabled == true))
            {
                return R2C3;
            }
            else if ((R2C3.Text == "X") && (R3C3.Text == "X") && (R1C3.Enabled == true))
            {
                return R1C3;
            }
            // Left top to lower right
            else if ((R1C1.Text == "X") && (R2C2.Text == "X") && (R3C3.Enabled == true))
            {
                return R3C3;
            }
            else if ((R1C1.Text == "X") && (R3C3.Text == "X") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "X") && (R3C3.Text == "X") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            // Right top to lower left
            else if ((R1C3.Text == "X") && (R2C2.Text == "X") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            else if ((R1C3.Text == "X") && (R3C1.Text == "X") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "X") && (R3C1.Text == "X") && (R1C3.Enabled == true))
            {
                return R1C3;
            }
            // If no threat is found
            else
            {
                return null;
            }
        }

        private Button artificialIntelligenceCheckToDefend()
        {
            if ((R1C1.Text == "O") && (R1C2.Text == "O") && (R1C3.Enabled == true))
            {
                return R1C3;
            }
            else if ((R1C1.Text == "O") && (R1C3.Text == "O") && (R1C2.Enabled == true))
            {
                return R1C2;
            }
            else if ((R1C2.Text == "O") && (R1C3.Text == "O") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            else if ((R2C1.Text == "O") && (R2C2.Text == "O") && (R2C3.Enabled == true))
            {
                return R2C3;
            }
            else if ((R2C1.Text == "O") && (R2C3.Text == "O") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "O") && (R2C3.Text == "O") && (R2C1.Enabled == true))
            {
                return R2C1;
            }
            else if ((R3C1.Text == "O") && (R3C2.Text == "O") && (R3C3.Enabled == true))
            {
                return R3C3;
            }
            else if ((R3C1.Text == "O") && (R3C3.Text == "O") && (R3C2.Enabled == true))
            {
                return R3C2;
            }
            else if ((R3C2.Text == "O") && (R3C3.Text == "O") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            // First column
            else if ((R1C1.Text == "O") && (R2C1.Text == "O") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            else if ((R1C1.Text == "O") && (R3C1.Text == "O") && (R2C1.Enabled == true))
            {
                return R2C1;
            }
            else if ((R2C1.Text == "O") && (R3C1.Text == "O") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            // Second column
            else if ((R1C2.Text == "O") && (R2C2.Text == "O") && (R3C2.Enabled == true))
            {
                return R3C2;
            }
            else if ((R1C2.Text == "O") && (R3C2.Text == "O") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "O") && (R3C2.Text == "O") && (R1C2.Enabled == true))
            {
                return R1C2;
            }
            // Third column
            else if ((R1C3.Text == "O") && (R2C3.Text == "O") && (R3C3.Enabled == true))
            {
                return R3C3;
            }
            else if ((R1C3.Text == "O") && (R3C3.Text == "O") && (R2C3.Enabled == true))
            {
                return R2C3;
            }
            else if ((R2C3.Text == "O") && (R3C3.Text == "O") && (R1C3.Enabled == true))
            {
                return R1C3;
            }
            // Top left to bottom right
            else if ((R1C1.Text == "O") && (R2C2.Text == "O") && (R3C3.Enabled == true))
            {
                return R3C3;
            }
            else if ((R1C1.Text == "O") && (R3C3.Text == "O") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "O") && (R3C3.Text == "O") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            // Top right to bottom left
            else if ((R1C3.Text == "O") && (R2C2.Text == "O") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            else if ((R1C3.Text == "O") && (R3C1.Text == "O") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R2C2.Text == "O") && (R3C1.Text == "O") && (R1C3.Enabled == true))
            {
                return R1C3;
            }
            else
            {
                return null;
            }
        }

        private Button artificialIntelligenceMakeMove()
        {
            if ((R2C2.Text == "O") && (R2C1.Enabled == true))
            {
                return R2C1;
            }
            else if ((R1C1.Text == "O") && (R2C2.Enabled == true))
            {
                return R2C2;
            }
            else if ((R1C2.Text == "O") && (R1C3.Enabled == true))
            {
                return R1C3;
            }
            else if ((R1C3.Text == "O") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            else if ((R2C1.Text == "O") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            else if ((R2C2.Text == "O") && (R2C3.Enabled == true))
            {
                return R2C3;
            }
            else if ((R2C3.Text == "O") && (R3C3.Enabled == true))
            {
                return R3C3;
            }
            else if ((R3C1.Text == "O") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            else if ((R3C2.Text == "O") && (R1C1.Enabled == true))
            {
                return R1C1;
            }
            else if ((R3C3.Text == "O") && (R3C1.Enabled == true))
            {
                return R3C1;
            }
            else if (R2C2.Enabled == true)
            {
                return R2C2;
            }
            else if (R1C2.Enabled == true)
            {
                return R1C2;
            }
            else if (R1C3.Enabled == true)
            {
                return R1C3;
            }
            else if (R2C1.Enabled == true)
            {
                return R2C1;
            }
            else if (R1C1.Enabled == true)
            {
                return R1C1;
            }
            else if (R2C3.Enabled == true)
            {
                return R2C3;
            }
            else if (R3C1.Enabled == true)
            {
                return R3C1;
            }
            else if (R3C2.Enabled == true)
            {
                return R3C2;
            }
            else
            {
                return R3C3;
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage = String.Format("Created by: Daniel Ignatov{0}Website: danielignatov.com{0}{0}Based on: Chris Merritt \"Winform Tic Tac Toe Tutorial\"{0}Source: youtube.com/watch?v=p3gYVcggQOU{0}{0}Sword Sound: Yap Audio Production{0}Source: freesound.org/people/Yap_Audio_Production/sounds/219003/{0}{0}Intro Background: Daniel Turuntsev{0}Source: youtube.com/watch?v=xYc8we0yRdE{0}{0}Intro Font: Font Meme{0}Source: fontmeme.com{0}{0}Icon: PixelMixer{0}Source: pixel-mixer.com", Environment.NewLine);

            MessageBox.Show(aboutMessage, "About");
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button) sender;

            if (turnSwitch == true)
            {
                Random twistOfFate = new Random();
                int twist = twistOfFate.Next(1, 6);

                switch (twist)
                {
                    case 1:
                        if (turnCount != 8)
                        {
                            if (enableSound == true)
                            {
                                playTwistOfFateSound();
                            }
                        }
                        button = artificialIntelligenceMakeMove();
                        button.Text = "O"; break;
                    default:
                        button.Text = "O"; break;
                }                
            }
            else
            {
                button.Text = "X";
            }
            
            button.Enabled = false;
            turnSwitch = !turnSwitch;
            turnCount += 1;
            checkForWinner();

            if (turnSwitch == false)
            {
                Thread.Sleep(150);
                artificialIntelligenceDoMove();
            }
        }

        private void checkForWinner()
        {
            bool winner = false;

            if ((R1C1.Text == R1C2.Text) && (R1C2.Text == R1C3.Text) && (!R1C1.Enabled && !R1C2.Enabled && !R1C3.Enabled))
            {
                winner = true;
            }
            else if ((R2C1.Text == R2C2.Text) && (R2C2.Text == R2C3.Text) && (!R2C1.Enabled && !R2C2.Enabled && !R2C3.Enabled))
            {
                winner = true;
            }
            else if ((R3C1.Text == R3C2.Text) && (R3C2.Text == R3C3.Text) && (!R3C1.Enabled && !R3C2.Enabled && !R3C3.Enabled))
            {
                winner = true;
            }
            else if ((R1C1.Text == R2C1.Text) && (R2C1.Text == R3C1.Text) && (!R1C1.Enabled && !R2C1.Enabled && !R3C1.Enabled))
            {
                winner = true;
            }
            else if ((R1C2.Text == R2C2.Text) && (R2C2.Text == R3C2.Text) && (!R1C2.Enabled && !R2C2.Enabled && !R3C2.Enabled))
            {
                winner = true;
            }
            else if ((R1C3.Text == R2C3.Text) && (R2C3.Text == R3C3.Text) && (!R1C3.Enabled && !R2C3.Enabled && !R3C3.Enabled))
            {
                winner = true;
            }
            else if ((R1C1.Text == R2C2.Text) && (R2C2.Text == R3C3.Text) && (!R1C1.Enabled && !R2C2.Enabled && !R3C3.Enabled))
            {
                winner = true;
            }
            else if ((R1C3.Text == R2C2.Text) && (R2C2.Text == R3C1.Text) && (!R1C3.Enabled && !R2C2.Enabled && !R3C1.Enabled))
            {
                winner = true;
            }

            if (winner == true)
            {
                String winText = String.Empty;

                if (turnSwitch == false)
                {
                    playerWinCount += 1;
                    winCountShow.Text = playerWinCount.ToString();
                    MessageBox.Show("Good job! " + (10 - gameCount) + " games to go.", "Winner!");
                }
                else
                {
                    playerLoseCount += 1;
                    loseCountShow.Text = playerLoseCount.ToString();
                    MessageBox.Show("Oh no! " + (10 - gameCount) + " games to go.", "Loser!");
                }

                disableButtons();
                Thread.Sleep(1100);
                newGameRound();
            }
            else
            {
                if (turnCount == 9)
                {
                    playerDrawCount += 1;
                    drawCountShow.Text = playerDrawCount.ToString();
                    MessageBox.Show("Draw!", "Bummer!");

                    disableButtons();
                    Thread.Sleep(1100);
                    newGameRound();
                }
            }

            if (gameCount == 11)
            {
                if (playerWinCount > playerLoseCount)
                {
                    MessageBox.Show("Congratulations, you beat the game and get to live another day! Yay!");
                }
                else
                {
                    MessageBox.Show("This game has 99 problems but you ain't one of them. You lose!");
                }

                newGame();
            }
        }

        private void disableButtons()
        {
            if (R1C1.Enabled)
            {
                R1C1.Enabled = false;
            }

            if (R1C2.Enabled)
            {
                R1C2.Enabled = false;
            }

            if (R1C3.Enabled)
            {
                R1C3.Enabled = false;
            }

            if (R2C1.Enabled)
            {
                R2C1.Enabled = false;
            }

            if (R2C2.Enabled)
            {
                R2C2.Enabled = false;
            }

            if (R2C3.Enabled)
            {
                R2C3.Enabled = false;
            }

            if (R3C1.Enabled)
            {
                R3C1.Enabled = false;
            }

            if (R3C2.Enabled)
            {
                R3C2.Enabled = false;
            }

            if (R3C3.Enabled)
            {
                R3C3.Enabled = false;
            }
        }

        private void newGame()
        {
            turnSwitch = true;
            turnCount = 0;
            gameCount = 1;
            playerWinCount = 0;
            winCountShow.Text = "0";
            playerDrawCount = 0;
            drawCountShow.Text = "0";
            playerLoseCount = 0;
            loseCountShow.Text = "0";

            if (R1C1.Enabled == false)
            {
                R1C1.Text = String.Empty;
                R1C1.Enabled = true;
            }

            if (R1C2.Enabled == false)
            {
                R1C2.Text = String.Empty;
                R1C2.Enabled = true;
            }

            if (R1C3.Enabled == false)
            {
                R1C3.Text = String.Empty;
                R1C3.Enabled = true;
            }

            if (R2C1.Enabled == false)
            {
                R2C1.Text = String.Empty;
                R2C1.Enabled = true;
            }

            if (R2C2.Enabled == false)
            {
                R2C2.Text = String.Empty;
                R2C2.Enabled = true;
            }

            if (R2C3.Enabled == false)
            {
                R2C3.Text = String.Empty;
                R2C3.Enabled = true;
            }

            if (R3C1.Enabled == false)
            {
                R3C1.Text = String.Empty;
                R3C1.Enabled = true;
            }

            if (R3C2.Enabled == false)
            {
                R3C2.Text = String.Empty;
                R3C2.Enabled = true;
            }

            if (R3C3.Enabled == false)
            {
                R3C3.Text = String.Empty;
                R3C3.Enabled = true;
            }
        }

        private void newGameRound()
        {
            turnSwitch = true;
            turnCount = 0;
            gameCount += 1;

            if (gameCount % 2 == 0)
            {
                artificialIntelligenceDoMove();
                turnSwitch = false;
            }

            if (R1C1.Enabled == false)
            {
                R1C1.Text = String.Empty;
                R1C1.Enabled = true;
            }

            if (R1C2.Enabled == false)
            {
                R1C2.Text = String.Empty;
                R1C2.Enabled = true;
            }

            if (R1C3.Enabled == false)
            {
                R1C3.Text = String.Empty;
                R1C3.Enabled = true;
            }

            if (R2C1.Enabled == false)
            {
                R2C1.Text = String.Empty;
                R2C1.Enabled = true;
            }

            if (R2C2.Enabled == false)
            {
                R2C2.Text = String.Empty;
                R2C2.Enabled = true;
            }

            if (R2C3.Enabled == false)
            {
                R2C3.Text = String.Empty;
                R2C3.Enabled = true;
            }

            if (R3C1.Enabled == false)
            {
                R3C1.Text = String.Empty;
                R3C1.Enabled = true;
            }

            if (R3C2.Enabled == false)
            {
                R3C2.Text = String.Empty;
                R3C2.Enabled = true;
            }

            if (R3C3.Enabled == false)
            {
                R3C3.Text = String.Empty;
                R3C3.Enabled = true;
            }
        }

        private void playTwistOfFateSound()
        {
            SoundPlayer twistOfFate = new SoundPlayer(TicTacToe.Properties.Resources.swords);
            twistOfFate.Play();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Enabled)
            {
                if (turnSwitch == true)
                {
                    button.Text = "O";
                }
                else
                {
                    button.Text = "X";
                }
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Enabled)
            {
                button.Text = String.Empty;
            }
        }

        private void soundButton_Click(object sender, EventArgs e)
        {
            if (soundButton.Text == "On")
            {
                enableSound = false;
                soundButton.ForeColor = System.Drawing.Color.Black;
                soundButton.Text = "Off";
            }
            else
            {
                enableSound = true;
                soundButton.ForeColor = System.Drawing.Color.Green;
                soundButton.Text = "On";
            }
        }

        private void introTimer_Tick(object sender, EventArgs e)
        {
            introBox.Hide();
            introBox.Enabled = false;
            introTimer.Stop();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string howToPlayMessage = String.Format("In medieval times life was not always fair, so is this game.{0}\"Game Of Tic Tac Toe\" has a little twist - each time you select position{0}there is random chance that the game will alter your selected position!{0}To emerge victorious (and avoid fatal end) is simple enough - you need{0}to win more times than losing in the course of 10 rounds.{0}{0}In order to win you must place three \"O\" in a row, column or diagonal.", Environment.NewLine);
            
            MessageBox.Show(howToPlayMessage, "How To Play");
        }
    }
}