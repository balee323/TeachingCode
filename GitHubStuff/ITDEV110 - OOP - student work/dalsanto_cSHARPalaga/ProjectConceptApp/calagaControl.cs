using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cSHARPalaga
{
    //Updated 12/16/2017

    class calagaControl
    {
        public calagaControl() { }

        calagaModel cModel = new calagaModel();
        calagaView cView = new calagaView();
        calagaSound cSound = new calagaSound();

        private int runOn = 1;
        public int RunOn { get { return runOn; } set { runOn = value; } }
        private int fps = 0;
        public int Fps { get { return fps; } set { fps = value; } }
        private int maxFps = 0;
        public int MaxFps { get { return maxFps; } set { maxFps = value; } }
        private int maximizeOn = 0;
        public int MaximizeOn { get { return maximizeOn; } set { maximizeOn = value; } }
        private int keyOn = 1;
        public int KeyOn { get { return keyOn; } set { keyOn = value; } }
        private int doKey = 0;
        public int DoKey { get { return doKey; } set { doKey = value; } }
        private int keyLock = 0;
        public int KeyLock { get { return keyLock; } set { keyLock = value; } }
        private int pMoveX = 0;
        public int PMoveX { get { return pMoveX; } set { pMoveX = value; } }
        private int pMoveY = 0;
        public int PMoveY { get { return pMoveY; } set { pMoveY = value; } }


        public void mainLoop()
        {
            cSound.PlaySound(8);
            cModel.BorderX = Console.WindowWidth;
            cModel.BorderY = Console.WindowHeight;
            cView.drawIntro();
            ForceMaximize();
            cModel.setKeyLockTimer();
            KeyLock = 1;
            DoKey = 0;
            Console.Clear();
            MainMenu();

            while (RunOn == 1)
            {
                if (cModel.timerCheck(cModel.KeyTimer, cModel.KeyDelay)) { KeyLock = 0; }
                if (DoKey > 0 && KeyLock == 0)
                {
                    //Arrow Keys - Player Move
                    if (DoKey == 1 && cModel.timerCheck(cModel.PMoveTimer, cModel.PCurMoveSpeed))
                    {
                        //Player Boundry Check
                        if (cModel.checkBorder(cModel.PX + 4, cModel.PY))
                        {
                            PMoveX = -2;
                            PMoveY = 0;
                        }
                        if (cModel.checkBorder(cModel.PX, cModel.PY + 3))
                        {
                            PMoveX = 0;
                            PMoveY = -1;
                        }
                        if (cModel.PX <= 3)
                        {
                            PMoveX = 2;
                            PMoveY = 0;
                        }
                        if (cModel.PY <= 2)
                        {
                            PMoveX = 0;
                            PMoveY = 1;
                        }
                        //Player Enemy Collision
                        cModel.TempInt = cModel.checkPonECollision();
                        //If Player Collides With Enemy
                        if (cModel.TempInt > -1 && cModel.Enemy[cModel.TempInt] > 0 && cModel.Enemy[cModel.TempInt] < 10)
                        {
                            cModel.ECol[cModel.TempInt] = 4;
                            cModel.PCol = 1;
                            cModel.PlayerHealth = cModel.PlayerHealth - 10;
                        }
                        //If Player Collides with Spread
                        if (cModel.TempInt > -1 && cModel.Enemy[cModel.TempInt] == 11)
                        {
                            cModel.PUpSpread++;
                            cSound.PlaySound(13);
                            Thread.Sleep(10);
                            cModel.ECol[cModel.TempInt] = 10;
                        }
                        //If Player Collides with Health
                        if (cModel.TempInt > -1 && cModel.Enemy[cModel.TempInt] == 12)
                        {
                            cModel.PlayerHealth = cModel.PlayerHealth + 10;
                            if (cModel.PlayerHealth > 100) { cModel.PlayerHealth = 100; }
                            cView.drawPlayerHealth(cModel.PlayerHealth);
                            cSound.PlaySound(11);
                            Thread.Sleep(10);
                            cModel.ECol[cModel.TempInt] = 10;
                        }
                        //If Player Collides with Explosive Shot
                        if (cModel.TempInt > -1 && cModel.Enemy[cModel.TempInt] == 13)
                        {
                            cModel.PUpExp++;
                            cSound.PlaySound(13);
                            Thread.Sleep(10);
                            cModel.ECol[cModel.TempInt] = 10;
                        }
                        //Player Move
                        cView.clearPlayer(cModel.PX, cModel.PY);
                        cModel.playerMove(PMoveX, PMoveY);
                        cView.drawPlayer(cModel.PX, cModel.PY);
                        PMoveX = 0;
                        PMoveY = 0;
                    }
                    //Q - Player Shoot
                    if (DoKey == 2 && cModel.timerCheck(cModel.PShootTimer, cModel.PCurShootSpeed))
                    {
                        cModel.PShoot = 1;
                    }
                    if (DoKey == 3)
                    {
                        if (cModel.PlayerHealth > 20)
                        {
                            cModel.pWBomb();
                            cModel.PlayerHealth = cModel.PlayerHealth - 20;
                            if (cModel.PlayerHealth < 20) { cModel.PlayerHealth = 20; }
                            cModel.PCol = 1;
                            cSound.PlaySound(7);
                            Thread.Sleep(300);
                        }
                    }
                    if (DoKey == 4)
                    {
                        if (cModel.PUpSpread == 0) { cModel.PUpSpread = 1; }
                        else { cModel.PUpSpread = 0; }
                        cSound.PlaySound(13);
                        Thread.Sleep(10);
                    }
                    if (DoKey == 5)
                    {
                        if (cModel.PUpAuto == 0)
                        {
                            cModel.PUpAuto = 1;
                            cModel.PCurShootSpeed = cModel.PCurShootSpeed * 3;
                            cModel.PCurProjSpeed = cModel.PCurProjSpeed * 3;
                        }
                        else
                        {
                            cModel.PUpAuto = 0;
                            cModel.PCurShootSpeed = cModel.PCurShootSpeed / 3;
                            cModel.PCurProjSpeed = cModel.PCurProjSpeed / 3;
                        }
                        cSound.PlaySound(12);
                        Thread.Sleep(10);
                    }
                    if (DoKey == 10)
                    {
                        cSound.PlaySound(14);
                        cModel.setKeyLockTimer();
                        KeyLock = 1;
                        DoKey = 0;
                        PauseMenu();
                        if (RunOn == 0) { break; }
                    }
                    cModel.setKeyLockTimer();
                    KeyLock = 1;
                    DoKey = 0;
                }//end Key Listener Do

                //Player Projectile Loop
                //Player Projectile Movement
                if (cModel.PShoot == 1 || 
                    (cModel.timerCheck(cModel.PShootTimer, cModel.PCurShootSpeed) && cModel.PUpAuto == 1))
                {
                    if (cModel.PUpAuto == 1) { cModel.pProjBurst(cModel.PX, cModel.PY, 2); }
                    else { cModel.playerShoot(cModel.PX, cModel.PY - 2, -1, 0, -1, 100); }
                    if (cModel.PUpSpread > 0 && cModel.PUpAuto == 0)
                    {
                        cModel.playerShoot(cModel.PX, cModel.PY - 2, cModel.PX - 4, 0, -1, 100);
                        cModel.playerShoot(cModel.PX, cModel.PY - 2, cModel.PX + 4, 0, -1, 100);
                        if (cModel.PUpSpread > 1)
                        {
                            cModel.playerShoot(cModel.PX - 2, cModel.PY - 1, cModel.PX - 8, 0, -1, 100);
                            cModel.playerShoot(cModel.PX + 2, cModel.PY - 1, cModel.PX + 8, 0, -1, 100);
                        }
                    }
                    cModel.PShoot = 0;
                }
                for (int i = 0; i < cModel.ProjP.Length; i++)
                {
                    if (cModel.ProjP[i] == 1 && cModel.timerCheck(cModel.PProjTimer[i], cModel.PProjSpeed[i]))
                    {
                        cModel.TempInt = cModel.checkECollision(cModel.ProjPX[i], cModel.ProjPY[i], -1);
                        //PProj Collide with Enemy
                        if (cModel.TempInt > -1)
                        {
                            cModel.ECol[cModel.TempInt] = 3;
                            cView.clearProj(cModel.ProjPX[i], cModel.ProjPY[i]);
                            cModel.killProjP(i);
                        }
                        else
                        {
                            cView.clearProj(cModel.ProjPX[i], cModel.ProjPY[i]);
                            cModel.pProjMove(i);
                            if (cModel.ProjP[i] == 1)
                            {
                                cView.drawProj(cModel.ProjPX[i], cModel.ProjPY[i], 1);
                                cModel.playerProjectiles(i);
                            }
                        }
                    }
                }

                //Enemy Loop
                //Enemy Collision
                for (int i = 0; i < cModel.ECol.Length; i++)
                {
                    cModel.enemySpawn(i);
                    //Enemy Move
                    if (cModel.Enemy[i] > 0 && cModel.timerCheck(cModel.EMoveTimer[i], cModel.EMoveSpeed[i]))
                    {
                        cView.clearEnemy(cModel.EX[i], cModel.EY[i]);
                        cModel.enemyMoveDir(i);
                        if (cModel.Enemy[i] == 1) { cView.drawEnemy(cModel.EX[i], cModel.EY[i]); }
                        if (cModel.Enemy[i] == 11) { cView.drawPUpSpread(cModel.EX[i], cModel.EY[i]); }
                        if (cModel.Enemy[i] == 12) { cView.drawPUpHealth(cModel.EX[i], cModel.EY[i]); }
                        if (cModel.Enemy[i] == 13) { cView.drawPUpExp(cModel.EX[i], cModel.EY[i]); }
                    }
                    //Enemy Shoot
                    if (cModel.Enemy[i] > 0 && cModel.Enemy[i] < 10 && cModel.timerCheck(cModel.EShootTimer[i], cModel.EShootSpeed[i]))
                    {
                        cModel.enemyShoot(0, 2, i, 0, 1);
                    }
                    //Enemy Collision
                    if (cModel.ECol[i] > 0)
                    {
                        if (cModel.ECol[i] == 2) { cSound.PlaySound(16); }//Enemy & Enemy Collision
                        if (cModel.ECol[i] == 3) { cSound.PlaySound(17); }//Player Projectile & Enemy Collision
                        if (cModel.ECol[i] == 4) { cSound.PlaySound(17); }//Player & Enemy Collision
                        cModel.PScore++;
                        cView.drawTop(cModel.PScore, cModel.PUpSpread, cModel.PUpExp);
                        cView.clearEnemy(cModel.EX[i], cModel.EY[i]);
                        cView.drawPlayer(cModel.PX, cModel.PY);
                        cModel.EColCount++;
                        if (cModel.ECol[i] == 2) { cModel.eProjBurst(i); }
                        if (cModel.PUpExp > 0 && cModel.Enemy[i] < 10 && cModel.ECol[i] == 3)
                        { cModel.pProjBurst(cModel.EX[i], cModel.EY[i], 100); }
                        cModel.killEnemy(i);
                        //Redraw Actors
                        for (int i2 = 0; i2 < cModel.Enemy.Length; i2++)
                        {
                            if (cModel.Enemy[i] == 1) { cView.drawEnemy(cModel.EX[i], cModel.EY[i]); }
                            if (cModel.Enemy[i] == 11) { cView.drawPUpSpread(cModel.EX[i], cModel.EY[i]); }
                            if (cModel.Enemy[i] == 12) { cView.drawPUpHealth(cModel.EX[i], cModel.EY[i]); }
                            if (cModel.Enemy[i] == 13) { cView.drawPUpExp(cModel.EX[i], cModel.EY[i]); }
                        }
                    }
                }

                //Enemy Projectile Loop
                //Enemy Projectile Movement
                for (int i = 0; i < cModel.ProjE.Length; i++)
                {
                    if (cModel.ProjE[i] == 1 && cModel.timerCheck(cModel.EProjTimer[i], cModel.EProjSpeed[i]))
                    {
                        if (cModel.checkPCollision(cModel.ProjEX[i], cModel.ProjEY[i]))
                        {
                            cModel.PCol = 1;
                            cModel.PlayerHealth = cModel.PlayerHealth - 2;
                            cView.clearProj(cModel.ProjEX[i], cModel.ProjEY[i]);
                            cModel.killProjE(i);
                        }
                        else
                        {
                            cView.clearProj(cModel.ProjEX[i], cModel.ProjEY[i]);
                            cModel.enemyProjMove(i);
                            if (cModel.ProjE[i] == 1)
                            {
                                cView.drawProj(cModel.ProjEX[i], cModel.ProjEY[i], 2);
                                cModel.enemyProjectiles(i);
                            }
                        }
                        //redraw after Enemy Collison
                        cModel.TempInt = cModel.checkECollision(cModel.ProjEX[i], cModel.ProjEY[i], -1);
                        if (cModel.TempInt > -1 && cModel.Enemy[cModel.TempInt] == 1)
                        {
                            cView.drawEnemy(cModel.EX[cModel.TempInt], cModel.EY[cModel.TempInt]);
                        }
                    }
                }

                //Player Collision
                if (cModel.PCol == 1)
                {
                    cView.drawPlayer(cModel.PX, cModel.PY);
                    cModel.PCol = 0;
                    cModel.PColCount++;
                    cView.drawTop(cModel.PScore, cModel.PUpSpread, cModel.PUpExp);
                    cView.drawPlayerHealth(cModel.PlayerHealth);
                    if (cModel.PlayerHealth < 20 && cModel.PlayerHealth > 0 && cModel.PLowHealth == 0)
                    { cSound.PlaySound(18); cModel.PLowHealth = 1; Thread.Sleep(100); }
                    //Player Death
                    if (cModel.PlayerHealth < 1)
                    {
                        cSound.PlaySound(9);
                        Thread.Sleep(700);
                        RedrawAll();
                        cView.drawBoom(cModel.PX, cModel.PY);
                        cModel.Restart();
                        cModel.setKeyLockTimer();
                        KeyLock = 1;
                        DoKey = 0;
                        cSound.PlaySound(10);
                        Thread.Sleep(2000);
                        cSound.PlaySound(8);
                        MainMenu();
                    }
                }//end Player Collision

            }//end mainLoop while
        }//end mainLoop

        public void PauseMenu()
        {
            cModel.Pause = 1;
            cModel.MenuSel = 1;
            ScreenCheck();
            cView.drawPMenu();
            Thread.Sleep(400);
            cSound.PlaySound(100);
            while (cModel.Pause == 1)
            {
                ScreenCheck();
                cView.menuAnim(cModel.MenuSel);
                if (cModel.timerCheck(cModel.KeyTimer, cModel.KeyDelay)) { KeyLock = 0; }
                if (DoKey > 0 && KeyLock == 0)
                {
                    if (DoKey == 1)
                    {
                        //up
                        if (PMoveY == -1)
                        {
                            PMoveX = 0;
                            PMoveY = 0;
                            if (cModel.MenuSel < 4 && cModel.MenuSel > 1) { cModel.MenuSel--; }
                            else if (cModel.MenuSel == 1) { cModel.MenuSel = 3; }
                            ScreenCheck();
                            cView.drawPMenuSel(cModel.MenuSel);
                            Console.Beep(600, 30);
                            Thread.Sleep(50);
                        }
                        //down
                        if (PMoveY == 1)
                        {
                            PMoveX = 0;
                            PMoveY = 0;
                            if (cModel.MenuSel < 3 && cModel.MenuSel > 0) { cModel.MenuSel++; }
                            else if (cModel.MenuSel == 3) { cModel.MenuSel = 1; }
                            ScreenCheck();
                            cView.drawPMenuSel(cModel.MenuSel);
                            Console.Beep(600, 30);
                            Thread.Sleep(50);
                        }
                        //right
                        if (PMoveX == 2)
                        {
                            PMoveX = 0;
                        }
                        //left
                        if (PMoveX == -2)
                        {
                            PMoveX = 0;
                        }
                    }
                    //enter
                    if (DoKey == 9)
                    {
                        //Continue
                        if (cModel.MenuSel == 1)
                        {
                            cSound.PlaySound(15);
                            cModel.Pause = 0;
                            RedrawAll();
                            break;
                        }
                        //Restart
                        if (cModel.MenuSel == 2)
                        {
                            cModel.Pause = 0;
                            cModel.Restart();
                            RedrawAll();
                            cModel.setKeyLockTimer();
                            KeyLock = 1;
                            DoKey = 0;
                            cSound.PlaySound(8);
                            MainMenu();
                            break;
                        }
                        //Quit
                        if (cModel.MenuSel == 3)
                        {
                            cSound.PlaySound(15);
                            cModel.Pause = 0;
                            KeyOn = 0;
                            RunOn = 0;
                            ScreenCheck();
                            cView.drawQuit();
                            break;
                        }
                    }
                    //Escape
                    if (DoKey == 10)
                    {
                        cSound.PlaySound(15);
                        cModel.Pause = 0;
                        RedrawAll();
                        break;
                    }
                    cModel.setKeyLockTimer();
                    KeyLock = 1;
                    DoKey = 0;
                }
            }//Pause Menu Loop
        }//Pause Menu

        public void MainMenu()
        {
            cModel.MainMenu = 1;
            cModel.MenuSel = 1;
            ScreenCheck();
            if (maximizeOn == 0) { cView.drawLogoMin(); }
            if (maximizeOn == 1) { cView.drawLogoMax(); }
            cView.drawMMenu(cModel.CurDifficulty, MaximizeOn);
            while (cModel.MainMenu == 1)
            {
                ScreenCheck();
                cView.menuAnim(cModel.MenuSel);
                if (cModel.timerCheck(cModel.KeyTimer, cModel.KeyDelay)) { KeyLock = 0; }
                if (DoKey > 0 && KeyLock == 0)
                {
                    if (DoKey == 1)
                    {
                        //up
                        if (PMoveY == -1)
                        {
                            PMoveX = 0;
                            PMoveY = 0;
                            if (cModel.MenuSel < 4 && cModel.MenuSel > 1) { cModel.MenuSel--; }
                            else if (cModel.MenuSel == 1) { cModel.MenuSel = 3; }
                            ScreenCheck();
                            cView.drawMMenuSel(cModel.MenuSel, cModel.CurDifficulty, MaximizeOn);
                            Console.Beep(600, 30);
                            Thread.Sleep(50);
                        }
                        //down
                        if (PMoveY == 1)
                        {
                            PMoveX = 0;
                            PMoveY = 0;
                            if (cModel.MenuSel < 3 && cModel.MenuSel > 0) { cModel.MenuSel++; }
                            else if (cModel.MenuSel == 3) { cModel.MenuSel = 1; }
                            ScreenCheck();
                            cView.drawMMenuSel(cModel.MenuSel, cModel.CurDifficulty, MaximizeOn);
                            Console.Beep(600, 30);
                            Thread.Sleep(50);
                        }
                        //right -Difficulty
                        if (PMoveX == 2 && cModel.MenuSel == 2)
                        {
                            PMoveX = 0;
                            if (cModel.CurDifficulty < 3 && cModel.CurDifficulty > 0) { cModel.CurDifficulty++; }
                            else if (cModel.CurDifficulty == 3) { cModel.CurDifficulty = 1; }
                            ScreenCheck();
                            cView.drawMMenuSel(cModel.MenuSel, cModel.CurDifficulty, MaximizeOn);
                            Console.Beep(600, 30);
                            Thread.Sleep(50);
                        }
                        //left -Difficulty
                        if (PMoveX == -2 && cModel.MenuSel == 2)
                        {
                            PMoveX = 0;
                            if (cModel.CurDifficulty < 4 && cModel.CurDifficulty > 1) { cModel.CurDifficulty--; }
                            else if (cModel.CurDifficulty == 1) { cModel.CurDifficulty = 3; }
                            ScreenCheck();
                            cView.drawMMenuSel(cModel.MenuSel, cModel.CurDifficulty, MaximizeOn);
                            Console.Beep(600, 30);
                            Thread.Sleep(50);
                        }
                    }
                    //enter
                    if (DoKey == 9)
                    {
                        //New Game
                        if (cModel.MenuSel == 1)
                        {
                            cModel.MainMenu = 0;
                            RedrawAll();
                            cSound.PlaySound(5);
                            break;
                        }
                        //Difficulty
                        if (cModel.MenuSel == 2)
                        {

                        }
                        //Quit
                        if (cModel.MenuSel == 3)
                        {
                            cSound.PlaySound(15);
                            cModel.MainMenu = 0;
                            KeyOn = 0;
                            RunOn = 0;
                            cView.drawQuit();
                            break;
                        }
                    }
                    cModel.setKeyLockTimer();
                    KeyLock = 1;
                    DoKey = 0;
                }
            }//Main Menu Loop
        }//Main Menu

        public void RedrawAll()
        {
            Console.Clear();
            cView.drawPlayer(cModel.PX, cModel.PY);
            cView.drawPlayerHealth(cModel.PlayerHealth);
            cView.drawTop(cModel.PScore, cModel.PUpSpread, cModel.PUpExp);
            for (int i = 0; i < cModel.ProjP.Length; i++)
            {
                if (cModel.ProjP[i] == 1)
                {
                    cView.drawProj(cModel.ProjPX[i], cModel.ProjPY[i], 1);
                }
            }
            for (int i2 = 0; i2 < cModel.ProjE.Length; i2++)
            {
                if (cModel.ProjE[i2] == 1)
                {
                    cView.drawProj(cModel.ProjEX[i2], cModel.ProjEY[i2], 2);
                }
            }
            for (int i3 = 0; i3 < cModel.Enemy.Length; i3++)
            {
                if (cModel.Enemy[i3] == 1) { cView.drawEnemy(cModel.EX[i3], cModel.EY[i3]); }
                if (cModel.Enemy[i3] == 11) { cView.drawPUpSpread(cModel.EX[i3], cModel.EY[i3]); }
                if (cModel.Enemy[i3] == 12) { cView.drawPUpHealth(cModel.EX[i3], cModel.EY[i3]); }
                if (cModel.Enemy[i3] == 13) { cView.drawPUpExp(cModel.EX[i3], cModel.EY[i3]); }
            }
            if (cModel.Pause == 1)
            {
                cView.drawPMenu();
                cView.drawPMenuSel(cModel.MenuSel);
            }
            if (cModel.MainMenu == 1)
            {
                if (maximizeOn == 0) { cView.drawLogoMin(); }
                if (maximizeOn == 1) { cView.drawLogoMax(); }
                cView.drawMMenu(cModel.CurDifficulty, MaximizeOn);
                cView.drawMMenuSel(cModel.MenuSel, cModel.CurDifficulty, MaximizeOn);
            }
        }

        public void ForceMaximize()
        {
            while (maximizeOn == 0)
            {
                ScreenCheck();
                if (DoKey == 10) { break; }
            }
        }

        public void ScreenCheck()
        {
            if (cModel.BorderX != Console.WindowWidth)
            {
                if (maximizeOn == 0) { maximizeOn = 1; }
                else { maximizeOn = 0; }
                cModel.ChangeBorders();
                RedrawAll();
            }
            else if (cModel.BorderY != Console.WindowHeight)
            {
                if (maximizeOn == 0) { maximizeOn = 1; }
                else { maximizeOn = 0; }
                cModel.ChangeBorders();
                RedrawAll();
            }
        }//end ScreenCheck

    }//end class
}//end namespace
