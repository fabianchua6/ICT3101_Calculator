namespace ICT3101_Calculator
{
    public class Calculator
    {
        // public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                // Return text for an incorrect option entry.
                // default:
                //     break;
            }

            return result;
        }

        public double Add(double num1, double num2)
        {
            // see if both numbers in String only contains 0 and 1s (binary)

            // convert num1 and num2 into string
            string num1String = num1.ToString("F0");
            string num2String = num2.ToString("F0");

            // check if num1 and num2 are binary
            if (num1String.All(c => c == '0' || c == '1') && num2String.All(c => c == '0' || c == '1'))
            {
                string concatenated = num1String + num2String;

                // Treat the concatenated string as a binary number and convert it to decimal
                int convertedResult = Convert.ToInt32(concatenated, 2);
                double result = Convert.ToDouble(convertedResult);

                return result;
            }

            return (num1 + num2);
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            // DividingZeroByZero
            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }

            // DividingByZeros
            if (num2 == 0)
            {
                return Double.PositiveInfinity;
            }

            // // throw exception when either is 0
            // if (num2 == 0 || num1 == 0)
            // {
            //     throw new ArgumentException("Numbers cannot be divided by zero!");
            // }

            return (num1 / num2);
        }

        // 15.
        public double Factorial(double num1)
        {
            // Handling negative numbers
            if (num1 < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            // Handling too big numbers
            if (num1 > 170) // 170! is approximately the largest factorial that can fit into a double
            {
                throw new ArgumentException("Factorial for this number is too large to fit into a double.");
            }

            // Base Cases
            if (num1 == 1 || num1 == 0)
                return 1;

            return num1 * Factorial(num1 - 1);
        }

        // 16a.
        public double AreaTriangle(double l, double h)
        {
            if (l < 0 || h < 0)
            {
                throw new ArgumentException("Length or height must not be negative");
            }


            if (l == 0 || h == 0)
            {
                throw new ArgumentException("Length or height must not be zero");
            }

            return (.5 * l * h);
        }

        // 16b.
        public double AreaCircle(double r)
        {
            if (r < 0)
            {
                throw new ArgumentException("Radius must not be negative");
            }

            return Math.PI * Math.Pow(r, 2);
        }

        // 17a.
        public double UnknownFunctionA(double num1, double num2)
        {
            // (5,4)
            // 120 
            // factorial(5) divided by num1 - num2
            if (num1 < num2)
                throw new ArgumentException("Number 1 cannot be smaller than Number 2");

            if (num1 < 0)
                throw new ArgumentException("Number 1 cannot be negative");

            var result = Factorial(num1) / Factorial(num1 - num2);

            return result;
        }

        // 17b.
        public double UnknownFunctionB(double num1, double num2)
        {
            // 3 factorial, 1 divide, 1 multiply, 1 subtract
            // num1 * f(n1-n2)

            if (num1 < num2)
                throw new ArgumentException("Number 1 cannot be smaller than Number 2");

            if (num1 < 0)
                throw new ArgumentException("Number 1 cannot be negative");

            var result = Factorial(num1) / (Factorial(num2) * Factorial(num1 - num2));

            return result;
        }

        // 2.2 17.
        public double MTBF(double MTTF, double MTTR)
        {
            // if either is negative
            if (MTTF < 0 || MTTR < 0)
            {
                throw new ArgumentException("MTTF or MTTR cannot be negative");
            }

            return (MTTF + MTTR);
        }

        public double Availability(double MTTF, double MTBF)
        {
            // if either is negative
            if (MTTF < 0 || MTBF < 0)
            {
                throw new ArgumentException("MTTF or MTBF cannot be negative");
            }

            return (MTTF / MTBF);
        }

        // 2.2 18.

        // init_fail(1 - avg_fail/total_fail)
        public double CurrentFailure(double initFail, double avgFail, double totalFail)
        {
            // round to 0 decimal places
            return Math.Round(initFail * (1 - avgFail / totalFail), 0);
        }

        // total_fail(1-exp(init_fail*time/total_fail)
        public double AvgExpectedFailure(double initFail, double totalFail, double time)
        {
            return Math.Round(initFail * (1 - Math.Exp(-totalFail * time / totalFail)), 0);
        }
    }
}