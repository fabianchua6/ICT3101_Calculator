using System.Runtime.CompilerServices;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;


[Binding]
public sealed class UsingCalculatorSteps
{
    private Calculator _calculator;
    private double _result;

    public UsingCalculatorSteps(Calculator calc)
    {
        this._calculator = calc;
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press add")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
    {
        // Act
        _result = _calculator.Add(p0, p1);
    }


    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(int p0)
    {
        // Assert
        Assert.That(this._result, Is.EqualTo(p0));
    }
}




    
