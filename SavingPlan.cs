using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BMI_calculator
{
    /// <summary>
    /// Class to calculate the total amount paid, 
    /// total earnings, total fees paid and final balance of a saving plan
    /// </summary>
    class SavingPlan
    {
        // Instance variables
        private double initialDeposit;
        private double monthlyDeposit;
        private double period;
        private double growthRate;
        private double fees;

     
        // Default constructor
        public SavingPlan()
        {
            initialDeposit = 0; 
            monthlyDeposit = 0;
            period = 0;
            growthRate = 0;
            fees = 0;
        }

        // Method to calculate the total amount paid over the saving period
        public double CalculateAmountPaid()
        {
            double balance = initialDeposit; // Initial deposit
            int months = (int)(period * 12); // Total number of months

            balance += monthlyDeposit * months; // Add the total monthly deposits to the balance

            return balance;
        }

        // Method to calculate the total earnings (interest earned) over the saving period
        public double CalculateAmountEarned()
        {
            double totalInterest = 0;
            double balance = initialDeposit;
            double monthlyInterest = growthRate / 100.0 / 12.0; // Monthly interest rate
            double monthlyFees = fees / 100.0 / 12.0; // Monthly fees
            int months = (int)(period * 12); // Total number of months

            for (int month = 1; month <= months; month++) // Loop through each month
            {
                double interest = balance * monthlyInterest; // Calculate the interest
                double monthlyFee = balance * monthlyFees; // Calculate the fees
                balance += interest - monthlyFee + monthlyDeposit; // Update the balance
                totalInterest += interest;  // Add the interest to the total interest
            }

            return totalInterest;
        }


        // Method to calculate the total fees paid over the saving period
        public double CalculateTotalFees()
        {
            double totalFees = 0;
            double balance = initialDeposit; // Initial deposit
            double monthlyFees = fees / 100.0 / 12.0; // Monthly fees
            int months = (int)(period * 12); // Total number of months

            for (int month = 1; month <= months; month++) // Loop through each month
            {
                double monthlyFee = balance * monthlyFees; // Calculate the fees
                balance += monthlyDeposit - monthlyFee; // Update the balance
                totalFees += monthlyFee; // Add the fees to the total fees
            }

            return totalFees;

        }

        // Method to calculate the final balance at the end of the saving period
        public double CalculateFinalBalance()
        {
            double balance = initialDeposit; // Initial deposit
            double monthlyInterest = growthRate / 100.0 / 12.0; // Monthly interest rate
            double monthlyFees = fees / 100.0 / 12.0; // Monthly fees
            int months = (int)(period * 12); // Total number of months

            for (int month = 1; month <= months; month++) // Loop through each month to add the interest and  remove the fees
            {
                double interest = balance * monthlyInterest; // Calculate the interest
                double monthlyFee = balance * monthlyFees;  // Calculate the fees
                balance += interest - monthlyFee + monthlyDeposit; // Update the balance
            }

            return balance;
        }

       

        #region setters and getters
        /// <summary>
        /// Getter method for the instance variables of the class
        /// </summary>
        /// <returns> The value stored in the fields for getters or sets it for setters.</returns>
        
        public double GetInitialDeposit()
        {
            return initialDeposit;
        }

        public void SetInitialDeposit(double initialDeposit)
        {
            if (initialDeposit >= 0)
                this.initialDeposit = initialDeposit;
        }

        public double GetMonthlyDeposit()
        {
            return monthlyDeposit;
        }

        public void SetMonthlyDeposit(double monthlyDeposit)
        {
            if (monthlyDeposit >= 0)
                this.monthlyDeposit = monthlyDeposit;
        }

        public double GetPeriod()
        {
            return period;
        }

        public void SetPeriod(double period)
        {
            if (period >= 0)
                this.period = period;
        }

        public double GetGrowthRate()
        {
            return growthRate;
        }

        public void SetGrowthRate(double growthRate)
        {
            if (growthRate >= 0)
                this.growthRate = growthRate;
        }

        public double GetFees()
        {
            return fees;
        }

        public void SetFees(double fees)
        {
            if (fees >= 0)
                this.fees = fees;
        }

        #endregion
    }
}


