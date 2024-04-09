using Calculator_App;
namespace CalculatorTestProject1;

public class UnitTest12
{
    
        [Test]
        public void LogOfTwoFloats_Base10_ReturnsCorrectLog()
        {
           //Arrange
           var caculator = new CalculatorEngine();
            float value = 100f; 
            float baseValue = 10f;
            //Act
            var result = caculator.LogOfTwoFloats(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(2).Within(0.0001), "Log base 10 of 100 should be 2.");
        }

        [Test]
        public void LogOfTwoFloats_BaseE_ReturnsCorrectLog()
        {   
            //Arrange
            var calculator = new CalculatorEngine();
            float value = (float)Math.E;
            float baseValue = (float)Math.E;
            //Act
            var result = calculator.LogOfTwoFloats(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(1).Within(0.0001), "Log base e of e should be 1.");
        }

        [Test]
        public void LogOfTwoFloats_BaseGreaterThanOne_ReturnsCorrectLog()
        {   
            //Arrange
            var calculator = new CalculatorEngine();
            float value = 8f;
            float baseValue = 2f;
            //Act
            var result = calculator.LogOfTwoFloats(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(3).Within(0.0001), "Log base 2 of 8 should be 3.");
        }

        [Test]
        public void LogOfTwoFloats_ValueOne_ReturnsZero()
        {
            //Arrange 
            var calculator = new CalculatorEngine();
            float value = 1f;
            float baseValue = 10f; 
            //Act
            var result = calculator.LogOfTwoFloats(value, baseValue);
            //Assert
            Assert.That(result, Is.EqualTo(0).Within(0.0001), "Log of 1 should be 0 regardless of the base.");
        }
        
}