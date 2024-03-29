namespace BMI_calculator
{
    public partial class Form1 : Form
    {
        private string name = string.Empty;
        private BMICalculator bmiCalculator = new BMICalculator();
        private SavingPlan savingPlan = new SavingPlan();
        private BMRCalculator bmrCalculator = new BMRCalculator();
        public Form1()
        {
            InitializeComponent();
            //Begin my work here

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text += " by Ahmed Radwan";

            // Set the default unit to metric and update the height text accordingly
            usUnitBtn.Checked = false;
            metricUnitBtn.Checked = true;
            UpdateUnit();
        }

        #region Task 1

        // Update the height text based on the selected unit
        private void UpdateUnit()
        {
            if (usUnitBtn.Checked)
            {
                labelHeight.Text = "Height (ft, in)";
                labelWeight.Text = "Weight (lb)";
                txtInch.Visible = true;
                ftLabel.Visible = true;
                inLabel.Visible = true;
                normalBMlLabel.Text = "Normal BMI is between 18.50 and 24.9";
                bmiCalculator.SetUnit(UnitTypes.Imperial);


            }
            else
            {
                labelHeight.Text = "Height (cm)";
                labelWeight.Text = "Weight (kg)";
                txtInch.Visible = false;
                ftLabel.Visible = false;
                inLabel.Visible = false;
                normalBMlLabel.Text = "Normal BMI is between 18.50 and 24.9";
                bmiCalculator.SetUnit(UnitTypes.Metric);


            }
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnit();
        }

        private void UsUnitBtn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnit();
        }
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //1. Read input
            bool ok = ReadInputBMI();


            if (ok)
            {
                //2. Calculate BMI and display results
                CalculateAndDisplayResults();

                // Calculate and display normal weight range
                string normalWeightRange = bmiCalculator.CalculateNormalWeightRange();
                normalLabel.Text = normalWeightRange;

            }


        }

        private void CalculateAndDisplayResults()
        {
            double bmi = bmiCalculator.CalculateBMI();

            BMIresultLabel.Text = bmi.ToString("f2");
            weightResultLabel.Text = bmiCalculator.BMIWeightCategory(bmi).ToString();
            resultsGroupBox.Text = "Results for " + name;
        }
        private bool ReadInputBMI()
        {
            ReadName();
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();
            ReadUnit();
            return heightOK && weightOK;
        }
        private void ReadUnit()
        {
            if (metricUnitBtn.Checked)
            {
                bmiCalculator.SetUnit(UnitTypes.Metric);
            }
            else if (usUnitBtn.Checked)
            {
                bmiCalculator.SetUnit(UnitTypes.Imperial);
            }
        }
        private void ReadName()
        {
            name = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                bmiCalculator.SetName(name); // Save the name in the BMI calculator
            }
            else
            {
                bmiCalculator.SetName("Unknown");
            }
            resultsGroupBox.Text = "Results for " + name;
        }

        private bool ReadHeight()
        {
            double height = 0;
            if (usUnitBtn.Checked)
            {
                if (!double.TryParse(txtfoot.Text, out double feet))
                {
                    MessageBox.Show("Please enter a valid height in feet", "Error");
                    txtfoot.Focus();
                    return false; // Return false immediately if parsing fails
                }
                if (!double.TryParse(txtInch.Text, out double inch))
                {
                    MessageBox.Show("Please enter a valid height in inches", "Error");
                    txtInch.Focus();
                    return false; // Return false immediately if parsing fails
                }
                height = (feet * 12) + inch;
            }
            else if (!double.TryParse(txtfoot.Text, out height))
            {
                MessageBox.Show("Please enter a valid height in cm", "Error");
                txtfoot.Focus();
                return false; // Return false immediately if parsing fails
            }


            // Save the height in the BMI calculator
            bmiCalculator.SetHeight(height);
            return true; // Return true if parsing and conversion are successful
        }


        private bool ReadWeight()
        {
            double weight;
            bool ok = double.TryParse(txtweight.Text, out weight);
            if (!ok)
            {
                MessageBox.Show("Invalid weight value", "Error");
            }
            Console.WriteLine("Weight: " + weight);
            // Save the weight in the BMI calculator
            bmiCalculator.SetWeight(weight);
            return ok;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }





        #endregion


        #region Task 2

        private void CalculateSavingButton_Clicked(object sender, EventArgs e)
        {
            //Input validation
            double initialDeposit = 0;
            if (!double.TryParse(InitialDepositTxt.Text, out initialDeposit))
            {
                MessageBox.Show("Invalid initial deposit value", "Error");
                InitialDepositTxt.Focus();
                return;
            }

            double monthlyDeposit = 0;
            if (!double.TryParse(MonthlyDepositTxt.Text, out monthlyDeposit))
            {
                MessageBox.Show("Invalid monthly deposit value", "Error");
                MonthlyDepositTxt.Focus();
                return;
            }

            double period = 0;
            if (!double.TryParse(PeriodTxt.Text, out period))
            {
                MessageBox.Show("Invalid period value", "Error");
                PeriodTxt.Focus();
                return;
            }

            double growthRate = 0;
            if (!double.TryParse(GrowthTxt.Text, out growthRate))
            {
                MessageBox.Show("Invalid growth rate value", "Error");
                GrowthTxt.Focus();
                return;
            }

            double fees = 0;
            if (!double.TryParse(FeesTxt.Text, out fees))
            {
                MessageBox.Show("Invalid fees value", "Error");
                FeesTxt.Focus();
                return;
            }

            // Set the values in the savings plan calculator
            savingPlan.SetInitialDeposit(initialDeposit);
            savingPlan.SetMonthlyDeposit(monthlyDeposit);
            savingPlan.SetPeriod(period);
            savingPlan.SetGrowthRate(growthRate);
            savingPlan.SetFees(fees);

            // Get the results and display them
            AmountPaidOutput.Text = savingPlan.CalculateAmountPaid().ToString("f2");
            AmountEarnedOutput.Text = savingPlan.CalculateAmountEarned().ToString("f2");
            FinalBalanceOutput.Text = savingPlan.CalculateFinalBalance().ToString("f2");
            TotalFeesOutput.Text = savingPlan.CalculateTotalFees().ToString("f2");

        }

        #endregion

        #region Task 3

        private void CalculateBMRButton_Click(object sender, EventArgs e)
        {
            // Input validation
            //Set the name to be displayed in the results
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                name = "Unknown"; // Set a default name if the user did not enter a name
            }


            // Read the height
            double height = 0;
            if (usUnitBtn.Checked)
            {
                if (!double.TryParse(txtfoot.Text, out double feet))
                {
                    MessageBox.Show("Please enter a valid height in feet", "Error");
                    txtfoot.Focus();
                    return;
                }
                if (!double.TryParse(txtInch.Text, out double inch))
                {
                    MessageBox.Show("Please enter a valid height in inches", "Error");
                    txtInch.Focus();
                    return;
                }
                // Convert height to centimeters
                height = (feet * 12 + inch) * 2.54; // Convert feet and inches to centimeters
            }
            else if (!double.TryParse(txtfoot.Text, out height))
            {
                MessageBox.Show("Please enter a valid height in cm", "Error");
                txtfoot.Focus();
                return;
            }

            // Read the weight
            double weight;
            if (usUnitBtn.Checked)
            {
                if (!double.TryParse(txtweight.Text, out double weightInLbs))
                {
                    MessageBox.Show("Please enter a valid weight in pounds", "Error");
                    txtweight.Focus();
                    return;
                }
                // Convert pounds to kilograms
                weight = weightInLbs * 0.453592; // 1 lb = 0.453592 kg
            }
            else
            {
                if (!double.TryParse(txtweight.Text, out weight))
                {
                    MessageBox.Show("Please enter a valid weight in kilograms", "Error");
                    txtweight.Focus();
                    return;
                }
            }



            // Read the age
            int age;
            if (!int.TryParse(inputAge.Text, out age))
            {
                MessageBox.Show("Invalid age value", "Error");
                inputAge.Focus();
                return;
            }


            // Set the values in the BMR calculator
            bmrCalculator.SetWeight(weight);
            bmrCalculator.SetHeight(height);
            bmrCalculator.SetAge(age);

            // Set gender based on radio button selection
            if (maleRadioButton.Checked)
            {
                bmrCalculator.SetGender(Gender.Male);
            }
            else if (femaleRadioButton.Checked)
            {
                bmrCalculator.SetGender(Gender.Female);
            }
            else
            {
                MessageBox.Show("Please select a gender", "Error");
                return; // Abort further processing if gender is not selected
            }

            // Set activity level based on radio button selection
            if (sedentaryRadioButton.Checked)
            {
                bmrCalculator.SetActivityLevel(ActivityLevel.Sedentary);
            }
            else if (lightlyActiveRadioButton.Checked)
            {
                bmrCalculator.SetActivityLevel(ActivityLevel.LightlyActive);
            }
            else if (moderatelyActiveRadioButton.Checked)
            {
                bmrCalculator.SetActivityLevel(ActivityLevel.ModeratelyActive);
            }
            else if (veryActiveRadioButton.Checked)
            {
                bmrCalculator.SetActivityLevel(ActivityLevel.VeryActive);
            }
            else if (extraActiveRadioButton.Checked)
            {
                bmrCalculator.SetActivityLevel(ActivityLevel.ExtraActive);
            }
            else
            {
                MessageBox.Show("Please select an activity level", "Error");
                return; // Abort further processing if activity level is not selected
            }

            // Calculate BMR and display the results
            // Clear existing labels
            bmrResults.Text = ""; // Assuming labelBMRResults is the label where you want to display the results

            // Add BMR results for name
            bmrResults.Text += $"BMR Results for {name.ToUpper()}\n\n";

            // Calculate and display BMR
            double bmr = bmrCalculator.CalculateBMR();
            bmrResults.Text += $"Your BMR:                                                                      {bmr:f1} \n";

            // Calculate and display Calories to Maintain Weight
            double caloriesToMaintainWeight = bmrCalculator.CalculateBMRToKeepWeight();
            bmrResults.Text += $"Calories to Maintain Weight:                                        {caloriesToMaintainWeight:f1} \n";

            // Calculate and display Calories to lose 0.5 kg per week
            double caloriesToLoseHalfKg = bmrCalculator.CalculateBMRToLoseOrGainWeight(-0.5);
            bmrResults.Text += $"Calories to lose 0.5 kg per week:                                  {caloriesToLoseHalfKg:f1} \n";

            // Calculate and display Calories to lose 1 kg per week
            double caloriesToLoseOneKg = bmrCalculator.CalculateBMRToLoseOrGainWeight(-1);
            bmrResults.Text += $"Calories to lose 1 kg per week:                                     {caloriesToLoseOneKg:f1} \n";

            // Calculate and display Calories to gain 0.5 kg per week
            double caloriesToGainHalfKg = bmrCalculator.CalculateBMRToLoseOrGainWeight(0.5);
            bmrResults.Text += $"Calories to gain 0.5 kg per week:                                  {caloriesToGainHalfKg:f1} \n";

            // Calculate and display Calories to gain 1 kg per week
            double caloriesToGainOneKg = bmrCalculator.CalculateBMRToLoseOrGainWeight(1);
            bmrResults.Text += $"Calories to gain 1 kg per week:                                     {caloriesToGainOneKg:f1} \n\n ";


            bmrResults.Text += "Losing more than 1000 calories per day is to be avoided.";

        }
        #endregion

    }
}
