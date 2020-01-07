using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 8

namespace HighLowAPP
{
    class HighLowModel
    {
        public HighLowModel() { }

        Random rnd = new Random();
        private int hlRand = 0;
        public int HLRand { get { return hlRand; } set { hlRand = value; } }

        public void resetHLRand(int num)
        {
            hlRand = rnd.Next(1, num);
        }

        public void playHey()
        {
            System.Media.SoundPlayer wavHey = new System.Media.SoundPlayer();
            wavHey.SoundLocation = @".\Hey.wav";
            wavHey.PlaySync();
        }

        public void playListen()
        {
            System.Media.SoundPlayer wavListen = new System.Media.SoundPlayer();
            wavListen.SoundLocation = @".\Listen.wav";
            wavListen.Play();
        }

        public void playSecret()
        {
            System.Media.SoundPlayer wavSecret = new System.Media.SoundPlayer();
            wavSecret.SoundLocation = @".\Secret.wav";
            wavSecret.Play();
        }

        public void playUp()
        {
            System.Media.SoundPlayer wavUp = new System.Media.SoundPlayer();
            wavUp.SoundLocation = @".\Up.wav";
            wavUp.Play();
        }

        public void playDown()
        {
            var wavDown = new System.Media.SoundPlayer();
            wavDown.SoundLocation = @".\Down.wav";
            wavDown.Play();
        }
    }
}
