// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    using System;
    using static QuantityMeasurementProblem.UnitType;

    /// <summary>
    /// Class To Perform Quantity Measurement.
    /// </summary>
    public class QuantityMeasurement
    {
        private UnitType unitsType = new UnitType();

        /// <summary>
        /// This method use for tempreture conversion.
        /// </summary>
        /// <param name="unit">Unit type.</param>
        /// <param name="temperature">Temperature quantity.</param>
        /// <returns>Temperature value.</returns>
        public double TemperatureConversion(double temperature, Units unit)
        {
            if (unit == Units.FAHRENHEIT)
                return (temperature - 32) * 5/9;
            return (temperature * 9/5) +32;
        }

        /// <summary>
        /// Method to get double values.
        /// </summary>
        /// <param name="value">Perform operation.</param>
        /// <param name="unitsType">taking unit.</param>
        /// <returns>value converted.</returns>
        /// 
        public double GetValueAndUnit(double value, Units unitsType)
        {
            return value * this.unitsType.GetconvertedUnit(unitsType);
        }

        /// <summary>
        /// Overrriding Equals Method.
        /// </summary>
        /// <param name="obj">Check object.</param>
        /// <returns>boolean value.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (obj is QuantityMeasurement)
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns>hascode.</returns>
        public override int GetHashCode()
        {
            return -1136221603 +  base.GetHashCode();
        }
    }
}