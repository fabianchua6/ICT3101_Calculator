using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.Features;
using System; // Add this line for ArgumentException

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorBasicReliabilitySteps
{
    private Calculator _calculator;
    private double _result;

    public UsingCalculatorBasicReliabilitySteps(Calculator calc)
    {
        this._calculator = calc;
    }

    // [Given(@"I have a calculator")]
    // public void GivenIHaveACalculator()
    // {
    //     _calculator = new Calculator();
    // }


    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press CurrentFailure")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCurrentFailure(double p0, double p1, double p2)
    {
        // Act
        this._result = _calculator.CurrentFailure(p0, p1, p2);
    }

    [Then(@"the current failure intensity result should be (.*)")]
    public void ThenTheCurrentFailureIntensityResultShouldBe(double p0)
    {
        // Assert
        Assert.That(this._result, Is.EqualTo(p0));
    }

    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press AverageFailure")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAverageFailure(double p0, double p1, double p2)
    {
        // Act
        this._result = _calculator.AvgExpectedFailure(p0, p1, p2);
    }

    [Then(@"the average expected failure result should be (.*)")]
    public void ThenTheAverageExpectedResultShouldBe(double p0)
    {
        // Assert
        Assert.That(this._result, Is.EqualTo(p0));
    }
}