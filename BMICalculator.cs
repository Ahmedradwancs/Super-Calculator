using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_calculator
{
    // No interaction with the user
    // No message boxes
    // Only calculations and instance variables
    class BMICalculator
    {

        private String name = "No Name";
        private double height; // m, feet
        private double weight; // kg, lb
        private UnitTypes unit;


        // Default constructor with default UnitTypes.Metric
        public BMICalculator()
        {
            unit = UnitTypes.Metric;
        }


        /// <summary>
        /// BMIWeightCategory method
        /// </summary>
        /// <return> The value of the BMI weight category.</return>
        public string BMIWeightCategory(double bmi)
        {
            string bmiCategory = "";


            if (bmi < 18.5)
                bmiCategory = "underweight";
            else if (bmi >= 18.5 && bmi < 25)
                bmiCategory = "Normal weight";
            else if (bmi >= 25 && bmi < 30)
                bmiCategory = "Overweight (Pre-obesity)";
            else if (bmi >= 30 && bmi < 35)
                bmiCategory = "Obese Class I";
            else if (bmi >= 35 && bmi < 40)
                bmiCategory = "Obese Class II";
            else if (bmi >= 40)
                bmiCategory = "Obese Class III";
            
            return bmiCategory;
        }

        /// <summary>
        /// CalculateBMI method
        /// </summary>
        /// <return> The value of the BMI.</return>
        public double CalculateBMI()
        {
            double bmi = 0;
            if (unit == UnitTypes.Metric)
            {
                height = height / 100;
                // BMI using metric units
                bmi = weight / (height * height);
                Console.WriteLine("ur bmi: " + bmi);
            }
            else
            {
                // BMI using imperial units
                bmi = (weight * 703) / (height * height);
                Console.WriteLine($"Weight (lbs): {weight}, Height (inches): {height}");

            }
            Console.WriteLine($"Calculated BMI: {bmi}");

            return bmi;
        }

        /// <summary>
        /// CalculateNormalWeightRange method
        /// </summary>
        /// <returns></returns>
        public string CalculateNormalWeightRange()
        {
            double lowWeight;
            double highWeight;
            string result = "";
            if (unit == UnitTypes.Metric)
            {

                lowWeight = height * height * 18.5;
                highWeight = height * height * 24.9;
                result = $"Normal weight range should be between {lowWeight:F2} and {highWeight:F2} kgs";

            }
            else
            {
                lowWeight = height * height * 703 * 18.5;
                highWeight = height * height * 703 * 24.9;
                result = $"Normal weight range should be between {lowWeight:F2} and {highWeight:F2} lbs";
            }

            return result;
        }

        #region setters and getters
        /// <summary>
        /// Getter method for name
        /// </summary>
        /// <returns> The value stored in the field name.</returns>
        public string GetName()
        {
            return name;
        }


        /// <summary>
        /// Setter method for name
        /// </summary>
        /// <param name="name"> Input: new name to be saved in name</param>
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
                this.name = name;
        }

        /// <summary>
        /// Getter method for height
        /// </summary>
        /// <return> The value stored in the field height.</return></return>
        public double GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Setter method for height
        /// </summary>
        /// <param name="height">Input: new value to be saved in height</param>
        public void SetHeight(double height)
        {
            if (height >= 0)
                this.height = height;
        }

        /// <summary>
        /// Getter method for weight
        /// </summary>
        /// <return> The value stored in the field weight.</return></return>
        public double GetWeight()
        {
            return weight;
        }

        /// <summary>
        /// Setter method for weight
        /// </summary>
        /// <param name="weight">Input: new value to be saved in weight</param>
        public void SetWeight(double weight)
        {
            if (weight >= 0)
                this.weight = weight;
        }

        /// <summary>
        /// Getter method for unit
        /// </summary>
        /// <return> The value stored in the field unit.</return></return>
        public UnitTypes GetUnit()
        {
            return unit;
        }

        /// <summary>
        /// Setter method for unit
        /// </summary>
        /// <param name="unit">Input: new value to be saved in unit</param>
        public void SetUnit(UnitTypes unit)
        {
            this.unit = unit;
        }
        #endregion


    }
}
