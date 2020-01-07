using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Assignment 9

namespace dalsanto_Bester
{
    class BesterModel
    {
        Random rnd = new Random();
        DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private int msgX = 0;
        public int MsgX { get { return msgX; } set { msgX = value; } }
        
        private int msgY = 0;
        public int MsgY { get { return msgY; } set { msgY = value; } }

        private int cRolls = 0;
        public int CRolls { get { return cRolls; } set { cRolls = value; } }
        private int pRolls = 0;
        public int PRolls { get { return pRolls; } set { pRolls = value; } }

        private int pTotal = 0;
        public int PTotal { get { return pTotal; } set { pTotal = value; } }
        private int cTotal = 0;
        public int CTotal { get { return cTotal; } set { cTotal = value; } }

        private string[] msgString = new string[8];
        public string[] MsgString { get { return msgString; } set { msgString = value; } }
        private string[] pMsgString = new string[8];
        public string[] PMsgString { get { return pMsgString; } set { pMsgString = value; } }

        private int[] cDice = new int[5];
        public int[] CDice { get { return cDice; } set { cDice = value; } }
        private int[] pDice = new int[5];
        public int[] PDice { get { return pDice; } set { pDice = value; } }

        private double timer;

        public BesterModel() { }

        public void MsgBox(string msg)
        {
            for (int i = 0; i < MsgString.Length; i++)
            {
                PMsgString[i] = MsgString[i];
            }
            for (int i = 0; i < MsgString.Length; i++)
            {
                if (i > 0)
                {
                    MsgString[i] = PMsgString[i - 1];
                }
            }
            MsgString[0] = msg;
            for (int i = 0; i < msgString.Length; i++)
            {
                Console.SetCursorPosition(17, 2 + i);
                Console.Write("                                           ");
                Console.SetCursorPosition(17, 2 + i);
                Console.WriteLine(MsgString[i]);
            }
            Console.SetCursorPosition(0, 0);
        }

        public void ClearScores()
        {
            PTotal = 0;
            CTotal = 0;
            PRolls = 0;
            CRolls = 0;
        }

        public void WaitTimer(int speed)
        {
            timer = (DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
            while ((((DateTime.UtcNow - UnixEpoch).TotalMilliseconds) - timer) < speed)
            {

            }
        }

        public int getRand()
        {
            int num = (rnd.Next(1,7));
            return num;
        }
    }
}
