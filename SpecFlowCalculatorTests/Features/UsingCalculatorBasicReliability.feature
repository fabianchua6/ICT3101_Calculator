Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

    @BasicReliability
    Scenario: Calculating current failure intensity
        Given I have a calculator
        When I have entered <init_fail>, <avg_fail> and <total_fail> into the calculator and press CurrentFailure
        Then the current failure intensity result should be <curr_fail_result>

    Examples:
      | init_fail | avg_fail | total_fail | curr_fail_result |
      | 10        | 50       | 100        | 5                |
      | 0         | 50       | 100        | 0                |
      | 20        | 40       | 80         | 10                |

    @BasicReliability
    Scenario: Calculating average expected failure
        Given I have a calculator
        When I have entered <init_fail>, <total_fail> and <time> into the calculator and press AverageFailure
        Then the average expected failure result should be <avg_fail_result>

    Examples:
      | init_fail | total_fail | time | avg_fail_result |
      | 10        | 100        | 10   | 63              |
      | 0         | 100        | 10   | 0               |
      | 30        | 60         | 6    | 57              |
      | 20        | 80         | 8    | 69              |
