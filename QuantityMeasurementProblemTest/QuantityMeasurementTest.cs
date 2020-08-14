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
    }
}