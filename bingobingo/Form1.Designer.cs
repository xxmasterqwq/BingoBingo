namespace bingobingo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addLottoNum = new System.Windows.Forms.Button();
            this.btn_removeAll = new System.Windows.Forms.Button();
            this.lbl_setOfNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_num = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_bingo = new System.Windows.Forms.Button();
            this.btn_match = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_createSetOfNum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_createSetOfNum = new System.Windows.Forms.TextBox();
            this.cbbox_numOfNum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbox_oddOrEvenOdds = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbox_comparingGame = new System.Windows.Forms.ComboBox();
            this.ckbox_comparingGame = new System.Windows.Forms.CheckBox();
            this.cbbox_comparingGameOdds = new System.Windows.Forms.ComboBox();
            this.ckbox_oddOrEven = new System.Windows.Forms.CheckBox();
            this.cbbox_oddOrEven = new System.Windows.Forms.ComboBox();
            this.ckbox_superNum = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbox_bingoOdds = new System.Windows.Forms.ComboBox();
            this.btn_allMatch = new System.Windows.Forms.Button();
            this.lBox_history = new System.Windows.Forms.ListBox();
            this.lbl_accumulatePrize = new System.Windows.Forms.Label();
            this.lbl_accumulateSet = new System.Windows.Forms.Label();
            this.btn_setSuperNum = new System.Windows.Forms.Button();
            this.btn_cancelSuperNum = new System.Windows.Forms.Button();
            this.btn_clearHistory = new System.Windows.Forms.Button();
            this.lbl_money = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_superNum = new System.Windows.Forms.TextBox();
            this.lbl_clickedBtn = new System.Windows.Forms.Label();
            this.btn_removeSelected = new System.Windows.Forms.Button();
            this.btn_clearAllSelectedNum = new System.Windows.Forms.Button();
            this.lBox_about = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addLottoNum
            // 
            this.btn_addLottoNum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_addLottoNum.Location = new System.Drawing.Point(14, 421);
            this.btn_addLottoNum.Name = "btn_addLottoNum";
            this.btn_addLottoNum.Size = new System.Drawing.Size(102, 36);
            this.btn_addLottoNum.TabIndex = 43;
            this.btn_addLottoNum.Text = "增加為中獎號碼";
            this.btn_addLottoNum.UseVisualStyleBackColor = true;
            this.btn_addLottoNum.Click += new System.EventHandler(this.btn_addLottoNum_Click);
            // 
            // btn_removeAll
            // 
            this.btn_removeAll.Location = new System.Drawing.Point(440, 355);
            this.btn_removeAll.Name = "btn_removeAll";
            this.btn_removeAll.Size = new System.Drawing.Size(124, 44);
            this.btn_removeAll.TabIndex = 39;
            this.btn_removeAll.Text = "刪除所有號碼 -->";
            this.btn_removeAll.UseVisualStyleBackColor = true;
            this.btn_removeAll.Click += new System.EventHandler(this.btn_removeAll_Click);
            // 
            // lbl_setOfNum
            // 
            this.lbl_setOfNum.AutoSize = true;
            this.lbl_setOfNum.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_setOfNum.Location = new System.Drawing.Point(705, 49);
            this.lbl_setOfNum.Name = "lbl_setOfNum";
            this.lbl_setOfNum.Size = new System.Drawing.Size(76, 31);
            this.lbl_setOfNum.TabIndex = 38;
            this.lbl_setOfNum.Text = "共0筆";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(574, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "你的號碼";
            // 
            // lbox_num
            // 
            this.lbox_num.ColumnWidth = 40;
            this.lbox_num.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbox_num.FormattingEnabled = true;
            this.lbox_num.ItemHeight = 24;
            this.lbox_num.Location = new System.Drawing.Point(580, 85);
            this.lbox_num.Name = "lbox_num";
            this.lbox_num.Size = new System.Drawing.Size(833, 364);
            this.lbox_num.TabIndex = 35;
            // 
            // btn_add
            // 
            this.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_add.Location = new System.Drawing.Point(440, 161);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(124, 44);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "增加號碼";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_bingo
            // 
            this.btn_bingo.Location = new System.Drawing.Point(440, 112);
            this.btn_bingo.Name = "btn_bingo";
            this.btn_bingo.Size = new System.Drawing.Size(124, 43);
            this.btn_bingo.TabIndex = 32;
            this.btn_bingo.Text = "自動選號";
            this.btn_bingo.UseVisualStyleBackColor = true;
            this.btn_bingo.Click += new System.EventHandler(this.btn_bingo_Click);
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(591, 463);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(124, 44);
            this.btn_match.TabIndex = 47;
            this.btn_match.Text = "對獎";
            this.btn_match.UseVisualStyleBackColor = true;
            this.btn_match.Click += new System.EventHandler(this.btn_match_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbox_oddOrEvenOdds);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbbox_comparingGame);
            this.groupBox2.Controls.Add(this.ckbox_comparingGame);
            this.groupBox2.Controls.Add(this.cbbox_comparingGameOdds);
            this.groupBox2.Controls.Add(this.ckbox_oddOrEven);
            this.groupBox2.Controls.Add(this.cbbox_oddOrEven);
            this.groupBox2.Controls.Add(this.ckbox_superNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbox_bingoOdds);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 181);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "玩法";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_createSetOfNum);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_createSetOfNum);
            this.groupBox4.Controls.Add(this.cbbox_numOfNum);
            this.groupBox4.Location = new System.Drawing.Point(327, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 181);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "包牌";
            // 
            // btn_createSetOfNum
            // 
            this.btn_createSetOfNum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_createSetOfNum.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_createSetOfNum.Location = new System.Drawing.Point(123, 130);
            this.btn_createSetOfNum.Name = "btn_createSetOfNum";
            this.btn_createSetOfNum.Size = new System.Drawing.Size(88, 32);
            this.btn_createSetOfNum.TabIndex = 55;
            this.btn_createSetOfNum.Text = "產生牌組";
            this.btn_createSetOfNum.UseVisualStyleBackColor = true;
            this.btn_createSetOfNum.Click += new System.EventHandler(this.btn_createSetOfNum_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(11, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "產生筆數";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(49, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "星數";
            // 
            // txt_createSetOfNum
            // 
            this.txt_createSetOfNum.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txt_createSetOfNum.Location = new System.Drawing.Point(123, 86);
            this.txt_createSetOfNum.Name = "txt_createSetOfNum";
            this.txt_createSetOfNum.Size = new System.Drawing.Size(88, 32);
            this.txt_createSetOfNum.TabIndex = 51;
            // 
            // cbbox_numOfNum
            // 
            this.cbbox_numOfNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_numOfNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbox_numOfNum.FormattingEnabled = true;
            this.cbbox_numOfNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbox_numOfNum.Location = new System.Drawing.Point(123, 39);
            this.cbbox_numOfNum.Name = "cbbox_numOfNum";
            this.cbbox_numOfNum.Size = new System.Drawing.Size(88, 29);
            this.cbbox_numOfNum.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(173, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "倍率";
            // 
            // cbbox_oddOrEvenOdds
            // 
            this.cbbox_oddOrEvenOdds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_oddOrEvenOdds.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbox_oddOrEvenOdds.FormattingEnabled = true;
            this.cbbox_oddOrEvenOdds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "6",
            "7",
            "8",
            "10",
            "12",
            "20",
            "50"});
            this.cbbox_oddOrEvenOdds.Location = new System.Drawing.Point(221, 131);
            this.cbbox_oddOrEvenOdds.Name = "cbbox_oddOrEvenOdds";
            this.cbbox_oddOrEvenOdds.Size = new System.Drawing.Size(79, 29);
            this.cbbox_oddOrEvenOdds.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(173, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "倍率";
            // 
            // cbbox_comparingGame
            // 
            this.cbbox_comparingGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_comparingGame.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbox_comparingGame.FormattingEnabled = true;
            this.cbbox_comparingGame.Items.AddRange(new object[] {
            "大",
            "小"});
            this.cbbox_comparingGame.Location = new System.Drawing.Point(89, 89);
            this.cbbox_comparingGame.Name = "cbbox_comparingGame";
            this.cbbox_comparingGame.Size = new System.Drawing.Size(79, 29);
            this.cbbox_comparingGame.TabIndex = 7;
            // 
            // ckbox_comparingGame
            // 
            this.ckbox_comparingGame.AutoSize = true;
            this.ckbox_comparingGame.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbox_comparingGame.Location = new System.Drawing.Point(13, 91);
            this.ckbox_comparingGame.Name = "ckbox_comparingGame";
            this.ckbox_comparingGame.Size = new System.Drawing.Size(77, 25);
            this.ckbox_comparingGame.TabIndex = 6;
            this.ckbox_comparingGame.Text = "比大小";
            this.ckbox_comparingGame.UseVisualStyleBackColor = true;
            this.ckbox_comparingGame.CheckedChanged += new System.EventHandler(this.ckbox_comparingGame_CheckedChanged);
            // 
            // cbbox_comparingGameOdds
            // 
            this.cbbox_comparingGameOdds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_comparingGameOdds.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbox_comparingGameOdds.FormattingEnabled = true;
            this.cbbox_comparingGameOdds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "6",
            "7",
            "8",
            "10",
            "12",
            "20",
            "50"});
            this.cbbox_comparingGameOdds.Location = new System.Drawing.Point(221, 89);
            this.cbbox_comparingGameOdds.Name = "cbbox_comparingGameOdds";
            this.cbbox_comparingGameOdds.Size = new System.Drawing.Size(79, 29);
            this.cbbox_comparingGameOdds.TabIndex = 5;
            // 
            // ckbox_oddOrEven
            // 
            this.ckbox_oddOrEven.AutoSize = true;
            this.ckbox_oddOrEven.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbox_oddOrEven.Location = new System.Drawing.Point(13, 135);
            this.ckbox_oddOrEven.Name = "ckbox_oddOrEven";
            this.ckbox_oddOrEven.Size = new System.Drawing.Size(61, 25);
            this.ckbox_oddOrEven.TabIndex = 4;
            this.ckbox_oddOrEven.Text = "單雙";
            this.ckbox_oddOrEven.UseVisualStyleBackColor = true;
            this.ckbox_oddOrEven.CheckedChanged += new System.EventHandler(this.ckbox_oddOrEven_CheckedChanged);
            // 
            // cbbox_oddOrEven
            // 
            this.cbbox_oddOrEven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_oddOrEven.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbox_oddOrEven.FormattingEnabled = true;
            this.cbbox_oddOrEven.Items.AddRange(new object[] {
            "單",
            "小單",
            "雙",
            "小雙"});
            this.cbbox_oddOrEven.Location = new System.Drawing.Point(89, 131);
            this.cbbox_oddOrEven.Name = "cbbox_oddOrEven";
            this.cbbox_oddOrEven.Size = new System.Drawing.Size(79, 29);
            this.cbbox_oddOrEven.TabIndex = 3;
            // 
            // ckbox_superNum
            // 
            this.ckbox_superNum.AutoSize = true;
            this.ckbox_superNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbox_superNum.Location = new System.Drawing.Point(186, 49);
            this.ckbox_superNum.Name = "ckbox_superNum";
            this.ckbox_superNum.Size = new System.Drawing.Size(93, 25);
            this.ckbox_superNum.TabIndex = 2;
            this.ckbox_superNum.Text = "超級號碼";
            this.ckbox_superNum.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "賓果倍率";
            // 
            // cbbox_bingoOdds
            // 
            this.cbbox_bingoOdds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbox_bingoOdds.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbox_bingoOdds.FormattingEnabled = true;
            this.cbbox_bingoOdds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "6",
            "7",
            "8",
            "10",
            "12",
            "20",
            "50"});
            this.cbbox_bingoOdds.Location = new System.Drawing.Point(89, 47);
            this.cbbox_bingoOdds.Name = "cbbox_bingoOdds";
            this.cbbox_bingoOdds.Size = new System.Drawing.Size(79, 29);
            this.cbbox_bingoOdds.TabIndex = 0;
            // 
            // btn_allMatch
            // 
            this.btn_allMatch.Location = new System.Drawing.Point(721, 463);
            this.btn_allMatch.Name = "btn_allMatch";
            this.btn_allMatch.Size = new System.Drawing.Size(124, 44);
            this.btn_allMatch.TabIndex = 49;
            this.btn_allMatch.Text = "全部號碼對獎";
            this.btn_allMatch.UseVisualStyleBackColor = true;
            this.btn_allMatch.Click += new System.EventHandler(this.btn_allMatch_Click);
            // 
            // lBox_history
            // 
            this.lBox_history.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_history.FormattingEnabled = true;
            this.lBox_history.ItemHeight = 20;
            this.lBox_history.Location = new System.Drawing.Point(12, 660);
            this.lBox_history.Name = "lBox_history";
            this.lBox_history.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lBox_history.Size = new System.Drawing.Size(967, 204);
            this.lBox_history.TabIndex = 50;
            // 
            // lbl_accumulatePrize
            // 
            this.lbl_accumulatePrize.AutoSize = true;
            this.lbl_accumulatePrize.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_accumulatePrize.Location = new System.Drawing.Point(693, 576);
            this.lbl_accumulatePrize.Name = "lbl_accumulatePrize";
            this.lbl_accumulatePrize.Size = new System.Drawing.Size(241, 35);
            this.lbl_accumulatePrize.TabIndex = 52;
            this.lbl_accumulatePrize.Text = "累計中獎金額: 0 元";
            // 
            // lbl_accumulateSet
            // 
            this.lbl_accumulateSet.AutoSize = true;
            this.lbl_accumulateSet.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_accumulateSet.Location = new System.Drawing.Point(692, 541);
            this.lbl_accumulateSet.Name = "lbl_accumulateSet";
            this.lbl_accumulateSet.Size = new System.Drawing.Size(153, 35);
            this.lbl_accumulateSet.TabIndex = 53;
            this.lbl_accumulateSet.Text = "已對獎 0 筆";
            // 
            // btn_setSuperNum
            // 
            this.btn_setSuperNum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_setSuperNum.Location = new System.Drawing.Point(356, 421);
            this.btn_setSuperNum.Name = "btn_setSuperNum";
            this.btn_setSuperNum.Size = new System.Drawing.Size(94, 36);
            this.btn_setSuperNum.TabIndex = 55;
            this.btn_setSuperNum.Text = "設為超級號碼";
            this.btn_setSuperNum.UseVisualStyleBackColor = true;
            this.btn_setSuperNum.Click += new System.EventHandler(this.btn_setSuperNum_Click);
            // 
            // btn_cancelSuperNum
            // 
            this.btn_cancelSuperNum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_cancelSuperNum.Location = new System.Drawing.Point(456, 421);
            this.btn_cancelSuperNum.Name = "btn_cancelSuperNum";
            this.btn_cancelSuperNum.Size = new System.Drawing.Size(94, 36);
            this.btn_cancelSuperNum.TabIndex = 56;
            this.btn_cancelSuperNum.Text = "取消超級號碼";
            this.btn_cancelSuperNum.UseVisualStyleBackColor = true;
            this.btn_cancelSuperNum.Click += new System.EventHandler(this.btn_cancelSuperNum_Click);
            // 
            // btn_clearHistory
            // 
            this.btn_clearHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_clearHistory.Location = new System.Drawing.Point(590, 608);
            this.btn_clearHistory.Name = "btn_clearHistory";
            this.btn_clearHistory.Size = new System.Drawing.Size(94, 36);
            this.btn_clearHistory.TabIndex = 57;
            this.btn_clearHistory.Text = "清除紀錄";
            this.btn_clearHistory.UseVisualStyleBackColor = true;
            this.btn_clearHistory.Click += new System.EventHandler(this.btn_clearHistory_Click);
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_money.Location = new System.Drawing.Point(830, 49);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(136, 31);
            this.lbl_money.TabIndex = 58;
            this.lbl_money.Text = "已投注 0 元";
            // 
            // lbl_income
            // 
            this.lbl_income.AutoSize = true;
            this.lbl_income.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_income.Location = new System.Drawing.Point(693, 611);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(167, 35);
            this.lbl_income.TabIndex = 59;
            this.lbl_income.Text = "淨收益 : 0 元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(170, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "超級號碼";
            // 
            // txt_superNum
            // 
            this.txt_superNum.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txt_superNum.Location = new System.Drawing.Point(262, 421);
            this.txt_superNum.Name = "txt_superNum";
            this.txt_superNum.Size = new System.Drawing.Size(88, 32);
            this.txt_superNum.TabIndex = 60;
            // 
            // lbl_clickedBtn
            // 
            this.lbl_clickedBtn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clickedBtn.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_clickedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_clickedBtn.Location = new System.Drawing.Point(430, 78);
            this.lbl_clickedBtn.Name = "lbl_clickedBtn";
            this.lbl_clickedBtn.Size = new System.Drawing.Size(144, 31);
            this.lbl_clickedBtn.TabIndex = 62;
            this.lbl_clickedBtn.Text = "已選 0 個數字";
            this.lbl_clickedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_removeSelected
            // 
            this.btn_removeSelected.Location = new System.Drawing.Point(440, 305);
            this.btn_removeSelected.Name = "btn_removeSelected";
            this.btn_removeSelected.Size = new System.Drawing.Size(124, 44);
            this.btn_removeSelected.TabIndex = 34;
            this.btn_removeSelected.Text = "刪除所選號碼 -->";
            this.btn_removeSelected.UseVisualStyleBackColor = true;
            this.btn_removeSelected.Click += new System.EventHandler(this.btn_removeSelected_Click);
            // 
            // btn_clearAllSelectedNum
            // 
            this.btn_clearAllSelectedNum.Location = new System.Drawing.Point(440, 211);
            this.btn_clearAllSelectedNum.Name = "btn_clearAllSelectedNum";
            this.btn_clearAllSelectedNum.Size = new System.Drawing.Size(124, 44);
            this.btn_clearAllSelectedNum.TabIndex = 63;
            this.btn_clearAllSelectedNum.Text = "<-- 清除所有選號";
            this.btn_clearAllSelectedNum.UseVisualStyleBackColor = true;
            this.btn_clearAllSelectedNum.Click += new System.EventHandler(this.btn_clearAllSelectedNum_Click);
            // 
            // lBox_about
            // 
            this.lBox_about.BackColor = System.Drawing.SystemColors.Info;
            this.lBox_about.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox_about.ForeColor = System.Drawing.Color.Green;
            this.lBox_about.FormattingEnabled = true;
            this.lBox_about.ItemHeight = 24;
            this.lBox_about.Location = new System.Drawing.Point(1036, 574);
            this.lBox_about.MultiColumn = true;
            this.lBox_about.Name = "lBox_about";
            this.lBox_about.Size = new System.Drawing.Size(377, 292);
            this.lBox_about.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(1030, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 35);
            this.label8.TabIndex = 65;
            this.label8.Text = "使用說明";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 68);
            this.label9.TabIndex = 66;
            this.label9.Text = "賓果賓果 投注站";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1436, 907);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lBox_about);
            this.Controls.Add(this.btn_clearAllSelectedNum);
            this.Controls.Add(this.lbox_num);
            this.Controls.Add(this.lbl_clickedBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_superNum);
            this.Controls.Add(this.lbl_income);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.btn_clearHistory);
            this.Controls.Add(this.btn_cancelSuperNum);
            this.Controls.Add(this.btn_setSuperNum);
            this.Controls.Add(this.lbl_accumulateSet);
            this.Controls.Add(this.lbl_accumulatePrize);
            this.Controls.Add(this.btn_allMatch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_match);
            this.Controls.Add(this.btn_addLottoNum);
            this.Controls.Add(this.btn_removeAll);
            this.Controls.Add(this.lbl_setOfNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_removeSelected);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_bingo);
            this.Controls.Add(this.lBox_history);
            this.Name = "Form1";
            this.Text = "Bingo Bingo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addLottoNum;
        private System.Windows.Forms.Button btn_removeAll;
        private System.Windows.Forms.Label lbl_setOfNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox_num;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_bingo;
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_allMatch;
        private System.Windows.Forms.ListBox lBox_history;
        private System.Windows.Forms.Label lbl_accumulatePrize;
        private System.Windows.Forms.Label lbl_accumulateSet;
        private System.Windows.Forms.Button btn_setSuperNum;
        private System.Windows.Forms.Button btn_cancelSuperNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbox_bingoOdds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbox_oddOrEvenOdds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbox_comparingGame;
        private System.Windows.Forms.CheckBox ckbox_comparingGame;
        private System.Windows.Forms.ComboBox cbbox_comparingGameOdds;
        private System.Windows.Forms.CheckBox ckbox_oddOrEven;
        private System.Windows.Forms.ComboBox cbbox_oddOrEven;
        private System.Windows.Forms.CheckBox ckbox_superNum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_createSetOfNum;
        private System.Windows.Forms.ComboBox cbbox_numOfNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_createSetOfNum;
        private System.Windows.Forms.Button btn_clearHistory;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label lbl_income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_superNum;
        private System.Windows.Forms.Label lbl_clickedBtn;
        private System.Windows.Forms.Button btn_removeSelected;
        private System.Windows.Forms.Button btn_clearAllSelectedNum;
        private System.Windows.Forms.ListBox lBox_about;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

