namespace CalculatorEngine;

public class CalculatorLogic
{
    public static double AddTwoNumbers(double inputA, double inputB) 
    {
        return inputA + inputB;
    }

    public static double SubtractTwoNumbers(double inputA, double inputB)
    {
        return inputA - inputB;
    }
    
    public static double MultiplyTwoNumbers(double inputA, double inputB)
    {
        return inputA * inputB;
    }

    public static double DivideTwoNumbers(double inputA, double inputB)
    {
        if (inputB == 0)
        {
            //return ;
        }
        return inputA / inputB;
    }

    //Rounding to the 8th decimal point before returning a value
    public static int CompareTwoNumbers(double inputA, double inputB)
    { 
        double validDifference = Math.Pow(10, -9); 
        double absoluteValueOfDiff = Math.Abs(inputA - inputB); //Absolute value of this difference. This way we consider the magnitude of difference, regardless of positive or negative.
        bool isWithinValidDifference = absoluteValueOfDiff <= validDifference; //if the difference is less than or equal to the accepted difference this bool is true.
            if(isWithinValidDifference)
            {
                return 1;
            }

            return 0;
    }

    public static double PowerFunction(double inputA, double inputB)
    {
        return Math.Pow(inputA, inputB);
    }

    //It is not required to calculate the factorial of a double so all inputs of this method will be integers.
    public static double FactorialOfDouble(double inputA) //This also needs to be changed to handle a negat
    {
        if (inputA < 0)
        {
            double answerOfNegativeFactorial = 1;
            for (double i = inputA; i <= -1; i++)
            {
                answerOfNegativeFactorial *= i;
            }
            return answerOfNegativeFactorial;
        }
        if (inputA is 1 or 0)
        {
            return 1;
        }
        return inputA * FactorialOfDouble(inputA - 1);
    }

    public static double SinOfDouble(double inputA)
    {
        return Math.Sin(inputA);
    }

    public static double CosOfDouble(double inputA)
    {
        return Math.Cos(inputA);
    }

    public static double TanOfDouble(double inputA)
    {
        return Math.Tan(inputA);
    }

    public static double InverseOfDouble(double inputA)
    {
        return (1 / inputA);
    }

    public static double LogOfTwoDoubles(double inputA, double inputB)
    {
        return Math.Log(inputA, inputB);
    }
    
    public static double RootOfTwoDoubles(double inputA, double inputB)
    {
        return Math.Pow(inputA, (1 / inputB));
    }
}