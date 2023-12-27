using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bingobingo
{
    public partial class Form1 : Form
    {
        List<Label> listlabels = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbox_comparingGame.Enabled = false;
            cbbox_comparingGameOdds.Enabled = false;
            cbbox_oddOrEven.Enabled = false;
            cbbox_oddOrEvenOdds.Enabled = false;
            cbbox_bingoOdds.SelectedIndex = 0;
            cbbox_numOfNum.SelectedIndex = 9;
            createBtn(8, 10);
            //testLottoNum();
            lBox_about.Items.Add("1. 此Bingo Bingo與台彩規則相同");
            lBox_about.Items.Add("2. 左上角為選號區");
            lBox_about.Items.Add("3. 您需要在沒有選號的時候才能使用自動選");
            lBox_about.Items.Add("號，且無法指定號碼數量。如需指定號碼數");
            lBox_about.Items.Add("量，請使用包牌區的功能。");
            lBox_about.Items.Add("4. 選滿20個中獎號碼後，必須先設定超級號");
            lBox_about.Items.Add("碼，才可新增中獎號碼。");
            lBox_about.Items.Add("5. 號碼未選擇時是橘色，選擇時是暗紅色，");
            lBox_about.Items.Add("超級號碼為灰色，而包牌時的固定號碼在");
            lBox_about.Items.Add("產生完號碼後會是綠色的。");
            lBox_about.Items.Add("6. 此程式純屬娛樂功能");
            lBox_about.Items.Add("7. 小賭怡情，大賭可能家破人亡。");
        }
        public List<Button> NumButtons = new List<Button>();
        void createBtn(int row, int col)
        {
            int num = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    num++;
                    Button dbutton = new Button();
                    dbutton.BackColor = Color.Orange;
                    dbutton.ForeColor = Color.Blue;
                    dbutton.Font = new Font("微軟正黑體", 14);
                    dbutton.Text = string.Format("{0}", num);
                    dbutton.Location = new Point(20 + 40 * j, 85 + 40 * i);
                    dbutton.Size = new Size(40, 40);
                    dbutton.Click += new EventHandler(NumButton_Click);
                    Controls.Add(dbutton);
                    NumButtons.Add(dbutton);
                }
            }
        }

        //不使用，使用者透過messagebox會更容易理解如何操作
        //void btnControl()
        //{
        //    if (tempArr.Count > 0)
        //    {
        //        btn_bingo.Enabled = false;
        //    }
        //    else if (tempArr.Count > 10)
        //    {
        //        btn_add.Enabled = false;
        //    }
        //    else if (tempArr.Count != 20)
        //    {
        //        btn_addLottoNum.Enabled = false;
        //        btn_setSuperNum.Enabled = false;
        //        btn_cancelSuperNum.Enabled = false;
        //    }
        //}

        List<int> tempArr = new List<int>();

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            //MessageBox.Show($"按下{myBtn.Text}");
            if (myBtn.BackColor == Color.DarkRed)
            {
                myBtn.BackColor = Color.Orange;
                int removeNum = int.Parse(myBtn.Text);
                tempArr.Remove(removeNum);

            }
            else
            {
                myBtn.BackColor = Color.DarkRed;
                int addNum = int.Parse(myBtn.Text);
                tempArr.Add(addNum);

            }
            
            setSelectedBtn();
            tempArr.Sort();
        }

        void setSelectedBtn()
        {
            lbl_clickedBtn.Text = string.Format("已選 {0} 個數字", tempArr.Count);
        }

        void setNumSet()
        {
            lbl_setOfNum.Text = string.Format("共{0}筆", lbox_num.Items.Count);
        }

        Random rnd = new Random();
        List<NumberSet> numberSet = new List<NumberSet>();
        private List<int> bingoNumArr;
        private void btn_bingo_Click(object sender, EventArgs e)
        {
            if (tempArr.Count == 10)
            {
                for (int i = 0; i < tempArr.Count; i++)
                {
                    NumButtons[tempArr[i] - 1].BackColor = Color.Orange;
                }
                tempArr.Clear();
            }
            if (tempArr.Count != 0)
            {
                MessageBox.Show("自動選號若欲包含特定號碼，請使用下方包牌區的功能。");
                return;
            }
            while (tempArr.Count < 10)
            {
                //產生1~80隨機數
                int bingoNum = rnd.Next(1, 81);
                if (tempArr.IndexOf(bingoNum) == -1) //防止重複數字
                {
                    tempArr.Add(bingoNum);
                }
            }

            tempArr.Sort();

            for (int i = 0; i < tempArr.Count; i++)
            {
                NumButtons[tempArr[i] - 1].BackColor = Color.DarkRed;
            }
            setSelectedBtn();
        }

        int totalMoney = 0;
        void createNumSet(List<int> bingoNumArr)
        {
            int bingoOdds = 1;

            if (cbbox_bingoOdds.SelectedItem != null)
            {
                string selectedValue = cbbox_bingoOdds.SelectedItem.ToString();

                if (int.TryParse(selectedValue, out bingoOdds))
                {
                    bingoOdds = int.Parse(selectedValue);
                }
                else
                {
                    MessageBox.Show("");
                }
            }

            bool boolSuperNum = ckbox_superNum.Checked;
            bool boolComparingGame = ckbox_comparingGame.Checked;
            string comparingGame = cbbox_comparingGame.Text;
            int comparingGameOdds = 0;
            if (cbbox_comparingGameOdds.SelectedItem != null)
            {
                string selectedValue = cbbox_comparingGameOdds.SelectedItem.ToString();

                if (int.TryParse(selectedValue, out comparingGameOdds))
                {
                    comparingGameOdds = int.Parse(selectedValue);
                }
                else
                {
                    MessageBox.Show("");
                }
            }

            bool boolOddOrEven = ckbox_oddOrEven.Checked;
            string oddOrEven = cbbox_oddOrEven.Text;
            int oddOrEvenOdds = 0;
            if (cbbox_oddOrEvenOdds.SelectedItem != null)
            {
                string selectedValue = cbbox_oddOrEvenOdds.SelectedItem.ToString();

                if (int.TryParse(selectedValue, out oddOrEvenOdds))
                {
                    oddOrEvenOdds = int.Parse(selectedValue);
                }
                else
                {
                    MessageBox.Show("");
                }
            }


            numberSet.Add(new NumberSet(bingoNumArr, bingoOdds, boolSuperNum, boolComparingGame, comparingGame, comparingGameOdds, boolOddOrEven, oddOrEven, oddOrEvenOdds));

            int money = 0;
            int bingoMoney = 0, comparingGameMoney = 0, oddOrEvenMoney = 0;
            
            if (boolSuperNum)
            {
                bingoMoney = 25 * 2 * bingoNumArr.Count * bingoOdds;
            }
            else
            {
                bingoMoney = 25 * bingoNumArr.Count * bingoOdds;
            }
            if (boolComparingGame)
            {
                comparingGameMoney = 25 * comparingGameOdds;
            }
            if (boolOddOrEven)
            {
                oddOrEvenMoney = 25 * oddOrEvenOdds;
            }
            money = bingoMoney + comparingGameMoney + oddOrEvenMoney;
            totalMoney += money;
            setTotalMoney();
        }

        void setTotalMoney()
        {
            lbl_money.Text = string.Format("已投注 {0} 元", totalMoney);
        }
        void addNumSet(List<int> bingoNumArr)
        {
            createNumSet(bingoNumArr);
            string strNum = "";
            for (int i = 0; i < bingoNumArr.Count; i++)
            {
                strNum += bingoNumArr[i] + " ";
            }
            if (numberSet.Count > 0)
            {
                NumberSet lastNumberSet = numberSet[numberSet.Count - 1];
                strNum += $"倍率: {lastNumberSet.BingoOdds} ";
                if (ckbox_superNum.Checked)
                {
                    strNum += "超級號碼";
                }
                if (ckbox_comparingGame.Checked)
                {
                    strNum += $", 比大小: {lastNumberSet.ComparingGame} 倍率: {lastNumberSet.ComparingGameOdds}";
                }
                if (ckbox_oddOrEven.Checked)
                {
                    strNum += $", 單雙: {lastNumberSet.OddAndEvenGame} 倍率: {lastNumberSet.OddAndEvenGameOdds}";
                }
            }
            lbox_num.Items.Add(strNum);
        }

        int money = 0; 
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tempArr.Count <= 10)
            {

                bingoNumArr = new List<int>();
                for (int i = 0; i < tempArr.Count; i++)
                {
                    bingoNumArr.Add(tempArr[i]);

                }
                for (int i = 0; i < bingoNumArr.Count; i++)
                {
                    Console.Write(bingoNumArr[i] + ",");
                }
            }
            createNumSet(bingoNumArr);
            string strNum = "";
            for (int i = 0; i < bingoNumArr.Count; i++)
            {
                strNum += bingoNumArr[i] + " ";
            }
            if (numberSet.Count > 0)
            {
                NumberSet lastNumberSet = numberSet[numberSet.Count - 1];
                strNum += $"倍率: {lastNumberSet.BingoOdds} ";
                if (ckbox_superNum.Checked)
                {
                    strNum += "超級號碼";
                }
                if (ckbox_comparingGame.Checked)
                {
                    strNum += $", 比大小: {lastNumberSet.ComparingGame} 倍率: {lastNumberSet.ComparingGameOdds}";
                }
                if (ckbox_oddOrEven.Checked)
                {
                    strNum += $", 單雙: {lastNumberSet.OddAndEvenGame} 倍率: {lastNumberSet.OddAndEvenGameOdds}";
                }
            }

            lbox_num.Items.Add(strNum);
            for (int i = 0; i < bingoNumArr.Count; i++)
            {
                NumButtons[bingoNumArr[i] - 1].BackColor = Color.Orange;
            }
            tempArr.Clear();
            setSelectedBtn();
            setNumSet();
        }

        private void btn_clearAllSelectedNum_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumButtons.Count; i++)
            {
                NumButtons[i].BackColor = Color.Orange;
            }
            tempArr.Clear();
            setSelectedBtn();
        }

        private void btn_removeSelected_Click(object sender, EventArgs e)
        {
            if (lbox_num.SelectedIndex >= 0)
            {
                numberSet.RemoveAt(lbox_num.SelectedIndex);
                lbox_num.Items.RemoveAt(lbox_num.SelectedIndex);               
            }
            else
            {
                MessageBox.Show("請選擇一組號碼");
            }
            setNumSet();
        }

        private void btn_removeAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要刪除所有號碼", "刪除所有號碼", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) //防止誤觸
            {
                lbox_num.Items.Clear();
                numberSet.Clear();
            }
            setNumSet();
        }

        List<int> arrLottoNum = new List<int>();
        
        private void btn_addLottoNum_Click(object sender, EventArgs e)
        {
    
            if (tempArr.Count > 20)
            {
                MessageBox.Show("已超過輸入上限");
                return;
            }
            if (tempArr.Count != 20)
            {
                MessageBox.Show("中獎號碼尚未全部輸入");
                return;
            }
            if (superNum == -1)
            {
                MessageBox.Show("請先設定超級號碼");
                return;
            }
            arrLottoNum.Clear();
            for (int i = 0; i < tempArr.Count; i++)
            {
                arrLottoNum.Add(tempArr[i]);
            }
            string strLottoNum = "";
            superNumIndex = arrLottoNum.IndexOf(superNum);
            for(int i = 0; i <  arrLottoNum.Count; i++)
            {
                strLottoNum += arrLottoNum[i] + " ";
            }

            int temp = arrLottoNum[19];
            arrLottoNum[19] = arrLottoNum[superNumIndex];   //將超級號碼移至arr的最後
            arrLottoNum[superNumIndex] = temp;
            if (arrLottoNum[7] >= 41)
            {
                comparingResult = "大";
            }
            else if (arrLottoNum[12] <= 40)
            {
                comparingResult = "小";
            }
            else
            {
                comparingResult = "none";
            }

            int odd = 0, even = 0;

            for (int i = 0; i < arrLottoNum.Count; i++)
            {
                if (arrLottoNum[i] % 2 == 1)
                {
                    odd++;
                }
                else
                {
                    even++;
                }
            }
            if (odd == 11 | odd == 12)
            {
                oddAndEvenResult = "小單";
            }
            else if (odd >= 13)
            {
                oddAndEvenResult = "單";
            }
            else if (even == 11 | even == 12)
            {
                oddAndEvenResult = "小雙";
            }
            else if (even >= 13)
            {
                oddAndEvenResult = "雙";
            }
            else if (odd == even)
            {
                oddAndEvenResult = "和";
            }
            lBox_history.Items.Add($"本期中獎號碼:{strLottoNum}, 比大小: {comparingResult}, 單雙: {oddAndEvenResult}");
            lBox_history.Items.Add("你的號碼：");  
            for (int i = 0; i < arrLottoNum.Count; i++)
            {
                NumButtons[arrLottoNum[i] - 1].BackColor = Color.Orange;
            }
            tempArr.Clear();
            setSelectedBtn();
            superNum = -1;
            txt_superNum.Text = "";
        }

        int superNumIndex = 0;
        int tempSuperNum = 0;
        int superNum = -1;
        private void btn_setSuperNum_Click(object sender, EventArgs e)
        {
            if (txt_superNum.Text != "")
            {
                bool input = Int32.TryParse(txt_superNum.Text, out tempSuperNum);
                if (!input || tempSuperNum <= 0)
                {
                    MessageBox.Show("輸入錯誤");
                    txt_superNum.Text = "";
                    return;
                }
            }
            if (tempArr.Count != 20)
            {
                MessageBox.Show("請先輸入完所有的中獎號碼再設定超級號碼");
                return;
            }
            else if (tempArr.IndexOf(tempSuperNum) == -1)
            {
                MessageBox.Show("超級號碼只能為中獎號碼的其中一個號碼");
                return;
            }
            else if (superNum != -1)
            {
                MessageBox.Show("僅能有一個超級號碼");
                return;
            }
            superNum = tempSuperNum;
            NumButtons[superNum - 1].BackColor = Color.Gray;         
        }

        private void btn_cancelSuperNum_Click(object sender, EventArgs e)
        {
            txt_superNum.Text = "";
            if (superNum == -1)
            {
                MessageBox.Show("尚未設定超級號碼");
                return;
            }
            NumButtons[superNum - 1].BackColor = Color.DarkRed;
            //arrLottoNum.Sort();
            superNum = -1;
        }
 
        string comparingResult = "";
        string oddAndEvenResult = "";
        
        int accPrize = 0, accSet = 0;
        void accumulatePrize()
        {
            lbl_accumulatePrize.Text = string.Format("累計中獎金額: {0} 元", accPrize);
        }

        void accumulateSet()
        {
            lbl_accumulateSet.Text = string.Format("已對獎 {0} 筆", accSet);
        }

        void setIncome()
        {
            if(income < 0)
            {
                lbl_income.ForeColor = Color.Red;
            }
            else if (income == 0)
            {
                lbl_income.ForeColor = Color.Black;
            }
            else
            {
                lbl_income.ForeColor = Color.Green;
            }
            lbl_income.Text = string.Format("淨收益: {0} 元", income);
        }

        long income = 0;
        private void btn_match_Click(object sender, EventArgs e)
        {
            if (arrLottoNum.Count != 20)
            {
                MessageBox.Show("中獎號碼尚未全部輸入");
                return;
            }
            if (lbox_num.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇一組號碼");
                return;
            }

            List<int> matchResult = match(numberSet[lbox_num.SelectedIndex].BingoNum, 
                numberSet[lbox_num.SelectedIndex].BingoOdds, 
                numberSet[lbox_num.SelectedIndex].SuperNumber,
                numberSet[lbox_num.SelectedIndex].BoolComparingGame,
                numberSet[lbox_num.SelectedIndex].ComparingGame,
                numberSet[lbox_num.SelectedIndex].ComparingGameOdds,
                numberSet[lbox_num.SelectedIndex].BoolOddAndEvenGame,
                numberSet[lbox_num.SelectedIndex].OddAndEvenGame,
                numberSet[lbox_num.SelectedIndex].OddAndEvenGameOdds);
            accPrize += matchResult[1];
            lBox_history.Items.Add($"{lbox_num.Items[lbox_num.SelectedIndex]}，中了{matchResult[0]}碼，你贏得了{matchResult[1]}元!");
            accumulatePrize();
            numberSet.RemoveAt(lbox_num.SelectedIndex);
            lbox_num.Items.RemoveAt(lbox_num.SelectedIndex);

            accSet++;
            accumulateSet();
            income = accPrize - totalMoney;
            setIncome();
            setNumSet();
        }

        private void btn_allMatch_Click(object sender, EventArgs e)
        {
            if (lbox_num.Items.Count <= 0)
            {
                MessageBox.Show("請輸入欲對獎的號碼");
                return;
            }
            if (arrLottoNum.Count != 20)
            {
                MessageBox.Show("中獎號碼尚未全部輸入");
                return;
            }
            for (int i = 0; i < lbox_num.Items.Count; i++)
            {
                List<int> matchResult = match(numberSet[i].BingoNum,
                numberSet[i].BingoOdds,
                numberSet[i].SuperNumber,
                numberSet[i].BoolComparingGame,
                numberSet[i].ComparingGame,
                numberSet[i].ComparingGameOdds,
                numberSet[i].BoolOddAndEvenGame,
                numberSet[i].OddAndEvenGame,
                numberSet[i].OddAndEvenGameOdds);
                accPrize += matchResult[1];
                lBox_history.Items.Add($"{lbox_num.Items[i]}，中了{matchResult[0]}碼，你贏得了{matchResult[1]}元!");
                accSet++;
                income = accPrize - totalMoney;
            }
            accumulatePrize();
            accumulateSet();
            setIncome();
            numberSet.Clear();
            lbox_num.Items.Clear();
            setNumSet();
        }

        private void ckbox_comparingGame_CheckedChanged(object sender, EventArgs e)
        {
            cbbox_comparingGame.Enabled = ckbox_comparingGame.Checked;
            cbbox_comparingGameOdds.Enabled = ckbox_comparingGame.Checked;
        }

        private void ckbox_oddOrEven_CheckedChanged(object sender, EventArgs e)
        {
            cbbox_oddOrEven.Enabled = ckbox_oddOrEven.Checked;
            cbbox_oddOrEvenOdds.Enabled = ckbox_oddOrEven.Checked;
        }

        List<int> arrSolidNum = new List<int>();
        
        private List<int> createNum(int index, List<int> arrSolidNum)
        {
            List<int> bingoNumArr = new List<int>();
            for(int i = 0; i < arrSolidNum.Count; i++)
            {
                bingoNumArr.Add(arrSolidNum[i]);
            }
            while (bingoNumArr.Count < index)
            {
                int bingoNum = rnd.Next(1, 81);
                if (bingoNumArr.IndexOf(bingoNum) == -1) //防止重複數字
                {
                    bingoNumArr.Add(bingoNum);
                }
            }
            return bingoNumArr;
        }
        
        private void btn_createSetOfNum_Click(object sender, EventArgs e)
        {
            arrSolidNum.Clear();
            int numOfNum = 10;
            if (cbbox_numOfNum.SelectedItem != null)
            {
                string selectedValue = cbbox_numOfNum.SelectedItem.ToString();

                if (int.TryParse(selectedValue, out numOfNum))
                {

                }
                else
                {
                    MessageBox.Show("");
                }
            }
            if (txt_createSetOfNum.Text.Trim() == "")
            {
                MessageBox.Show("請輸入欲產生的號碼筆數");
                return;
            }
            if (tempArr.Count >= numOfNum)
            {
                MessageBox.Show("無法將欲固定數字的數量大於每筆號碼產生的數量");
                return;
            }
            bool convert = false;
            convert = int.TryParse(txt_createSetOfNum.Text, out int createSetOfNum);
            if (!convert)
            {
                MessageBox.Show("輸入內容有誤");
                txt_createSetOfNum.Text = "";
                return;
            }
            if (createSetOfNum <= 0)
            {
                MessageBox.Show("你不能產生小於一的筆數");
                return;
            }
            List<List<int>> solidNumSet = new List<List<int>>();
            for (int i = 0; i < tempArr.Count; i++)
            {
                arrSolidNum.Add(tempArr[i]);
                NumButtons[tempArr[i] - 1].BackColor = Color.LightGreen;
            }

            while (solidNumSet.Count < createSetOfNum)
            {

                if (solidNumSet.Count == 0)
                {
                    bingoNumArr = createNum(numOfNum, arrSolidNum);
                }
                else
                {
                    bool repeat = true;
                    while (repeat)
                    {
                        bingoNumArr = createNum(numOfNum, arrSolidNum);
                        for (int i = 0; i < solidNumSet.Count; i++)
                        {
                            IEnumerable<int> repeatNum = bingoNumArr.Intersect(solidNumSet[i]);
                            if (repeatNum.Count() == numOfNum)
                            {
                                Console.WriteLine("repeat");
                                break;
                            }
                            else if (i == solidNumSet.Count - 1)
                            {
                                repeat = false;
                            }
                        }
                    }
                }
                tempArr.Clear();
                bingoNumArr.Sort();
                addNumSet(bingoNumArr);
                solidNumSet.Add(bingoNumArr);
                for (int i = 0; i < bingoNumArr.Count; i++)
                {
                    tempArr.Add(bingoNumArr[i]);
                }                
                for (int i = 0; i < NumButtons.Count; i++)
                {
                    if (NumButtons[i].BackColor != Color.LightGreen)
                    {
                        NumButtons[i].BackColor = Color.Orange;
                    }
                }   
                for (int i = 0; i < tempArr.Count; i++)
                {
                    if (NumButtons[tempArr[i] - 1].BackColor != Color.LightGreen)
                    {
                        NumButtons[tempArr[i] - 1].BackColor = Color.DarkRed;
                    }
                }               
                setSelectedBtn();
                setNumSet();
            }
        }

        private void btn_clearHistory_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要清除紀錄", "清除紀錄", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) //防止誤觸
            {
                arrLottoNum.Clear();
                superNum = -1;
                lBox_history.Items.Clear();
                accPrize = 0;
                accSet = 0;
                accumulatePrize();
                accumulateSet();
                totalMoney = 0;
                setTotalMoney();
                income = 0;
                setIncome();
            }
        }

        private List<int> match(List<int> arrMatchingNum, int bingoOdds, bool superNum, bool comparing, string comparingGame, int ComparingOdds, bool oddAndEven, string oddAndEvenGame, int oddAndEvenOdds)
        {
            List<int> bingoPrize = bingoMatch(arrMatchingNum, bingoOdds, superNum);
            int oddAndEvenPrize = 0;
            int comaparingPrize = 0;
            if(comparing)
            {
                comaparingPrize = comparingGameMatch(comparingGame, ComparingOdds);
            }
            if (oddAndEven)
            {
                oddAndEvenPrize = oddAndEvenMatch(oddAndEvenGame, oddAndEvenOdds);
            }
            bingoPrize[1] = bingoPrize[1] + comaparingPrize + oddAndEvenPrize;
            if(bingoPrize[1] > 100000000)
            {
                bingoPrize[1] = 100000000;
            }
            return bingoPrize;
        }

        private List<int> bingoMatch(List<int> arrMatchingNum, int odds, bool superNum)
        {
            IEnumerable<int> matchedNum = arrLottoNum.Intersect(arrMatchingNum);
            int match = matchedNum.Count();
            int winPrize = 0;
            int bingoWinPrize = 0;
            double superNumOdds = 1;
            if (arrMatchingNum.Count == 10)
            {
                switch (match)
                {
                    case 10:
                        bingoWinPrize = 5000000 * match; superNumOdds = 2.5f; break;
                    case 9:
                        bingoWinPrize = 250000 * match; superNumOdds = 2.5f; break;
                    case 8:
                        bingoWinPrize = 25000 * match; superNumOdds = 2.5f; break;
                    case 7:
                        bingoWinPrize = 2500 * match; superNumOdds = 2.5f; break;
                    case 6:
                        bingoWinPrize = 250 * match; superNumOdds = 3; break;
                    case 5:
                        bingoWinPrize = 25 * match; superNumOdds = 3; break;
                    case 0:
                        bingoWinPrize = 25 * match; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 9)
            {
                switch (match)
                {
                    case 9:
                        bingoWinPrize = 1000000 * match; superNumOdds = 2.5f; break;
                    case 8:
                        bingoWinPrize = 100000 * match; superNumOdds = 2.5f; break;
                    case 7:
                        bingoWinPrize = 3000 * match; superNumOdds = 3; break;
                    case 6:
                        bingoWinPrize = 500 * match; superNumOdds = 2.5f; break;
                    case 5:
                        bingoWinPrize = 100 * match; superNumOdds = 2.5f; break;
                    case 4:
                        bingoWinPrize = 25 * match; superNumOdds = 3; break;
                    case 0:
                        bingoWinPrize = 25 * match; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 8)
            {
                switch (match)
                {
                    case 8:
                        bingoWinPrize = 500000 * match; superNumOdds = 2.5f; break;
                    case 7:
                        bingoWinPrize = 20000 * match; superNumOdds = 2.5f; break;
                    case 6:
                        bingoWinPrize = 1000 * match; superNumOdds = 2.5f; break;
                    case 5:
                        bingoWinPrize = 200 * match; superNumOdds = 2.5f; break;
                    case 4:
                        bingoWinPrize = 25 * match; superNumOdds = 3; break;
                    case 0:
                        bingoWinPrize = 25 * match; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 7)
            {
                switch (match)
                {
                    case 7:
                        bingoWinPrize = 80000 * match; superNumOdds = 2.5f; break;
                    case 6:
                        bingoWinPrize = 3000 * match; superNumOdds = 2.5f; break;
                    case 5:
                        bingoWinPrize = 300 * match; superNumOdds = 2.5f; break;
                    case 4:
                        bingoWinPrize = 50 * match; superNumOdds = 2.5f; break;
                    case 3:
                        bingoWinPrize = 25 * match; superNumOdds = 3; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 6)
            {
                switch (match)
                {
                    case 6:
                        bingoWinPrize = 25000 * match; superNumOdds = 2.5f; break;
                    case 5:
                        bingoWinPrize = 1000 * match; superNumOdds = 2.5f; break;
                    case 4:
                        bingoWinPrize = 200 * match; superNumOdds = 2.5f; break;
                    case 3:
                        bingoWinPrize = 25 * match; superNumOdds = 3; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 5)
            {
                switch (match)
                {
                    case 5:
                        bingoWinPrize = 7500 * match; superNumOdds = 8 / 3; break;
                    case 4:
                        bingoWinPrize = 500 * match; superNumOdds = 3; break;
                    case 3:
                        bingoWinPrize = 50 * match; superNumOdds = 3; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 4)
            {
                switch (match)
                {
                    case 4:
                        bingoWinPrize = 1000 * match; superNumOdds = 3; break;
                    case 3:
                        bingoWinPrize = 100 * match; superNumOdds = 3; break;
                    case 2:
                        bingoWinPrize = 25 * match; superNumOdds = 3; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 3)
            {
                switch (match)
                {
                    case 3:
                        bingoWinPrize = 500 * match; superNumOdds = 3; break;
                    case 2:
                        bingoWinPrize = 50 * match; superNumOdds = 3; break;
                    default:
                        break;
                }
            }
            else if (arrMatchingNum.Count == 2)
            {
                switch (match)
                {
                    case 2:
                        bingoWinPrize = 75 * match; superNumOdds = 8 / 3; break;
                    case 1:
                        bingoWinPrize = 25 * match; superNumOdds = 3; break;
                    default:
                        break;
                }
            }
            else
            {
                switch (match)
                {
                    case 1:
                        bingoWinPrize = 50 * match; superNumOdds = 3; break;
                    default:
                        break;
                }
            }
            if (superNum == true && arrMatchingNum.IndexOf(arrLottoNum[19]) != -1)
            {
                if(bingoWinPrize == 0)
                {
                    winPrize = 25 * odds;
                }
                else
                {
                    winPrize = (int)Math.Floor(bingoWinPrize * superNumOdds * odds);
                }
            }
            else
            {
                winPrize = bingoWinPrize;
            }
            List<int> bingoMatchResult = new List<int> { match, winPrize };
            return bingoMatchResult;
        }

        private int comparingGameMatch(string comparingGame, int odds)
        {
            int comparingPrize = 0;
            if (comparingGame == comparingResult)
            {
                comparingPrize = 150 * odds;
            }
            return comparingPrize;
        }
   
        private int oddAndEvenMatch(string oddAndEven, int odds)
        {
            int oddAndEvenPrize = 0;
            if (oddAndEven == oddAndEvenResult && oddAndEvenResult == "小單")
            {
                oddAndEvenPrize = 45 * odds;
            }
            else if (oddAndEven == oddAndEvenResult && oddAndEvenResult == "小雙")
            {
                oddAndEvenPrize = 45 * odds; 
            }
            else if (oddAndEven == oddAndEvenResult && oddAndEvenResult == "單")
            {
                oddAndEvenPrize = 150 * odds;
            }
            else if (oddAndEven == oddAndEvenResult && oddAndEvenResult == "雙")
            {
                oddAndEvenPrize = 150 * odds;
            }
            else if (oddAndEven == oddAndEvenResult && oddAndEvenResult == "和")
            {
                oddAndEvenPrize = 70 *odds;
            }
            return oddAndEvenPrize;
        }
    }
}
