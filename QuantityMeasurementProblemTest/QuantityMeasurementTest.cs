// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblemTest
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// Class to Test Quantity Measurement Problem.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// Object created.
        /// </summary>
        private QuantityMeasurement quantityMeasurement;
        private QuantityMeasurement quantityMeasurement2;

        /// <summary>
        /// Setup Method for calling object.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
            this.quantityMeasurement2 = new QuantityMeasurement();
        }

        /// <summary>
        /// Test 1.1: check two feet 0 values.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.FEET);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.2: check equality for null values.
        /// </summary>
        [Test]
        public void GivenTwoNullFeetValue_WhenNotProper_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test 1.3: check equality for reference.
        /// </summary>
        [Test]
        public void GivenTwoReferenceObject_WhenEqual_ShouldReturnTrue()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValueAndUnit(0.0, UnitType.Units.FEET);
            bool data = value1.Equals(value2);
            Assert.IsTrue(data);
        }

        /// <summary>
        /// Test 1.4: check equality for type.
        /// </summary>
        [Test]
        public void GivenTwoTypeObject_WhenEqual_ShouldReturnEqual()
        {
            Assert.AreEqual(this.quantityMeasurement, this.quantityMeasurement2);
        }

        /// <summary>
        /// Test 1.5: check equality for Feet value check.
        /// </summary>
        [Test]
        public void GivenTwoSameFeetValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(5.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement.GetValueAndUnit(5.0, UnitType.Units.FEET);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.6: check two 0 inch values.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroInch_WhenSame_ShouldReturnEqual()
        {
            double inchValue1 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.INCH);
            double inchValue2 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.INCH);
            Assert.AreEqual(inchValue1, inchValue2);
        }

        /// <summary>
        /// Test 1.7: check equality for null.
        /// </summary>
        [Test]
        public void GivenNullInchValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test 1.8: check equality for reference in Inch.
        /// </summary>
        [Test]
        public void GivenReferenceObjectForInch_WhenEqual_ShouldReturnTrue()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.INCH);
            double value2 = this.quantityMeasurement2.GetValueAndUnit(0.0, UnitType.Units.INCH);
            bool data = value1.Equals(value2);
            Assert.IsTrue(data);
        }

        /// <summary>
        /// Test 1.9: check equality for type in inch.
        /// </summary>
        [Test]
        public void GivenTwoTypeObjectInInch_WhenEqual_ShouldReturnEqual()
        {
            Assert.AreEqual(this.quantityMeasurement, this.quantityMeasurement2);
        }

        /// <summary>
        /// Test 1.10: check equality for value check in Inch.
        /// </summary>
        [Test]
        public void GivenTwoSameInchValue_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(5.0, UnitType.Units.INCH);
            double value2 = this.quantityMeasurement.GetValueAndUnit(5.0, UnitType.Units.INCH);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.11: check equality for values of Feet & Inch.
        /// </summary>
        [Test]
        public void GivenFeetAndInchValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement.GetValueAndUnit(0.0, UnitType.Units.INCH);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.13: check equality for values of Feet & Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneInchValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.INCH);
            Assert.AreNotEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.14: check equality for values of 1 Inch & 1 Feet.
        /// </summary>
        [Test]
        public void GivenOneInchandOneFeetValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.INCH);
            double value2 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            Assert.AreNotEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.15: check equality for values of 1 Feet & 12 Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetandTwelveInchValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement.GetValueAndUnit(12.0, UnitType.Units.INCH);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 12 Inch & 1 Feet.
        /// </summary>
        [Test]
        public void GivenTwelveFeetandOneInchValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(12.0, UnitType.Units.INCH);
            double value2 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 3 Feet & 1 Yard.
        /// </summary>
        [Test]
        public void GivenThreeFeetandOneYardValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(3.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.YARD);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 1Feet & 1Yard.
        /// </summary>
        [Test]
        public void GivenOneFeetandOneYardValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            double value2 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.YARD);
            Assert.AreNotEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 1 Inch & 1Yard.
        /// </summary>
        [Test]
        public void GivenOneInchandOneYardValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.INCH);
            double value2 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.YARD);
            Assert.AreNotEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 1 Yard & 36 Inch.
        /// </summary>
        [Test]
        public void GivenOneYardAndThirtySixInchValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.YARD);
            double value2 = this.quantityMeasurement.GetValueAndUnit(36.0, UnitType.Units.INCH);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 36 Inch & 1 Yard.
        /// </summary>
        [Test]
        public void GivenThirtySixInchAndOneYardValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(36.0, UnitType.Units.INCH);
            double value2 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.YARD);
            Assert.AreEqual(value2, value1);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 1 Yard & 3 Feet.
        /// </summary>
        [Test]
        public void GivenOneYardAndThreeFeetValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.YARD);
            double value2 = this.quantityMeasurement.GetValueAndUnit(3.0, UnitType.Units.FEET);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 3.1: check equality for values of Two inch to five centimeter.
        /// </summary>
        [Test]
        public void GivenTwoInchAndFiveCMValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValueAndUnit(2.0, UnitType.Units.INCH);
            double value2 = this.quantityMeasurement.GetValueAndUnit(5.0, UnitType.Units.CM);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 4.1: Addition of 2 Inche & 2 Inch values.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoInch_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(2.0, UnitType.Units.INCH);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(2.0, UnitType.Units.INCH);
            Assert.AreEqual(valueOne + valueTwo, 4);
        }

        /// <summary>
        /// Test 4.2: Addtion of 1 feet & 2 Inches values.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInch_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(2.0, UnitType.Units.INCH);
            Assert.AreEqual(valueOne + valueTwo, 14);
        }

        /// <summary>
        /// Test 4.3: Addtion of 1 feet & 1 feet values.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.FEET);
            Assert.AreEqual(valueOne + valueTwo, 24);
        }

        /// <summary>
        /// Test 4.4: Addition of 2 Inch & 2.5 Cm values.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoptFiveCm_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(2.0, UnitType.Units.INCH);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(2.5, UnitType.Units.CM);
            Assert.AreEqual(valueOne + valueTwo, 3);
        }

        /// <summary>
        /// Test 5.1: Check 1 gallon & 3.78 litres equal.
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreeptSevenEightLiters_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.GALLON);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(3.78, UnitType.Units.LITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 5.2:  Check 1 litre & 1000 ml equal.
        /// </summary>
        [Test]
        public void GivenOneLitreAndThousandMiliLitre_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.LITRE);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(1000.0, UnitType.Units.ML);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 6.1: Addition of 1 gallon & 3.78 Litres values.
        /// </summary>
        [Test]
        public void GivenOneGallonAndLitre_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.GALLON);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(3.78, UnitType.Units.LITRE);
            Assert.AreEqual(valueOne + valueTwo, 7.5599999999999996);
        }

        /// <summary>
        /// Test 6.2: Addition of 1 litre & 1000 Ml values.
        /// </summary>
        [Test]
        public void GivenLitreAndML_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.LITRE);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(1000.0, UnitType.Units.ML);
            Assert.AreEqual(valueOne + valueTwo, 2);
        }

        /// <summary>
        /// Test 7.1: check equality for values of 1 Kg to 1000 grams.
        /// </summary>
        [Test]
        public void GivenOneKgAndThousandGrams_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValueAndUnit(1.0, UnitType.Units.KG);
            double valueTwo = this.quantityMeasurement.GetValueAndUnit(1000.0, UnitType.Units.GRAM);
            Assert.AreEqual(valueOne , valueTwo);
        }
    }
}