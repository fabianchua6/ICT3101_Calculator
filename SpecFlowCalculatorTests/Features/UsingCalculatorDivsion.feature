Feature: UsingCalculatorDivision
In order to conquer divisions
As a division enthusiast
I want to understand a variety of division operations

    @Divisions
    Scenario Outline: Dividing numbers in various scenarios
        Given I have a calculator
        When I have entered <value1> and <value2> into the calculator and press divide
        Then the division result should be <result>

        Examples:
          | value1 | value2 | result |
          | 1      | 2      | 0.5    |
          | 0      | 15     | 0      |

    @Divisions
    Scenario: Dividing zero by a number
        Given I have a calculator
        When I have entered 0 and <value1> into the calculator and press divide
        Then the division result should be 0

    Examples:
      | value1 |
      | 2      |
      | 15     |

    @Divisions
    Scenario: Dividing by zeros
        Given I have a calculator
        When I have entered <value1> and 0 into the calculator and press divide
        Then the division result should be positive_infinity

    Examples:
      | value1 |
      | 22     |
      | 1      |

    @Divisions
    Scenario: Dividing by zero by zero
        Given I have a calculator
        When I have entered 0 and 0 into the calculator and press divide
        Then the division result should be 1