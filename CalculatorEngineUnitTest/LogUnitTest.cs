
using System.Runtime.CompilerServices;
using CalculatorEngine;

namespace CalculatorTestProject1;
//Unit Tests For Log Functions
public class LogUnitTest
{
    //preq-ENGINE-9
        [Test]
        public void LogOfTwoDoubles_Base2_ReturnsCorrectLog()
        {
           //Arrange
            double value = 8; 
            double baseValue = 2;
            double expected = 3;
            //Act
            var result = CalculatorLogic.LogOfTwoDoubles(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Log base 2 of 8 should be 3.");
        }

        [Test]
        public void LogOfTwoDoubles_Base5_ReturnsCorrectLog()
        {   
            //Arrange
            double value = 25;
            double baseValue = 5;
            double expected = 2;
            //Act
            var result = CalculatorLogic.LogOfTwoDoubles(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Log base 5 of 25 should be 2.");
        }
        [Test]
        //preq-UNIT-TEST-10
        public void LogOfTwoDoubles_NegativeBase_ReturnsNaN()
        {
            //Arrange 
            double value = -2;
            double baseValue = 2;
            //Act
            var result = CalculatorLogic.LogOfTwoDoubles(value, baseValue);
            //Assert 
            Assert.That(result,Is.NaN, "Logarithm with a negative value should return NaN.");
        }
        [Test]
        //preq-UNIT-TEST-11
        public void LogOfTwoDoubles_Base0_ReturnsNaN()
        {
            //Arrange 
            double value = 8;
            double baseValue = 0;
            //Act
            var result = CalculatorLogic.LogOfTwoDoubles(value, baseValue);
            //Assert 
            Assert.That(result,Is.NaN, "Logarithm with a Zero base should return NaN.");
        }

        [Test]
        public void LogOfTwoDoubles_ValueOne_ReturnsZero()
        {
            //Arrange 
            double value = 1;
            double baseValue = 10;
            double expected = 0;
            //Act
            var result = CalculatorLogic.LogOfTwoDoubles(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Log of 1 should be 0 regardless of the base.");
        }
        
}