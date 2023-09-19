using ICT3101_Calculator;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        // Lab Example
        // [Test]
        // public void Add_EmptyString_ReturnsZero()
        // {
        //     // Arrange
        //     var stringCalculator = new StringCalculator();
        //
        //     // Act
        //     var actual = stringCalculator.add("");
        //
        //     // Assert
        //     Assert.Equals(0, actual);
        // }

         // Task 13a.
         [Test]
         public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
         {
             // Act
             double result = _calculator.Add(10, 20);
        
             // Assert
             Assert.That(result, Is.EqualTo(30));
         }

         [Test]
         public void Add_WhenCalledWithNegativeInteger_ReturnsSum()
         {
             // Act
             double result = _calculator.Add(-3, -4);
        
             // Assert
             Assert.That(result, Is.EqualTo(-7));
         }

        [Test]
        public void Subtract_WhenSubtractingLargerFromSmaller_ReturnsNegative()
        {
            // Act
            double result = _calculator.Subtract(5, 10);

            // Assert
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Multiply_WhenOneArgumentIsZero_ReturnsZero()
        {
            double result = _calculator.Multiply(0, 5);
            Assert.That(result, Is.EqualTo(0));
        }


        // Task 14
        // Ensure that an ArgumentException is thrown
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            // Assert
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        // Task 15
        [Test]
        [TestCase(-1)]

        public void Factorial_WhenCalledWithNegativeNumber_ThrowsArgumentException(double a) {
            // Assert
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(180)]

        public void Factorial_WhenCalledWithLargeNumber_ThrowsArgumentException(double a)
        {
            // Assert
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);

        }


        // 16a.
        [Test]
        [TestCase(1,5)]
        // Normal
        public void AreaTriangle_WhenGivenLengthAndHeight_ReturnsArea(double l, double h)
        {
            // Act
            var area = 0.5 * l * h;

            // Assert
            Assert.That(_calculator.AreaTriangle(l, h), Is.EqualTo(area));
        }


        [Test]
        [TestCase(1,0)]
        [TestCase(0,1)]
        // zeroes
        public void AreaTriangle_WhenCalledWithZero_ThrowsArgumentException(double l, double h)
        {
            // Assert
            Assert.That(()=>_calculator.AreaTriangle(l, h), Throws.ArgumentException);
        }

        [Test]
        [TestCase(1, -3)]
        [TestCase(-5,2 )]
        // negative cases
        public void AreaTriangle_WhenCalledWithNegativeArgument_ThrowsArgumentException(double l, double h)
        {
            // Assert
            Assert.That(()=>_calculator.AreaTriangle(l, h), Throws.ArgumentException);
        }

        // 16b.
        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(3.14)]
        // Normal
        public void AreaCircle_WhenGivenRadius_ReturnsArea(double r)
        {
            // Act
            var area = Math.PI * Math.Pow(r, 2);

            // Assert
            Assert.That(_calculator.AreaCircle(r), Is.EqualTo(area).Within(0.0001));
        }

        [Test]
        [TestCase(0)]
        // zero
        public void AreaCircle_WhenRadiusIsZero_ReturnsZero(double r)
        {
            // Act & Assert
            Assert.That(_calculator.AreaCircle(r), Is.EqualTo(0));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        // Negative Cases
        public void AreaCircle_WhenCalledWithNegativeRadius_ThrowsArgumentException(double r)
        {
            // Assert
            Assert.That(() => _calculator.AreaCircle(r), Throws.ArgumentException);
        }


        // 17a.
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }


        // 17b.
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}