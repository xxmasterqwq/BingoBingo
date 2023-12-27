using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingobingo
{
    internal class NumberSet
    { 
        //public List<int> listNum = new List<int>();
        //int bingoOdds = 1;
        //public bool superNumber = false;
        //public bool comparingGame = false;
        //public int comparingGameOdds = 0;
        //public bool oddAndEvenGame = false;
        //public int oddAndEvenGameOdds = 0;
        public List<int> BingoNum { get; set; }
        public int BingoOdds { get; set; }
        public bool SuperNumber { get; set; }
        public bool BoolComparingGame;
        public string ComparingGame { get; set; }
        public int ComparingGameOdds { get; set; }
        public bool BoolOddAndEvenGame;
        public string OddAndEvenGame { get; set; }
        public int OddAndEvenGameOdds { get; set; }

        public NumberSet(List<int> bingoNum, int bingoOdds, bool superNumber, bool boolComparingGame, string comparingGame, int comparingGameOdds, bool boolOddAndEvenGame, string oddAndEvenGame, int oddAndEvenGameOdds)
        {
            BingoNum = bingoNum;
            BingoOdds = bingoOdds;
            SuperNumber = superNumber;
            BoolComparingGame = boolComparingGame;
            ComparingGame = comparingGame;
            ComparingGameOdds = comparingGameOdds;
            BoolOddAndEvenGame = boolOddAndEvenGame;
            OddAndEvenGame = oddAndEvenGame;
            OddAndEvenGameOdds = oddAndEvenGameOdds;
            OddAndEvenGameOdds = oddAndEvenGameOdds;
        }
        public NumberSet(List<int> bingoNum)
        {
            BingoNum = bingoNum;
        }



    }
}
