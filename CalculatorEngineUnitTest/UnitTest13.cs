/*
using CalculatorEngine;

namespace CalculatorTestProject1;

public class UnitTest13
{
     [Test]
        public void RootOfTwoDoubles_PositiveNumber_ReturnsSquareRoot()
        {
            //Arrange
            double testValue1 = 9;

            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(testValue1, 0);
            //Assert
            Assert.That(result, Is.EqualTo(3).Within(0.0001), "Square root of 9 should be 3.");
        }

        [Test]
        public void RootOfTwoDoubles_Zero_ReturnsZero()
        {
           //Arrange 
            double testValue1 = 0;
            double expected = 0;
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(testValue1, 0); // Second parameter is ignored
            //Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Square root of 0 should be 0.");
        }

        [Test]
        public void RootOfTwoDoubles_NegativeNumber_ThrowsExceptionOrReturnsNaN()
        {
            //Arrange
            double testValue1 = -1;
            
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(testValue1, 0);
            //Assert
            Assert.That(double.IsNaN(result),Is.EqualTo(true), "Square root of a negative number should be NaN.");
        }

        
        [Test]
        public void RootOfTwoDoubles_VerySmallPositiveNumber_ReturnsCorrectSquareRoot()
        {
            //Arrange
            double testValue1 = 0.0001;
            
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(testValue1, 0);
            //Assert
            Assert.That(result, Is.EqualTo(0.01).Within(0.0001), "Square root of 0.0001 should be 0.01.");
        }

       
        [Test]
        public void RootOfTwoDoubles_VeryLargePositiveNumber_ReturnsCorrectSquareRoot()
        {
            //Arrange
            double testValue1 = 1000000;
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(testValue1, 0);
            //Assert
            Assert.That(result, Is.EqualTo(1000).Within(0.1), "Square root of 1000000 should be 1000.");
        }
    
} */