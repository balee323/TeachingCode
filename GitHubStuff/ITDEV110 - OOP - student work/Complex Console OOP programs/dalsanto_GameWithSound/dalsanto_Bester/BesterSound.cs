using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 9

namespace dalsanto_Bester
{
    class BesterSound
    {
        public BesterSound() { }

        public void playPRoll()
        {
            System.Media.SoundPlayer pRoll = new System.Media.SoundPlayer();
            pRoll.SoundLocation = @".\PRoll.wav";
            pRoll.Play();
        }

        public void playCRoll()
        {
            System.Media.SoundPlayer cRoll = new System.Media.SoundPlayer();
            cRoll.SoundLocation = @".\CRoll.wav";
            cRoll.Play();
        }

        public void playPwin()
        {
            System.Media.SoundPlayer pWin = new System.Media.SoundPlayer();
            pWin.SoundLocation = @".\Pwin.wav";
            pWin.Play();
        }

        public void playCwin()
        {
            System.Media.SoundPlayer cWin = new System.Media.SoundPlayer();
            cWin.SoundLocation = @".\Cwin.wav";
            cWin.Play();
        }

        public void playStart()
        {
            System.Media.SoundPlayer Start = new System.Media.SoundPlayer();
            Start.SoundLocation = @".\Start.wav";
            Start.Play();
        }
    }
}
