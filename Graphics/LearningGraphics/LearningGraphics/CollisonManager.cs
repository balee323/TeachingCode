using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningGraphics
{
    class CollisonManager
    {

        private List<SpriteObj> _enemies;
        private SpriteObj _hero;
        private Form1 _form1;

        public int Score { get; set; } = 0;

        public CollisonManager(List<SpriteObj> enemies, SpriteObj hero, Form1 form1)
        {
            this._enemies = enemies;
            this._hero = hero;
            this._form1 = form1;
        }

        public void StartCollisonDetection()
        {        
            Task.Run(DetectCollisonWithShips);        
        }


        private void DetectCollisonWithShips()
        {
            while (true)
            {
                Parallel.ForEach(_enemies, EnemyHit);
                Parallel.ForEach(_enemies, CollisionWithEnemy);
                Task.Delay(50).Wait(); //this is so CPU usage doesn't get high
            }
            
         
        }

        private void CollisionWithEnemy(SpriteObj enemy)
        {
            if (enemy.ShipCoodinates.IntersectsWith(_hero.ShipCoodinates) && !enemy.IsDetroyed && !_hero.IsDetroyed)
            {
                _hero.ShipSprite = Image.FromFile("asserts\\Explosion.png");
                _hero.IsDetroyed = true;
                _form1.PlayExplosionSound();
            }
        }

        private void EnemyHit(SpriteObj enemy)
        {
            if (enemy.ShipCoodinates.IntersectsWith(_hero.Bullet) && !enemy.IsDetroyed)
            {
                enemy.ShipSprite = Image.FromFile("asserts\\Explosion.png");
                enemy.IsDetroyed = true;
                _form1.PlayExplosionSound();
                Score += 500;
        
            }
        }



    }
}
