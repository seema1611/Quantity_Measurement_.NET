// <copyright file="UnitType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Provides units and its values.
    /// </summary>
    public class UnitType
    {
        /// <summary>
        /// Enum that is set with value.
        /// </summary>
        public enum Units
        {
            FEET,
            INCH,
        }

        /// <summary>
        /// Method to perform conversion.
        /// </summary>
        /// <param name="unitsType">unitsType is converted units .</param>
        /// <returns>double value.</returns>
        public double GetconvertedUnit(Units unitsType)
        {
            if (unitsType == Units.FEET)
            {
                return 12.0;
            }

            if (unitsType == Units.INCH)
            {
                return 1.0;
            }

            return 0.0;
        }
    }
}