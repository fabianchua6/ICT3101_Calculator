using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.Features;
using System; // Add this line for ArgumentException

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class UsingCalculatorAvailabilitySteps
{
    private Calculator _calculator;
    private double _result;
    private double _mttf;
    private double _mttr;

    public UsingCalculatorAvailabilitySteps(Calculator calc)
    {
        this._calculator = calc;
    }

    // [Given(@"I have a calculator")]
    // public void GivenIHaveACalculator()
    // {
    //     _calculator = new Calculator();
    // }


    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
    {
        _mttf = p0;
        _mttr = p1;
        // Act
        try
        {
            _result = _calculator.MTBF(p0, p1);
        }
        catch (ArgumentException)
        {
            // Catch the exception to allow the test to continue to the Then step
        }
    }

    [Then(@"the MBTF result should be (.*)")]
    public void ThenTheMBTFResultShouldBe(double p0)
    {
        // Assert
        Assert.That(this._result, Is.EqualTo(p0));
    }

    [Then(@"the calculator should throw an ArgumentException with message (.*)")]
    public void ThenTheCalculatorShouldThrowAnArgumentExceptionWithMessage(string errorMessage)
    {
        // Assert
        Assert.That(() => _calculator.MTBF(_mttf, _mttr), Throws.ArgumentException.With.Message.EqualTo(errorMessage));
    }


    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
    {
        // Act
        this._result = _calculator.Availability(p0, p1);
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheAvailabilityResultShouldBe(double p0)
    {
        // Assert
        Assert.That(this._result, Is.EqualTo(p0));
    }
}