namespace FlappyBird
{
    public partial class MainForm : Form
    {
        int speed = 8;
        int gravity = 8;
        int score = 0;
        bool isGameStarted = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (!isGameStarted)
            {
                PositionReset();
                score = 0;
                isGameStarted = true;
                timer1.Enabled = true;
                lblStartEnd.Visible = false;
            }
        }

        private void PositionReset()
        {
            pbBird.Location = new Point(92, 113);
            pbPipeUp.Location = new Point(311, 271);
            pbPipeDown.Location = new Point(462, -19);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbBird.Top += gravity;
            pbPipeDown.Left -= speed;
            pbPipeUp.Left -= speed;
            lblScore.Text = "Score: " + score.ToString();

            if (pbPipeUp.Left < -150)
            {
                pbPipeUp.Left = 800;
                score++;
            }
            if (pbPipeDown.Left < -180)
            {
                pbPipeDown.Left = 950;
                score++;
            }

            if (pbBird.Bounds.IntersectsWith(pbPipeDown.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbPipeUp.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbGround.Bounds) ||
                pbBird.Top < -25
                )
            {
                EndGame();
            }

            if (score % 5 == 0)
            {
                speed = 8 + (score / 5);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!isGameStarted)
                {
                    StartGame();
                }
                gravity = 8;
            }
        }

        private void EndGame()
        {
            timer1.Stop();
            lblStartEnd.Text = "GAME OVER!!";
            lblStartEnd.Visible = true;
            isGameStarted = false;
        }
    }
}