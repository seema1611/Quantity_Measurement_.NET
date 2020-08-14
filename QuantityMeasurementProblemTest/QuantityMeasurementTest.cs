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
    }
}