using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningGraphics
{

    class SpriteObj
    {
        private Rectangle _bullet = new Rectangle(0, 0, 5, 55);
        private Graphics _graphics;
        private Rectangle _shipCoodinates = new Rectangle();
        private Form _form;
        private bool _isHero;
        private bool _isAmmoInFlight = false;
        private Image _ammoSprite;
        private Image _orginalSprite;
        private int _originalSpeed;
        private Rectangle _originalShipCoordinates;
        private bool _isDetroyed = false;
        private int _score = 0;
        private Brush _bulletColor = Brushes.White;

        private Timer _leftTimer = new Timer();
        private Timer _rightTimer = new Timer();
        private int _timesDetroyed = 0;


        public SpriteObj(Graphics graphics, Image spriteImage, Rectangle shipStartingCoordinates, int shipSpeed, Form form, bool isHero = false)
        {
            this._graphics = graphics;
            this.ShipSprite = spriteImage;
            this._orginalSprite = spriteImage;
            this.ShipCoodinates = shipStartingCoordinates;
            this._originalShipCoordinates = shipStartingCoordinates;
            this.ShipSpeed = shipSpeed;
            this._originalSpeed = shipSpeed;
            this._form = form;
            this._isHero = isHero;

            _rightTimer.Interval = 10;
            _rightTimer.Enabled = false;
            _rightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);

            _leftTimer.Interval = 10;
            _leftTimer.Enabled = false;
            _leftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
        }


        public bool IsDetroyed
        {
            get { return _isDetroyed; }
            set
            {
                _isDetroyed = value;
                if (value == true)
                {
                    TimesDetroyed++;
                }
                
                if( TimesDetroyed % 5 == 0 && TimesDetroyed != 0)
                {
                    ShipSpeed += 2;
                }
            }
        }
            
            
        public string Name { get; set; }


        public Image ShipSprite { get; set; }


        public Image AmmoSprite {
            get { return _ammoSprite; }
            set { _ammoSprite = value; }
        }

        public Rectangle ShipCoodinates
        {
            get { return _shipCoodinates; }
            set { _shipCoodinates = value; }

        }

        public int ShipSpeed { get; set; }


        public Rectangle Bullet
        {
            get { return _bullet; }
            set { _bullet = value; }
        }

        public int TimesDetroyed { get => _timesDetroyed; set => _timesDetroyed = value; }


        public int Score { get => _score; set => _score = value; }
        public bool IsAmmoInFlight { get => _isAmmoInFlight; set => _isAmmoInFlight = value; }

        public void Reset()
        {
            ShipSprite = _orginalSprite;
            ShipCoodinates = _originalShipCoordinates;
            IsDetroyed = false;
            ShipSpeed = _originalSpeed;
            TimesDetroyed = 0;
            _isAmmoInFlight = false;

        }

        public void Fire()
        {
            if (!_isAmmoInFlight && !IsDetroyed) {

                _isAmmoInFlight = true;

                if (_score <= 0)
                {
                    _bullet.Width = 5;
                    _bulletColor = Brushes.White;
                }
                else if (_score == 5000 ){
                    _bullet.Width = _bullet.Width + 2;
                    _bulletColor = Brushes.Yellow;
                }
                else if (_score == 10000)
                {
                    _bullet.Width = _bullet.Width + 5;
                    _bulletColor = Brushes.Orange;
                }
                else if (_score == 15000)
                {
                    _bullet.Width = _bullet.Width + 3;
                    _bulletColor = Brushes.Red;
                }
                else if (_score == 20000)
                {
                    _bullet.Width = _bullet.Width + 3;
                    _bulletColor = Brushes.Purple;
                }
                else if (_score == 30000)
                {
                    _bullet.Width = _bullet.Width + 4;
                    _bulletColor = Brushes.Cyan;
                }
                else if (_score == 45000)
                {
                    _bullet.Width = _bullet.Width + 4;
                    _bulletColor = Brushes.Silver;
                }
                else if (_score == 60000)
                {
                    _bullet.Width = _bullet.Width + 5;
                    _bulletColor = Brushes.SteelBlue;
                }
                else if (_score == 75000)
                {
                    _bullet.Width = _bullet.Width + 8;
                    _bulletColor = Brushes.Gold;
                }
                else if (_score == 100000)
                {
                    _bullet.Width = _bullet.Width + 8;
                    _bulletColor = Brushes.Goldenrod;
                }


                //To center the bullet at front of spaceship
                _bullet.X = ShipCoodinates.X + (ShipCoodinates.Width / 2) - (_bullet.Width/2); 
                _bullet.Y = ShipCoodinates.Y;
                _isAmmoInFlight = true;
            }
     
        }


        public void DrawSprites()
        {
            if (_graphics != null)
            {

                //_graphics.FillRectangle(Brushes.Black, ShipCoodinates.X-20, ShipCoodinates.Y, ShipCoodinates.Width+50, ShipCoodinates.Height+5);
                //_graphics.FillRectangle(Brushes.Black, Bullet.X, Bullet.Y, Bullet.Width+2, Bullet.Height+2);

                UpdateShipLocation();
               // UpdateAmmoLocation();

                _graphics.DrawImage(ShipSprite, ShipCoodinates);

                if (_isAmmoInFlight)
                {
                    //_graphics.DrawImage(AmmoSprite, Bullet);
                    _graphics.DrawRectangle(new Pen(Color.White), Bullet);
                    _graphics.FillRectangle(_bulletColor, Bullet);
                }              
            }
        }


        private void UpdateShipLocation()
        {

            if (!_isHero)
            {
                if (ShipCoodinates.Top > _form.Height)
                {
                    _shipCoodinates.Y = 0;
                    ShipSprite = _orginalSprite;
                    IsDetroyed = false;
                }
                else
                {
                    var xLocation = ShipCoodinates.Y + ShipSpeed;
                    _shipCoodinates.Y = xLocation;
                }
            }
           
        }


        public void UpdateAmmoLocationThread()
        {
            Task.Run(UpdateAmmoLocation);
        }


        private void UpdateAmmoLocation()
        {
            while (true)
            {

                if ((Bullet.Top > -30) && _isAmmoInFlight)
                {
                    var yLocation = Bullet.Y - 30;
                    _bullet.Y = yLocation;
                }
                else
                {
                    _isAmmoInFlight = false;
                }
                Task.Delay(10).Wait();
            }

        }


        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            if (ShipCoodinates.Right > _form.Right - (ShipCoodinates.Width * 2))
            {
                _rightTimer.Stop();
            }
            else if (!IsDetroyed)
            {
                var xLocation = ShipCoodinates.X + ShipSpeed;
                _shipCoodinates.X = xLocation;
            }
        }


        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if (ShipCoodinates.Left < 0)
            {
                _leftTimer.Stop();
            }
            else if (!IsDetroyed)
            {
                var xLocation = ShipCoodinates.X - ShipSpeed;
                _shipCoodinates.X = xLocation;
            }
       
        }




        public void MoveLeft()
        {
                _rightTimer.Enabled = false;
                _leftTimer.Enabled = true;        
        }


        public void MoveRight()
        {   
                _leftTimer.Enabled = false;
                _rightTimer.Enabled = true;     
        }


        public void AllStop()
        {
            //Task.Delay(30).Wait();
            _rightTimer.Stop();
            _leftTimer.Stop();

        }



    }
}
