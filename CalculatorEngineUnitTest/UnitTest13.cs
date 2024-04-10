/*using Calculator_App;
namespace CalculatorTestProject1;

public class UnitTest13
{
     [Test]
        public void RootOfTwoFloats_PositiveNumber_ReturnsSquareRoot()
        {
            //Arrange
            var calculator = new CalculatorEngine();
            float testValue = 9f; 
            //Act
            var result = calculator.RootOfTwoFloats(testValue, 0); 
            //Assert
            Assert.That(result, Is.EqualTo(3).Within(0.0001), "Square root of 9 should be 3.");
        }

        [Test]
        public void RootOfTwoFloats_Zero_ReturnsZero()
        {
           //Arrange 
           var calculator = new CalculatorEngine();
            float testValue = 0f; // Sqrt(0) = 0
            //Act
            var result = calculator.RootOfTwoFloats(testValue, 0); // Second parameter is ignored
            //Assert
            Assert.That(result, Is.EqualTo(0).Within(0.0001), "Square root of 0 should be 0.");
        }

        [Test]
        public void RootOfTwoFloats_NegativeNumber_ThrowsExceptionOrReturnsNaN()
        {
            //Arrange
            var calculator = new CalculatorEngine();
            float testValue = -1f;
            
            //Act
            var result = calculator.RootOfTwoFloats(testValue, 0);
            //Assert
            Assert.That(double.IsNaN(result),Is.EqualTo(true), "Square root of a negative number should be NaN.");
        }

        
        [Test]
        public void RootOfTwoFloats_VerySmallPositiveNumber_ReturnsCorrectSquareRoot()
        {
            //Arrange
            var calculator = new CalculatorEngine();
            float testValue = 0.0001f; 
            //Act
            var result = calculator.RootOfTwoFloats(testValue, 0);
            //Assert
            Assert.That(result, Is.EqualTo(0.01).Within(0.0001), "Square root of 0.0001 should be 0.01.");
        }

       
        [Test]
        public void RootOfTwoFloats_VeryLargePositiveNumber_ReturnsCorrectSquareRoot()
        {
            //Arrange
            var calculator = new CalculatorEngine();
            float testValue = 1000000f; 
            //Act
            var result = calculator.RootOfTwoFloats(testValue, 0);
            //Assert
            Assert.That(result, Is.EqualTo(1000).Within(0.1), "Square root of 1000000 should be 1000.");
        }
    
}*/