using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.Features;

namespace SpecFlowCalculatorTests.Steps;

public class CalculatorContext
{
    public Calculator Calculator { get; set; }
    public ArgumentException ErrorMessage { get; set; }
    public double Result { get; set; }
}

[Binding]
public sealed class UsingCalculatorStepDefinitions
{
    private readonly CalculatorContext _calculatorContext;
    
    public UsingCalculatorStepDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }

    // private Calculator _calculator;
    //
    // public void UsingCalculatorDivisionSteps(Calculator calc)
    // {
    //     this._calculator = calc;
    // }

    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
         _calculatorContext.Calculator = new Calculator();
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press add")]
    public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
    {
        _calculatorContext.Result = _calculatorContext.Calculator.Add(p0, p1);
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBeOnTheScreen(int p0)
    {
        Assert.That(_calculatorContext.Result, Is.EqualTo(p0));
    }


    
    [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
    {
        // Act
        _calculatorContext.Result = _calculatorContext.Calculator.Divide(p0, p1);
    }

    [Then(@"the division result should be (.*)")]
    public void ThenTheDivisionResultShouldBe(string p0)
    {
        // Assert
        if (p0 == "positive_infinity")
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(Double.PositiveInfinity));
        }
        else
        {
            Assert.That(_calculatorContext.Result, Is.EqualTo(Double.Parse(p0)));
        }
    }
}