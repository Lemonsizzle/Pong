using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        bool goup;
        bool godown;
        
        int speedCPU = 5;
        int speedPlayer = 5;
        int walk = 8;
        int runM = 5;
        bool running;

        int ballx = 5;
        int bally = 5;

        int pPoints = 0;
        int cPoints = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void downPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }

            if (e.Modifiers == Keys.Shift || e.KeyCode == Keys.Shift)
            {
                running = true;
            }
        }

        private void upPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

            if (e.Modifiers == Keys.Shift || e.KeyCode == Keys.Shift)
            {
                running = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            scoreP.Text = "" + pPoints;
            scoreC.Text = "" + cPoints;

            ball.Top -= bally;
            ball.Left -= ballx;

            paddleCPU.Top += speedCPU;

            if(pPoints < 5)
            {
                if(paddleCPU.Top < 0 || paddleCPU.Top > 455)
                {
                    speedCPU = -speedCPU;
                }
            }
            else
            {
                paddleCPU.Top = ball.Top + 30;
            }

            if(ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                cPoints++;
            }
            
            if(ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                pPoints++;
            }

            if(ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }

            if(ball.Bounds.IntersectsWith(paddlePlayer.Bounds) || ball.Bounds.IntersectsWith(paddleCPU.Bounds))
            {
                ballx = -ballx;
            }


            if (running)
            {
                if (goup == true && paddlePlayer.Top > 0)
                {
                    paddlePlayer.Top -= walk * runM;
                }

                if (godown == true && paddlePlayer.Top < 455)
                {
                    paddlePlayer.Top += walk * runM;
                }
            }
            else
            {
                if (goup == true && paddlePlayer.Top > 0)
                {
                    paddlePlayer.Top -= walk;
                }

                if (godown == true && paddlePlayer.Top < 455)
                {
                    paddlePlayer.Top += walk;
                }
            }

            if (pPoints == 10)
            {
                gameTime.Stop();
                MessageBox.Show("You win this game");
            }

            if(cPoints == 10)
            {
                gameTime.Stop();
                MessageBox.Show("CPU wins, you lose");
            }

        }
    }
}
