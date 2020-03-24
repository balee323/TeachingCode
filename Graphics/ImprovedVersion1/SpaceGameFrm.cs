using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace ImprovedVersion1
{
    public partial class SpaceGameFrm : Form
    {
        WindowsMediaPlayer GameSong;
        WindowsMediaPlayer Shoot;
        WindowsMediaPlayer Explosion;
        PictureBox[] Stars;
        PictureBox[] Enemis;
        PictureBox[] Munitions;
        PictureBox[] EnemisMunition;

        Random rnd;

        Timer _mainTimer = new Timer();
        Timer _enemyMoveTimer = new Timer();
        Timer _enemyAmmoTimer = new Timer();
        Timer _upTimer = new Timer();
        Timer _downTimer = new Timer();
        Timer _leftTimer = new Timer();
        Timer _rightTimer = new Timer();
        Timer _ammoTimer = new Timer();

        int BackgroundSpeed;
        int MunitionSpeed;
        int AircraftSpeed;
        int EnemiSpeed;
        int EnemisMunitionSpeed;
        int Score;
        int Level;
        int hard;
        bool pause;
        bool gameIsOver;

        PictureBox Aircraft = new PictureBox();

        //Constructor
        public SpaceGameFrm()
        {
            InitializeComponent();
        }

        //window_Load method
        private void SpaceGameFrm_Load(object sender, EventArgs e)
        {


            //Init Variables
            pause = false;
            gameIsOver = false;
            BackgroundSpeed = 4; //4
            EnemisMunitionSpeed = 4;
            MunitionSpeed = 20;
            AircraftSpeed = 6;
            EnemiSpeed = 4;
            Score = 0;
            Level = 1;
            hard = 9;

            //Create WMP
            GameSong = new WindowsMediaPlayer();
            Shoot = new WindowsMediaPlayer();
            Explosion = new WindowsMediaPlayer();

            //Load all songs
            GameSong.URL = "songs\\GameSong.mp3";
            Shoot.URL = "songs\\shoot.mp3";
            Explosion.URL = "songs\\boom.mp3";

            //Setup Songs settings
            GameSong.settings.setMode("loop", true);
            GameSong.settings.volume = 5;
            Shoot.settings.volume = 1;
            Explosion.settings.volume = 6;

            var image = Image.FromFile("asserts\\Aircraft1.png");
            Aircraft.Image = image;
            Aircraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Aircraft.BackColor = Color.Transparent;
            Aircraft.Top = this.Height - Aircraft.Height * 2 - 10;
            Aircraft.Left = (this.Width - Aircraft.Width) / 2;
            Aircraft.Width = 75;
            Aircraft.Height = 75;
            this.Controls.Add(Aircraft);

           

            //Load all Images
            Image enemi1 = Image.FromFile("asserts\\E1.png");
            Image enemi2 = Image.FromFile("asserts\\E2.png");
            Image enemi3 = Image.FromFile("asserts\\E3.png");
            Image boss1 = Image.FromFile("asserts\\Boss1.png");
            Image boss2 = Image.FromFile("asserts\\Boss2.png");
            Image munition = Image.FromFile("asserts\\munition.png");

            //Create Picturebox Array for images
            Stars = new PictureBox[10];   //10
            Enemis = new PictureBox[20];  //10
            Munitions = new PictureBox[10]; //3
            EnemisMunition = new PictureBox[10];  //10

            rnd = new Random();

            for (int i = 0; i < Stars.Length; i++)
            {
                Stars[i] = new PictureBox();
                Stars[i].BorderStyle = BorderStyle.None;
                Stars[i].Location = new Point(rnd.Next(0, this.Width), rnd.Next(0, this.Height));
                if (i % 2 == 1)
                {
                    Stars[i].Size = new Size(2, 2);
                    Stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    Stars[i].Size = new Size(3, 3);
                    Stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(Stars[i]);
            }

            //Initialiase EnemisPictureBoxes
            for (int i = 0; i < Enemis.Length; i++)
            {
                Enemis[i] = new PictureBox();
                Enemis[i].Size = new Size(40, 40);
                Enemis[i].SizeMode = PictureBoxSizeMode.Zoom;
                Enemis[i].BorderStyle = BorderStyle.None;
                Enemis[i].BackColor = System.Drawing.Color.Transparent;

                Enemis[i].Visible = false;
                this.Controls.Add(Enemis[i]);
                Enemis[i].Location = new Point((i + 1) * 50, -30);
            }

            Enemis[0].Image = boss1;
            Enemis[1].Image = enemi2;
            Enemis[2].Image = enemi3;
            Enemis[3].Image = enemi3;
            Enemis[4].Image = enemi1;
            Enemis[5].Image = enemi3;
            Enemis[6].Image = enemi2;
            Enemis[7].Image = enemi3;
            Enemis[8].Image = enemi2;
            Enemis[9].Image = boss2;
            Enemis[10].Image = boss1;
            Enemis[11].Image = enemi2;
            Enemis[12].Image = enemi3;
            Enemis[13].Image = enemi3;
            Enemis[14].Image = enemi1;
            Enemis[15].Image = enemi3;
            Enemis[16].Image = enemi2;
            Enemis[17].Image = enemi3;
            Enemis[18].Image = enemi2;
            Enemis[19].Image = boss2;


            //Enemis Munition          
            for (int i = 0; i < EnemisMunition.Length; i++)
            {
                EnemisMunition[i] = new PictureBox();
                EnemisMunition[i].Size = new Size(2, 50);
                EnemisMunition[i].Visible = false;
                EnemisMunition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                EnemisMunition[i].Location = new Point(Enemis[x].Location.X, Enemis[x].Location.Y - 20);
                this.Controls.Add(EnemisMunition[i]);
            }

            //Initialise Munition PictureBoxes
            for (int i = 0; i < Munitions.Length; i++)
            {
                Munitions[i] = new PictureBox();
                Munitions[i].Size = new Size(8, 8);
                Munitions[i].Image = munition;
                Munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                Munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(Munitions[i]);
            }
            GameSong.controls.play();

            
            SetControlsToFront();
            //this.panel1.SendToBack();

            SetupTimers();



        }//end form_load


        private void SetupTimers()
        {
            _mainTimer.Enabled = true;
            _mainTimer.Interval = 10;
            _mainTimer.Tick += new System.EventHandler(this.MainGameTimer_Tick);

            _enemyMoveTimer.Enabled = true;
            _enemyMoveTimer.Interval = 10;
            _enemyMoveTimer.Tick += new System.EventHandler(this.MoveEnemisTimer_Tick);


            _ammoTimer.Enabled = true;
            _ammoTimer.Interval = 10;
            _ammoTimer.Tick += new System.EventHandler(this.AmmoTimer_Tick);


            _downTimer.Interval = 5;
            _downTimer.Enabled = false;
            _downTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);


            _leftTimer.Interval = 5;
            _leftTimer.Enabled = false;
            _leftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);

   
            _rightTimer.Interval = 5;
            _rightTimer.Enabled = false;
            _rightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);

  
            _upTimer.Interval = 5;
            _upTimer.Enabled = false;
            _upTimer.Tick += new System.EventHandler(this.MoveTopTimer_Tick);
        }



        private void SetControlsToFront()
        {
            foreach (Control control in this.Controls)
            {
                control.BringToFront();
            }
        }


        //Move Game Timer_Tick
        private void MainGameTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Stars.Length / 2; i++)
            {
                Stars[i].Top += BackgroundSpeed + 10;
                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }

            for (int i = Stars.Length / 2; i < Stars.Length; i++)
            {
                Stars[i].Top += BackgroundSpeed - 2;
                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }
        }

        //KeyDown Event Handler
        private void SpaceGameFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    _rightTimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    _leftTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    _downTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    _upTimer.Start();
                }
            }
        }

        //KeyUp Event Handler
        private void SpaceGameFrm_KeyUp(object sender, KeyEventArgs e)
        {
           
            _rightTimer.Stop();
            _leftTimer.Stop();
            _downTimer.Stop();
            _upTimer.Stop();


            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        Text_lbl.Visible = false;
                        GameSong.controls.play(); ;
                        pause = false;
                    }
                    else
                    {
                        Text_lbl.Location = new Point(20, 150);
                        Text_lbl.Text = "GAME PAUSED";
                        Text_lbl.Visible = true;
                        GameSong.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        //Move Left Timer_Tick
        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if (Aircraft.Left > 0)
            {
                Aircraft.Left -= AircraftSpeed;
            }
        }

        //Move Rigth Timer_Tick
        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            if (Aircraft.Right < this.Right - Aircraft.Width)
            {
                Aircraft.Left += AircraftSpeed;
            }
            
        }

        //Move Upwards Timer_Tick
        private void MoveTopTimer_Tick(object sender, EventArgs e)
        {
            if (Aircraft.Top > 10)
            {
                Aircraft.Top -= AircraftSpeed;
            }
        }

        //Move Downwards Timer_Tick
        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            if (Aircraft.Bottom < this.Height - Aircraft.Height/2)
            {
                Aircraft.Top += AircraftSpeed;
            }
        }

        //Move Gun Munition Timer_Tick
        private void AmmoTimer_Tick(object sender, EventArgs e)
        {
            Shoot.controls.play();

            for (int i = 0; i < Munitions.Length; i++)
            {
                if (Munitions[i].Top > 0)
                {
                    Munitions[i].Visible = true;
                    Munitions[i].Top -= MunitionSpeed;

                    Collision();
                }
                else
                {
                    Munitions[i].Visible = false;
                    Munitions[i].Location = new Point(Aircraft.Location.X + 20, Aircraft.Location.Y - i * 30);
                }
            }
        }

        private void EnemyAmmoTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (EnemisMunition.Length - hard); i++)
            {
                if (EnemisMunition[i].Top < this.Height)
                {
                    EnemisMunition[i].Visible = true;
                    EnemisMunition[i].Top += EnemisMunitionSpeed;
                    //CollisionWithEnemisMunition();
                }
                else  //redraw enemies at back at top
                {
                    EnemisMunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    EnemisMunition[i].Location = new Point(Enemis[x].Location.X + 20, Enemis[x].Location.Y + 30);
                }
            }
        }

        //Move Enemies Timer_Tick
        private void MoveEnemisTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemisVertical(Enemis, EnemiSpeed);
        }

        //Enemi Vertical Move Method
        private void MoveEnemisVertical(PictureBox[] enemis, int speed)
        {
            for (int i = 0; i < enemis.Length; i++)
            {
                enemis[i].Visible = true;
                enemis[i].Top += speed;

                if (enemis[i].Top > this.Height)
                {
                    Enemis[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        //Collusion of Aircraft with enemis munition Handler
        private void CollisionWithEnemisMunition()
        {
            for (int i = 0; i < EnemisMunition.Length; i++)
            {
                if (EnemisMunition[i].Bounds.IntersectsWith(Aircraft.Bounds))
                {
                    EnemisMunition[i].Visible = false;
                    Explosion.settings.volume = 30;
                    Explosion.controls.play();
                    Aircraft.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        //Collision Handler Methods
        private void Collision()
        {
            for (int i = 0; i < Enemis.Length; i++)
            {
                if (Munitions[0].Bounds.IntersectsWith(Enemis[i].Bounds) || Munitions[1].Bounds.IntersectsWith(Enemis[i].Bounds) || Munitions[2].Bounds.IntersectsWith(Enemis[i].Bounds))
                {
                    Explosion.controls.play();
                    Score += 1;
                    scorelbl.Text = (Score < 10) ? "0" + Score.ToString() : Score.ToString();

                    if (Score % 30 == 0)
                    {
                        Level += 1;
                        levelbl.Text = (Level < 10) ? "0" + Level.ToString() : Level.ToString();

                        if (EnemiSpeed <= 10 && EnemisMunitionSpeed <= 10 && hard >= 0)
                        {
                            hard--;
                            EnemiSpeed++;
                            EnemisMunitionSpeed++;
                        }

                        if (Level == 10)
                        {
                            GameOver("NICE DONE");
                        }
                    }
                    Enemis[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Aircraft.Bounds.IntersectsWith(Enemis[i].Bounds))
                {
                    Explosion.settings.volume = 30;
                    Explosion.controls.play();
                    //Aircraft.Visible = false;
                    //GameOver("GAME OVER");
                }
            }
        }

        //Game Control Method
        private void GameOver(String str)
        {
            GameSong.controls.stop();
            Text_lbl.Location = new Point(60, 110);
            Text_lbl.Text = str.Trim();
            Text_lbl.Visible = true;
            gameIsOver = true;
            pause = true;
            ReplayBtn.Text = "Replay";
            ReplayBtn.Visible = true;
            QuitBtn.Visible = true;
            StopTimers();
        }

        //Replay Buttons Event Handlers
        private void ReplayBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            SpaceGameFrm_Load(e, e);
        }

        //QuitGame Button Event Handler 
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        //Stop Timers
        private void StopTimers()
        {
            _mainTimer.Stop();
            _enemyMoveTimer.Stop();
            _ammoTimer.Stop();
            _enemyAmmoTimer.Stop();
        }

        //Start Timers
        private void StartTimers()
        {
            _mainTimer.Start();
            _enemyMoveTimer.Start();
            _ammoTimer.Start();
            _enemyAmmoTimer.Start();
        }

      
    }
}
