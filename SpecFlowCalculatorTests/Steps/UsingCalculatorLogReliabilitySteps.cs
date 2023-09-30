using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.Features;
using System; // Add this line for ArgumentException

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorLogReliabilitySteps
{
    private Calculator _calculator;
    private double _result;

    public UsingCalculatorLogReliabilitySteps(Calculator calc)
    {
        this._calculator = calc;
    }

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        _calculator = new Calculator();
    }


    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press LogCurrentFailure")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogCurrentFailure(double p0, double p1, double p2)
    {
        // Act
        this._result = _calculator.LogCurrentFailure(p0, p1, p2);
    }

    [Then(@"the current log failure intensity result should be (.*)")]
    public void ThenTheCurrentLogFailureIntensityResultShouldBe(double p0)
    {
        // Assert
        Assert.That(this._result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press LogAverageFailure")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogAverageFailure(double p0, double p1, double p2)
    {
        // Act
        this._result = _calculator.LogAvgExpectedFailure(p0, p1, p2);
    }

    [Then(@"the average log expected failure result should be (.*)")]
    public void ThenTheAverageLogExpectedResultShouldBe(double p0)
    {
        // Assert
        Assert.That(this._result, Is.EqualTo(p0));
    }
}