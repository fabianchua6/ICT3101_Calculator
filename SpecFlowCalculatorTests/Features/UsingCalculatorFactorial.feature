Feature: UsingCalculatorFactorial
In order to conquer factorial
As a factorial enthusiast
I want to understand a variety of factorial operations

    @Factorials
    Scenario Outline: Factorial of numbers in various scenarios
        #!TODO: what to deal with this?
        Given I have a calculator
        When I have entered <value1> into the calculator and press factorial
        Then the factorial result should be <result>

        Examples:
        | value1 | result |
        | 0      | 1      |
        | 1      | 1      |
        
#    @Factorials
#    Scenario: Dividing zero by a number
#        Given I have a calculator
#        When I have entered 0 and <value1> into the calculator and press divide
#        Then the division result should be 0
#
#    Examples:
#      | value1 |
#      | 2      |
#      | 15     |

#    @Divisions
#    Scenario: Dividing by zeros
#        Given I have a calculator
#        When I have entered <value1> and 0 into the calculator and press divide
#        Then the division result should be positive_infinity
#
#    Examples:
#      | value1 |
#      | 22     |
#      | 1      |
#
#    @Divisions
#    Scenario: Dividing by zero by zero
#        Given I have a calculator
#        When I have entered 0 and 0 into the calculator and press divide
#        Then the division result should be 1