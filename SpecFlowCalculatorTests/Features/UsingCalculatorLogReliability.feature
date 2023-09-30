Feature: UsingCalculatorLogReliability
In order to calculate the Log Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

    @LogReliability
    Scenario: Calculating current log failure intensity
        Given I have a calculator
        When I have entered <fail_intens>, <init_fail> and <avg_fail> into the calculator and press LogCurrentFailure
        Then the current log failure intensity result should be <log_curr_fail_result>

    Examples:
      | fail_intens | init_fail | avg_fail | log_curr_fail_result |
      | 0.02        | 10        | 50       | 3.68                 |
      | 0.04        | 20        | 60       | 1.81                 |

    @BasicReliability
    Scenario: Calculating average log expected failure
        Given I have a calculator
        When I have entered <fail_intens>, <init_fail> and <time> into the calculator and press LogAverageFailure
        Then the average log expected failure result should be <log_avg_fail_result>

    Examples:
      | fail_intens | init_fail | time | log_avg_fail_result |
      | 10          | 100       | 10   | 0.92                |
      | 30          | 60        | 6    | 0.31                |
      | 20          | 80        | 8    | 0.47                |