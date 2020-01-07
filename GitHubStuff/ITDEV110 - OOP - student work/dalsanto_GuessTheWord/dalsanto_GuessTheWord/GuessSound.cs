using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 10

namespace dalsanto_GuessTheWord
{
    class GuessSound
    {
        public GuessSound() { }

        public void PlaySound(int num)
        {
            System.Media.SoundPlayer attention = new System.Media.SoundPlayer();
            attention.SoundLocation = @".\attention.wav";

            System.Media.SoundPlayer wrong = new System.Media.SoundPlayer();
            wrong.SoundLocation = @".\wrong.wav";

            System.Media.SoundPlayer correct = new System.Media.SoundPlayer();
            correct.SoundLocation = @".\correct.wav";

            System.Media.SoundPlayer lose = new System.Media.SoundPlayer();
            lose.SoundLocation = @".\lose.wav";

            System.Media.SoundPlayer win = new System.Media.SoundPlayer();
            win.SoundLocation = @".\win.wav";

            switch (num)
            {
                case 1:
                    attention.Play();
                    num = 0;
                    break;

                case 2:
                    wrong.Play();
                    num = 0;
                    break;

                case 3:
                    correct.Play();
                    num = 0;
                    break;

                case 4:
                    lose.Play();
                    num = 0;
                    break;

                case 5:
                    win.Play();
                    num = 0;
                    break;

                default:
                    break;
            }
        }
    }
}
