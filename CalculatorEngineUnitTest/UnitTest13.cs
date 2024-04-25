
using CalculatorEngine;

namespace CalculatorTestProject1;
// Unit Tests For Root Function
public class UnitTest13
{
    //preq-ENGINE-11
     [Test]
        public void RootOfTwoDoubles_PositiveNumber_ReturnsSquareRoot()
        {
            //Arrange
            double squareRootOf = 9;
            double exponent = 2; //The inverse of exponent is being passed through Calculator logic. Raising 9 to the power of 1/2 is the same thing as taking the sqaure root of 9. 

            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(squareRootOf, exponent);
            
            //Assert
            Assert.That(result, Is.EqualTo(3), "Square root of 9 should be 3.");
        }

        [Test]
        public void RootOfTwoDoubles_Zero_ReturnsZero()
        {
           //Arrange 
            double squareRootOf = 0;
            double exponent = 2;
            double expected = 0;
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(squareRootOf, exponent);
            //Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001), "Square root of 0 should be 0.");
        }
        
        [Test]
        public void RootOfTwoDoubles_SquareRootOfNegativeNumber_ThrowsExceptionOrReturnsNaN()
        {
            //Arrange
            double squareRootOf = -1;
            double exponent = 2;
            
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(squareRootOf, exponent);
            //Assert
            Assert.That(double.IsNaN(result),Is.EqualTo(true), "Square root of a negative number should be NaN.");
        }
      
        
        [Test]
        public void RootOfTwoDoubles_VerySmallPositiveNumber_ReturnsCorrectSquareRoot()
        {
            //Arrange
            double squareRootOf = 0.0001;
            double exponent = 2;
            
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(squareRootOf, exponent);
            //Assert
            Assert.That(result, Is.EqualTo(0.01).Within(0.0001), "Square root of 0.0001 should be 0.01.");
        }
  
       
        [Test]
        public void RootOfTwoDoubles_VeryLargePositiveNumber_ReturnsCorrectSquareRoot()
        {
            //Arrange
            double squareRootOf = 1000000;
            double exponent = 2;
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(squareRootOf, exponent);
            //Assert
            Assert.That(result, Is.EqualTo(1000).Within(0.1), "Square root of 1000000 should be 1000.");
        }
} 