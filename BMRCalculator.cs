using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_calculator
{
    /// <summary>
    /// Enums to represent gender and activity level
    /// </summary>
    public enum Gender
    {
        Male,
        Female
    }

    public enum ActivityLevel
    {
        Sedentary,
        LightlyActive,
        ModeratelyActive,
        VeryActive,
        ExtraActive
    }

    /// <summary>
    /// Class to calculate the Basal Metabolic Rate (BMR) of a person
    /// </summary>
    class BMRCalculator
    {
        // Instance variables
        private double weight;
        private double height;
        private int age;
        private Gender gender;
        private ActivityLevel activityLevel;


        // constructor with default values
        public BMRCalculator()
        {
            weight = 0;
            height = 0;
            age = 0;
            gender = Gender.Male;
            activityLevel = ActivityLevel.Sedentary;
        }

        private double[] activityLevelFactors = { 1.2, 1.375, 1.55, 1.725, 1.9 };

        //BMR calculation method
        public double CalculateBMR()
        {
            double bmr = (10 * weight) + (6.25 * height) - (5 * age); // BMR calculation

            double bmrFemale = bmr - 161; // BMR calculation for females 
            double bmrMale = bmr + 5; // BMR calculation for males
            if (gender == Gender.Male)
            {
                bmr = bmrMale; 
            }
            else
            {
                bmr = bmrFemale;
        }
            return bmr;
        }

        // Method to calculate BMRs to keep current weight
        public double CalculateBMRToKeepWeight()
        {
            double bmr = CalculateBMR();
            double bmrToKeepWeight = bmr * activityLevelFactors[(int)activityLevel]; // BMR to keep current weight
            return bmrToKeepWeight;
        }

        // Method to calculate BMRs to lose weight or gain weight
        public double CalculateBMRToLoseOrGainWeight(double calories)
        {
            double stableBMR = CalculateBMRToKeepWeight();
            double bmrToLoseOrGainWeight = stableBMR + (calories * 1000 / 7); // BMR to lose or gain weight
            return bmrToLoseOrGainWeight;
        }

        #region getters and setters
        public double GetWeight()
        {
            return weight;
        }
        public double GetHeight()
        {
               return height;
        }
        public int GetAge()
        {
            return age;
        }
        public Gender GetGender()
        {
            return gender;
        }
        public ActivityLevel GetActivityLevel()
        {
            return activityLevel;
        }

        public void SetWeight(double weight)
        {
            if (weight > 0)
                this.weight = weight;
        }

        public void SetHeight(double height)
        {
            if (height > 0)
                this.height = height;
        }

        public void SetAge(int age)
        {
            if (age > 0)
                this.age = age;
        }

        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }

        public void SetActivityLevel(ActivityLevel activityLevel)
        {
            this.activityLevel = activityLevel;
        }

        #endregion


    }
}
