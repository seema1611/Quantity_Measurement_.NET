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
            YARD,
            CM,
            GALLON,
            LITRE,
            ML,
            KG,
            GRAM,
            TONNE,
        }

        /// <summary>
        /// Method to perform conversion.
        /// </summary>
        /// <param name="unitsType">unitsType is converted units .</param>
        /// <returns>double value.</returns>
        public double GetconvertedUnit(Units unitsType)
        {
            switch (unitsType)
            {
                case Units.FEET:
                    return 12.0;
                case Units.INCH:
                    return 1.0;
                case Units.YARD:
                    return 36.0;
                case Units.CM:
                    return 0.4;
                case Units.GALLON:
                    return 3.78;
                case Units.LITRE:
                    return 1;
                case Units.ML:
                    return 0.001;
                case Units.KG:
                    return 1;
                case Units.GRAM:
                    return 0.001;
                case Units.TONNE:
                    return 1000;
            }
            return 0.0;
        }
    }
}