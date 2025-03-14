using System.Windows.Forms;

namespace CrashPlaneGame
{
    public partial class CrashCarGame : Form
    {
        private int gamespeed = 0;
        Random r = new();
        private int x,
            y;
        private int collectedCoins = 0;

        public CrashCarGame()
        {
            InitializeComponent();
            mainCar.BackColor = Color.Transparent;
            enemyCar1.BackColor = Color.Transparent;
            enemyCar2.BackColor = Color.Transparent;
            GameOver.Visible = false;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Moveline(gamespeed);
            Enemy(gamespeed);
            Coin(gamespeed);
            CoinCollection();
            Gameover();
        }

        private void CrashCarGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (mainCar.Left > 0)
                {
                    mainCar.Left += -8;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (mainCar.Right < 380)
                {
                    mainCar.Left += 8;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (mainCar.Top > 0)
                {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (mainCar.Bottom < 380)
                {
                    gamespeed--;
                }
            }
        }

        private void Moveline(int speed)
        {
            if (centerLine1.Top >= 380)
            {
                centerLine1.Top = 0;
            }
            else
            {
                centerLine1.Top += speed;
            }

            if (centerLine2.Top >= 380)
            {
                centerLine2.Top = 0;
            }
            else
            {
                centerLine2.Top += speed;
            }

            if (centerLine3.Top >= 380)
            {
                centerLine3.Top = 0;
            }
            else
            {
                centerLine3.Top += speed;
            }

            if (centerLine4.Top >= 380)
            {
                centerLine4.Top = 0;
            }
            else
            {
                centerLine4.Top += speed;
            }
        }

        private void Enemy(int speed)
        {
            if (enemyCar1.Top >= 380)
            {
                x = r.Next(0, 200);
                enemyCar1.Location = new Point(x, 0);
            }
            else
            {
                enemyCar1.Top += speed;
            }

            if (enemyCar2.Top >= 380)
            {
                x = r.Next(0, 300);
                enemyCar2.Location = new Point(x, 0);
            }
            else
            {
                enemyCar3.Top += speed;
            }
            if (enemyCar3.Top >= 380)
            {
                x = r.Next(0, 400);
                enemyCar3.Location = new Point(x, 0);
            }
            else
            {
                enemyCar2.Top += speed;
            }
        }

        private void Coin(int speed)
        {
            if (coin1.Top >= 380)
            {
                x = r.Next(0, 100);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 380)
            {
                x = r.Next(20, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 380)
            {
                x = r.Next(0, 300);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 380)
            {
                x = r.Next(50, 400);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }

        private void Gameover()
        {
            if (mainCar.Bounds.IntersectsWith(enemyCar1.Bounds))
            {
                GameTimer.Enabled = false;
                GameOver.Visible = true;
            }
            if (mainCar.Bounds.IntersectsWith(enemyCar2.Bounds))
            {
                GameTimer.Enabled = false;
                GameOver.Visible = true;
            }
            if (mainCar.Bounds.IntersectsWith(enemyCar3.Bounds))
            {
                GameTimer.Enabled = false;
                GameOver.Visible = true;
            }
        }

        private void CoinCollection()
        {
            if (mainCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoins++;
                coinsCollected.Text = "Coins = " + collectedCoins.ToString();
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            if (mainCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoins++;
                coinsCollected.Text = "Coins = " + collectedCoins.ToString();
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            if (mainCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoins++;
                coinsCollected.Text = "Coins = " + collectedCoins.ToString();
                x = r.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }
            if (mainCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoins++;
                coinsCollected.Text = "Coins = " + collectedCoins.ToString();
                x = r.Next(0, 200);
                coin4.Location = new Point(x, 0);
            }
        }

        private void GameOver_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
