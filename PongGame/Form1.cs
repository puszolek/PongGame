using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class WindowMain : Form
    {

        List<Ball> listBalls = new List<Ball>();
        int iterator = 0;

        public WindowMain()
        {
            InitializeComponent();
            listBalls.Add(PicBoxBall);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //PicBoxBall.Location = new Point(10, 10);
            if (ButtonStart.Text == "Start")
            {
                TimerBallMovement.Start();
                ButtonStart.Text = "Stop";
            }
            else
            {
                TimerBallMovement.Stop();
                ButtonStart.Text = "Start";
            }
            
        }

        private void TimerBallMovement_Tick(object sender, EventArgs e)
        {
            foreach (Ball ball in listBalls)
            {
                ball.Location = new Point(ball.Location.X + (int)ball.Vx, ball.Location.Y + (int)ball.Vy);
                if(ball.Location.X >= PanelBox.Size.Width - ball.Size.Width)
                {
                    ball.Vx = -ball.Vx;
                }
                if (ball.Location.Y >= PanelBox.Size.Height - ball.Size.Height)
                {
                    ball.Vy = -ball.Vy;
                }
                if (ball.Location.X <= 0)
                {
                    ball.Vx = -ball.Vx;
                }
                if (ball.Location.Y <= 0)
                {
                    ball.Vy = -ball.Vy;
                }

                if ((ball.Location.X >= PanelPaddle.Location.X && ball.Location.X <= PanelPaddle.Location.X + PanelPaddle.Size.Width) 
                    && (ball.Location.Y+ball.Size.Height >= PanelPaddle.Location.Y && ball.Location.Y+ball.Size.Height <= PanelPaddle.Location.Y + PanelPaddle.Size.Width))
                {
                    ball.Vy = -ball.Vy;
                }
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Ball ball = new Ball();
            ball.Image = global::PongGame.Properties.Resources.BallImg;
            ball.Location = new System.Drawing.Point(97, 95);
            ball.Name = "PicBoxBall" + iterator;
            ball.Size = new System.Drawing.Size(39, 38);
            ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 1;
            ball.TabStop = false;
            ball.Vx = 2D;
            ball.Vy = 2D;

            listBalls.Add(ball);
            PanelBox.Controls.Add(ball);

            iterator++;
        }

        private void PanelBox_MouseMove(object sender, MouseEventArgs e)
        {
            PanelPaddle.Location = new Point(e.Location.X, e.Location.Y);
        }
    }
}
