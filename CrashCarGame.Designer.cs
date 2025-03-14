namespace CrashPlaneGame
{
    partial class CrashCarGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashCarGame));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            centerLine1 = new PictureBox();
            centerLine2 = new PictureBox();
            centerLine3 = new PictureBox();
            centerLine4 = new PictureBox();
            mainCar = new PictureBox();
            enemyCar1 = new PictureBox();
            enemyCar2 = new PictureBox();
            GameOver = new Label();
            enemyCar3 = new PictureBox();
            coin1 = new PictureBox();
            coin2 = new PictureBox();
            coin3 = new PictureBox();
            coin4 = new PictureBox();
            coinsCollected = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centerLine1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centerLine2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centerLine3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centerLine4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Info;
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 387);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Info;
            pictureBox2.Location = new Point(333, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 387);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 10;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // centerLine1
            // 
            centerLine1.BackColor = SystemColors.Info;
            centerLine1.Location = new Point(187, -2);
            centerLine1.Name = "centerLine1";
            centerLine1.Size = new Size(10, 74);
            centerLine1.TabIndex = 2;
            centerLine1.TabStop = false;
            // 
            // centerLine2
            // 
            centerLine2.BackColor = SystemColors.Info;
            centerLine2.Location = new Point(187, 99);
            centerLine2.Name = "centerLine2";
            centerLine2.Size = new Size(10, 104);
            centerLine2.TabIndex = 3;
            centerLine2.TabStop = false;
            // 
            // centerLine3
            // 
            centerLine3.BackColor = SystemColors.Info;
            centerLine3.Location = new Point(187, 228);
            centerLine3.Name = "centerLine3";
            centerLine3.Size = new Size(10, 113);
            centerLine3.TabIndex = 4;
            centerLine3.TabStop = false;
            // 
            // centerLine4
            // 
            centerLine4.BackColor = SystemColors.Info;
            centerLine4.Location = new Point(187, 370);
            centerLine4.Name = "centerLine4";
            centerLine4.Size = new Size(10, 74);
            centerLine4.TabIndex = 5;
            centerLine4.TabStop = false;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(51, 306);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(50, 81);
            mainCar.SizeMode = PictureBoxSizeMode.StretchImage;
            mainCar.TabIndex = 6;
            mainCar.TabStop = false;
            // 
            // enemyCar1
            // 
            enemyCar1.BackColor = Color.Transparent;
            enemyCar1.Image = (Image)resources.GetObject("enemyCar1.Image");
            enemyCar1.Location = new Point(88, 28);
            enemyCar1.Name = "enemyCar1";
            enemyCar1.Size = new Size(53, 77);
            enemyCar1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCar1.TabIndex = 7;
            enemyCar1.TabStop = false;
            // 
            // enemyCar2
            // 
            enemyCar2.BackColor = Color.Transparent;
            enemyCar2.Image = (Image)resources.GetObject("enemyCar2.Image");
            enemyCar2.Location = new Point(281, 72);
            enemyCar2.Name = "enemyCar2";
            enemyCar2.Size = new Size(55, 82);
            enemyCar2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCar2.TabIndex = 8;
            enemyCar2.TabStop = false;
            // 
            // GameOver
            // 
            GameOver.AutoSize = true;
            GameOver.BackColor = Color.Yellow;
            GameOver.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameOver.ForeColor = Color.Red;
            GameOver.Location = new Point(119, 186);
            GameOver.Name = "GameOver";
            GameOver.Size = new Size(145, 30);
            GameOver.TabIndex = 9;
            GameOver.Text = "Game Over";
            GameOver.Click += GameOver_Click;
            // 
            // enemyCar3
            // 
            enemyCar3.BackColor = Color.Transparent;
            enemyCar3.Image = (Image)resources.GetObject("enemyCar3.Image");
            enemyCar3.Location = new Point(230, 241);
            enemyCar3.Name = "enemyCar3";
            enemyCar3.Size = new Size(55, 82);
            enemyCar3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyCar3.TabIndex = 10;
            enemyCar3.TabStop = false;
            // 
            // coin1
            // 
            coin1.BackColor = Color.Transparent;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(211, 53);
            coin1.Name = "coin1";
            coin1.Size = new Size(33, 31);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 11;
            coin1.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = Color.Transparent;
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(51, 145);
            coin2.Name = "coin2";
            coin2.Size = new Size(33, 31);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 12;
            coin2.TabStop = false;
            // 
            // coin3
            // 
            coin3.BackColor = Color.Transparent;
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(303, 195);
            coin3.Name = "coin3";
            coin3.Size = new Size(33, 31);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 13;
            coin3.TabStop = false;
            // 
            // coin4
            // 
            coin4.BackColor = Color.Transparent;
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(132, 241);
            coin4.Name = "coin4";
            coin4.Size = new Size(33, 31);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 14;
            coin4.TabStop = false;
            // 
            // coinsCollected
            // 
            coinsCollected.AutoSize = true;
            coinsCollected.BackColor = Color.Transparent;
            coinsCollected.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coinsCollected.ForeColor = Color.Gold;
            coinsCollected.Location = new Point(12, 9);
            coinsCollected.Name = "coinsCollected";
            coinsCollected.Size = new Size(77, 21);
            coinsCollected.TabIndex = 15;
            coinsCollected.Text = "Coins = 0";
            // 
            // CrashCarGame
            // 
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(380, 427);
            Controls.Add(coinsCollected);
            Controls.Add(coin4);
            Controls.Add(coin3);
            Controls.Add(coin2);
            Controls.Add(coin1);
            Controls.Add(enemyCar3);
            Controls.Add(GameOver);
            Controls.Add(enemyCar2);
            Controls.Add(enemyCar1);
            Controls.Add(mainCar);
            Controls.Add(centerLine4);
            Controls.Add(centerLine3);
            Controls.Add(centerLine2);
            Controls.Add(centerLine1);
            ForeColor = SystemColors.ControlText;
            Name = "CrashCarGame";
            KeyDown += CrashCarGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)centerLine1).EndInit();
            ((System.ComponentModel.ISupportInitialize)centerLine2).EndInit();
            ((System.ComponentModel.ISupportInitialize)centerLine3).EndInit();
            ((System.ComponentModel.ISupportInitialize)centerLine4).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox centerLine1;
        private PictureBox centerLine2;
        private PictureBox centerLine3;
        private PictureBox centerLine4;
        private PictureBox mainCar;
        private PictureBox enemyCar1;
        private PictureBox enemyCar2;
        private Label GameOver;
        private PictureBox enemyCar3;
        private PictureBox coin1;
        private PictureBox coin2;
        private PictureBox coin3;
        private PictureBox coin4;
        private Label coinsCollected;
    }
}
