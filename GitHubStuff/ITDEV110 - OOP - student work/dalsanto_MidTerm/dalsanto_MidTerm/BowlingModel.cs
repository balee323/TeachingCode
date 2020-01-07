using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matthew Dal Santo
//ITDEV110
//Mid Term

namespace BowlingScores
{
    class BowlingModel
    {
        public BowlingModel() { }

        //Model properties setup.
        private int goGoGo = 1;
        public int GoGoGo { get { return goGoGo; } set { goGoGo = value; } }
        private int goGoGo2 = 1;
        public int GoGoGo2 { get { return goGoGo2; } set { goGoGo2 = value; } }
        private int scoreCount = 0;
        public int ScoreCount { get { return scoreCount; } set { scoreCount = value; } }
        private int totalScores = 0;
        public int TotalScores { get { return totalScores; } set { totalScores = value; } }
        private int scoreAverageCalc = 0;
        public int ScoreAverageCalc { get { return scoreAverageCalc; } set { scoreAverageCalc = value; } }
        private string inputStr = "";
        public string InputStr { get { return inputStr; } set { inputStr = value; } }

        //Counter for number of scores entered.
        public void CountUp()
        {
            ScoreCount = ScoreCount + 1;
        }//end CountUp method

        //Add last score entered to total of all scores.
        public int CalcAddTotal(int newScore)
        {
            TotalScores = TotalScores + newScore;
            return TotalScores;
        }//end CalcAddTotal method

        //Average all entered scores.
        public int CalcAverage(int numScores, int allScores)
        {
            ScoreAverageCalc = allScores / numScores;
            return ScoreAverageCalc;
        }//end CalcAverage method

        //Reset data.
        public void ResetData()
        {
            ScoreCount = 0;
            TotalScores = 0;
            ScoreAverageCalc = 0;
            GoGoGo2 = 1;
        }//end ResetData method
    }//end class
}
