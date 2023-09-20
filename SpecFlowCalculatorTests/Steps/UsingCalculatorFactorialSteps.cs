using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.Features;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorFactorialSteps
{
    private Calculator _calculator;
    private double _result;

    public UsingCalculatorFactorialSteps(Calculator calc)
    {
        this._calculator = calc;
    }

    // [Given(@"I have a calculator")]
    // public void GivenIHaveACalculator()
    // {
    //     _calculator = new Calculator();
    // }

    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorial(double p0)
    {
        // Act
        this._result = _calculator.Factorial(p0);
    }

    [Then(@"the factorial result should be (.*)")]
    public void ThenTheFactorialResultShouldBe(string p0)
    {
        // Assert
        if (p0 == "positive_infinity")
        {
            Assert.That(this._result, Is.EqualTo(Double.PositiveInfinity));
        }
        else
        {
            Assert.That(this._result, Is.EqualTo(Double.Parse(p0)));
        }
    }
}