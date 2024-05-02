
using CalculatorEngine;

namespace CalculatorTestProject1;
// Unit Tests For Root Function
public class RootUnitTest
{
     [Test]
        public void RootOfTwoDoubles_PositiveNumber_ReturnsCubeRoot()
        {
            //Arrange
            double baseValue = 8;
            double root = 3; //The inverse of exponent is being passed through Calculator logic. Raising 9 to the power of 1/2 is the same thing as taking the sqaure root of 9. 

            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(baseValue, root);
            
            //Assert
            Assert.That(result, Is.EqualTo(2), "Cube root of 8 should be 2.");
        }

        [Test]
        public void RootOfTwoDoubles_TwoPositiveNumber_ReturnsSquareRoot()
        {
           //Arrange 
            double baseValue = 25;
            double root = 2;
           
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(baseValue, root);
            //Assert
            Assert.That(result, Is.EqualTo(5).Within(0.0001), "Square root of 25 should be 5.");
        }
        
        [Test]
        public void RootOfTwoDoubles_NegativeSquareRootOfNumber_ThrowsExceptionOrReturnsNaN()
        {
            //Arrange
            double baseValue = 8;
            double root = 0;
            
            //Act
            var result = CalculatorLogic.RootOfTwoDoubles(baseValue, root);
            //Assert
            Assert.That(result,Is.NaN, "Negative Square root of a positive number should be NaN.");
        }
        
} 