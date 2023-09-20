using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.Features;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorDivisionSteps
{
    private Calculator _calculator;
    private double _result;

    public UsingCalculatorDivisionSteps(Calculator calc)
    {
        this._calculator = calc;
    }

    // [Given(@"I have a calculator")]
    // public void GivenIHaveACalculator()
    // {
    //     _calculator = new Calculator();
    // }

    [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
    {
        // Act
        this._result = _calculator.Divide(p0, p1);
    }

    [Then(@"the division result should be (.*)")]
    public void ThenTheDivisionResultShouldBe(string p0)
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