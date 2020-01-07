using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 7

namespace HighLowAPP
{
    class HighLowModel
    {
        public HighLowModel() { }

        Random rnd = new Random();
        private int hlRand = 0;
        public int HLRand { get { return hlRand; } set { hlRand = value; } }

        public void resetHLRand()
        {
            hlRand = rnd.Next(1, 100);
        }

        public void playHey()
        {
            var wavHey = new System.Media.SoundPlayer();
            wavHey.SoundLocation = @".\Hey.wav";
            wavHey.PlaySync();
        }

        public void playListen()
        {
            var wavListen = new System.Media.SoundPlayer();
            wavListen.SoundLocation = @".\Listen.wav";
            wavListen.PlaySync();
        }

        public void playSecret()
        {
            var wavSecret = new System.Media.SoundPlayer();
            wavSecret.SoundLocation = @".\Secret.wav";
            wavSecret.PlaySync();
        }

        public void playUp()
        {
            var wavUp = new System.Media.SoundPlayer();
            wavUp.SoundLocation = @".\Up.wav";
            wavUp.PlaySync();
        }

        public void playDown()
        {
            var wavDown = new System.Media.SoundPlayer();
            wavDown.SoundLocation = @".\Down.wav";
            wavDown.PlaySync();
        }
    }
}
