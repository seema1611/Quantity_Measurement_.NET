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
            FEET,INCH,YARD,CM, GALLON,LITRE,ML,
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

            if (unitsType == Units.YARD)
            {
                return 36.0;
            }

            if (unitsType == Units.CM)
            {
                return 1 / 2.5;
            }

            if (unitsType == Units.LITRE)
            {
                return 1 * 1000.0;
            }

            if (unitsType == Units.GALLON)
            {
                return 1 * 3780.0;
            }

            if (unitsType == Units.ML)
            {
                return 1.0;
            }

            return 0.0;
        }
    }
}