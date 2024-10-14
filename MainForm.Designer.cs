namespace FlappyBird
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbBird = new PictureBox();
            pbGround = new PictureBox();
            pbPipeDown = new PictureBox();
            pbPipeUp = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            lblStartEnd = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPipeUp).BeginInit();
            SuspendLayout();
            // 
            // pbBird
            // 
            pbBird.Anchor = AnchorStyles.None;
            pbBird.Image = Properties.Resources.yellowbird_upflap;
            pbBird.Location = new Point(92, 113);
            pbBird.Name = "pbBird";
            pbBird.Size = new Size(54, 47);
            pbBird.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBird.TabIndex = 0;
            pbBird.TabStop = false;
            // 
            // pbGround
            // 
            pbGround.Image = Properties.Resources._base;
            pbGround.Location = new Point(-35, 404);
            pbGround.Name = "pbGround";
            pbGround.Size = new Size(723, 91);
            pbGround.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGround.TabIndex = 1;
            pbGround.TabStop = false;
            // 
            // pbPipeDown
            // 
            pbPipeDown.Image = Properties.Resources.pipe_down;
            pbPipeDown.Location = new Point(462, -19);
            pbPipeDown.Name = "pbPipeDown";
            pbPipeDown.Size = new Size(90, 179);
            pbPipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPipeDown.TabIndex = 2;
            pbPipeDown.TabStop = false;
            // 
            // pbPipeUp
            // 
            pbPipeUp.Image = Properties.Resources.pipe_up;
            pbPipeUp.Location = new Point(311, 271);
            pbPipeUp.Name = "pbPipeUp";
            pbPipeUp.Size = new Size(85, 304);
            pbPipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPipeUp.TabIndex = 3;
            pbPipeUp.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.ForeColor = Color.Firebrick;
            lblScore.Location = new Point(12, 18);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(106, 29);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score: 0";
            // 
            // lblStartEnd
            // 
            lblStartEnd.AutoSize = true;
            lblStartEnd.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartEnd.ForeColor = Color.Purple;
            lblStartEnd.Location = new Point(179, 194);
            lblStartEnd.Name = "lblStartEnd";
            lblStartEnd.Size = new Size(189, 37);
            lblStartEnd.TabIndex = 5;
            lblStartEnd.Text = "Start Game";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(564, 489);
            Controls.Add(lblStartEnd);
            Controls.Add(lblScore);
            Controls.Add(pbBird);
            Controls.Add(pbGround);
            Controls.Add(pbPipeUp);
            Controls.Add(pbPipeDown);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = " ";
            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pbBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPipeUp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBird;
        private PictureBox pbGround;
        private PictureBox pbPipeDown;
        private PictureBox pbPipeUp;
        private System.Windows.Forms.Timer timer1;
        private Label lblScore;
        private Label lblStartEnd;
    }
}