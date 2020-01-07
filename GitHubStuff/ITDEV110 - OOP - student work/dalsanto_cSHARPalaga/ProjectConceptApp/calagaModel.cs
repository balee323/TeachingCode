using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cSHARPalaga
{
    //Updated 12/16/2017

    class calagaModel
    {
        public calagaModel() { }

        Random rnd = new Random();
        DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        //Loop Init
        private int keyDelay = 1;
        public int KeyDelay { get{ return keyDelay; } set { keyDelay = value; } }
        private int tempInt = 0;
        public int TempInt { get { return tempInt; } set { tempInt = value; } }

        //Switches
        private int pause = 0;
        public int Pause { get { return pause; } set { pause = value; } }
        private int mainMenu = 0;
        public int MainMenu { get { return mainMenu; } set { mainMenu = value; } }
        private int pLowHealth = 0;
        public int PLowHealth { get { return pLowHealth; } set { pLowHealth = value; } }
        private int pShoot = 0;
        public int PShoot { get { return pShoot; } set { pShoot = value; } }
        private int pUpSpread = 0;
        public int PUpSpread { get { return pUpSpread; } set { pUpSpread = value; } }
        private int pUpExp = 0;
        public int PUpExp { get { return pUpExp; } set { pUpExp = value; } }
        private int pUpAuto = 0;
        public int PUpAuto { get { return pUpAuto; } set { pUpAuto = value; } }

        //Array Sizes & Constants
        //-max player projectiles
        private static int pMaxProj = 50;
        public int PMaxProj { get { return pMaxProj; } set { pMaxProj = value; } }
        //-max enemy projectiles
        private static int eMaxProj = 100;
        public int EMaxProj { get { return eMaxProj; } set { eMaxProj = value; } }
        //-max enemies
        private static int eMax = 10;
        public int EMax { get { return eMax; } set { eMax = value; } }

        private static int conDifficulty = 1;
        public int ConDifficulty { get { return conDifficulty; } set { conDifficulty = value; } }
        private int pUpSpawn = 5;
        public int PUpSpawn { get { return pUpSpawn; } set { pUpSpawn = value; } }

        private static int pConProjSpeed = 15;
        public int PConProjSpeed { get { return pConProjSpeed; } set { pConProjSpeed = value; } }
        private static int pConShootSpeed = 100;
        public int PConShootSpeed { get { return pConShootSpeed; } set { pConShootSpeed = value; } }
        private static int pConMoveSpeed = 1;
        public int PConMoveSpeed { get { return pConMoveSpeed; } set { pConMoveSpeed = value; } }

        private static int eConProjSpeed = 50;
        public int EConProjSpeed { get { return eConProjSpeed; } set { eConProjSpeed = value; } }
        private static int eConShootSpeed = 1000;
        public int EConShootSpeed { get { return eConShootSpeed; } set { eConShootSpeed = value; } }
        private static int eConMoveSpeed = 300;
        public int EConMoveSpeed { get { return eConMoveSpeed; } set { eConMoveSpeed = value; } }
        private static int eConSpawnSpeed = 1000;
        public int EConSpawnSpeed { get { return eConSpawnSpeed; } set { eConSpawnSpeed = value; } }

        //Game Settings
        private int curDifficulty = conDifficulty;
        public int CurDifficulty { get { return curDifficulty; } set { curDifficulty = value; } }

        //XY Coords
        //-border
        private int borderX = 0;
        public int BorderX { get { return borderX; } set { borderX = value; } }
        private int borderY = 0;
        public int BorderY { get { return borderY; } set { borderY = value; } }

        //-player
        private int pX = (Console.WindowWidth - 1) / 2;
        public int PX { get { return pX; } set { pX = value; } }
        private int pY = Console.WindowHeight - 4;
        public int PY { get { return pY; } set { pY = value; } }

        //-enemny
        private int[] eX = new int[eMax];
        public int[] EX { get { return eX; } set { eX = value; } }
        private int[] eY = new int[eMax];
        public int[] EY { get { return eY; } set { eY = value; } }
        //-player projectile
        private int[] projPX = new int[pMaxProj];
        public int[] ProjPX { get { return projPX; } set { projPX = value; } }
        private int[] projPY = new int[pMaxProj];
        public int[] ProjPY { get { return projPY; } set { projPY = value; } }
        private int[] projTarPX = new int[pMaxProj];
        public int[] ProjTarPX { get { return projTarPX; } set { projTarPX = value; } }
        private int[] projFixPX = new int[eMaxProj];
        public int[] ProjFixPX { get { return projFixPX; } set { projFixPX = value; } }
        private int[] projFixPY = new int[eMaxProj];
        public int[] ProjFixPY { get { return projFixPY; } set { projFixPY = value; } }

        //-enemy projectile
        private int[] projEX = new int[eMaxProj];
        public int[] ProjEX { get { return projEX; } set { projEX = value; } }
        private int[] projEY = new int[eMaxProj];
        public int[] ProjEY { get { return projEY; } set { projEY = value; } }
        private int[] projTarEX = new int[eMaxProj];
        public int[] ProjTarEX { get { return projTarEX; } set { projTarEX = value; } }
        private int[] projFixEX = new int[eMaxProj];
        public int[] ProjFixEX { get { return projFixEX; } set { projFixEX = value; } }
        private int[] projFixEY = new int[eMaxProj];
        public int[] ProjFixEY { get { return projFixEY; } set { projFixEY = value; } }

        //Actors
        //-player stats
        private int playerHealth = 100;
        public int PlayerHealth { get { return playerHealth; } set { playerHealth = value; } }
        private int pScore = 0;
        public int PScore { get { return pScore; } set { pScore = value; } }
        //-player projectile
        private int[] projP = new int[pMaxProj];
        public int[] ProjP { get { return projP; } set { projP = value; } }

        private int[] projPMove = new int[pMaxProj];
        public int[] ProjPMove { get { return projPMove; } set { projPMove = value; } }
        //-enemy
        private int[] enemy = new int[eMax];
        public int[] Enemy { get { return enemy; } set { enemy = value; } }

        private int[] eMoveDirX = new int[eMax];
        public int[] EMoveDirX { get { return eMoveDirX; } set { eMoveDirX = value; } }
        private int[] eMoveDirY = new int[eMax];
        public int[] EMoveDirY { get { return eMoveDirY; } set { eMoveDirY = value; } }
        private int[] eMoveDur = new int[eMax];
        public int[] EMoveDur { get { return eMoveDur; } set { eMoveDur = value; } }

        //-enemy projectile
        private int[] projE = new int[eMaxProj];
        public int[] ProjE { get { return projE; } set { projE = value; } }

        private int[] projEMove = new int[eMaxProj];
        public int[] ProjEMove { get { return projEMove; } set { projEMove = value; } }

        //Actor Collision
        private int[] eCol = new int[eMax];
        public int[] ECol { get { return eCol; } set { eCol = value; } }
        private int pCol = 0;
        public int PCol { get { return pCol; } set { pCol = value; } }


        //Actor Limits
        //-max player projectiles
        private int pCurMaxProj = pMaxProj;
        public int PCurMaxProj { get { return pCurMaxProj; } set { pCurMaxProj = value; } }
        //-max enemy projectiles
        private int eCurMaxProj = pMaxProj;
        public int ECurMaxProj { get { return eCurMaxProj; } set { eCurMaxProj = value; } }
        //-max enemies
        private int eCurMax = eMax;
        public int ECurMax { get { return eCurMax; } set { eCurMax = value; } }

        //Counters
        private int eColCount = 0;
        public int EColCount { get { return eColCount; } set { eColCount = value; } }
        private int pColCount = 0;
        public int PColCount { get { return pColCount; } set { pColCount = value; } }
        private int menuSel = 1;
        public int MenuSel { get { return menuSel; } set { menuSel = value; } }


        //Timers & Limiters
        //-keyboard listener limiter
        private double keyTimer = 0;
        public double KeyTimer { get { return keyTimer; } set { keyTimer = value; } }
        //-player move
        private double pMoveTimer = 0;
        public double PMoveTimer { get { return pMoveTimer; } set { pMoveTimer = value; } }
        private int pCurMoveSpeed = pConMoveSpeed;
        public int PCurMoveSpeed { get { return pCurMoveSpeed; } set { pCurMoveSpeed = value; } }
        //-player shoot
        private double pShootTimer = 0;
        public double PShootTimer { get { return pShootTimer; } set { pShootTimer = value; } }
        private int pCurShootSpeed = pConShootSpeed;
        public int PCurShootSpeed { get { return pCurShootSpeed; } set { pCurShootSpeed = value; } }
        //-player projectiles
        private int[] pProjDur = new int[pMaxProj];
        public int[] PProjDur { get { return pProjDur; } set { pProjDur = value; } }
        private double[] pProjTimer = new double[pMaxProj];
        public double[] PProjTimer { get { return pProjTimer; } set { pProjTimer = value; } }
        private int[] pProjSpeed = new int[pMaxProj];
        public int[] PProjSpeed { get { return pProjSpeed; } set { pProjSpeed = value; } }
        private int pCurProjSpeed = pConProjSpeed;
        public int PCurProjSpeed { get { return pCurProjSpeed; } set { pCurProjSpeed = value; } }
        //-enemy move
        private double[] eMoveTimer = new double[eMax];
        public double[] EMoveTimer { get { return eMoveTimer; } set { eMoveTimer = value; } }
        private int[] eMoveSpeed = new int[eMax];
        public int[] EMoveSpeed { get { return eMoveSpeed; } set { eMoveSpeed = value; } }
        private int eCurMoveSpeed = eConMoveSpeed;
        public int ECurMoveSpeed { get { return eCurMoveSpeed; } set { eCurMoveSpeed = value; } }
        //-enemy shoot
        private double[] eShootTimer = new double[eMax];
        public double[] EShootTimer { get { return eShootTimer; } set { eShootTimer = value; } }
        private int[] eShootSpeed = new int[eMax];
        public int[] EShootSpeed { get { return eShootSpeed; } set { eShootSpeed = value; } }
        private int eCurShootSpeed = eConShootSpeed;
        public int ECurShootSpeed { get { return eCurShootSpeed; } set { eCurShootSpeed = value; } }
        //-enemy spawn
        private double eSpawnTimer = 0;
        public double ESpawnTimer { get { return eSpawnTimer; } set { eSpawnTimer = value; } }
        private int eCurSpawnSpeed = eConSpawnSpeed;
        public int ECurSpawnSpeed { get { return eCurSpawnSpeed; } set { eCurSpawnSpeed = value; } }
        //-enemy projectiles
        private double[] eProjTimer = new double[eMaxProj];
        public double[] EProjTimer { get { return eProjTimer; } set { eProjTimer = value; } }
        private int[] eProjSpeed = new int[eMaxProj];
        public int[] EProjSpeed { get { return eProjSpeed; } set { eProjSpeed = value; } }
        private int eCurProjSpeed = eConProjSpeed;
        public int ECurProjSpeed { get { return eCurProjSpeed; } set { eCurProjSpeed = value; } }


        public void test()
        {
        }

        public void test2()
        {
        }

        public void throttle(float num)
        {
            if (num < .5) { num = num * num * num * num * num; }
            else if (num < .6) { num = num * num * num * num; }
            else if (num < .7) { num = num * num * num; }
            else if (num < .8) { num = num * num; }
            float speedUp = (1 - num) + 1;
            float tempFloat = 0;
            tempFloat = (float)PMaxProj * num;
            PCurMaxProj = (int)tempFloat;
            tempFloat = (float)EMaxProj * num;
            ECurMaxProj = (int)tempFloat;
            tempFloat = (float)EMax * num;
            ECurMax = (int)tempFloat;
            tempFloat = (float)PConShootSpeed * speedUp;
            PCurShootSpeed = (int)tempFloat;
            tempFloat = (float)PConProjSpeed * speedUp;
            PCurProjSpeed = (int)tempFloat;
            tempFloat = (float)EConShootSpeed * speedUp;
            ECurShootSpeed = (int)tempFloat;
            tempFloat = (float)EConProjSpeed * speedUp;
            ECurProjSpeed = (int)tempFloat;
        }

        public void setKeyLockTimer()
        {
            KeyTimer = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }

        public Boolean checkBorder(int x, int y)
        {
            if (x >= Console.WindowWidth) { return true; }
            if (y >= Console.WindowHeight) { return true; }
            return false;
        }

        public Boolean checkAllBorders(int x, int y)
        {
            if (x < 1 ||
                x > Console.WindowWidth - 1 ||
                y < 1 ||
                y > Console.WindowHeight - 2)
            { return true; }
            return false;
        }

        public void playerMove(int x, int y)
        {
            PX = PX + x;
            PY = PY + y;
            PMoveTimer = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }

        public void playerShoot(int x, int y, int tarX, int fixX, int fixY, int dur)
        {
            for (int i = 0; i < ProjP.Length; i++)
            {
                if (ProjP[i] == 0 && i < PCurMaxProj)
                {
                    ProjP[i] = 1;
                    ProjPMove[i] = 0;
                    PProjDur[i] = dur;
                    ProjPX[i] = x;
                    ProjPY[i] = y;
                    ProjTarPX[i] = tarX;
                    ProjFixPX[i] = fixX;
                    ProjFixPY[i] = fixY;
                    PProjSpeed[i] = PCurProjSpeed;
                    PProjTimer[i] = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
                    PShootTimer = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
                    if (checkAllBorders(ProjPX[i], ProjPY[i])) { killProjP(i); }
                    break;
                }
            }
        }

        public void pProjMove(int i)
        {
            if (ProjPX[i] > ProjTarPX[i] && ProjTarPX[i] > -1) { ProjPX[i] = ProjPX[i] - 1; }
            if (ProjPX[i] < ProjTarPX[i] && ProjTarPX[i] > -1) { ProjPX[i] = ProjPX[i] + 1; }
            ProjPX[i] = ProjPX[i] + projFixPX[i];
            ProjPY[i] = ProjPY[i] + projFixPY[i];
            PProjDur[i]--;
            if (PProjDur[i] < 0) { killProjP(i); }
            if (checkAllBorders(ProjPX[i], ProjPY[i])) { killProjP(i); }
        }

        public void playerProjectiles(int i)
        {
            PProjTimer[i] = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }

        public void killProjP(int i)
        {
            ProjP[i] = 0;
            ProjFixPX[i] = 0;
            ProjFixPY[i] = 0;
            ProjTarPX[i] = 0;
        }

        public void enemyMoveDir(int i)
        {
            //Checks if Enemy is Occupying another's space.  If so, destroy the moving enemy.
            TempInt = checkEonECollision(i);
            //If Enemy Colided into is not above 10, a powerup
            if (TempInt > -1 && Enemy[TempInt] < 10 && Enemy[i] < 10)
            {
                ECol[TempInt] = 2;
            }
            //Checks if Enemy Collides with Player
            TempInt = checkPonECollision();
            if (TempInt > -1 && Enemy[TempInt] < 10 && Enemy[i] < 10)
            {
                ECol[TempInt] = 4;
                PCol = 1;
                PlayerHealth = PlayerHealth - 10;
            }

            EMoveTimer[i] = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
            if (Enemy[i] > 0 && Enemy[i] < 10)
            {
                if (EMoveDur[i] <= 0)
                {
                    EMoveDirX[i] = (rnd.Next(1, 4) - 2) * 2;
                    EMoveDirY[i] = rnd.Next(1, 4) - 2;
                    EMoveDur[i] = rnd.Next(1, 101);
                    EMoveSpeed[i] = rnd.Next(30, EConMoveSpeed);
                }
                EX[i] = EX[i] + EMoveDirX[i];
                EY[i] = EY[i] + EMoveDirY[i];
                EMoveDur[i] = EMoveDur[i] - 1;
                if (EX[i] >= (Console.WindowWidth - 2))
                {
                    EX[i] = EX[i] - EMoveDirX[i];
                    EMoveDirX[i] = EMoveDirX[i] * -1;
                }
                if (EY[i] >= (Console.WindowHeight - 10))
                {
                    EY[i] = EY[i] - EMoveDirY[i];
                    EMoveDirY[i] = EMoveDirY[i] * -1;
                }
                if (EX[i] <= 1)
                {
                    EX[i] = EX[i] - EMoveDirX[i];
                    EMoveDirX[i] = EMoveDirX[i] * -1;
                }
                if (EY[i] <= 1)
                {
                    EY[i] = EY[i] - EMoveDirY[i];
                    EMoveDirY[i] = EMoveDirY[i] * -1;
                }
            }
        }

        public void enemyShoot(int x, int y, int enemyIndex, int fixX, int fixY)
        {
            for (int i = 0; i < ProjE.Length; i++)
            {
                if (Enemy[enemyIndex] > 0 && Enemy[enemyIndex] < 10 && ProjE[i] == 0 && i < ECurMaxProj)
                {
                    ProjE[i] = 1;
                    if (EY[enemyIndex] <= PY) { ProjTarEX[i] = PX; }
                    else { ProjTarEX[i] = -1; }
                    ProjEMove[i] = 0;
                    ProjEX[i] = EX[enemyIndex] + x;
                    ProjEY[i] = EY[enemyIndex] + y;
                    ProjFixEX[i] = fixX;
                    ProjFixEY[i] = fixY;
                    EShootSpeed[enemyIndex] = (rnd.Next(10, 100) * ECurShootSpeed) / 100;
                    EProjSpeed[i] = ECurProjSpeed;
                    EProjTimer[i] = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
                    EShootTimer[enemyIndex] = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
                    if (checkAllBorders(ProjEX[i], ProjEY[i])) { killProjE(i); }
                    break;
                }
            }
        }

        public void enemyProjMove(int i)
        {

            if (rnd.Next(1, 100) < ((33 * CurDifficulty) - 30))
            {
                if (ProjEX[i] > ProjTarEX[i] && ProjTarEX[i] > 0) { ProjEX[i] = ProjEX[i] - 1; }
                if (ProjEX[i] < ProjTarEX[i] && ProjTarEX[i] > 0) { ProjEX[i] = ProjEX[i] + 1; }
            }
            ProjEX[i] = ProjEX[i] + projFixEX[i];
            ProjEY[i] = ProjEY[i] + projFixEY[i];
            if (checkAllBorders(ProjEX[i], ProjEY[i])) { killProjE(i); }
        }

        public void enemyProjectiles(int i)
        {
            EProjTimer[i] = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
        }

        public void killProjE(int i)
        {
            ProjE[i] = 0;
            ProjFixEX[i] = 0;
            ProjFixEY[i] = 0;
        }

        public void killEnemy(int i)
        {
            Enemy[i] = 0;
            EMoveDur[i] = 0;
            ECol[i] = 0;
        }

        public void enemySpawn(int i)
        {
            int tempEonE = 0;
            int tempPonE = 0;
            int tempRnd = 0;
            if (Enemy[i] == 0 && timerCheck(ESpawnTimer, ECurSpawnSpeed) && i < ECurMax)
            {
                if (rnd.Next(1, 100) > PUpSpawn)
                {
                    Enemy[i] = 1;
                    EMoveSpeed[i] = ECurMoveSpeed;
                    EShootSpeed[i] = ECurShootSpeed;
                    EMoveDirX[i] = 0;
                    EMoveDirY[i] = 0;
                    do
                    {
                        EX[i] = (rnd.Next(5, (Console.WindowWidth - 5)));
                        EY[i] = (rnd.Next(2, (Console.WindowHeight - 10)));
                        tempEonE = checkEonECollision(i);
                        tempPonE = checkPonECollision();
                    }
                    while (tempEonE > -1 && tempPonE > -1);
                    EMoveTimer[i] = ((DateTime.UtcNow - UnixEpoch).TotalMilliseconds + (EMoveSpeed[i] + 1));
                    EShootTimer[i] = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
                }
                //Power Up Spawn
                else
                {
                    tempRnd = rnd.Next(1, 4);
                    //Spread
                    if (tempRnd == 1 && PUpSpread < 2)
                    {
                        Enemy[i] = 11;
                        EMoveSpeed[i] = 100;
                        do
                        {
                            EX[i] = (rnd.Next(5, (Console.WindowWidth - 5)));
                            EY[i] = (rnd.Next(2, (Console.WindowHeight - 10)));
                            tempEonE = checkEonECollision(i);
                            tempPonE = checkPonECollision();
                        }
                        while (tempEonE > -1 && tempPonE > -1);
                        EMoveTimer[i] = ((DateTime.UtcNow - UnixEpoch).TotalMilliseconds + (EMoveSpeed[i] + 1));
                    }
                    //Explosive Shot
                    else if (tempRnd == 2 && PUpExp < 1)
                    {
                        Enemy[i] = 13;
                        EMoveSpeed[i] = 100;
                        do
                        {
                            EX[i] = (rnd.Next(5, (Console.WindowWidth - 5)));
                            EY[i] = (rnd.Next(2, (Console.WindowHeight - 10)));
                            tempEonE = checkEonECollision(i);
                            tempPonE = checkPonECollision();
                        }
                        while (tempEonE > -1 && tempPonE > -1);
                        EMoveTimer[i] = ((DateTime.UtcNow - UnixEpoch).TotalMilliseconds + (EMoveSpeed[i] + 1));
                    }
                    //Health
                    else
                    {
                        Enemy[i] = 12;
                        EMoveSpeed[i] = 100;
                        do
                        {
                            EX[i] = (rnd.Next(5, (Console.WindowWidth - 5)));
                            EY[i] = (rnd.Next(2, (Console.WindowHeight - 10)));
                            tempEonE = checkEonECollision(i);
                            tempPonE = checkPonECollision();
                        }
                        while (tempEonE > -1 && tempPonE > -1);
                        EMoveTimer[i] = ((DateTime.UtcNow - UnixEpoch).TotalMilliseconds + (EMoveSpeed[i] + 1));
                    }
                }
                ESpawnTimer = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
            }
        }


        public void pWBomb()
        {
            for (int i = 0; i < Enemy.Length; i++)
            {
                if (Enemy[i] > 0) { ECol[i] = 1; pProjBurst(EX[i], EY[i], 100); }
            }
        }

        //Checks if x, y Collides with Player
        public Boolean checkPCollision(int x, int y)
        {
            if (hitBox(PX, PY, x, y, 5, 3))
            {
                return true;
            }
            return false;
        }
        
        //Checks if an Enemy will Collide with x, y
        //int exclude & return: -1 is nobody
        //int exclude: the Enemy actor to exclude(self)
        //return: the enemy that collided
        public int checkECollision(int x, int y, int exclude)
        {
            for (int i = 0; i < Enemy.Length; i++)
            {
                if (i != exclude && Enemy[i] > 0 && hitBox(EX[i], EY[i], x, y, 5, 3))
                {
                    return i;
                }
            }
            return -1;
        }

        //Scans a whole hitbox for Enemy Collision
        //Player: x = 5, y = 3
        //Enemy: x = 5, y = 3
        //int xCount = -1 * ((hitX - 1) / 2);
        //int yCount = -1 * ((hitY - 1) / 2);
        //enemy Hitbox: x = -2, y = -1
        //i = The moving Enemy checking for collision
        //return: the Enemy that collided, -1 if no Enemies were Collided with
        public int checkEonECollision(int i)
        {
            int xCount = -2;
            int yCount = -1;
            while (xCount < 3)
            {
                while (yCount < 2)
                {
                    TempInt = checkECollision((EX[i] + xCount), EY[i] + yCount, i);
                    if (TempInt > -1) { return TempInt; }
                    yCount++;
                }
                yCount = -1;
                xCount++;
            }
            return -1;
        }

        //Checks to see if Player Collides with any Enemy
        public int checkPonECollision()
        {
            int xCount = -2;
            int yCount = -1;
            for (int i = 0; i < Enemy.Length; i++)
            {
                if (Enemy[i] > 0)
                {
                    while (xCount < 3)
                    {
                        while (yCount < 2)
                        {
                            TempInt = checkECollision((PX + xCount), PY + yCount, -1);
                            if (TempInt > -1) { return TempInt; }
                            yCount++;
                        }
                        yCount = -1;
                        xCount++;
                    }

                }
            }
            return -1;
        }

        //Scans a Unit's hitBox.
        //Player: x = 5, y = 3
        //Enemy: x = 5, y = 3
        public Boolean hitBox(int x, int y, int projX, int projY, int hitX, int hitY)
        {
            int xCount = -1 * ((hitX - 1) / 2);
            int yCount = -1 * ((hitY - 1) / 2);
            while (xCount < ((hitX - 1) / 2) + 1)
            {
                while (yCount < ((hitY - 1) / 2) + 1)
                {
                    if (x + xCount == projX && y + yCount == projY)
                    {
                        return true;
                    }
                    yCount++;
                }
                yCount = -1 * ((hitY - 1) / 2);
                xCount++;
            }
            return false;
        }

        public void ChangeBorders()
        {
            float tempFloat = 0;
            tempFloat = (((float)PX / (float)BorderX) * (float)Console.WindowWidth);
            PX = (int)tempFloat;
            tempFloat = (((float)PY / (float)BorderY) * (float)Console.WindowHeight);
            PY = (int)tempFloat;
            if (checkBorder(PX + 4, 2)) { PX = Console.WindowWidth - 6; }
            if (checkBorder(3, PY + 2)) { PY = Console.WindowHeight - 3; }
            if (PX <= 3) { PX = 4; }
            if (PY <= 2) { PY = 2; }
            for (int i = 0; i < ProjP.Length; i++)
            {
                tempFloat = (((float)ProjPX[i] / (float)BorderX) * (float)Console.WindowWidth);
                ProjPX[i] = (int)tempFloat;
                tempFloat = (((float)ProjPY[i] / (float)BorderY) * (float)Console.WindowHeight);
                ProjPY[i] = (int)tempFloat;
                tempFloat = (((float)ProjTarPX[i] / (float)BorderX) * (float)Console.WindowWidth);
                ProjTarPX[i] = (int)tempFloat;
                if (checkBorder(ProjPX[i] + 3, 1)) { ProjPX[i] = Console.WindowWidth - 3; }
                if (checkBorder(1, ProjPY[i] + 2)) { ProjPY[i] = Console.WindowHeight - 3; }
                if (ProjPX[i] <= 1) { ProjPX[i] = 1; }
                if (ProjPY[i] <= 1) { ProjPY[i] = 2; }
            }
            for (int i2 = 0; i2 < ProjE.Length; i2++)
            {
                tempFloat = (((float)ProjEX[i2] / (float)BorderX) * (float)Console.WindowWidth);
                ProjEX[i2] = (int)tempFloat;
                tempFloat = (((float)ProjEY[i2] / (float)BorderY) * (float)Console.WindowHeight);
                ProjEY[i2] = (int)tempFloat;
                tempFloat = (((float)ProjTarEX[i2] / (float)BorderX) * (float)Console.WindowWidth);
                ProjTarEX[i2] = (int)tempFloat;
                if (checkBorder(ProjEX[i2] + 3, 1)) { ProjEX[i2] = Console.WindowWidth - 3; }
                if (checkBorder(1, ProjEY[i2] + 2)) { ProjEY[i2] = Console.WindowHeight - 3; }
                if (ProjEX[i2] <= 1) { ProjEX[i2] = 1; }
                if (ProjEY[i2] <= 1) { ProjEY[i2] = 2; }
            }
            for (int i3 = 0; i3 < Enemy.Length; i3++)
            {
                tempFloat = (((float)EX[i3] / (float)BorderX) * (float)Console.WindowWidth);
                EX[i3] = (int)tempFloat;
                tempFloat = (((float)EY[i3] / (float)BorderY) * (float)Console.WindowHeight);
                EY[i3] = (int)tempFloat;
                if (checkBorder(EX[i3] + 4, 2)) { EX[i3] = Console.WindowWidth - 6; }
                if (checkBorder(3, EY[i3] + 13)) { EY[i3] = Console.WindowHeight - 14; }
                if (EX[i3] <= 3) { EX[i3] = 4; }
                if (EY[i3] <= 2) { EY[i3] = 2; }
            }
            BorderX = Console.WindowWidth;
            BorderY = Console.WindowHeight;
        }

        public void Restart()
        {
            PX = Console.WindowWidth / 2;
            PY = Console.WindowHeight - 4;
            PlayerHealth = 100;
            PScore = 0;
            PLowHealth = 0;
            PCol = 0;
            PShoot = 0;
            PMoveTimer = 0;
            PCurMoveSpeed = PConMoveSpeed;
            PShootTimer = 0;
            PCurShootSpeed = PConShootSpeed;
            PCurProjSpeed = PConProjSpeed;
            PCurMaxProj = PMaxProj;
            ECurMaxProj = EMaxProj;
            ECurMax = EMax;
            ECurMoveSpeed = EConMoveSpeed;
            ECurShootSpeed = EConShootSpeed;
            ESpawnTimer = 0;
            ECurSpawnSpeed = EConSpawnSpeed;
            ECurProjSpeed = EConProjSpeed;
            KeyTimer = 0;
            MenuSel = 1;
            CurDifficulty = ConDifficulty;
            PUpSpread = 0;
            PUpExp = 0;
            PUpAuto = 0;
            for (int i = 0; i < ProjP.Length; i++)
            {
                ProjP[i] = 0;
                ProjPX[i] = 0;
                ProjPY[i] = 0;
                ProjPMove[i] = 0;
                PProjTimer[i] = 0;
                PProjSpeed[i] = 0;
            }
            for (int i2 = 0; i2 < ProjE.Length; i2++)
            {
                ProjE[i2] = 0;
                ProjEMove[i2] = 0;
                ProjEX[i2] = 0;
                ProjEY[i2] = 0;
                ProjTarEX[i2] = 0;
                EProjTimer[i2] = 0;
                EProjSpeed[i2] = 0;
            }
            for (int i3 = 0; i3 < Enemy.Length; i3++)
            {
                Enemy[i3] = 0;
                EX[i3] = 0;
                EY[i3] = 0;
                EMoveDirX[i3] = 0;
                EMoveDirY[i3] = 0;
                EMoveDur[i3] = 0;
                ECol[i3] = 0;
                EMoveTimer[i3] = 0;
                EMoveSpeed[i3] = 0;
                EShootTimer[i3] = 0;
                EShootSpeed[i3] = 0;
            }
        }

        public void eProjBurst(int i)
        {
            //Enemy Death Burst
            enemyShoot(-3, -2, i, -2, -1);
            enemyShoot(3, -2, i, 2, -1);
            enemyShoot(0, -3, i, 0, -1);
            enemyShoot(-5, 0, i, -3, 0);
            enemyShoot(5, 0, i, 3, 0);
            enemyShoot(-3, 2, i, -2, 1);
            enemyShoot(3, 2, i, 2, 1);
            enemyShoot(0, 3, i, 0, 1);
        }

        public void pProjBurst(int x, int y, int dur)
        {
            //Player Burst
            //(ProjX, ProjY, -1, MoveX, MoveY, Dur)
            playerShoot(x - 3, y - 2, -1, -2, -1, dur);
            playerShoot(x + 3, y - 2, -1, 2, -1, dur);
            playerShoot(x, y - 3, -1, 0, -1, dur + 1);
            playerShoot(x - 5, y, -1, -3, 0, dur + 1);
            playerShoot(x + 5, y, -1, 3, 0, dur + 1);
            playerShoot(x - 3, y + 2, -1, -2, 1, dur);
            playerShoot(x + 3, y + 2, -1, 2, 1, dur);
            playerShoot(x, y + 3, -1, 0, 1, dur + 1);
        }

        public Boolean timerCheck(double timer, int speed)
        {
            if ((((DateTime.UtcNow - UnixEpoch).TotalMilliseconds) - timer) > speed) { return true; }
            else { return false; }
        }

    }//end class
}//end namespace
