using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoGame
{
    public partial class Flappy_Min : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        public Flappy_Min()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            bottomPipe.Left -= pipeSpeed;
            topPipe.Left -= pipeSpeed;
            bottomPipe2.Left -= pipeSpeed;
            topPipe2.Left -= pipeSpeed;
            bottomPipe3.Left -= pipeSpeed;
            topPipe3.Left -= pipeSpeed;
            Cloud1.Left -= pipeSpeed;
            Cloud2.Left -= pipeSpeed;
            Canabis1.Left -= pipeSpeed;
            Canabis3.Left -= pipeSpeed;
            canabis2.Left -= pipeSpeed;
            scoreValue.Text = "x  " + score.ToString();
            endText1.Visible = false;
            

            if (Cloud1.Left < -170)
                Cloud1.Left = 1500;

            if (Cloud2.Left < -170)
                Cloud2.Left = 1500;

            if (Canabis1.Left < -80)
                Canabis1.Left = 1200;
            if (Canabis3.Left < -80)
                Canabis3.Left = 1200;
            if (canabis2.Left < -80)
                canabis2.Left = 1200;
            if (bottomPipe.Left < -80)
            {
                bottomPipe.Left = 1200;
                score++;
            }
            if (topPipe.Left < -80)
            {
                topPipe.Left = 1200;
                score++;
            }
            if (bottomPipe2.Left < -80)
            {
                bottomPipe2.Left = 1200;
                score++;
            }
            if (topPipe2.Left < -80)
            {
                topPipe2.Left = 1200;
                score++;
            }
            if (bottomPipe3.Left < -80)
            {
                bottomPipe3.Left = 1200;
                score++;
            }
            if (topPipe3.Left < -80)
            {
                topPipe3.Left = 1200;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(bottomPipe.Bounds) || 
                flappyBird.Bounds.IntersectsWith(bottomPipe2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(bottomPipe3.Bounds) ||
                flappyBird.Bounds.IntersectsWith(topPipe.Bounds) ||
                flappyBird.Bounds.IntersectsWith(topPipe2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(topPipe3.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top <-10)
            {
                EndGame();
            }
            
            switch (score)
            {
                case 8:
                    pipeSpeed = 10;
                    break;
                case 16:
                    pipeSpeed = 12;
                    break;
                case 30:
                    pipeSpeed = 14;
                    break;
                case 40:
                    pipeSpeed = 16;
                    break;
                case 50:
                    pipeSpeed = 18;
                    break;

            }





        }
        
        private void EndGame()
        {
            gameTimer.Stop();
            endText1.Text = String.Format("GAME OVER \r\n \r\n Bạn đã ngất sau khi hút {0} điếu cần \r\n Bấm Enter để chơi lại", score);
            endText1.Visible = true;
        }
        
            
        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -8;
            if (e.KeyCode == Keys.Enter)
                Application.Restart();
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 8;
        }
    }
}
