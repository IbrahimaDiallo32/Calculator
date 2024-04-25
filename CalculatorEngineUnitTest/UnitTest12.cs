
using CalculatorEngine;

namespace CalculatorTestProject1;
//Unit Tests For Log Functions
public class UnitTest12
{
    //preq-ENGINE-9
        [Test]
        public void LogOfTwoDoubles_Base10_ReturnsCorrectLog()
        {
           //Arrange
            double value = 100; 
            double baseValue = 10;
            double expected = 2;
            //Act
            var result = CalculatorLogic.LogOfTwoDoubles(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Log base 10 of 100 should be 2.");
        }

        [Test]
        public void LogOfTwoDoubles_BaseE_ReturnsCorrectLog()
        {   
            //Arrange
            double value = Math.E;
            double baseValue = Math.E;
            double expected = 1;
            //Act
            var result = CalculatorLogic.LogOfTwoDoubles(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Log base e of e should be 1.");
        }

        [Test]
        public void LogOfTwoDoubles_BaseGreaterThanOne_ReturnsCorrectLog()
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