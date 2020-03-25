using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace LearningGraphics
{
    public partial class Form1 : Form
    {

        private SpriteObj[] _enemyShips;
        private SpriteObj _hero;
        private CollisonManager _collisonMgr;

        public Form1()
        {
            //this.DoubleBuffered = true; // to reduce/prevent flickering
            this.BackColor = Color.Black;
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            //Trying another way to reduce flickering/tearing
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            BeginGame();
        }

        private void BeginGame()
        {
            PlayGameSong();

            lblScore.Text = "0";

            _hero = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\Aircraft1.png"), new Rectangle(this.Width / 2, this.Height - (70 * 2), 40, 38), 5, this, true);

            _enemyShips = new SpriteObj[10];

            _enemyShips[0] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\Boss1.png"), new Rectangle(10, 10, 70, 70), 3, this);

            _enemyShips[1] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E1.png"), new Rectangle(100, 10, 45, 40), 5, this);
            _enemyShips[2] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E2.png"), new Rectangle(160, 10, 45, 40), 7, this);
            _enemyShips[3] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E3.png"), new Rectangle(210, 10, 45, 40), 6, this);
            _enemyShips[4] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E1.png"), new Rectangle(270, 10, 45, 40), 5, this);
            _enemyShips[5] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E2.png"), new Rectangle(330, 10, 45, 40), 7, this);
            _enemyShips[6] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E3.png"), new Rectangle(390, 10, 45, 40), 6, this);
            _enemyShips[7] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E1.png"), new Rectangle(450, 10, 45, 40), 5, this);
            _enemyShips[8] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\E2.png"), new Rectangle(510, 10, 45, 40), 7, this);

            _enemyShips[9] = new SpriteObj(this.CreateGraphics(), Image.FromFile("asserts\\Boss2.png"), new Rectangle(590, 10, 70, 70), 2, this);
            SetupTimers();

            _hero.UpdateAmmoLocationThread();
            _collisonMgr = new CollisonManager(_enemyShips.ToList(), _hero, this);
            _collisonMgr.StartCollisonDetection();
        }


        private void ResetGame()
        {
            var g = this.CreateGraphics();
            g.Clear(Color.Black);

            
           
            lblScore.Text = "0";

            _collisonMgr.Score = 0;
            _hero.Reset();
            
            foreach(SpriteObj enemy in _enemyShips){
                enemy.Reset();
            }
            

            Task.Delay(100);

            
        }


        private void PlayGameSong()
        {

            var song = new WindowsMediaPlayer();
            //Load song
            song.URL = "sounds\\GameSong.mp3";

            //Setup Songs settings
            song.settings.setMode("loop", true);
            song.settings.volume = 5;
            song.controls.play();
        }


        private void SetupTimers()
        {


            Task stars = new Task(GenerateStars);
            //stars.Start();

            Task task1 = new Task(RefreshSprites);
            task1.Start();
       

        }

        private void GenerateStars()
        {
            //throw new NotImplementedException();
        }

       

        //Move Enemies Timer_Tick
        private void RefreshSprites()
        {
            while(true){
                
                if (_enemyShips != null)
                {
                    try
                    {
                        var g = this.CreateGraphics();
                        g.Clear(Color.Black);

                        Parallel.ForEach(_enemyShips, (ship) => ship.DrawSprites());
                    }
                    catch
                    {

                    }
                }
                        
                _hero.DrawSprites();
                _hero.Score = _collisonMgr.Score;
                lblScore.Invoke(new Action(() => lblScore.Text = _collisonMgr.Score.ToString()));
                         
                if (_hero.IsDetroyed)
                {
                    button1.Invoke(new Action(() =>  button1.Visible = true));
                    button1.Invoke(new Action(() => button1.Enabled = true));
                }

                Task.Delay(70).Wait();
            }
              

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                _hero.MoveRight();
            }
            if (e.KeyCode == Keys.Left)
            {
                _hero.MoveLeft();
            }
            if (e.KeyCode == Keys.Down)
            {
                //_downTimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                //_upTimer.Start();
            }

        }



        public void PlayExplosionSound()
        {
            Task.Run(() => PlaySound("sounds\\explosion.wav"));

        }

    
        private void PlaySound(string soundUrl)
        {
            SoundPlayer soundPlayer = new SoundPlayer(soundUrl);
            soundPlayer.Play();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Space)
            {
                _hero.AllStop();
            }
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ' ')
            {
                 _hero.Fire();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ResetGame();
            button1.Visible = false;
            this.Focus();
            //button1.Enabled = false;
            
        }
    }
}
