using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Final

namespace dalsanto_FinalExam
{
    class FinalSound
    {
        public FinalSound() { }

        System.Media.SoundPlayer pIntro = new System.Media.SoundPlayer();

        public void playIntro()
        {
            pIntro.SoundLocation = @".\Intro.wav";
            pIntro.Play();
        }

    }
}
