using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace cSHARPalaga
{
    //Updated 12/16/2017

    class calagaSound
    {
        public calagaSound() { }

        public void PlaySound(int selectSound)
        {
            System.Media.SoundPlayer wavpShoot = new System.Media.SoundPlayer();
            wavpShoot.SoundLocation = @".\pShoot.wav";

            System.Media.SoundPlayer waveShoot = new System.Media.SoundPlayer();
            waveShoot.SoundLocation = @".\eShoot.wav";

            System.Media.SoundPlayer wavBip = new System.Media.SoundPlayer();
            wavBip.SoundLocation = @".\bip.wav";

            System.Media.SoundPlayer wavBoom1 = new System.Media.SoundPlayer();
            wavBoom1.SoundLocation = @".\boom1.wav";

            System.Media.SoundPlayer wavMenuSelect = new System.Media.SoundPlayer();
            wavMenuSelect.SoundLocation = @".\menuSelect.wav";

            System.Media.SoundPlayer wavMenuMove = new System.Media.SoundPlayer();
            wavMenuMove.SoundLocation = @".\menuMove.wav";

            System.Media.SoundPlayer wavProjBurst = new System.Media.SoundPlayer();
            wavProjBurst.SoundLocation = @".\projBurst.wav";

            System.Media.SoundPlayer wavRebelTheme = new System.Media.SoundPlayer();
            wavRebelTheme.SoundLocation = @".\SpaceMusic2.wav";

            System.Media.SoundPlayer wavPlayerDead = new System.Media.SoundPlayer();
            wavPlayerDead.SoundLocation = @".\playerDead.wav";

            System.Media.SoundPlayer wavPBoom = new System.Media.SoundPlayer();
            wavPBoom.SoundLocation = @".\pBoom.wav";

            System.Media.SoundPlayer wavPowerupPHealth = new System.Media.SoundPlayer();
            wavPowerupPHealth.SoundLocation = @".\powerupPHealth.wav";

            System.Media.SoundPlayer wavPowerupPAuto = new System.Media.SoundPlayer();
            wavPowerupPAuto.SoundLocation = @".\powerupPAuto.wav";

            System.Media.SoundPlayer wavPowerupPSpread = new System.Media.SoundPlayer();
            wavPowerupPSpread.SoundLocation = @".\powerupPSpread.wav";

            System.Media.SoundPlayer wavSelectOn = new System.Media.SoundPlayer();
            wavSelectOn.SoundLocation = @".\selectOn.wav";

            System.Media.SoundPlayer wavSelectOff = new System.Media.SoundPlayer();
            wavSelectOff.SoundLocation = @".\selectOff.wav";

            System.Media.SoundPlayer wavECollide = new System.Media.SoundPlayer();
            wavECollide.SoundLocation = @".\eCollide.wav";

            System.Media.SoundPlayer wavBoom2 = new System.Media.SoundPlayer();
            wavBoom2.SoundLocation = @".\boom2.wav";

            System.Media.SoundPlayer wavLowHealth = new System.Media.SoundPlayer();
            wavLowHealth.SoundLocation = @".\lowHealth.wav";

            System.Media.SoundPlayer wavSilence = new System.Media.SoundPlayer();
            wavSilence.SoundLocation = @".\silence.wav";

            wavpShoot.Stop();
            waveShoot.Stop();
            wavBip.Stop();
            wavBoom1.Stop();
            wavMenuSelect.Stop();
            wavMenuMove.Stop();
            wavProjBurst.Stop();
            wavRebelTheme.Stop();
            wavPlayerDead.Stop();
            wavPBoom.Stop();
            wavPowerupPHealth.Stop();
            wavPowerupPAuto.Stop();
            wavPowerupPSpread.Stop();
            wavSelectOn.Stop();
            wavSelectOff.Stop();
            wavECollide.Stop();
            wavBoom2.Stop();
            wavLowHealth.Stop();
            wavSilence.Stop();

            switch (selectSound)
            {
                case 1:
                    wavpShoot.Play();
                    selectSound = 0;
                    break;

                case 2:
                    waveShoot.Play();
                    selectSound = 0;
                    break;

                case 3:
                    wavBip.Play();
                    selectSound = 0;
                    break;

                case 4:
                    wavBoom1.Play();
                    selectSound = 0;
                    break;

                case 5:
                    wavMenuSelect.Play();
                    selectSound = 0;
                    break;

                case 6:
                    wavMenuMove.Play();
                    selectSound = 0;
                    break;

                case 7:
                    wavProjBurst.Play();
                    selectSound = 0;
                    break;

                case 8:
                    wavRebelTheme.PlayLooping();
                    selectSound = 0;
                    break;

                case 9:
                    wavPlayerDead.Play();
                    selectSound = 0;
                    break;

                case 10:
                    wavPBoom.Play();
                    selectSound = 0;
                    break;

                case 11:
                    wavPowerupPHealth.Play();
                    selectSound = 0;
                    break;

                case 12:
                    wavPowerupPAuto.Play();
                    selectSound = 0;
                    break;

                case 13:
                    wavPowerupPSpread.Play();
                    selectSound = 0;
                    break;

                case 14:
                    wavSelectOn.Play();
                    selectSound = 0;
                    break;

                case 15:
                    wavSelectOff.Play();
                    selectSound = 0;
                    break;

                case 16:
                    wavECollide.Play();
                    selectSound = 0;
                    break;

                case 17:
                    wavBoom2.Play();
                    selectSound = 0;
                    break;

                case 18:
                    wavLowHealth.Play();
                    selectSound = 0;
                    break;

                case 100:
                    wavSilence.PlayLooping();
                    selectSound = 0;
                    break;

                default:
                    break;
            }
        }//end PlaySound

    }
}
