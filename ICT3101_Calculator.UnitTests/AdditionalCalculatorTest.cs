using ICT3101_Calculator;
using Moq;

namespace ICT3101_Caculator.UnitTests;

public class AdditionalCalculatorTest
{
    private Calculator _calculator;
    private Mock<IFileReader> _mockFileReader;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
        _mockFileReader = new Mock<IFileReader>();

        string testDirectory = TestContext.CurrentContext.TestDirectory;

        var workingDirectory = Environment.CurrentDirectory;
        var projectDirectory = Directory.GetParent(workingDirectory)?.Parent?.Parent?.FullName;
        var filePath = projectDirectory + "\\MagicNumbers.txt";

        _mockFileReader.Setup(fr => fr.Read(filePath)).Returns(new string[8]
            { "1", "-2", "4", "-6", "7", "23", "-3", "6" });
    }

    // Lab 4 4.
    [Test]
    public void GenMagicNum_ValidInputPositiveMagicNum_ReturnsDouble()
    {
        // Act
        double result = _calculator.GenMagicNum(0, _mockFileReader.Object); // Should read 2.0 from the file

        // Assert
        Assert.That(result, Is.EqualTo(2)); // 2 * 1.0
    }

    [Test]
    public void GenMagicNum_ValidInputNegativeMagicNum_ReturnsNegativeDouble()
    {
        // Act
        double result = _calculator.GenMagicNum(2, _mockFileReader.Object); // Should read 8.0 from the file

        // Assert
        Assert.That(result, Is.EqualTo(8.0)); // -2 * -4.0
    }

    [Test]
    public void GenMagicNum_InvalidIndex_ReturnsZero()
    {
        // Act
        double result = _calculator.GenMagicNum(100, _mockFileReader.Object); // An index that doesn't exist

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void GenMagicNum_ZeroIndexValidMagicNum_ReturnsDouble()
    {
        // Act
        double result = _calculator.GenMagicNum(0, _mockFileReader.Object); // Should read 2.0 from the file

        // Assert
        Assert.That(result, Is.EqualTo(2)); // 2 * 1.0
    }
}