
namespace BMI_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelHeight = new Label();
            labelWeight = new Label();
            label4 = new Label();
            labelBMI = new Label();
            BMIresultLabel = new Label();
            weightResultLabel = new Label();
            normalBMlLabel = new Label();
            calculateBtn = new Button();
            metricUnitBtn = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            unitGroupBox = new GroupBox();
            usUnitBtn = new RadioButton();
            resultsGroupBox = new GroupBox();
            normalLabel = new Label();
            txtweight = new TextBox();
            txtfoot = new TextBox();
            txtName = new TextBox();
            txtInch = new TextBox();
            menuStrip1 = new MenuStrip();
            ftLabel = new Label();
            inLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            FeesTxt = new TextBox();
            GrowthTxt = new TextBox();
            PeriodTxt = new TextBox();
            MonthlyDepositTxt = new TextBox();
            InitialDepositTxt = new TextBox();
            FeesLabel = new Label();
            GrowthLabel = new Label();
            PeriodLabel = new Label();
            MonthlyDepositLabel = new Label();
            InitialDepositlabel = new Label();
            CalculateSavingButton = new Button();
            groupBox3 = new GroupBox();
            AmountPaidOutput = new Label();
            AmountEarnedOutput = new Label();
            FinalBalanceOutput = new Label();
            TotalFeesOutput = new Label();
            LabelAmountPaid = new Label();
            LabelAmountEarned = new Label();
            LabelFinalBalance = new Label();
            LabelTotalFees = new Label();
            groupBox4 = new GroupBox();
            bmrResults = new Label();
            inputAge = new TextBox();
            txtAge = new Label();
            CalculateBMRButton = new Button();
            groupBox6 = new GroupBox();
            extraActiveRadioButton = new RadioButton();
            veryActiveRadioButton = new RadioButton();
            moderatelyActiveRadioButton = new RadioButton();
            lightlyActiveRadioButton = new RadioButton();
            sedentaryRadioButton = new RadioButton();
            groupBox5 = new GroupBox();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            unitGroupBox.SuspendLayout();
            resultsGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(11, 53);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 9F);
            labelHeight.Location = new Point(13, 89);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(123, 20);
            labelHeight.TabIndex = 1;
            labelHeight.Text = "Height (ft and in)";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 9F);
            labelWeight.Location = new Point(13, 127);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(89, 20);
            labelWeight.TabIndex = 2;
            labelWeight.Text = "Weight (lbs)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 92);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 3;
            label4.Text = "Weight Category";
            // 
            // labelBMI
            // 
            labelBMI.AutoSize = true;
            labelBMI.Location = new Point(28, 44);
            labelBMI.Name = "labelBMI";
            labelBMI.Size = new Size(79, 23);
            labelBMI.TabIndex = 4;
            labelBMI.Text = "Your BMI";
            // 
            // BMIresultLabel
            // 
            BMIresultLabel.BorderStyle = BorderStyle.Fixed3D;
            BMIresultLabel.Location = new Point(420, 44);
            BMIresultLabel.Name = "BMIresultLabel";
            BMIresultLabel.Size = new Size(84, 28);
            BMIresultLabel.TabIndex = 5;
            BMIresultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // weightResultLabel
            // 
            weightResultLabel.BorderStyle = BorderStyle.Fixed3D;
            weightResultLabel.Location = new Point(247, 92);
            weightResultLabel.Name = "weightResultLabel";
            weightResultLabel.Size = new Size(257, 32);
            weightResultLabel.TabIndex = 6;
            weightResultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // normalBMlLabel
            // 
            normalBMlLabel.ForeColor = Color.Green;
            normalBMlLabel.Location = new Point(6, 159);
            normalBMlLabel.Name = "normalBMlLabel";
            normalBMlLabel.Size = new Size(416, 23);
            normalBMlLabel.TabIndex = 7;
            normalBMlLabel.Text = "Normal BMI is between 18.50 and 24.9";
            normalBMlLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // calculateBtn
            // 
            calculateBtn.BackColor = SystemColors.ControlLightLight;
            calculateBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            calculateBtn.ForeColor = SystemColors.ActiveCaptionText;
            calculateBtn.Location = new Point(149, 220);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(252, 44);
            calculateBtn.TabIndex = 8;
            calculateBtn.Text = "Calculate BMI";
            calculateBtn.UseVisualStyleBackColor = false;
            calculateBtn.Click += CalculateBtn_Click;
            // 
            // metricUnitBtn
            // 
            metricUnitBtn.Font = new Font("Segoe UI", 9F);
            metricUnitBtn.Location = new Point(6, 37);
            metricUnitBtn.Name = "metricUnitBtn";
            metricUnitBtn.Size = new Size(163, 27);
            metricUnitBtn.TabIndex = 9;
            metricUnitBtn.TabStop = true;
            metricUnitBtn.Text = "Metric Unit (kg cm)";
            metricUnitBtn.UseVisualStyleBackColor = true;
            metricUnitBtn.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // unitGroupBox
            // 
            unitGroupBox.Controls.Add(usUnitBtn);
            unitGroupBox.Controls.Add(metricUnitBtn);
            unitGroupBox.Font = new Font("Segoe UI", 10F);
            unitGroupBox.Location = new Point(355, 60);
            unitGroupBox.Name = "unitGroupBox";
            unitGroupBox.Size = new Size(183, 135);
            unitGroupBox.TabIndex = 10;
            unitGroupBox.TabStop = false;
            unitGroupBox.Text = "Unit";
            // 
            // usUnitBtn
            // 
            usUnitBtn.AutoSize = true;
            usUnitBtn.Font = new Font("Segoe UI", 9F);
            usUnitBtn.Location = new Point(6, 72);
            usUnitBtn.Name = "usUnitBtn";
            usUnitBtn.Size = new Size(145, 24);
            usUnitBtn.TabIndex = 14;
            usUnitBtn.TabStop = true;
            usUnitBtn.Text = "US unit (foot, lbs)";
            usUnitBtn.UseVisualStyleBackColor = true;
            usUnitBtn.CheckedChanged += UsUnitBtn_CheckedChanged;
            // 
            // resultsGroupBox
            // 
            resultsGroupBox.Controls.Add(normalLabel);
            resultsGroupBox.Controls.Add(weightResultLabel);
            resultsGroupBox.Controls.Add(BMIresultLabel);
            resultsGroupBox.Controls.Add(normalBMlLabel);
            resultsGroupBox.Controls.Add(labelBMI);
            resultsGroupBox.Controls.Add(label4);
            resultsGroupBox.Font = new Font("Segoe UI", 10F);
            resultsGroupBox.Location = new Point(14, 263);
            resultsGroupBox.Name = "resultsGroupBox";
            resultsGroupBox.Size = new Size(524, 268);
            resultsGroupBox.TabIndex = 0;
            resultsGroupBox.TabStop = false;
            resultsGroupBox.Text = "Results for ";
            // 
            // normalLabel
            // 
            normalLabel.Font = new Font("Segoe UI", 9F);
            normalLabel.ForeColor = Color.FromArgb(0, 192, 0);
            normalLabel.Location = new Point(43, 202);
            normalLabel.Name = "normalLabel";
            normalLabel.Size = new Size(427, 41);
            normalLabel.TabIndex = 8;
            // 
            // txtweight
            // 
            txtweight.Font = new Font("Segoe UI", 10F);
            txtweight.Location = new Point(135, 122);
            txtweight.Name = "txtweight";
            txtweight.Size = new Size(67, 30);
            txtweight.TabIndex = 11;
            // 
            // txtfoot
            // 
            txtfoot.Font = new Font("Segoe UI", 10F);
            txtfoot.Location = new Point(135, 86);
            txtfoot.Name = "txtfoot";
            txtfoot.Size = new Size(67, 30);
            txtfoot.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(135, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 30);
            txtName.TabIndex = 13;
            // 
            // txtInch
            // 
            txtInch.Font = new Font("Segoe UI", 10F);
            txtInch.Location = new Point(237, 89);
            txtInch.Name = "txtInch";
            txtInch.Size = new Size(49, 30);
            txtInch.TabIndex = 14;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1011, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // ftLabel
            // 
            ftLabel.Location = new Point(199, 87);
            ftLabel.Name = "ftLabel";
            ftLabel.Size = new Size(32, 29);
            ftLabel.TabIndex = 16;
            ftLabel.Text = "ft";
            ftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inLabel
            // 
            inLabel.Location = new Point(290, 91);
            inLabel.Name = "inLabel";
            inLabel.Size = new Size(35, 26);
            inLabel.TabIndex = 17;
            inLabel.Text = "in";
            inLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(inLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ftLabel);
            groupBox1.Controls.Add(labelHeight);
            groupBox1.Controls.Add(txtInch);
            groupBox1.Controls.Add(labelWeight);
            groupBox1.Controls.Add(txtweight);
            groupBox1.Controls.Add(txtfoot);
            groupBox1.Location = new Point(14, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 180);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "BMI Calculator";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FeesTxt);
            groupBox2.Controls.Add(GrowthTxt);
            groupBox2.Controls.Add(PeriodTxt);
            groupBox2.Controls.Add(MonthlyDepositTxt);
            groupBox2.Controls.Add(InitialDepositTxt);
            groupBox2.Controls.Add(FeesLabel);
            groupBox2.Controls.Add(GrowthLabel);
            groupBox2.Controls.Add(PeriodLabel);
            groupBox2.Controls.Add(MonthlyDepositLabel);
            groupBox2.Controls.Add(InitialDepositlabel);
            groupBox2.Location = new Point(569, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 238);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saving Plan";
            // 
            // FeesTxt
            // 
            FeesTxt.Location = new Point(247, 189);
            FeesTxt.Name = "FeesTxt";
            FeesTxt.Size = new Size(148, 27);
            FeesTxt.TabIndex = 9;
            // 
            // GrowthTxt
            // 
            GrowthTxt.Location = new Point(247, 150);
            GrowthTxt.Name = "GrowthTxt";
            GrowthTxt.Size = new Size(148, 27);
            GrowthTxt.TabIndex = 8;
            // 
            // PeriodTxt
            // 
            PeriodTxt.Location = new Point(247, 117);
            PeriodTxt.Name = "PeriodTxt";
            PeriodTxt.Size = new Size(148, 27);
            PeriodTxt.TabIndex = 7;
            // 
            // MonthlyDepositTxt
            // 
            MonthlyDepositTxt.Location = new Point(247, 80);
            MonthlyDepositTxt.Name = "MonthlyDepositTxt";
            MonthlyDepositTxt.Size = new Size(148, 27);
            MonthlyDepositTxt.TabIndex = 6;
            // 
            // InitialDepositTxt
            // 
            InitialDepositTxt.Location = new Point(247, 40);
            InitialDepositTxt.Name = "InitialDepositTxt";
            InitialDepositTxt.Size = new Size(148, 27);
            InitialDepositTxt.TabIndex = 5;
            // 
            // FeesLabel
            // 
            FeesLabel.Location = new Point(19, 192);
            FeesLabel.Name = "FeesLabel";
            FeesLabel.Size = new Size(115, 20);
            FeesLabel.TabIndex = 4;
            FeesLabel.Text = "Fees in %";
            // 
            // GrowthLabel
            // 
            GrowthLabel.Location = new Point(19, 153);
            GrowthLabel.Name = "GrowthLabel";
            GrowthLabel.Size = new Size(196, 20);
            GrowthLabel.TabIndex = 3;
            GrowthLabel.Text = "Growth (or interest) in %";
            // 
            // PeriodLabel
            // 
            PeriodLabel.Location = new Point(19, 117);
            PeriodLabel.Name = "PeriodLabel";
            PeriodLabel.RightToLeft = RightToLeft.No;
            PeriodLabel.Size = new Size(133, 20);
            PeriodLabel.TabIndex = 2;
            PeriodLabel.Text = "Period (years)";
            // 
            // MonthlyDepositLabel
            // 
            MonthlyDepositLabel.Location = new Point(19, 81);
            MonthlyDepositLabel.Name = "MonthlyDepositLabel";
            MonthlyDepositLabel.Size = new Size(133, 20);
            MonthlyDepositLabel.TabIndex = 1;
            MonthlyDepositLabel.Text = "Monthly deposit";
            // 
            // InitialDepositlabel
            // 
            InitialDepositlabel.Location = new Point(19, 43);
            InitialDepositlabel.Name = "InitialDepositlabel";
            InitialDepositlabel.Size = new Size(153, 25);
            InitialDepositlabel.TabIndex = 0;
            InitialDepositlabel.Text = "Initial deposit";
            // 
            // CalculateSavingButton
            // 
            CalculateSavingButton.Location = new Point(645, 295);
            CalculateSavingButton.Name = "CalculateSavingButton";
            CalculateSavingButton.Size = new Size(257, 41);
            CalculateSavingButton.TabIndex = 20;
            CalculateSavingButton.Text = "Calculate saving";
            CalculateSavingButton.UseVisualStyleBackColor = true;
            CalculateSavingButton.Click += CalculateSavingButton_Clicked;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(AmountPaidOutput);
            groupBox3.Controls.Add(AmountEarnedOutput);
            groupBox3.Controls.Add(FinalBalanceOutput);
            groupBox3.Controls.Add(TotalFeesOutput);
            groupBox3.Controls.Add(LabelAmountPaid);
            groupBox3.Controls.Add(LabelAmountEarned);
            groupBox3.Controls.Add(LabelFinalBalance);
            groupBox3.Controls.Add(LabelTotalFees);
            groupBox3.Location = new Point(572, 342);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(417, 189);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Future Value";
            // 
            // AmountPaidOutput
            // 
            AmountPaidOutput.BorderStyle = BorderStyle.Fixed3D;
            AmountPaidOutput.Location = new Point(285, 36);
            AmountPaidOutput.Name = "AmountPaidOutput";
            AmountPaidOutput.Size = new Size(107, 20);
            AmountPaidOutput.TabIndex = 7;
            // 
            // AmountEarnedOutput
            // 
            AmountEarnedOutput.BorderStyle = BorderStyle.Fixed3D;
            AmountEarnedOutput.Location = new Point(285, 70);
            AmountEarnedOutput.Name = "AmountEarnedOutput";
            AmountEarnedOutput.Size = new Size(107, 20);
            AmountEarnedOutput.TabIndex = 8;
            // 
            // FinalBalanceOutput
            // 
            FinalBalanceOutput.BorderStyle = BorderStyle.Fixed3D;
            FinalBalanceOutput.Location = new Point(285, 107);
            FinalBalanceOutput.Name = "FinalBalanceOutput";
            FinalBalanceOutput.Size = new Size(107, 20);
            FinalBalanceOutput.TabIndex = 9;
            // 
            // TotalFeesOutput
            // 
            TotalFeesOutput.BorderStyle = BorderStyle.Fixed3D;
            TotalFeesOutput.Location = new Point(285, 143);
            TotalFeesOutput.Name = "TotalFeesOutput";
            TotalFeesOutput.Size = new Size(107, 20);
            TotalFeesOutput.TabIndex = 10;
            // 
            // LabelAmountPaid
            // 
            LabelAmountPaid.Location = new Point(16, 34);
            LabelAmountPaid.Name = "LabelAmountPaid";
            LabelAmountPaid.Size = new Size(133, 20);
            LabelAmountPaid.TabIndex = 3;
            LabelAmountPaid.Text = "Amount paid";
            // 
            // LabelAmountEarned
            // 
            LabelAmountEarned.Location = new Point(16, 71);
            LabelAmountEarned.Name = "LabelAmountEarned";
            LabelAmountEarned.Size = new Size(153, 20);
            LabelAmountEarned.TabIndex = 4;
            LabelAmountEarned.Text = "Amount earned";
            // 
            // LabelFinalBalance
            // 
            LabelFinalBalance.Location = new Point(16, 109);
            LabelFinalBalance.Name = "LabelFinalBalance";
            LabelFinalBalance.Size = new Size(153, 20);
            LabelFinalBalance.TabIndex = 5;
            LabelFinalBalance.Text = "Final balance";
            // 
            // LabelTotalFees
            // 
            LabelTotalFees.Location = new Point(16, 143);
            LabelTotalFees.Name = "LabelTotalFees";
            LabelTotalFees.Size = new Size(175, 20);
            LabelTotalFees.TabIndex = 6;
            LabelTotalFees.Text = "Total fees";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(bmrResults);
            groupBox4.Controls.Add(inputAge);
            groupBox4.Controls.Add(txtAge);
            groupBox4.Controls.Add(CalculateBMRButton);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(12, 555);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(975, 318);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "BMRCalculator";
            // 
            // bmrResults
            // 
            bmrResults.BackColor = Color.White;
            bmrResults.ForeColor = Color.FromArgb(0, 192, 0);
            bmrResults.Location = new Point(453, 51);
            bmrResults.Name = "bmrResults";
            bmrResults.Size = new Size(511, 253);
            bmrResults.TabIndex = 5;
            // 
            // inputAge
            // 
            inputAge.Location = new Point(66, 161);
            inputAge.Name = "inputAge";
            inputAge.Size = new Size(61, 27);
            inputAge.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.AutoSize = true;
            txtAge.Location = new Point(17, 164);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(36, 20);
            txtAge.TabIndex = 3;
            txtAge.Text = "Age";
            // 
            // CalculateBMRButton
            // 
            CalculateBMRButton.Location = new Point(139, 256);
            CalculateBMRButton.Name = "CalculateBMRButton";
            CalculateBMRButton.Size = new Size(297, 51);
            CalculateBMRButton.TabIndex = 2;
            CalculateBMRButton.Text = "Calculate BMR";
            CalculateBMRButton.UseVisualStyleBackColor = true;
            CalculateBMRButton.Click += CalculateBMRButton_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(extraActiveRadioButton);
            groupBox6.Controls.Add(veryActiveRadioButton);
            groupBox6.Controls.Add(moderatelyActiveRadioButton);
            groupBox6.Controls.Add(lightlyActiveRadioButton);
            groupBox6.Controls.Add(sedentaryRadioButton);
            groupBox6.Location = new Point(137, 37);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(299, 208);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Weekly Activity Level";
            // 
            // extraActiveRadioButton
            // 
            extraActiveRadioButton.AutoSize = true;
            extraActiveRadioButton.Location = new Point(19, 171);
            extraActiveRadioButton.Name = "extraActiveRadioButton";
            extraActiveRadioButton.Size = new Size(250, 24);
            extraActiveRadioButton.TabIndex = 4;
            extraActiveRadioButton.TabStop = true;
            extraActiveRadioButton.Text = "Extra active, hard exercises or job";
            extraActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // veryActiveRadioButton
            // 
            veryActiveRadioButton.AutoSize = true;
            veryActiveRadioButton.Location = new Point(19, 138);
            veryActiveRadioButton.Name = "veryActiveRadioButton";
            veryActiveRadioButton.Size = new Size(193, 24);
            veryActiveRadioButton.TabIndex = 3;
            veryActiveRadioButton.TabStop = true;
            veryActiveRadioButton.Text = "Very active (6 to 7 times)";
            veryActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // moderatelyActiveRadioButton
            // 
            moderatelyActiveRadioButton.AutoSize = true;
            moderatelyActiveRadioButton.Location = new Point(19, 103);
            moderatelyActiveRadioButton.Name = "moderatelyActiveRadioButton";
            moderatelyActiveRadioButton.Size = new Size(245, 24);
            moderatelyActiveRadioButton.TabIndex = 2;
            moderatelyActiveRadioButton.TabStop = true;
            moderatelyActiveRadioButton.Text = "Moderately active ( 3 to 5 times)";
            moderatelyActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // lightlyActiveRadioButton
            // 
            lightlyActiveRadioButton.AutoSize = true;
            lightlyActiveRadioButton.Location = new Point(19, 68);
            lightlyActiveRadioButton.Name = "lightlyActiveRadioButton";
            lightlyActiveRadioButton.Size = new Size(209, 24);
            lightlyActiveRadioButton.TabIndex = 1;
            lightlyActiveRadioButton.TabStop = true;
            lightlyActiveRadioButton.Text = "Lightly active (1 to 3 times)";
            lightlyActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // sedentaryRadioButton
            // 
            sedentaryRadioButton.AutoSize = true;
            sedentaryRadioButton.Location = new Point(19, 36);
            sedentaryRadioButton.Name = "sedentaryRadioButton";
            sedentaryRadioButton.Size = new Size(236, 24);
            sedentaryRadioButton.TabIndex = 0;
            sedentaryRadioButton.TabStop = true;
            sedentaryRadioButton.Text = "Sedentary (little or no exercise)";
            sedentaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(maleRadioButton);
            groupBox5.Controls.Add(femaleRadioButton);
            groupBox5.Location = new Point(23, 37);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(104, 96);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Gender";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(13, 55);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(63, 24);
            maleRadioButton.TabIndex = 2;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(14, 27);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 24);
            femaleRadioButton.TabIndex = 1;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 885);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(CalculateSavingButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(resultsGroupBox);
            Controls.Add(unitGroupBox);
            Controls.Add(calculateBtn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Super Calculator";
            Load += Form1_Load;
            unitGroupBox.ResumeLayout(false);
            unitGroupBox.PerformLayout();
            resultsGroupBox.ResumeLayout(false);
            resultsGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelHeight;
        private Label labelWeight;
        private Label label4;
        private Label labelBMI;
        private Label BMIresultLabel;
        private Label weightResultLabel;
        private Label normalBMlLabel;
        private Button calculateBtn;
        private RadioButton metricUnitBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox unitGroupBox;
        private GroupBox resultsGroupBox;
        private TextBox txtweight;
        private TextBox txtfoot;
        private TextBox txtName;
        private RadioButton usUnitBtn;
        private TextBox txtInch;
        private EventHandler txtName_TextChanged;
        private MenuStrip menuStrip1;
        private Label ftLabel;
        private Label inLabel;
        private Label normalLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button CalculateSavingButton;
        private GroupBox groupBox3;
        private Label FeesLabel;
        private Label GrowthLabel;
        private Label PeriodLabel;
        private Label MonthlyDepositLabel;
        private Label InitialDepositlabel;
        private Label LabelAmountPaid;
        private Label LabelAmountEarned;
        private Label LabelFinalBalance;
        private Label LabelTotalFees;
        private TextBox FeesTxt;
        private TextBox GrowthTxt;
        private TextBox PeriodTxt;
        private TextBox MonthlyDepositTxt;
        private TextBox InitialDepositTxt;
        private Label AmountPaidOutput;
        private Label AmountEarnedOutput;
        private Label FinalBalanceOutput;
        private Label TotalFeesOutput;
        private GroupBox groupBox4;
        private TextBox inputAge;
        private Label txtAge;
        private Button CalculateBMRButton;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Label bmrResults;
        private RadioButton extraActiveRadioButton;
        private RadioButton veryActiveRadioButton;
        private RadioButton moderatelyActiveRadioButton;
        private RadioButton lightlyActiveRadioButton;
        private RadioButton sedentaryRadioButton;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
    }
}
